using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Models.Enity;
using WebApplication1.Models.Query;
using static WebApplication1.Models.Enum;

namespace WebApplication1.Manage
{
    public class AccountManage
    {
        private readonly PortfolioContext _Context;
        public AccountManage(PortfolioContext _context) 
        {
            _Context = _context;
        }
        public IEnumerable<UserData> QueryUser(QueryUser _query)
        {

            var qry = _Context.Users.Where(m => _Context.DISPLAY_STATUS.Contains(m.DataState));
            if (_query.UserPK.HasValue)
                qry = qry.Where(m => m.UserPK == _query.UserPK.Value);
            if (string.IsNullOrWhiteSpace(_query.UserAccount) )
                qry = qry.Where(m => m.UserAccount == _query.UserAccount);
            if (string.IsNullOrWhiteSpace(_query.UserIDNO))
                qry = qry.Where(m => m.UserIDNO == _query.UserIDNO);
            if (string.IsNullOrWhiteSpace(_query.UserName))
                qry = qry.Where(m => m.UserName.Contains(_query.UserName) );

            return qry;
        }

        public DBReturnResult InsertUser(UserData _user) 
        {
            UserData data = _Context.Users.Where(m => m.UserPK == _user.UserPK).FirstOrDefault();
            if(data != null)
                return DBReturnResult.Fall;

            _user.CreateDate = DateTime.Now;
            _user.CreateUserPK = 1;
            _Context.Add(_user);
            _Context.SaveChanges();

            return DBReturnResult.Succese;
        }

        public DBReturnResult UpdateUser(UserData _user)
        {
            UserData data = _Context.Users.Where(m => m.UserPK == _user.UserPK).FirstOrDefault();
            if (data == null)
                return DBReturnResult.Fall;

            _Context.Entry(data).CurrentValues.SetValues(_user);
            data.ChangedDate = DateTime.Now;
            data.ChangedUserPK = 1;
            _Context.SaveChanges();

            return DBReturnResult.Succese;
        }

        public DBReturnResult DeleteUser(long _userPK)
        {
            UserData data = _Context.Users.Where(m => m.UserPK == _userPK).FirstOrDefault();
            if (data == null)
                return DBReturnResult.Fall;

            data.ChangedDate = DateTime.Now;
            data.ChangedUserPK = 1;
            data.DataState = DataStatus.Deleted;
            _Context.SaveChanges();

            return DBReturnResult.Succese;
        }
    }
}

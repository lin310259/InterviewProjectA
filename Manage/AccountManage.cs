using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Models.Enity;
using WebApplication1.Models.Query;

namespace WebApplication1.Manage
{
    public class AccountManage
    {
        private readonly PortfolioContext _Context;
        public AccountManage(PortfolioContext _context) 
        {
            _Context = _context;
        }
        public IEnumerable<User> QueryUser(QueryUser _query)
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


    }
}

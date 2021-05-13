using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Manage;
using WebApplication1.Models.Enity;
using WebApplication1.Models.Query;
using static WebApplication1.Models.Enum;

namespace WebApplication1.Controllers
{
    
    public class AccountController : Controller
    {
        private readonly AccountManage _Account_Manage;
        public AccountController(AccountManage _account_manage)
        {
            _Account_Manage = _account_manage;
        }
        public IActionResult UserList()
        {
            return View();
        }

        [HttpPost]
        public JsonResult GetUserList(QueryUser _query)
        {
            List<UserData> list = _Account_Manage.QueryUser(_query).ToList();
            return Json(list);
        }

        [HttpPost]
        public JsonResult SaveUserList(UserData _user)
        {
            DBReturnResult result = DBReturnResult.Fall;
            UserData data = _Account_Manage.QueryUser(new QueryUser() { UserPK = _user.UserPK}).FirstOrDefault();
            if (data == null)
                result = _Account_Manage.InsertUser(_user);
            else
                result = _Account_Manage.UpdateUser(_user);

            if(result == DBReturnResult.Succese)
                return Json("Succese");

            return Json("Fail");
        }

        [HttpPost]
        public JsonResult DeleteUserList(long _userPK)
        {
            DBReturnResult result = DBReturnResult.Fall;
            UserData data = _Account_Manage.QueryUser(new QueryUser() { UserPK = _userPK }).FirstOrDefault();
            if (data != null) {
                result = _Account_Manage.DeleteUser(_userPK);

                if (result == DBReturnResult.Succese)
                    return Json("Succese");
            }
            return Json("Fail");
        }
    }
}

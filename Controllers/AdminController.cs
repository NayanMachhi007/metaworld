using Meta_Ads_World.Data;
using Meta_Ads_World.Models;
using Meta_Ads_World.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Meta_Ads_World.Controllers
{
    public class AdminController : Controller
    {
        private readonly DataContext _datacontext;
        private readonly UserRepository _userrepository;

        public AdminController(DataContext datacontext)
        {
            _datacontext = datacontext;
            _userrepository = new UserRepository(_datacontext);
        }


        public IActionResult index()
        {
            return View();
        }

        //User Status List
        public IActionResult userstatuslist()
        {
            UserModelList user = new UserModelList();
            user.UserList = _userrepository.UserList();
            return View(user);
        }



        //Json UsrGetStatus
        public JsonResult UserGetStatus(int getid,Boolean getstatus)
        {
            var data = _datacontext.UserMsts.Where(x => x.userid == getid).FirstOrDefault();
            if (data != null)
            {
                data.status = getstatus;
                _datacontext.UserMsts.Update(data);
                _datacontext.SaveChanges();
            }
            return Json(data);
        }       
    }
}

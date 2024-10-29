using Meta_Ads_World.Data;
using Meta_Ads_World.Models;
using Meta_Ads_World.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Meta_Ads_World.Controllers
{
    public class AdminController : Controller
    {
        private readonly DataContext _datacontext;
        private readonly UserRepository _userrepository;
        private readonly BrandSocialCategoryRepository _brandSocialCategoryRepository;


        public AdminController(DataContext datacontext)
        {
            _datacontext = datacontext;
            _userrepository = new UserRepository(_datacontext);
            _brandSocialCategoryRepository= new BrandSocialCategoryRepository(_datacontext);
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

        //Brand Social Category List 
        public IActionResult brandsocialinstacategorylist()
        {
            InstaPostModelList insta = new InstaPostModelList();
            insta.InstaPostList = _brandSocialCategoryRepository.InstaPostList();
            return View(insta);
        }


        //Instagram Post Budget Add
        [HttpGet]
        public IActionResult instapostbudgetadd()
        {
            InstaPostBudgetModelList insta = new InstaPostBudgetModelList();
            insta.instaPostBudgetModelLists = _brandSocialCategoryRepository.instagrampostbudgetlist();
            return View(insta);
            
        }

        [HttpPost]
        public IActionResult instapostbudgetadd(InstaPostBudgetModelList instabudget)
        {
            _brandSocialCategoryRepository.instagrampostbudgetadd(instabudget);
            return RedirectToAction("instapostbudgetadd");
        }

        //Instagram Post Budget Edit
        [HttpGet]
        public IActionResult instapostbudgetedit(int id)
        {
            var data = _brandSocialCategoryRepository.instagrambudgetdetails(id);
            return View(data);
        }

        [HttpPost]
        public IActionResult instapostbudgetedit(InstaPostBudgetModelList instaedit)
        {
           _brandSocialCategoryRepository.instagrambudgetedit(instaedit);
            return RedirectToAction("instapostbudgetadd");
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

using Meta_Ads_World.Data;
using Meta_Ads_World.Models;
using Meta_Ads_World.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;
using System.Diagnostics;

namespace Meta_Ads_World.Controllers
{
    public class VisitorController : Controller
    {
        private readonly DataContext _datacontext;
        private readonly UserRepository _userRepository;
        private readonly BrandRepository _brandrepository;
        private readonly BrandSocialCategoryRepository _brandsocialcategoryrepository;

        public VisitorController(DataContext datacontext)
        {
            _datacontext = datacontext;
            _userRepository = new UserRepository(_datacontext);
            _brandrepository = new BrandRepository(_datacontext);
            _brandsocialcategoryrepository = new BrandSocialCategoryRepository(_datacontext);
        }

        public IActionResult Index()
        {
            return View();
        }


        //User Registration Add
        [HttpGet]
        public IActionResult userregistrationadd(string id)
        {
            UserModelList user = new UserModelList();
            var data = _datacontext.UserMsts.Where(x => x.urefreallcode == id).FirstOrDefault();
            if (data != null)
            {
                user.urefreallid = data.userid;
            }
            return View(user);
        }

        [HttpPost]
        public IActionResult userregistrationadd(UserModelList useradd)
        {
            _userRepository.UserRegistrationAdd(useradd);
            return RedirectToAction("userregistrationadd");
        }

        public IActionResult login()
        {
            return View();
        }

        //User Account Details
        [HttpGet]
        public IActionResult useraccountdetails()
        {
            int id = 1;
            UserModelList userdetails = new UserModelList();
            var data = _datacontext.UserMsts.Find(id);
            userdetails.UserList = _userRepository.UserRefreallList();

            userdetails.userid = data.userid;
            userdetails.ufname = data.ufname;
            userdetails.ulname = data.ulname;
            userdetails.uemail = data.uemail;
            userdetails.urefreallcode = data.urefreallcode;

            return View(userdetails);
        }

        public IActionResult visitorlogin()
        {
            return View();
        }

        public IActionResult history()
        {
            return View();
        }

        //User Account
        [HttpGet]
        public IActionResult usersettings()
        {
            int id = 1;
            UserModelList user = new UserModelList();
            var data = _datacontext.UserMsts.Find(id);
            user.userid = data.userid;
            user.uemail = data.uemail;
            user.uconfirmemail = data.uconfirmemail;
            user.upassword = data.upassword;
            user.uconfirmpassword = data.uconfirmpassword;

            return View(user);
        }

        //Brand Registration
        public IActionResult brandregistraionadd()
        {

            return View();
        }

        [HttpPost]
        public IActionResult brandregistraionadd(BrandRegistrationModelList bradregisadd)
        {
            _brandrepository.BrandRegistrationAdd(bradregisadd);
            return RedirectToAction("brandregistraionadd");
        }

        //User Account
        [HttpPost]
        public IActionResult usersettings(UserModelList useredit)
        {
            _userRepository.UserRegistrationSettings(useredit);
            return RedirectToAction("usersettings");
        }

        //Instagram Post
        [HttpGet]
        public IActionResult instagrampost()
        {
            InstaPostModelList insta = new InstaPostModelList();
            insta.InstaPostList = _brandsocialcategoryrepository.InstaPostList();
            return View(insta);
        }

        //Brand Instagram Post Get Method
        [HttpGet]
        public IActionResult brandinstapostadd()
        {
            int id = 1;
            InstaPostModelList insta = new InstaPostModelList();
            var data = _datacontext.InstaPostBudgetMst.Where(x => x.instapostbudgetid == id).FirstOrDefault();
            insta.instalikebudget = data.instalikebudget;
            insta.instacommentbudget = data.instacommentbudget;
            insta.instasharebudget = data.instasharebudget;
            insta.instasavebudget = data.instasavebudget;
            return View(insta);
        }


        //Brand Instagram Post Post Method
        [HttpPost]
        public IActionResult brandinstapostadd(InstaPostModelList instaadd)
        {
            _brandsocialcategoryrepository.instagrampostadd(instaadd);
            return RedirectToAction("brandinstapostadd");
        }

        [HttpGet]
        public IActionResult brandfilter()
        {
            return View();
        }



        //Json Like 
        public JsonResult instalike(int id, int like)
        {
            int temp = 1;
            like += temp;
            var data = _datacontext.InstaPostMsts.Where(x => x.instapostid == id).FirstOrDefault();
            if (data != null)
            {
                data.instaposttotallike = like.ToString();
                _datacontext.InstaPostMsts.Update(data);
                _datacontext.SaveChanges();
            }

            return Json(data);

        }

        //Json Comment
        public JsonResult instacomment(int getid)
        {
            var data = _datacontext.InstaPostMsts.Where(x => x.instapostid == getid).ToList();
            return Json(data);
        }


    }
}

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

        public VisitorController(DataContext datacontext)
        {
            _datacontext = datacontext;
            _userRepository = new UserRepository(_datacontext);
            _brandrepository=new BrandRepository(_datacontext);
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
            var data = _datacontext.UserMsts.Where(x=>x.urefreallcode==id).FirstOrDefault();
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
            userdetails.ufname=data.ufname;
            userdetails.ulname = data.ulname;
            userdetails.uemail=data.uemail;
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

        [HttpGet]
        public IActionResult brandsocialinstagram()
        {
            return View();
        }
        
        //User Account
        [HttpPost]
        public IActionResult usersettings(UserModelList useredit)
        {
            _userRepository.UserRegistrationSettings(useredit);
            return RedirectToAction("usersettings");
        }


    }
}

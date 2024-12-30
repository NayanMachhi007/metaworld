using Meta_Ads_World.Data;
using Meta_Ads_World.Models;
using Meta_Ads_World.Repository;
using Microsoft.AspNetCore.Mvc;

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
            //user.citylist = _datacontext.CityMsts.ToList();
            //user.arealist = _datacontext.AreaMsts.ToList();
            return View(user);
        }

        [HttpPost]
        public IActionResult userregistrationadd(UserModelList useradd)
        {
            if (ModelState.IsValid)
            {
                _userRepository.UserRegistrationAdd(useradd);
                return RedirectToAction("userregistrationadd");
            }
            return View();

        }

        [HttpGet]
        public IActionResult userlogin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult userlogin(UserModel userlogin)
        {
            var email = userlogin.uemail;
            var password = userlogin.upassword;
            var data = _datacontext.UserMsts.Where(x => x.uemail == email && x.upassword == password).FirstOrDefault();
            if (data != null)
            {
                return RedirectToAction("visitorlogin");
            }
            return RedirectToAction("userregistrationadd");
        }
      
        public IActionResult brandindex()
        {
            return View();
        }


        //User Account Details
        [HttpGet]
        public IActionResult useraccountdetails()
        {
            int id = 1;
            UserModelList userdetails = new UserModelList();
            userdetails.UserList = _userRepository.UserRefreallList();
            var data = _datacontext.UserMsts.Find(id);
            userdetails.userid = data.userid;
            userdetails.ufname = data.ufname;
            userdetails.profilepicture = data.profilepicture;
            userdetails.ufname = data.ufname;
            userdetails.uemail = data.uemail;
            userdetails.contactno = data.contactno;
            userdetails.urefreallcode = data.urefreallcode;

            return View(userdetails);
        }

        [HttpGet]
        public IActionResult visitorlogin()
        {
            UserModelList user = new UserModelList();
            user.InstaPostList = _datacontext.InstaPostMsts.ToList();
            user.YouTubePostList = _datacontext.YouTubePostMst.ToList();
            return View(user);
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
            user.UserList = _userRepository.UserRefreallList();
            var data = _datacontext.UserMsts.Find(id);
            user.userid = data.userid;
            user.uemail = data.uemail;
            user.upassword = data.upassword;
            user.ufname = data.ufname;
            user.profilepicture = data.profilepicture;

            return View(user);
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


        //Youtube Post
        [HttpGet]
        public IActionResult youtubepost()
        {
            YoutTubePostModelList youtube = new YoutTubePostModelList();
            youtube.YouTubeList = _brandsocialcategoryrepository.YoutubePostModelList();
            return View(youtube);
        }






        //Json Like 
        public JsonResult instalike(int id, int like)

        {
            int temp = 1;

            var data = _datacontext.InstaPostMsts.Where(x => x.instapostid == id).FirstOrDefault();
            if (data != null)
            {
                like += temp;
                data.instaposttotallike = like.ToString();
                _datacontext.InstaPostMsts.Update(data);
                _datacontext.SaveChanges();
            }

            else
            {
                like = temp;
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

        //Json Youtube Like 
        public JsonResult youtubelike(int id, int like)
        {
            int temp = 1;
            like += temp;
            var data = _datacontext.YouTubePostMst.Where(x => x.youtubepostid == id).FirstOrDefault();
            if (data != null)
            {
                data.youtubeposttotallike = like.ToString();
                _datacontext.YouTubePostMst.Update(data);
                _datacontext.SaveChanges();
            }

            return Json(data);

        }



        //Json Comment
        public JsonResult youtubecomment(int getid)
        {
            var data = _datacontext.YouTubePostMst.Where(x => x.youtubepostid == getid).ToList();
            return Json(data);
        }





    }
}

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


        [HttpGet]
        public IActionResult brandlogin()
        {
            return View();
        }


        [HttpPost]
        public IActionResult brandlogin(BrandRegistrationModel brandadd)
        {
            var email = brandadd.bemail;
            var password = brandadd.bpassword;

            var data = _datacontext.BrandRegistrationMst.Where(x=>x.bemail == email && x.bpassword == password).FirstOrDefault();
            if (data != null)
            {
                return RedirectToAction("brandindex");
            }
            return RedirectToAction("brandregistrationadd");
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
            var data = _datacontext.UserMsts.Find(id);
            userdetails.UserList = _userRepository.UserRefreallList();

            userdetails.userid = data.userid;
            userdetails.ufname = data.ufname;
            userdetails.ulname = data.ulname;
            userdetails.uemail = data.uemail;
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
            var data = _datacontext.UserMsts.Find(id);
            user.userid = data.userid;
            user.uemail = data.uemail;
            user.upassword = data.upassword;

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


        //Youtube Post
        [HttpGet]
        public IActionResult youtubepost()
        {
            YoutTubePostModelList youtube = new YoutTubePostModelList();
            youtube.YouTubeList = _brandsocialcategoryrepository.YoutubePostModelList();
            return View(youtube);
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
            if (ModelState.IsValid)
            {
                _brandsocialcategoryrepository.instagrampostadd(instaadd);
                return RedirectToAction("brandinstapostadd");
            }
            int id = 1;
            InstaPostModelList insta = new InstaPostModelList();
            var data = _datacontext.InstaPostBudgetMst.Where(x => x.instapostbudgetid == id).FirstOrDefault();
            insta.instalikebudget = data.instalikebudget;
            insta.instacommentbudget = data.instacommentbudget;
            insta.instasharebudget = data.instasharebudget;
            insta.instasavebudget = data.instasavebudget;
            return View(insta);

        }

        //Brand Youtube Post Get Method
        [HttpGet]
        public IActionResult brandyoutubepostadd()
        {

            int id = 1;
            YoutTubePostModelList youtube = new YoutTubePostModelList();
            var data = _datacontext.youTubePostBudgetMsts.Where(x => x.youtubepostbudgetid == id).FirstOrDefault();
            youtube.youtubelikebudget = data.youtubelikebudget;
            youtube.youtubecommentbudget = data.youtubecommentbudget;
            youtube.youtubesharebudget = data.youtubesharebudget;
            youtube.youtubesavebudget = data.youtubesavebudget;
            return View(youtube);
        }


        //Brand Youtube Post Post Method
        [HttpPost]
        public IActionResult brandyoutubepostadd(YoutTubePostModelList youtubeadd)
        {
            if (ModelState.IsValid)
            {
                _brandsocialcategoryrepository.youtubepostadd(youtubeadd);
                return RedirectToAction("brandyoutubepostadd");
            }
            int id = 1;
            YoutTubePostModelList youtube = new YoutTubePostModelList();
            var data = _datacontext.youTubePostBudgetMsts.Where(x => x.youtubepostbudgetid == id).FirstOrDefault();
            youtube.youtubelikebudget = data.youtubelikebudget;
            youtube.youtubecommentbudget = data.youtubecommentbudget;
            youtube.youtubesharebudget = data.youtubesharebudget;
            youtube.youtubesavebudget = data.youtubesavebudget;
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

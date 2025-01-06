using Meta_Ads_World.Data;
using Meta_Ads_World.Models;
using Meta_Ads_World.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Meta_Ads_World.Controllers
{
    public class VisitorController : Controller
    {
        private readonly DataContext _dacontext;
        private readonly UserRepository _userRepository;
        private readonly BrandSocialCategoryRepository _brandSocialCategoryRepository;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public VisitorController(DataContext dacontext, IWebHostEnvironment webHostEnvironment)
        {
            _dacontext = dacontext;
            _userRepository = new UserRepository(_dacontext);
            _brandSocialCategoryRepository = new BrandSocialCategoryRepository(_dacontext, webHostEnvironment);
            _webHostEnvironment = webHostEnvironment;
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
            var data = _dacontext.UserMsts.Where(x => x.urefreallcode == id).FirstOrDefault();
            if (data != null)
            {
                user.urefreallid = data.userid;
            }
            //user.citylist = _dacontext.CityMsts.ToList();
            //user.arealist = _dacontext.AreaMsts.ToList();
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
            var data = _dacontext.UserMsts.Where(x => x.uemail == email && x.upassword == password).FirstOrDefault();
            if (data != null)
            {
                return RedirectToAction("userdesk");
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
            var data = _dacontext.UserMsts.Find(id);
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
        public IActionResult userdesk(int id)
        {

            InstaPostModelList insta = new InstaPostModelList();
            insta.InstaPostList = _brandSocialCategoryRepository.AdminPaymentRequestInstaPostList();

            return View(insta);
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
            var data = _dacontext.UserMsts.Find(id);
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
            insta.InstaPostList = _brandSocialCategoryRepository.InstaPostList();
            return View(insta);
        }


        //Youtube Post
        [HttpGet]
        public IActionResult youtubepost()
        {
            YoutTubePostModelList youtube = new YoutTubePostModelList();
            youtube.YouTubeList = _brandSocialCategoryRepository.YoutubePostModelList();
            return View(youtube);
        }


        //Instagram Post Details
        [HttpGet]
        public IActionResult instapostdetails(int id)
        {
            int visitoruserid = 1;
            var data = (from brand in _dacontext.UserMsts
                        join insta in _dacontext.InstaPostMsts on brand.userid equals insta.instabranduserid
                        select new
                        {
                            userid = brand.userid,
                            username = brand.ufname,
                            instapostid = insta.instapostid,
                            instaposturl = insta.instaposturl,
                            instacommentstatus = insta.instapostcommentstatus,
                            instasharestatus = insta.instagrampostsharestatus,
                            instasavestatus = insta.instapostsavestatus,
                            counter = insta.counter,
                        }).ToList();
            var finddata = data.Where(x => x.instapostid == id).FirstOrDefault();

            InstagramPostUserHandlerDataModel user = new InstagramPostUserHandlerDataModel();
            user.userid = visitoruserid;
            user.username = finddata.username;
            user.instapostid = finddata.instapostid;
            user.instaposturl = finddata.instaposturl;
            user.instacommentstatus = finddata.instacommentstatus;
            user.instasavestatus = finddata.instasavestatus;
            user.counter = finddata.counter;
            return View(user);
        }

        [HttpPost]
        public IActionResult instapostdetails(InstagramPostUserHandlerDataModel add)
        {
            string instalike = add.instalike;
            string instashare = add.instashare;
            string instasave = add.instasave;
            if (instalike == "true")
            {
                instalike = "1";
            }
            else
            {
                instalike = "0";
            }

            if (instashare == "true")
            {
                instashare = "1";
            }
            else
            {
                instashare = "0";
            }
            if (instasave == "true")
            {
                instasave = "1";
            }
            else
            {
                instasave = "0";
            }
            UserInstaPostHandlerMst dataadd = new UserInstaPostHandlerMst()
            {
                userid = add.userid,
                instapostid = add.instapostid,
                instalike = instalike,
                instashare = instashare,
                instasave = instasave,
                instacomment = add.instacomment,
            };
            _dacontext.UserInstaPostHandlerMsts.Add(dataadd);
            _dacontext.SaveChanges();
            return RedirectToAction("instapostdetails");
        }

        //Json Like 
        public JsonResult instalike(int id, int like)
        {
            int temp = 1;

            var data = _dacontext.InstaPostMsts.Where(x => x.instapostid == id).FirstOrDefault();
            if (data != null)
            {
                like += temp;
                data.instaposttotallike = like.ToString();
                _dacontext.InstaPostMsts.Update(data);
                _dacontext.SaveChanges();
            }

            else
            {
                like = temp;
                data.instaposttotallike = like.ToString();
                _dacontext.InstaPostMsts.Update(data);
                _dacontext.SaveChanges();
            }

            return Json(data);

        }



        //Json Comment
        public JsonResult instacomment(int getid)
        {
            var data = _dacontext.InstaPostMsts.Where(x => x.instapostid == getid).ToList();
            return Json(data);
        }

        //Json Youtube Like 
        public JsonResult youtubelike(int id, int like)
        {
            int temp = 1;
            like += temp;
            var data = _dacontext.YouTubePostMst.Where(x => x.youtubepostid == id).FirstOrDefault();
            if (data != null)
            {
                data.youtubeposttotallike = like.ToString();
                _dacontext.YouTubePostMst.Update(data);
                _dacontext.SaveChanges();
            }

            return Json(data);

        }



        //Json Comment
        public JsonResult youtubecomment(int getid)
        {
            var data = _dacontext.YouTubePostMst.Where(x => x.youtubepostid == getid).ToList();
            return Json(data);
        }


        [HttpPost]
        //Json UserHandlerData
        public JsonResult userhandlerlikeadd(int id, string like, string comment, string share, string save, int userid)
        {
            return Json(userhandlerlikeadd);
        }

        [HttpPost]
        public JsonResult instacounter(int id,int counterid)
        {
            int temp = 1;
            counterid += temp;
            var data = _dacontext.InstaPostMsts.Where(x => x.instapostid == id).FirstOrDefault();
            if (data != null)
            {
                data.counter = counterid;
                _dacontext.InstaPostMsts.Update(data);
                _dacontext.SaveChanges();
                return Json(data);
            }

            return Json(null);
        }
    }
}


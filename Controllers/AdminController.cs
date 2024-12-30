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
        private readonly AdminRepository _adminRepository;


        public AdminController(DataContext datacontext)
        {
            _datacontext = datacontext;
            _userrepository = new UserRepository(_datacontext);
            _brandSocialCategoryRepository = new BrandSocialCategoryRepository(_datacontext);
            _adminRepository = new AdminRepository(_datacontext);
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

        //Brand Social Instagram Category List 
        public IActionResult brandsocialinstacategorylist()
        {
            InstaPostModelList insta = new InstaPostModelList();
            insta.InstaPostList = _brandSocialCategoryRepository.InstaPostList();
            return View(insta);
        }

        //Brand Social Instagram Category List 
        public IActionResult brandsocialyoutubecategorylist()
        {
            YoutTubePostModelList youtube = new YoutTubePostModelList();
            youtube.YouTubeList = _brandSocialCategoryRepository.YoutubePostModelList();
            return View(youtube);
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


        //Youtube Post Budget Add
        [HttpGet]
        public IActionResult youtubepostbudgetadd()
        {
            YouTubePostBudgetModeliList youtube = new YouTubePostBudgetModeliList();
            youtube.youTubePostBudgetModeliLists = _brandSocialCategoryRepository.youtubepostbudgetlist();
            return View(youtube);
        }

        [HttpPost]
        public IActionResult youtubepostbudgetadd(YouTubePostBudgetModeliList youtubebudget)
        {
            _brandSocialCategoryRepository.youtubepostbudgetadd(youtubebudget);
            return RedirectToAction("youtubepostbudgetadd");
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

        //YouTube Post Budget Edit
        [HttpGet]
        public IActionResult youtubepostbudgetedit(int id)
        {
            var data = _brandSocialCategoryRepository.youtubebudgetdetails(id);
            return View(data);
        }

        [HttpPost]
        public IActionResult youtubepostbudgetedit(YouTubePostBudgetModeliList youtubeedit)
        {
            _brandSocialCategoryRepository.youtubebudgetedit(youtubeedit);
            return RedirectToAction("youtubepostbudgetadd");
        }



        [HttpGet]
        public IActionResult stateadd()
        {
            StateModelList state = new StateModelList();
            state.statelist = _adminRepository.StateList();
            return View(state);
        }

        [HttpPost]
        public IActionResult stateadd(StateModelList stateadd)
        {
            _adminRepository.StateAdd(stateadd);
            return RedirectToAction("stateadd");
        }


        [HttpGet]
        public IActionResult cityadd()
        {
            CityModelList city = new CityModelList();
            city.StateMstList = _datacontext.StateMsts.ToList();
            city.CityList = _adminRepository.citylist();
            return View(city);

        }

        [HttpPost]
        public IActionResult cityadd(CityModelList cityadd)
        {
            _adminRepository.CityAdd(cityadd);
            return RedirectToAction("cityadd");
        }

        [HttpGet]
        public IActionResult areaadd()
        {
            AreaModelList area = new AreaModelList();
            area.citylist = _datacontext.CityMsts.ToList();
            area.arealist = _adminRepository.arealist();
            return View(area);

        }

        [HttpPost]
        public IActionResult areaadd(AreaModelList area)
        {
            _adminRepository.areaadd(area);
            return RedirectToAction("areaadd");
        }


        //Json UsrGetStatus
        public JsonResult UserGetStatus(int getid, Boolean getstatus)
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

        //Brand Insta Like Status
        [HttpPost]
        public JsonResult instalikestatus(int id, Boolean status)
        {
            var data = _datacontext.InstaPostMsts.Where(x => x.instapostid == id).FirstOrDefault();
            if (data != null)
            {
                data.instapostlikestatus = status;
                _datacontext.InstaPostMsts.Update(data);
                _datacontext.SaveChanges();
            }
            return Json(data);
        }


        //Brand Insta Share Status
        [HttpPost]
        public JsonResult instasharestatus(int id, Boolean status)
        {
            var data = _datacontext.InstaPostMsts.Where(x => x.instapostid == id).FirstOrDefault();
            if (data != null)
            {
                data.instagrampostsharestatus = status;
                _datacontext.InstaPostMsts.Update(data);
                _datacontext.SaveChanges();
            }
            return Json(data);
        }

        //Brand Insta Save Status
        [HttpPost]
        public JsonResult instasavestatus(int id, Boolean status)
        {
            var data = _datacontext.InstaPostMsts.Where(x => x.instapostid == id).FirstOrDefault();
            if (data != null)
            {
                data.instapostsavestatus = status;
                _datacontext.InstaPostMsts.Update(data);
                _datacontext.SaveChanges();
            }
            return Json(data);
        }

        //Brand Youtube Like Status
        [HttpPost]
        public JsonResult youtubelikestatus(int id, Boolean status)
        {
            var data = _datacontext.YouTubePostMst.Where(x => x.youtubepostid == id).FirstOrDefault();
            if (data != null)
            {
                data.youtubepostlikestatus = status;
                _datacontext.YouTubePostMst.Update(data);
                _datacontext.SaveChanges();
            }
            return Json(data);
        }


        //Brand Insta Share Status
        [HttpPost]
        public JsonResult youtubesharestatus(int id, Boolean status)
        {
            var data = _datacontext.YouTubePostMst.Where(x => x.youtubepostid == id).FirstOrDefault();
            if (data != null)
            {
                data.youtubepostsharestatus = status;
                _datacontext.YouTubePostMst.Update(data);
                _datacontext.SaveChanges();
            }
            return Json(data);
        }

        //Brand Insta Save Status
        [HttpPost]
        public JsonResult youtubesavestatus(int id, Boolean status)
        {
            var data = _datacontext.YouTubePostMst.Where(x => x.youtubepostid == id).FirstOrDefault();
            if (data != null)
            {
                data.youtubepostsavestatus = status;
                _datacontext.YouTubePostMst.Update(data);
                _datacontext.SaveChanges();
            }
            return Json(data);
        }

        [HttpPost]
        public JsonResult InstaBudgetStatus(int id, Boolean status)
        {
            var data = _datacontext.InstaPostBudgetMst.Where(x => x.instapostbudgetid == id).FirstOrDefault();
            if (data != null)
            {
                data.status = status;
                _datacontext.InstaPostBudgetMst.Update(data);
                _datacontext.SaveChanges();

                return Json(data);
            }

            return Json(null);
        }


        [HttpPost]
        public JsonResult YoutubeBudgetStatus(int id, Boolean status)
        {
            var data = _datacontext.youTubePostBudgetMsts.Where(x => x.youtubepostbudgetid == id).FirstOrDefault();
            if (data != null)
            {
                data.status = status;
                _datacontext.youTubePostBudgetMsts.Update(data);
                _datacontext.SaveChanges();

                return Json(data);
            }

            return Json(null);
        }
    }
}

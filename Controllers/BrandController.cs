using Meta_Ads_World.Data;
using Meta_Ads_World.Models;
using Meta_Ads_World.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Meta_Ads_World.Controllers
{
    public class BrandController : Controller
    {

        private readonly DataContext _datacontext;
        public readonly UserRepository _userRepository;
        private readonly BrandRepository _brandrepository;
        public readonly BrandSocialCategoryRepository _brandsocialcategoryrepository;

        public BrandController(DataContext datacontext)
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

        //Brand Registration
        [HttpGet]
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
        public IActionResult brandlogin()
        {
            return View();
        }


        [HttpPost]
        public IActionResult brandlogin(BrandRegistrationModel brandadd)
        {
            var email = brandadd.bemail;
            var password = brandadd.bpassword;

            var data = _datacontext.BrandRegistrationMst.Where(x => x.bemail == email && x.bpassword == password).FirstOrDefault();
            if (data != null)
            {
                return RedirectToAction("brandindex");
            }
            return RedirectToAction("brandregistrationadd");
        }

        //Brand Instagram Post Get Method
        [HttpGet]
        public IActionResult brandinstapostadd()
        {
            Boolean status = true;
            InstaPostModelList insta = new InstaPostModelList();
            var data = _datacontext.InstaPostBudgetMst.FirstOrDefault(x => x.status == status);

            if (data != null)
            {
                insta.instalikebudget = data.instalikebudget;
                insta.instacommentbudget = data.instacommentbudget;
                insta.instasharebudget = data.instasharebudget;
                insta.instasavebudget = data.instasavebudget;
                return View(insta);
            }

            return View();
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

            Boolean status = true;
            YoutTubePostModelList youtube = new YoutTubePostModelList();
            var data = _datacontext.youTubePostBudgetMsts.Where(x => x.status == status).FirstOrDefault();
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




        //Json State
        [HttpPost]
        public JsonResult areaname(string statestring)
        {
            var data = _datacontext.AreaMsts.Where(x => x.areaname.Contains(statestring)).ToList();

            return Json(data);
        }


    }
}

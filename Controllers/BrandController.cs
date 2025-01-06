using Meta_Ads_World.Data;
using Meta_Ads_World.Models;
using Meta_Ads_World.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Meta_Ads_World.Controllers
{
    public class BrandController : Controller
    {

        private readonly DataContext _datacontext;
        private readonly BrandRepository _brandRepository;
        private readonly BrandSocialCategoryRepository _brandSocialCategoryRepository;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public BrandController(DataContext datacontext, IWebHostEnvironment webHostEnvironment)
        {
            _datacontext = datacontext;
            _brandRepository = new BrandRepository(_datacontext);
            _brandSocialCategoryRepository = new BrandSocialCategoryRepository(_datacontext, webHostEnvironment);
            _webHostEnvironment = webHostEnvironment;
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
            _brandRepository.BrandRegistrationAdd(bradregisadd);
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
        public IActionResult brandinstapostadd(int id)
        {
            id = 1;
            Boolean status = true;
            InstaPostModelList insta = new InstaPostModelList();
            var data = _datacontext.InstaPostBudgetMst.FirstOrDefault(x => x.status == status);

            if (data != null)
            {
                insta.instalikebudget = data.instalikebudget;
                insta.instacommentbudget = data.instacommentbudget;
                insta.instasharebudget = data.instasharebudget;
                insta.instasavebudget = data.instasavebudget;
                insta.instabranduserid = id;
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
                int id = 1;
                InstaPostMst insta = new InstaPostMst()
                {
                    instaposttotallike = instaadd.instaposttotallike,
                    instapostcomment = instaadd.instapostcomment,
                    instapostshare = instaadd.instapostshare,
                    instapostsave = instaadd.instapostsave,
                    instapoststartingdate = instaadd.instapoststartingdate,
                    instapostendingdate = instaadd.instapostendingdate,
                    instapostlikestatus = instaadd.instapostlikestatus,
                    instapostcommentstatus = instaadd.instapostcommentstatus,
                    instagrampostsharestatus = instaadd.instagrampostsharestatus,
                    instapostsavestatus = instaadd.instapostsavestatus,
                    instaposturl = instaadd.instaposturl,
                    posttotalbudget = instaadd.posttotalbudget,
                    instabranduserid = id,
                    instapoststatus = instaadd.instapoststatus,
                    counter = instaadd.counter,
                };
                _datacontext.InstaPostMsts.Add(insta);
                _datacontext.SaveChanges();

                int data = insta.instapostid;
               
                return RedirectToAction("paymentinsta", new { id = data});
            }

            return View();

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
                _brandSocialCategoryRepository.youtubepostadd(youtubeadd);
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


        [HttpGet]
        public IActionResult paymentinsta(int id)
        {
            BrandPaymentTransactionModelList datafind = new BrandPaymentTransactionModelList();
            Boolean status = true;
            var statusdata = _datacontext.QrMst.FirstOrDefault(x => x.status == status);
            if (statusdata != null)
            {
                datafind.qrid = statusdata.qrid;
                datafind.qrpath = statusdata.qrpath;
                datafind.status = statusdata.status;
                datafind.paymentinstaid = id;
            }


            return View(datafind);
        }

        [HttpPost]
        public IActionResult paymentinsta(BrandPaymentTransactionModel add)
        {
            _brandSocialCategoryRepository.brandpaymentadddata(add);
            return RedirectToAction("brandinstapostadd");
        }

        //Payment Add And transction Data
        [HttpGet]
        public IActionResult paymentdata(int getinstaid)
        {
            return View();
            
        }

        




        //Json State
        [HttpPost]
        public JsonResult areaname(string statestring)
        {
            var data = _datacontext.AreaMsts.Where(x => x.areaname.Contains(statestring)).ToList();

            return Json(data);
        }


        [HttpGet]
        public IActionResult UpdateData()
        {  

            return View();
        }

        [HttpPost]
        public IActionResult UpdateData(BrandRegistrationModel model)
        {

            TempData["alertupdate"] = "Data updated successfully!";

            return RedirectToAction("index");
        }





    }
}

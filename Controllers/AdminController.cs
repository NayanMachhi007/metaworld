using Meta_Ads_World.Data;
using Meta_Ads_World.Models;
using Meta_Ads_World.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Meta_Ads_World.Controllers
{
    public class AdminController : Controller
    {
        private readonly DataContext _dataContext;
        private readonly UserRepository _userRepository;
        private readonly BrandSocialCategoryRepository _brandSocialCategoryRepository;
        private readonly AdminRepository _adminrepository;
        private readonly IWebHostEnvironment _environment;

        public AdminController(DataContext dataContext, IWebHostEnvironment webHostEnvironment)
        {
            _dataContext = dataContext;
            _userRepository = new UserRepository(_dataContext);
            _brandSocialCategoryRepository = new BrandSocialCategoryRepository(_dataContext, webHostEnvironment);
            _adminrepository = new AdminRepository(_dataContext, webHostEnvironment);
            _environment = webHostEnvironment;

        }

        public IActionResult index()
        {
            return View();
        }

        //User Status List
        public IActionResult userstatuslist()
        {
            UserModelList user = new UserModelList();
            user.UserList = _userRepository.UserList();
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
            youtube.YouTubeList = _brandSocialCategoryRepository.AdminPaymentRequestYoutubePostModelList();
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
            state.statelist = _adminrepository.StateList();
            return View(state);
        }

        [HttpPost]
        public IActionResult stateadd(StateModelList stateadd)
        {
            _adminrepository.StateAdd(stateadd);
            return RedirectToAction("stateadd");
        }


        [HttpGet]
        public IActionResult cityadd()
        {
            CityModelList city = new CityModelList();
            city.StateMstList = _dataContext.StateMsts.ToList();
            city.CityList = _adminrepository.citylist();
            return View(city);

        }

        [HttpPost]
        public IActionResult cityadd(CityModelList cityadd)
        {
            _adminrepository.CityAdd(cityadd);
            return RedirectToAction("cityadd");
        }

        [HttpGet]
        public IActionResult areaadd()
        {
            AreaModelList area = new AreaModelList();
            area.citylist = _dataContext.CityMsts.ToList();
            area.arealist = _adminrepository.arealist();
            return View(area);

        }

        [HttpPost]
        public IActionResult areaadd(AreaModelList area)
        {
            _adminrepository.areaadd(area);
            return RedirectToAction("areaadd");
        }


        //Payment QR Add Method
        [HttpGet]
        public IActionResult qrcodeadd()
        {
            return View();
        }

        // Payment QR Add Method
        [HttpPost]
        public IActionResult qrcodeadd(QrCodeModel qrdata)
        {
            _adminrepository.qradd(qrdata);
            return RedirectToAction("qrcodelist");
        }

        [HttpGet]
        public IActionResult qrcodelist()
        {
            TempData["ShowingMessage"] = "Area Updated";

            QrCodeModelList list = new QrCodeModelList();
            list.qrlist = _adminrepository.qrcodelist();
            return View(list);
        }

        //Payment Method
        [HttpGet]
        public IActionResult payment()
        {
            QrCodeModel datafind = new QrCodeModel();
            Boolean status = true;
            var data = _dataContext.QrMst.Where(x => x.status == status).FirstOrDefault();
            if (data != null)
            {
                datafind.qrid = data.qrid;
                datafind.qrpath = data.qrpath;
                datafind.status = data.status;
            }
            return View(datafind);
        }

        //Json UsrGetStatus
        public JsonResult QRGetStatus(int getid, Boolean getstatus)
        {
            var data = _dataContext.QrMst.Where(x => x.qrid == getid).FirstOrDefault();
            if (data != null)
            {
                data.status = getstatus;
                _dataContext.QrMst.Update(data);
                _dataContext.SaveChanges();
            }
            return Json(data);
        }

        //Instagram Post Admin Request Reject of Accept
        [HttpGet]
        public IActionResult instapostrequest()
        {

            var data = (from brand in _dataContext.BrandRegistrationMst
                        join insta in _dataContext.InstaPostMsts on brand.id equals insta.instabranduserid
                        join payment in _dataContext.BrandPaymentTransactionMsts on insta.instapostid equals payment.paymentinstaid

                        select new
                        {
                            brandid = brand.id,
                            instapostid = insta.instapostid,
                            instaurl = insta.instaposturl,
                            instastatus = insta.instapoststatus,
                            paymentid = payment.transcationid,
                            paymentrecipt = payment.paymentrecipt
                        }).ToList();





            var itemdatalist = new List<InstaPostAdminModel>();
            foreach (var dataiteam in data)
            {
                InstaPostAdminModel list = new InstaPostAdminModel()
                {
                    brandid = dataiteam.brandid,
                    instapostid = dataiteam.instapostid,
                    instaurl = dataiteam.instaurl,
                    instastatus = dataiteam.instastatus,
                    paymentid = dataiteam.paymentid,
                    paymentrecipt = dataiteam.paymentrecipt
                };
                itemdatalist.Add(list);
            }

            return View(itemdatalist);
        }

        //Youtube Post Admin Request Reject of Accept
        [HttpGet]
        public IActionResult youtubepostrequest()
        {

            var data = (from brand in _dataContext.BrandRegistrationMst
                        join youtube in _dataContext.YouTubePostMst on brand.id equals youtube.youtubebranduserid
                        join payment in _dataContext.brandYouTubePaymentTransactionMsts on youtube.youtubepostid equals payment.paymentyoutubeid

                        select new
                        {
                            brandid = brand.id,
                            youtubepostid = youtube.youtubepostid,
                            youtubeurl = youtube.youtubeposturl,
                            youtubestatus = youtube.youtubepoststatus,
                            paymentid = payment.transcationid,
                            paymentrecipt = payment.paymentrecipt
                        }).ToList();

            var itemdatalist = new List<YoutubeAdminModel>();
            foreach (var dataiteam in data)
            {
                YoutubeAdminModel list = new YoutubeAdminModel()
                {
                    brandid = dataiteam.brandid,
                    youtubepostid = dataiteam.youtubepostid,
                    youtubeurl = dataiteam.youtubeurl,
                    youtubestatus = dataiteam.youtubestatus,
                    paymentid = dataiteam.paymentid,
                    paymentrecipt = dataiteam.paymentrecipt
                };
                itemdatalist.Add(list);
            }

            return View(itemdatalist);
        }


        //Json UsrGetStatus
        public JsonResult UserGetStatus(int getid, Boolean getstatus)
        {
            var data = _dataContext.UserMsts.Where(x => x.userid == getid).FirstOrDefault();
            if (data != null)
            {
                data.status = getstatus;
                _dataContext.UserMsts.Update(data);
                _dataContext.SaveChanges();
            }
            return Json(data);
        }

        //Brand Insta Like Status
        [HttpPost]
        public JsonResult instalikestatus(int id, Boolean status)
        {
            var data = _dataContext.InstaPostMsts.Where(x => x.instapostid == id).FirstOrDefault();
            if (data != null)
            {
                data.instapostlikestatus = status;
                _dataContext.InstaPostMsts.Update(data);
                _dataContext.SaveChanges();
            }
            return Json(data);
        }


        //Brand Insta Share Status
        [HttpPost]
        public JsonResult instasharestatus(int id, Boolean status)
        {
            var data = _dataContext.InstaPostMsts.Where(x => x.instapostid == id).FirstOrDefault();
            if (data != null)
            {
                data.instagrampostsharestatus = status;
                _dataContext.InstaPostMsts.Update(data);
                _dataContext.SaveChanges();
            }
            return Json(data);
        }

        //Brand Insta Save Status
        [HttpPost]
        public JsonResult instasavestatus(int id, Boolean status)
        {
            var data = _dataContext.InstaPostMsts.Where(x => x.instapostid == id).FirstOrDefault();
            if (data != null)
            {
                data.instapostsavestatus = status;
                _dataContext.InstaPostMsts.Update(data);
                _dataContext.SaveChanges();
            }
            return Json(data);
        }

        //Brand Youtube Like Status
        [HttpPost]
        public JsonResult youtubelikestatus(int id, Boolean status)
        {
            var data = _dataContext.YouTubePostMst.Where(x => x.youtubepostid == id).FirstOrDefault();
            if (data != null)
            {
                data.youtubepostlikestatus = status;
                _dataContext.YouTubePostMst.Update(data);
                _dataContext.SaveChanges();
            }
            return Json(data);
        }


        //Brand Insta Share Status
        [HttpPost]
        public JsonResult youtubesharestatus(int id, Boolean status)
        {
            var data = _dataContext.YouTubePostMst.Where(x => x.youtubepostid == id).FirstOrDefault();
            if (data != null)
            {
                data.youtubepostsharestatus = status;
                _dataContext.YouTubePostMst.Update(data);
                _dataContext.SaveChanges();
            }
            return Json(data);
        }

        //Brand Insta Save Status
        [HttpPost]
        public JsonResult youtubesavestatus(int id, Boolean status)
        {
            var data = _dataContext.YouTubePostMst.Where(x => x.youtubepostid == id).FirstOrDefault();
            if (data != null)
            {
                data.youtubepostsavestatus = status;
                _dataContext.YouTubePostMst.Update(data);
                _dataContext.SaveChanges();
            }
            return Json(data);
        }

        [HttpPost]
        public JsonResult InstaBudgetStatus(int id, Boolean status)
        {
            var data = _dataContext.InstaPostBudgetMst.Where(x => x.instapostbudgetid == id).FirstOrDefault();
            if (data != null)
            {
                data.status = status;
                _dataContext.InstaPostBudgetMst.Update(data);
                _dataContext.SaveChanges();

                return Json(data);
            }

            return Json(null);
        }


        [HttpPost]
        public JsonResult YoutubeBudgetStatus(int id, Boolean status)
        {
            var data = _dataContext.youTubePostBudgetMsts.Where(x => x.youtubepostbudgetid == id).FirstOrDefault();
            if (data != null)
            {
                data.status = status;
                _dataContext.youTubePostBudgetMsts.Update(data);
                _dataContext.SaveChanges();

                return Json(data);
            }

            return Json(null);
        }


        //Brand Insta Status
        [HttpPost]
        public JsonResult instastatus(int id, Boolean status)
        {
            var data = _dataContext.InstaPostMsts.Where(x => x.instapostid == id).FirstOrDefault();

            if (data != null)
            {
                if (status == true)
                {
                    data.instapoststatus = status;
                    _dataContext.InstaPostMsts.Update(data);
                    _dataContext.SaveChanges();
                }
                else
                {
                    data.instapoststatus = status;
                    _dataContext.InstaPostMsts.Update(data);
                    _dataContext.SaveChanges();
                }

            }
            return Json(data);
        }


        //Brand Insta Status
        [HttpPost]
        public JsonResult youtubestatus(int id, Boolean status)
        {
            var data = _dataContext.YouTubePostMst.Where(x => x.youtubepostid == id).FirstOrDefault();

            if (data != null)
            {
                if (status == true)
                {
                    data.youtubepoststatus = status;
                    _dataContext.YouTubePostMst.Update(data);
                    _dataContext.SaveChanges();
                }
                else
                {
                    data.youtubepoststatus = status;
                    _dataContext.YouTubePostMst.Update(data);
                    _dataContext.SaveChanges();
                }

            }
            return Json(data);
        }

    }
}


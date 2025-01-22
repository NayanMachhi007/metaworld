using Meta_Ads_World.Data;
using Meta_Ads_World.Models;
using Microsoft.AspNetCore.Hosting;

namespace Meta_Ads_World.Repository
{
    public class BrandSocialCategoryRepository
    {
        private readonly DataContext _datacontext;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public BrandSocialCategoryRepository(DataContext datacontext, IWebHostEnvironment webHostEnvironment)
        {
            _datacontext = datacontext;
            _webHostEnvironment = webHostEnvironment;
        }

        public List<InstaPostModelList> InstaPostList()
        {
            Boolean status = true;
            List<InstaPostModelList> list = new List<InstaPostModelList>();
            var data = _datacontext.InstaPostMsts.ToList();
            foreach (var item in data)
            {
                InstaPostModelList insta = new InstaPostModelList()
                {
                    instapostid = item.instapostid,
                    instaposttotallike = item.instaposttotallike,
                    instapostcomment = item.instapostcomment,
                    instapostshare = item.instapostshare,
                    instapostsave = item.instapostsave,
                    instapoststartingdate = item.instapoststartingdate,
                    instapostendingdate = item.instapostendingdate,
                    instapostlikestatus = item.instapostlikestatus,
                    instapostcommentstatus = item.instapostcommentstatus,
                    instagrampostsharestatus = item.instagrampostsharestatus,
                    instapostsavestatus = item.instapostsavestatus,
                    instaposturl = item.instaposturl,
                    posttotalbudget = item.posttotalbudget,
                    instabranduserid = item.instabranduserid,
                    instapoststatus = item.instapoststatus,
                };
                list.Add(insta);
            }
            return list;
        }

        public List<InstaPostModelList> AdminPaymentRequestInstaPostList()
        {
            Boolean status = true;
            List<InstaPostModelList> list = new List<InstaPostModelList>();
            var data = _datacontext.InstaPostMsts.Where(x => x.instapoststatus == status).ToList();
            //var youtubedata = _datacontext.YouTubePostMst.Where(x => x.youtubepoststatus == status).ToList();
            foreach (var item in data)
            {
                InstaPostModelList insta = new InstaPostModelList()
                {
                    instapostid = item.instapostid,
                    instaposttotallike = item.instaposttotallike,
                    instapostcomment = item.instapostcomment,
                    instapostshare = item.instapostshare,
                    instapostsave = item.instapostsave,
                    instapoststartingdate = item.instapoststartingdate,
                    instapostendingdate = item.instapostendingdate,
                    instapostlikestatus = item.instapostlikestatus,
                    instapostcommentstatus = item.instapostcommentstatus,
                    instagrampostsharestatus = item.instagrampostsharestatus,
                    instapostsavestatus = item.instapostsavestatus,
                    instaposturl = item.instaposturl,
                    posttotalbudget = item.posttotalbudget,
                    instabranduserid = item.instabranduserid,
                    instapoststatus = item.instapoststatus,
                };
                list.Add(insta);
            }


            //foreach (var iteam in youtubedata)
            //{
            //    InstaPostModelList datalist = new InstaPostModelList()
            //    {
            //        youtubepostid = iteam.youtubepostid,
            //        youtubeposttotallike = iteam.youtubeposttotallike,
            //        youtubepostcomment = iteam.youtubepostcomment,
            //        youtubepostshare = iteam.youtubepostshare,
            //        youtubepostsave = iteam.youtubepostsave,
            //        youtubepoststartingdate = iteam.youtubepoststartingdate,
            //        youtubepostendingdate = iteam.youtubepostendingdate,
            //        youtubepostlikestatus = iteam.youtubepostlikestatus,
            //        youtubepostcommentstatus = iteam.youtubepostcommentstatus,
            //        youtubepostsharestatus = iteam.youtubepostsharestatus,
            //        youtubepostsavestatus = iteam.youtubepostsavestatus,
            //        youtubeposturl = iteam.youtubeposturl,
            //        youtubeposttotalbudget = iteam.youtubeposttotalbudget,
            //        youtubebranduserid = iteam.youtubebranduserid,
            //        youtubepoststatus = iteam.youtubepoststatus,
            //    };
            //    list.Add(datalist);
            //}

            return list;
        }



        //YouTubePost List
        public List<YoutTubePostModelList> AdminPaymentRequestYoutubePostModelList()
        {
            Boolean status = true;
            List<YoutTubePostModelList> list = new List<YoutTubePostModelList>();
            var data = _datacontext.YouTubePostMst.Where(x => x.youtubepoststatus == status).ToList();
            foreach (var item in data)
            {
                YoutTubePostModelList youtube = new YoutTubePostModelList()
                {
                    youtubepostid = item.youtubepostid,
                    youtubeposttotallike = item.youtubeposttotallike,
                    youtubepostcomment = item.youtubepostcomment,
                    youtubepostshare = item.youtubepostshare,
                    youtubepostsave = item.youtubepostsave,
                    youtubepoststartingdate = item.youtubepoststartingdate,
                    youtubepostendingdate = item.youtubepostendingdate,
                    youtubepostlikestatus = item.youtubepostlikestatus,
                    youtubepostcommentstatus = item.youtubepostcommentstatus,
                    youtubepostsharestatus = item.youtubepostsharestatus,
                    youtubepostsavestatus = item.youtubepostsavestatus,
                    youtubeposturl = item.youtubeposturl,
                    youtubeposttotalbudget = item.youtubeposttotalbudget,
                    youtubebranduserid = item.youtubebranduserid,
                    counter = item.counter,
                    youtubepoststatus = item.youtubepoststatus,
                };
                list.Add(youtube);
            }
            return list;
        }

        // Brand Social Instagram Post Add

        public void instagrampostadd(InstaPostModelList instaadd)
        {

        }

        // Brand Social Youtube Post Add
        public void youtubepostadd(YoutTubePostModelList youtubeadd)
        {

        }

        //Instagram Post Budget Add

        public void instagrampostbudgetadd(InstaPostBudgetModelList instabudgetadd)
        {
            InstaPostBudgetMst instabudget = new InstaPostBudgetMst()
            {
                instalikebudget = instabudgetadd.instalikebudget,
                instacommentbudget = instabudgetadd.instacommentbudget,
                instasharebudget = instabudgetadd.instasharebudget,
                instasavebudget = instabudgetadd.instasavebudget,
                status = instabudgetadd.status
            };
            _datacontext.InstaPostBudgetMst.Add(instabudget);
            _datacontext.SaveChanges();
        }

        //Youtube Post Budget Add

        public void youtubepostbudgetadd(YouTubePostBudgetModeliList youtubebudgetadd)
        {
            YouTubePostBudgetMst youtubebudget = new YouTubePostBudgetMst()
            {
                youtubelikebudget = youtubebudgetadd.youtubelikebudget,
                youtubecommentbudget = youtubebudgetadd.youtubecommentbudget,
                youtubesharebudget = youtubebudgetadd.youtubesharebudget,
                youtubesavebudget = youtubebudgetadd.youtubesavebudget,
                status = youtubebudgetadd.status
            };
            _datacontext.youTubePostBudgetMsts.Add(youtubebudget);
            _datacontext.SaveChanges();
        }

        //Instagram Budget List
        public List<InstaPostBudgetModelList> instagrampostbudgetlist()
        {
            List<InstaPostBudgetModelList> insta = new List<InstaPostBudgetModelList>();
            var data = _datacontext.InstaPostBudgetMst.ToList();
            if (data != null)
            {
                foreach (var iteam in data)
                {
                    InstaPostBudgetModelList instalist = new InstaPostBudgetModelList()
                    {
                        instapostbudgetid = iteam.instapostbudgetid,
                        instalikebudget = iteam.instalikebudget,
                        instacommentbudget = iteam.instacommentbudget,
                        instasharebudget = iteam.instasharebudget,
                        instasavebudget = iteam.instasavebudget,
                        status = iteam.status,
                    };
                    insta.Add(instalist);
                }

                return insta;

            }

            return null;
        }

        //YouTube Budget List
        public List<YouTubePostBudgetModeliList> youtubepostbudgetlist()
        {
            List<YouTubePostBudgetModeliList> youtube = new List<YouTubePostBudgetModeliList>();
            var data = _datacontext.youTubePostBudgetMsts.ToList();
            foreach (var iteam in data)
            {
                YouTubePostBudgetModeliList youtubelist = new YouTubePostBudgetModeliList()
                {
                    youtubepostbudgetid = iteam.youtubepostbudgetid,
                    youtubelikebudget = iteam.youtubelikebudget,
                    youtubecommentbudget = iteam.youtubecommentbudget,
                    youtubesharebudget = iteam.youtubesharebudget,
                    youtubesavebudget = iteam.youtubesavebudget,
                    status = iteam.status,
                };
                youtube.Add(youtubelist);
            }
            return youtube;
        }

        //Instagram Budget Details

        public InstaPostBudgetModelList instagrambudgetdetails(int id)
        {
            InstaPostBudgetModelList Insta = new InstaPostBudgetModelList();
            var data = _datacontext.InstaPostBudgetMst.Find(id);
            Insta.instapostbudgetid = data.instapostbudgetid;
            Insta.instalikebudget = data.instalikebudget;
            Insta.instacommentbudget = data.instacommentbudget;
            Insta.instasharebudget = data.instasharebudget;
            Insta.instasavebudget = data.instasavebudget;
            Insta.status = data.status;
            return Insta;
        }

        //Instagram Budget Edit
        public void instagrambudgetedit(InstaPostBudgetModelList insta)
        {
            InstaPostBudgetMst instaedit = new InstaPostBudgetMst()
            {
                instapostbudgetid = insta.instapostbudgetid,
                instalikebudget = insta.instalikebudget,
                instacommentbudget = insta.instasharebudget,
                instasharebudget = insta.instasharebudget,
                instasavebudget = insta.instasavebudget,
                status = insta.status,
            };
            _datacontext.InstaPostBudgetMst.Update(instaedit);
            _datacontext.SaveChanges();
        }

        //YouTube Budget Details

        public YouTubePostBudgetModeliList youtubebudgetdetails(int id)
        {
            YouTubePostBudgetModeliList youtube = new YouTubePostBudgetModeliList();
            var data = _datacontext.youTubePostBudgetMsts.Find(id);
            youtube.youtubepostbudgetid = data.youtubepostbudgetid;
            youtube.youtubelikebudget = data.youtubelikebudget;
            youtube.youtubecommentbudget = data.youtubecommentbudget;
            youtube.youtubesharebudget = data.youtubesharebudget;
            youtube.youtubesavebudget = data.youtubesavebudget;
            youtube.status = data.status;
            return youtube;
        }

        //YouTube Budget Edit
        public void youtubebudgetedit(YouTubePostBudgetModeliList youtube)
        {
            YouTubePostBudgetMst youtubeedit = new YouTubePostBudgetMst()
            {
                youtubepostbudgetid = youtube.youtubepostbudgetid,
                youtubelikebudget = youtube.youtubelikebudget,
                youtubecommentbudget = youtube.youtubecommentbudget,
                youtubesharebudget = youtube.youtubesharebudget,
                youtubesavebudget = youtube.youtubesavebudget,
                status = youtube.status,
            };
            _datacontext.youTubePostBudgetMsts.Update(youtubeedit);
            _datacontext.SaveChanges();
        }


        //Instagram Post Budget Details Find
        public InstaPostModelList Budgetfind(bool status)
        {
            status = true;
            InstaPostModelList model = new InstaPostModelList();
            var data = _datacontext.InstaPostBudgetMst.FirstOrDefault(x => x.status == status);
            if (data != null)
            {
                model.instalikebudget = data.instalikebudget;
                model.instacommentbudget = data.instacommentbudget;
                model.instasharebudget = data.instasharebudget;
                model.instasavebudget = data.instasavebudget;

                return model;
            }

            return null;
        }


        //Brand Payment Transcation Add
        public void brandpaymentadddata(BrandPaymentTransactionModel adddata)
        {

            int userid = 1;
            var folder = "meta-ads-world-upload-images/transaction-recipt-images/" + adddata.uploadfile.FileName; // Use the file name you want to delete
            var filereplace = Path.Combine(_webHostEnvironment.WebRootPath, folder);

            //// Check if the file already exists
            //if (System.IO.File.Exists(filereplace))
            //{
            //    // Delete the existing file
            //    System.IO.File.Delete(filereplace);
            //}

            // Save the new file
            using (var stream = new FileStream(filereplace, FileMode.Create))
            {
                adddata.uploadfile.CopyTo(stream);
            }

            BrandPaymentTransactionMst add = new BrandPaymentTransactionMst()
            {
                paymentrecipt = folder,
                transcationid = adddata.transcationid,
                contactno = adddata.contactno,
                paymentbranduserid = userid,
                paymentinstaid = adddata.paymentinstaid,
            };

            _datacontext.BrandPaymentTransactionMsts.Add(add);
            _datacontext.SaveChanges();

        }


        public void brandyoutuberecordpaymentadddata(BrandYoutubePaymentTransactionModel adddata)
        {

            int userid = 1;
            var folder = "meta-ads-world-upload-images/transaction-recipt-images/" + adddata.uploadfile.FileName; // Use the file name you want to delete
            var filereplace = Path.Combine(_webHostEnvironment.WebRootPath, folder);

            //// Check if the file already exists
            //if (System.IO.File.Exists(filereplace))
            //{
            //    // Delete the existing file
            //    System.IO.File.Delete(filereplace);
            //}

            // Save the new file
            using (var stream = new FileStream(filereplace, FileMode.Create))
            {
                adddata.uploadfile.CopyTo(stream);
            }

            BrandYouTubePaymentTransactionMst add = new BrandYouTubePaymentTransactionMst()
            {
                paymentrecipt = folder,
                transcationid = adddata.transcationid,
                contactno = adddata.contactno,
                paymentbranduserid = userid,
                paymentyoutubeid = adddata.paymentyoutubeid,
            };

            _datacontext.brandYouTubePaymentTransactionMsts.Add(add);
            _datacontext.SaveChanges();

        }

    }
}
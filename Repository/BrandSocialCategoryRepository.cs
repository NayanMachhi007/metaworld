using Meta_Ads_World.Data;
using Meta_Ads_World.Models;

namespace Meta_Ads_World.Repository
{
    public class BrandSocialCategoryRepository
    {
        private readonly DataContext _datacontext;

        public BrandSocialCategoryRepository(DataContext datacontext)
        {
            _datacontext = datacontext;
        }

        public List<InstaPostModelList> InstaPostList()
        {
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
                };
                list.Add(insta);
            }
            return list;
        }



        //YouTubePost List
        public List<YoutTubePostModelList> YoutubePostModelList()
        {
            List<YoutTubePostModelList> list = new List<YoutTubePostModelList>();
            var data = _datacontext.YouTubePostMst.ToList();
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
                };
                list.Add(youtube);
            }
            return list;
        }

        // Brand Social Instagram Post Add

        public void instagrampostadd(InstaPostModelList instaadd)
        {
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
            };
            _datacontext.InstaPostMsts.Add(insta);
            _datacontext.SaveChanges();
        }

        // Brand Social Youtube Post Add
        public void youtubepostadd(YoutTubePostModelList youtubeadd)
        {
            YouTubePostMst youtube = new YouTubePostMst()
            {
                youtubeposttotallike = youtubeadd.youtubeposttotallike,
                youtubepostcomment = youtubeadd.youtubepostcomment,
                youtubepostshare = youtubeadd.youtubepostshare,
                youtubepostsave = youtubeadd.youtubepostsave,
                youtubepoststartingdate = youtubeadd.youtubepoststartingdate,
                youtubepostendingdate = youtubeadd.youtubepostendingdate,
                youtubepostlikestatus = youtubeadd.youtubepostlikestatus,
                youtubepostcommentstatus = youtubeadd.youtubepostcommentstatus,
                youtubepostsharestatus = youtubeadd.youtubepostsharestatus,
                youtubepostsavestatus = youtubeadd.youtubepostsavestatus,
                youtubeposturl = youtubeadd.youtubeposturl,
                youtubeposttotalbudget = youtubeadd.youtubeposttotalbudget,
            };
            _datacontext.YouTubePostMst.Add(youtube);
            _datacontext.SaveChanges();
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

    }
}
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

        public void instagrampostbudgetadd(InstaPostBudgetModelList instabudgetadd)
        {
            InstaPostBudgetMst instabudget = new InstaPostBudgetMst()
            {
                instalikebudget = instabudgetadd.instalikebudget,
                instacommentbudget = instabudgetadd.instacommentbudget,
                instasharebudget = instabudgetadd.instasharebudget,
                instasavebudget = instabudgetadd.instasavebudget,
            };
            _datacontext.InstaPostBudgetMst.Add(instabudget);
            _datacontext.SaveChanges();
        }

        //Instagram Budget List
        public List<InstaPostBudgetModelList> instagrampostbudgetlist()
        {
            List<InstaPostBudgetModelList> insta = new List<InstaPostBudgetModelList>();
            var data = _datacontext.InstaPostBudgetMst.ToList();
            foreach (var iteam in data)
            {
                InstaPostBudgetModelList instalist = new InstaPostBudgetModelList()
                {
                    instapostbudgetid = iteam.instapostbudgetid,
                    instalikebudget = iteam.instalikebudget,
                    instacommentbudget = iteam.instacommentbudget,
                    instasharebudget = iteam.instasharebudget,
                    instasavebudget = iteam.instasavebudget,
                };
                insta.Add(instalist);
            }
            return insta;
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
            return Insta;
        }

        //Instagram Budget Edit
        public void instagrambudgetedit(InstaPostBudgetModelList insta)
        {
            InstaPostBudgetMst instaedit = new InstaPostBudgetMst()
            {
                instapostbudgetid= insta.instapostbudgetid,
                instalikebudget= insta.instalikebudget,
                instacommentbudget= insta.instasharebudget,
                instasharebudget= insta.instasharebudget,
                instasavebudget= insta.instasavebudget,
            };
            _datacontext.InstaPostBudgetMst.Update(instaedit);
            _datacontext.SaveChanges();
        }

    }
}
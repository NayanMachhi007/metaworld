using Meta_Ads_World.Data;

namespace Meta_Ads_World.Models
{
    public class InstaPostModel
    {
        public int instapostid { get; set; }
        public string instaposttotallike { get; set; }
        public string instapostcomment { get; set; }
        public Boolean instapostshare{ get; set; }
        public Boolean instapostsave{ get; set; }
        public DateTime instapoststartingdate { get; set; } = DateTime.Now;
        public DateTime instapostendingdate { get; set; } = DateTime.Now;
        public Boolean instapostlikestatus { get; set; }
        public Boolean instapostcommentstatus { get; set; }
        public Boolean instagrampostsharestatus { get; set; }
        public Boolean instapostsavestatus { get; set; }
        public string instaposturl { get; set; }
        public string posttotalbudget { get; set; }


        //Insta Post Budget Model

        public int instapostbudgetid { get; set; }
        public int instalikebudget { get; set; }
        public int instacommentbudget { get; set; }
        public int instasharebudget { get; set; }
        public int instasavebudget { get; set; }


    }

    public class InstaPostModelList : InstaPostModel
    {
        public List<InstaPostModelList> InstaPostList { get; set; }
        public List<InstaPostBudgetMst> instabudget { get; set; }
    }
}

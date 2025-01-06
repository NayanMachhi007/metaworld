using Meta_Ads_World.Data;
using System.ComponentModel.DataAnnotations;

namespace Meta_Ads_World.Models
{
    public class InstaPostModel
    {
        public int instapostid { get; set; }
        public string instaposttotallike { get; set; }
        public string instapostcomment { get; set; }
        public string instapostshare { get; set; }
        public string instapostsave { get; set; }
        public DateTime instapoststartingdate { get; set; } = DateTime.Now;
        public DateTime instapostendingdate { get; set; } = DateTime.Now;
        public Boolean instapostlikestatus { get; set; }
        public Boolean instapostcommentstatus { get; set; }
        public Boolean instagrampostsharestatus { get; set; }
        public Boolean instapostsavestatus { get; set; }
        public string instaposturl { get; set; }

        [Required(ErrorMessage = "Please Enter the details")]
        public string posttotalbudget { get; set; }
        public Boolean instapoststatus { get; set; }
        public int instabranduserid { get; set; }
        public int counter { get; set; }

        //Insta Post Budget Model

        public int instapostbudgetid { get; set; }
        public int instalikebudget { get; set; }
        public int instacommentbudget { get; set; }
        public int instasharebudget { get; set; }
        public int instasavebudget { get; set; }

        public Boolean status { get; set; }



    }

    public class InstaPostModelList : InstaPostModel
    {
        public List<InstaPostModelList>? InstaPostList { get; set; }
        public List<InstaPostBudgetMst>? instabudget { get; set; }

        public List<BrandRegistrationMst>? BrandRegistration { get; set; }

        public List<UserMst>? UserMst { get; set; }
    }
}

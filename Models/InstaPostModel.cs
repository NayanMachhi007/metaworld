using Meta_Ads_World.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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


        //Youtube Data

        //public int youtubepostid { get; set; }
        //public string? youtubeposttotallike { get; set; }
        //public string? youtubepostcomment { get; set; }
        //public string? youtubepostshare { get; set; }
        //public string? youtubepostsave { get; set; }
        //public DateTime youtubepoststartingdate { get; set; } = DateTime.Now;
        //public DateTime youtubepostendingdate { get; set; } = DateTime.Now;
        //public Boolean youtubepostlikestatus { get; set; }
        //public Boolean youtubepostcommentstatus { get; set; }
        //public Boolean youtubepostsharestatus { get; set; }
        //public Boolean youtubepostsavestatus { get; set; }
        //public string? youtubeposturl { get; set; }
        //public Boolean? youtubepoststatus { get; set; }
        //public string? youtubeposttotalbudget { get; set; }       
        //public int youtubebranduserid { get; set; }
        //public int youtubecounter { get; set; }

    }

    public class InstaPostModelList : InstaPostModel
    {
        public List<InstaPostModelList>? InstaPostList { get; set; }
        public List<InstaPostBudgetMst>? instabudget { get; set; }
        public List<YouTubePostMst>? youTube { get; set; }
        public List<BrandRegistrationMst>? BrandRegistration { get; set; }

        public List<UserMst>? UserMst { get; set; }
    }
}

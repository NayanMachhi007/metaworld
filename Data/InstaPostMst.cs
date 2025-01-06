using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Meta_Ads_World.Data
{
    public class InstaPostMst
    {
        [Key]
        public int instapostid { get; set; }
        public string instaposttotallike { get; set; }
        public string? instapostcomment { get; set; }
        public string instapostshare { get; set; }
        public string instapostsave { get; set; }
        public DateTime instapoststartingdate { get; set; } = DateTime.Now;
        public DateTime instapostendingdate { get; set; } = DateTime.Now;
        public Boolean instapostlikestatus { get; set; }
        public Boolean instapostcommentstatus { get; set; }
        public Boolean instagrampostsharestatus { get; set; }
        public Boolean instapostsavestatus { get; set; }
        public string instaposturl { get; set; }
        public string posttotalbudget { get; set; }
        public Boolean instapoststatus { get; set; }

        [ForeignKey("BrandRegistrationMst")]
        public int instabranduserid { get; set; }
        public BrandRegistrationMst BrandRegistrationMst { get; set; }
        public int counter { get; set; }

        //public ICollection<UserInstaPostHandlerMst> UserInstaPostHandlers { get; set; }
    }
}

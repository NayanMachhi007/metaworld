using System.ComponentModel.DataAnnotations;

namespace Meta_Ads_World.Data
{
    public class InstaPostMst
    {
        [Key]
        public int instapostid { get; set; }
        public string instaposttotallike { get; set; }
        public string instapostcomment { get; set; }
        public Boolean instapostshare { get; set; }
        public Boolean instapostsave { get; set; }
        public DateTime instapoststartingdate { get; set; } = DateTime.Now;
        public DateTime instapostendingdate { get; set; } = DateTime.Now;
        public Boolean instapostlikestatus { get; set; }
        public Boolean instapostcommentstatus { get; set; }
        public Boolean instagrampostsharestatus { get; set; }
        public Boolean instapostsavestatus { get; set; }
        public string instaposturl { get; set; }
        public string posttotalbudget { get; set; }
    }
}

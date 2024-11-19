using System.ComponentModel.DataAnnotations;

namespace Meta_Ads_World.Data
{
    public class YouTubePostMst
    {
        [Key]
        public int youtubepostid { get; set; }
        public string youtubeposttotallike { get; set; }
        public string youtubepostcomment { get; set; }
        public Boolean youtubepostshare { get; set; }
        public Boolean youtubepostsave { get; set; }
        public DateTime youtubepoststartingdate { get; set; } = DateTime.Now;
        public DateTime youtubepostendingdate { get; set; } = DateTime.Now;
        public Boolean youtubepostlikestatus { get; set; }
        public Boolean youtubepostcommentstatus { get; set; }
        public Boolean youtubepostsharestatus { get; set; }
        public Boolean youtubepostsavestatus { get; set; }
        public string youtubeposturl { get; set; }
        public string youtubeposttotalbudget { get; set; }
    }
}

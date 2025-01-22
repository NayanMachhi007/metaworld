using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Meta_Ads_World.Data
{
    public class YouTubePostMst
    {
        [Key]
        public int youtubepostid { get; set; }
        public string youtubeposttotallike { get; set; }
        public string youtubepostcomment { get; set; }
        public string youtubepostshare { get; set; }
        public string youtubepostsave { get; set; }
        public DateTime youtubepoststartingdate { get; set; } = DateTime.Now;
        public DateTime youtubepostendingdate { get; set; } = DateTime.Now;
        public Boolean youtubepostlikestatus { get; set; }
        public Boolean youtubepostcommentstatus { get; set; }
        public Boolean youtubepostsharestatus { get; set; }
        public Boolean youtubepostsavestatus { get; set; }
        public string youtubeposturl { get; set; }
        public Boolean youtubepoststatus { get; set; }

        public string youtubeposttotalbudget { get; set; }

        [ForeignKey("BrandRegistrationMst")]
        public int youtubebranduserid { get; set; }
        public BrandRegistrationMst BrandRegistrationMst { get; set; }
        public int counter { get; set; }
    }
}

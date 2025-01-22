using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Meta_Ads_World.Data
{
    public class UserYoutubePostHandlerMst
    {
        [Key]
        public int userhandlerid { get; set; }

        [ForeignKey("UserMst")]
        public int userid { get; set; }

        [ForeignKey("youTubePostMst")]
        public int youtubeid { get; set; }

        public string? youtubelike { get; set; }
        public string? youtubecomment { get; set; }
        public string youtubeshare { get; set; }
        public string youtubesave { get; set; }
        public DateTime userhandlertime { get; set; } = System.DateTime.Now;

        public UserMst UserMst { get; set; }
        public YouTubePostMst youTubePostMst { get; set; }
    }
}

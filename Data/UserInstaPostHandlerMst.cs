using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Meta_Ads_World.Data
{
    public class UserInstaPostHandlerMst
    {
        [Key]
        public int userhandlerid { get; set; }

        [ForeignKey("UserMst")]
        public int userid { get; set; }

        [ForeignKey("InstaPostMst")]
        public int instapostid { get; set; }

        public string? instalike { get; set; }
        public string? instacomment { get; set; }
        public string instashare { get; set; }
        public string instasave { get; set; }
        public DateTime userhandlertime { get; set; } = System.DateTime.Now;

        public UserMst UserMst { get; set; }
        public InstaPostMst InstaPostMst { get; set; }
    }
}

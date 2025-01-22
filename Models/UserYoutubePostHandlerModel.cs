using Meta_Ads_World.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace Meta_Ads_World.Models
{
    public class UserYoutubePostHandlerModel
    {
        public int userhandlerid { get; set; }
        public int userid { get; set; }
        public string username { get; set; }
        public int youtubeid { get; set; }
        public string? youtubelike { get; set; }
        public string? youtubecomment { get; set; }
        public string youtubeshare { get; set; }
        public string youtubesave { get; set; }
        public string youtubeposturl { get; set; }
        public DateTime userhandlertime { get; set; } = System.DateTime.Now;

        public Boolean youtubecommentstatus { get; set; }
        public Boolean youtubesavestatus { get; set; }
        public Boolean youtubesharestatus { get; set; }
        public Boolean youtubestatus { get; set; }
        public int counter { get; set; }
        public string posttotalbudget { get; set; }
    }

    public class UserYoutubePostHandlerModelList : UserInstaPostHandlerModel
    {
        public List<UserYoutubePostHandlerModelList> youtubelist { get; set; }
        public List<YouTubePostMst> youTubePostMsts { get; set; }
    }
}

using Meta_Ads_World.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace Meta_Ads_World.Models
{
    public class UserInstaPostHandlerModel
    {
        public int userhandlerid { get; set; }
        public int userid { get; set; }
        public int instapostid { get; set; }
        public string? instalike { get; set; }
        public string? instacomment { get; set; }
        public string instashare { get; set; }
        public string instasave { get; set; }
        public DateTime userhandlertime { get; set; } = System.DateTime.Now;


        //Instagram Post
        public string instaposturl { get; set; }
        public Boolean instapoststatus { get; set; }

    }

    public class UserInstaPostHandlerModelList : UserInstaPostHandlerModel
    {
        public List<UserInstaPostHandlerModelList> UserInstaPostHandlerModelLists { get; set; }
        public List<InstaPostMst> InstaPostMst { get; set; }
        public List<UserMst> UserMst { get; set; }

    }
}

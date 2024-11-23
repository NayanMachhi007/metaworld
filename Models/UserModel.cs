using Meta_Ads_World.Data;
using System.ComponentModel.DataAnnotations;

namespace Meta_Ads_World.Models
{
    public class UserModel
    {
        public int userid { get; set; }
        public string ufname { get; set; }
        public string ulname { get; set; }

        [RegularExpression("^.+@[^\\.].*\\.[a-z]{2,}$")]
        public string uemail { get; set; }
        public string upassword { get; set; }

        [Compare("upassword")]
        
        public string uconfirmpassword { get; set; }
        public string ucountry { get; set; }
        public string ustate { get; set; }
        public string ucity { get; set; }
        public Boolean status { get; set; }
        public int urefreallid { get; set; }
        public string? urefreallcode { get; set; }
    }

    public class UserModelList : UserModel
    {
        public List<InstaPostMst>? InstaPostList { get; set; }

        public List<YouTubePostMst>? YouTubePostList { get; set; }

        public List<UserModelList>? UserList { get; set; }
    }
}

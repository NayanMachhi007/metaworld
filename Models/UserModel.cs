using Meta_Ads_World.Data;
using System.ComponentModel.DataAnnotations;
using System.Formats.Asn1;

namespace Meta_Ads_World.Models
{
    public class UserModel
    {
        public int userid { get; set; }
        public string ufname { get; set; }

        [RegularExpression("^.+@[^\\.].*\\.[a-z]{2,}$")]
        public string uemail { get; set; }
        public string upassword { get; set; }

        [Compare("upassword")]
        
        public string uconfirmpassword { get; set; }
        public string areadcode { get; set; }

        [RegularExpression("^((\\+)?(\\d{2}[-])?(\\d{10}){1})?(\\d{11}){0,1}?$")]
        public string contactno { get; set; }
        public string profilepicture { get; set; }
        public Boolean status { get; set; }
        public int urefreallid { get; set; }
        public string? urefreallcode { get; set; }
    }

    public class UserModelList : UserModel
    {
        public List<InstaPostMst>? InstaPostList { get; set; }

        public List<YouTubePostMst>? YouTubePostList { get; set; }

        public List<UserModelList>? UserList { get; set; }

        public List<CityMst>? citylist { get; set; }

        public List<AreaMst>? arealist { get; set; }
    }
}

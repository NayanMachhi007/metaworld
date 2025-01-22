using Meta_Ads_World.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace Meta_Ads_World.Models
{
    public class InstagramPostUserHandlerDataModel
    {
        public int userhandlerid { get; set; }
        public int userid { get; set; }
        public string username { get; set; }
        public int instapostid { get; set; }
        public string? instalike { get; set; }
        public string? instacomment { get; set; }
        public string instashare { get; set; }
        public string instasave { get; set; }
        public string instaposturl { get; set; }
        public DateTime userhandlertime { get; set; } = System.DateTime.Now;

        public Boolean instacommentstatus { get; set; }
        public Boolean instasharestatus { get; set; }
        public Boolean instasavestatus { get; set; }
        public int counter { get; set; }
        public string posttotalbudget { get; set; }
    }

    public class InstagramPostUserHandlerDataModelList : InstagramPostUserHandlerDataModel
    {
        public List<InstagramPostUserHandlerDataModel> InstaUserHandlerList { get; set; }
        public List<InstaPostMst> InstaPostMst { get; set; }
    }
}

using Meta_Ads_World.Data;

namespace Meta_Ads_World.Models
{
    public class YoutubeAdminModel
    {
        public int brandid { get; set; }
        public int youtubepostid { get; set; }
        public string youtubeurl { get; set; }
        public Boolean youtubestatus { get; set; }
        public string paymentid { get; set; }
        public string paymentrecipt { get; set; }
    }

    public class YoutubeAdminModelList : YoutubeAdminModel
    {
        public List<BrandRegistrationMst> BrandRegistrationMst { get; set; }
        public List<BrandYouTubePaymentTransactionMst> BrandPaymentMst { get; set; }
        public List<YouTubePostMst> YouTubePostMst { get; set; }
    }
}

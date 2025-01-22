using Meta_Ads_World.Data;

namespace Meta_Ads_World.Models
{
    public class BrandYoutubePaymentTransactionModel
    {
        public int id { get; set; }

        public IFormFile uploadfile { get; set; }

        public string paymentrecipt { get; set; }
        public string transcationid { get; set; }
        public string contactno { get; set; }
        public int paymentbranduserid { get; set; }
        public int paymentyoutubeid { get; set; }

        //QR Code Data
        public int qrid { get; set; }
        public string qrpath { get; set; }
        public Boolean status { get; set; }
    }

    public class BrandYoutubePaymentTransactionModeList : BrandPaymentTransactionModel
    {
        public List<YouTubePostMst> YouTubePostMst { get; set; }
        public List<BrandYoutubePaymentTransactionModeList> brandYoutubePaymentTransactionModeLists { get; set; }
        public List<QrCodeMst> qrCodeMsts { get; set; }
    }
}

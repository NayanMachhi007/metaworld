using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Meta_Ads_World.Data
{
    public class BrandYouTubePaymentTransactionMst
    {
        [Key]
        public int id { get; set; }
        public string paymentrecipt { get; set; }
        public string transcationid { get; set; }
        public string contactno { get; set; }

        [ForeignKey("brandRegistrationMst")]
        public int paymentbranduserid { get; set; }

        [ForeignKey("YouTubePost")]
        public int paymentyoutubeid { get; set; }

        public BrandRegistrationMst brandRegistrationMst { get; set; }
        public YouTubePostMst YouTubePost { get; set; }

    }
}

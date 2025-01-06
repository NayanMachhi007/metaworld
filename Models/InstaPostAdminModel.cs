using Meta_Ads_World.Data;

namespace Meta_Ads_World.Models
{
    public class InstaPostAdminModel
    {
        public int brandid { get; set; }
        public int instapostid { get; set; }
        public string instaurl { get; set; }
        public Boolean instastatus { get; set; }
        public string paymentid { get; set; }
        public string paymentrecipt { get; set; }
    }


    public class InstaPostAdminModelList : InstaPostAdminModel
    {
        public List<BrandRegistrationMst> BrandRegistrationMst { get; set; }
        public List<BrandPaymentTransactionMst> BrandPaymentMst { get; set; }
        public List<InstaPostMst> InstaPostMsts { get; set; }
    }
}

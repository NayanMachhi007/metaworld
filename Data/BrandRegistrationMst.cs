using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Meta_Ads_World.Data
{
    public class BrandRegistrationMst
    {
        [Key]
        public int id { get; set; }
        public string bname { get; set; }
        public string bemail { get; set; }
        public string bcontactno { get; set; }
        public string areacode { get; set; }
        public string bpassword { get; set; }
        public Boolean bstatus { get; set; }
        //public ICollection<BrandPaymentTransactionMst> brandPaymentTransactionMsts { get; set; }
        //public ICollection<InstaPostMst> instaPostMsts { get; set; }
    }
}

using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Meta_Ads_World.Data
{
    public class BrandPaymentTransactionMst
    {
        [Key]
        public int id { get; set; }
        public string  paymentrecipt { get; set; }
        public string transcationid { get; set; }
        public string contactno { get; set; }

        [ForeignKey("brandRegistrationMst")]
        public int paymentbranduserid { get; set; }

        [ForeignKey("InstaPostMst")]
        public int paymentinstaid { get; set; }

        public BrandRegistrationMst brandRegistrationMst { get; set; }
        public InstaPostMst InstaPostMst { get; set; }
    }
}

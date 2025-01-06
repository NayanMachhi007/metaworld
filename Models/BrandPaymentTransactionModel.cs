using Meta_Ads_World.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace Meta_Ads_World.Models
{
    public class BrandPaymentTransactionModel
    {
        public int id { get; set; }

        public IFormFile uploadfile { get; set; }

        public string paymentrecipt { get; set; }
        public string transcationid { get; set; }
        public string contactno { get; set; }
        public int paymentbranduserid { get; set; }
        public int paymentinstaid { get; set; }

        //QR Code Data
        public int qrid { get; set; }
        public string qrpath { get; set; }
        public Boolean status { get; set; }

       

    }

    public class BrandPaymentTransactionModelList : BrandPaymentTransactionModel
    {
        public List<InstaPostMst> InstagramPostMst { get; set; }
        public List<BrandPaymentTransactionModelList> PaymentTransactionModelLists { get; set; }
        public List<QrCodeMst> qrCodeMsts { get; set; }

    }
}

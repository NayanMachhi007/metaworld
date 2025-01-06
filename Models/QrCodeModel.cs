using Meta_Ads_World.Data;

namespace Meta_Ads_World.Models
{
    public class QrCodeModel
    {
        public int qrid { get; set; }
        public IFormFile fileupload { get; set; }
        public string qrpath { get; set; }
        public Boolean status { get; set; }

        //Public BrandUser
        public int id { get; set; }
    }

    public class QrCodeModelList : QrCodeModel
    {
        public List<QrCodeModelList> qrlist { get; set; }

        public List<BrandRegistrationMst> BrandRegisterMst { get; set; }

    }
}

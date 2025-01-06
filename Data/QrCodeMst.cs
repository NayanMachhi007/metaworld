using System.ComponentModel.DataAnnotations;

namespace Meta_Ads_World.Data
{
    public class QrCodeMst
    {
        [Key]
        public int qrid { get; set; }
        public string qrpath { get; set; }
        public Boolean status { get; set; }
    }
}

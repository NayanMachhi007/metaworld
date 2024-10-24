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
        public string bcountry { get; set; }
        public string bstate { get; set; }
        public string bcity { get; set; }
        public string bpassword { get; set; }
        public string bconfirmpassword { get; set; }
        public Boolean bstatus { get; set; }               
    }
}

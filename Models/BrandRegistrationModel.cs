using Meta_Ads_World.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Meta_Ads_World.Models
{
    public class BrandRegistrationModel
    {
        public int id { get; set; }
        public string bname { get; set; }
        public string bemail { get; set; }
        public string bcontactno { get; set; }
        public string areacode { get; set; }
        public string bpassword { get; set; }

        [Compare("bpassword")]
        public string bconfirmpassword { get; set; }
        public Boolean bstatus { get; set; }
    }

    public class BrandRegistrationModelList : BrandRegistrationModel
    {
        public List<BrandRegistrationModelList> BrandList { get; set; }

    }
}

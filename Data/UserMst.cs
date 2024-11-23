using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System.ComponentModel.DataAnnotations;

namespace Meta_Ads_World.Data
{
    public class UserMst
    {
        [Key]
        public int userid { get; set; }
        public string ufname { get; set; }
        public string ulname { get; set; }
        public string uemail { get; set; }
        public string upassword { get; set; }
        public string ucountry { get; set; }
        public string ustate { get; set; }
        public string ucity { get; set; }
        public Boolean status { get; set; }
        public int urefreallid { get; set; }
        public string urefreallcode { get; set; }
    }
}

using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System.ComponentModel.DataAnnotations;

namespace Meta_Ads_World.Data
{
    public class UserMst
    {
        [Key]
        public int userid { get; set; }
        public string ufname { get; set; }
        public string uemail { get; set; }
        public string upassword { get; set; }
        public string areadcode { get; set; }
        public string contactno { get; set; }
        public string profilepicture { get; set; }
        public Boolean status { get; set; }
        public int urefreallid { get; set; }
        public string urefreallcode { get; set; }

        public ICollection<UserInstaPostHandlerMst> userInstaPostHandlerMsts { get; set; }
    }
}

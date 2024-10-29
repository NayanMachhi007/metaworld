namespace Meta_Ads_World.Models
{
    public class UserModel
    {
        public int userid { get; set; }
        public string ufname { get; set; }
        public string ulname { get; set; }
        public string uemail { get; set; }
        public string uconfirmemail { get; set; }
        public string upassword { get; set; }
        public string uconfirmpassword { get; set; }
        public string ucountry { get; set; }
        public string ustate { get; set; }
        public string ucity { get; set; }
        public Boolean status { get; set; }
        public int urefreallid { get; set; }
        public string urefreallcode { get; set; }
    }

    public class UserModelList : UserModel
    {
        public List<UserModelList> UserList { get; set; }
    }
}

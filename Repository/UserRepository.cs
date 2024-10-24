using Meta_Ads_World.Data;
using Meta_Ads_World.Models;
using System.Collections.Frozen;

namespace Meta_Ads_World.Repository
{
    public class UserRepository
    {
        private readonly DataContext _datacontext;

        public UserRepository(DataContext datacontext)
        {
            _datacontext = datacontext;
        }



        //User List
        public List<UserModelList> UserList()
        {
            List<UserModelList> User = new List<UserModelList>();
            var data = _datacontext.UserMsts.ToList();
            foreach (var iteam in data)
            {
                UserModelList userlist = new UserModelList()
                {
                    userid = iteam.userid,
                    ufname = iteam.ufname,
                    ulname = iteam.ulname,
                    uemail = iteam.uemail,
                    uconfirmemail = iteam.uconfirmemail,
                    upassword = iteam.upassword,
                    uconfirmpassword = iteam.uconfirmpassword,
                    ucountry = iteam.ucountry,
                    ustate = iteam.ustate,
                    ucity = iteam.ucity,
                    urefreallid = iteam.urefreallid,
                    urefreallcode = iteam.urefreallcode,
                    status=iteam.status,
                };
                User.Add(userlist);
            }
            return User;
        }

        //User Referall Join List
        public List<UserModelList> UserRefreallList()
        {
            int id = 1;
            List<UserModelList> user = new List<UserModelList>();
            var data = _datacontext.UserMsts.Where(x=>x.userid ==id).ToList();
            foreach (var iteam in data)
            {
                UserModelList list = new UserModelList()
                {
                    userid=iteam.userid,
                    ufname=iteam.ufname,
                    ulname=iteam.ulname,
                    uemail=iteam.uemail,
                    urefreallcode=iteam.urefreallcode
                };
                user.Add(list);
            }
            return user;
            
        }

        //User Registration Add
        public void UserRegistrationAdd(UserModelList useradd)
        {
            UserMst user;
            var random = new Random();
            string randomber;
            do
            {
                int length = 6;
                string datanumber = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890";
                randomber = new string(Enumerable.Repeat(datanumber, length).Select(s => s[random.Next(s.Length)]).ToArray());
                user = _datacontext.UserMsts.Where(x => x.urefreallcode == randomber).FirstOrDefault();

            } while (user != null);


            UserMst useraddregister = new UserMst()
            {
                userid = useradd.userid,
                ufname = useradd.ufname,
                ulname = useradd.ulname,
                uemail = useradd.uemail,
                uconfirmemail = useradd.uconfirmemail,
                upassword = useradd.upassword,
                uconfirmpassword = useradd.uconfirmpassword,
                ucountry = useradd.ucountry,
                ustate = useradd.ustate,
                ucity = useradd.ucity,
                urefreallid = useradd.urefreallid,
                urefreallcode = randomber,
                status=useradd.status,
            };
            _datacontext.UserMsts.Add(useraddregister);
            _datacontext.SaveChanges();
        }

        //User Registration Settings
        public void UserRegistrationSettings(UserModelList useredit)
        {
            UserMst user = _datacontext.UserMsts.Find(useredit.userid);
            if (user != null) {               
                user.uemail = useredit.uemail;
                user.uconfirmemail = useredit.uconfirmemail;
                user.upassword = useredit.upassword;
                user.uconfirmpassword = useredit.uconfirmpassword;
                _datacontext.UserMsts.Update(user);
                _datacontext.SaveChanges();            
            }
        }

    }
}

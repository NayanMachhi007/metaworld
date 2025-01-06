using Meta_Ads_World.Data;
using Meta_Ads_World.Models;

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
                    uemail = iteam.uemail,
                    upassword = iteam.upassword,
                    areadcode = iteam.areadcode,
                    contactno = iteam.contactno,
                    profilepicture = iteam.profilepicture,
                    urefreallid = iteam.urefreallid,
                    urefreallcode = iteam.urefreallcode,
                    status = iteam.status,
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
            var data = _datacontext.UserMsts.Where(x => x.urefreallid == id).ToList();
            foreach (var iteam in data)
            {
                UserModelList list = new UserModelList()
                {
                    userid = iteam.userid,
                    ufname = iteam.ufname,
                    uemail = iteam.uemail,
                    urefreallcode = iteam.urefreallcode,
                    profilepicture = iteam.profilepicture
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
                uemail = useradd.uemail,
                upassword = useradd.upassword,
                areadcode = useradd.areadcode,
                contactno = useradd.contactno,
                profilepicture = useradd.profilepicture,
                urefreallid = useradd.urefreallid,
                urefreallcode = randomber,
                status = useradd.status,
            };
            _datacontext.UserMsts.Add(useraddregister);
            _datacontext.SaveChanges();
        }

        //User Registration Settings
        public void UserRegistrationSettings(UserModelList useredit)
        {
            UserMst user = _datacontext.UserMsts.Find(useredit.userid);
            if (user != null)
            {
                user.uemail = useredit.uemail;
                user.upassword = useredit.upassword;
                _datacontext.UserMsts.Update(user);
                _datacontext.SaveChanges();
            }
        }

        //Instagram Post User List
        public List<UserInstaPostHandlerModelList> userinstapostlist()
        {
            var data = _datacontext.InstaPostMsts.Join(_datacontext.UserInstaPostHandlerMsts,
                e => e.instapostid,
                d => d.instapostid,
                (e, d) => new
                {
                    instapostid = e.instapostid,
                    instalike = e.instaposttotallike,
                    instacomment = e.instapostcomment,
                    instashare = e.instapostshare,
                    instasave = e.instapostsave,
                    instaposturl = e.instaposturl,
                    instapoststatus = e.instapoststatus,
                    userid = d.userid,
                }
                ).ToList();

            var findata = data.Where(x => x.instapoststatus == false).ToList();

            List<UserInstaPostHandlerModelList> list = new List<UserInstaPostHandlerModelList>();
            foreach (var iteam in findata)
            {
                UserInstaPostHandlerModelList model = new UserInstaPostHandlerModelList()
                {
                    instapostid = iteam.instapostid,
                    instalike = iteam.instalike,
                    instacomment = iteam.instacomment,
                    instashare = iteam.instashare,
                    instasave = iteam.instasave,
                    instaposturl = iteam.instaposturl,
                    instapoststatus = iteam.instapoststatus,
                    userid = iteam.userid,
                };
                list.Add(model);
            }

            return list;
        }

    }
}

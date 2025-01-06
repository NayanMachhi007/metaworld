using Meta_Ads_World.Data;
using Meta_Ads_World.Models;

namespace Meta_Ads_World.Repository
{
    public class AdminRepository
    {
        private readonly DataContext _datacontext;
        private readonly IWebHostEnvironment _environment;

        public AdminRepository(DataContext datacontext, IWebHostEnvironment environment)
        {
            _datacontext = datacontext;
            _environment = environment;
        }

        public List<StateModelList> StateList()
        {
            List<StateModelList> state = new List<StateModelList>();
            var data = _datacontext.StateMsts.ToList();
            foreach (var iteam in data)
            {
                StateModelList statelist = new StateModelList()
                {
                    stateid = iteam.stateid,
                    statename = iteam.statename
                };
                state.Add(statelist);
            }
            return state;
        }

        public void StateAdd(StateModelList state)
        {
            StateMst stateadd = new StateMst()
            {
                statename = state.statename,
            };
            _datacontext.StateMsts.Add(stateadd);
            _datacontext.SaveChanges();
        }


        public List<CityModelList> citylist()
        {
            List<CityModelList> list = new List<CityModelList>();
            var data = _datacontext.CityMsts.ToList();
            foreach (var city in data)
            {
                CityModelList citylist = new CityModelList()
                {
                    cityid = city.cityid,
                    cityname = city.cityname,
                    stateid = city.stateid,
                };
                list.Add(citylist);
            }
            return list;
        }

        public void CityAdd(CityModelList city)
        {
            CityMst cityadd = new CityMst()
            {
                cityname = city.cityname,
                stateid = city.stateid,
            };
            _datacontext.CityMsts.Add(cityadd);
            _datacontext.SaveChanges();
        }

        public List<AreaModelList> arealist()
        {
            List<AreaModelList> area = new List<AreaModelList>();
            var data = _datacontext.AreaMsts.ToList();
            foreach (var iteam in data)
            {
                AreaModelList arealist = new AreaModelList()
                {
                    areaid = iteam.areaid,
                    areaname = iteam.areaname,
                    cityid = iteam.cityid,
                };
                area.Add(arealist);
            }
            return area;
        }

        public void areaadd(AreaModelList areaadd)
        {
            AreaMst area = new AreaMst()
            {
                areaname = areaadd.areaname,
                cityid = areaadd.cityid,
            };
            _datacontext.AreaMsts.Add(area);
            _datacontext.SaveChanges();
        }

        //QR Code Add 
        public void qradd(QrCodeModel qradd)
        {
            var folder = "meta-ads-world-upload-images/qr-code-images/" + qradd.fileupload.FileName; // Use the file name you want to delete
            var filereplace = Path.Combine(_environment.WebRootPath, folder);
            qradd.fileupload.CopyTo(new FileStream(filereplace, FileMode.Create));

            QrCodeMst codeadd = new QrCodeMst()
            {
                qrpath = folder
            };
            _datacontext.QrMst.Add(codeadd);
            _datacontext.SaveChanges();
        }

        public List<QrCodeModelList> qrcodelist()
        {
            List<QrCodeModelList> list = new List<QrCodeModelList>();
            var code = _datacontext.QrMst.ToList();

            foreach (var itean in code)
            {
                QrCodeModelList data = new QrCodeModelList()
                {
                    qrid = itean.qrid,
                    qrpath = itean.qrpath,
                    status = itean.status
                };
                list.Add(data);
            }
            return list;

        }
    }
}

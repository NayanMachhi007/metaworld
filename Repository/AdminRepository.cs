using Meta_Ads_World.Data;
using Meta_Ads_World.Models;
using System.Formats.Asn1;

namespace Meta_Ads_World.Repository
{
    public class AdminRepository
    {
        private readonly DataContext _datacontext;

        public AdminRepository(DataContext datacontext)
        {
            _datacontext = datacontext;
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
                statename= state.statename, 
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
                cityname=city.cityname,
                stateid=city.stateid,
            };
            _datacontext.CityMsts.Add(cityadd);
            _datacontext.SaveChanges();
        }

        public List<AreaModelList> arealist()
        {
            List<AreaModelList> area = new List<AreaModelList>();
            var data = _datacontext.AreaMsts.ToList();
            foreach(var iteam in data)
            {
                AreaModelList arealist = new AreaModelList()
                {
                    areaid=iteam.areaid,
                    areaname=iteam.areaname,
                    cityid=iteam.cityid,
                };
                area.Add(arealist);
            }
            return area;
        }

        public void areaadd(AreaModelList areaadd)
        {
            AreaMst area = new AreaMst()
            {
                areaname=areaadd.areaname,
                cityid=areaadd.cityid,
            };
            _datacontext.AreaMsts.Add(area);
            _datacontext.SaveChanges();
        }
    }
}

using Meta_Ads_World.Data;

namespace Meta_Ads_World.Models
{
    public class AreaModel
    {
        public int areaid { get; set; }
        public string areaname { get; set; }
        public int cityid { get; set; }
    }

    public class AreaModelList : AreaModel
    {
        public List<AreaModelList> arealist { get; set; }
        public List<CityMst> citylist { get; set; }
    }

}

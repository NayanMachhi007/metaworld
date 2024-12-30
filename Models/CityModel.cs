using Meta_Ads_World.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace Meta_Ads_World.Models
{
    public class CityModel
    {
        public int cityid { get; set; }
        public string cityname { get; set; }
        public int stateid { get; set; }
        public StateMst state { get; set; }
    }

    public class CityModelList : CityModel
    {
        public List<CityModelList> CityList { get; set; }
        public List<StateMst> StateMstList { get; set; }
    }
}

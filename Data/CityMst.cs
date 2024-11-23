using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Meta_Ads_World.Data
{
    public class CityMst
    {
        [Key]
        public int cityid { get; set; }
        public string cityname { get; set; }
        public int stateid { get; set; }


    }
}

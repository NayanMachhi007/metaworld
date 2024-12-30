using System.ComponentModel.DataAnnotations;

namespace Meta_Ads_World.Data
{
    public class AreaMst
    {
        [Key]
        public int areaid { get; set; }
        public string areaname { get; set; }
        public int cityid { get; set; }
    }
}

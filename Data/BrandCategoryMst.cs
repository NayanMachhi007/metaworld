using System.ComponentModel.DataAnnotations;

namespace Meta_Ads_World.Data
{
    public class BrandCategoryMst
    {
        [Key]
        public int bcategoryid { get; set; }
        public string bcategoryname { get; set; }
        public Boolean bcategorystatus { get; set; }
    }
}

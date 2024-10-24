namespace Meta_Ads_World.Models
{
    public class BrandCategoryModel
    {
        public int bcategoryid { get; set; }
        public string bcategoryname { get; set; }
        public Boolean bcategorystatus { get; set; }
    }

    public class BrandCategoryModelList : BrandCategoryModel
    {
        public List<BrandCategoryModelList> BrandCategoryList { get; set; }
    }
}
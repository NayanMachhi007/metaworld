using Meta_Ads_World.Data;
using Meta_Ads_World.Models;
using System.Diagnostics.CodeAnalysis;

namespace Meta_Ads_World.Repository
{
    public class BrandRepository
    {
        private readonly DataContext _datacontext;

        public BrandRepository(DataContext datacontext)
        {
            _datacontext = datacontext;
        }

        public List<BrandRegistrationModelList> BrandRegisterList()
        {
            List<BrandRegistrationModelList> list = new List<BrandRegistrationModelList>();
            var data = _datacontext.BrandRegistrationMst.ToList();
            foreach (var item in data)
            {
                BrandRegistrationModelList brandlist = new BrandRegistrationModelList()
                {
                    id = item.id,
                    bname = item.bname,
                    bemail = item.bemail,
                    bcontactno = item.bcontactno,
                    bcountry = item.bcountry,
                    bstate = item.bstate,
                    bcity = item.bcity,
                    bpassword = item.bpassword,
                    bstatus = item.bstatus,
                };
                list.Add(brandlist);
            }
            return list;
        }

        public void BrandRegistrationAdd(BrandRegistrationModelList brand)
        {
            BrandRegistrationMst brandregi = new BrandRegistrationMst()
            {
                bname = brand.bname,
                bemail = brand.bemail,
                bcontactno = brand.bcontactno,
                bcountry = brand.bcountry,
                bstate = brand.bstate,
                bcity = brand.bcity,
                bpassword = brand.bpassword,
                bstatus = brand.bstatus,
               
            };
            _datacontext.Add(brandregi);
            _datacontext.SaveChanges();
        }

        //Brand Category List
        public List<BrandCategoryModelList> BrandCategoryList(BrandRegistrationModelList brand)
        {
            List<BrandCategoryModelList> brandcate = new List<BrandCategoryModelList>();
            var data = _datacontext.BrandCategoryMst.ToList();
            foreach (var item in data)
            {
                BrandCategoryModelList category = new BrandCategoryModelList()
                {
                    bcategoryid = item.bcategoryid,
                    bcategoryname = item.bcategoryname,
                    bcategorystatus = item.bcategorystatus,
                };
                brandcate.Add(category);
            }
            return brandcate;

        }
    }
}
using System.ComponentModel.DataAnnotations;

namespace Meta_Ads_World.Data
{
    public class InstaPostBudgetMst
    {
        [Key]
        public int instapostbudgetid { get; set; }
        public int instalikebudget { get; set; }
        public int instacommentbudget { get; set; }
        public int instasharebudget { get; set; }
        public int instasavebudget { get; set; }
        public Boolean status { get; set; }
    }
}

namespace Meta_Ads_World.Models
{
    public class InstaPostBudgetModel
    {
        public int instapostbudgetid { get; set; }
        public int instalikebudget { get; set; }
        public int instacommentbudget { get; set; }
        public int instasharebudget { get; set; }
        public int instasavebudget { get; set; }
    }

    public class InstaPostBudgetModelList : InstaPostBudgetModel
    {
        public List<InstaPostBudgetModelList> instaPostBudgetModelLists { get; set; }
    }
}

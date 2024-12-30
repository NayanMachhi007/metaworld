using Meta_Ads_World.Data;

namespace Meta_Ads_World.Models
{
    public class YouTubePostBudgetModel
    {
        public int youtubepostbudgetid { get; set; }
        public int youtubelikebudget { get; set; }
        public int youtubecommentbudget { get; set; }
        public int youtubesharebudget { get; set; }
        public int youtubesavebudget { get; set; }
        public Boolean status { get; set; }
    }

    public class YouTubePostBudgetModeliList : YouTubePostBudgetModel
    {
        public List<YouTubePostBudgetModeliList> youTubePostBudgetModeliLists { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace Meta_Ads_World.Data
{
    public class YouTubePostBudgetMst
    {

        [Key]
        public int youtubepostbudgetid { get; set; }
        public int youtubelikebudget { get; set; }
        public int youtubecommentbudget { get; set; }
        public int youtubesharebudget { get; set; }
        public int youtubesavebudget { get; set; }
    }
}

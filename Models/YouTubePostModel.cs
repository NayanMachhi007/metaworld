using Meta_Ads_World.Data;
using System.ComponentModel.DataAnnotations;

namespace Meta_Ads_World.Models
{
    public class YouTubePostModel
    {
        public int youtubepostid { get; set; }
        public string youtubeposttotallike { get; set; }
        public string youtubepostcomment { get; set; }
        public string youtubepostshare { get; set; }
        public string youtubepostsave { get; set; }
        public DateTime youtubepoststartingdate { get; set; } = DateTime.Now;
        public DateTime youtubepostendingdate { get; set; } = DateTime.Now;
        public Boolean youtubepostlikestatus { get; set; }
        public Boolean youtubepostcommentstatus { get; set; }
        public Boolean youtubepostsharestatus { get; set; }
        public Boolean youtubepostsavestatus { get; set; }
        public string youtubeposturl { get; set; }

        [Required(ErrorMessage = "Please Enter The How Many User")]
        public string youtubeposttotalbudget { get; set; }

        //Youtube Post Budget Mst Field List
        public int youtubelikebudget { get; set; }
        public int youtubecommentbudget { get; set; }
        public int youtubesharebudget { get; set; }
        public int youtubesavebudget { get; set; }
    }

    public class YoutTubePostModelList : YouTubePostModel
    {
        public List<YouTubePostBudgetMst>? youtubepostbudgetmstslist { get; set; }
        public List<YoutTubePostModelList>? YouTubeList { get; set; }
    }
}

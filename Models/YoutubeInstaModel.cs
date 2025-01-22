using Meta_Ads_World.Data;

namespace Meta_Ads_World.Models
{
    public class YoutubeInstaModel
    {
        public IEnumerable<InstaPostMst> Insta { get; set; }
        public IEnumerable<YouTubePostMst> youTube{ get; set; }
    }
}

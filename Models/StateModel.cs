namespace Meta_Ads_World.Models
{
    public class StateModel
    {
        public int stateid { get; set; }
        public string statename { get; set; }
    }

    public class StateModelList : StateModel
    { 
        public List<StateModelList> statelist { get; set; }
    }
}

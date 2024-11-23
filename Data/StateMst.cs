using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace Meta_Ads_World.Data
{
    public class StateMst
    {
        [Key]
        public int stateid { get; set; }
        public string statename { get; set; }

    }
}

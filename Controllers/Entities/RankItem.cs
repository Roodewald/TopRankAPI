using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TopRankAPI.Entities
{
    public class RankItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id {get;set;}
        public required float Time { get; set; }
        public required string PlayerName { get; set; } = string.Empty;
        public required string GameVersion { get; set; } = "1";
    }
}
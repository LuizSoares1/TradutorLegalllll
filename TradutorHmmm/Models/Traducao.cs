using System.ComponentModel.DataAnnotations;

namespace TradutorHmmm.Models
{
    public class Traducao
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Palavra { get; set; }
        [Required]
        public string Traducaoo { get; set; }
    }
}

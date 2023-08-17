using System.ComponentModel.DataAnnotations;

namespace TradutorHmmm.Data.Dto
{
    public class ObterTraducaoRequest
    {
        [Required]
        public string Palavra { get; set; }
    }
}

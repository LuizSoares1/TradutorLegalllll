using System.ComponentModel.DataAnnotations;

namespace TradutorHmmm.Models
{

    //MAGNO CARALHO, ANALISA SAPORRA E ME EXPLICA PQ ESSA CARALHA TÁ RETORNANDO ERRO 404, SENDO QUE A LÓGICA ESTÁ CERTA 😡😡😡😡😡😡
    public class Traducao
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Palavra { get; set; }
        [Required]
        public string PalavraTraduzida { get; set; }
    }
}

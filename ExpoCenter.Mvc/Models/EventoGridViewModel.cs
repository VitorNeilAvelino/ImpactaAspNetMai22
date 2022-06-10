using System.ComponentModel.DataAnnotations;

namespace ExpoCenter.Mvc.Models
{
    public class EventoGridViewModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime Data { get; set; }

        [Required]
        public string Local { get; set; }

        [Required]
        [Display(Name = "Preço")]
        [DataType(DataType.Currency)]
        public decimal Preco { get; set; }

        public bool Selecionado { get; set; }
    }
}
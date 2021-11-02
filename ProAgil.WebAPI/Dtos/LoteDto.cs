using System.ComponentModel.DataAnnotations;

namespace ProAgil.WebAPI.Dtos
{
    public class LoteDto
    {
        public int Id { get; set; }
       
        [Required]
        public string Nome { get; set; }
        
        [Required]
        public decimal Preco { get; set; }
        public string DataInicio { get; set; }
        public string DataFim { get; set; }
        public int Quantidade { get; set; }

        public int EventoId { get; set; }
        public EventoDto Evento { get; }  
        
    }
}
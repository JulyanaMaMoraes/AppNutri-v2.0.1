using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Teste.Models
{
    public class Caloria
    {
        [Key]
        public int Id { get; set; }

        
        [Display(Name = "Data da Refeição")]
        [StringLength(50, MinimumLength = 4)]
        public string Data_Refeicao { get; set; }


        
        [Display(Name = "Horário da Refeição")]
        [StringLength(50, MinimumLength = 4)]
        public string Horario_Refeicao { get; set; }


       
        [Display(Name = "Refeição")]
        [StringLength(50, MinimumLength = 4)]
        public string Refeicao { get; set; }


        
        [Display(Name = "Peso da Refeição")]
        [StringLength(50, MinimumLength = 4)]
        public string Peso_Refeicao { get; set; }

        //public ICollection<Cadastro> Cpf { get; set; }

        [Display(Name = "CPF")]
        [StringLength(20, MinimumLength = 8)]
        public string CPF { get; set; }

        
    }
}

using System.ComponentModel.DataAnnotations;


namespace Teste.Models
{
    public class Paciente
    {
        //[Key]
        //public int Id { get; set; }

        [Required]
        [Display(Name = "Nome da Pessoa")]
        [StringLength(50, MinimumLength = 8)]
        public string Nome { get; set; }

        [Key]
        [Required]
        [Display(Name = "Cpf da Pessoa")]
        [StringLength(20, MinimumLength = 8)]

        public string CPF { get; set; }



        [Required]
        [Display(Name = "Email da Pessoa")]
        [StringLength(50, MinimumLength = 8)]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Telefone da Pessoa")]
        [StringLength(50, MinimumLength = 8)]
        public string telefone { get; set; }

        [Required]
        [Display(Name = "Idade da Pessoa")]
        [StringLength(50, MinimumLength = 1)]
        public string Idade { get; set; }

        [Required]
        [Display(Name = "Username da Pessoa")]
        [StringLength(50, MinimumLength = 8)]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(50, MinimumLength = 4)]
        public string Password { get; set; }


        [Required]
        [Display(Name = "Comorbidade da Pessoa")]
        [StringLength(255, MinimumLength = 8)]
        public string Comorbidade { get; set; }

        [Required]
        [Display(Name = "Preferencia Alimentar da Pessoa")]
        [StringLength(255, MinimumLength = 8)]
        public string Preferencia_Alimentar { get; set; }


        [Required]
        [Display(Name = "Objetivo da Pessoa")]
        [StringLength(255, MinimumLength = 8)]
        public string Objetivo { get; set; }

        [Required]
        [Display(Name = "Exercicio Habitual da Pessoa")]
        [StringLength(255, MinimumLength = 8)]
        public string Exercicio_Habitual { get; set; }

        [Required]
        [Display(Name = "Alimentacao Habitual da Pessoa")]
        [StringLength(255, MinimumLength = 8)]
        public string Alimentacao_Habitual { get; set; }

        public virtual ICollection<Caloria> Caloria { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoPromocao2.Models
{
    public class PROMOCAOO
    {
        private int      ID_PROMOCAO;
        private string   NOME;
        private string   DETALHES;
        private string   CATEGORIA;
        private DateTime DATA_INICIO;
        private DateTime DATA_FIM;
        private decimal  VALOR;
        private string   ESTADO;
        private string   CIDADE;
        private string   BAIRRO;
        private string   RUA;
        private int      NUMERO;
        private int      LIMITE_DE_CUPONS;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PROMOCAOO()
        {
            this.TB_PROMOCAO = new HashSet<USUARIO_SISTEMA>();
        }

        public PROMOCAOO() { }

        [Key]
        public int ID_PROMOCAO { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório")]
        [Display(Name = " Nome")]
        public string NOME { get; set; }

        [Required(ErrorMessage = "Detalhes é obrigatório")]
        [Display(Name = " Detalhes")]
        public string DETALHES { get; set; }

        [Required(ErrorMessage = "Categoria é obrigatório")]
        [Display(Name = " Categoria")][Required(ErrorMessage = "Nome é obrigatório")]
        [Display(Name = " Nome")]
        public string CATEGORIA { get; set; }

        [Required(ErrorMessage = "Data Inicio é obrigatório")]
        [Display(Name = " Data Inicio")]
        public System.DateTime DATA_INICIO { get; set; }

        [Required(ErrorMessage = "Data Fim é obrigatório")]
        [Display(Name = " Data Fim")]
        public Nullable<System.DateTime> DATA_FIM { get; set; }

        [Required(ErrorMessage = "Valor é obrigatório")]
        [Display(Name = " Valor")]
        public decimal VALOR { get; set; }

        [Required(ErrorMessage = "Estado é obrigatório")]
        [Display(Name = " Estado")]
        public string ESTADO { get; set; }

        [Required(ErrorMessage = "Cidade é obrigatório")]
        [Display(Name = " Cidade")]
        public string CIDADE { get; set; }

        [Required(ErrorMessage = "Bairro é obrigatório")]
        [Display(Name = " Bairro")]
        public string BAIRRO { get; set; }

        [Required(ErrorMessage = "Rua é obrigatório")]
        [Display(Name = " Rua")]
        public string RUA { get; set; }

        [Required(ErrorMessage = "Numero é obrigatório")]
        [Display(Name = " Numero")]
        public Nullable<int> NUMERO { get; set; }

        [Required(ErrorMessage = "Limite de Cupons é obrigatório")]
        [Display(Name = " Limite de Cupons")]
        public int LIMITE_DE_CUPONS { get; set; }

    }
}

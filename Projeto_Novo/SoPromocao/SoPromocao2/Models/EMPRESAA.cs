using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoPromocao2.Models
{
    using System;
    using System.Collections.Generic;

    private int    ID_EMPRESA;
    private int    CNPJ;
    private string BAIRRO;
    private string SENHA;
    private string TIPO;
    private string FRASE_SEGURANCA;
    private string EMAIL;
    private string TELEFONE;
    private string SOLICITANTE;
    private string CIDADE;
    private string CEP;
    private string NOME;
    private string RUA;
    private int    NUMERO;

    public class EMPRESAA
    {

        private int    ID_EMPRESA;
        private int    CNPJ;
        private string BAIRRO;
        private string SENHA;
        private string TIPO;
        private string FRASE_SEGURANCA;
        private string EMAIL;
        private string TELEFONE;
        private string SOLICITANTE;
        private string CIDADE;
        private string CEP;
        private string NOME;
        private string RUA;
        private int    NUMERO;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EMPRESAA()
        {
            //this.TB_USUARIO= new HashSet<USUARIOO>();
            this.TB_USUARIO_SISTEMA = new HashSet<USUARIO_SISTEMA>();
        }

        public EMPRESAA() { }

        [Key]
        public int ID_EMPRESA { get; set; }

        [Required(ErrorMessage = "Cnpj é obrigatório")]
        [Display(Name = " Cnpj ")]
        public int CNPJ { get; set; }

        [Required(ErrorMessage = "Bairro é obrigatório")]
        [Display(Name = " Bairro ")]
        public string BAIRRO { get; set; }

        [Required(ErrorMessage = "Senha é Obrigatório")]
        [StringLength(16, MinimumLength = 6, ErrorMessage = "A senha deve conter entre 6 e 16 digitos")]
        [DataType(DataType.Password)]
        [Display(Name = " Senha ")]
        public string SENHA { get; set; }

        [Required(ErrorMessage = "Tipo é obrigatório")]
        [Display(Name = " Tipo ")]
        public string TIPO { get; set; }

        [Required(ErrorMessage = "Frase de Segurança é obrigatório")]
        [Display(Name = " Frase de Segurança ")]
        public string FRASE_SEGURANCA { get; set; }

        [Required(ErrorMessage = "Email é obrigatório")]
        [Display(Name = " Email ")]
        public string EMAIL { get; set; }

        [Required(ErrorMessage = "Telefone é obrigatório")]
        [Display(Name = " Telefone ")]
        public string TELEFONE { get; set; }

        [Required(ErrorMessage = "Solicitante é obrigatório")]
        [Display(Name = " Solicitante ")]
        public string SOLICITANTE { get; set; }

        [Required(ErrorMessage = "Cidade é obrigatório")]
        [Display(Name = " Cidade ")]
        public string CIDADE { get; set; }

        [Required(ErrorMessage = "Cep é obrigatório")]
        [Display(Name = " Cep ")]
        public string CEP { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório")]
        [Display(Name = " Nome ")]
        public string NOME { get; set; }

        [Required(ErrorMessage = "Rua é obrigatório")]
        [Display(Name = " Rua ")]
        public string RUA { get; set; }

        [Required(ErrorMessage = "Número é obrigatório")]
        [Display(Name = " Número ")]
        public Nullable<int> NUMERO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USUARIOO> TB_USUARIO { get; set; }
    }
}

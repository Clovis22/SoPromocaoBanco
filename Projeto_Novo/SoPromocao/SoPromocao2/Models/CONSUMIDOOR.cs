
namespace SoPromocao2 {

    using System;
    using System.Collections.Generic;

    public class CONSUMIDOOR
    {

        private int      ID_CONSUMIDOR;
        private int      RG_C;
        private string   NOME;
        private string   SOBRENOME;
        private string   EMAIL;
        private string   SEXO;
        private string   FRASE_DE_SEGURANCA;
        private string   SENHA;
        private DateTime DATA_DE_NASCIMENTO;
        private string   ENDERECO;
        private string   TELEFONE;
        private string   CIDADE;
        private string   ESTADO;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CONSUMIDOOR()
        {
            this.TB_USUARIO_SISTEMA = new HashSet<USUARIO_SISTEMA>();
        }

        public CONSUMIDOOR() { }

        [Key]
        public int ID_CONSUMIDOR { get; set; }

        [Required(ErrorMessage = "Rg é Obrigatório")]
        [StringLength(10, MinimumLength = 7, ErrorMessage = "O RG contém no mínimo 7 dígitos")]
        [Display(Name = "Rg")]
        public int RG_C { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório")]
        [Display(Name = " Nome")]
        public string NOME { get; set; }

        [Required(ErrorMessage = "Sobrenome é obrigatório")]
        [Display(Name = "Sobrenome")]
        public string SOBRENOME { get; set; }

        [Required(ErrorMessage = "Email é obrigatório")]
        [Display(Name = " Email ")]
        public string EMAIL { get; set; }

        [Required(ErrorMessage = "Sexo é obrigatório")]
        [Display(Name = " Sexo")]
        public string SEXO { get; set; }

        [Required(ErrorMessage = "Frase de Segurança é obrigatório")]
        [Display(Name = " Frase de Sgurança")]
        public string FRASE_DE_SEGURANCA { get; set; }

        [Required(ErrorMessage = "Senha é Obrigatório")]
        [StringLength(16, MinimumLength = 6, ErrorMessage = "A senha deve conter entre 6 e 16 digitos")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string SENHA { get; set; }

        [Required(ErrorMessage = "Data de Nascimento é obrigatório")]
        [Display(Name = " Data de Nascimento")]
        public System.DateTime DATA_DE_NASCIMENTO { get; set; }

        [Required(ErrorMessage = "Endereco é obrigatório")]
        [Display(Name = " Endereco")]
        public string ENDERECO { get; set; }

        [Required(ErrorMessage = "Telefone é Obrigatório")]
        [StringLength(16, MinimumLength = 8, ErrorMessage = "O telefone deve conter entre 8 e 16 digitos")]
        [Display(Name = "Telefone")]
        public string TELEFONE { get; set; }

        [Required(ErrorMessage = "Cidade é obrigatório")]
        [Display(Name = " Cidade")]
        public string CIDADE { get; set; }

        [Required(ErrorMessage = "Estado é obrigatório")]
        [Display(Name = " Estado")]
        public string ESTADO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USUARIO_SISTEMA> TB_USUARIO_SISTEMA { get; set; }

    }

}
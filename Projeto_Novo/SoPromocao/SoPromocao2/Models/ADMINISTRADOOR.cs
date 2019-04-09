
namespace ADMINISTRADOOR.Models
{

    using System;
    using System.Collections.Generic;
    public class AMINISTRADOOR
    {
        private int    ID_ADMINISTRADOR;
        private int    RG_A;
        private string NOME;
        private string SOBRENOME;
        private string EMAIL;
        private string SENHA;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ADMINISTRADOOR()
        {
            this.TB_USUARIO_SISTEMA = new HashSet<USUARIO_SISTEMA>();
        }

        [Key]
        public int ID_ADMINISTRADOR { get; set; }

        [Required(ErrorMessage = "Rg é Obrigatório")]
        [StringLength(10, MinimumLength = 7, ErrorMessage = "O RG contém no mínimo 7 dígitos")]
        [Display(Name = "Rg")]
        public int RG_A { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório")]
        [Display(Name = " Nome")]
        public string NOME { get; set; }

        [Required(ErrorMessage = "Sobrenome é obrigatório")]
        [Display(Name = "Sobrenome")]
        public string SOBRENOME { get; set; }

        [Required(ErrorMessage = "Email é obrigatório")]
        [Display(Name = " Email ")]
        public string EMAIL { get; set; }

        [Required(ErrorMessage = "Senha é Obrigatório")]
        [StringLength(16, MinimumLength = 6, ErrorMessage = "A senha deve conter entre 6 e 16 digitos")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string SENHA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USUARIO_SISTEMA> TB_USUARIO_SISTEMA { get; set; }

    }

}
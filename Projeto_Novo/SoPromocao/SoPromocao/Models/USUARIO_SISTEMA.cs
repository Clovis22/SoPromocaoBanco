//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SoPromocao.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class USUARIO_SISTEMA
    {
        public int ID { get; set; }
        public Nullable<int> ID_CONSUMIDOR { get; set; }
        public Nullable<int> ID_ADMINISTRADOR { get; set; }
        public Nullable<int> ID_USUARIO_EMPRESA { get; set; }
    
        public virtual ADMINISTRADOR TB_ADMINISTRADOR { get; set; }
        public virtual CONSUMIDOR TB_CONSUMIDOR { get; set; }
        public virtual USUARIO_EMPRESA TB_USUARIO_EMPRESA { get; set; }
    }
}

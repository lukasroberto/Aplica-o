//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Monial
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cliente_Usuario_Alarme
    {
        public int cli_usu_ala_id { get; set; }
        public Nullable<int> usuario_id { get; set; }
        public Nullable<long> cli_id { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        public virtual Usuario_Alarme Usuario_Alarme { get; set; }
    }
}

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
    
    public partial class Usuario_Alarme
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuario_Alarme()
        {
            this.Cliente_Usuario_Alarme = new HashSet<Cliente_Usuario_Alarme>();
        }
    
        public int usuario_id { get; set; }
        public string usuario_nome { get; set; }
        public string usuario_senha { get; set; }
        public string usuario_obs { get; set; }
        public long cli_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cliente_Usuario_Alarme> Cliente_Usuario_Alarme { get; set; }
    }
}

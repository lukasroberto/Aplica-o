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
    
    public partial class Cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cliente()
        {
            this.Chip = new HashSet<Chip>();
            this.Cliente_Procedimentos = new HashSet<Cliente_Procedimentos>();
            this.Cliente_Servico = new HashSet<Cliente_Servico>();
            this.Cliente_Usuario_Alarme = new HashSet<Cliente_Usuario_Alarme>();
            this.Leitor = new HashSet<Leitor>();
            this.OS = new HashSet<OS>();
        }
    
        public long cli_id { get; set; }
        public string cli_nome { get; set; }
        public string cli_rua { get; set; }
        public string cli_numero { get; set; }
        public string cli_bairro { get; set; }
        public Nullable<int> cidade_id { get; set; }
        public string cli_estado { get; set; }
        public string cli_telefone { get; set; }
        public string cli_cad_por { get; set; }
        public Nullable<System.DateTime> cli_data_cad { get; set; }
        public string cli_telefone1 { get; set; }
        public Nullable<int> emp_id { get; set; }
        public Nullable<bool> cli_monitorado { get; set; }
        public Nullable<System.DateTime> cli_ultima_comunicacao { get; set; }
        public string cli_obs { get; set; }
        public Nullable<System.DateTime> cli_data_cancelado_mon { get; set; }
        public string cli_comunicacao { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Chip> Chip { get; set; }
        public virtual Cidade Cidade { get; set; }
        public virtual Empresa Empresa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cliente_Procedimentos> Cliente_Procedimentos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cliente_Servico> Cliente_Servico { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cliente_Usuario_Alarme> Cliente_Usuario_Alarme { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Leitor> Leitor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OS> OS { get; set; }
    }
}

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
    
    public partial class OS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OS()
        {
            this.OS_Tecnico = new HashSet<OS_Tecnico>();
        }
    
        public long os_id { get; set; }
        public Nullable<long> cli_id { get; set; }
        public System.DateTime os_data_ini { get; set; }
        public Nullable<System.DateTime> os_ini_serv { get; set; }
        public Nullable<System.DateTime> os_fim_serv { get; set; }
        public string os_serv_sol { get; set; }
        public string os_serv_efe { get; set; }
        public Nullable<int> os_status { get; set; }
        public string os_obs { get; set; }
        public string os_expedidor { get; set; }
        public Nullable<System.DateTime> os_data_agend { get; set; }
        public string os_pecas_util { get; set; }
        public string os_pecas_retir { get; set; }
        public string os_solicitada_por { get; set; }
        public Nullable<int> os_tipo { get; set; }
        public Nullable<System.TimeSpan> os_tempo_servico { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OS_Tecnico> OS_Tecnico { get; set; }
    }
}

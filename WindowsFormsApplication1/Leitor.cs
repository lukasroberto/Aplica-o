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
    
    public partial class Leitor
    {
        public long eve_id { get; set; }
        public System.DateTime eve_data_hora { get; set; }
        public string eve_hora { get; set; }
        public string eve_data { get; set; }
        public long cli_id { get; set; }
        public string eve_codigo_evento { get; set; }
        public string eve_conta_grupo_receptor { get; set; }
        public string eve_particao { get; set; }
        public string eve_protocolo { get; set; }
        public string eve_usuario_zona { get; set; }
        public Nullable<int> eve_status { get; set; }
        public string status { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        public virtual Evento Evento { get; set; }
        public virtual Receptores Receptores { get; set; }
    }
}
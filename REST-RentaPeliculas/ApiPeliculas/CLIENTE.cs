//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApiPeliculas
{
    using System;
    using System.Collections.Generic;
    using System.Xml.Serialization;

    public partial class CLIENTE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CLIENTE()
        {
            this.FICHARENTA = new List<FICHARENTA>();
            this.MEMBRESIA1 = new List<MEMBRESIA>();
        }
    
        public string CLIID { get; set; }
        public string MEMID { get; set; }
        public string NOMBRECLI { get; set; }
        public string CEDULACLI { get; set; }
        public string EMAILCLI { get; set; }
    
        public virtual MEMBRESIA MEMBRESIA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<FICHARENTA> FICHARENTA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [XmlIgnore]
        public virtual List<MEMBRESIA> MEMBRESIA1 { get; set; }
    }
}

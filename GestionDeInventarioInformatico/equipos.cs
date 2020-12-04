//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestionDeInventarioInformatico
{
    using System;
    using System.Collections.Generic;
    
    public partial class equipos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public equipos()
        {
            this.historialCambios = new HashSet<historialCambios>();
            this.perifericos = new HashSet<perifericos>();
            this.usuarios = new HashSet<usuarios>();
        }
    
        public int idEquipo { get; set; }
        public string nombre { get; set; }
        public string modelo { get; set; }
        public System.DateTime fecCompra { get; set; }
        public Nullable<System.DateTime> garantia { get; set; }
        public int ram { get; set; }
        public short idRamTipo { get; set; }
        public Nullable<int> idMarca { get; set; }
        public Nullable<int> idDepartamento { get; set; }
        public int idProveedor { get; set; }
        public int idTipoEquipo { get; set; }
        public string motherboard { get; set; }
        public string cpu { get; set; }
        public string gpu { get; set; }
        public int hdd { get; set; }
        public Nullable<int> ssd { get; set; }
        public short hddUnidad { get; set; }
        public short ssdUnidad { get; set; }
    
        public virtual departamentos departamentos { get; set; }
        public virtual unidadAlmacenamiento unidadAlmacenamiento { get; set; }
        public virtual marcas marcas { get; set; }
        public virtual proveedores proveedores { get; set; }
        public virtual ramtipo ramtipo { get; set; }
        public virtual tipoEquipos tipoEquipos { get; set; }
        public virtual unidadAlmacenamiento unidadAlmacenamiento1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<historialCambios> historialCambios { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<perifericos> perifericos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<usuarios> usuarios { get; set; }
    }
}

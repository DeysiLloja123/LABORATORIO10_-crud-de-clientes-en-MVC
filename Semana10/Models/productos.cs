//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Semana10.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class productos
    {
        public productos()
        {
            this.detallesdepedidos = new HashSet<detallesdepedidos>();
        }
    
        public int idproducto { get; set; }
        public string nombreProducto { get; set; }
        public Nullable<int> idProveedor { get; set; }
        public Nullable<int> idCategoria { get; set; }
        public string cantidadPorUnidad { get; set; }
        public Nullable<decimal> precioUnidad { get; set; }
        public Nullable<short> unidadesEnExistencia { get; set; }
        public Nullable<short> unidadesEnPedido { get; set; }
        public Nullable<short> nivelNuevoPedido { get; set; }
        public Nullable<short> suspendido { get; set; }
        public string categoriaProducto { get; set; }
    
        public virtual categorias categorias { get; set; }
        public virtual ICollection<detallesdepedidos> detallesdepedidos { get; set; }
        public virtual proveedores proveedores { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FerreteriaYerias
{
    using System;
    using System.Collections.Generic;
    
    public partial class DETALLE_COMPROBANTE
    {
        public int IdDetalle { get; set; }
        public Nullable<int> IdComprobante { get; set; }
        public Nullable<int> CodProd { get; set; }
        public Nullable<int> CantProd { get; set; }
        public Nullable<decimal> PrecioVenta { get; set; }
        public Nullable<decimal> ImporteProd { get; set; }
    
        public virtual COMPROBANTE COMPROBANTE { get; set; }
        public virtual PRODUCTO PRODUCTO { get; set; }
    }
}
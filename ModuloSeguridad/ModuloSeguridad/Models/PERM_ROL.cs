//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModuloSeguridad.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PERM_ROL
    {
        public string COD_PRROL { get; set; }
        public string COD_ROL { get; set; }
        public string COD_PERM { get; set; }
    
        public virtual PERMISOS PERMISOS { get; set; }
        public virtual ROLES ROLES { get; set; }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BDAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Meals
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Meals()
        {
            this.Menus = new HashSet<Menus>();
        }
    
        public string id_mea { get; set; }
        public string id_tmea { get; set; }
        public string mea_name { get; set; }
        public string mea_desc { get; set; }
        public string mea_cost { get; set; }
        public string mea_pic { get; set; }
    
        public virtual TypeMeal TypeMeal { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Menus> Menus { get; set; }
    }
}

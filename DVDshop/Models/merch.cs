//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DVDshop.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class merch
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public merch()
        {
            this.sostav = new HashSet<sostav>();
        }
    
        public int id { get; set; }
        public string photo { get; set; }
        public string name { get; set; }
        public string dexcription { get; set; }
        public string manufacturer { get; set; }
        public int price { get; set; }
        public Nullable<int> discount { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sostav> sostav { get; set; }
        public bool TextColor
        {
            get
            {
                if (Convert.ToDouble(discount) != 0) return true;
                else return false;
            }
        }
        public string Arrow
        {
            get
            {
                if (TextColor) return "Strikethrough";
                else return "None";
            }

        }
        public string newcost
        {
            get
            {
                if (TextColor) return Convert.ToString((Convert.ToDouble(price)) - Convert.ToDouble(price) * Convert.ToDouble(discount) / 100);
                else return "";
            }

        }
    }
}

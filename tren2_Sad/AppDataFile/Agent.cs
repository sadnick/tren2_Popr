//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace tren2_Sad.AppDataFile
{
    using System;
    using System.Collections.Generic;
    
    public partial class Agent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Agent()
        {
            this.ProductDiscount = new HashSet<ProductDiscount>();
            this.TypeAgent1 = new HashSet<TypeAgent>();
        }
    
        public int ID { get; set; }
        public string TypeAgent { get; set; }
        public string NameCompany { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string LogoImage { get; set; }
        public string LegalAddress { get; set; }
        public string PriorityDelivery { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Patronymic { get; set; }
        public string INN { get; set; }
        public string KPP { get; set; }
        public Nullable<int> ProductID { get; set; }
    
        public virtual Product Product { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductDiscount> ProductDiscount { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TypeAgent> TypeAgent1 { get; set; }
    }
}

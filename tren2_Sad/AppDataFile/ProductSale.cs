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
    
    public partial class ProductSale
    {
        public int ID { get; set; }
        public string Product { get; set; }
        public string NameAgent { get; set; }
        public string AmountProduction { get; set; }
        public Nullable<System.DateTime> DateRealization { get; set; }
        public Nullable<int> ProductID { get; set; }
    
        public virtual Product Product1 { get; set; }
    }
}

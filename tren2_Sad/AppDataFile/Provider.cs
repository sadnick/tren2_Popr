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
    
    public partial class Provider
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string INN { get; set; }
        public string Type { get; set; }
        public Nullable<int> HistoryProviderID { get; set; }
        public Nullable<int> ProductionID { get; set; }
    
        public virtual HistoryProvider HistoryProvider { get; set; }
        public virtual Production Production { get; set; }
    }
}

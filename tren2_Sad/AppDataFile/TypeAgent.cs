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
    
    public partial class TypeAgent
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public int AgentID { get; set; }
    
        public virtual Agent Agent { get; set; }
    }
}

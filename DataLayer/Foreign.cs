//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Foreign
    {
        public int foreign_id { get; set; }
        public System.TimeSpan travel_time { get; set; }
        public int stop_number { get; set; }
        public string stop_path { get; set; }
        public int flight_id { get; set; }
    
        public virtual Flight Flight { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class viewInfo
    {
        public int id { get; set; }
        public Nullable<int> taskId { get; set; }
        public Nullable<int> employeeId { get; set; }
        public Nullable<System.DateTime> sheetDate { get; set; }
        public Nullable<System.TimeSpan> startingHour { get; set; }
        public Nullable<System.TimeSpan> endingHour { get; set; }
        public string TaskName { get; set; }
        public string ProjectName { get; set; }
        public string CustomerName { get; set; }
    }
}

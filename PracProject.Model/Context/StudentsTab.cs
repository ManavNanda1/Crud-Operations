//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PracProject.Model.Context
{
    using System;
    using System.Collections.Generic;
    
    public partial class StudentsTab
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Email { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public string Department { get; set; }
        public Nullable<int> Country { get; set; }
        public Nullable<int> State { get; set; }
    
        public virtual Country Country1 { get; set; }
        public virtual state state1 { get; set; }
    }
}
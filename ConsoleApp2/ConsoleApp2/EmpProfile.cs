//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApp2
{
    using System;
    using System.Collections.Generic;
    
    public partial class EmpProfile
    {
        public int EmpCode { get; set; }
        public byte[] EmpName { get; set; }
        public System.DateTime DateOfBirth { get; set; }
        public int DeptCode { get; set; }
    
        public virtual DeptInfo DeptInfo { get; set; }
    }
}

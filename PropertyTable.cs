//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication4
{
    using System;
    using System.Collections.Generic;
    
    public partial class PropertyTable
    {
        public int Id { get; set; }
        public string PropertyType { get; set; }
        public string PropertyCatagory { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Location { get; set; }
        public string Status { get; set; }
        public Nullable<int> Price { get; set; }
        public Nullable<int> Size { get; set; }
        public byte[] Image { get; set; }
    }
}
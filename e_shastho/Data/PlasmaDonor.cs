//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace e_shastho.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class PlasmaDonor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
        public System.DateTime CoronaAffectedDate { get; set; }
        public System.DateTime RecoveryDate { get; set; }
        public string BloodGroup { get; set; }
        public string Email { get; set; }
        public bool HasDonated { get; set; }
        public bool IsVerified { get; set; }
    }
}

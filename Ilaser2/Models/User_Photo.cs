//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ilaser2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class User_Photo
    {
        public int Photo_Id { get; set; }
        public string Photo_URL { get; set; }
        public int User_Id { get; set; }
    
        public virtual User User { get; set; }
    }
}

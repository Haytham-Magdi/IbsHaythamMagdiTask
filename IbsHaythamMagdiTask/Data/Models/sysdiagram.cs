//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IbsHaythamMagdiTask.Data.Models
{
    using System;
    using System.Collections.Generic;
    
    using System.ComponentModel.DataAnnotations;
    
    public partial class sysdiagram
    {
    
    //	one
        [Required]
    public string name { get; set; } // hhh
    
    //	one
        [Required]
    public int principal_id { get; set; } // hhh
    
    //	one
        [Required]
    public int diagram_id { get; set; } // hhh
    
    //	one
        [Required]
    public Nullable<int> version { get; set; } // hhh
    
    //	one
        [Required]
    public byte[] definition { get; set; } // hhh
    }
}

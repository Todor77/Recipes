//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Recipees
{
    using System;
    using System.Collections.Generic;
    
    public partial class recipe
    {
        public int recipe_id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    
        public virtual recipe_ingredient recipe_ingredient { get; set; }
    }
}
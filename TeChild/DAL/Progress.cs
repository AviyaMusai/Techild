//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Progress
    {
        public int id { get; set; }
        public int userId { get; set; }
        public int lessonAndSubjectId { get; set; }
        public int isPass { get; set; }
        public int mark { get; set; }
    
        public virtual Lessons Lessons { get; set; }
        public virtual Users Users { get; set; }
    }
}
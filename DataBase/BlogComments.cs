//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class BlogComments
    {
        public int CommentId { get; set; }
        public Nullable<int> React { get; set; }
        public string CommenterName { get; set; }
        public string CommenterPic { get; set; }
        public string Comment { get; set; }
        public Nullable<int> BlogId { get; set; }
    
        public virtual Blog Blog { get; set; }
    }
}

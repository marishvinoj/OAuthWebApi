//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OAuthWebApi2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ApiUser
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ApiUser()
        {
            this.User_Roles = new HashSet<User_Roles>();
        }
    
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserPasswd { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User_Roles> User_Roles { get; set; }
    }
}

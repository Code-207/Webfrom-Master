//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Code923.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Users
    {
        public System.Guid Users_Id { get; set; }
        public string Users_Account { get; set; }
        public string Users_Password { get; set; }
        public string Users_NickName { get; set; }
        public string Users_Photo { get; set; }
        public System.Guid Users_RolesId { get; set; }
        public Nullable<int> Users_DeleteId { get; set; }
        public System.DateTime Users_CreateTime { get; set; }
        public System.DateTime Users_UpdateTime { get; set; }
    }
}

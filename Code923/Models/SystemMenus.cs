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
    
    public partial class SystemMenus
    {
        public System.Guid SystemMenus_Id { get; set; }
        public string SystemMenus_Title { get; set; }
        public string SystemMenus_Link { get; set; }
        public Nullable<System.Guid> SystemMenus_ParentId { get; set; }
        public string SystemMenus_Icon { get; set; }
        public Nullable<int> SystemMenus_DeleteId { get; set; }
        public System.DateTime SystemMenus_CreateTime { get; set; }
        public System.DateTime SystemMenus_UpdateTime { get; set; }
    }
}

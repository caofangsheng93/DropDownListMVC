//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace DropDownBandingMVC
{
    using System;
    using System.Collections.Generic;
    
    public partial class States
    {
        public States()
        {
            this.Cities = new HashSet<Cities>();
        }
    
        public int StatedId { get; set; }
        public string StateName { get; set; }
    
        public virtual ICollection<Cities> Cities { get; set; }
    }
}

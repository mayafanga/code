//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace BAR.TeamManager.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class activity
    {
        public int ID { get; set; }
        public string vcActivityName { get; set; }
        public string vcActivityIntroduce { get; set; }
        public string vcActivityTitle { get; set; }
        public string vcActivitySliderAddress { get; set; }
        public string vcThumbnailAddress { get; set; }
        public string vcParticipants { get; set; }
        public string vcActivityFileAddress { get; set; }
        public Nullable<System.DateTime> dHostTime { get; set; }
        public string vcHostAddress { get; set; }
        public string vcActivityAdvice { get; set; }
        public string vcActivityFeel { get; set; }
        public Nullable<System.DateTime> dActivityEndTime { get; set; }
        public Nullable<bool> bAudit { get; set; }
        public Nullable<bool> IsDel { get; set; }
    }
}

﻿using HeBianGu.Base.WpfBase;

namespace HeBianGu.ExplorePlayer.Base.Model
{

    public class mbc_db_areatype : StringEntityBase
    {
        [Display(Name = "类型名称")]
        public string Name { get; set; } 

        [Display(Name = "报警类型ID")]
        public string Value { get; set; }

        [Display(Name = "数据类型")]
        public string Text { get; set; } 

    }
}

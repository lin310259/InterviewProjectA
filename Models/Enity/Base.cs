﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using static WebApplication1.Models.EnumType;

namespace WebApplication1.Models.Enity
{
    public class Base
    {
        /// <summary>
        /// 資料建立日期
        /// </summary>
        [Column("CreateDate"), Display(Name = "資料建立日期")]
        [Required]
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// 資料修改日期
        /// </summary>
        [Column("ChangedDate"), Display(Name = "資料修改日期")]
        [Required]
        public DateTime ChangedDate { get; set; }

        /// <summary>
        /// 建立者UserPK
        /// </summary>
        [Column("CreateUserPK"), Display(Name = "建立者UserPK")]
        [Required]
        public long CreateUserPK { get; set; }

        /// <summary>
        /// 修改者UserPK
        /// </summary>
        [Column("ChangedUserPK"), Display(Name = "修改者UserPK")]
        [Required]
        public long ChangedUserPK { get; set; }

        /// <summary>
        /// 資料狀態
        /// 說明：[0=正常(預設)], [1=刪除]
        /// </summary>
        [Column("DataState"), Display(Name = "資料狀態")]
        [Required]
        public DataStatus DataState { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using static WebApplication1.Models.Enum;

namespace WebApplication1.Models.Enity
{
    public class User:Base
    {
        /// <summary>
        /// 使用者唯一識別碼PK
        /// </summary>
        [Column("UserPK"), Display(Name = "使用者唯一識別碼PK")]
        [Key, Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long UserPK { get; set; }

        /// <summary>
        /// 帳號
        /// </summary>
        [Column("UserAccount"), Display(Name = "帳號"), MaxLength(20)]
        [Required]
        public string UserAccount { get; set; }

        /// <summary>
        /// 密碼
        /// </summary>
        [Column("UserPassword"), Display(Name = "密碼"), MaxLength(20)]
        [Required]
        public string UserPassword { get; set; }

        /// <summary>
        /// 身分證號碼
        /// </summary>
        [Column("UserIDNO"), Display(Name = "身分證號碼"), MaxLength(20)]
        public string UserIDNO { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [Column("UserName"), Display(Name = "姓名"), MaxLength(120)]
        [Required]
        public string UserName { get; set; }

        /// <summary>
        /// 英文姓名
        /// </summary>
        [Column("UserEngName"), Display(Name = "英文姓名"), MaxLength(150)]
        public string UserEngName { get; set; }

        /// <summary>
        /// 性別
        /// 說明：[0=未知(預設)], [1=男]，[2=女]
        /// </summary>
        [Column("UserSex"), Display(Name = "性別")]
        [Required]
        public Sex UserSex { get; set; }

        /// <summary>
        /// 出生年月日
        /// </summary>
        [Column("UserBirthDay"), Display(Name = "出生年月日")]
        public DateTime? UserBirthDay { get; set; }

        /// <summary>
        /// 服務機構
        /// </summary>
        [Column("UADT01_20"), Display(Name = "服務機構")]
        public long ServOrg { get; set; }

        /// <summary>
        /// 服務部門
        /// </summary>
        [Column("UADT01_21"), Display(Name = "服務部門"), MaxLength(120)]
        public string ServDep { get; set; }

        /// <summary>
        /// 連絡電話
        /// </summary>
        [Column("UserContactTEL"), Display(Name = "連絡電話"), MaxLength(30)]
        public string UserContactTEL { get; set; }

        /// <summary>
        /// 行動電話
        /// </summary>
        [Column("UserMobile"), Display(Name = "行動電話"), MaxLength(30)]
        public string UserMobile { get; set; }

        /// <summary>
        /// 主要聯絡 Email 位址
        /// </summary>
        [Column("UserEMail1"), Display(Name = "主要聯絡Email位址"), MaxLength(200)]
        public string UserEMail1 { get; set; }

        /// <summary>
        /// 聯絡地址
        /// </summary>
        [Column("UserContactAddr"), Display(Name = "聯絡地址"), MaxLength(200)]
        public string UserContactAddr { get; set; }

        /// <summary>
        /// 備註
        /// </summary>
        [Column("UserMemo"), Display(Name = "備註")]
        public string UserMemo { get; set; }

    }
}

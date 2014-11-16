using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SIMNews.Models
{
    public class 教师
    {
        [Key]
        [Required]
        [MaxLength(8)]
        public string 工号 { get; set; }

        [Required]
        public string 姓名 { get; set; }

        public string 性别 { get; set; }

        public DateTime? 出生日期 { get; set; }

        [Required]
        public string 所在系部 { get; set; }

        public string 职称 { get; set; }

        public string 个人简介 { get; set; }

        public string 职务 { get; set; }

        public string 邮箱 { get; set; }

        public string 办公电话 { get; set; }

        public string 家庭电话 { get; set; }

        public string 手机 { get; set; }

        [Required]
        public string 角色 { get; set; }
    }
}
using System;
using System.ComponentModel.DataAnnotations;

namespace fuxi5.Domain
{
    public class Role
    {
        [Key]
        public int AId { get; set; }
        public string role { get; set; }//角色名
        public string jurisdiction { get; set; }//拥有权限
        public string describe { get; set; }//具体描述
    }
}

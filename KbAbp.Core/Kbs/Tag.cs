using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KbAbp.Kbs
{
    /// <summary>
    /// 标签
    /// </summary>
    public class Tag : Entity<long>
    {
        /// <summary>
        /// 名称
        /// </summary>
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// 使用次数
        /// </summary>
        public int UsedCount { get; set; }
    }
}

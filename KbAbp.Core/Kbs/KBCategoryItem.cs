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
    /// 知识项
    /// </summary>
    public class KbCategoryItem : Entity<long>
    {
        [Required]
        [MaxLength(100)]
        /// <summary>
        /// 知识条目值
        /// </summary>
        public string Name { get; set; }

        [MaxLength(100)]
        /// <summary>
        /// 代码
        /// </summary>
        public string Code { get; set; }

        [Required]
        /// <summary>
        /// 外键
        /// </summary>
        public long KbCategoryId { get; set; }

        /// <summary>
        /// 外键对象
        /// </summary>
        public KbCategory KbCategory { get; set; }
    }
}

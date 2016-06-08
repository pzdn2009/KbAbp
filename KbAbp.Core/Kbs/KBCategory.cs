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
    /// 知识库类别
    /// </summary>
    public class KbCategory : Entity<long>
    {
        [MaxLength(50)]
        [Required]
        /// <summary>
        /// 类别名称
        /// </summary>
        public virtual string Name { get; set; }

        [MaxLength(50)]
        /// <summary>
        /// 代码
        /// </summary>
        public virtual string Code { get; set; }
        
        /// <summary>
        /// 子项
        /// </summary>
        public virtual IEnumerable<KbCategoryItem> KBCategoryItems { get; set; }
    }
}

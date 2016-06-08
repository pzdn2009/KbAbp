using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KbAbp.Kbs
{
    public class KbQueue : Entity<long>, IHasCreationTime, IModificationAudited
    {
        /// <summary>
        /// 标题
        /// </summary>
        [MaxLength(100)]
        [Required]
        public string Title { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        [MaxLength(1000)]
        public string Url { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public KbQueueStatus Status { get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        public IEnumerable<Tag> Tags { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        public DateTime CreationTime
        {
            get; set;
        }

        /// <summary>
        /// 修改日期
        /// </summary>
        public DateTime? LastModificationTime
        {
            get; set;
        }

        /// <summary>
        /// 修改人
        /// </summary>
        public long? LastModifierUserId
        {
            get; set;
        }
    }
}

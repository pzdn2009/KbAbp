using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KbAbp.Kbs
{
    public class KnowledgeCategory : CreationAuditedEntity<long>
    {
        /// <summary>
        /// 知识点名称
        /// </summary>
        [MaxLength(100)]
        public string Name { get; set; }
    }
}

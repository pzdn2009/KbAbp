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
    public class Knowledge : FullAuditedEntity<long>
    {
        public long KnowledgeCategoryId { get; set; }

        public virtual KnowledgeCategory KnowledgeCategory { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(4000)]
        public string Detail { get; set; }
        

        public int Sort { get; set; }
    }
}

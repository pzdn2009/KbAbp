using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KbAbp.Projects
{
    [Table("Projects")]
    public class Project : Entity<long>, IHasCreationTime
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime CreationTime
        {
            get; set;
        }
    }
}

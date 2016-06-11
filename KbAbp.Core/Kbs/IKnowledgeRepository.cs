using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KbAbp.Kbs
{
    public interface IKnowledgeRepository : IRepository<Knowledge, long>
    {

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KbAbp.Kbs.Dtos
{
    public class GetKnowledgeOutput
    {
        public List<KnowledgeDto> Knowledges { get; set; }
    }
}

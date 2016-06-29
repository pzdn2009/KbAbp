using KbAbp.Kbs.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KbAbp.Kbs
{
    public interface IKnowledgeCategoryAppService
    {
        void CreateKnowledgeCategory(CreateKnowledgeCategoryInput input);

        GetKnowledgeCategoryOutput GetKnowledgeCategorys(GetKnowledgeCategoryInput input);
    }
}

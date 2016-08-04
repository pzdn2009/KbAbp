using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KbAbp.Kbs
{
    public class KnowledgeAppService : ApplicationService, IKnowledgeAppService
    {
        private IKnowledgeRepository knowledgeRepository;
        public KnowledgeAppService(IKnowledgeRepository knowledgeRepository)
        {
            this.knowledgeRepository = knowledgeRepository;
        }

        public void CreateKnowledge(CreateKnowledgeInput input)
        {
            var maxCnt = knowledgeRepository.GetAll().Where(zw => zw.KnowledgeCategoryId == input.KnowledgeCategoryId).Count();

            knowledgeRepository.Insert(new Knowledge()
            {
                CreationTime = DateTime.Now,
                CreatorUserId = null,
                LastModificationTime = DateTime.Now,
                LastModifierUserId = null,
                IsDeleted = false,
                Name = input.Name,
                Sort = maxCnt + 1,
                Detail = input.Detail,
                KnowledgeCategoryId = input.KnowledgeCategoryId
            });
        }
    }
}

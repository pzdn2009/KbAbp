using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using KbAbp.Kbs.Dtos;
using AutoMapper;

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

        public GetKnowledgeOutput GetKnowledges(GetKnowledgeInput input)
        {
            var q = knowledgeRepository.GetAll();

            if (input.KnowledgeCategoryId.HasValue)
            {
                q = q.Where(zw => zw.KnowledgeCategoryId == input.KnowledgeCategoryId.Value);
            }

            return new GetKnowledgeOutput()
            {
                 Knowledges = Mapper.Map<List<KnowledgeDto>>(q)
            };
        }
    }
}

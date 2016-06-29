using Abp.Application.Services;
using Abp.UI;
using AutoMapper;
using KbAbp.Kbs.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KbAbp.Kbs
{
    public class KnowledgeCategoryAppService : ApplicationService, IKnowledgeCategoryAppService
    {
        private IKnowledgeCategoryRepository _KnowledgeCategoryRepository;
        public KnowledgeCategoryAppService(IKnowledgeCategoryRepository knowledgeCategoryRepository)
        {
            this._KnowledgeCategoryRepository = knowledgeCategoryRepository;
        }

        public void CreateKnowledgeCategory(CreateKnowledgeCategoryInput input)
        {
            var exist = _KnowledgeCategoryRepository.GetAll().Where(zw => zw.Name == input.Name) != null;
            if (exist)
            {
                throw new UserFriendlyException(string.Format(L("XExists"), input.Name));
            }

            _KnowledgeCategoryRepository.Insert(new KnowledgeCategory()
            {
                Name = input.Name,
                CreationTime = DateTime.Now,
                CreatorUserId = null,
                KbCategoryItemId = input.KbCategoryItemId
            });
        }

        public GetKnowledgeCategoryOutput GetKnowledgeCategories(GetKnowledgeCategoryInput input)
        {
            var q = _KnowledgeCategoryRepository.GetAll();

            if (input.KbCategoryItemId.HasValue)
            {
                q = q.Where(zw => zw.KbCategoryItemId == input.KbCategoryItemId);
            }

            return new GetKnowledgeCategoryOutput()
            {
                KnowledgeCategories = Mapper.Map<List<KnowledgeCategoryDto>>(q)
            };
        }
    }
}

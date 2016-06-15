using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KbAbp.Kbs.Dtos;
using AutoMapper;

namespace KbAbp.Kbs
{
    public class KbCategoryItemAppService : ApplicationService, IKbCategoryItemAppService
    {
        private IKbCategoryRepository _KbCategoryRepository;
        private IKbCategoryItemRepository _KbCategoryItemRepository;
        public KbCategoryItemAppService(IKbCategoryRepository kbCategoryRepository, IKbCategoryItemRepository kbCategoryItemRepository)
        {
            _KbCategoryRepository = kbCategoryRepository;
            _KbCategoryItemRepository = kbCategoryItemRepository;
        }

        public int KbCategoryItemDto { get; private set; }
        public object KbCategoryItems { get; private set; }

        public void CreateKbCategoryItem(CreateKbCategoryItemInput input)
        {
            var kbCategory = _KbCategoryRepository.Get(input.KbCategoryId);
            _KbCategoryItemRepository.Insert(new KbCategoryItem()
            {
                Name = input.Name,
                Code = kbCategory.Code,
                KbCategoryId = input.KbCategoryId
            });
        }

        public GetKbCategoryItemOutput GetKbCategoryItems(GetKbCategoryItemInput input)
        {
            var q = _KbCategoryItemRepository.GetAll();
            if (input != null && input.KbCategoryId.HasValue)
            {
                q = q.Where(zw => zw.KbCategoryId == input.KbCategoryId.Value);
            }

            Mapper.CreateMap<KbCategoryItem, KbCategoryItemDto>();

            return new GetKbCategoryItemOutput()
            {
                KbCategoryItems = Mapper.Map<List<KbCategoryItemDto>>(q)
            };
        }
    }
}

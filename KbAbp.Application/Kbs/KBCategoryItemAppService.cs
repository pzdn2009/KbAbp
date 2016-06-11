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
        private IKbCategoryItemRepository _KbCategoryItemRepository;
        public KbCategoryItemAppService(IKbCategoryItemRepository kbCategoryItemRepository)
        {
            _KbCategoryItemRepository = kbCategoryItemRepository;
        }

        public int KbCategoryItemDto { get; private set; }
        public object KbCategoryItems { get; private set; }

        public void CreateKbCategoryItem(CreateKbCategoryItemInput input)
        {
            _KbCategoryItemRepository.Insert(new KbCategoryItem()
            {
                Name = input.Name,
                Code = input.Name,
                KbCategoryId = input.KbCategoryId
            });
        }

        public GetKbCategoryItemOutput GetKbCategoryItems(GetKbCategoryItemInput input)
        {
            var q = _KbCategoryItemRepository.GetAll();
            if (input != null)
            {
                q = q.Where(zw => zw.KbCategoryId == input.KbCategoryId);
            }

            Mapper.CreateMap<KbCategoryItem, KbCategoryItemDto>();

            return new GetKbCategoryItemOutput()
            {
                KbCategoryItems = Mapper.Map<List<KbCategoryItemDto>>(q)
            };
        }
    }
}

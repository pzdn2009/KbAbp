using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using KbAbp.Kbs.Dtos;

namespace KbAbp.Kbs
{
    public class KbCategoryAppService : ApplicationService, IKbCategoryAppService
    {
        private IKbCategoryRepository _kbCategoryRepository;

        public KbCategoryAppService(IKbCategoryRepository kbCategoryRepository)
        {
            _kbCategoryRepository = kbCategoryRepository;
        }

        public void CreateKbCategory(CreateKbCategoryInput input)
        {
            var dbKbCategory = _kbCategoryRepository.FirstOrDefault(zw => zw.Name == input.Name);
            if (dbKbCategory == null)
            {
                _kbCategoryRepository.Insert(new KbCategory()
                {
                    Name = input.Name,
                    Code = GetCode()
                });
            }
        }

        public GetKbCategoryOutput GetKbCategories(GetKbCategoryInput input)
        {
            var q = _kbCategoryRepository.GetAll();

            return new GetKbCategoryOutput()
            {
                KbCategories = Mapper.Map<List<KbCategoryDto>>(q)
            };
        }

        public static string GetCode()
        {
            return Convert.ToBase64String(Guid.NewGuid().ToByteArray());
        }
    }
}

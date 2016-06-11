using Abp.Application.Services.Dto;

namespace KbAbp.Kbs.Dtos
{
    public class KbCategoryItemDto : EntityDto<long>
    {
        public string Name { get; set;  }
    }
}
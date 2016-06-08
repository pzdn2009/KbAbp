using Abp.Application.Services.Dto;

namespace KbAbp.Kbs.Dtos
{
    public class KbCategoryDto : EntityDto<long>
    {
        public string Name { get; set; }
    }
}
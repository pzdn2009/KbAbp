using Abp.Application.Services.Dto;

namespace KbAbp.Kbs
{
    public class GetKnowledgeCategoryInput : IInputDto
    {
        public long? KbCategoryItemId { get; set; }
    }
}
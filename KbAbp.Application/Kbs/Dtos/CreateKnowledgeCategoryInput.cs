using Abp.Application.Services.Dto;

namespace KbAbp.Kbs
{
    public class CreateKnowledgeCategoryInput : IInputDto
    {
        public string Name { get; set; }

        public long KbCategoryItemId { get; set; }
    }
}
using Abp.Application.Services.Dto;

namespace KbAbp.Kbs
{
    public class CreateKnowledgeInput : IInputDto
    {
        public long KnowledgeCategoryId { get; set; }
        public string Name { get; set; }
        public string Detail { get; set; }
    }
}
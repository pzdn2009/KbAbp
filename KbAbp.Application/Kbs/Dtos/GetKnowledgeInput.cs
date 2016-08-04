using Abp.Application.Services.Dto;

namespace KbAbp.Kbs.Dtos
{
    public class GetKnowledgeInput : IInputDto
    {
        public long? KnowledgeCategoryId { get; set; }
    }
}

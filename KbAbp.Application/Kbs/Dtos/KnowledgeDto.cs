using Abp.Application.Services.Dto;

namespace KbAbp.Kbs.Dtos
{
    public class KnowledgeDto: EntityDto<long>
    {
        public long Sort { get; set; }

        public string Name { get; set; }

        public string Detail { get; set; }
    }
}

using KbAbp.Kbs.Dtos;

namespace KbAbp.Kbs
{
    public interface IKnowledgeAppService
    {
        void CreateKnowledge(CreateKnowledgeInput input);

        GetKnowledgeOutput GetKnowledges(GetKnowledgeInput input);
    }
}

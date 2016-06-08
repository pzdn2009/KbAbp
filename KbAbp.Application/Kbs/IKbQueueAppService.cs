using KbAbp.Kbs.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KbAbp.Kbs
{
    public interface IKbQueueAppService
    {
        GetKbQueueOutput GetKbQueues(GetKbQueueInput input);

        void UpdateKbQueue(UpdateKbQueueInput input);

        void CreateKbQueue(CreateKbQueueInput input);
    }
}

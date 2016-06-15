using Abp.Application.Services;
using Abp.Domain.Repositories;
using AutoMapper;
using KbAbp.Kbs.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KbAbp.Kbs
{
    public class KbQueueAppService : ApplicationService, IKbQueueAppService
    {
        private IRepository<KbQueue, long> _kbQueueRepository;

        public KbQueueAppService(IRepository<KbQueue, long> kbQueueRepository)
        {
            _kbQueueRepository = kbQueueRepository;
        }

        public void CreateKbQueue(CreateKbQueueInput input)
        {
            _kbQueueRepository.Insert(new KbQueue()
            {
                CreationTime = DateTime.Now,
                LastModificationTime = DateTime.Now,
                Status = KbQueueStatus.Active,
                Title = input.Title,
                Url = input.Url
            });
        }

        public GetKbQueueOutput GetKbQueues(GetKbQueueInput input)
        {
            var q = _kbQueueRepository.GetAll();

            return new GetKbQueueOutput()
            {
                KbQueues = Mapper.Map<List<KbQueueDto>>(q)
            };
        }

        public void UpdateKbQueue(UpdateKbQueueInput input)
        {
            throw new NotImplementedException();
        }
    }
}

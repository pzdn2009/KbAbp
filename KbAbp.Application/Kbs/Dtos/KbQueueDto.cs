using Abp.Application.Services.Dto;
using System;

namespace KbAbp.Kbs.Dtos
{
    public class KbQueueDto: EntityDto<long>
    {
        public string Title { get; set; }

        public string Url { get; set; }

        public byte Status { get; set; }

        public DateTime CreationTime { get; set; }
    }
}
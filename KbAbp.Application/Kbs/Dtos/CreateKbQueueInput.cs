using Abp.Application.Services.Dto;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace KbAbp.Kbs.Dtos
{
    public class CreateKbQueueInput : IInputDto
    {
        [Required]
        public string Title { get; set; }

        public string Url { get; set; }

        public string Tags { get; set; }

        public List<string> GetTagList()
        {
            var list = new List<string>();

            if (!string.IsNullOrEmpty(Tags))
            {
                list.AddRange(Tags.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries));
            }

            return list;
        }
    }
}
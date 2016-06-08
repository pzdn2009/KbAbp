using System;
using Abp.Application.Services.Dto;
using System.Collections.Generic;

namespace KbAbp.Kbs.Dtos
{
    public class GetKbCategoryOutput
    {
        public List<KbCategoryDto> KbCategories { get; set; }
    }
}
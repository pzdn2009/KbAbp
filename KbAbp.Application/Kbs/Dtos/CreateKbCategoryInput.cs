using Abp.Application.Services.Dto;
using System.ComponentModel.DataAnnotations;

namespace KbAbp.Kbs.Dtos
{
    public class CreateKbCategoryInput : IInputDto
    {
        [Required]
        public string Name { get; set; }
    }
}
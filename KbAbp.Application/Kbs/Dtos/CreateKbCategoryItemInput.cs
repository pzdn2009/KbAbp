using Abp.Application.Services.Dto;
using System.ComponentModel.DataAnnotations;

namespace KbAbp.Kbs.Dtos
{
    public class CreateKbCategoryItemInput : IInputDto
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public long KbCategoryId { get; set; }
    }
}
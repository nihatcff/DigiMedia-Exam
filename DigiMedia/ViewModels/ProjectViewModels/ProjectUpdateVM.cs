using System.ComponentModel.DataAnnotations;

namespace DigiMedia.ViewModels.ProjectViewModels
{
    public class ProjectUpdateVM
    {
        public int Id { get; set; }
        [Required,MaxLength(256),MinLength(3)]
        public string Title { get; set; } = string.Empty;
        public IFormFile? Image { get; set; }
        [Required]
        public int CategoryId { get; set; }
    }
}

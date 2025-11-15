using System.ComponentModel.DataAnnotations;

namespace OnatrixUmbraco.ViewModels
{
    public class ServiceQuestionFormViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Question { get; set; }

        public string? SuccessMessage { get; set; }
        public string? ErrorMessage { get; set; }
    }
}
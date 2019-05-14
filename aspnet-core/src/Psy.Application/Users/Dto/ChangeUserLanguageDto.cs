using System.ComponentModel.DataAnnotations;

namespace Psy.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
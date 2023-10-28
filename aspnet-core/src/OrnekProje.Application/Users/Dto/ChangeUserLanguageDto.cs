using System.ComponentModel.DataAnnotations;

namespace OrnekProje.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
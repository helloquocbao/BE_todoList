using System.ComponentModel.DataAnnotations;

namespace Sadec.TodoList.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
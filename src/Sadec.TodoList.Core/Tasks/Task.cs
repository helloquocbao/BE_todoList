using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;
using Abp.Timing;

namespace Sadec.TodoList.Tasks
{
    [Table("AppTasks")]
    public class Task : FullAuditedEntity<int>
    {
        public const int MaxTitleLength = 256;
        public const int MaxDescriptionLength = 64 * 1024; //64KB

        [Required]
        [MaxLength(MaxTitleLength)]
        public string Title { get; set; }

        [MaxLength(MaxDescriptionLength)]
        public string Description { get; set; }

        public bool isActive { get; set; }
        public Task()
        {
            CreationTime = Clock.Now;
            isActive = true;
        }

        public Task(string title, string description = null)
            : this()
        {
            Title = title;
            Description = description;
        }
    }
}

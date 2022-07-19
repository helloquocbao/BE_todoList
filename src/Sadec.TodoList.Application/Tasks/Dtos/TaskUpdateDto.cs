using Abp.AutoMapper;

namespace Sadec.TodoList.Tasks.Dtos
{
    //[AutoMapFrom(typeof(Task))]
    public class TaskUpdateDto
    {
        public int? id;
        public string? Title;
        public string? description;
        public bool? isActive;
    }
}

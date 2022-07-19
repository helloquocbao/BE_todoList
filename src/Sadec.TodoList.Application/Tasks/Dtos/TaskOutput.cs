using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sadec.TodoList.Tasks.Dtos
{
    //[AutoMapFrom(typeof(Task))]
    public class TaskOutput
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime CreationTime { get; set; }
        public bool isActive { get; set; }

    }
}

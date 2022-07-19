using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Sadec.TodoList.Tasks.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sadec.TodoList.Tasks
{
   public interface ITaskAppService : IApplicationService
    {
        Task<ListResultDto<TaskListDto>> GetAllAsync();
    }
}

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Sadec.TodoList.Tasks.Dtos;
using Microsoft.EntityFrameworkCore;
using Abp.UI;

namespace Sadec.TodoList.Tasks
{
    public class TaskAppService : TodoListAppServiceBase, ITaskAppService
    {
        private readonly IRepository<Task> _taskRepository;

        public TaskAppService(IRepository<Task> taskRepository)
        {
            _taskRepository = taskRepository;
        }
        public async Task<ListResultDto<TaskListDto>> GetAllAsync()
        {
            var tasks = await _taskRepository
                   .GetAll()    
                   .OrderByDescending(t => t.CreationTime)
                   .ToListAsync();

            return new ListResultDto<TaskListDto>(
                ObjectMapper.Map<List<TaskListDto>>(tasks)
            );
        }
            
        public async Task<TaskOutput> CreateAsync(TaskInput input)
        {
            var task = ObjectMapper.Map<Task>(input);
           
            return ObjectMapper.Map<TaskOutput>(await _taskRepository.InsertAsync(task));
        }

        public async System.Threading.Tasks.Task DeleteAsync(int input)
        {
           
            await _taskRepository.DeleteAsync(input);
        }

        public async Task<TaskOutput> GetAsync(int id)
        {
            var task = await _taskRepository.FirstOrDefaultAsync(id);

            return ObjectMapper.Map<TaskOutput>(task);
        }

        public async Task<TaskOutput> UpdateAsync(TaskUpdateDto input)
        {
            var task = await _taskRepository.GetAsync((int)input.id);
            if (task == null)
                throw new UserFriendlyException("TodoCanNotUpdate");
            task.Title = input?.Title;
            task.Description = input.description;
            await _taskRepository.UpdateAsync(task);

            return ObjectMapper.Map<TaskOutput>(task);
        }

    }
}
    
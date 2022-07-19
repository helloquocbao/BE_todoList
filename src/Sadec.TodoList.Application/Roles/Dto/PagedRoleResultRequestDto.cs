using Abp.Application.Services.Dto;

namespace Sadec.TodoList.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}


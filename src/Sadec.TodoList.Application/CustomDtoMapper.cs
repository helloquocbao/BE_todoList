using AutoMapper;
using Sadec.TodoList.Roles.Dto;
using Sadec.TodoList.Tasks.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sadec.TodoList
{
    public static class CustomDtoMapper
    {

        public static void CreateMappings(IMapperConfigurationExpression configuration)
        {
            //task
            configuration.CreateMap<Sadec.TodoList.Tasks.Task, TaskOutput>();
            configuration.CreateMap<TaskInput, Sadec.TodoList.Tasks.Task>();
            configuration.CreateMap<TaskUpdateDto, Sadec.TodoList.Tasks.Task>();

            //role
            configuration.CreateMap<Sadec.TodoList.Authorization.Roles.Role, RoleDto>();
            configuration.CreateMap<Sadec.TodoList.Authorization.Roles.Role, RoleEditDto>();
            
        }


    }
}

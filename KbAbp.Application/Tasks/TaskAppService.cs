using Abp.Application.Services;
using Abp.Domain.Repositories;
using AutoMapper;
using KbAbp.Tasks.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KbAbp.Tasks
{
    public class TaskAppService : ApplicationService, ITaskAppService
    {
        private readonly ITaskRepository _taskRepository;

        public TaskAppService(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public Dtos.GetTasksOutput GetTasks(Dtos.GetTasksInput input)
        {
            var tasks = _taskRepository.GetAll();

            if (input != null && input.State.HasValue)
            {
                tasks = tasks.Where(zw => zw.State == input.State);
            }

            tasks = tasks.OrderBy(zw => zw.State).ThenBy(zw => zw.ProjectID)
                .ThenByDescending(zw => zw.CreationTime);

            Mapper.CreateMap<Task, TaskDto>().ForMember(dest => dest.ProjectName, option => option.MapFrom(
                 src => src.Project != null ? src.Project.Name : string.Empty));

            var ret= new GetTasksOutput()
            {
                Tasks = Mapper.Map<List<TaskDto>>(tasks)
            };

            return ret;
        }

        public void UpdateTask(Dtos.UpdateTaskInput input)
        {
            //We can use Logger, it's defined in ApplicationService base class.
            Logger.Info("Updating a task for input: " + input);

            //Retrieving a task entity with given id using standard Get method of repositories.
            var task = _taskRepository.Get(input.TaskId);

            //Updating changed properties of the retrieved task entity.

            if (input.State.HasValue)
            {
                task.State = input.State.Value;
            }
        }

        public void CreateTask(Dtos.CreateTaskInput input)
        {
            Logger.Info("Creating a task for input: " + input);

            var task = new Task { Description = input.Description, ProjectID = input.ProjectID };

            _taskRepository.Insert(task);
        }
    }
}

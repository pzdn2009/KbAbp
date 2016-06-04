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
            //Called specific GetAllWithPeople method of task repository.
            if (input != null && input.State.HasValue)
            {

            }
            input = new GetTasksInput() { State = TaskState.Active };
            var tasks = _taskRepository.GetAll().ToList();
            var task = tasks.FirstOrDefault();
            //Used AutoMapper to automatically convert List<Task> to List<TaskDto>.
            return new GetTasksOutput
            {
                Tasks = new List<TaskDto>() {
                    new TaskDto() { Id = task.Id, CreationTime = task.CreationTime, Description =task.Description,
                     State = (byte)task.State }
                }
            };
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
            //We can use Logger, it's defined in ApplicationService class.
            Logger.Info("Creating a task for input: " + input);

            //Creating a new Task entity with given input's properties
            var task = new Task { Description = input.Description };

            //if (input.AssignedPersonId.HasValue)
            //{
            //    task.AssignedPerson = _personRepository.Load(input.AssignedPersonId.Value);
            //}

            //Saving entity with standard Insert method of repositories.
            _taskRepository.Insert(task);
        }
    }
}

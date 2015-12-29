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
            var tasks = _taskRepository.GetAll().Where(zw => zw.State == input.State);

            //Used AutoMapper to automatically convert List<Task> to List<TaskDto>.
            return new GetTasksOutput
            {
                Tasks = Mapper.Map<List<TaskDto>>(tasks)
            };
        }

        public void UpdateTask(Dtos.UpdateTaskInput input)
        {
            throw new NotImplementedException();
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

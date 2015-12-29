using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KbAbp.Tasks
{
    public class Task : Entity<long>, IHasCreationTime
    {
        public Task()
        {
            CreationTime = DateTime.Now;
            State = TaskState.Active;
        }
        /// <summary>
        /// Describes the task.
        /// </summary>
        public virtual string Description { get; set; }

        /// <summary>
        /// The time when this task is created.
        /// </summary>
        public virtual DateTime CreationTime { get; set; }

        /// <summary>
        /// Current state of the task.
        /// </summary>
        public virtual TaskState State { get; set; }
    }
}

using System;

namespace KontakteApp
{
    public class Task
    {
        private Int32 _id;
        private Employee _assignedTo;

        public int Id { get => _id; set => _id = value; }
        public Employee AssignedTo { get => _assignedTo; set => _assignedTo = value; }

        #region CTOR
        public Task(Int32 id)
        {
            _id = id;
        }

        public Task(Int32 id, Employee assignedTo)
        {
            Id = id;
            _assignedTo = assignedTo;
        }
        #endregion

    }
}

using System;
using System.Windows.Forms;

namespace KontakteApp
{
    public class Employee
    {
        private String _name;

        public string Name { get => _name; set => _name = value; }

        #region CTOR
        public Employee(String name)
        {
            Name = name;
        }
        #endregion

        public Employee Self
        {
            get { return this; }
        }

        public void RequestStatus(Int32 taskID)
        {
            MessageBox.Show(String.Format(
                "Status for task {0} has been requested from {1}.",
                taskID, Name), "Status Request");
        }
    }
}

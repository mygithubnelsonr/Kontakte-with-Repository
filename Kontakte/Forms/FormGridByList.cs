using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace KontakteApp
{
    public partial class FormGridByList : Form
    {
        #region privat Fields
        private bool _dgvFilled = false;
        private bool _needUpdate = false;
        private bool _newRowNeeded;
        private bool _isNewRow;
        private int _newRowIndex;
        private int _numberOfRows = 1000;
        private object _cellValue;
        private MyRepository _myrepository;
        private List<Person> people = new List<Person>();

        #endregion

        #region Properties
        public bool DgvFilled { get => _dgvFilled; set => _dgvFilled = value; }
        public bool NewRowNeeded { get => _newRowNeeded; set => _newRowNeeded = value; }
        public int NumberOfRows { get => _numberOfRows; set => _numberOfRows = value; }
        public MyRepository MyRepository { get => _myrepository; set => _myrepository = value; }
        public bool IsNewRow { get => _isNewRow; set => _isNewRow = value; }
        public int NewRowIndex { get => _newRowIndex; set => _newRowIndex = value; }
        #endregion

        #region CTOR
        public FormGridByList()
        {
            InitializeComponent();
        }
        #endregion

        private void FormGridByList_Load(object sender, EventArgs e)
        {
            MyRepository = new MyRepository();
            PopolateList();

        }

        private void FormGridByList_Resize(object sender, EventArgs e)
        {
            //Console.WriteLine($"Height={this.Height}");
        }

        private void toolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItemFill_Click(object sender, EventArgs e)
        {
            PopolateList();
        }

        private void toolStripMenuItemUpdate_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItemDelete_Click(object sender, EventArgs e)
        {
            int r = personenDataGridView.CurrentRow.Index;
            var id = personenDataGridView[0, r].Value;
            RecordDelete((int)id);
        }

        private void toolStripMenuItemTest_Click(object sender, EventArgs e)
        {
            // add a new person to database
            // TestAddPerson();
        }

        private void personenDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Console.WriteLine("personenDataGridView_RowHeaderMouseClick");
            //personenDataGridView.SelectionMode =
            //    DataGridViewSelectionMode.RowHeaderSelect;
            //personenDataGridView.Rows[e.RowIndex].Selected = true;

            //personenDataGridView.CurrentRow.DefaultCellStyle.BackColor = Color.Maroon;
            //personenDataGridView.CurrentRow.DefaultCellStyle.ForeColor = Color.White;

            if (IsNewRow && !NewRowNeeded)
            {
                RecordSave(e.RowIndex);
                IsNewRow = false;
            }
        }

        private void personenDataGridView_NewRowNeeded(object sender, DataGridViewRowEventArgs e)
        {
            Console.WriteLine("personenDataGridView_NewRowNeeded");
            NewRowNeeded = true;
            IsNewRow = false;
            personenDataGridView[0, e.Row.Index].Value = NewID();
        }

        private void personenDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (DgvFilled == false) return;

            Console.WriteLine("personenDataGridView_RowsAdded");

            if (NewRowNeeded)
            {
                NewRowNeeded = false;
                NumberOfRows = NumberOfRows + 1;
            }

            IsNewRow = true;
            NewRowIndex = e.RowIndex;
        }

        private void personenDataGridView_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvFilled == false) return;

            Console.WriteLine("personenDataGridView_RowLeave");

            if (IsNewRow && !NewRowNeeded)
            {
                RecordSave(e.RowIndex);
                IsNewRow = false;

            }
        }

        private void personenDataGridView_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            Console.WriteLine("personenDataGridView_CellValueNeeded");
        }

        private void personenDataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            Console.WriteLine("personenDataGridView_CellBeginEdit");
            _cellValue = personenDataGridView[e.ColumnIndex, e.RowIndex].Value;
        }

        private void personenDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("personenDataGridView_CellEndEdit");

            var cellvalue = personenDataGridView[e.ColumnIndex, e.RowIndex].Value;

            if (_cellValue != cellvalue)
            {
                _needUpdate = true;
            }
        }

        private void personenDataGridView_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            int id = 99;
            string field = "Firma";
            string value = "Gerke";

            if (_needUpdate)
            {
                RecordUpdate(id, field, value);

            }
        }

        void PopolateList()
        {
            DgvFilled = false;

            people = MyRepository.GetAllContacts();

            var list = new BindingList<Person>(people);

            // Die ComboBox-Spalte des Personen-DataGridView 
            // initialisieren
            DataGridViewCheckBoxColumn checkBoxColumn =
               (DataGridViewCheckBoxColumn)this.personenDataGridView.Columns["Kunde"];

            checkBoxColumn.FlatStyle = FlatStyle.Flat;
            checkBoxColumn.ThreeState = true;

            personenDataGridView.AutoGenerateColumns = false;
            this.personenDataGridView.DataSource = list;

            personenDataGridView.AutoResizeRowHeadersWidth(
                DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);

            foreach (DataGridViewRow row in personenDataGridView.Rows)
            {
                if (!row.IsNewRow)
                    row.HeaderCell.Value = $"{row.Index + 1}";
            }

            DgvFilled = true;
        }



        public int NewID()
        {
            int newID = -1;
            foreach (DataGridViewRow row in personenDataGridView.Rows)
            {
                if (row.IsNewRow) continue;
                if ((int)row.Cells[0].Value > newID)
                    newID = (int)row.Cells[0].Value;
            }
            return ++newID;
        }

        void RecordSave(int row)
        {
            Person person = new Person();

            person.Kontakt_Id = (int)personenDataGridView[0, row].Value;
            person.Vorname = (string)personenDataGridView[1, row].Value;
            person.Nachname = (string)personenDataGridView[2, row].Value;
            person.Firma = (string)personenDataGridView[3, row].Value;
            person.Telefon = (string)personenDataGridView[4, row].Value;
            person.Email = (string)personenDataGridView[5, row].Value;

            bool? k = (bool?)personenDataGridView["Kunde", row].Value;
            if (k != null) person.Kunde = k;

            DateTime? a = (DateTime?)personenDataGridView["Anruf", row].Value;
            if (a != null) person.Anruf = a;

            bool success = false;


            if (String.IsNullOrEmpty(person.Vorname) || String.IsNullOrEmpty(person.Nachname))
                toolStripStatusLabel1.Text = "invalide value! Check field 'Vorname' and 'Nachname'";
            else
            {
                List<Person> people = new List<Person>();
                people.Add(person);

                success = MyRepository.SaveRecord(people);

                if (success)
                    toolStripStatusLabel1.Text = "save record successfull";
                else
                    toolStripStatusLabel1.Text = "saving record failed!";
            }
        }

        void RecordUpdate(int id, string field, string value)
        {
            bool success = MyRepository.UpdateRecord(id, field, value);
        }

        void RecordDelete(int id)
        {
            Console.WriteLine("RecordDelete: Id={0}", id);
            bool success = MyRepository.DeleteRecord(id);

            if (success)
                toolStripStatusLabel1.Text = "delete record successfull";
            else
                toolStripStatusLabel1.Text = "deleting record failed!";
        }

        void RecordFind()
        {

        }

        void TestAddPerson()
        {
            Person person = new Person
            {
                Kontakt_Id = NewID(),
                Nachname = "Kalum",
                Vorname = "Susi",
                Firma = "Hanse",
                Telefon = "123-4578",
                Email = "sk.hanse.de",
                Kunde = true,
                Anruf = DateTime.Now
            };

            personenDataGridView.AutoResizeRowHeadersWidth(
                DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);

            List<Person> people = new List<Person>();
            people.Add(person);

            var result = MyRepository.SaveRecord(people);

            if (result == false)
                //throw new ArgumentException("Save record failed!");
                Console.WriteLine("Save record failed!");
        }


    }
}

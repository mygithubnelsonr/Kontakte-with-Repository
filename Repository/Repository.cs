using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

//ToDo: Repo as dll in a new project

namespace Repository
{
    public class MyRepository
    {
        #region Private Fields
        private string _connectionString;
        private string _caption;
        private SqlDataAdapter dataAdapter;
        private DataTable _table;
        #endregion

        #region Properties
        public string ConnectionString { get => _connectionString; set => _connectionString = value; }
        public string Caption { get => _caption; set => _caption = value; }
        public DataTable Table { get => _table; set => _table = value; }
        #endregion

        #region CTOR
        public MyRepository()
        {
            Init();
        }
        #endregion

        #region Public Methods
        public void Init()
        {
            Config config = Config.GetInstance("Config.xml");

            ConnectionString = config.ConnectionString;
            Caption = config.Caption;

            try
            {
                SQLHelper helper = new SQLHelper(ConnectionString);
                bool connectionOK = helper.IsConnected;
            }
            catch
            {
                throw new ArgumentException("Die Datenbank 'Kontakte' wurde nicht gefunden!\n" +
                    "Bitte die Datei 'KontakteApp.exe.config.deploy' anpassen.\n" +
                    "Das Programm wird jetzt beendet.");
            }
        }

        public List<Person> GetAllContacts()
        {
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            SqlCommand sqlCommand = new SqlCommand("select * from dbo.Personen", sqlConnection);
            dataAdapter = new SqlDataAdapter(sqlCommand);

            DataTable contacts = new DataTable();
            dataAdapter.Fill(contacts);

            List<Person> persons = new List<Person>();

            int records = 0;
            foreach (DataRow dr in contacts.Rows)
            {
                Console.WriteLine($"Id={dr[0]}");
                try
                {
                    Person person = new Person();
                    person.Kontakt_Id = (int)dr["Kontakt_Id"];
                    person.Vorname = (string)dr["Vorname"];
                    person.Nachname = (string)dr["Nachname"];
                    person.Firma = dr["Firma"] == DBNull.Value ? null : (string)dr["Firma"];
                    person.Telefon = dr["Telefon"] == DBNull.Value ? null : (string)dr["Telefon"];
                    person.Email = dr["Email"] == DBNull.Value ? null : (string)dr["Email"];
                    person.Kunde = dr["Kunde"] == DBNull.Value ? false : (bool)dr["Kunde"];
                    person.Anruf = dr["Anruf"] == DBNull.Value ? DateTime.MinValue : (DateTime)dr["Anruf"];

                    persons.Add(person);
                    ++records;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"can not read data! (record={dr[0]})");
                    Console.WriteLine(ex.Message);
                }

            }
            Console.WriteLine($"{records} records added");

            return persons;
        }

        public bool SaveRecord(List<Person> people)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                Person person = new Person();
                person = people[0];

                try
                {
                    if (String.IsNullOrEmpty(person.Vorname) || String.IsNullOrEmpty(person.Nachname))
                        throw new InvalidExpressionException();
                }
                catch (InvalidExpressionException ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }

                var tmp = "";
                string sql = $"Insert Into Personen (Vorname,Nachname,Firma,Telefon,Email,Kunde,Anruf) " +
                    $"Values (" +
                    // ToDo: validate of empty string 
                    $"'{person.Vorname}'," +
                    $"'{person.Nachname}',";
                tmp = person.Firma == null ? "Null," : $"'{person.Firma}',"; sql += tmp;
                tmp = person.Telefon == null ? "Null," : $"'{person.Telefon}',"; sql += tmp;
                tmp = person.Email == null ? "Null," : $"'{person.Email}',"; sql += tmp;
                tmp = person.Kunde == null ? "Null," : $"'{person.Kunde}',"; sql += tmp;
                tmp = person.Anruf == null ? "Null" : $"'{person.Anruf}',"; sql += tmp;
                sql += ")";

                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);
                    var result = command.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }
        }

        public bool UpdateRecord(int id, string field, object value)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();

                    string sql = $"Update Personen Set {field}='{value}' Where Kontakt_Id={id}";
                    SqlCommand command = new SqlCommand(sql, connection);
                    var result = command.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }
        }

        public bool DeleteRecord(int Id)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();

                    string sql = $"Delete From Personen Where Kontakt_Id={Id}";
                    SqlCommand command = new SqlCommand(sql, connection);
                    var result = command.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }
        }
        #endregion

    }
}

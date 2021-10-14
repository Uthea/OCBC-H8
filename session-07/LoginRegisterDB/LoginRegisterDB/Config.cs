using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;


namespace LoginRegisterDB
{
    class Config
    {
        string ConnectionString = "";
        public MySqlConnection connection = null;
        public string server = "127.0.0.1";
        public string user = "root";
        public string password = "root";

        DataSet ds;
        DataTable dt;

        public string Table = "user_info";
        public string connectionType = "";
        string RecordSource = "";

        DataGridView tempdata;

        public Config()
        {

        }

        // connect to database
        public void Connect(string database_name)
        {
            try
            {
                ConnectionString = string.Format("SERVER={0};DATABASE={1};UID={2};PASSWORD={3}"
                    , server, database_name, user, password);

                connection = new MySqlConnection(ConnectionString);
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        // create connection to mysql before execution
        public void nowquiee(string sl_comm)
        {
            try
            {
                MySqlConnection cs = new MySqlConnection(ConnectionString);
                cs.Open();
                MySqlCommand myc = new MySqlCommand(sl_comm, cs);
                myc.ExecuteNonQuery();
                cs.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        // execute select statements
        public void ExecuteSql(string Sql_command)
        {
            nowquiee(Sql_command);
        }


        // execute delete, insert and update
        public void Execute(string Sql_command)
        {
            RecordSource = Sql_command;
            connectionType = Table;
            dt = new DataTable(connectionType);

            try
            {
                string command = RecordSource.ToUpper();

                MySqlDataAdapter da2 = new MySqlDataAdapter(RecordSource, connection);

                DataSet tempds = new DataSet();
                da2.Fill(tempds, connectionType);
                // da2.Fill(tempds);


            }
            catch (Exception err) { MessageBox.Show(err.Message); }

        }

        // select based on column name and row index
        public string Results(int ROW, string COLUMN_NAME)
        {
            try
            {
                return dt.Rows[ROW][COLUMN_NAME].ToString();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return dt.Rows[ROW][COLUMN_NAME].ToString();
            }
        }

        // Execute select statement
        public void ExecuteSelect(string Sql_command)
        {
            RecordSource = Sql_command;
            connectionType = Table;

            dt = new DataTable(connectionType);

            try
            {
                string command = RecordSource;

                MySqlDataAdapter da = new MySqlDataAdapter(RecordSource, connection);
                ds = new DataSet();
                da.Fill(ds, connectionType);
                da.Fill(dt);
                tempdata = new DataGridView();


            }
            catch (Exception err) { MessageBox.Show(err.Message); }
        }

        public int Count()
        {
            return dt.Rows.Count;
        }


    }
}

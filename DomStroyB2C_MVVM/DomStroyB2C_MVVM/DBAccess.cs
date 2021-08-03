using System;
using MySql.Data.MySqlClient;
using System.Data;

namespace DomStroyB2C_MVVM
{
    public class DBAccess
    {
        private static MySqlConnection connection = new MySqlConnection();
        private static MySqlCommand command = new MySqlCommand();
        private static MySqlDataReader DbReader;
        private static MySqlDataAdapter adapter = new MySqlDataAdapter();
        public MySqlTransaction DbTran;
        //public static string ip_address = "";//;;;;//Persist Security Info=False;server=192.168.10.149

        public string strConnString = "datasource=127.0.0.1;port=3306;username=domstroy;password=2427651701;database=domstroy";

        public int executeDataAdapter(DataTable tblName, string strSelectMySql)
        {
            try
            {
                if (connection.State == 0)
                {
                    createConn();
                }
                adapter.SelectCommand.CommandText = strSelectMySql;
                adapter.SelectCommand.CommandType = CommandType.Text;
                MySqlCommandBuilder DbCommandBuilder = new MySqlCommandBuilder(adapter);
                DbCommandBuilder.ConflictOption = ConflictOption.OverwriteChanges;

                return adapter.Update(tblName);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public int AliExecuteDataAdapter(DataTable tblName, string strSelectMySql)
        {
            try
            {
                if (connection.State == 0)
                {
                    createConn();
                }
                adapter.SelectCommand.CommandText = strSelectMySql;
                adapter.SelectCommand.CommandType = CommandType.Text;
                MySqlCommandBuilder DbCommandBuilder = new MySqlCommandBuilder(adapter);
                DbCommandBuilder.ConflictOption = ConflictOption.OverwriteChanges;

                string inser = DbCommandBuilder.GetInsertCommand().ToString();
                string update = DbCommandBuilder.GetUpdateCommand().CommandText.ToString();
                string delete = DbCommandBuilder.GetDeleteCommand().CommandText.ToString();

                return adapter.Update(tblName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void beginTrans()
        {
            try
            {
                if (DbTran == null)
                {
                    if (connection.State == 0)
                    {
                        createConn();
                        DbTran = connection.BeginTransaction();
                        adapter.SelectCommand.Transaction = DbTran;
                    }
                    else
                    {
                        DbTran = connection.BeginTransaction();
                        adapter.SelectCommand.Transaction = DbTran;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void commitTrans()
        {
            try
            {
                if (DbTran != null)
                {
                    DbTran.Commit();
                    DbTran = null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void rollbackTrans()
        {
            try
            {
                if (DbTran != null)
                {
                    DbTran.Rollback();
                    DbTran = null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void createConn()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.ConnectionString = strConnString;
                    connection.Open();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void closeConn()
        {
            connection.Close();
        }

        public void readDatathroughAdapter(string query, DataTable tblName)
        {
            try
            {
                if (connection.State == 0)
                {
                    createConn();
                }
                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = CommandType.Text;

                adapter = new MySqlDataAdapter(command);
                adapter.Fill(tblName);

            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public MySqlDataReader readDatathroughReader(string query)
        {
            MySqlDataReader reader;
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    createConn();
                }

                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = CommandType.Text;

                reader = command.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }



        public int executeQuery(MySqlCommand dbCommand)
        {
            try
            {
                if (connection.State == 0)
                {
                    createConn();
                }
                dbCommand.Connection = connection;
                dbCommand.CommandType = CommandType.Text;

                return dbCommand.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}

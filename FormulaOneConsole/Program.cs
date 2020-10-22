using System;
using System.Data.SqlClient;
using System.IO;

namespace FormulaOneConsole
{
    class Program
    {

        public const string WORKINGPATH = @"C:\data\formulaone\";
        private const string CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + WORKINGPATH + @"FormulaOne.mdf;Integrated Security=True";
        private static string[] tableNames = { "Country", "Driver", "Team" };

        static void Main(string[] args)
        {
            char scelta = ' ';
            do
            {
                Console.WriteLine("\n*** FORMULA ONE - BATCH SCRIPTS ***\n");
                Console.WriteLine("1 - Create Countries");
                Console.WriteLine("2 - Create Teams");
                Console.WriteLine("3 - Create Drivers");
                Console.WriteLine("------------------");
                Console.WriteLine("R - RESET DB");
                Console.WriteLine("------------------");
                Console.WriteLine("X - EXIT\n");
                scelta = Console.ReadKey(true).KeyChar;
                switch (scelta)
                {
                    case '1':
                        ExecuteSqlScript("Countries.sql");
                        break;
                    case '2':
                        ExecuteSqlScript("Teams.sql");
                        break;
                    case '3':
                        ExecuteSqlScript("Drivers.sql");
                        break;
                    case 'R':
                        ResetDb();
                        break;
                    default:
                        if (scelta != 'X' && scelta != 'x') Console.WriteLine("\nUncorrect Choice - Try Again\n");
                        break;
                }
            } while (scelta != 'X' && scelta != 'x');
        }

        private static void ResetDb()
        {
            //System.IO.File.Copy(WORKINGPATH + "FormulaOne.mdf", WORKINGPATH + "Backup.mdf", true);
            BackupDb();
            bool OK = DropTable("Country");
            if (OK) OK = DropTable("Driver");
            OK = false;
            if (OK) OK = DropTable("Team");
            if (OK) OK = ExecuteSqlScript("Countries.sql");
            if (OK) OK = ExecuteSqlScript("Drivers.sql");
            if (OK) OK = ExecuteSqlScript("Teams.sql");
            if (OK)
            {
                //System.IO.File.Delete(WORKINGPATH + "Backup.mdf");
                Console.WriteLine("\nRESET DB OK\n\n");
            }
            else
            {
                //System.IO.File.Copy(WORKINGPATH + "Backup.mdf", WORKINGPATH + "FormulaOne.mdf", true);
                //System.IO.File.Delete(WORKINGPATH + "Backup.mdf");
                RestoreDb();
            }
        }

        private static void BackupDb()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
                {
                    string sqlStmt = "";
                    foreach (string table in tableNames)
                    {
                        sqlStmt += "DROP TABLE " + table + "_bck;";
                        sqlStmt += "SELECT * INTO " + table + "_bck FROM " + table + ";";
                    }
                    Console.WriteLine(sqlStmt);
                    using (SqlCommand bckCommand = new SqlCommand(sqlStmt, conn))
                    {
                        conn.Open();
                        bckCommand.ExecuteNonQuery();
                        conn.Close();
                        Console.WriteLine("Backup Created Sucessfully");
                    }
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine("Backup Not Created: " + exc.Message);
            }
        }

        private static void RestoreDb()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
                {
                    string sqlStmt = "";
                    foreach (string table in tableNames)
                    {
                        sqlStmt += "DROP TABLE " + table + ";";
                        sqlStmt += "SELECT * INTO " + table + " FROM " + table + "_bck;";
                    }
                    Console.WriteLine(sqlStmt);
                    using (SqlCommand bckCommand = new SqlCommand(sqlStmt, conn))
                    {
                        conn.Open();
                        bckCommand.ExecuteNonQuery();
                        conn.Close();
                        Console.WriteLine("DB Restored Sucessfully");
                    }
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine("DB Not Restored: " + exc.Message);
            }
        }

        private static bool DropTable(string tableName)
        {
            bool retVal = true;
            try
            {
                using (var con = new SqlConnection(CONNECTION_STRING))
                {
                    using (var cmd = new SqlCommand("Drop Table " + tableName + ";", con))
                    {
                        try
                        {
                            con.Open();
                            cmd.ExecuteNonQuery();
                            Console.WriteLine("\nDROP " + tableName + " - SUCCESS\n");
                        }
                        catch (SqlException err)
                        {
                            Console.WriteLine("\tErrore SQL: " + err.Number + " - " + err.Message);
                            retVal = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nDROP " + tableName + " - ERROR: " + ex.Message + "\n");
                retVal = false;
            }
            return retVal;
        }

        static bool ExecuteSqlScript(string sqlScriptName)
        {
            bool retVal = true;
            var fileContent = File.ReadAllText(WORKINGPATH + sqlScriptName);
            fileContent = fileContent.Replace("\r\n", "");
            fileContent = fileContent.Replace("\r", "");
            fileContent = fileContent.Replace("\n", "");
            fileContent = fileContent.Replace("\t", "");
            var sqlqueries = fileContent.Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
            try
            {
                using (var con = new SqlConnection(CONNECTION_STRING))
                {
                    using (var cmd = new SqlCommand("query", con))
                    {
                        con.Open(); int i = 0; int nErr = 0;
                        foreach (var query in sqlqueries)
                        {
                            cmd.CommandText = query; i++;
                            try
                            {
                                cmd.ExecuteNonQuery();
                            }
                            catch (SqlException err)
                            {
                                Console.WriteLine("Errore in esecuzione della query numero: " + i);
                                Console.WriteLine("\tErrore SQL: " + err.Number + " - " + err.Message);
                                nErr++;
                                retVal = false;
                            }
                        }
                        string finalMessage = nErr == 0 ? "Script " + sqlScriptName + " completed without errors." : "Script " + sqlScriptName + " completed with " + nErr + " ERRORS!";
                        Console.WriteLine("\n" + finalMessage + "\n");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nExecuteSqlScript " + sqlScriptName + " - ERROR: " + ex.Message + "\n");
                retVal = false;
            }
            return retVal;
        }
    }
}

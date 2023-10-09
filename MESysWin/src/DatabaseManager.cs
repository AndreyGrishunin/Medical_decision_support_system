using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MESysWin.src
{
    class DatabaseManager
    {
        // Реализация паттерна Singletone
        private static DatabaseManager instance;

        private DatabaseManager() {
            // Проверим папку DATA
            checkDataDir();
            // Проверим файл базы данных
            if (!File.Exists(DatabaseName))
            {
                // Если не существует, то сообщим, что создадим новую.
                Log.Print("Knowledge base and database do not exist. A new database file is created in \"" + DatabaseName + "\" the path.", "DatabaseManager", Log.type.WARNING);
                MessageBox.Show("Knowledge base and database do not exist. A new database file is created in \"" + DatabaseName + "\" the path.", "Database not exist", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Строка подключения к базе данных
            connection_string = "Data Source="
                + DatabaseName
                + ";";

            //conn = new SQLiteConnection(connection_string);
        }

        public static DatabaseManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DatabaseManager();
                    Log.Print("Create DatabaseManager instance singletone", "DatabaseManager", Log.type.INFO);
                }
                return instance;
            }
        }

        // Имя базы данных
        // KBofMD - Knowledge base of medical diagnosis
        private string database_name = "data\\KBofMD.db";
        public string DatabaseName
        {
            get { return database_name; }
        }

        // Проверка наличия папки DATA
        private bool checkDataDir()
        {
            if (!Directory.Exists("data"))
            {
                try
                {
                    Directory.CreateDirectory("data");
                    Log.Print("Create directory DATA", "DatabaseManager", Log.type.INFO);

                    return true;
                }
                catch (Exception ex)
                {
                    Log.Print(ex.Message, ex.Source, Log.type.ERROR);
                    Console.WriteLine(ex.Message);
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            } else
            {
                return true;
            }
        }

        private string connection_string;
        private SQLiteConnection conn;
        private object diagnose;

        private void OpenConnection()
        {
            conn = new SQLiteConnection(connection_string);

            try
            {
                // Подключаемся
                conn.Open();
                //Log.Print("Open connection database", "DatabaseManager", Log.type.INFO);
            }
            catch (SQLiteException ex)
            {
                // Сообщаем об ощибке подключения
                Log.Print(ex.Message, ex.Source, Log.type.ERROR);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateTables()
        {
            // Если подключение есть
            if (conn.State == ConnectionState.Open)
            {
                SQLiteCommand cmd = conn.CreateCommand();

                string sql_command = "PRAGMA foreign_keys = ON;";
                cmd.CommandText = sql_command;
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SQLiteException ex)
                {
                    Log.Print(ex.Message, ex.Source, Log.type.ERROR);
                    Console.WriteLine(ex.Message);
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Создадим таблицу Linguistic_variable, если она не существует
                CreateTable(conn, "linguistic_variable",
                    "id_ling_var INTEGER PRIMARY KEY AUTOINCREMENT",
                    "name TEXT NOT NULL",
                    "reasoning_bottom REAL NOT NULL",
                    "reasoning_top REAL NOT NULL");

                // Создадим таблицу MF_type, если она не существует
                CreateTable(conn, "mf_type",
                    "id_mf_type INTEGER PRIMARY KEY",
                    "name TEXT NOT NULL",
                    "description TEXT");

                // Создадим таблицу boundary_type, если она не существует
                CreateTable(conn, "boundary_type",
                    "id_bound INTEGER PRIMARY KEY",
                    "name TEXT NOT NULL",
                    "description TEXT");

                // Создадим таблицу Triangular_MF, если она не существует
                CreateTable(conn, "triangular_mf",
                    "id_triangl_mf INTEGER PRIMARY KEY AUTOINCREMENT",
                    //"id_mf_type INTEGER NOT NULL",
                    "a REAL NOT NULL",
                    "b REAL NOT NULL",
                    "c REAL NOT NULL");

                // Создадим таблицу Trapezoidal_MF, если она не существует
                CreateTable(conn, "trapezoidal_mf",
                    "id_trapez_mf INTEGER PRIMARY KEY AUTOINCREMENT",
                    //"id_mf_type INTEGER NOT NULL",
                    "a REAL NOT NULL",
                    "b REAL NOT NULL",
                    "c REAL NOT NULL",
                    "d REAL NOT NULL");

                // Создадим таблицу Gauss_MF, если она не существует
                CreateTable(conn, "gauss_mf",
                    "id_gauss_mf INTEGER PRIMARY KEY AUTOINCREMENT",
                    //"id_mf_type INTEGER NOT NULL",
                    "c REAL NOT NULL",
                    "q REAL NOT NULL");

                // Создадим таблицу Fuzzy_variable, если она не существует
                CreateTable(conn, "fuzzy_variable",
                    "id_var INTEGER PRIMARY KEY AUTOINCREMENT",
                    "id_ling_var INTEGER NOT NULL",
                    "name TEXT NOT NULL",
                    "id_mf_type INTEGER",
                    "id_bound INTEGER",
                    "id_triangl_mf INTEGER",
                    "id_trapez_mf INTEGER",
                    "id_gauss_mf INTEGER",
                    "r INTEGER",
                    "g INTEGER",
                    "b INTEGER",
                    "FOREIGN KEY (id_ling_var) REFERENCES linguistic_variable(id_ling_var) ON DELETE CASCADE",
                    "FOREIGN KEY (id_mf_type) REFERENCES mf_type(id_mf_type)",
                    "FOREIGN KEY (id_bound) REFERENCES boundary_type(id_bound)",
                    "FOREIGN KEY (id_triangl_mf) REFERENCES triangular_mf(id_triangl_mf)",
                    "FOREIGN KEY (id_trapez_mf) REFERENCES trapezoidal_mf(id_trapez_mf)",
                    "FOREIGN KEY (id_gauss_mf) REFERENCES gauss_mf(id_gauss_mf)");

                // Создадим таблицу Quantifier, если она не создана
                CreateTable(conn, "quantifier",
                    "id_quantifier INTEGER PRIMARY KEY AUTOINCREMENT",
                    "name TEXT",
                    "rule TEXT");

                // Создадим таблицу Diagnosis, если она не создана
                CreateTable(conn, "diagnosis",
                    "id_diagnosis INTEGER PRIMARY KEY AUTOINCREMENT",
                    "name TEXT",
                    "description TEXT",
                    "symptoms TEXT",
                    "treatment TEXT");

                // Создадим таблицу Patient, если она не создана
                CreateTable(conn, "patient",
                    "id INTEGER PRIMARY KEY AUTOINCREMENT",
                    "name TEXT",
                    "date TEXT",
                    "diagnosis TEXT");

                // Создадим таблицу Antecedent, если она не создана
                CreateTable(conn, "antecedent",
                    "id_antecedent INTEGER PRIMARY KEY AUTOINCREMENT",
                    "id_ling_var INTEGER NOT NULL",
                    "id_var INTEGER NOT NULL",
                    "id_quantifier INTEGER NOT NULL",
                    "preview TEXT",
                    //"id_next_ant INTEGER",
                    "FOREIGN KEY (id_ling_var) REFERENCES linguistic_variable(id_ling_var) ON DELETE CASCADE",
                    "FOREIGN KEY (id_var) REFERENCES fuzzy_variable(id_var) ON DELETE CASCADE",
                    "FOREIGN KEY (id_quantifier) REFERENCES quantifier(id_quantifier)");
                //   FOREIGN KEY(trackartist) REFERENCES artist(artistid)

                // Создадим таблицу knowledge_base, если она не создана
                CreateTable(conn, "knowledge_base",
                    "id_rule INTEGER PRIMARY KEY AUTOINCREMENT",
                    "id_diagnosis INTEGER NOT NULL",
                    "preview TEXT",
                    //"id_antecedent INTEGER",
                    "FOREIGN KEY (id_diagnosis) REFERENCES diagnosis(id_diagnosis) ON DELETE CASCADE");
                //"FOREIGN KEY (id_antecedent) REFERENCES antecedent(id_antecedent)");

                CreateTable(conn, "antecedent_list",
                    "id_rule INTEGER NOT NULL",
                    "id_antecedent INTEGER NOT NULL",
                    "FOREIGN KEY (id_rule) REFERENCES knowledge_base(id_rule) ON DELETE CASCADE",
                    "FOREIGN KEY (id_antecedent) REFERENCES antecedent(id_antecedent) ON DELETE CASCADE");

                // Создадим таблицу user_grop, если она не создана
                CreateTable(conn, "user_group",
                    "id_group INTEGER PRIMARY KEY AUTOINCREMENT",
                    "name TEXT",
                    "description TEXT");

                // Создаем таблицу login, если она не создана
                CreateTable(conn, "login",
                    "id_login INTEGER PRIMARY KEY AUTOINCREMENT",
                    "id_group INTEGER",
                    "login TEXT",
                    "password TEXT",
                    "FOREIGN KEY(id_group) REFERENCES user_group(id_group)");
            }
        }

        private void CloseConnection()
        {
            try
            {
                // Закрываем подключение
                conn.Dispose();
                //conn.Close();
                conn = null;
            } catch (SQLiteException ex)
            {
                // Сообщаем об ощибке отключения
                Log.Print(ex.Message, ex.Source, Log.type.ERROR);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // Первое подключение к базе данных
        public void DatabaseConnect()
        {
            OpenConnection();
            CreateTables();
            CloseConnection();
        }

        private void CreateTable(SQLiteConnection SQLiteCon, string name_table, params string[] fields)
        {
            SQLiteCommand cmd = SQLiteCon.CreateCommand();

            string sql_command = "CREATE table IF NOT EXISTS " + name_table + " (";
            for (int i = 0; i < fields.Length; i++)
            {
                sql_command += fields[i];
                if ((i + 1) < fields.Length)
                {
                    sql_command += ", ";
                } else
                {
                    sql_command += ");";
                }
            }

            cmd.CommandText = sql_command;
            try
            {
                cmd.ExecuteNonQuery();
                //Log.Print("CREATE table IF NOT EXISTS " + name_table, "DatabaseManager", Log.type.INFO);
            }
            catch (SQLiteException ex)
            {
                Log.Print(ex.Message, ex.Source, Log.type.ERROR);
                Console.WriteLine(ex.Message);
                //MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool DeleteFromTable(long id, string tableName, string columnName, bool checkIdInOtherTables = true)
        {
            bool res = false;
            OpenConnection();

            SQLiteCommand cmd = conn.CreateCommand();

            if (checkIdInOtherTables)
            {
                cmd.CommandText = "PRAGMA foreign_keys = ON;";
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SQLiteException ex)
                {
                    Log.Print(ex.Message, ex.Source, Log.type.ERROR);
                    Console.WriteLine(ex.Message);
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            cmd.CommandText = String.Format("DELETE FROM {0} WHERE {1} = '{2}'",
                tableName, columnName, id);

            try
            {
                cmd.ExecuteNonQuery();
                res = true;
            }
            catch (SQLiteException ex)
            {
                Log.Print(ex.Message, ex.Source, Log.type.ERROR);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CloseConnection();
            return res;
        }

        public long GetMaxId(string table, string colunmId)
        {
            long res = -1;

            OpenConnection();
            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = String.Format("SELECT max({0}) FROM {1}", colunmId, table);

            try
            {
                var obj = cmd.ExecuteScalar();
                res = Convert.ToInt32(obj);
            }
            catch (SQLiteException ex)
            {
                Log.Print(ex.Message, ex.Source, Log.type.ERROR);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.InvalidCastException)
            {
                res = -1;
            }

            CloseConnection();
            return res;
        }


        #region TYPE_MF

        public List<TypeMFunc> GetTypesMf()
        {
            List<TypeMFunc> list = new List<TypeMFunc>();

            OpenConnection();

            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT id_mf_type, name, description FROM mf_type";

            try
            {
                SQLiteDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    list.Add(new TypeMFunc(r.GetInt64(0), r.GetString(1), r.GetString(2)));
                }
                r.Close();
            }
            catch (SQLiteException ex)
            {
                Log.Print(ex.Message, ex.Source, Log.type.ERROR);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CloseConnection();

            return list;
        }

        public long InsertType(TypeMFunc type)
        {
            long inserted_id = -1;

            OpenConnection();

            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "INSERT INTO mf_type "
                + "(id_mf_type, name, description) "
                + "VALUES (@id_mf_type, @name, @description)";

            cmd.Parameters.AddWithValue("@id_mf_type", type.ID);
            cmd.Parameters.AddWithValue("@name", type.Name);
            cmd.Parameters.AddWithValue("@description", type.Description);

            try
            {
                cmd.ExecuteNonQuery();
                type.ID = inserted_id = conn.LastInsertRowId;
            }
            catch (SQLiteException ex)
            {
                Log.Print(ex.Message, ex.Source, Log.type.ERROR);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CloseConnection();
            return inserted_id;
        }

        public void UpdateType(TypeMFunc type)
        {
            OpenConnection();

            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "UPDATE mf_type "
                + "SET name = @name, description = @description "
                + "WHERE id_mf_type = @id_mf_type";

            cmd.Parameters.AddWithValue("@id_mf_type", type.ID);
            cmd.Parameters.AddWithValue("@name", type.Name);
            cmd.Parameters.AddWithValue("@description", type.Description);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                Log.Print(ex.Message, ex.Source, Log.type.ERROR);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CloseConnection();
        }

        public TypeMFunc GetTypeMFunc(long id)
        {
            TypeMFunc res = new TypeMFunc(-1, "", "");

            OpenConnection();

            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT id_mf_type, name, description FROM mf_type "
                + "WHERE id_mf_type = @id_mf_type";

            cmd.Parameters.AddWithValue("@id_mf_type", id);

            try
            {
                SQLiteDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    res = new TypeMFunc(r.GetInt64(0), r.GetString(1), r.GetString(2));
                }
                r.Close();
            }
            catch (SQLiteException ex)
            {
                Log.Print(ex.Message, ex.Source, Log.type.ERROR);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CloseConnection();

            return res;
        }

        #endregion

        #region SYMPTOMS (LINGUISTIC VARIABLE)
        // Вернуть список всех симптомов и их ID
        public List<Symptom> GetSymptomList()
        {
            List<Symptom> res = new List<Symptom>();

            OpenConnection();

            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT id_ling_var, name, reasoning_bottom, reasoning_top "
                + "FROM linguistic_variable";

            try
            {
                SQLiteDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    res.Add(new Symptom(r.GetInt64(0), r.GetString(1), r.GetDouble(2), r.GetDouble(3)));
                }
                r.Close();
            }
            catch (SQLiteException ex)
            {
                Log.Print(ex.Message, ex.Source, Log.type.ERROR);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CloseConnection();

            return res;
        }

        public long InsertSymptom(Symptom smp)
        {
            long inserted_id = -1;

            OpenConnection();

            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "INSERT INTO linguistic_variable "
                + "(name, reasoning_bottom, reasoning_top) "
                + "VALUES (@name, @reasoning_bottom, @reasoning_top)";

            cmd.Parameters.AddWithValue("@name", smp.Name);
            cmd.Parameters.AddWithValue("@reasoning_bottom", smp.ReasoningBottom);
            cmd.Parameters.AddWithValue("@reasoning_top", smp.ReasoningTop);

            try
            {
                cmd.ExecuteNonQuery();

                smp.ID = inserted_id = conn.LastInsertRowId;
            }
            catch (SQLiteException ex)
            {
                Log.Print(ex.Message, ex.Source, Log.type.ERROR);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CloseConnection();

            return inserted_id;
        }

        public void UpdateSymptome(Symptom smp)
        {
            OpenConnection();

            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "UPDATE linguistic_variable "
                + "SET name = @name, "
                + "reasoning_bottom = @reasoning_bottom, "
                + "reasoning_top = @reasoning_top "
                + "WHERE id_ling_var = @id_ling_var";

            cmd.Parameters.AddWithValue("@id_ling_var", smp.ID);
            cmd.Parameters.AddWithValue("@name", smp.Name);
            cmd.Parameters.AddWithValue("@reasoning_bottom", smp.ReasoningBottom);
            cmd.Parameters.AddWithValue("@reasoning_top", smp.ReasoningTop);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                Log.Print(ex.Message, ex.Source, Log.type.ERROR);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CloseConnection();
        }

        public Symptom GetSymptom(long id)
        {
            var res = new Symptom(-1, "", 0, 100);

            OpenConnection();

            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT id_ling_var, name, reasoning_bottom, reasoning_top "
                + "FROM linguistic_variable "
                + "WHERE id_ling_var = @id_ling_var";

            cmd.Parameters.AddWithValue("@id_ling_var", id);

            try
            {
                SQLiteDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    res = new Symptom(r.GetInt64(0), r.GetString(1), r.GetDouble(2), r.GetDouble(3));
                    res.ID = r.GetInt64(0);
                }
                r.Close();
            }
            catch (SQLiteException ex)
            {
                Log.Print(ex.Message, ex.Source, Log.type.ERROR);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CloseConnection();

            return res;
        }

        #endregion

        #region MF_PARAMS
        //public long InsertMF(double c, double sigma)
        public long InsertMF(GaussMFuncParams param)
        {
            long inserted_id = -1;

            OpenConnection();

            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "INSERT INTO gauss_mf "
                + "(c, q) "
                + "VALUES (@c, @q)";

            cmd.Parameters.AddWithValue("@c", param.C);
            cmd.Parameters.AddWithValue("@q", param.Sigma);

            try
            {
                cmd.ExecuteNonQuery();

                param.ID = inserted_id = conn.LastInsertRowId;
            }
            catch (SQLiteException ex)
            {
                Log.Print(ex.Message, ex.Source, Log.type.ERROR);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CloseConnection();

            return inserted_id;
        }

        public GaussMFuncParams GetGaussMFuncParams(long id)
        {
            GaussMFuncParams res = new GaussMFuncParams(0, 0);
            OpenConnection();

            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT id_gauss_mf, c, q "
                + "FROM gauss_mf "
                + "WHERE id_gauss_mf = @id_gauss_mf";

            cmd.Parameters.AddWithValue("@id_gauss_mf", id);

            try
            {
                SQLiteDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    res = new GaussMFuncParams(/*r.GetInt64(0),*/ r.GetDouble(1), r.GetDouble(2));
                    res.ID = r.GetInt64(0);
                }
                r.Close();
            }
            catch (SQLiteException ex)
            {
                Log.Print(ex.Message, ex.Source, Log.type.ERROR);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CloseConnection();
            return res;
        }

        public void UpdateMF(GaussMFuncParams param)
        {
            OpenConnection();

            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "UPDATE gauss_mf "
                + "SET c = @c, q = @q "
                + "WHERE id_gauss_mf = @id_gauss_mf";

            cmd.Parameters.AddWithValue("@id_gauss_mf", param.ID);
            cmd.Parameters.AddWithValue("@c", param.C);
            cmd.Parameters.AddWithValue("@q", param.Sigma);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                Log.Print(ex.Message, ex.Source, Log.type.ERROR);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CloseConnection();
        }

        //public long InsertMF(double a, double b, double c)
        public long InsertMF(TriangulareMFuncParams param)
        {
            long inserted_id = -1;

            OpenConnection();

            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "INSERT INTO triangular_mf "
                + "(a, b, c) "
                + "VALUES (@a, @b, @c)";

            cmd.Parameters.AddWithValue("@a", param.A);
            cmd.Parameters.AddWithValue("@b", param.B);
            cmd.Parameters.AddWithValue("@c", param.C);

            try
            {
                cmd.ExecuteNonQuery();

                param.ID = inserted_id = conn.LastInsertRowId;
            }
            catch (SQLiteException ex)
            {
                Log.Print(ex.Message, ex.Source, Log.type.ERROR);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CloseConnection();

            return inserted_id;
        }

        public TriangulareMFuncParams GetTriangulareMFuncParams(long id)
        {
            TriangulareMFuncParams res = new TriangulareMFuncParams(0, 0, 0);
            OpenConnection();

            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT id_triangl_mf, a, b, c "
                + "FROM triangular_mf "
                + "WHERE id_triangl_mf = @id_triangl_mf";

            cmd.Parameters.AddWithValue("@id_triangl_mf", id);

            try
            {
                SQLiteDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    res = new TriangulareMFuncParams(/*r.GetInt64(0),*/ r.GetDouble(1), r.GetDouble(2), r.GetDouble(3));
                    res.ID = r.GetInt64(0);
                }
                r.Close();
            }
            catch (SQLiteException ex)
            {
                Log.Print(ex.Message, ex.Source, Log.type.ERROR);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CloseConnection();
            return res;
        }

        public void UpdateMF(TriangulareMFuncParams param)
        {
            OpenConnection();

            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "UPDATE triangular_mf "
                + "SET a = @a, b = @b, c = @c "
                + "WHERE id_triangl_mf = @id_triangl_mf";

            cmd.Parameters.AddWithValue("@id_triangl_mf", param.ID);
            cmd.Parameters.AddWithValue("@a", param.A);
            cmd.Parameters.AddWithValue("@b", param.B);
            cmd.Parameters.AddWithValue("@c", param.C);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                Log.Print(ex.Message, ex.Source, Log.type.ERROR);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CloseConnection();
        }

        //public long InsertMF(double a, double b, double c, double d)
        public long InsertMF(TrapezoidalMFuncParams param)
        {
            long inserted_id = -1;

            OpenConnection();

            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "INSERT INTO trapezoidal_mf "
                + "(a, b, c, d) "
                + "VALUES (@a, @b, @c, @d)";

            cmd.Parameters.AddWithValue("@a", param.A);
            cmd.Parameters.AddWithValue("@b", param.B);
            cmd.Parameters.AddWithValue("@c", param.C);
            cmd.Parameters.AddWithValue("@d", param.D);

            try
            {
                cmd.ExecuteNonQuery();

                param.ID = inserted_id = conn.LastInsertRowId;
            }
            catch (SQLiteException ex)
            {
                Log.Print(ex.Message, ex.Source, Log.type.ERROR);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CloseConnection();

            return inserted_id;
        }

        public TrapezoidalMFuncParams GetTrapezoidalMFuncParams(long id)
        {
            TrapezoidalMFuncParams res = new TrapezoidalMFuncParams(0, 0, 0, 0);
            OpenConnection();

            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT id_trapez_mf, a, b, c, d "
                + "FROM trapezoidal_mf "
                + "WHERE id_trapez_mf = @id_trapez_mf";

            cmd.Parameters.AddWithValue("@id_trapez_mf", id);

            try
            {
                SQLiteDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    res = new TrapezoidalMFuncParams(/*r.GetInt64(0),*/ r.GetDouble(1), r.GetDouble(2), r.GetDouble(3), r.GetDouble(4));
                    res.ID = r.GetInt64(0);
                }
                r.Close();
            }
            catch (SQLiteException ex)
            {
                Log.Print(ex.Message, ex.Source, Log.type.ERROR);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CloseConnection();
            return res;
        }

        public void UpdateMF(TrapezoidalMFuncParams param)
        {
            OpenConnection();

            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "UPDATE trapezoidal_mf "
                + "SET a = @a, b = @b, c = @c, d = @d "
                + "WHERE id_trapez_mf = @id_trapez_mf";

            cmd.Parameters.AddWithValue("@id_trapez_mf", param.ID);
            cmd.Parameters.AddWithValue("@a", param.A);
            cmd.Parameters.AddWithValue("@b", param.B);
            cmd.Parameters.AddWithValue("@c", param.C);
            cmd.Parameters.AddWithValue("@c", param.D);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                Log.Print(ex.Message, ex.Source, Log.type.ERROR);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CloseConnection();
        }

        #endregion

        #region FUZZY_VARIABLE

        public long InsertFuzzyVar(FuzzyVariable fv)
        {
            long inserted_id = -1;

            OpenConnection();

            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "INSERT INTO fuzzy_variable "
                + "(id_ling_var, name, id_mf_type, id_bound, id_triangl_mf, id_trapez_mf, "
                + "id_gauss_mf, r, g, b) "
                + "VALUES (@id_ling_var, @name, @id_mf_type, @id_bound, @id_triangl_mf, @id_trapez_mf, "
                + "@id_gauss_mf, @r, @g, @b)";

            cmd.Parameters.AddWithValue("@id_ling_var", fv.IdSymptom);
            cmd.Parameters.AddWithValue("@name", fv.Name);
            cmd.Parameters.AddWithValue("@id_mf_type", (int)fv.Type);
            cmd.Parameters.AddWithValue("@id_bound", (int)fv.Bound);
            cmd.Parameters.AddWithValue("@id_triangl_mf", fv.TrianglParam.ID);
            cmd.Parameters.AddWithValue("@id_trapez_mf", fv.TrapezParam.ID);
            cmd.Parameters.AddWithValue("@id_gauss_mf", fv.GaussParam.ID);
            cmd.Parameters.AddWithValue("@r", fv.ColorLine.R);
            cmd.Parameters.AddWithValue("@g", fv.ColorLine.G);
            cmd.Parameters.AddWithValue("@b", fv.ColorLine.B);

            try
            {
                cmd.ExecuteNonQuery();

                fv.ID = inserted_id = conn.LastInsertRowId;
            }
            catch (SQLiteException ex)
            {
                Log.Print(ex.Message, ex.Source, Log.type.ERROR);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CloseConnection();

            return inserted_id;
        }

        public void UpdateFuzzyVar(FuzzyVariable fv)
        {
            OpenConnection();

            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "UPDATE fuzzy_variable "
                + "SET id_ling_var = @id_ling_var, name = @name, id_mf_type = @id_mf_type, id_bound = @id_bound, id_triangl_mf = @id_triangl_mf, "
                + "id_trapez_mf = @id_trapez_mf, id_gauss_mf = @id_gauss_mf, r = @r, g = @g, b = @b "
                + "WHERE id_var = @id_var";

            cmd.Parameters.AddWithValue("@id_var", fv.ID);
            cmd.Parameters.AddWithValue("@id_ling_var", fv.IdSymptom);
            cmd.Parameters.AddWithValue("@name", fv.Name);
            cmd.Parameters.AddWithValue("@id_mf_type", (int)fv.Type);
            cmd.Parameters.AddWithValue("@id_bound", (int)fv.Bound);
            cmd.Parameters.AddWithValue("@id_triangl_mf", fv.TrianglParam.ID);
            cmd.Parameters.AddWithValue("@id_trapez_mf", fv.TrapezParam.ID);
            cmd.Parameters.AddWithValue("@id_gauss_mf", fv.GaussParam.ID);
            cmd.Parameters.AddWithValue("@r", fv.ColorLine.R);
            cmd.Parameters.AddWithValue("@g", fv.ColorLine.G);
            cmd.Parameters.AddWithValue("@b", fv.ColorLine.B);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                Log.Print(ex.Message, ex.Source, Log.type.ERROR);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CloseConnection();
        }

        public List<FuzzyVariable> GetFuzzyVariables(long id_symptom)
        {
            List<FuzzyVariable> reslist = new List<FuzzyVariable>();
            OpenConnection();

            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT "
                    + "id_var, "
                    + "id_ling_var, "
                    + "name, "
                    + "id_mf_type, "
                    + "id_bound, "
                    + "id_triangl_mf, "
                    + "id_trapez_mf, "
                    + "id_gauss_mf, "
                    + "r, g, b "
                + "FROM fuzzy_variable "
                + "WHERE id_ling_var = @id_ling_var";

            cmd.Parameters.AddWithValue("@id_ling_var", id_symptom);

            try
            {
                SQLiteDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    System.Drawing.Color clr = new System.Drawing.Color();
                    try
                    {
                        clr = System.Drawing.Color.FromArgb(r.GetInt32(8), r.GetInt32(9), r.GetInt32(10));
                    }
                    catch
                    {
                        clr = System.Drawing.Color.Yellow;
                    }

                    FuzzyVariable fv;
                    try
                    {
                        fv = new FuzzyVariable(r.GetInt64(0), r.GetInt64(1), r.GetString(2), clr);
                    }
                    catch
                    {
                        fv = new FuzzyVariable(r.GetInt64(0), r.GetInt64(1), "", clr);
                    }

                    switch (r.GetInt64(3))
                    {
                        case 0:
                            fv.Type = TypeMFuncEnum.GAUSS;
                            break;
                        case 1:
                            fv.Type = TypeMFuncEnum.TRIANGULARE;
                            break;
                        case 2:
                            fv.Type = TypeMFuncEnum.TRAPEZOIDAL;
                            break;
                        default:
                            fv.Type = TypeMFuncEnum.NOT_SETUP;
                            break;
                    }

                    switch (r.GetInt64(4))
                    {
                        case 0:
                            fv.Bound = BoundaryTypeEnum.LEFT;
                            break;
                        case 1:
                            fv.Bound = BoundaryTypeEnum.RIGHT;
                            break;
                        default:
                            fv.Bound = BoundaryTypeEnum.MIDDLE;
                            break;
                    }

                    fv.ColorLine = clr;

                    try { fv.TrianglParam.ID = r.GetInt64(5); } catch { fv.TrianglParam.ID = -1; }
                    try { fv.TrapezParam.ID = r.GetInt64(6); } catch { fv.TrapezParam.ID = -1; }
                    try { fv.GaussParam.ID = r.GetInt64(7); } catch { fv.GaussParam.ID = -1; }

                    reslist.Add(fv);
                }
                r.Close();
            }
            catch (SQLiteException ex)
            {
                Log.Print(ex.Message, ex.Source, Log.type.ERROR);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CloseConnection();
            return reslist;
        }

        #endregion

        #region BOUNDARY_TYPE

        public long InsertBoundType(BoundaryType bound)
        {
            long inserted_id = -1;

            OpenConnection();

            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "INSERT INTO boundary_type "
                + "(id_bound, name, description) "
                + "VALUES (@id_bound, @name, @description)";

            cmd.Parameters.AddWithValue("@id_bound", bound.ID);
            cmd.Parameters.AddWithValue("@name", bound.Name);
            cmd.Parameters.AddWithValue("@description", bound.Description);

            try
            {
                cmd.ExecuteNonQuery();
                bound.ID = inserted_id = conn.LastInsertRowId;
            }
            catch (SQLiteException ex)
            {
                Log.Print(ex.Message, ex.Source, Log.type.ERROR);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CloseConnection();

            return inserted_id;
        }

        public void UpdateBoundType(BoundaryType bound)
        {
            OpenConnection();

            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "UPDATE boundary_type "
                + "SET name = @name, description = @description "
                + "WHERE id_bound = @id_bound";

            cmd.Parameters.AddWithValue("@id_bound", bound.ID);
            cmd.Parameters.AddWithValue("@name", bound.Name);
            cmd.Parameters.AddWithValue("@description", bound.Description);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                Log.Print(ex.Message, ex.Source, Log.type.ERROR);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CloseConnection();
        }

        public List<BoundaryType> GetBoundaryTypes()
        {
            var list = new List<BoundaryType>();

            OpenConnection();

            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT id_bound, name, description FROM boundary_type";

            try
            {
                SQLiteDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    list.Add(new BoundaryType(r.GetInt64(0), r.GetString(1), r.GetString(2)));
                }
                r.Close();
            }
            catch (SQLiteException ex)
            {
                Log.Print(ex.Message, ex.Source, Log.type.ERROR);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CloseConnection();

            return list;
        }

        public BoundaryType GetBoundaryType(long id)
        {
            BoundaryType res = new BoundaryType(-1, "", "");
            OpenConnection();

            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT id_bound, name, description FROM boundary_type "
                + "WHERE id_bound = @id_bound";

            cmd.Parameters.AddWithValue("@id_bound", id);

            try
            {
                SQLiteDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    res = new BoundaryType(r.GetInt64(0), r.GetString(1), r.GetString(2));
                }
                r.Close();
            }
            catch (SQLiteException ex)
            {
                Log.Print(ex.Message, ex.Source, Log.type.ERROR);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CloseConnection();
            return res;
        }

        #endregion

        public List<Quantifier> GetQuantifiers()
        {
            var resList = new List<Quantifier>();

            OpenConnection();

            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT id_quantifier, name, rule FROM quantifier";

            try
            {
                SQLiteDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    var curr = new Quantifier(r.GetString(1), (QuantifierEnum)r.GetInt64(0));
                    curr.ID = r.GetInt64(0);
                    curr.Rule = r.GetString(2);

                    resList.Add(curr);
                }
                r.Close();
            }
            catch (SQLiteException ex)
            {
                Log.Print(ex.Message, ex.Source, Log.type.ERROR);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CloseConnection();

            return resList;
        }

        public List<GroupUsers> GetGroupUsers()
        {
            List<GroupUsers> list = new List<GroupUsers>();

            OpenConnection();

            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT id_group, name, description FROM user_group";

            try
            {
                SQLiteDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    var curr = new GroupUsers();
                    curr.ID = r.GetInt64(0);
                    curr.Name = r.GetString(1);
                    curr.Description = r.GetString(2);

                    list.Add(curr);
                }
                r.Close();
            }
            catch (SQLiteException ex)
            {
                Log.Print(ex.Message, ex.Source, Log.type.ERROR);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CloseConnection();

            return list;
        }

        public List<User> GetUserList()
        {
            List<User> list = new List<User>();

            OpenConnection();

            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT id_login, id_group, login, password FROM login";

            try
            {
                SQLiteDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    var curr = new User();
                    curr.ID = r.GetInt64(0);
                    curr.GroupId = r.GetInt64(1);
                    curr.Login = r.GetString(2);
                    try { curr.Password = r.GetString(3); } catch { curr.Password = String.Empty; }


                    list.Add(curr);
                }
                r.Close();
            }
            catch (SQLiteException ex)
            {
                Log.Print(ex.Message, ex.Source, Log.type.ERROR);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CloseConnection();

            return list;
        }

        public long InsertUser(User usr)
        {
            long inserted_id = -1;

            OpenConnection();

            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "INSERT INTO login "
                + "(id_group, login, password) "
                + "VALUES (@id_group, @login, @password)";

            cmd.Parameters.AddWithValue("@id_group", usr.GroupId);
            cmd.Parameters.AddWithValue("@login", usr.Login);
            cmd.Parameters.AddWithValue("@password", usr.Password);

            try
            {
                cmd.ExecuteNonQuery();
                usr.ID = inserted_id = conn.LastInsertRowId;
            }
            catch (SQLiteException ex)
            {
                Log.Print(ex.Message, ex.Source, Log.type.ERROR);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CloseConnection();

            return inserted_id;
        }

        public void UpdateUser(User usr)
        {
            OpenConnection();

            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "UPDATE login "
                + "SET id_group = @id_group, login = @login, password = @password "
                + "WHERE id_login = @id_login";

            cmd.Parameters.AddWithValue("@id_login", usr.ID);
            cmd.Parameters.AddWithValue("@id_group", usr.GroupId);
            cmd.Parameters.AddWithValue("@login", usr.Login);
            cmd.Parameters.AddWithValue("@password", usr.Password);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                Log.Print(ex.Message, ex.Source, Log.type.ERROR);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CloseConnection();
        }

        #region PATIENT

        public List<Patient> GetPatient()
        {
            var list = new List<Patient>();

            OpenConnection();

            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT * FROM patient";

            try
            {
                SQLiteDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    var curr = new Patient(r.GetString(1));
                    curr.ID = r.GetInt64(0);
                    curr.Name = r.GetString(1);
                    curr.MHI = r.GetValue(2).ToString();
                    curr.MHO = r.GetValue(3).ToString();
                    curr.Benefit_code = r.GetValue(4).ToString();
                    curr.Date_of_birth = r.GetString(5);
                    curr.Age = r.GetValue(6).ToString();
                    curr.Gender = r.GetValue(7).ToString();
                    curr.Residence_address = r.GetValue(8).ToString();
                    curr.Residential_address = r.GetValue(9).ToString();
                    curr.Phone = r.GetValue(10).ToString();
                    curr.Place_of_work = r.GetValue(11).ToString();
                    curr.Profession = r.GetValue(12).ToString();
                    curr.Post = r.GetValue(13).ToString();
                    curr.Dependent = r.GetValue(14).ToString();
                    curr.Document_name = r.GetValue(15).ToString();
                    curr.Document_number = r.GetValue(16).ToString();
                    curr.Document_date = r.GetValue(17).ToString();
                    curr.Document_issued = r.GetValue(18).ToString();
                    curr.Diagnosis = r.GetValue(19).ToString();
                    curr.Concomitant_diagnosis = r.GetValue(20).ToString();
                    curr.Symptoms = r.GetValue(21).ToString();
                    curr.Medications_taken = r.GetValue(22).ToString();
                    curr.Attending_physician = r.GetValue(23).ToString();
                    curr.Today_day = r.GetValue(24).ToString();

                    list.Add(curr);
                }
                r.Close();
            }
            catch (SQLiteException ex)
            {
                Log.Print(ex.Message, ex.Source, Log.type.ERROR);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CloseConnection();

            return list;
        }

        public Patient GetPatient(long id)
        {
            var patgn = new Patient();

            OpenConnection();

            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT * FROM patient "
                + "WHERE patient_id = @patient_id;";

            cmd.Parameters.AddWithValue("@patient_id", id);

            try
            {
                SQLiteDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    patgn.ID = r.GetInt64(0);
                    patgn.Name = r.GetString(1);
                    patgn.MHI = r.GetValue(2).ToString();
                    patgn.MHO = r.GetValue(3).ToString();
                    patgn.Benefit_code = r.GetValue(4).ToString();
                    patgn.Date_of_birth = r.GetString(5);
                    patgn.Age = r.GetValue(6).ToString();
                    patgn.Gender = r.GetValue(7).ToString();
                    patgn.Residence_address = r.GetValue(8).ToString();
                    patgn.Residential_address = r.GetValue(9).ToString();
                    patgn.Phone = r.GetValue(10).ToString();
                    patgn.Place_of_work = r.GetValue(11).ToString();
                    patgn.Profession = r.GetValue(12).ToString();
                    patgn.Post = r.GetValue(13).ToString();
                    patgn.Dependent = r.GetValue(14).ToString();
                    patgn.Document_name = r.GetValue(15).ToString();
                    patgn.Document_number = r.GetValue(16).ToString();
                    patgn.Document_date = r.GetValue(17).ToString();
                    patgn.Document_issued = r.GetValue(18).ToString();
                    patgn.Diagnosis = r.GetValue(19).ToString();
                    patgn.Concomitant_diagnosis = r.GetValue(20).ToString();
                    patgn.Symptoms = r.GetValue(21).ToString();
                    patgn.Medications_taken = r.GetValue(22).ToString();
                    patgn.Attending_physician = r.GetValue(23).ToString();
                    patgn.Today_day = r.GetValue(24).ToString();



                }
                r.Close();
            }
            catch (SQLiteException ex)
            {
                Log.Print(ex.Message, ex.Source, Log.type.ERROR);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CloseConnection();

            return patgn;
        }

        public long InsertPatient(Patient patient)
        {
            long res = -1;

            OpenConnection();

            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "INSERT INTO patient "
                + "(patient_name, patient_mhi, patient_mio, patient_benefit_code, patient_date_of_birth, patient_age, patient_gender, patient_residence_address, patient_residential_address, patient_phone, patient_place_of_work, patient_profession, patient_post, patient_dependent, patient_document_name, patient_document_number, patient_document_date, patient_document_issued, patient_diagnosis, patient_concomitant_diagnosis, patient_symptoms, patient_medications_taken, patient_attending_physician, patient_today_day) "
                + "VALUES (@patient_name, @patient_mhi, @patient_mio, @patient_benefit_code, @patient_date_of_birth, @patient_age, @patient_gender, @patient_residence_address, @patient_residential_address, @patient_phone, @patient_place_of_work, @patient_profession, @patient_post, @patient_dependent, @patient_document_name, @patient_document_number, @patient_document_date, @patient_document_issued, @patient_diagnosis, @patient_concomitant_diagnosis, @patient_symptoms, @patient_medications_taken, @patient_attending_physician, @patient_today_day); INSERT INTO login"
               + "(id_group, login, password) "
               + "VALUES (5, @patient_login, 1234)";
            cmd.Parameters.AddWithValue("@patient_login", patient.Name);
            cmd.Parameters.AddWithValue("@patient_name", patient.Name);
            cmd.Parameters.AddWithValue("@patient_mhi", patient.MHI);
            cmd.Parameters.AddWithValue("@patient_mio", patient.MHO);
            cmd.Parameters.AddWithValue("@patient_benefit_code", patient.Benefit_code);
            cmd.Parameters.AddWithValue("@patient_date_of_birth", patient.Date_of_birth);
            cmd.Parameters.AddWithValue("@patient_age", patient.Age);
            cmd.Parameters.AddWithValue("@patient_gender", patient.Gender);

            cmd.Parameters.AddWithValue("@patient_residence_address", patient.Residence_address);
            cmd.Parameters.AddWithValue("@patient_residential_address", patient.Residential_address);
            cmd.Parameters.AddWithValue("@patient_phone", patient.Phone);
            cmd.Parameters.AddWithValue("@patient_place_of_work", patient.Place_of_work);

            cmd.Parameters.AddWithValue("@patient_profession", patient.Profession);
            cmd.Parameters.AddWithValue("@patient_post", patient.Post);
            cmd.Parameters.AddWithValue("@patient_dependent", patient.Dependent);
            cmd.Parameters.AddWithValue("@patient_document_name", patient.Document_name);

            cmd.Parameters.AddWithValue("@patient_document_number", patient.Document_number);
            cmd.Parameters.AddWithValue("@patient_document_date", patient.Document_date);
            cmd.Parameters.AddWithValue("@patient_document_issued", patient.Document_issued);
            cmd.Parameters.AddWithValue("@patient_diagnosis", patient.Diagnosis);

            cmd.Parameters.AddWithValue("@patient_concomitant_diagnosis", patient.Concomitant_diagnosis);
            cmd.Parameters.AddWithValue("@patient_symptoms", patient.Symptoms);
            cmd.Parameters.AddWithValue("@patient_medications_taken", patient.Medications_taken);
            cmd.Parameters.AddWithValue("@patient_attending_physician", patient.Attending_physician);

            cmd.Parameters.AddWithValue("@patient_today_day", patient.Today_day);


            try
            {
                cmd.ExecuteNonQuery();
                patient.ID = res = conn.LastInsertRowId;
            }
            catch (SQLiteException ex)
            {
                Log.Print(ex.Message, ex.Source, Log.type.ERROR);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CloseConnection();

            return res;
        }

        public void UpdatePatient(Patient patient)
        {
            OpenConnection();

            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "UPDATE patient "
                + "SET patient_name = @patient_name, patient_mhi = @patient_mhi, patient_mio = @patient_mio, patient_benefit_code = @patient_benefit_code, patient_date_of_birth = @patient_date_of_birth, patient_age = @patient_age, patient_gender = @patient_gender, patient_residence_address = @patient_residence_address, patient_residential_address = @patient_residential_address, patient_phone = @patient_phone, patient_place_of_work = @patient_place_of_work, patient_profession = @patient_profession, patient_post = @patient_post, patient_dependent = @patient_dependent, patient_document_name = @patient_document_name, patient_document_number = @patient_document_number, patient_document_date = @patient_document_date, patient_document_issued = @patient_document_issued, patient_diagnosis = @patient_diagnosis, patient_concomitant_diagnosis = @patient_concomitant_diagnosis, patient_symptoms = @patient_symptoms, patient_medications_taken = @patient_medications_taken, patient_attending_physician = @patient_attending_physician, patient_today_day = @patient_today_day "
                + "WHERE patient_id = @patient_id";

            cmd.Parameters.AddWithValue("@patient_id", patient.ID);
            cmd.Parameters.AddWithValue("@patient_name", patient.Name);
            cmd.Parameters.AddWithValue("@patient_mhi", patient.MHI);
            cmd.Parameters.AddWithValue("@patient_mio", patient.MHO);
            cmd.Parameters.AddWithValue("@patient_benefit_code", patient.Benefit_code);
            cmd.Parameters.AddWithValue("@patient_date_of_birth", patient.Date_of_birth);
            cmd.Parameters.AddWithValue("@patient_age", patient.Age);
            cmd.Parameters.AddWithValue("@patient_gender", patient.Gender);

            cmd.Parameters.AddWithValue("@patient_residence_address", patient.Residence_address);
            cmd.Parameters.AddWithValue("@patient_residential_address", patient.Residential_address);
            cmd.Parameters.AddWithValue("@patient_phone", patient.Phone);
            cmd.Parameters.AddWithValue("@patient_place_of_work", patient.Place_of_work);

            cmd.Parameters.AddWithValue("@patient_profession", patient.Profession);
            cmd.Parameters.AddWithValue("@patient_post", patient.Post);
            cmd.Parameters.AddWithValue("@patient_dependent", patient.Dependent);
            cmd.Parameters.AddWithValue("@patient_document_name", patient.Document_name);

            cmd.Parameters.AddWithValue("@patient_document_number", patient.Document_number);
            cmd.Parameters.AddWithValue("@patient_document_date", patient.Document_date);
            cmd.Parameters.AddWithValue("@patient_document_issued", patient.Document_issued);
            cmd.Parameters.AddWithValue("@patient_diagnosis", patient.Diagnosis);

            cmd.Parameters.AddWithValue("@patient_concomitant_diagnosis", patient.Concomitant_diagnosis);
            cmd.Parameters.AddWithValue("@patient_symptoms", patient.Symptoms);
            cmd.Parameters.AddWithValue("@patient_medications_taken", patient.Medications_taken);
            cmd.Parameters.AddWithValue("@patient_attending_physician", patient.Attending_physician);

            cmd.Parameters.AddWithValue("@patient_today_day", patient.Today_day);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                Log.Print(ex.Message, ex.Source, Log.type.ERROR);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CloseConnection();
        }

        public void UpdateDiagnosis(string v)
        {
            OpenConnection();

            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "UPDATE patient "
                + "SET patient_diagnosis = @patient_diagnosis "
                + "WHERE patient_name = @patient_name";

            cmd.Parameters.AddWithValue("@patient_diagnosis", v);
            cmd.Parameters.AddWithValue("@patient_name", Settings.Instance.currenUser.Login);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                Log.Print(ex.Message, ex.Source, Log.type.ERROR);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CloseConnection();
        }

        #endregion

        #region DIAGNOSIS

        public List<Diagnosis> GetDiagnosis()
        {
            var list = new List<Diagnosis>();

            OpenConnection();

            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT id_diagnosis, name, description, symptoms, treatment FROM diagnosis";

            try
            {
                SQLiteDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    var curr = new Diagnosis(r.GetString(1));
                    curr.ID = r.GetInt64(0);
                    //curr.Name = r.GetString(1);
                    curr.Description = r.GetString(2);
                    curr.Symptoms = r.GetString(3);
                    curr.Treatment = r.GetString(4);

                    list.Add(curr);
                }
                r.Close();
            }
            catch (SQLiteException ex)
            {
                Log.Print(ex.Message, ex.Source, Log.type.ERROR);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CloseConnection();

            return list;
        }

        public Diagnosis GetDiagnosis(long id)
        {
            var diagn = new Diagnosis();

            OpenConnection();

            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT id_diagnosis, name, description, symptoms, treatment FROM diagnosis "
                + "WHERE id_diagnosis = @id_diagnosis;";

            cmd.Parameters.AddWithValue("@id_diagnosis", id);

            try
            {
                SQLiteDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    diagn.ID = r.GetInt64(0);
                    diagn.Name = r.GetString(1);
                    diagn.Description = r.GetString(2);
                    diagn.Symptoms = r.GetString(3);
                    diagn.Treatment = r.GetString(4);
                }
                r.Close();
            }
            catch (SQLiteException ex)
            {
                Log.Print(ex.Message, ex.Source, Log.type.ERROR);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CloseConnection();

            return diagn;
        }

        public long InsertDiagnosis(Diagnosis diagnosis)
        {
            long res = -1;

            OpenConnection();

            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "INSERT INTO diagnosis "
                + "(name, description, symptoms, treatment) "
                + "VALUES (@name, @description, @symptoms, @treatment)";

            cmd.Parameters.AddWithValue("@name", diagnosis.Name);
            cmd.Parameters.AddWithValue("@description", diagnosis.Description);
            cmd.Parameters.AddWithValue("@symptoms", diagnosis.Symptoms);
            cmd.Parameters.AddWithValue("@treatment", diagnosis.Treatment);

            try
            {
                cmd.ExecuteNonQuery();
                diagnosis.ID = res = conn.LastInsertRowId;
            }
            catch (SQLiteException ex)
            {
                Log.Print(ex.Message, ex.Source, Log.type.ERROR);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CloseConnection();

            return res;
        }

        public void UpdateDiagnosis(Diagnosis diagnosis)
        {
            OpenConnection();

            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "UPDATE diagnosis "
                + "SET name = @name, description = @description, symptoms = @symptoms, treatment = @treatment "
                + "WHERE id_diagnosis = @id_diagnosis";

            cmd.Parameters.AddWithValue("@id_diagnosis", diagnosis.ID);
            cmd.Parameters.AddWithValue("@name", diagnosis.Name);
            cmd.Parameters.AddWithValue("@description", diagnosis.Description);
            cmd.Parameters.AddWithValue("@symptoms", diagnosis.Symptoms);
            cmd.Parameters.AddWithValue("@treatment", diagnosis.Treatment);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                Log.Print(ex.Message, ex.Source, Log.type.ERROR);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CloseConnection();
        }

        #endregion

        public List<Rule> GetRuleList()
        {
            var ruleList = new List<Rule>();

            OpenConnection();

            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT id_rule, id_diagnosis, preview FROM knowledge_base";

            try
            {
                SQLiteDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    var currRule = new Rule();

                    currRule.ID = r.GetInt64(0);
                    currRule.Conclusion = new Diagnosis();
                    currRule.Conclusion.ID = r.GetInt64(1);
                    currRule.Preview = r.GetString(2);

                    ruleList.Add(currRule);
                }
                r.Close();
            }
            catch (SQLiteException ex)
            {
                Log.Print(ex.Message, ex.Source, Log.type.ERROR);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CloseConnection();

            /*for (int i=0; i < ruleList.Count; i++)
            {
                ruleList[i].Conclusion = GetDiagnosis(ruleList[i].Conclusion.ID);
            }*/
            foreach (var rul in ruleList)
            {
                rul.Conclusion = GetDiagnosis(rul.Conclusion.ID);
            }

            return ruleList;
        }

        public List<Antecedent> GetAntecedentList()
        {
            var res = new List<Antecedent>();

            OpenConnection();

            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT id_antecedent, id_ling_var, id_var, id_quantifier, preview FROM antecedent";

            try
            {
                SQLiteDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    var curr = new Antecedent();

                    curr.ID = r.GetInt64(0);
                    curr.LinguisticVariable = new Symptom(r.GetInt64(1), "", 0, 100);
                    curr.FuzzyVar = new FuzzyVariable(r.GetInt64(2), r.GetInt64(1), "", System.Drawing.Color.Black);
                    curr.Quant = new Quantifier("", (QuantifierEnum)r.GetInt64(3));
                    curr.Preview = r.GetString(4);

                    res.Add(curr);
                }
                r.Close();
            }
            catch (SQLiteException ex)
            {
                Log.Print(ex.Message, ex.Source, Log.type.ERROR);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CloseConnection();

            foreach (var ant in res)
            {
                ant.LinguisticVariable = GetSymptom(ant.LinguisticVariable.ID);

                var fList = GetFuzzyVariables(ant.LinguisticVariable.ID);
                ant.FuzzyVar = fList.Find(x => x.ID == ant.FuzzyVar.ID);

                var qList = GetQuantifiers();
                ant.Quant = qList.Find(x => x.ID == ant.Quant.ID);
            }

            return res;
        }

        public long InsertAntecedent(Antecedent ant)
        {
            long res = -1;

            OpenConnection();

            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT id_antecedent, id_ling_var, id_var, id_quantifier, preview FROM antecedent "
                + "WHERE id_ling_var = @id_ling_var AND id_var = @id_var AND id_quantifier = @id_quantifier";

            cmd.Parameters.AddWithValue("@id_ling_var", ant.LinguisticVariable.ID);
            cmd.Parameters.AddWithValue("@id_var", ant.FuzzyVar.ID);
            cmd.Parameters.AddWithValue("@id_quantifier", ant.Quant.ID);

            try
            {
                SQLiteDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    res = ant.ID = r.GetInt64(0);
                }
                r.Close();
            }
            catch (SQLiteException ex)
            {
                Log.Print(ex.Message, ex.Source, Log.type.ERROR);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (ant.ID == -1)
            {

                cmd.CommandText = "INSERT INTO antecedent "
                    + "(id_ling_var, id_var, id_quantifier, preview) "
                    + "VALUES (@id_ling_var, @id_var, @id_quantifier, @preview)";

                cmd.Parameters.AddWithValue("@id_ling_var", ant.LinguisticVariable.ID);
                cmd.Parameters.AddWithValue("@id_var", ant.FuzzyVar.ID);
                cmd.Parameters.AddWithValue("@id_quantifier", ant.Quant.ID);
                cmd.Parameters.AddWithValue("@preview", ant.Preview);

                try
                {
                    cmd.ExecuteNonQuery();
                    ant.ID = res = conn.LastInsertRowId;
                }
                catch (SQLiteException ex)
                {
                    Log.Print(ex.Message, ex.Source, Log.type.ERROR);
                    Console.WriteLine(ex.Message);
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                cmd.CommandText = "UPDATE antecedent "
                + "SET id_ling_var = @id_ling_var, id_var = @id_var, id_quantifier = @id_quantifier, preview = @preview "
                + "WHERE id_antecedent = @id_antecedent";

                cmd.Parameters.AddWithValue("@id_antecedent", ant.ID);
                cmd.Parameters.AddWithValue("@id_ling_var", ant.LinguisticVariable.ID);
                cmd.Parameters.AddWithValue("@id_var", ant.FuzzyVar.ID);
                cmd.Parameters.AddWithValue("@id_quantifier", ant.Quant.ID);
                cmd.Parameters.AddWithValue("@preview", ant.Preview);

                try
                {
                    cmd.ExecuteNonQuery();
                    //ant.ID = res = conn.LastInsertRowId;
                }
                catch (SQLiteException ex)
                {
                    Log.Print(ex.Message, ex.Source, Log.type.ERROR);
                    Console.WriteLine(ex.Message);
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            CloseConnection();

            return res;
        }

        public long InsertRule(Rule rule)
        {
            long res = -1;

            OpenConnection();

            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "INSERT INTO knowledge_base "
                + "(id_diagnosis, preview) "
                + "VALUES (@id_diagnosis, @preview)";

            cmd.Parameters.AddWithValue("@id_diagnosis", rule.Conclusion.ID);
            cmd.Parameters.AddWithValue("@preview", rule.Preview);

            try
            {
                cmd.ExecuteNonQuery();
                rule.ID = res = conn.LastInsertRowId;
            }
            catch (SQLiteException ex)
            {
                Log.Print(ex.Message, ex.Source, Log.type.ERROR);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CloseConnection();

            return res;
        }

        public bool InsertRulesAntecedents(List<Antecedent> antlist, Rule rule)
        {
            bool res = false;

            OpenConnection();

            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "BEGIN; ";
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                Log.Print(ex.Message, ex.Source, Log.type.ERROR);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                res = false;
            }

            foreach (var ant in antlist)
            {
                cmd.CommandText = "INSERT INTO antecedent_list "
                + "(id_rule, id_antecedent) "
                + "VALUES (@id_rule, @id_antecedent); ";

                cmd.Parameters.AddWithValue("@id_rule", rule.ID);
                cmd.Parameters.AddWithValue("@id_antecedent", ant.ID);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SQLiteException ex)
                {
                    Log.Print(ex.Message, ex.Source, Log.type.ERROR);
                    Console.WriteLine(ex.Message);
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    res = false;
                }
            }

            cmd.CommandText = "COMMIT; ";

            try
            {
                cmd.ExecuteNonQuery();
                res = true;
            }
            catch (SQLiteException ex)
            {
                Log.Print(ex.Message, ex.Source, Log.type.ERROR);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                res = false;
            }

            CloseConnection();

            return res;
        }

        public List<Antecedent> GetAntecedentsInRule(Rule rule)
        {
            var antlist = new List<Antecedent>();

            OpenConnection();

            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT id_rule, id_antecedent FROM antecedent_list " +
                "WHERE id_rule = @id_rule;";

            cmd.Parameters.AddWithValue("@id_rule", rule.ID);

            try
            {
                SQLiteDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    var curr = new Antecedent();

                    curr.ID = r.GetInt64(1);

                    antlist.Add(curr);
                }
                r.Close();
            }
            catch (SQLiteException ex)
            {
                Log.Print(ex.Message, ex.Source, Log.type.ERROR);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CloseConnection();

            var allAnt = GetAntecedentList();
            for (int i = 0; i < antlist.Count; i++)
            {
                foreach (var aa in allAnt)
                {
                    if (antlist[i].ID == aa.ID)
                    {
                        antlist[i] = aa;
                        break;
                    }
                }
            }

            return antlist;
        }
    }
}
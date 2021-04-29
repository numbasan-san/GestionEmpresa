using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionEmpresa.Clases;
using System.Data;
using System.Data.SQLite;

namespace GestionEmpresa.Data
{
    class suportDepartamento
    {
        public suportDepartamento()
        {
            SQLiteConnector.CreateTable();
        }

        public List<Departamento> verRegistro()
        {

            SQLiteConnector.CreateTable();
            List<Departamento> Departamentos = new List<Departamento>();
            SQLiteConnection conn = SQLiteConnector.CreateConnection();
            SQLiteCommand command;
            SQLiteDataReader reader;
            command = conn.CreateCommand();

            command.CommandText = "SELECT * FROM Departamento";
            try
            {
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Departamentos.Add(new Departamento(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetInt32(2),
                    reader.GetInt32(3)
                    ));
                }
            }
            catch (SQLiteException e)
            {
                System.Windows.Forms.MessageBox.Show(e.ToString());
            }
            conn.Close();
            return Departamentos;
        }

        public DataSet dataSet()
        {
            DataSet ds = new DataSet();
            SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM Depeartamento", SQLiteConnector.CreateConnection());
            da.Fill(ds);
            return ds;
        }

        public void agregar(Departamento depart)
        {
            SQLiteConnection conn = SQLiteConnector.CreateConnection();
            SQLiteCommand sqliteCommand;
            sqliteCommand = conn.CreateCommand();
            sqliteCommand.CommandText = @"INSERT INTO Departamento(departmentID, nombre, paisId, noContact) VALUES (" +
                "" + depart.codigo + ", " +
                "" + depart.nombre + ", " +
                "" + depart.paisId + ", " +
                "'" + depart.noContact + ");";
            sqliteCommand.ExecuteNonQuery();
            conn.Close();
        }

        public void modificar(Departamento depart)
        {
            SQLiteConnection conn = SQLiteConnector.CreateConnection();
            SQLiteCommand sqliteCommand;
            sqliteCommand = conn.CreateCommand();
            sqliteCommand.CommandText = @"UPDATE Departamento SET " +
                                            "departmentID = " + depart.codigo + "," +
                                            "nombre = " + depart.nombre + "," +
                                            "paisId = " + depart.paisId + "," +
                                            "noContact = '" + depart.noContact + ";";
            sqliteCommand.ExecuteNonQuery();
            conn.Close();
        }

        public void eliminar(Departamento depart)
        {
            SQLiteConnection conn = SQLiteConnector.CreateConnection();
            SQLiteCommand sqliteCommand;
            sqliteCommand = conn.CreateCommand();
            sqliteCommand.CommandText = "DELETE FROM Departmento WHERE departamentID = " + depart.codigo + ";";
            sqliteCommand.ExecuteNonQuery();
            conn.Close();
        }
    }
}

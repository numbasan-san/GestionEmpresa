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
    class suportEmpleado
    {
        public suportEmpleado()
        {
            SQLiteConnector.CreateTable();
        }

        public List<clsEmpleado> verRegistro()
        {

            SQLiteConnector.CreateTable();
            List<clsEmpleado> Empleados = new List<clsEmpleado>();
            SQLiteConnection conn = SQLiteConnector.CreateConnection();
            SQLiteCommand command;
            SQLiteDataReader reader;
            command = conn.CreateCommand();

            command.CommandText = "SELECT * FROM Empleado";
            try
            {
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Empleados.Add(new clsEmpleado(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetInt32(3),
                    reader.GetString(4)
                    ));
                }
            }
            catch (SQLiteException e)
            {
                System.Windows.Forms.MessageBox.Show(e.ToString());
            }
            conn.Close();
            return Empleados;
        }

        public DataSet dataSet()
        {
            DataSet ds = new DataSet();
            SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM Empleado", SQLiteConnector.CreateConnection());
            da.Fill(ds);
            return ds;
        }

        public void agregar(clsEmpleado empleado)
        {
            SQLiteConnection conn = SQLiteConnector.CreateConnection();
            SQLiteCommand sqliteCommand;
            sqliteCommand = conn.CreateCommand();
            sqliteCommand.CommandText = @"INSERT INTO Empleado(empleadoID, nombre, apellido, departamentID,  cargo) VALUES (" +
                "" + empleado.id + ", " +
                "" + empleado.nombre + ", " +
                "" + empleado.apellido + ", " +
                "" + empleado.departId + ", " +
                "'" + empleado.cargo + ");";
            sqliteCommand.ExecuteNonQuery();
            conn.Close();
        }

        public void modificar(clsEmpleado empleado)
        {
            SQLiteConnection conn = SQLiteConnector.CreateConnection();
            SQLiteCommand sqliteCommand;
            sqliteCommand = conn.CreateCommand();
            sqliteCommand.CommandText = @"UPDATE Empleado SET " +
                                            "empleadoID = '" + empleado.id + "," +
                                            "nombre = " + empleado.nombre + "," +
                                            "apellido = " + empleado.apellido + "," +
                                            "departamentID = " + empleado.departId + "," +
                                            "cargo = " + empleado.cargo + ";";
            sqliteCommand.ExecuteNonQuery();
            conn.Close();
        }

        public void eliminar(clsEmpleado empleado)
        {
            SQLiteConnection conn = SQLiteConnector.CreateConnection();
            SQLiteCommand sqliteCommand;
            sqliteCommand = conn.CreateCommand();
            sqliteCommand.CommandText = "DELETE FROM Empleado WHERE empleadoID = " + empleado.id+ ";";
            sqliteCommand.ExecuteNonQuery();
            conn.Close();
        }
    }
}

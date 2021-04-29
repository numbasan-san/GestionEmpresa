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
    class suportRegion
    {
        public suportRegion()
        {
            SQLiteConnector.CreateTable();
        }

        public List<clsRegion> verRegistro()
        {

            SQLiteConnector.CreateTable();
            List<clsRegion> Regiones = new List<clsRegion>();
            SQLiteConnection conn = SQLiteConnector.CreateConnection();
            SQLiteCommand command;
            SQLiteDataReader reader;
            command = conn.CreateCommand();

            command.CommandText = "SELECT * FROM Region";
            try
            {
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Regiones.Add(new clsRegion(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2)
                    ));

                }
            }
            catch (SQLiteException e)
            {
                System.Windows.Forms.MessageBox.Show(e.ToString());
            }
            conn.Close();
            return Regiones;
        }

        public DataSet dataSet()
        {
            DataSet ds = new DataSet();
            SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM Region", SQLiteConnector.CreateConnection());
            da.Fill(ds);
            return ds;
        }

        public void agregar(clsRegion region)
        {
            SQLiteConnection conn = SQLiteConnector.CreateConnection();
            SQLiteCommand sqliteCommand;
            sqliteCommand = conn.CreateCommand();
            sqliteCommand.CommandText = @"INSERT INTO Region(paisId, continente, pais) VALUES (" +
                "" + region.codigo + ", " +
                "" + region.continente + ", " +
                "'" + region.pais + ");";
            sqliteCommand.ExecuteNonQuery();
            conn.Close();
        }

        public void modificar(clsRegion region)
        {
            SQLiteConnection conn = SQLiteConnector.CreateConnection();
            SQLiteCommand sqliteCommand;
            sqliteCommand = conn.CreateCommand();
            sqliteCommand.CommandText = @"UPDATE Region SET " +
                                            "paisId = " + region.codigo + "," +
                                            "continente = " + region.continente + "," +
                                            "pais = '" + region.pais + ";";
            sqliteCommand.ExecuteNonQuery();
            conn.Close();
        }

        public void eliminar(clsRegion region)
        {
            SQLiteConnection conn = SQLiteConnector.CreateConnection();
            SQLiteCommand sqliteCommand;
            sqliteCommand = conn.CreateCommand();
            sqliteCommand.CommandText = "DELETE FROM Region WHERE paisId = " + region.codigo + ";";
            sqliteCommand.ExecuteNonQuery();
            conn.Close();
        }
    }
}

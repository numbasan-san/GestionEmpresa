using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace GestionEmpresa.Data
{
    class SQLiteConnector
    {
        public static SQLiteConnection CreateConnection()
        {
            SQLiteConnection sqliteConn;
            sqliteConn = new SQLiteConnection("Data Source = Data.db; Version = 3; New = True; Compress = True;");
            try
            {
                sqliteConn.Open();
            }
            catch
            {

            }
            return sqliteConn;
        }

        public static void CreateTable()
        {
            SQLiteCommand sqliteCommand;
            string createSQL = @"
            CREATE TABLE 'Region' (
                'paisID'   INTEGER,
	            'pais'    TEXT,
	            'continete'    TEXT,
	             PRIMARY KEY('paisID' AUTOINCREMENT)
            );
            CREATE TABLE 'Departamento' ( 
                'departamentID'    INTEGER,	
                'nombre'    TEXT,	
                'paisID'    INTEGER,	
                'noContact' INTEGER,
            PRIMARY KEY('departamentID' AUTOINCREMENT),
            FOREIGN KEY('Region') REFERENCES Region(paisID) 
            );
            CREATE TABLE 'Empleado' ( 
                'empleadoID'    INTEGER,	
                'nombre'    TEXT,	
                'apellido'    TEXT,	
                'departamentID'    INTEGER,	
                'cargo' TEXT,
            PRIMARY KEY('empleadoID' AUTOINCREMENT),
            FOREIGN KEY('Departamento') REFERENCES Departamento(departamentID) 
            );";
            sqliteCommand = SQLiteConnector.CreateConnection().CreateCommand();
            sqliteCommand.CommandText = createSQL;
            try
            {
                sqliteCommand.ExecuteNonQuery();

            }
            catch
            {

            }
        }

    }
}

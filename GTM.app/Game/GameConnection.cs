using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTM.app.Game
{
    public static class GameConnection
    {
        public static string ConnectionBaseString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=";
        public static string RootFolder { get; set; }
        private static OleDbConnection connection;

        public static DataSet GetLastSave()
        {
            connection = new OleDbConnection($"{ConnectionBaseString}{RootFolder}\\Config;Extended Properties=\"text;HDR=YES;FMT=FixedLength;\"");
            string selectQuery = "SELECT * FROM lastgame.dat";
            OleDbDataAdapter saveCommand = new OleDbDataAdapter(selectQuery, connection);
            DataSet dataSet = new DataSet();
            
            saveCommand.Fill(dataSet);

            // Just wanna check something
            foreach (DataRow dr in dataSet.Tables[0].Rows)
            {
                StringBuilder stringBuilder = new StringBuilder();
                foreach (DataColumn dc in dataSet.Tables[0].Columns)
                {
                    stringBuilder.Append($"{dc.ColumnName}: {dr[dc]}");
                }
            }

            return dataSet;
        }
    }
}

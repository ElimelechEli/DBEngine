using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DBEngine.Entities;

namespace DBEngine.DAL
{
    public abstract class AbsDBEngine : IDBEngine
    {
        public string objectType;

        public IDBEngine Delete(string filter)
        {
            // Assembles query
            return NonQuery("");
        }

        public IDBEngine Insert(string tableName, Dictionary<string, string> column_data)
        {
            // Assembles query
            return NonQuery("");
        }

        public IDBEngine Select(string filter, out DataTable results)
        {
            IDBEngine temp =  Query("", out DataTable data);
            results = data;
            return temp;   
        }

        public IDBEngine Update(string tableName, string filter, Dictionary<string, string> column_data)
        {
            // Assembles query
            return NonQuery("");
        }

        // Performs connection to DB
        public abstract bool Connect();

        // Performs requested query
        public abstract IDBEngine Query(string query, out DataTable results);

        public abstract IDBEngine NonQuery(string query);

        // Checks if connected
        public abstract bool isConnected();
    }
}

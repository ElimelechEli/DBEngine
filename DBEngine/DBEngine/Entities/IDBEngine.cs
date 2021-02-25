using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DBEngine.Entities
{
    public interface IDBEngine
    {
        IDBEngine Select(string filter, out DataTable results);
        IDBEngine Insert(string tableName, Dictionary<string, string> column_data);
        IDBEngine Update(string tableName, string filter, Dictionary<string, string> column_data);
        IDBEngine Delete(string filter);
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using DBEngine.DAL;
using DBEngine.Entities;

namespace DBEngine.Factories
{
    public class DBEngineFacroty
    {
        public IDBEngine GetBD(string sqlEngineType)
        {
            switch (sqlEngineType.ToUpper().Trim())
            {
                case "MSSQL": return new MSSqlEngine();
                case "MYSQL": return new MySQLEngine();
                default: throw new Exception($"No Such Database Engine Exist: {sqlEngineType}");
            }
        }
    }
}

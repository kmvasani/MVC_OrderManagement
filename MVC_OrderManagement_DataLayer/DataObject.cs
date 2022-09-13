using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MVC_OrderManagement_DataLayer
{
    public class DataObject
    {
        private string _ConnectionString { get; set;}
        private SqlTransaction _transaction { get; set;}
        public DataObject()
        {
            _ConnectionString = ConfigurationManager.ConnectionStrings["OrderDB"].ConnectionString;
        }
        public DataObject(SqlTransaction trans)
        {
            _ConnectionString = ConfigurationManager.ConnectionStrings["OrderDB"].ConnectionString;
            _transaction = trans;
        }

        public string ConnectionString => _ConnectionString;
        public SqlTransaction Transaction => _transaction;
    }
}
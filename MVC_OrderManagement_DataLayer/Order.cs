using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MVC_OrderManagement_DataLayer
{
    public class Order : DataObject
    {
        public Order() : base()
        {
        }

        public Order(SqlTransaction transaction) : base(transaction)
        {

        }

        [Display(Name = "Order Id")]
        public Guid OrderId { get; set; }

        [Display(Name = "Order Name")]
        [Required]
        public string OrderName { get; set; }

        [Display(Name = "Order Date")]
        public DateTime OrderDate { get; set; }

        public string OrderStatus { get; set; }



        public Order GetOrder(string orderid)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlCommand cmd;

            //Short form of this code is given below

            //if (Transaction != null)
            //{
            //    cmd = new SqlCommand("GetOrder", connection) { CommandType = System.Data.CommandType.StoredProcedure };
            //}
            //else
            //{
            //    cmd = new SqlCommand("GetOrder", connection,Transaction) { CommandType = System.Data.CommandType.StoredProcedure };
            //}

            cmd = Transaction != null
                ? new SqlCommand("GetOrder", connection) { CommandType = System.Data.CommandType.StoredProcedure }
                : new SqlCommand("GetOrder", connection, Transaction) { CommandType = System.Data.CommandType.StoredProcedure };

            //@OrderId is in stored Procedure

            cmd.Parameters.AddWithValue("@OrderId", orderid);
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            try
            {
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();

            }

            //tranform the dataset to entities

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                return new Order()
                {
                    OrderId = new Guid(orderid),
                    OrderName = dr["Name"].ToString(),
                    OrderDate = (DateTime)dr["OrderDate"],
                    OrderStatus = "Active"
                };

            }

            return new Order();
        }
        public Order UpdateOrder(Order order)
        {
            return new Order();
        }
        public void DeleteOrder(Guid orderid)
        {

        }
        public Order CreateOrder(Order order)
        {
            return new Order();
        }

        public List<Order> GetOrders()
        {
            return new List<Order>();
        }
    }
}
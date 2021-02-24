using MovieRentalAssignment.PresentationLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalAssignment.DataAccessLayer
{
    public class Customer
    {
        // Show Customers
        public DataTable DisplayAllCustomers()
        {
            SqlCommand cmd = DataBaseConnection.OpenConnection().CreateCommand();

            cmd.CommandText = " select CustID, CONCAT(firstname,' ',lastname,' - S / D of ',fathername) as name from customer";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            da.Fill(ds);
            cmd.Dispose();
            return ds;
        }

        // Show Customers for Grid
        public DataTable ShowCustomersTbl()
        {
            SqlCommand cmd = DataBaseConnection.OpenConnection().CreateCommand();

            cmd.CommandText = " select * from customer";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            da.Fill(ds);
            cmd.Dispose();
            return ds;
        }

        // Delete customer
        public bool DeleteCustomerTblData(string CustID)
        {
            SqlCommand cmd = DataBaseConnection.OpenConnection().CreateCommand();
            cmd.CommandText = "delete customer where custid=@custId";
          
            cmd.Parameters.AddWithValue("@custId", CustID);
            bool ans = cmd.ExecuteNonQuery() > 0;
            cmd.Dispose();
            return ans;
        }


        // to add customer information
        public bool AddCustomerData(CustomerDataTbl data)
        {
            SqlCommand cmd = DataBaseConnection.OpenConnection().CreateCommand();
            cmd.CommandText = "AddCustInfo"; // stored procedure
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FirstName", data.FirstName);
            cmd.Parameters.AddWithValue("@LastName", data.LastName);
            cmd.Parameters.AddWithValue("@fathername", data.fatherName);
            cmd.Parameters.AddWithValue("@Address", data.Address);
            cmd.Parameters.AddWithValue("@Phone", data.Phone);
            bool ans = cmd.ExecuteNonQuery() > 0;
            cmd.Dispose();
            return ans;
        }

        // Update customer
        public bool UpdateCustomerInformation(CustomerDataTbl data)
        {
            SqlCommand cmd = DataBaseConnection.OpenConnection().CreateCommand();
            cmd.CommandText = "update customer set firstName=@Fname,lastname=@Lname,fathername=@fathername, address=@address, phone=@phone where custId=@custId";
            cmd.Parameters.AddWithValue("@custId", data.CustId);
            cmd.Parameters.AddWithValue("@Fname", data.FirstName);
            cmd.Parameters.AddWithValue("@Lname", data.LastName);
            cmd.Parameters.AddWithValue("@fathername", data.fatherName);
            cmd.Parameters.AddWithValue("@address", data.Address);
            cmd.Parameters.AddWithValue("@phone", data.Phone);
            bool ans = cmd.ExecuteNonQuery() > 0;
            cmd.Dispose();
            return ans;
        }


        // Show Customer Information
        public CustomerDataTbl ShowCustomerFromID(int CustId)
        {
            SqlCommand cmd = DataBaseConnection.OpenConnection().CreateCommand();

            cmd.CommandText = "Select * from customer where custid=@CustId";
           
            cmd.Parameters.AddWithValue("@CustId", CustId);
            CustomerDataTbl data = null;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                data = new CustomerDataTbl();
                data.FirstName = reader[1].ToString();
                data.LastName = reader[2].ToString();
                data.fatherName = reader[3].ToString();
                data.Address = reader[4].ToString();
                data.Phone = reader[5].ToString();
                
            }
            reader.Dispose();
            cmd.Dispose();
            return data;
        }
    }
}

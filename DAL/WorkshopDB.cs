using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOL;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class WorkshopDB
    {
        public bool InsertIntoDB(tbl_Workshop workshop)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=ADMIN-PC\\PritSQLExpress;Initial Catalog=Workshop;Integrated Security=True;";
            //try
            //{
                //Insert the 'workshop' into DB               

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO tbl_Workshop VALUES (@WorkshopTitle, @WorkshopDate, @WorkshopDuration, @WorkshopTopics, NULL, NULL, NULL, NULL);";
                cmd.Connection = conn;

                cmd.Parameters.AddWithValue("@WorkshopTitle", workshop.WorkshopTitle);
                cmd.Parameters.AddWithValue("@WorkshopDate", workshop.WorkshopDate);
                cmd.Parameters.AddWithValue("@WorkshopDuration", workshop.WorkshopDuration);
                cmd.Parameters.AddWithValue("@WorkshopTopics", workshop.WorkshopTopics);

                conn.Open();
                cmd.ExecuteNonQuery();
                
            //}
            //catch (Exception ex)
            //{

            //}
            //finally
            //{
                conn.Close();
            //}


            return true;
        }
    }
}

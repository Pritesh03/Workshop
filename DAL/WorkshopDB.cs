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
            conn.ConnectionString = "Data Source = ADMIN-PC\\PritSQLExpress; Initial Catalog = Workshop; Integrated Security = True;";
            try
            {
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

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return true;
        }

        public List<tbl_Workshop> GetWorkshops()
        {
            List<tbl_Workshop> lstWorkshops = new List<tbl_Workshop>();
            try
            {
                using(SqlConnection conn = new SqlConnection("Data Source = ADMIN-PC\\PritSQLExpress; Initial Catalog = Workshop; Integrated Security = True;"))
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_Workshop", conn);

                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while(dr.Read())
                    {
                        tbl_Workshop workshop = new tbl_Workshop();
                        workshop.WorkshopId = int.Parse(dr["WorkshopId"].ToString());
                        workshop.WorkshopTitle = Convert.ToString(dr["WorkshopTitle"]);
                        workshop.WorkshopDate = DateTime.Parse(dr["WorkshopDate"].ToString());
                        workshop.WorkshopDuration = Convert.ToString(dr["WorkshopDuration"]);
                        workshop.WorkshopTopics = Convert.ToString(dr["WorkshopTopics"]);

                        lstWorkshops.Add(workshop);
                    }
                    dr.Close();
                }
            }
            catch
            {
            }
            return lstWorkshops;
        }
    }
}

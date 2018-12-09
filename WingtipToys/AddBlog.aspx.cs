using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WingtipToys
{
    public partial class AddBlog : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void AddPost(object sender, EventArgs e)
        {
            if (titlePost.Text != "" && textPost.Text != "")
            {
                string serverConnectiob = WebConfigurationManager.ConnectionStrings["WingtipToys"].ConnectionString;
                String queryString = "Insert into Posts(title, text, date) " +
                                    "VALUES (@a, @b, @c )";

                using (SqlConnection connection = new SqlConnection(
                        serverConnectiob))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.AddWithValue("@a", titlePost.Text);
                    command.Parameters.AddWithValue("@b", textPost.Text);
                    command.Parameters.AddWithValue("@c", DateTime.Now);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    command.Connection.Close();
                }
            }
        }
    }
}
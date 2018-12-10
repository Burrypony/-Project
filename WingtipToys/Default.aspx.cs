using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WingtipToys.Models;

namespace WingtipToys
{
  public partial class _Default : Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
            GetPosts();
    }


        public void GetPosts()
        {
            string strCon = System.Web
                                  .Configuration
                                  .WebConfigurationManager
                                  .ConnectionStrings["WingtipToys"].ConnectionString;

            SqlConnection conn = new SqlConnection(strCon);

            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM[POSTS] ORDER BY [date] DESC", conn);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            BlogPosts.DataSource = ds;
            BlogPosts.DataBind();

            /*
            List<Post> posts = new List<Post>();
            String sql = "SELECT * FROM [POSTS] ORDER BY [date]";

            string strCon = System.Web
                                  .Configuration
                                  .WebConfigurationManager
                                  .ConnectionStrings["SocialSiteConnectionString"].ConnectionString;

            SqlConnection conn = new SqlConnection(strCon);
            SqlCommand comm = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataReader nwReader = comm.ExecuteReader();
            while( nwReader.Read() )
            {
                posts.Add(new Post
                {
                    PostId = nwReader.GetInt32(0),
                    title = nwReader.GetString(1),
                    text = nwReader.GetString(2),
                    date = nwReader.GetDateTime(3)
                });
            }
            */

        }

    private void Page_Error(object sender, EventArgs e)
    {
      // Get last error from the server.
      Exception exc = Server.GetLastError();

      // Handle specific exception.
      if (exc is InvalidOperationException)
      {
        // Pass the error on to the error page.
        Server.Transfer("ErrorPage.aspx?handler=Page_Error%20-%20Default.aspx",
            true);
      }
    }
  }
}
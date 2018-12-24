using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;

namespace WingtipToys
{
    public partial class PostInfo : System.Web.UI.Page
    {
        public string title;
        public string text;
        public string date;
        private int? postId = null;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            int postId;
            
            if ( Int32.TryParse(Request.QueryString["id"], out postId))
            {
                this.postId = postId; 
                GetPost( postId );
                GetComments(postId);
            }
            else
            {
                Label1.Text = "Post does not exist";
            }
            
        }
        private void GetPost(int id)
        {
            string strCon = System.Web
                      .Configuration
                      .WebConfigurationManager
                      .ConnectionStrings["WingtipToys"].ConnectionString;

            SqlConnection conn = new SqlConnection(strCon);

            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM[POSTS] WHERE PostId = " +  id, conn);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            if ( ds.Tables[0].Rows.Count > 0 )
            {
                Label1.Text = ds.Tables[0].Rows[0].ItemArray.GetValue(1).ToString();
                TextBox1.Text = ds.Tables[0].Rows[0].ItemArray.GetValue(2).ToString();
                Label2.Text = ds.Tables[0].Rows[0].ItemArray.GetValue(3).ToString();
            }
        }
        protected void AddComment(object sender, EventArgs e)
        {
            if (writeCommentText.Text != "" && postId!= null)
            {
                string serverConnectiob = WebConfigurationManager.ConnectionStrings["WingtipToys"].ConnectionString;
                String queryString = "Insert into Comments(CommentText, CommentData, CommentUserName, CommentPostId) " +
                                    "VALUES (@a, @b, @c, @d)";

                using (SqlConnection connection = new SqlConnection(
                        serverConnectiob))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.AddWithValue("@a", writeCommentText.Text);
                    command.Parameters.AddWithValue("@b", DateTime.Now);
                    command.Parameters.AddWithValue("@c", Context.User.Identity.GetUserName());
                    command.Parameters.AddWithValue("@d", postId);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    command.Connection.Close();
                }

                Response.Redirect(Request.RawUrl);
            }
        }
        public void GetComments(int id)
        {
            string strCon = System.Web
                      .Configuration
                      .WebConfigurationManager
                      .ConnectionStrings["WingtipToys"].ConnectionString;

            SqlConnection conn = new SqlConnection(strCon);

            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM[Comments]WHERE CommentPostId = " +  id, conn);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            CommentPost.DataSource = ds;
            CommentPost.DataBind();
        }
    }


}
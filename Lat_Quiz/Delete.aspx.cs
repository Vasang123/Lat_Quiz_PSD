using Lat_Quiz.controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lat_Quiz
{
    public partial class Delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            error.Text = Controller.FindDeletedSong(Int64.Parse(Request.QueryString["id"]));
            if (error.Text == "success")
            {
                Response.Redirect("Home.aspx");
            }
        }
    }
}
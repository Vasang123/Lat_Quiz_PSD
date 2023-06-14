using Lat_Quiz.controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lat_Quiz
{
    public partial class Create : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void createSong_Click(object sender, EventArgs e)
        {

            error.Text = Controller.validateCreateData(songName.Text, artistName.Text, date.Text, description.Text);
            if(error.Text == "success")
            {
                Response.Redirect("Home.aspx");
            }
        }
    
    }
}
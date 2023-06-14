using Lat_Quiz.controller;
using Lat_Quiz.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lat_Quiz
{
    public partial class Update : System.Web.UI.Page
    {
        protected MsSong song = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            song = songRepository.getSong(Int64.Parse(Request.QueryString["id"]));
            if (!IsPostBack) // only assign value once during initial page load
            {
                songName.Text = song.SongName;
                artistName.Text = song.ArtistName;
                date.Text = song.ReleaseDate.ToString("yyyy-MM-dd");
                description.Text = song.SongDescription;
            }
        }

        protected void updateSong_Click(object sender, EventArgs e)
        {
            error.Text = Controller.validateUpdateData(song.ID, songName.Text, artistName.Text, date.Text, description.Text);
            if (error.Text == "success")
            {
                Response.Redirect("Home.aspx");
            }
        }
    }
}
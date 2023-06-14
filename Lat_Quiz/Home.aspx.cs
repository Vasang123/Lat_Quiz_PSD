using Lat_Quiz.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lat_Quiz
{
    
    public partial class Home : System.Web.UI.Page
    {
        protected List<MsSong> songs = null;
        protected bool data = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            songs = songRepository.getSongs();
            data = songRepository.checkUniqueInsert("1234");
            test.Text = data.ToString();
        }
        public List<MsSong> Songs
        {
            get { return songs; }
        }

    }
}
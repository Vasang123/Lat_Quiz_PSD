using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lat_Quiz.factory
{
    public class SongFactory
    {
        public static MsSong create(string SongName, string ArtistName, DateTime ReleaseDate, string SongDescription)
        {
            MsSong song = new MsSong();
            song.SongName = SongName;
            song.ArtistName = ArtistName;
            song.ReleaseDate = ReleaseDate;
            song.SongDescription = SongDescription;
            return song;
        }
    }
}
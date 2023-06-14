using Lat_Quiz.factory;
using Lat_Quiz.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lat_Quiz.controller
{
    public class Controller
    {
        public static string validateCreateData(string SongName, string ArtistName, string ReleaseDate ,string SongDescription)
        {
            if (SongName.Equals(""))
            {
                return "Song Name Can't be empty";
            } else if (songRepository.checkUniqueInsert(SongName) == true) {
                return "Song Name must be unique";
            }
            else if (ArtistName.Equals(""))
            {
                return "Artist Name Can't be empty";
            }
            else if (ArtistName.Length < 3)
            {
                return "Artist Name minimal 3 words";
            }
            else if (ReleaseDate.Equals(""))
            {
                return "Release Date Can't be empty";
            }
            else if (SongDescription.Equals(""))
            {
                return "Song Desc Can't be empty";
            }
            else if (SongDescription.Length > 255)
            {
                return "Song Desc Max characters is 255";
            }
            songRepository.AddSong(SongFactory.create(SongName, ArtistName, DateTime.Parse(ReleaseDate), SongDescription));
            return "success";
        }
        public static string validateUpdateData(Int64 id, string SongName, string ArtistName, string ReleaseDate, string SongDescription)
        {
            if (SongName.Equals(""))
            {
                return "Song Name Can't be empty";
            }
            else if (songRepository.checkUniqueUpdate(SongName,id) == true)
            {
                return "Song Name must be unique";
            }
            else if (ArtistName.Equals(""))
            {
                return "Artist Name Can't be empty";
            }
            else if (ArtistName.Length < 3)
            {
                return "Artist Name minimal 3 words";
            }
            else if (ReleaseDate.Equals(""))
            {
                return "Release Date Can't be empty";
            }
            else if (SongDescription.Equals(""))
            {
                return "Song Desc Can't be empty";
            }
            else if (SongDescription.Length > 255)
            {
                return "Song Desc Max characters is 255";
            }
            songRepository.UpdateSong(SongFactory.create(SongName, ArtistName, DateTime.Parse(ReleaseDate), SongDescription), id);
            return "success";
        }
        public static string FindDeletedSong(Int64 id)
        {
            return songRepository.DeleteSong(id);
        }
    }
}
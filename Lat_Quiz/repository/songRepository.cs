using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lat_Quiz.repository
{
    public class songRepository
    {
        public static Database1Entities 
            database = new Database1Entities();
       
        public static List<MsSong> getSongs()
        {
            return (from x in database.MsSongs select x).ToList();
        }
        public static MsSong getSong(Int64 id)
        {
            return (from x in database.MsSongs where x.ID == id select x).FirstOrDefault();
        }
        public static bool checkUniqueInsert(string name)
        {
            var query= from x in database.MsSongs where x.SongName == name select x ;
            return query.Any();

        }
        public static bool checkUniqueUpdate(string name, Int64 id)
        {
            var query = from x in database.MsSongs where x.SongName == name && x.ID != id select x;
            return query.Any();

        }
        public static string AddSong(MsSong song)
        {
            database.MsSongs.Add(song);
            database.SaveChanges();
            return song.SongName;
        }
        public static void UpdateSong(MsSong song, Int64 id)
        {
            var updateSong = database.MsSongs.Find(id);
            if(updateSong != null)
            {
                updateSong.SongName = song.SongName;
                updateSong.ArtistName = song.ArtistName;
                updateSong.ReleaseDate = song.ReleaseDate;
                updateSong.SongDescription = song.SongDescription;
                database.SaveChanges();
            }
        }
        public static string DeleteSong(Int64 id)
        {
            var deleteSong = database.MsSongs.Find(id);
            if (deleteSong != null)
            {
                database.MsSongs.Remove(deleteSong);
                database.SaveChanges();
                return "success";
            }
            return "fail";
        }
    }
}
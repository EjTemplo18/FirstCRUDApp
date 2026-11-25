using Microsoft.Data.SqlClient;

namespace FirstCRUDApp;

public static class SongDB
{
    private static List<Song> songs = new List<Song>();

    public static List<Song> GetAllSongs()
    { 
        // Get connection to the database
        SqlConnection con = new SqlConnection();

        // Prepare our SQL

        // Execute SQL

        // Read results and put data into a List<Song>

        // Return the list of songs
    }

    public static void AddSong(Song song)
    {
        throw new NotImplementedException();
    }

    public static void UpdateSong(Song song)
    {
        throw new NotImplementedException();
    }

    public static void DeleteSong(Song song)
    {
        throw new NotImplementedException();
    }
}

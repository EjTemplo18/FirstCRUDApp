using Microsoft.Data.SqlClient;

namespace FirstCRUDApp;

public static class SongDB
{
    private static List<Song> songs = new List<Song>();

    public static List<Song> GetAllSongs()
    { 
        // Get connection to the database
        SqlConnection con = new();
        con.ConnectionString = "Data Source=localhost;Initial Catalog=SongDb;Integrated Security=True;Trust Server Certificate=True;";

        // Open the connection to the database
        con.Open();

        // Prepare our SQL
        SqlCommand selectCommand = new();
        selectCommand.Connection = con;
        selectCommand.CommandText =
            """
            SELECT Id
            , Genre
            , Artists
            , SongTitle
            , Album
            , NumberOfStreams
            , SongFileLocation
            FROM Songs
            """;

        // Execute SQL
        SqlDataReader reader = selectCommand.ExecuteReader();

        // Read results and put data into a List<Song>
        List<Song> songs = new();
        while (reader.Read())
        {
            Song mySong = new()
            {
                Id = reader.GetInt32(0),
                // Conditional/ternary operator to check if Genre is null in the database.
                Genre = reader.GetString(1),
                Artists = reader.GetString(2),
                // Set song title to value but if it's null use empty string instead. This is a null coalescing operator.
                SongTitle = reader.GetString(3),
                Album = reader.GetString(4),
                NumberOfStreams = reader.GetInt32(5),
                SongFileLocation = reader.GetString(6)
            };

            songs.Add(mySong);
        }

        // Close the connection to the database
        con.Close();

        // Return the list of songs
        return songs;
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

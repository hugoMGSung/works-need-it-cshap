using System.Data;
using System.Data.SqlClient;
using WpfMovieFinder.Models;
using WpfMovieFinder.Views;

namespace WpfMovieFinder.Helpers
{
    public class DAL
    {
        public static DataSet GetAllMovies()
        {
            using (SqlConnection conn = new SqlConnection(Commons.CONNSTRING))
            {
                using (SqlCommand cmd = new SqlCommand("GetAllMovies", conn))
                {
                    conn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    return ds;
                }
            }
        }


        public static void SetWatchMovie(MovieEntity param)
        {
            using (SqlConnection conn = new SqlConnection(Commons.CONNSTRING))
            {
                using (SqlCommand cmd = new SqlCommand("AddNewMovie", conn))
                {
                    conn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Title", param.Title);
                    cmd.Parameters.AddWithValue("@Year", param.Year);
                    cmd.Parameters.AddWithValue("@imdbRating", param.Rated);
                    cmd.Parameters.AddWithValue("@Runtime", param.Runtime);
                    cmd.Parameters.AddWithValue("@Genre", param.Genre);
                    cmd.Parameters.AddWithValue("@Actors", param.Actors);
                    cmd.Parameters.AddWithValue("@Plot", param.Plot);
                    cmd.Parameters.AddWithValue("@Metascore", param.Metascore);
                    cmd.Parameters.AddWithValue("@Poster", param.Poster);
                    cmd.Parameters.AddWithValue("@Image", param.Picture);
                    cmd.Parameters.AddWithValue("@Trailer", param.Trailer);

                    var i = cmd.ExecuteNonQuery();

                    if (i >= 1)
                    {
                        CustomPopupView cmsg = new CustomPopupView("Added watch list");
                        cmsg.ShowDialog();
                        return;
                    }
                    else
                    {
                        CustomPopupView cmsg = new CustomPopupView("Exists in watch list");
                        cmsg.ShowDialog();
                        return;
                    }
                }
            }
        }
        // TODO
    }
}

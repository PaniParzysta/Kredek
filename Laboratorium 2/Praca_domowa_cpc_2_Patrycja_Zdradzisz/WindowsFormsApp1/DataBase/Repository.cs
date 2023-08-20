using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1.DataBase
{
    class Repository
    {
        private readonly SqlConnection _connection = new SqlConnection(Properties.Resources.ConnectionString);

        /// <summary>
        /// Wyciągnięcie do tabeli widoku z Films z bazy danych
        /// </summary>
        /// <returns></returns>
        public DataTable GetFilms()
        {
            string query = "SELECT * FROM ViewFilms; ";
            SqlDataAdapter adapter = new SqlDataAdapter(query, _connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }

        /// <summary>
        /// Wyciągnięcie do tabeli widoku z Actor z bazy danych
        /// </summary>
        /// <returns></returns>
        public DataTable GetFilmsActor()
        {
            string query = "SELECT * FROM ViewFilmsActor; ";
            SqlDataAdapter adapter = new SqlDataAdapter(query, _connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }

        /// <summary>
        /// Wyciągnięcie do tabeli filmów z wybranym aktorem
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <returns></returns>
        public DataTable GetActor(string firstName, string lastName)
        {
            string query = "SELECT * FROM ViewFilmsActor WHERE FirstName='" + firstName + "' AND LastName='" + lastName + "';";
            SqlDataAdapter adapter = new SqlDataAdapter(query, _connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }
        /// <summary>
        /// Wyciągnięcie do tabeli widoku z Category z bazy danych
        /// </summary>
        /// <returns></returns>
        public DataTable GetFilmsCategory()
        {
            string query = "SELECT * FROM ViewFilmsCategory; ";
            SqlDataAdapter adapter = new SqlDataAdapter(query, _connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }

        /// <summary>
        /// Wyciągnięcie do tabeli filmów z wybraną kategorią
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        public DataTable GetCategory(string category)
        {
            string query = "SELECT * FROM ViewFilmsCategory WHERE NameCategory='" + category + "';";
            SqlDataAdapter adapter = new SqlDataAdapter(query, _connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }
        /// <summary>
        /// Wyciągnięcie do tabeli widoku z Rental z bazy danych 
        /// </summary>
        /// <returns></returns>
        public DataTable GetFilmsRental()
        {
            string query = "SELECT * FROM ViewRental; ";
            SqlDataAdapter adapter = new SqlDataAdapter(query, _connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }

        /// <summary>
        /// Metoda sprawdzająca czy istnieje użytkownik
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool Login(string login, string password)
        {
            string query = "SELECT COUNT(*) FROM Users WHERE UserName='" + login + "' AND Password='" + password + "';";

            _connection.Open();

            SqlCommand comm = new SqlCommand(query, _connection);
            int foundUsers = (int)comm.ExecuteScalar();


            _connection.Close();

            if (foundUsers >= 1)
                return true;
            return false;
        }

        /// <summary>
        /// Metoda dodająca film
        /// </summary>
        /// <param name="title"></param>
        /// <param name="yearOfProduction"></param>
        /// <param name="subtitles"></param>
        /// <param name="language"></param>
        /// <param name="rental"></param>
        public void AddFilm(string title, int yearOfProduction, string subtitles, string language, int rental)
        {
            string queryGetSubtitlesId = "SELECT Id FROM Subtitles WHERE NameSubtitles='" + subtitles +"';";
            string queryGetLanguageId = "SELECT Id FROM Languages WHERE NameLanguage='" + language + "';";

            _connection.Open();

            SqlCommand commandGetSubtitlesId = new SqlCommand(queryGetSubtitlesId, _connection);
            int subtitlesId = (int)commandGetSubtitlesId.ExecuteScalar();

            SqlCommand commandGetLanguageId = new SqlCommand(queryGetLanguageId, _connection);
            int languageId = (int)commandGetLanguageId.ExecuteScalar();

            string insertFilmsQuery = "INSERT INTO Films VALUES ('" + title + "'," + yearOfProduction + "," + subtitlesId + "," + languageId +"," + rental + ");";
            SqlCommand commandInsertFilms = new SqlCommand(insertFilmsQuery, _connection);
            commandInsertFilms.ExecuteNonQuery();

            _connection.Close();
        }

        /// <summary>
        /// Metoda usuwająca film z tabeli Films na podstawie filmId
        /// </summary>
        /// <param name="bookId"></param>
        public void DeleteFilm(int filmId)
        {
            string queryDeleteFilm = "DELETE FROM Films WHERE Id=" + filmId;

            _connection.Open();

            SqlCommand commandDeleteFilm = new SqlCommand(queryDeleteFilm, _connection);
            commandDeleteFilm.ExecuteNonQuery();

            _connection.Close();
        }

        /// <summary>
        /// Metoda edytująca książkę z tabeli Films
        /// </summary>
        /// <param name="bookId"></param>
        /// <param name="title"></param>
        /// <param name="yearOfPublish"></param>
        /// <param name="price"></param>
        /// <param name="genre"></param>
        /// <param name="authorFirstName"></param>
        /// <param name="authorLastName"></param>
        public void EditFilm(int filmId, string title, int yearOfProduction, string subtitles, string language, int rental)
        {
            string queryGetSubtitlesId = "SELECT Id FROM Subtitles WHERE NameSubtitles='" + subtitles + "';";
            string queryGetLanguageId = "SELECT Id FROM Languages WHERE NameLanguage='" + language + "';";

            _connection.Open();

            SqlCommand commandGetSubtitlesId = new SqlCommand(queryGetSubtitlesId, _connection);
            int subtitlesId = (int)commandGetSubtitlesId.ExecuteScalar();

            SqlCommand commandGetLanguageId = new SqlCommand(queryGetLanguageId, _connection);
            int languageId = (int)commandGetLanguageId.ExecuteScalar();


            string updateFilmQuery = "UPDATE Films SET Title='" + title + "',YearOfProduction=" + yearOfProduction + ", SubtitlesId=" + subtitlesId + ", LanguageId=" + languageId + ", IsRentable=" + rental + " WHERE Id=" + filmId + ";";
            SqlCommand commandInsertFilm = new SqlCommand(updateFilmQuery, _connection);
            commandInsertFilm.ExecuteNonQuery();

            _connection.Close();
        }
    }
}

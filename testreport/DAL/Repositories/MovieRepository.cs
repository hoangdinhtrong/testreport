using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using testreport.Extensions;
using testreport.Models.Dtos;
using testreport.Models.Entities;

namespace testreport.DAL.Repositories
{
    public class MovieRepository
    {
        private static volatile MovieRepository _instance;
        private static readonly object lockObject = new object();

        private MovieRepository() { }

        public static MovieRepository GetInstance()
        {
            if (_instance == null)
            {
                lock (lockObject)
                {
                    if (_instance == null)
                    {
                        var random = new Random();

                        _instance = new MovieRepository();
                    }
                }
            }
            return _instance;
        }

        public List<Movie> GetMovies()
        {
            string query = @"SELECT Id ,Title ,Genre ,ReleaseDate ,Owner FROM Movies";
            DataTable data = DataProvider.GetInstance().ExecuteQuery(query);
            return data.CreateListFromTable<Movie>();
        }

        public List<Movie> GetPaging(MovieRequestDto request)
        {
            string query = @"SELECT Id ,Title ,Genre ,ReleaseDate ,Owner
                            FROM Movies
                            WHERE(TRIM(@title) IS NULL OR LEN(TRIM(@title)) <= 0 OR Title LIKE '%' + @title + '%')
                                AND(TRIM(@genre) IS NULL OR LEN(TRIM(@genre)) <= 0 OR Genre LIKE '%' + @genre + '%')
                                AND(TRIM(@owner) IS NULL OR LEN(TRIM(@owner)) <= 0 OR Owner LIKE '%' + @owner + '%')
                            ORDER BY Id ASC
                            OFFSET(@pageNumber * @pageSize) ROWS
                            FETCH NEXT @pageSize ROWS ONLY
                "
            ;

            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@title",!string.IsNullOrWhiteSpace(request.Title) ? (object)request.Title.Trim() : DBNull.Value),
                new SqlParameter("@genre",!string.IsNullOrWhiteSpace(request.Genre) ? (object)request.Genre.Trim() : DBNull.Value),
                new SqlParameter("@owner",! string.IsNullOrWhiteSpace(request.Owner) ?(object) request.Owner.Trim() : DBNull.Value),
                new SqlParameter("@pageNumber",request.PageIndex),
                new SqlParameter("@pageSize",request.PageSize),
            };

            DataTable data = DataProvider.GetInstance().ExecuteQuery(query, sqlParameters);
            return data.CreateListFromTable<Movie>();
        }

        public bool Insert(MovieCreateUpdateDto request)
        {
            string query = @"INSERT Movies (Title, Genre, ReleaseDate, Owner)
                            VALUES  (@title, @genre, @releaseDate, @owner)";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@title", request.Title),
                new SqlParameter("@genre", request.Genre),
                new SqlParameter("@owner", request.Owner),
                new SqlParameter("@releaseDate", DateTime.UtcNow),
            };
            int result = DataProvider.GetInstance().ExecuteNonQuery(query, sqlParameters);
            return result > 0;
        }

        public bool Update(MovieCreateUpdateDto request)
        {
            string query = @"UPDATE Movies SET Title = @title, Genre = @genre, Owner = @owner WHERE Id = @id";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@title", request.Title),
                new SqlParameter("@genre", request.Genre),
                new SqlParameter("@owner", request.Owner),
                new SqlParameter("@id", request.Id),
            };
            int result = DataProvider.GetInstance().ExecuteNonQuery(query, sqlParameters);
            return result > 0;
        }

        public bool Delete(int id)
        {
            string query = @"DELETE Movies WHERE Id = @id";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@id", id),
            };
            int result = DataProvider.GetInstance().ExecuteNonQuery(query, sqlParameters);

            return result > 0;
        }
    }
}

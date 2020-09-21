using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace _15PunkteQuiz.Data
{
    public class SqliteDb : IDataSource
    {
        private SQLiteConnection _dbConnection;

        public SqliteDb()
        {
            var dbFilePath = "./questions.sqlite";
            if (!File.Exists(dbFilePath))
                CreateAndSeedDB(dbFilePath);

            _dbConnection = new SQLiteConnection(string.Format(
                "Data Source={0};Version=3;", dbFilePath));
            _dbConnection.Open();
        }

        private void CreateAndSeedDB(string dbFilePath)
        {
            SQLiteConnection.CreateFile(dbFilePath);

            var tmpConnection = new SQLiteConnection(string.Format(
                "Data Source={0};Version=3;", dbFilePath));
            tmpConnection.Open();

            tmpConnection.Execute(
                "CREATE TABLE \"Courses\" (\r\n\t\"Id\"\tTEXT NOT NULL UNIQUE,\r\n\t\"Name\"\tTEXT NOT NULL,\r\n\tPRIMARY KEY(\"Name\")\r\n);");

            tmpConnection.Execute(
                "CREATE TABLE \"Questions\" (\r\n\t\"Id\"\tTEXT NOT NULL UNIQUE,\r\n\t\"CourseId\"\tTEXT NOT NULL,\r\n\t\"Text\"\tTEXT NOT NULL,\r\n\t\"Difficulty\"\tINTEGER NOT NULL,\r\n\t\"RightAnswer\"\tTEXT NOT NULL,\r\n\t\"WrongAnswer1\"\tTEXT NOT NULL,\r\n\t\"WrongAnswer2\"\tTEXT NOT NULL,\r\n\t\"WrongAnswer3\"\tTEXT NOT NULL,\r\n\tPRIMARY KEY(\"Id\"),\r\n\tFOREIGN KEY(\"CourseId\") REFERENCES \"Courses\"(\"Id\") ON DELETE SET NULL\r\n);");

            tmpConnection.Close();
        }

        public List<CourseDto> GetAllCourses()
        {
            throw new NotImplementedException();
        }

        public List<QuestionDto> GetAllQuestionsByCourse(CourseDto course)
        {
            throw new NotImplementedException();
        }

        public List<QuestionDto> GetRandomQuestionByCourse(CourseDto course)
        {
            throw new NotImplementedException();
        }

        public void AddCourse(CourseDto course)
        {
            throw new NotImplementedException();
        }

        public void AddQuestion(QuestionDto question)
        {
            throw new NotImplementedException();
        }

        public void EditQuestion(QuestionDto question)
        {
            throw new NotImplementedException();
        }
    }
}

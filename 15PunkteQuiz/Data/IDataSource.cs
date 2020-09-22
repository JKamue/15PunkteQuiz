using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15PunkteQuiz.Data
{
    public interface IDataSource
    {
        List<CourseDto> GetAllCourses();
        List<QuestionDto> GetAllQuestionsByCourse(CourseDto course);
        QuestionDto GetRandomQuestionByCourse(CourseDto course, int difficulty);

        void AddCourse(CourseDto course);
        void AddQuestionToCourse(QuestionDto question, CourseDto course);
        void EditQuestion(QuestionDto question);
        void DeleteQuestion(QuestionDto question);
    }
}

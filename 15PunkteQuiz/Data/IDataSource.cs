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
        List<QuestionDto> GetRandomQuestionByCourse(CourseDto course);

        void AddCourse(CourseDto course);
        void AddQuestion(QuestionDto question);
        void EditQuestion(QuestionDto question);
    }
}

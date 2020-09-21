using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15PunkteQuiz.Data
{
    class CourseDto
    {
        public string Id;
        public string Name;

        public CourseDto(string id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}

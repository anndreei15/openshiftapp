using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace testopenshift.Controllers
{
    public class HordeController : Controller
    {
        private static Dictionary<string, string> _Students = new Dictionary<string, string>();

        [HttpGet("horde/create/{student}")]
        public string Post(string student, string prenume)
        {
            _Students[student] = prenume;

            return String.Format("{0} added to the list!", student);
        }

        [HttpPatch("horde/edit/{student}")]
        public string Patch(string student, string prenume)
        {
            if (!_Students.ContainsKey(student))
            {
                return "Student not found.";
            }

            _Students[student] = prenume;

            return "Student edited.";
        }

        [HttpGet("horde/details/{student}")]
        public string Details(string student)
        {
            if (!_Students.ContainsKey(student))
            {
                return "Student not found.";
            }

            return _Students[student];
        }

        [HttpDelete("horde/delete/{student}")]
        public string Delete(string student)
        {
            if (!_Students.ContainsKey(student))
            {
                return "Student not found.";
            }

            _Students.Remove(student);

            return "Student deleted.";
        }


    }
}
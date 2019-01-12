using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace testopenshift.Controllers
{
    public class StudentController
    {
        [HttpGet("student/{student}")]
        public string Student(string student)
        {
            switch(student)
            {
                case "create":
                    return "Create a new student";
                case "edit":
                    return "Edit student info!";
                case "details":
                    return "Student details below!";
                case "delete":
                    return "Are you sure you want to delete this student?";

            }
            return String.Empty;
        }
    }
}

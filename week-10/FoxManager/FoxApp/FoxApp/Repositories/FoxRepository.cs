using FoxApp.Entities;
using FoxApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxApp.Repositories
{
    public class FoxRepository
    {
        FoxContext foxContext;

        public FoxRepository(FoxContext foxContext)
        {
            this.foxContext = foxContext;
        }

        public bool CheckStudentExist(string name)
        {
            var user = foxContext.Students.FirstOrDefault(x => x.Name.Equals(name));
            return user != null ? true : false;
        }

        public Student GetStudentInfo(string name)
        {
            return foxContext.Students.FirstOrDefault(y => y.Name.Equals(name));
        }

        public List<Models.Task> GetStudentTaskList(string name)
        {
            return foxContext.Tasks.Where(p => p.Student.Name.Equals(name)).ToList();
        }
    }
}

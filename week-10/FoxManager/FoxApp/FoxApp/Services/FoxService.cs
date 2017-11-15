using FoxApp.Models;
using FoxApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxApp.Services
{
    public class FoxService
    {
        private FoxRepository foxRepository;

        public FoxService(FoxRepository foxRepository)
        {
            this.foxRepository = foxRepository;
        }

        public bool AuthenticateStudent(string name)
        {
            return foxRepository.CheckStudentExist(name);
        }

        public Student GetStudentInfo(string name)
        {
            return foxRepository.GetStudentInfo(name);
        }

        public List<Models.Task> GetStudentProjects(string name)
        {
            return foxRepository.GetStudentTaskList(name);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoApp.Models;
using ToDoApp.Entities;

namespace ToDoApp.Repositories
{
    public class ToDoRepository
    {
        ToDoContext TodoContext;

        public ToDoRepository(ToDoContext todoContext)
        {
            TodoContext = todoContext;
        }
    }
}

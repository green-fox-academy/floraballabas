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

        public void AddTodo()
        {
            var todo = new ToDo()
            {
                Title = "To Understand this",
                IsDone = false,
                IsUrgent = true
            };
            TodoContext.Add(todo);
            TodoContext.SaveChanges();
        }

        public ToDo GetLastToDo()
        {
            return TodoContext.Todoes.Last();
        }
    }
}

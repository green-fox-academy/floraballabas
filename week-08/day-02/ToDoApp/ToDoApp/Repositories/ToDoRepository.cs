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

        public List<ToDo> GetList()
        {
            return TodoContext.Todoes.ToList();
        }

        public List<ToDo> NotDoneList()
        {
            var notDone = from title in TodoContext.Todoes
                          where title.IsDone == false
                          select title;
            return notDone.ToList();
        }

        public void AddTodo(string title)
        {
            var todo = new ToDo()
            {
                Title = title,
                IsDone = false,
                IsUrgent = false
            };

            TodoContext.Todoes.Add(todo);
            TodoContext.SaveChanges();
        }

        public void DeleteTodo(int id)
        {
            ToDo deletedTodo = TodoContext.Todoes.FirstOrDefault(x => x.Id == id);
            TodoContext.Todoes.Remove(deletedTodo);
            TodoContext.SaveChanges();
        }
    }
}

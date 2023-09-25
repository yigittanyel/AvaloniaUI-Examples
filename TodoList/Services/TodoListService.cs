using System.Collections.Generic;
using TodoList.Models;

namespace TodoList.Services;
public class TodoListService
{
    public IEnumerable<TodoItem> GetItems() => new[]
    {
            new TodoItem { Description = "Walk the dog" },
            new TodoItem { Description = "Buy some milk" },
            new TodoItem { Description = "Learn Avalonia", IsChecked = true },
    };
}
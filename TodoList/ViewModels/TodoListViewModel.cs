using System.Collections.Generic;
using System.Collections.ObjectModel;
using TodoList.Models;
namespace TodoList.ViewModels;

public class TodoListViewModel: ViewModelBase
{
    public TodoListViewModel(IEnumerable<TodoItem> items)
    {
        ListItems = new ObservableCollection<TodoItem>(items);
    }

    public ObservableCollection<TodoItem> ListItems { get; }
}

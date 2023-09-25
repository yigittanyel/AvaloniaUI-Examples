using ReactiveUI;
using TodoList.Services;

namespace TodoList.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ViewModelBase _contentViewModel;

        public MainWindowViewModel()
        {
            var service = new TodoListService();
            TodoList = new TodoListViewModel(service.GetItems());
            _contentViewModel = TodoList;
        }

        public TodoListViewModel TodoList { get; }

        public ViewModelBase ContentVm
        {
            get => _contentViewModel;
            private set => this.RaiseAndSetIfChanged(ref _contentViewModel, value);
        }

        public void AddItem()
        {
            ContentVm = new AddNewItemViewModel();
        }
    }
}
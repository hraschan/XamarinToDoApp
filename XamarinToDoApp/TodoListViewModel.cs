using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinToDoApp
{
    internal class TodoListViewModel
    {
        public ObservableCollection<ToDoItem> todoItems { get; set; }

        public ICommand AddTodoCommand => new Command(AddTodoItem);
        public ICommand DeleteTodoCommand => new Command(DeleteTodoItem);

        public string NewTodoInputValue { get; set; }

        public TodoListViewModel()
        {
           todoItems = new ObservableCollection<ToDoItem>();

           todoItems.Add(new ToDoItem("todo 1", false));
           todoItems.Add(new ToDoItem("todo 2", true));

        }

        void AddTodoItem()
        {
            todoItems.Add(new ToDoItem(NewTodoInputValue, false));


        }

        void DeleteTodoItem(object item)
        {
            ToDoItem todoItemBeingRemoved = item as ToDoItem;
            todoItems.Remove(todoItemBeingRemoved);
        }

    }
}

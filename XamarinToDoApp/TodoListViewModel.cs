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
        // Liste
        public ObservableCollection<ToDoItem> todoItems { get; set; }

        // Commands
        public ICommand AddTodoCommand => new Command(AddTodoItem);
        public ICommand DeleteTodoCommand => new Command(DeleteTodoItem);

        public string NewTodoInputValue { get; set; }

        // Constructor
        public TodoListViewModel()
        {
           todoItems = new ObservableCollection<ToDoItem>();

           todoItems.Add(new ToDoItem("todo 1", false));
           todoItems.Add(new ToDoItem("todo 2", true));

        }

        // Add todo item
        void AddTodoItem()
        {
            todoItems.Add(new ToDoItem(NewTodoInputValue, false));


        }

        // Delete Todo item
        void DeleteTodoItem(object item)
        {
            ToDoItem todoItemBeingRemoved = item as ToDoItem;
            todoItems.Remove(todoItemBeingRemoved);
        }

    }
}

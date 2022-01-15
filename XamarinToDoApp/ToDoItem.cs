using System;
using System.Collections.Generic;
using System.Text;


namespace XamarinToDoApp
{
    internal class ToDoItem
    {
        public string todoText { get; set; }
        public bool completed { get; set; }

        public ToDoItem(string todoText, bool completed)
        {
            this.todoText = todoText;
            this.completed = completed;
        }
    }
}

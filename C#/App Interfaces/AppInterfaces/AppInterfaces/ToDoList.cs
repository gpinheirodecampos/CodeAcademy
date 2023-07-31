using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppInterfaces 
{
    class ToDoList : IDisplayable, IResetable
    {
        // PROPRIEDADES

        public string[] Todos
        { get; private set; }

        // CAMPOS

        private int nextOpenIndex;

        // CONSTRUTORES

        public ToDoList() 
        {
            Todos = new string[5];
            nextOpenIndex = 0;
        }

        // METODOS

        public void Add(string todo)
        {
            Todos[nextOpenIndex] = todo;
            nextOpenIndex++;
        }

        public void Display()
        {
            foreach (string todo in Todos)
            {
                Console.WriteLine($"{todo}");
            }
        }

        public void Reset()
        {
            Todos = new string[5];
            nextOpenIndex = 0;
        }
    }
}

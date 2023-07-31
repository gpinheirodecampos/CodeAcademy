using System;

namespace AppInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciando classe TodoList
            ToDoList tdl = new ToDoList();

            // Adicionando tarefas a lista
            tdl.Add("Invite friends");
            tdl.Add("Buy decorations");
            tdl.Add("Party");

            // Instanciando classe de Gerenciamento de Senha
            PasswordManager pm = new PasswordManager("iluvpie", true);

            // Saida
            tdl.Display();
            pm.Display();

            // Resetando classes
            tdl.Reset();
            pm.Reset();
        }
    }
}


using ToDoList_Homework.Data;

namespace ToDoList_Homework.Commands
{
    internal class MarkAsCompletedCommand : ICommand
    {
        private readonly IToDoList _toDoList;

        public string Description => "Отметить выполненную задачу";

        public MarkAsCompletedCommand(IToDoList toDoList)
        {
            _toDoList = toDoList;
        }

        public void Execute()
        {
            do
            {
                Console.WriteLine("Отметить выполненную задачу");
                var task = Convert.ToInt32(Console.ReadLine());

                if (task != null)
                {
                    try

                    {
                        _toDoList.MarkAsCompleted(task);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Ошибка");
                        Console.WriteLine(ex.Message);
                        break;
                    }
                }
            } while (true);
        }
    }
}


using ToDoList_Homework.Data;

namespace ToDoList_Homework.Commands;

internal class DeleteCommand : ICommand
{
        private readonly IToDoList _toDoList;

        public string Description => "Удалить задачу";

        public DeleteCommand(IToDoList toDoList)
        {
            _toDoList = toDoList;
        }

    public void Execute()
    {
        do
        {
            Console.WriteLine("Удалить задачу (введите ее номер)");
            var task = Convert.ToInt32(Console.ReadLine());

            if (task != null)
            {
                try

                {
                    _toDoList.Delete(task);
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


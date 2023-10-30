namespace ToDoList_Homework.Data;

public interface IToDoList
{
    void Add(string task);

    void Delete(int id);

    void MarkAsCompleted(int id);

    string[] ToDoItems();

    string[] DoneItems();
}

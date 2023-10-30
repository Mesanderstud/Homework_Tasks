namespace ToDoList_Homework.Commands;

internal interface ICommand
{
    public string Description { get; }
    public void Execute();
}

namespace StrangeWorld.Patrons.Commands
{
    //* Interface used on command type executions
    public interface ICommand
    {
        //Execute command content
        public void Execute();
    }
}
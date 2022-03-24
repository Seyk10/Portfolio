namespace StrangeWorld.Patrons.Commands
{
    //* Interface used for commands executions with parameters
    //* T = Parameter type
    public interface ICommandParameter<T>
    {
        //Execute command content
        public void Execute(T parameter);
    }
}
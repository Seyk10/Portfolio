namespace StrangeWorld.Patrons.Commands
{
    //* Interface used to create command with a return value
    //* T = return type
    public interface ICommandReturn<T>
    {
        //Execute command content and return result
        public T Execute();   
    }
}
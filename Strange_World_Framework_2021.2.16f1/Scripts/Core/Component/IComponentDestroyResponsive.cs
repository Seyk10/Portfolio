namespace StrangeWorld.Core
{
    //* Interface used on entities responsive to component destroy state
    public interface IComponentDestroyResponsive<T> where T : AData
    {
        //Used to respond on component destroy event
        void OnComponentDestroyResponse(AComponent<T> component);
    }
}
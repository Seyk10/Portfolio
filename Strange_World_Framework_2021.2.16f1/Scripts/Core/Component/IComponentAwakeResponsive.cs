namespace StrangeWorld.Core
{
    //* Interface used on entities responsive to component awake state
    public interface IComponentAwakeResponsive<T> where T : AData
    {
        //Used to respond on component awake event
        void OnComponentAwakeResponse(AComponent<T> component);
    }
}
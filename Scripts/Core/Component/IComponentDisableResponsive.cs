namespace StrangeWorld.Core
{
    //* Interface used on entities responsive to component disable state
    public interface IComponentDisableResponsive<T> where T : AData
    { 
        //Used to respond on component disable event
        void OnComponentDisableResponse(AComponent<T> component);
    }
}
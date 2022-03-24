namespace StrangeWorld.Core
{
    //* Interface used on entities responsive to component enable state
    public interface IComponentEnableResponsive<T> where T : AData
    {
        //Used to respond on component enable event
        void OnComponentEnableResponse(AComponent<T> component);
    }
}
namespace StrangeWorld.Patrons.Observer
{
    //* Interface used to set a event observer and notify subjects
    public interface IObserver
    {
        //Add new subject
        public void AddSubject(ISubject subject);

        //Remove subject
        public void RemoveSubject(ISubject subject);

        //Notify subjects
        public void RaiseSubjects();
    }
}

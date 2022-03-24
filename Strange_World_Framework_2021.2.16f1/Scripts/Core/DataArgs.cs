using System;

namespace StrangeWorld.Core
{
    //* Class used as args for data structures
    //* T = AEventData
    public class DataArgs<T> : EventArgs where T : AData
    {
       //Data from component event
       public readonly T[] data;

       //Default constructor, store component data
       public DataArgs(T[] data) => this.data = data;
    }
}
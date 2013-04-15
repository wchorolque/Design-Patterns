/*
 * Created by SharpDevelop.
 * User: wintendo
 * Date: 15/04/2013
 * Time: 2:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace DesignPatterns.Memento
{
    /// <summary>
    /// Description of OurObject.
    /// </summary>
    public class OurObject
    {
        int     internalState = 0;
        string  anotherState = "I know nothing";
        
        public OurObjectMemento CreateMemento()
        {
            return new OurObjectMemento(internalState, anotherState);
        }
        
        public void RestoreMemento(OurObjectMemento memento)
        {
            this.internalState = memento.InternalState;
            this.anotherState = memento.AnotherState;
        }
        
        public void DoStuff()
        {
            internalState = 42;
            anotherState = "I know the question too";
        }
        
        public void PrintState()
        {
            System.Console.WriteLine("Current state is {0}:{1}",
                                     internalState, 
                                     anotherState);
        }
    }
}

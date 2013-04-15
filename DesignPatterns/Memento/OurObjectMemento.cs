/*
 * Created by SharpDevelop.
 * User: wintendo
 * Date: 15/04/2013
 * Time: 2:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace DesignPatterns.Memento
{
    /// <summary>
    /// Description of OurObjectMemento.
    /// </summary>
    public class OurObjectMemento
    {
        int     internalState;
        string  anotherState;
        
        public int InternalState {
            get {
                return internalState;
            }
        }
        
        public string AnotherState {
            get {
                return AnotherState;
            }
        }
        
        public OurObjectMemento(int internalState, string anotherState)
        {
            this.internalState = internalState;
            this.anotherState = anotherState;
        }
    }
}

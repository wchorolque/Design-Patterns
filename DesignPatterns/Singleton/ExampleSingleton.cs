/*
 * Created by SharpDevelop.
 * User: wintendo
 * Date: 15/04/2013
 * Time: 0:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace DesignPatterns
{
    /// <summary>
    /// Description of ExampleSingleton.
    /// </summary>
    public class ExampleSingleton
    {
        public void PrintHello()
        {
            System.Console.WriteLine("Hello World!");
        }
        
        ExampleSingleton()
        {
        }
        
        static ExampleSingleton exampleSingleton = new ExampleSingleton();
        
        public static ExampleSingleton Singleton {
            get {
                return exampleSingleton;
            }
        }
    }
}

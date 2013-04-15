/*
 * Created by SharpDevelop.
 * User: wintendo
 * Date: 15/04/2013
 * Time: 2:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace DesignPatterns.Strategy
{
    /// <summary>
    /// Description of HelloPrinter.
    /// </summary>
    public class HelloPrinter
    {
        IHelloStrategy helloStrategy;
        
        public IHelloStrategy HelloStrategy {
            get {
                return helloStrategy;
            }
            set {
                helloStrategy = value;
            }
        }
        
        public void PrintHello()
        {
            if (helloStrategy != null) {
                Console.WriteLine(helloStrategy.GenerateHelloString());
            }
        }
    }
}

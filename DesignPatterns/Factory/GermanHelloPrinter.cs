/*
 * Created by SharpDevelop.
 * User: wintendo
 * Date: 15/04/2013
 * Time: 0:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace DesignPatterns.Factory
{
    /// <summary>
    /// Description of GermanHelloPrinter.
    /// </summary>
    public class GermanHelloPrinter : IHelloPrinter
    {
        public void PrintHello()
        {
            System.Console.WriteLine("Hello Welt!");
        }
    }
}

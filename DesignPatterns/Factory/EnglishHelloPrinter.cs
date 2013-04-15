/*
 * Created by SharpDevelop.
 * User: wintendo
 * Date: 15/04/2013
 * Time: 0:49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace DesignPatterns.Factory
{
    /// <summary>
    /// Description of EnglishHelloPrinter.
    /// </summary>
    public class EnglishHelloPrinter : IHelloPrinter
    {
        public void PrintHello()
        {
            System.Console.WriteLine("Hello World!");
        }
    }
}

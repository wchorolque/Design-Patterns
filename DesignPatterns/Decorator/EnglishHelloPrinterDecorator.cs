/*
 * Created by SharpDevelop.
 * User: wintendo
 * Date: 15/04/2013
 * Time: 1:07
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using DesignPatterns.Factory;

namespace DesignPatterns.Decorator
{
    /// <summary>
    /// Description of EnglishHelloPrinterDecorator.
    /// </summary>
    public class EnglishHelloPrinterDecorator : AbstractHelloPrinterDecorator
    {
        public EnglishHelloPrinterDecorator(IHelloPrinter helloPrinter)
            : base(helloPrinter)
        {
        }
        
        public override void PrintGoodbye()
        {
            System.Console.WriteLine("Good bye!");
        }
    }
}

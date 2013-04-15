/*
 * Created by SharpDevelop.
 * User: wintendo
 * Date: 15/04/2013
 * Time: 1:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using DesignPatterns.Factory;

namespace DesignPatterns.Decorator
{
    /// <summary>
    /// Description of AbstractHelloPrinterDecorator.
    /// </summary>
    public abstract class AbstractHelloPrinterDecorator : IHelloPrinterDecorator
    {
        IHelloPrinter helloPrinter;
        
        public AbstractHelloPrinterDecorator(IHelloPrinter helloPrinter)
        {
            this.helloPrinter = helloPrinter;
        }
        
        public void PrintHello()
        {
            helloPrinter.PrintHello();
        }
        
        public abstract void PrintGoodbye();
    }
}

/*
 * Created by SharpDevelop.
 * User: wintendo
 * Date: 15/04/2013
 * Time: 1:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using DesignPatterns.Factory;

namespace DesignPatterns.Decorator
{
    /// <summary>
    /// Description of IHelloPrinterDecorator.
    /// </summary>
    public interface IHelloPrinterDecorator : IHelloPrinter
    {
        void PrintGoodbye();
    }
}

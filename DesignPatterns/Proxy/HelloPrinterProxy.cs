/*
 * Created by SharpDevelop.
 * User: wintendo
 * Date: 15/04/2013
 * Time: 2:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using DesignPatterns.Factory;

namespace DesignPatterns.Proxy
{
    /// <summary>
    /// Description of HelloPrinterProxy.
    /// </summary>
    public class HelloPrinterProxy : IHelloPrinter
    {
        string language;
        IHelloPrinter printer = null;
        
        public HelloPrinterProxy(string language)
        {
            this.language = language;
        }
        
        public void PrintHello()
        {
            if (null == printer) {
                printer = new HelloFactory().CreateHelloPrinter(language);
                if (null == printer) {
                    throw new System.NotSupportedException(language);
                }
            }
            
            printer.PrintHello();
        }
    }
}

/*
 * Created by SharpDevelop.
 * User: wintendo
 * Date: 15/04/2013
 * Time: 0:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace DesignPatterns.Factory
{
    /// <summary>
    /// Description of HelloFactory.
    /// </summary>
    public class HelloFactory
    {
        public IHelloPrinter CreateHelloPrinter(string language)
        {
            switch (language) {
                case "de":
                    return new GermanHelloPrinter();
                case "en":
                    return new EnglishHelloPrinter();
            }
            return null;
        }
    }
}

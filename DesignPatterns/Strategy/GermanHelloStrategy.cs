/*
 * Created by SharpDevelop.
 * User: wintendo
 * Date: 15/04/2013
 * Time: 2:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace DesignPatterns.Strategy
{
    /// <summary>
    /// Description of GermanHelloStrategy.
    /// </summary>
    public class GermanHelloStrategy : IHelloStrategy
    {
        public String GenerateHelloString()
        {
            return "Hallo Welt!";
        }
    }
}

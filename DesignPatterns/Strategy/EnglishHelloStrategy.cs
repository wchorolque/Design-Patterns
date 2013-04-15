/*
 * Created by SharpDevelop.
 * User: wintendo
 * Date: 15/04/2013
 * Time: 2:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace DesignPatterns.Strategy
{
    /// <summary>
    /// Description of EnglishHelloStrategy.
    /// </summary>
    public class EnglishHelloStrategy : IHelloStrategy
    {
        public string GenerateHelloString()
        {
            return "Hello World!";
        }
    }
}

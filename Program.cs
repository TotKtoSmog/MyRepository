using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Parser
{
	public class Program
	{
		public static void Main(string[] args)
		{
			XMLHandler.WriteXML(new User(1000,"Test"));
			ShowHello();
		}
		public static void ShowHello() => Console.WriteLine("Hello");
	}
}
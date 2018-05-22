/*
 * Created by SharpDevelop.
 * User: Ventvo
 * Date: 05/19/2018
 * Time: 03:47 PM
 */
using System;
using System.Threading;
using System.Collections.Generic;

namespace Snake
{
	class Snake
	{	
		public static void Main(string[] args)
		{	
			Console.Title = "Snake!";
			Console.CursorVisible=false;
			Console.BackgroundColor = ConsoleColor.DarkBlue;
			Console.Clear();
			Int16 winWidth = 50, winHigth = 20;
			Console.SetWindowSize(winWidth,winHigth);
			Console.SetBufferSize(winWidth,winHigth);
			Game gm = new Game();
			gm.Start();
		}
	}
}
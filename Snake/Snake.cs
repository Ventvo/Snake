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
			char body = '█';
			char border = '█';
			char point = '*';
			char space = ' ';
			Int16 delay = 200;
			Int16 shortdelay = 60;
			Console.Title = "Snake!";
			Console.CursorVisible=false;
			Console.BackgroundColor = ConsoleColor.DarkBlue;
			Console.Clear();
			Sounds snd = new Sounds();
			snd.GameSound();
			Int16 winWidth = 100, winHigth = 40;
			Console.SetWindowSize(winWidth,winHigth);
			Console.SetBufferSize(winWidth,winHigth);
			Game gm = new Game(border,body,point,space,delay,shortdelay);
			gm.Start();
		}
	}
}
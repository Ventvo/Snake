/*
 * Created by SharpDevelop.
 * User: Ventvo
 * Date: 05/19/2018
 * Time: 03:47 PM
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace Snake
{
	class Snake
	{
		[DllImport("kernel32.dll", ExactSpelling = true)]
		private static extern IntPtr GetConsoleWindow();
		private static IntPtr ThisConsole = GetConsoleWindow();
		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
		private const int HIDE = 0;
		private const int MAXIMIZE = 3;
		private const int MINIMIZE = 6;
		private const int RESTORE = 9;

		public static void Main(string[] args)
		{	
			char body = '█';
			char border = '█';
			char point = '*';
			char space = ' ';
			Int16 delay = 200;
			Int16 shortdelay = 60;
			Console.Title = "Snake!";
			Console.CursorVisible = false;
			Console.BackgroundColor = ConsoleColor.DarkBlue;
			Console.Clear();
			Sounds snd = new Sounds();
			snd.Play("Snake");
			Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
			Console.SetBufferSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
			ShowWindow(ThisConsole, MAXIMIZE);
			Render rndr = new Render();
			Console.CursorVisible = false;
			rndr.Menu();
			Console.Clear();
			Game gm = new Game(border, body, point, space, delay, shortdelay);
			gm.Start();
		}
	}
}
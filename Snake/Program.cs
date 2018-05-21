/*
 * Created by SharpDevelop.
 * User: Ventvo
 * Date: 05/19/2018
 * Time: 03:47 PM
 */
 //todo nahoru a dolu vic cekani nez doboku..
using System;
using System.Threading;
using System.Collections.Generic;

namespace Snake
{
	class Program
	{	
		public static void Main(string[] args)
		{	
			List<int> logx = new List<int>();
			List<int> logy = new List<int>();
			Console.Title = "Snake!";
			Console.CursorVisible=false;
			Console.BackgroundColor = ConsoleColor.DarkBlue;
			Console.Clear();
			Int16 winWidth = 100, winHigth = 40;
			char body = '█';
			int[,] log = new int[winWidth*winHigth,2];
			int lenght = 0;
			Console.SetWindowSize(winWidth,winHigth);
			Console.SetBufferSize(winWidth,winHigth);
			ConsoleKeyInfo pressed;
			Console.SetCursorPosition(winWidth/2,winHigth/2);
			Console.Write(body);
			logx.Add(winWidth/2);
			logy.Add(winHigth/2);
			pressed = Console.ReadKey();
			do{
				if(Console.KeyAvailable==true){
				pressed = Console.ReadKey(false);
				}
				Console.SetCursorPosition(logx[lenght],logy[lenght]);
				Console.Write(' ');
				if(pressed.Key == ConsoleKey.RightArrow){
					Console.SetCursorPosition(logx[lenght]+1,logy[lenght]);
					logx[lenght]=logx[lenght]+1;
				}else if(pressed.Key == ConsoleKey.LeftArrow){
					Console.SetCursorPosition(logx[lenght]-1,logy[lenght]);
					logx[lenght]=logx[lenght]-1;
				}else if(pressed.Key == ConsoleKey.UpArrow){
					Console.SetCursorPosition(logx[lenght],logy[lenght]-1);
					logy[lenght]=logy[lenght]-1;
				} else if(pressed.Key == ConsoleKey.DownArrow){
					Console.SetCursorPosition(logx[lenght],logy[lenght]+1);
					logy[lenght]=logy[lenght]+1;
				}Console.Write(body);
					Thread.Sleep(100);
			}while(pressed.Key!=ConsoleKey.Escape);
		}
	}
}
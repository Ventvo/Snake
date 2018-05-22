/*
 * Created by SharpDevelop.
 * User: Ventr
 * Date: 05/22/2018
 * Time: 08:08 AM
 */
using System;
using System.Threading;
using System.Collections.Generic;

namespace Snake
{
	public class Game
	{
		List<int> logx = new List<int>();
		List<int> logy = new List<int>();
		char body = '█';
		int lenght = 0;
		ConsoleKeyInfo pressed;
		
		public void Start()
		{
			List<int> logx = new List<int>();
			List<int> logy = new List<int>();
			char body = '█';
			int lenght = 0;
			ConsoleKeyInfo pressed;
			Console.SetCursorPosition(Console.BufferWidth/2,Console.BufferHeight/2);
			Console.Write(body);
			logx.Add(Console.BufferWidth/2);
			logy.Add(Console.BufferHeight/2);
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

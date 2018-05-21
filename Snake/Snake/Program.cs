/*
 * Created by SharpDevelop.
 * User: Ventvo
 * Date: 05/19/2018
 * Time: 03:47 PM
 */
 
using System;
using System.Threading;

namespace Snake
{
	class Program
	{
		public static void Main(string[] args)
		{	
			Console.Title = "Snake!";
			Console.CursorVisible=false;
			Console.BackgroundColor = ConsoleColor.DarkBlue;
			Console.Clear();
			Int16 winWidth = 100, winHigth = 40;
			char body = '█';
			int[,] log = new int[winWidth*winHigth,2];
			int lenght = 0;
			Console.SetWindowSize(winWidth,winHigth);
			for(int i=0;i<1;i++)
				for(int j=0; j<winWidth*winHigth;j++)
					log[j,i]=0;
			
			ConsoleKeyInfo pressed;
			pressed = Console.ReadKey();
			do{
				if(Console.KeyAvailable==true){
				pressed = Console.ReadKey();
				}
				Console.SetCursorPosition(log[lenght,0],log[lenght,1]);
				Console.Write(' ');
				if(pressed.Key == ConsoleKey.RightArrow){
					Console.SetCursorPosition(log[lenght,0]+1,log[lenght,1]);
					log[lenght,0]=log[lenght,0]+1;
				}else if(pressed.Key == ConsoleKey.LeftArrow){
					Console.SetCursorPosition(log[lenght,0]-1,log[lenght,1]);
					log[lenght,0]=log[lenght,0]-1;
				}else if(pressed.Key == ConsoleKey.UpArrow){
					Console.SetCursorPosition(log[lenght,0],log[lenght,1]-1);
					log[lenght,1]=log[lenght,1]-1;
				} else if(pressed.Key == ConsoleKey.DownArrow){
					Console.SetCursorPosition(log[lenght,0],log[lenght,1]+1);
					log[lenght,1]=log[lenght,1]+1;
				}Console.Write(body);
				if((pressed.Modifiers & ConsoleModifiers.Shift) != 0)
				Thread.Sleep(20);
				else Thread.Sleep(200);
			}while(pressed.Key!=ConsoleKey.Escape);
			
			Console.Read();
		}
	}
}
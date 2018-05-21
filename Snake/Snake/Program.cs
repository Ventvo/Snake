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
		List<int> logx;
		List<int> logy;
		public static void Main(string[] args)
		{	
			Console.Title = "Snake!";
			Console.CursorVisible=false;
			Console.BackgroundColor = ConsoleColor.DarkBlue;
			Console.Clear();
			Int16 winWidth = 100, winHigth = 40;
			char body = '█';
			List<int> logx = new List<int>();
			List<int> logy = new List<int>();
			logx.add(winWidth/2);
			logy.add(winHigth/2);
			
			int lenght = 0;
			Console.SetWindowSize(winWidth,winHigth);
			Console.SetBufferSize(winWidth,winHigth); 
			//point
			Random rnd = new Random();
			int[] point = new int[2];
			point[0]=rnd.Next(0,winWidth);
			point[1]=rnd.Next(0,winHigth);
			Console.SetCursorPosition(point[0],point[1]);
			Console.Write('*');
			ConsoleKeyInfo pressed=Console.ReadKey();
			do{
				//point collected	
				if(Console.CursorLeft-1==point[0]&&Console.CursorTop==point[1]){
					Console.Write(' ');
					point[0]=rnd.Next(1,winWidth);
					point[1]=rnd.Next(1,winHigth);
					Console.SetCursorPosition(point[0],point[1]);
					Console.Write('*');
					lenght++;
					Console.SetCursorPosition(0,0);
					Console.Write(lenght);
				}
				
				//move
				if(Console.KeyAvailable==true){
					pressed = Console.ReadKey();}
				Thread.Sleep(100);
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
			}while(pressed.Key!=ConsoleKey.Escape);
		}
	}
}
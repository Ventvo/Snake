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
	{	//declaratio
		List<Int16> logx = new List<Int16>();
		List<Int16> logy = new List<Int16>();
		char body,point,space,border;
		Int16 length = 0,delay;
		ConsoleKeyInfo pressed,pressed1;
		Boolean test=false,over=false,colision;
		Int16 px,py;
		
		public Game(char border,char body,char point,char space, bool colision, Int16 delay){
			this.body=body;
			this.point=point;
			this.space=space;
			this.colision=colision;
			this.delay=delay;
			this.border=border;
		}
		
		//main game loop
		public void Start(){
			Random rnd = new Random();
			Console.SetCursorPosition(0,0);
			Console.Write("Points: "+length);
			px = (Int16)rnd.Next(2,Console.BufferWidth-1);
			py = (Int16)rnd.Next(1,Console.BufferHeight-1);
			Console.SetCursorPosition(px,py);
			Console.Write(point);
			Console.SetCursorPosition(Console.BufferWidth/2,Console.BufferHeight/2);
			Console.Write(body);
			logx.Add(Convert.ToInt16(Console.BufferWidth/2));
			logy.Add(Convert.ToInt16(Console.BufferHeight/2));
			Console.SetCursorPosition(Console.BufferWidth-1,Console.BufferHeight-1);
			Console.Write(border);
			for(int i=0;i<Console.BufferWidth;i++){
				Console.SetCursorPosition(i,1);
				Console.Write(border);
			}
			for(int i=2;i<Console.BufferHeight-1;i++){
				Console.SetCursorPosition(Console.BufferWidth-1,i);
				Console.Write(border);
			}
			pressed = Console.ReadKey(false);
			do{
				move();
				
				Thread.Sleep(delay);
			}while(!(pressed.Key==ConsoleKey.Escape||over));
		}
		
		//detect point collect
		private bool Pointget(){
			Random rnd = new Random();
			if(px==logx[length]&&py==logy[length]){
				do{
					px = (Int16)rnd.Next(2,Console.BufferWidth-2);
					py = (Int16)rnd.Next(2,Console.BufferHeight-2);
					for(int i=0;i<length;i++){
						if(px==logx[i]||py==logy[i]) test=true;
						else test=false;
					}
				}while(test);
				
				Console.SetCursorPosition(px,py);
				Console.Write(point);
				length++;
				Console.SetCursorPosition(0,0);
				Console.Write("                                                                   ");
				Console.SetCursorPosition(0,0);
				Console.Write("Points: "+length);
				Console.SetCursorPosition(logx[0],logy[0]);
				return false;
			}else return true;
		}
		
		//moving snake
		private void move(){
				if(Console.KeyAvailable){
					pressed1 = Console.ReadKey(false);
					if(pressed1.Key == ConsoleKey.RightArrow||pressed1.Key == ConsoleKey.LeftArrow||pressed1.Key == ConsoleKey.UpArrow||pressed1.Key == ConsoleKey.DownArrow||pressed1.Key==ConsoleKey.Escape||((pressed1.Key == ConsoleKey.RightArrow&&pressed.Key == ConsoleKey.LeftArrow)||(pressed1.Key == ConsoleKey.UpArrow&&pressed.Key == ConsoleKey.DownArrow)||((pressed.Key == ConsoleKey.RightArrow&&pressed1.Key == ConsoleKey.LeftArrow)||(pressed.Key == ConsoleKey.UpArrow&&pressed1.Key == ConsoleKey.DownArrow)))){
						pressed=pressed1;
					}else{
						Console.Clear();
						Console.SetCursorPosition(px,py);
						Console.Write(point);
						Console.SetCursorPosition(0,0);
						Console.Write("Points: "+length);
					}
				}
				Console.SetCursorPosition(logx[0],logy[0]);
				Console.Write(space);
				if(pressed.Key == ConsoleKey.RightArrow){
					Console.SetCursorPosition(logx[length]+1,logy[length]);
					if(logx.Contains(Convert.ToInt16(logx[length]+1))&&logy.Contains(logy[length])&&length>0&&colision)
						over=true;
					logx.Add(Convert.ToInt16(logx[length]+1));
					logy.Add(Convert.ToInt16(logy[length]));
					if(Pointget()){
					logx.RemoveAt(0);
					logy.RemoveAt(0);
					}
				}else if(pressed.Key == ConsoleKey.LeftArrow){
					Console.SetCursorPosition(logx[length]-1,logy[length]);
					if(logx.Contains(Convert.ToInt16(logx[length]-1))&&logy.Contains(logy[length])&&length>0&&colision)
						over=true;
					logx.Add(Convert.ToInt16(logx[length]-1));
					logy.Add(Convert.ToInt16(logy[length]));
					if(Pointget()){
					logx.RemoveAt(0);
					logy.RemoveAt(0);
					}
				}else if(pressed.Key == ConsoleKey.UpArrow){
					Console.SetCursorPosition(logx[length],logy[length]-1);
					if(logx.Contains(logx[length])&&logy.Contains(Convert.ToInt16(logy[length]-1))&&length>0&&colision)
						over=true;
					logx.Add(Convert.ToInt16(logx[length]));
					logy.Add(Convert.ToInt16(logy[length]-1));
					if(Pointget()){
					logx.RemoveAt(0);
					logy.RemoveAt(0);
					}
				} else if(pressed.Key == ConsoleKey.DownArrow){
					Console.SetCursorPosition(logx[length],logy[length]+1);
					if(logx.Contains(logx[length])&&logy.Contains(Convert.ToInt16(logy[length]+1))&&length>0&&colision)
						over=true;
   					logx.Add(Convert.ToInt16(logx[length]));
					logy.Add(Convert.ToInt16(logy[length]+1));
					if(Pointget()){
					logx.RemoveAt(0);
					logy.RemoveAt(0);
					}
				}Console.Write(body);
		}
	}
}

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
	{	//declaration
		List<Int16> logx = new List<Int16>();
		List<Int16> logy = new List<Int16>();
		char body,point,space,border;
		Int16 length = 0,delay,shortdelay,timer;
		ConsoleKeyInfo pressed,pressed1;
		Boolean over=false;
		Int16 px,py;
		Int16 pointc=1;
		
		public Game(char border,char body,char point,char space, Int16 delay, Int16 shortdelay){
			this.body=body;
			this.point=point;
			this.space=space;
			this.delay=delay;
			this.shortdelay=shortdelay;
			this.border=border;
			this.timer=delay;
		}
		
		//main game loop
		public void Start(){
			
			Render rend = new Render();
			rend.Game(border);
			Console.SetCursorPosition(0,0);
			Console.Write("Points: "+length);
			genpoint();
			Console.SetCursorPosition(Console.BufferWidth/2,Console.BufferHeight/2);
			Console.ForegroundColor=ConsoleColor.DarkMagenta;
			Console.Write(body);
			logx.Add(Convert.ToInt16(Console.BufferWidth/2));
			logy.Add(Convert.ToInt16(Console.BufferHeight/2));
			pressed = Console.ReadKey(false);
			do{
				move();
				Console.CursorVisible=false;
				Thread.Sleep(timer);
			}while(!(pressed.Key==ConsoleKey.Escape||over));
		}
		
		//detect point collect
		bool Pointget(){
			if(px==logx[length]&&py==logy[length]){
				genpoint();
				length++;
				Console.SetCursorPosition(0,0);
				Console.Write("                                                                   ");
				Console.SetCursorPosition(0,0);
				Console.Write("Points: "+length);
				Console.SetCursorPosition(logx[0],logy[0]);
				return false;
			}else return true;
		}
		
		//generate point on screen
		void genpoint(){
			Random rnd = new Random();
			switch (pointc){
							case 1:{
								Console.ForegroundColor=ConsoleColor.Blue;
								pointc++;
								break;
								}
							case 2:{
								Console.ForegroundColor=ConsoleColor.Cyan;
								pointc++;
								break;
								}
							case 3:{
								Console.ForegroundColor=ConsoleColor.Black;
								pointc++;
								break;
								}
							case 4:{
								Console.ForegroundColor=ConsoleColor.DarkCyan;
								pointc++;
								break;
								}
							case 5:{
								Console.ForegroundColor=ConsoleColor.DarkGray;
								pointc++;
								break;
								}
							case 6:{
								Console.ForegroundColor=ConsoleColor.DarkGreen;
								pointc++;
								break;
								}
							case 7:{
								Console.ForegroundColor=ConsoleColor.DarkMagenta;
								pointc++;
								break;
								}
							case 8:{
								Console.ForegroundColor=ConsoleColor.DarkRed;
								pointc++;
								break;
								}
							case 9:{
								Console.ForegroundColor=ConsoleColor.DarkYellow;
								pointc++;
								break;
								}
							case 10:{
								Console.ForegroundColor=ConsoleColor.Gray;
								pointc++;
								break;
								}
							case 11:{
								Console.ForegroundColor=ConsoleColor.Green;
								pointc++;
								break;
								}
							case 12:{
								Console.ForegroundColor=ConsoleColor.Magenta;
								pointc++;
								break;
								}
							case 13:{
								Console.ForegroundColor=ConsoleColor.Red;
								pointc++;
								break;
								}
							case 14:{
								Console.ForegroundColor=ConsoleColor.White;
								pointc++;
								break;
								}
							default:{
								Console.ForegroundColor=ConsoleColor.Yellow;
								pointc=1;
								break;
								}
						}
			do{
				px = (Int16)rnd.Next(2,Console.BufferWidth-2);
				py = (Int16)rnd.Next(2,Console.BufferHeight-2);
			}while(logx.Contains(px)&&logy.Contains(py));
			Console.SetCursorPosition(px,py);
			Console.Write(point);
		}
		
		//moving snake
		void move(){
				if(Console.KeyAvailable){	
					pressed1 = Console.ReadKey(false);
					if(pressed==pressed1)timer=shortdelay;
					else timer=delay;
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
				switch(pressed.Key){
					
					case ConsoleKey.RightArrow:{
						Console.SetCursorPosition(logx[length]+1,logy[length]);
						over = colision(logx[length]+1,logy[length]);
						logx.Add(Convert.ToInt16(logx[length]+1));
						logy.Add(Convert.ToInt16(logy[length]));
						Console.ForegroundColor=ConsoleColor.DarkMagenta;
						Console.Write(body);
						Console.SetCursorPosition(logx[0],logy[0]);
						Console.Write(space);
						if(Pointget()){
							logx.RemoveAt(0);
							logy.RemoveAt(0);
						}
						break;
					}
					
					case ConsoleKey.LeftArrow:{
						Console.SetCursorPosition(logx[length]-1,logy[length]);
						over = colision(logx[length]-1,logy[length]);
						logx.Add(Convert.ToInt16(logx[length]-1));
						logy.Add(Convert.ToInt16(logy[length]));
						Console.ForegroundColor=ConsoleColor.DarkMagenta;
						Console.Write(body);
						Console.SetCursorPosition(logx[0],logy[0]);
						Console.Write(space);
						if(Pointget()){
							logx.RemoveAt(0);
							logy.RemoveAt(0);
						}
						break;
					}
					
					case ConsoleKey.UpArrow:{
						Console.SetCursorPosition(logx[length],logy[length]-1);
						over = colision(logx[length],logy[length]-1);
						logx.Add(Convert.ToInt16(logx[length]));
						logy.Add(Convert.ToInt16(logy[length]-1));
						Console.ForegroundColor=ConsoleColor.DarkMagenta;
						Console.Write(body);
						Console.SetCursorPosition(logx[0],logy[0]);
						Console.Write(space);
						if(Pointget()){
							logx.RemoveAt(0);
							logy.RemoveAt(0);
						}
						break;
					}
					
					case ConsoleKey.DownArrow:{
						Console.SetCursorPosition(logx[length],logy[length]+1);
   						over = colision(logx[length],logy[length]+1);
						logx.Add(Convert.ToInt16(logx[length]));
						logy.Add(Convert.ToInt16(logy[length]+1));
						Console.ForegroundColor=ConsoleColor.DarkMagenta;
						Console.Write(body);
						Console.SetCursorPosition(logx[0],logy[0]);
						Console.Write(space);
						if(Pointget()){
							logx.RemoveAt(0);
							logy.RemoveAt(0);
						}
						break;
					}
				}
		}
		
		//colision detection
		bool colision(Int16 x, Int16 y){
			if(y<2||y>Console.BufferHeight-2||x<1||x>Console.BufferWidth-2)
				return true;
			if(logx.Contains(x)&&logy.Contains(y))
				for(int i=0;i<length;i++)
					if(logx[i]==x&&logy[i]==y)
						return true;
			return false;
		}
		bool colision(Int32 x, Int16 y){
			if(y<2||y>Console.BufferHeight-2||x<1||x>Console.BufferWidth-2)
				return true;
			if(logx.Contains(Convert.ToInt16(x))&&logy.Contains(y))
				for(int i=0;i<length;i++)
					if((logx[i]==x&&logy[i]==y)||y<2||y>Console.BufferHeight-2||x<1||x>Console.BufferWidth-2)
						return true;
			return false;
		}
		bool colision(Int16 x, Int32 y){
			if(y<2||y>Console.BufferHeight-2||x<1||x>Console.BufferWidth-2)
				return true;
			if(logx.Contains(x)&&logy.Contains(Convert.ToInt16(y)))
				for(int i=0;i<length;i++)
					if((logx[i]==x&&logy[i]==y)||y<2||y>Console.BufferHeight-2||x<1||x>Console.BufferWidth-2)
						return true;
			return false;
		}
	}
}

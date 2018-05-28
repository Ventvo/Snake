/*
 * Created by SharpDevelop.
 * User: Ventr
 * Date: 05/25/2018
 * Time: 09:17 AM
 */
using System;

namespace Snake
{
	/// <summary>
	/// Description of Render.
	/// </summary>
	public class Render
	{
		public Render()
		{
		}
		
		public void Menu(){
			Console.Clear();
			Console.SetCursorPosition(0,0);
		}
		
		public void Game(char border){
			for(int i=0; i<Console.BufferWidth-1;i++){
				Console.SetCursorPosition(i,1);
				Console.Write(border);
				Console.SetCursorPosition(i,Console.BufferHeight-1);
				Console.Write(border);
			}
			for(int i=1;i<Console.BufferHeight-1;i++){
				Console.SetCursorPosition(0,i);
				Console.Write(border);
				Console.SetCursorPosition(Console.BufferWidth-1,i);
				Console.Write(border);
			}
		}
	}
}

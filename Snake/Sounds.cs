﻿/*
 * Created by SharpDevelop.
 * User: Ventr
 * Date: 05/24/2018
 * Time: 09:55 PM
 */
using System;
using System.Threading;

namespace Snake
{
	/// <summary>
	/// Description of Sounds.
	/// </summary>
	public class Sounds
	{
		public Sounds()
		{
				
		}
		
		public void GameSound()
        {
				Thread soundGame = new Thread(Tetris);
				soundGame.Start();
				soundGame.IsBackground=true;
        }
		
		void Mario(){
			do{
				Console.Beep(659, 125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(523, 125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(375); Console.Beep(392, 125); Thread.Sleep(375); Console.Beep(523, 125); Thread.Sleep(250); Console.Beep(392, 125); Thread.Sleep(250); Console.Beep(330, 125); Thread.Sleep(250); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(466, 125); Thread.Sleep(42); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(392, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(880, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(587, 125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(250); Console.Beep(392, 125); Thread.Sleep(250); Console.Beep(330, 125); Thread.Sleep(250); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(494, 125); Thread.Sleep(125); Console.Beep(466, 125); Thread.Sleep(42); Console.Beep(440, 125); Thread.Sleep(125); Console.Beep(392, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(880, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(784, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(587, 125); Console.Beep(494, 125); Thread.Sleep(375); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(698, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(698, 125); Thread.Sleep(625); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(622, 125); Thread.Sleep(250); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(523, 125); Thread.Sleep(1125); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(698, 125); Thread.Sleep(125); Console.Beep(698, 125); Console.Beep(698, 125); Thread.Sleep(625); Console.Beep(784, 125); Console.Beep(740, 125); Console.Beep(698, 125); Thread.Sleep(42); Console.Beep(622, 125); Thread.Sleep(125); Console.Beep(659, 125); Thread.Sleep(167); Console.Beep(415, 125); Console.Beep(440, 125); Console.Beep(523, 125); Thread.Sleep(125); Console.Beep(440, 125); Console.Beep(523, 125); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(622, 125); Thread.Sleep(250); Console.Beep(587, 125); Thread.Sleep(250); Console.Beep(523, 125);
			}while(true);
		}
		
		void Tetris(){
			do{		
				Console.Beep(658, 125);
				Console.Beep(1320, 500);
				Console.Beep(990, 250);
				Console.Beep(1056, 250);
				Console.Beep(1188, 250);
				Console.Beep(1320, 125);
				Console.Beep(1188, 125);
				Console.Beep(1056, 250);
				Console.Beep(990, 250);
				Console.Beep(880, 500);
				Console.Beep(880, 250);
				Console.Beep(1056, 250);
				Console.Beep(1320, 500);
				Console.Beep(1188, 250);
				Console.Beep(1056, 250);
				Console.Beep(990, 750);
				Console.Beep(1056, 250);
				Console.Beep(1188, 500);
				Console.Beep(1320, 500);
				Console.Beep(1056, 500);
				Console.Beep(880, 500);
				Console.Beep(880, 500);
				Thread.Sleep(250);
				Console.Beep(1188, 500);
				Console.Beep(1408, 250);
				Console.Beep(1760, 500);
				Console.Beep(1584, 250);
				Console.Beep(1408, 250);
				Console.Beep(1320, 750);
				Console.Beep(1056, 250);
				Console.Beep(1320, 500);
				Console.Beep(1188, 250);
				Console.Beep(1056, 250);
				Console.Beep(990, 500);
				Console.Beep(990, 250);
				Console.Beep(1056, 250);
				Console.Beep(1188, 500);
				Console.Beep(1320, 500);
				Console.Beep(1056, 500);
				Console.Beep(880, 500);
				Console.Beep(880, 500);
				Thread.Sleep(500);
				Console.Beep(1320, 500);
				Console.Beep(990, 250);
				Console.Beep(1056, 250);
				Console.Beep(1188, 250);
				Console.Beep(1320, 125);
				Console.Beep(1188, 125);
				Console.Beep(1056, 250);
				Console.Beep(990, 250);
				Console.Beep(880, 500);
				Console.Beep(880, 250);
				Console.Beep(1056, 250);
				Console.Beep(1320, 500);
				Console.Beep(1188, 250);
				Console.Beep(1056, 250);
				Console.Beep(990, 750);
				Console.Beep(1056, 250);
				Console.Beep(1188, 500);
				Console.Beep(1320, 500);
				Console.Beep(1056, 500);
				Console.Beep(880, 500);
				Console.Beep(880, 500);
				Thread.Sleep(250);
				Console.Beep(1188, 500);
				Console.Beep(1408, 250);
				Console.Beep(1760, 500);
				Console.Beep(1584, 250);
				Console.Beep(1408, 250);
				Console.Beep(1320, 750);
				Console.Beep(1056, 250);
				Console.Beep(1320, 500);
				Console.Beep(1188, 250);
				Console.Beep(1056, 250);
				Console.Beep(990, 500);
				Console.Beep(990, 250);
				Console.Beep(1056, 250);
				Console.Beep(1188, 500);
				Console.Beep(1320, 500);
				Console.Beep(1056, 500);
				Console.Beep(880, 500);
				Console.Beep(880, 500);
				Thread.Sleep(500);
				Console.Beep(660, 1000);
				Console.Beep(528, 1000);
				Console.Beep(594, 1000);
				Console.Beep(495, 1000);
				Console.Beep(528, 1000);
				Console.Beep(440, 1000);
				Console.Beep(419, 1000);
				Console.Beep(495, 1000);
				Console.Beep(660, 1000);
				Console.Beep(528, 1000);
				Console.Beep(594, 1000);
				Console.Beep(495, 1000);
				Console.Beep(528, 500);
				Console.Beep(660, 500);
				Console.Beep(880, 1000);
				Console.Beep(838, 2000);
				Console.Beep(660, 1000);
				Console.Beep(528, 1000);
				Console.Beep(594, 1000);
				Console.Beep(495, 1000);
				Console.Beep(528, 1000);
				Console.Beep(440, 1000);
				Console.Beep(419, 1000);
				Console.Beep(495, 1000);
				Console.Beep(660, 1000);
				Console.Beep(528, 1000);
				Console.Beep(594, 1000);
				Console.Beep(495, 1000);
				Console.Beep(528, 500);
				Console.Beep(660, 500);
				Console.Beep(880, 1000);
				Console.Beep(838, 2000);
			}while(true);
		}
	}
		
}


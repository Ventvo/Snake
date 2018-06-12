/*
 * Created by SharpDevelop.
 * User: Ventr
 * Date: 05/25/2018
 * Time: 09:14 AM
 */
using System;
using System.Threading;

namespace Snake
{
	/// <summary>
	/// Description of Menu.
	/// </summary>
	public class Menu
	{
		char border, body, point, space;
		Int16 delay, shortdelay;
		bool skalkamode;
		public Menu(char border, char body, char point, char space, Int16 delay, Int16 shortdelay, bool skalkamode)
		{
			this.border = border;
			this.body = body;
			this.point = point;
			this.space = space;
			this.delay = delay;
			this.shortdelay = shortdelay;
			this.skalkamode = skalkamode;
		}
		
		public bool Main()
		{
			Render rnd = new Render();
			int selected;
			Random random = new Random();
			Sounds snd = new Sounds();
			bool win;
			snd.Music(random.Next(1, 5));
			do {
				rnd.Menu(skalkamode);

			} while(!int.TryParse(Convert.ToString(Console.ReadKey(false).KeyChar), out selected));

			switch (selected) {
				case 0:
					{
						return false;
					}
				case 1:
					{
						Game game = new Game(border, body, point, space, delay, shortdelay);
						Console.Clear();
						snd.Stop();
						win = game.Start(skalkamode);
						if (win) {
							snd.Sound("win");
							rnd.Win();
							Thread.Sleep(2000);
						} else {
							snd.Sound("win");
							rnd.Gameover();
							Thread.Sleep(2000);
						}
						Console.Clear();
						break;
					}
				case 2:
					{
						Console.Clear();
						Console.SetCursorPosition(0, 0);
						Console.Write("Work in progress (press enter)");
						Console.Read();
						break;
					}
				case 3:
					{
						Console.Clear();
						Console.SetCursorPosition(0, 0);
						Console.Write("Work in progress (press enter)");
						Console.Read();
						break;
					}
					
			}
			return true;
		}
	}
}

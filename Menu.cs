/*
 * Created by SharpDevelop.
 * User: Ventr
 * Date: 05/25/2018
 * Time: 09:14 AM
 */
using System;

namespace Snake
{
	/// <summary>
	/// Description of Menu.
	/// </summary>
	public class Menu
	{
		char border, body, point, space;
		Int16 delay, shortdelay;
		public Menu(char border, char body, char point, char space, Int16 delay, Int16 shortdelay)
		{
			this.border = border;
			this.body = body;
			this.point = point;
			this.space = space;
			this.delay = delay;
			this.shortdelay = shortdelay;
		}
		
		public bool Main()
		{
			Render rnd = new Render();
			int selected;
			do {
				rnd.Menu();
			} while(!int.TryParse(Convert.ToString(Console.ReadKey(false).KeyChar), out selected));
			switch (selected) {
				case 1:
					{
						Game game = new Game(border, body, point, space, delay, shortdelay);
						Console.Clear();
						game.Start();
						Console.Clear();
						break;
					}
				case 2:
					{
						break;
					}
				case 3:
					{
						break;
					}
					
			}
			return true;
		}
	}
}

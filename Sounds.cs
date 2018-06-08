/*
 * Created by SharpDevelop.
 * User: Ventr
 * Date: 05/24/2018
 * Time: 09:55 PM
 */
using System;
using System.Threading;
using System.Media;

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
		
		public void Play(string sound)
        {
			SoundPlayer player = new SoundPlayer(Environment.CurrentDirectory+@"\sounds\"+sound+".wav");
			player.PlayLooping();
        }
		
	}
		
}


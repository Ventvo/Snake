/*
 * Created by SharpDevelop.
 * User: Ventr
 * Date: 05/24/2018
 * Time: 09:55 PM
 */
using System;
using System.Media;

namespace Snake
{
	/// <summary>
	/// Description of Sounds.
	/// </summary>
	public class Sounds
	{
		string path = Environment.CurrentDirectory + @"\sounds\";
		public Sounds()
		{
				
		}
		public void Sound(string Sound)
		{
			SoundPlayer player = new SoundPlayer(path + @"\sounds\" + Sound + ".wav");
			player.Play();
		}
		
		public void Music(int Song)
		{
			switch (Song) {
				case 1:
					{
						SoundPlayer player = new SoundPlayer(path + @"\music\Gopnik.wav");
						player.PlayLooping();
						break;
					}
				case 2:
					{
						SoundPlayer player = new SoundPlayer(path + @"\music\Katyusha.wav");
						player.PlayLooping();
						break;
					}
				case 3:
					{
						SoundPlayer player = new SoundPlayer(path + @"\music\Mario.wav");
						player.PlayLooping();
						break;
					}
				case 4:
					{
						SoundPlayer player = new SoundPlayer(path + @"\music\Snake.wav");
						player.PlayLooping();
						break;
					}
				case 5:
					{
						SoundPlayer player = new SoundPlayer(path + @"\music\Tetris.wav");
						player.PlayLooping();
						break;
					}
			}
		}
		public void Stop()
		{
			SoundPlayer player = new SoundPlayer();
			player.Stop();
		}
	}
}


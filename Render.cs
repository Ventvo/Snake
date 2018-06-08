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
		
		public void Menu()
		{
			Console.CursorLeft = Console.BufferWidth / 5;
			Text("Menu", 1);
			Console.CursorTop = 16 + 3;
			Console.CursorLeft = Console.BufferWidth / 5;
			Text("Play", 2);
			Console.ReadLine();
		}
		
		void Text(string text, Int16 font)
		{
			int topcursor = Console.CursorTop, charlength = 1, cursorposition;
			if (font == 2)
				text = text.ToLower();
			for (int i = 0; i < text.Length; i++) {
				cursorposition = Console.CursorLeft;
				switch (text[i]) {
					case 'a':
						{
							switch (font) {
								case 1:
									{
										charlength = WriteLine("  aaaaaaaaaaaaa   ");
										charlength = WriteLine("  a::::::::::::a  ");
										charlength = WriteLine("  aaaaaaaaa:::::a ");
										charlength = WriteLine("           a::::a ");
										charlength = WriteLine("    aaaaaaa:::::a ");
										charlength = WriteLine("  aa::::::::::::a ");
										charlength = WriteLine(" a::::aaaa::::::a ");
										charlength = WriteLine("a::::a    a:::::a ");
										charlength = WriteLine("a::::a    a:::::a ");
										charlength = WriteLine("a:::::aaaa::::::a ");
										charlength = WriteLine(" a::::::::::aa:::a");
										charlength = WriteLine("  aaaaaaaaaa  aaaa");
										charlength = 18;
										break;
									}
								case 2:
									{
										charlength = WriteLine(" _______ ");
										charlength = WriteLine("|   _   |");
										charlength = WriteLine("|  |_|  |");
										charlength = WriteLine("|       |");
										charlength = WriteLine("|       |");
										charlength = WriteLine("|   _   |");
										charlength = WriteLine("|__| |__|");
										break;								
									}
							}
							break;
						}
					case 'b':
						{
							switch (font) {
								case 1:
									{
										charlength = WriteLine("bbbbbbbb            ");
										charlength = WriteLine("b::::::b            ");
										charlength = WriteLine("b::::::b            ");
										charlength = WriteLine("b::::::b            ");
										charlength = WriteLine(" b:::::b            ");
										charlength = WriteLine(" b:::::bbbbbbbbb    ");
										charlength = WriteLine(" b::::::::::::::bb  ");
										charlength = WriteLine(" b::::::::::::::::b ");
										charlength = WriteLine(" b:::::bbbbb:::::::b");
										charlength = WriteLine(" b:::::b    b::::::b");
										charlength = WriteLine(" b:::::b     b:::::b");
										charlength = WriteLine(" b:::::b     b:::::b");
										charlength = WriteLine(" b:::::b     b:::::b");
										charlength = WriteLine(" b:::::bbbbbb::::::b");
										charlength = WriteLine(" b::::::::::::::::b ");
										charlength = WriteLine(" b:::::::::::::::b  ");
										charlength = WriteLine(" bbbbbbbbbbbbbbbb   ");
										charlength = 20;
										break;
									}
								case 2:
									{
										charlength = WriteLine(" _______ ");
										charlength = WriteLine("|  _    |");
										charlength = WriteLine("| |_|   |");
										charlength = WriteLine("|       |");
										charlength = WriteLine("|  _   | ");
										charlength = WriteLine("| |_|   |");
										charlength = WriteLine("|_______|");
										break;
									}
							}
							break;
						}
					case 'c':
						{
							switch (font) {
								case 1:
									{
										charlength = WriteLine("    cccccccccccccccc");
										charlength = WriteLine("  cc:::::::::::::::c");
										charlength = WriteLine(" c:::::::::::::::::c");
										charlength = WriteLine("c:::::::cccccc:::::c");
										charlength = WriteLine("c::::::c     ccccccc");
										charlength = WriteLine("c:::::c             ");
										charlength = WriteLine("c:::::c             ");
										charlength = WriteLine("c::::::c     ccccccc");
										charlength = WriteLine("c:::::::cccccc:::::c");
										charlength = WriteLine(" c:::::::::::::::::c");
										charlength = WriteLine("  cc:::::::::::::::c");
										charlength = WriteLine("    cccccccccccccccc");
										charlength = 20;
										break;
									}
								case 2:
									{
										charlength = WriteLine(" _______ ");
										charlength = WriteLine("|       |");
										charlength = WriteLine("|       |");
										charlength = WriteLine("|       |");
										charlength = WriteLine("|      _|");
										charlength = WriteLine("|     |_ ");
										charlength = WriteLine("|_______|");
										break;
									}
							}
							break;
						}
					case 'd':
						{
							switch (font) {
								case 1:
									{
										charlength = WriteLine("            dddddddd");
										charlength = WriteLine("            d::::::d");
										charlength = WriteLine("            d::::::d");
										charlength = WriteLine("            d::::::d");
										charlength = WriteLine("            d:::::d ");
										charlength = WriteLine("    ddddddddd:::::d ");
										charlength = WriteLine("  dd::::::::::::::d ");
										charlength = WriteLine(" d::::::::::::::::d ");
										charlength = WriteLine("d:::::::ddddd:::::d ");
										charlength = WriteLine("d::::::d    d:::::d ");
										charlength = WriteLine("d:::::d     d:::::d ");
										charlength = WriteLine("d:::::d     d:::::d ");
										charlength = WriteLine("d:::::d     d:::::d ");
										charlength = WriteLine("d::::::ddddd::::::dd");
										charlength = WriteLine(" d:::::::::::::::::d");
										charlength = WriteLine("  d:::::::::ddd::::d");
										charlength = WriteLine("   ddddddddd   ddddd");
										charlength = 20;
										break;
									}
								case 2:
									{
										charlength = WriteLine(" ______  ");
										charlength = WriteLine("|      | ");
										charlength = WriteLine("|  _    |");
										charlength = WriteLine("| | |   |");
										charlength = WriteLine("| |_|   |");
										charlength = WriteLine("|       |");
										charlength = WriteLine("|______| ");
										break;
									}
							}
							break;
						}
					case 'e':
						{
							switch (font) {
								case 1:
									{
										charlength = WriteLine("    eeeeeeeeeeee    ");
										charlength = WriteLine("  ee::::::::::::ee  ");
										charlength = WriteLine(" e::::::eeeee:::::ee");
										charlength = WriteLine("e::::::e     e:::::e");
										charlength = WriteLine("e:::::::eeeee::::::e");
										charlength = WriteLine("e:::::::::::::::::e ");
										charlength = WriteLine("e::::::eeeeeeeeeee  ");
										charlength = WriteLine("e:::::::e           ");
										charlength = WriteLine("e::::::::e          ");
										charlength = WriteLine(" e::::::::eeeeeeee  ");
										charlength = WriteLine("  ee:::::::::::::e  ");
										charlength = WriteLine("    eeeeeeeeeeeeee  ");
										charlength = 20;
										break;
									}
								case 2:
									{
										charlength = WriteLine(" _______ ");
										charlength = WriteLine("|       |");
										charlength = WriteLine("|    ___|");
										charlength = WriteLine("|   |___ ");
										charlength = WriteLine("|    ___|");
										charlength = WriteLine("|   |___ ");
										charlength = WriteLine("|_______|");
										break;
									}
							}
							break;
						}
					case 'f':
						{
							switch (font) {
								case 1:
									{
										charlength = WriteLine("    ffffffffffffffff  ");
										charlength = WriteLine("   f::::::::::::::::f ");
										charlength = WriteLine("  f::::::::::::::::::f");
										charlength = WriteLine("  f::::::fffffff:::::f");
										charlength = WriteLine("  f:::::f       ffffff");
										charlength = WriteLine("  f:::::f             ");
										charlength = WriteLine(" f:::::::ffffff       ");
										charlength = WriteLine(" f::::::::::::f       ");
										charlength = WriteLine(" f::::::::::::f       ");
										charlength = WriteLine(" f:::::::ffffff       ");
										charlength = WriteLine("  f:::::f             ");
										charlength = WriteLine("  f:::::f             ");
										charlength = WriteLine(" f:::::::f            ");
										charlength = WriteLine(" f:::::::f            ");
										charlength = WriteLine(" f:::::::f            ");
										charlength = WriteLine(" fffffffff            ");
										charlength = 22;
										break;
									}
								case 2:
									{
										charlength = WriteLine(" _______ ");
										charlength = WriteLine("|       |");
										charlength = WriteLine("|    ___|");
										charlength = WriteLine("|   |___ ");
										charlength = WriteLine("|    ___|");
										charlength = WriteLine("|   |    ");
										charlength = WriteLine("|___|    ");
										break;
									}
							}
							break;
						}
					case 'g':
						{
							switch (font) {
								case 1:
									{
										charlength = WriteLine("   ggggggggg   ggggg");
										charlength = WriteLine("  g:::::::::ggg::::g");
										charlength = WriteLine(" g:::::::::::::::::g");
										charlength = WriteLine("g::::::ggggg::::::gg");
										charlength = WriteLine("g:::::g     g:::::g ");
										charlength = WriteLine("g:::::g     g:::::g ");
										charlength = WriteLine("g:::::g     g:::::g ");
										charlength = WriteLine("g::::::g    g:::::g ");
										charlength = WriteLine("g:::::::ggggg:::::g ");
										charlength = WriteLine(" g::::::::::::::::g ");
										charlength = WriteLine("  gg::::::::::::::g ");
										charlength = WriteLine("    gggggggg::::::g ");
										charlength = WriteLine("            g:::::g ");
										charlength = WriteLine("gggggg      g:::::g ");
										charlength = WriteLine("g:::::gg   gg:::::g ");
										charlength = WriteLine(" g::::::ggg:::::::g ");
										charlength = WriteLine("  gg:::::::::::::g  ");
										charlength = WriteLine("    ggg::::::ggg    ");
										charlength = WriteLine("       gggggg       ");
										charlength = 20;
										break;
									}
								case 2:
									{
										charlength = WriteLine(" _______ ");
										charlength = WriteLine("|       |");
										charlength = WriteLine("|    ___|");
										charlength = WriteLine("|   | __ ");
										charlength = WriteLine("|   ||  |");
										charlength = WriteLine("|   |_| |");
										charlength = WriteLine("|_______|");
										break;
									}
							}
							break;
						}
					case 'h':
						{
							switch (font) {
								case 1:
									{
										charlength = WriteLine("hhhhhhh             ");
										charlength = WriteLine("h:::::h             ");
										charlength = WriteLine("h:::::h             ");
										charlength = WriteLine("h:::::h             ");
										charlength = WriteLine(" h::::h hhhhh       ");
										charlength = WriteLine(" h::::hh:::::hhh    ");
										charlength = WriteLine(" h::::::::::::::hh  ");
										charlength = WriteLine(" h:::::::hhh::::::h ");
										charlength = WriteLine(" h::::::h   h::::::h");
										charlength = WriteLine(" h:::::h     h:::::h");
										charlength = WriteLine(" h:::::h     h:::::h");
										charlength = WriteLine(" h:::::h     h:::::h");
										charlength = WriteLine(" h:::::h     h:::::h");
										charlength = WriteLine(" h:::::h     h:::::h");
										charlength = WriteLine(" h:::::h     h:::::h");
										charlength = WriteLine(" hhhhhhh     hhhhhhh");
										charlength = 20;
										break;
									}
								case 2:
									{

										charlength = WriteLine(" __   __ ");
										charlength = WriteLine("|  | |  |");
										charlength = WriteLine("|  |_|  |");
										charlength = WriteLine("|       |");
										charlength = WriteLine("|       |");
										charlength = WriteLine("|   _   |");
										charlength = WriteLine("|__| |__|");
										break;

									}
							}
							break;
						}
					case 'i':
						{
							switch (font) {
								case 1:
									{
										charlength = WriteLine("  iiii  ");
										charlength = WriteLine(" i::::i ");
										charlength = WriteLine("  iiii  ");
										charlength = WriteLine("        ");
										charlength = WriteLine("iiiiiii ");
										charlength = WriteLine("i:::::i ");
										charlength = WriteLine(" i::::i ");
										charlength = WriteLine(" i::::i ");
										charlength = WriteLine(" i::::i ");
										charlength = WriteLine(" i::::i ");
										charlength = WriteLine(" i::::i ");
										charlength = WriteLine(" i::::i ");
										charlength = WriteLine("i::::::i");
										charlength = WriteLine("i::::::i");
										charlength = WriteLine("i::::::i");
										charlength = WriteLine("iiiiiiii");
										charlength = 8;
										break;
									}
								case 2:
									{

										charlength = WriteLine(" ___  ");
										charlength = WriteLine("|   | ");
										charlength = WriteLine("|   | ");
										charlength = WriteLine("|   | ");
										charlength = WriteLine("|   | ");
										charlength = WriteLine("|   | ");
										charlength = WriteLine("|___| ");
										break;

									}
							}
							break;
						}
					case 'j':
						{
							switch (font) {
								case 1:
									{
										charlength = WriteLine("            jjjj ");
										charlength = WriteLine("           j::::j");
										charlength = WriteLine("            jjjj ");
										charlength = WriteLine("                 ");
										charlength = WriteLine("          jjjjjjj");
										charlength = WriteLine("          j:::::j");
										charlength = WriteLine("           j::::j");
										charlength = WriteLine("           j::::j");
										charlength = WriteLine("           j::::j");
										charlength = WriteLine("           j::::j");
										charlength = WriteLine("           j::::j");
										charlength = WriteLine("           j::::j");
										charlength = WriteLine("           j::::j");
										charlength = WriteLine("           j::::j");
										charlength = WriteLine("           j::::j");
										charlength = WriteLine("           j::::j");
										charlength = WriteLine("           j::::j");
										charlength = WriteLine(" jjjj      j::::j");
										charlength = WriteLine("j::::jj   j:::::j");
										charlength = WriteLine("j::::::jjj::::::j");
										charlength = WriteLine(" jj::::::::::::j ");
										charlength = WriteLine("   jjj::::::jjj  ");
										charlength = WriteLine("      jjjjjj     ");
										charlength = 17;
										break;
									}
								case 2:
									{

										charlength = WriteLine("     ___ ");
										charlength = WriteLine("    |   |");
										charlength = WriteLine("    |   |");
										charlength = WriteLine("    |   |");
										charlength = WriteLine(" ___|   |");
										charlength = WriteLine("|       |");
										charlength = WriteLine("|_______|");
										break;

									}
							}
							break;
						}
					case 'k':
						{
							switch (font) {
								case 1:
									{
										charlength = WriteLine("kkkkkkkk           ");
										charlength = WriteLine("k::::::k           ");
										charlength = WriteLine("k::::::k           ");
										charlength = WriteLine("k::::::k           ");
										charlength = WriteLine(" k:::::k    kkkkkkk");
										charlength = WriteLine(" k:::::k   k:::::k ");
										charlength = WriteLine(" k:::::k  k:::::k  ");
										charlength = WriteLine(" k:::::k k:::::k   ");
										charlength = WriteLine(" k::::::k:::::k    ");
										charlength = WriteLine(" k:::::::::::k     ");
										charlength = WriteLine(" k:::::::::::k     ");
										charlength = WriteLine(" k::::::k:::::k    ");
										charlength = WriteLine("k::::::k k:::::k   ");
										charlength = WriteLine("k::::::k  k:::::k  ");
										charlength = WriteLine("k::::::k   k:::::k ");
										charlength = WriteLine("kkkkkkkk    kkkkkkk");
										charlength = 19;
										break;
									}
								case 2:
									{

										charlength = WriteLine(" ___   _ ");
										charlength = WriteLine("|   | | |");
										charlength = WriteLine("|   |_| |");
										charlength = WriteLine("|      _|");
										charlength = WriteLine("|     |_ ");
										charlength = WriteLine("|    _  |");
										charlength = WriteLine("|___| |_|");
										break;

									}
							}
							break;
						}
					case 'l':
						{
							switch (font) {
								case 1:
									{
										charlength = WriteLine("lllllll ");
										charlength = WriteLine("l:::::l ");
										charlength = WriteLine("l:::::l ");
										charlength = WriteLine("l:::::l ");
										charlength = WriteLine(" l::::l ");
										charlength = WriteLine(" l::::l ");
										charlength = WriteLine(" l::::l ");
										charlength = WriteLine(" l::::l ");
										charlength = WriteLine(" l::::l ");
										charlength = WriteLine(" l::::l ");
										charlength = WriteLine(" l::::l ");
										charlength = WriteLine(" l::::l ");
										charlength = WriteLine("l::::::l");
										charlength = WriteLine("l::::::l");
										charlength = WriteLine("l::::::l");
										charlength = WriteLine("llllllll");
										charlength = 8;
										break;
									}
								case 2:
									{

										charlength = WriteLine(" ___     ");
										charlength = WriteLine("|   |    ");
										charlength = WriteLine("|   |    ");
										charlength = WriteLine("|   |    ");
										charlength = WriteLine("|   |___ ");
										charlength = WriteLine("|       |");
										charlength = WriteLine("|_______|");
										break;

									}
							}
							break;
						}
					case 'm':
						{
							switch (font) {
								case 1:
									{
										charlength = WriteLine("   mmmmmmm    mmmmmmm   ");
										charlength = WriteLine(" mm:::::::m  m:::::::mm ");
										charlength = WriteLine("m::::::::::mm::::::::::m");
										charlength = WriteLine("m::::::::::::::::::::::m");
										charlength = WriteLine("m:::::mmm::::::mmm:::::m");
										charlength = WriteLine("m::::m   m::::m   m::::m");
										charlength = WriteLine("m::::m   m::::m   m::::m");
										charlength = WriteLine("m::::m   m::::m   m::::m");
										charlength = WriteLine("m::::m   m::::m   m::::m");
										charlength = WriteLine("m::::m   m::::m   m::::m");
										charlength = WriteLine("m::::m   m::::m   m::::m");
										charlength = WriteLine("mmmmmm   mmmmmm   mmmmmm");
										charlength = 24;
										break;
									}
								case 2:
									{

										charlength = WriteLine(" __   __ ");
										charlength = WriteLine("|  |_|  |");
										charlength = WriteLine("|       |");
										charlength = WriteLine("|       |");
										charlength = WriteLine("|       |");
										charlength = WriteLine("| ||_|| |");
										charlength = WriteLine("|_|   |_|");
										break;

									}
							}
							break;
						}
					case 'n':
						{
							switch (font) {
								case 1:
									{
										charlength = WriteLine("nnnn  nnnnnnnn    ");
										charlength = WriteLine("n:::nn::::::::nn  ");
										charlength = WriteLine("n::::::::::::::nn ");
										charlength = WriteLine("nn:::::::::::::::n");
										charlength = WriteLine("  n:::::nnnn:::::n");
										charlength = WriteLine("  n::::n    n::::n");
										charlength = WriteLine("  n::::n    n::::n");
										charlength = WriteLine("  n::::n    n::::n");
										charlength = WriteLine("  n::::n    n::::n");
										charlength = WriteLine("  n::::n    n::::n");
										charlength = WriteLine("  n::::n    n::::n");
										charlength = WriteLine("  nnnnnn    nnnnnn");
										charlength = 18;
										break;
									}
								case 2:
									{

										charlength = WriteLine(" __    _ ");
										charlength = WriteLine("|  |  | |");
										charlength = WriteLine("|   |_| |");
										charlength = WriteLine("|       |");
										charlength = WriteLine("|  _    |");
										charlength = WriteLine("| | |   |");
										charlength = WriteLine("|_|  |__|");
										break;

									}
							}
							break;
						}
					case 'o':
						{
							switch (font) {
								case 1:
									{
										charlength = WriteLine("   ooooooooooo   ");
										charlength = WriteLine(" oo:::::::::::oo ");
										charlength = WriteLine("o:::::::::::::::o");
										charlength = WriteLine("o:::::ooooo:::::o");
										charlength = WriteLine("o::::o     o::::o");
										charlength = WriteLine("o::::o     o::::o");
										charlength = WriteLine("o::::o     o::::o");
										charlength = WriteLine("o::::o     o::::o");
										charlength = WriteLine("o:::::ooooo:::::o");
										charlength = WriteLine("o:::::::::::::::o");
										charlength = WriteLine(" oo:::::::::::oo ");
										charlength = WriteLine("   ooooooooooo   ");
										charlength = 17;
										break;
									}
								case 2:
									{

										charlength = WriteLine(" _______ ");
										charlength = WriteLine("|       |");
										charlength = WriteLine("|   _   |");
										charlength = WriteLine("|  | |  |");
										charlength = WriteLine("|  |_|  |");
										charlength = WriteLine("|       |");
										charlength = WriteLine("|_______|");
										break;

									}
							}
							break;
						}
					case 'p':
						{
							switch (font) {
								case 1:
									{
										charlength = WriteLine("ppppp   ppppppppp   ");
										charlength = WriteLine("p::::ppp:::::::::p  ");
										charlength = WriteLine("p:::::::::::::::::p ");
										charlength = WriteLine("pp::::::ppppp::::::p");
										charlength = WriteLine(" p:::::p     p:::::p");
										charlength = WriteLine(" p:::::p     p:::::p");
										charlength = WriteLine(" p:::::p     p:::::p");
										charlength = WriteLine(" p:::::p    p::::::p");
										charlength = WriteLine(" p:::::ppppp:::::::p");
										charlength = WriteLine(" p::::::::::::::::p ");
										charlength = WriteLine(" p::::::::::::::pp  ");
										charlength = WriteLine(" p::::::pppppppp    ");
										charlength = WriteLine(" p:::::p            ");
										charlength = WriteLine(" p:::::p            ");
										charlength = WriteLine("p:::::::p           ");
										charlength = WriteLine("p:::::::p           ");
										charlength = WriteLine("p:::::::p           ");
										charlength = WriteLine("ppppppppp           ");
										break;
									}
								case 2:
									{

										charlength = WriteLine(" _______ ");
										charlength = WriteLine("|       |");
										charlength = WriteLine("|    _  |");
										charlength = WriteLine("|   |_| |");
										charlength = WriteLine("|    ___|");
										charlength = WriteLine("|   |    ");
										charlength = WriteLine("|___|    ");
										break;

									}
							}
							break;
						}
					case 'q':
						{
							switch (font) {
								case 1:
									{
										charlength = WriteLine("   qqqqqqqqq   qqqqq");
										charlength = WriteLine("  q:::::::::qqq::::q");
										charlength = WriteLine(" q:::::::::::::::::q");
										charlength = WriteLine("q::::::qqqqq::::::qq");
										charlength = WriteLine("q:::::q     q:::::q ");
										charlength = WriteLine("q:::::q     q:::::q ");
										charlength = WriteLine("q:::::q     q:::::q ");
										charlength = WriteLine("q::::::q    q:::::q ");
										charlength = WriteLine("q:::::::qqqqq:::::q ");
										charlength = WriteLine(" q::::::::::::::::q ");
										charlength = WriteLine("  qq::::::::::::::q ");
										charlength = WriteLine("    qqqqqqqq::::::q ");
										charlength = WriteLine("            q:::::q ");
										charlength = WriteLine("            q:::::q ");
										charlength = WriteLine("           q:::::::q");
										charlength = WriteLine("           q:::::::q");
										charlength = WriteLine("           q:::::::q");
										charlength = WriteLine("           qqqqqqqqq");
										break;
									}
								case 2:
									{

										charlength = WriteLine(" _______ ");
										charlength = WriteLine("|       |");
										charlength = WriteLine("|   _   |");
										charlength = WriteLine("|  | |  |");
										charlength = WriteLine("|  |_|  |");
										charlength = WriteLine("|      | ");
										charlength = WriteLine("|____||_|");
										break;

									}
							}
							break;
						}
					case 'r':
						{
							switch (font) {
								case 1:
									{
										charlength = WriteLine("rrrrr   rrrrrrrrr   ");
										charlength = WriteLine("r::::rrr:::::::::r  ");
										charlength = WriteLine("r:::::::::::::::::r ");
										charlength = WriteLine("rr::::::rrrrr::::::r");
										charlength = WriteLine(" r:::::r     r:::::r");
										charlength = WriteLine(" r:::::r     rrrrrrr");
										charlength = WriteLine(" r:::::r            ");
										charlength = WriteLine(" r:::::r            ");
										charlength = WriteLine(" r:::::r            ");
										charlength = WriteLine(" r:::::r            ");
										charlength = WriteLine(" r:::::r            ");
										charlength = WriteLine(" rrrrrrr            ");
										break;
									}
								case 2:
									{

										charlength = WriteLine(" ______   ");
										charlength = WriteLine("|    _ |  ");
										charlength = WriteLine("|   | ||  ");
										charlength = WriteLine("|   |_||_ ");
										charlength = WriteLine("|    __  |");
										charlength = WriteLine("|   |  | |");
										charlength = WriteLine("|___|  |_|");
										break;
		
									}
							}
							break;
						}
					case 's':
						{
							switch (font) {
								case 1:
									{
										charlength = WriteLine("    ssssssssss   ");
										charlength = WriteLine("  ss::::::::::s  ");
										charlength = WriteLine("ss:::::::::::::s ");
										charlength = WriteLine("s::::::ssss:::::s");
										charlength = WriteLine(" s:::::s  ssssss ");
										charlength = WriteLine("   s::::::s      ");
										charlength = WriteLine("      s::::::s   ");
										charlength = WriteLine("ssssss   s:::::s ");
										charlength = WriteLine("s:::::ssss::::::s");
										charlength = WriteLine("s::::::::::::::s ");
										charlength = WriteLine(" s:::::::::::ss  ");
										charlength = WriteLine("  sssssssssss    ");
										break;
									}
								case 2:
									{

										charlength = WriteLine(" _______ ");
										charlength = WriteLine("|       |");
										charlength = WriteLine("|  _____|");
										charlength = WriteLine("| |_____ ");
										charlength = WriteLine("|_____  |");
										charlength = WriteLine(" _____| |");
										charlength = WriteLine("|_______|");
										break;

									}
							}
							break;
						}
					case 't':
						{
							switch (font) {
								case 1:
									{
										charlength = WriteLine("         tttt          ");
										charlength = WriteLine("      ttt:::t          ");
										charlength = WriteLine("      t:::::t          ");
										charlength = WriteLine("      t:::::t          ");
										charlength = WriteLine("ttttttt:::::ttttttt    ");
										charlength = WriteLine("t:::::::::::::::::t    ");
										charlength = WriteLine("t:::::::::::::::::t    ");
										charlength = WriteLine("tttttt:::::::tttttt    ");
										charlength = WriteLine("      t:::::t          ");
										charlength = WriteLine("      t:::::t          ");
										charlength = WriteLine("      t:::::t          ");
										charlength = WriteLine("      t:::::t    tttttt");
										charlength = WriteLine("      t::::::tttt:::::t");
										charlength = WriteLine("      tt::::::::::::::t");
										charlength = WriteLine("        tt:::::::::::tt");
										charlength = WriteLine("          ttttttttttt  ");
										break;
									}
								case 2:
									{

										charlength = WriteLine(" _______ ");
										charlength = WriteLine("|       |");
										charlength = WriteLine("|_     _|");
										charlength = WriteLine("  |   |  ");
										charlength = WriteLine("  |   |  ");
										charlength = WriteLine("  |   |  ");
										charlength = WriteLine("  |___|  ");
										break;

									}
							}
							break;
						}
					case 'u':
						{
							switch (font) {
								case 1:
									{
										charlength = WriteLine("uuuuuu    uuuuuu  ");
										charlength = WriteLine("u::::u    u::::u  ");
										charlength = WriteLine("u::::u    u::::u  ");
										charlength = WriteLine("u::::u    u::::u  ");
										charlength = WriteLine("u::::u    u::::u  ");
										charlength = WriteLine("u::::u    u::::u  ");
										charlength = WriteLine("u::::u    u::::u  ");
										charlength = WriteLine("u:::::uuuu:::::u  ");
										charlength = WriteLine("u:::::::::::::::uu");
										charlength = WriteLine(" u:::::::::::::::u");
										charlength = WriteLine("  uu::::::::uu:::u");
										charlength = WriteLine("    uuuuuuuu  uuuu");
										break;
									}
								case 2:
									{

										charlength = WriteLine(" __   __ ");
										charlength = WriteLine("|  | |  |");
										charlength = WriteLine("|  | |  |");
										charlength = WriteLine("|  |_|  |");
										charlength = WriteLine("|       |");
										charlength = WriteLine("|       |");
										charlength = WriteLine("|_______|");
										break;

									}
							}
							break;
						}
					case 'v':
						{
							switch (font) {
								case 1:
									{
										charlength = WriteLine("vvvvvvv           vvvvvvv");
										charlength = WriteLine(" v:::::v         v:::::v ");
										charlength = WriteLine("  v:::::v       v:::::v  ");
										charlength = WriteLine("   v:::::v     v:::::v   ");
										charlength = WriteLine("    v:::::v   v:::::v    ");
										charlength = WriteLine("     v:::::v v:::::v     ");
										charlength = WriteLine("      v:::::v:::::v      ");
										charlength = WriteLine("       v:::::::::v       ");
										charlength = WriteLine("        v:::::::v        ");
										charlength = WriteLine("         v:::::v         ");
										charlength = WriteLine("          v:::v          ");
										charlength = WriteLine("           vvv           ");
										break;
									}
								case 2:
									{

										charlength = WriteLine(" __   __ ");
										charlength = WriteLine("|  | |  |");
										charlength = WriteLine("|  |_|  |");
										charlength = WriteLine("|       |");
										charlength = WriteLine("|       |");
										charlength = WriteLine(" |     | ");
										charlength = WriteLine("  |___|  ");
										break;

									}
							}
							break;
						}
					case 'w':
						{
							switch (font) {
								case 1:
									{
										charlength = WriteLine("wwwwwww           wwwww           wwwwwww");
										charlength = WriteLine(" w:::::w         w:::::w         w:::::w ");
										charlength = WriteLine("  w:::::w       w:::::::w       w:::::w  ");
										charlength = WriteLine("   w:::::w     w:::::::::w     w:::::w   ");
										charlength = WriteLine("    w:::::w   w:::::w:::::w   w:::::w    ");
										charlength = WriteLine("     w:::::w w:::::w w:::::w w:::::w     ");
										charlength = WriteLine("      w:::::w:::::w   w:::::w:::::w      ");
										charlength = WriteLine("       w:::::::::w     w:::::::::w       ");
										charlength = WriteLine("        w:::::::w       w:::::::w        ");
										charlength = WriteLine("         w:::::w         w:::::w         ");
										charlength = WriteLine("          w:::w           w:::w          ");
										charlength = WriteLine("           www             www           ");
										break;
									}
								case 2:
									{

										charlength = WriteLine(" _     _ ");
										charlength = WriteLine("| | _ | |");
										charlength = WriteLine("| || || |");
										charlength = WriteLine("|       |");
										charlength = WriteLine("|       |");
										charlength = WriteLine("|   _   |");
										charlength = WriteLine("|__| |__|");
										break;

									}
							}
							break;
						}
					case 'x':
						{
							switch (font) {
								case 1:
									{
										charlength = WriteLine("xxxxxxx      xxxxxxx");
										charlength = WriteLine(" x:::::x    x:::::x ");
										charlength = WriteLine("  x:::::x  x:::::x  ");
										charlength = WriteLine("   x:::::xx:::::x   ");
										charlength = WriteLine("    x::::::::::x    ");
										charlength = WriteLine("     x::::::::x     ");
										charlength = WriteLine("     x::::::::x     ");
										charlength = WriteLine("    x::::::::::x    ");
										charlength = WriteLine("   x:::::xx:::::x   ");
										charlength = WriteLine("  x:::::x  x:::::x  ");
										charlength = WriteLine(" x:::::x    x:::::x ");
										charlength = WriteLine("xxxxxxx      xxxxxxx");
										break;
									}
								case 2:
									{

										charlength = WriteLine(" __   __ ");
										charlength = WriteLine("|  |_|  |");
										charlength = WriteLine("|       |");
										charlength = WriteLine("|       |");
										charlength = WriteLine(" |     | ");
										charlength = WriteLine("|   _   |");
										charlength = WriteLine("|__| |__|");
										break;

									}
							}
							break;
						}
					case 'y':
						{
							switch (font) {
								case 1:
									{
										charlength = WriteLine("yyyyyyy           yyyyyyy");
										charlength = WriteLine(" y:::::y         y:::::y ");
										charlength = WriteLine("  y:::::y       y:::::y  ");
										charlength = WriteLine("   y:::::y     y:::::y   ");
										charlength = WriteLine("    y:::::y   y:::::y    ");
										charlength = WriteLine("     y:::::y y:::::y     ");
										charlength = WriteLine("      y:::::y:::::y      ");
										charlength = WriteLine("       y:::::::::y       ");
										charlength = WriteLine("        y:::::::y        ");
										charlength = WriteLine("         y:::::y         ");
										charlength = WriteLine("        y:::::y          ");
										charlength = WriteLine("       y:::::y           ");
										charlength = WriteLine("      y:::::y            ");
										charlength = WriteLine("     y:::::y             ");
										charlength = WriteLine("    y:::::y              ");
										charlength = WriteLine("   y:::::y               ");
										charlength = WriteLine("  yyyyyyy                ");
										break;
									}
								case 2:
									{

										charlength = WriteLine(" __   __ ");
										charlength = WriteLine("|  | |  |");
										charlength = WriteLine("|  |_|  |");
										charlength = WriteLine("|       |");
										charlength = WriteLine("|_     _|");
										charlength = WriteLine("  |   |  ");
										charlength = WriteLine("  |___|  ");
										break;

									}
							}
							break;
						}
					case 'z':
						{
							switch (font) {
								case 1:
									{
										charlength = WriteLine("zzzzzzzzzzzzzzzzz");
										charlength = WriteLine("z:::::::::::::::z");
										charlength = WriteLine("z::::::::::::::z ");
										charlength = WriteLine("zzzzzzzz::::::z  ");
										charlength = WriteLine("      z::::::z   ");
										charlength = WriteLine("     z::::::z    ");
										charlength = WriteLine("    z::::::z     ");
										charlength = WriteLine("   z::::::z      ");
										charlength = WriteLine("  z::::::zzzzzzzz");
										charlength = WriteLine(" z::::::::::::::z");
										charlength = WriteLine("z:::::::::::::::z");
										charlength = WriteLine("zzzzzzzzzzzzzzzzz");
										break;
									}
								case 2:
									{

										charlength = WriteLine(" _______ ");
										charlength = WriteLine("|       |");
										charlength = WriteLine("|____   |");
										charlength = WriteLine(" ____|  |");
										charlength = WriteLine("| ______|");
										charlength = WriteLine("| |_____ ");
										charlength = WriteLine("|_______|");
										break;

									}
							}
							break;
						}
					case 'A':
						{
							switch (font) {
								case 1:
									{
										charlength = WriteLine("               AAA               ");
										charlength = WriteLine("              A:::A              ");
										charlength = WriteLine("             A:::::A             ");
										charlength = WriteLine("            A:::::::A            ");
										charlength = WriteLine("           A:::::::::A           ");
										charlength = WriteLine("          A:::::A:::::A          ");
										charlength = WriteLine("         A:::::A A:::::A         ");
										charlength = WriteLine("        A:::::A   A:::::A        ");
										charlength = WriteLine("       A:::::A     A:::::A       ");
										charlength = WriteLine("      A:::::AAAAAAAAA:::::A      ");
										charlength = WriteLine("     A:::::::::::::::::::::A     ");
										charlength = WriteLine("    A:::::AAAAAAAAAAAAA:::::A    ");
										charlength = WriteLine("   A:::::A             A:::::A   ");
										charlength = WriteLine("  A:::::A               A:::::A  ");
										charlength = WriteLine(" A:::::A                 A:::::A ");
										charlength = WriteLine("AAAAAAA                   AAAAAAA");
										break;
									}
							}
							break;
						}
					case 'B':
						{
							switch (font) {
								case 1:
									{
										charlength = WriteLine("BBBBBBBBBBBBBBBBB   ");
										charlength = WriteLine("B::::::::::::::::B  ");
										charlength = WriteLine("B::::::BBBBBB:::::B ");
										charlength = WriteLine("BB:::::B     B:::::B");
										charlength = WriteLine("  B::::B     B:::::B");
										charlength = WriteLine("  B::::B     B:::::B");
										charlength = WriteLine("  B::::BBBBBB:::::B ");
										charlength = WriteLine("  B:::::::::::::BB  ");
										charlength = WriteLine("  B::::BBBBBB:::::B ");
										charlength = WriteLine("  B::::B     B:::::B");
										charlength = WriteLine("  B::::B     B:::::B");
										charlength = WriteLine("  B::::B     B:::::B");
										charlength = WriteLine("BB:::::BBBBBB::::::B");
										charlength = WriteLine("B:::::::::::::::::B ");
										charlength = WriteLine("B::::::::::::::::B  ");
										charlength = WriteLine("BBBBBBBBBBBBBBBBB   ");
										break;
									}
							}
							break;
						}
					case 'C':
						{
							switch (font) {
								case 1:
									{
										charlength = WriteLine("        CCCCCCCCCCCCC");
										charlength = WriteLine("     CCC::::::::::::C");
										charlength = WriteLine("   CC:::::::::::::::C");
										charlength = WriteLine("  C:::::CCCCCCCC::::C");
										charlength = WriteLine(" C:::::C       CCCCCC");
										charlength = WriteLine("C:::::C              ");
										charlength = WriteLine("C:::::C              ");
										charlength = WriteLine("C:::::C              ");
										charlength = WriteLine("C:::::C              ");
										charlength = WriteLine("C:::::C              ");
										charlength = WriteLine("C:::::C              ");
										charlength = WriteLine(" C:::::C       CCCCCC");
										charlength = WriteLine("  C:::::CCCCCCCC::::C");
										charlength = WriteLine("   CC:::::::::::::::C");
										charlength = WriteLine("     CCC::::::::::::C");
										charlength = WriteLine("        CCCCCCCCCCCCC");
										break;
									}
							}
							break;
						}
					case 'D':
						{
							switch (font) {
								case 1:
									{
										charlength = WriteLine("DDDDDDDDDDDDD        ");
										charlength = WriteLine("D::::::::::::DDD     ");
										charlength = WriteLine("D:::::::::::::::DD   ");
										charlength = WriteLine("DDD:::::DDDDD:::::D  ");
										charlength = WriteLine("  D:::::D    D:::::D ");
										charlength = WriteLine("  D:::::D     D:::::D");
										charlength = WriteLine("  D:::::D     D:::::D");
										charlength = WriteLine("  D:::::D     D:::::D");
										charlength = WriteLine("  D:::::D     D:::::D");
										charlength = WriteLine("  D:::::D     D:::::D");
										charlength = WriteLine("  D:::::D     D:::::D");
										charlength = WriteLine("  D:::::D    D:::::D ");
										charlength = WriteLine("DDD:::::DDDDD:::::D  ");
										charlength = WriteLine("D:::::::::::::::DD   ");
										charlength = WriteLine("D::::::::::::DDD     ");
										charlength = WriteLine("DDDDDDDDDDDDD        ");
										break;
									}
							}
							break;
						}
					case 'E':
						{
							switch (font) {
								case 1:
									{
										charlength = WriteLine("EEEEEEEEEEEEEEEEEEEEEE");
										charlength = WriteLine("E::::::::::::::::::::E");
										charlength = WriteLine("E::::::::::::::::::::E");
										charlength = WriteLine("EE::::::EEEEEEEEE::::E");
										charlength = WriteLine("  E:::::E       EEEEEE");
										charlength = WriteLine("  E:::::E             ");
										charlength = WriteLine("  E::::::EEEEEEEEEE   ");
										charlength = WriteLine("  E:::::::::::::::E   ");
										charlength = WriteLine("  E:::::::::::::::E   ");
										charlength = WriteLine("  E::::::EEEEEEEEEE   ");
										charlength = WriteLine("  E:::::E             ");
										charlength = WriteLine("  E:::::E       EEEEEE");
										charlength = WriteLine("EE::::::EEEEEEEE:::::E");
										charlength = WriteLine("E::::::::::::::::::::E");
										charlength = WriteLine("E::::::::::::::::::::E");
										charlength = WriteLine("EEEEEEEEEEEEEEEEEEEEEE");
										break;
									}
							}
							break;
						}
					case 'F':
						{
							switch (font) {
								case 1:
									{
										charlength = WriteLine("FFFFFFFFFFFFFFFFFFFFFF");
										charlength = WriteLine("F::::::::::::::::::::F");
										charlength = WriteLine("F::::::::::::::::::::F");
										charlength = WriteLine("FF::::::FFFFFFFFF::::F");
										charlength = WriteLine("  F:::::F       FFFFFF");
										charlength = WriteLine("  F:::::F             ");
										charlength = WriteLine("  F::::::FFFFFFFFFF   ");
										charlength = WriteLine("  F:::::::::::::::F   ");
										charlength = WriteLine("  F:::::::::::::::F   ");
										charlength = WriteLine("  F::::::FFFFFFFFFF   ");
										charlength = WriteLine("  F:::::F             ");
										charlength = WriteLine("  F:::::F             ");
										charlength = WriteLine("FF:::::::FF           ");
										charlength = WriteLine("F::::::::FF           ");
										charlength = WriteLine("F::::::::FF           ");
										charlength = WriteLine("FFFFFFFFFFF           ");
										break;
									}
							}
							break;
						}
					case 'G':
						{
							switch (font) {
								case 1:
									{
										charlength = WriteLine("        GGGGGGGGGGGGG");
										charlength = WriteLine("     GGG::::::::::::G");
										charlength = WriteLine("   GG:::::::::::::::G");
										charlength = WriteLine("  G:::::GGGGGGGG::::G");
										charlength = WriteLine(" G:::::G       GGGGGG");
										charlength = WriteLine("G:::::G              ");
										charlength = WriteLine("G:::::G              ");
										charlength = WriteLine("G:::::G    GGGGGGGGGG");
										charlength = WriteLine("G:::::G    G::::::::G");
										charlength = WriteLine("G:::::G    GGGGG::::G");
										charlength = WriteLine("G:::::G        G::::G");
										charlength = WriteLine(" G:::::G       G::::G");
										charlength = WriteLine("  G:::::GGGGGGGG::::G");
										charlength = WriteLine("   GG:::::::::::::::G");
										charlength = WriteLine("     GGG::::::GGG:::G");
										charlength = WriteLine("        GGGGGG   GGGG");
										break;
									}
							}
							break;
						}
					case 'H':
						{
							switch (font) {
								case 1:
									{
										charlength = WriteLine("HHHHHHHHH     HHHHHHHHH");
										charlength = WriteLine("H:::::::H     H:::::::H");
										charlength = WriteLine("H:::::::H     H:::::::H");
										charlength = WriteLine("HH::::::H     H::::::HH");
										charlength = WriteLine("  H:::::H     H:::::H  ");
										charlength = WriteLine("  H:::::H     H:::::H  ");
										charlength = WriteLine("  H::::::HHHHH::::::H  ");
										charlength = WriteLine("  H:::::::::::::::::H  ");
										charlength = WriteLine("  H:::::::::::::::::H  ");
										charlength = WriteLine("  H::::::HHHHH::::::H  ");
										charlength = WriteLine("  H:::::H     H:::::H  ");
										charlength = WriteLine("  H:::::H     H:::::H  ");
										charlength = WriteLine("HH::::::H     H::::::HH");
										charlength = WriteLine("H:::::::H     H:::::::H");
										charlength = WriteLine("H:::::::H     H:::::::H");
										charlength = WriteLine("HHHHHHHHH     HHHHHHHHH");
										break;
									}

							}
							break;
						}
					case 'I':
						{
							switch (font) {
								case 1:
									{
										charlength = WriteLine("IIIIIIIIII");
										charlength = WriteLine("I::::::::I");
										charlength = WriteLine("I::::::::I");
										charlength = WriteLine("II::::::II");
										charlength = WriteLine("  I::::I  ");
										charlength = WriteLine("  I::::I  ");
										charlength = WriteLine("  I::::I  ");
										charlength = WriteLine("  I::::I  ");
										charlength = WriteLine("  I::::I  ");
										charlength = WriteLine("  I::::I  ");
										charlength = WriteLine("  I::::I  ");
										charlength = WriteLine("  I::::I  ");
										charlength = WriteLine("II::::::II");
										charlength = WriteLine("I::::::::I");
										charlength = WriteLine("I::::::::I");
										charlength = WriteLine("IIIIIIIIII");
										break;
									}

							}
							break;
						}
					case 'J':
						{
							switch (font) {
								case 1:
									{
										charlength = WriteLine("          JJJJJJJJJJJ");
										charlength = WriteLine("          J:::::::::J");
										charlength = WriteLine("          J:::::::::J");
										charlength = WriteLine("          JJ:::::::JJ");
										charlength = WriteLine("            J:::::J  ");
										charlength = WriteLine("            J:::::J  ");
										charlength = WriteLine("            J:::::J  ");
										charlength = WriteLine("            J:::::j  ");
										charlength = WriteLine("            J:::::J  ");
										charlength = WriteLine("JJJJJJJ     J:::::J  ");
										charlength = WriteLine("J:::::J     J:::::J  ");
										charlength = WriteLine("J::::::J   J::::::J  ");
										charlength = WriteLine("J:::::::JJJ:::::::J  ");
										charlength = WriteLine(" JJ:::::::::::::JJ   ");
										charlength = WriteLine("   JJ:::::::::JJ     ");
										charlength = WriteLine("     JJJJJJJJJ       ");
										break;
									}

							}
							break;
						}
					case 'K':
						{
							switch (font) {
								case 1:
									{
										charlength = WriteLine("KKKKKKKKK    KKKKKKK");
										charlength = WriteLine("K:::::::K    K:::::K");
										charlength = WriteLine("K:::::::K    K:::::K");
										charlength = WriteLine("K:::::::K   K::::::K");
										charlength = WriteLine("KK::::::K  K:::::KKK");
										charlength = WriteLine("  K:::::K K:::::K   ");
										charlength = WriteLine("  K::::::K:::::K    ");
										charlength = WriteLine("  K:::::::::::K     ");
										charlength = WriteLine("  K:::::::::::K     ");
										charlength = WriteLine("  K::::::K:::::K    ");
										charlength = WriteLine("  K:::::K K:::::K   ");
										charlength = WriteLine("KK::::::K  K:::::KKK");
										charlength = WriteLine("K:::::::K   K::::::K");
										charlength = WriteLine("K:::::::K    K:::::K");
										charlength = WriteLine("K:::::::K    K:::::K");
										charlength = WriteLine("KKKKKKKKK    KKKKKKK");
										break;
									}

							}
							break;
						}
					case 'L':
						{
							switch (font) {
								case 1:
									{
										charlength = WriteLine("LLLLLLLLLLL             ");
										charlength = WriteLine("L:::::::::L             ");
										charlength = WriteLine("L:::::::::L             ");
										charlength = WriteLine("LL:::::::LL             ");
										charlength = WriteLine("  L:::::L               ");
										charlength = WriteLine("  L:::::L               ");
										charlength = WriteLine("  L:::::L               ");
										charlength = WriteLine("  L:::::L               ");
										charlength = WriteLine("  L:::::L               ");
										charlength = WriteLine("  L:::::L               ");
										charlength = WriteLine("  L:::::L               ");
										charlength = WriteLine("  L:::::L         LLLLLL");
										charlength = WriteLine("LL:::::::LLLLLLLLL:::::L");
										charlength = WriteLine("L::::::::::::::::::::::L");
										charlength = WriteLine("L::::::::::::::::::::::L");
										charlength = WriteLine("LLLLLLLLLLLLLLLLLLLLLLLL");
										break;
									}

							}
							break;
						}
					case 'M':
						{
							switch (font) {
								case 1:
									{
										charlength = WriteLine("MMMMMMMM               MMMMMMMM");
										charlength = WriteLine("M:::::::M             M:::::::M");
										charlength = WriteLine("M::::::::M           M::::::::M");
										charlength = WriteLine("M:::::::::M         M:::::::::M");
										charlength = WriteLine("M::::::::::M       M::::::::::M");
										charlength = WriteLine("M:::::::::::M     M:::::::::::M");
										charlength = WriteLine("M:::::::M::::M   M::::M:::::::M");
										charlength = WriteLine("M::::::M M::::M M::::M M::::::M");
										charlength = WriteLine("M::::::M  M::::M::::M  M::::::M");
										charlength = WriteLine("M::::::M   M:::::::M   M::::::M");
										charlength = WriteLine("M::::::M    M:::::M    M::::::M");
										charlength = WriteLine("M::::::M     MMMMM     M::::::M");
										charlength = WriteLine("M::::::M               M::::::M");
										charlength = WriteLine("M::::::M               M::::::M");
										charlength = WriteLine("M::::::M               M::::::M");
										charlength = WriteLine("MMMMMMMM               MMMMMMMM");
										break;
									}

							}
							break;
						}
					case 'N':
						{
							switch (font) {
								case 1:
									{
										charlength = WriteLine("NNNNNNNN        NNNNNNNN");
										charlength = WriteLine("N:::::::N       N::::::N");
										charlength = WriteLine("N::::::::N      N::::::N");
										charlength = WriteLine("N:::::::::N     N::::::N");
										charlength = WriteLine("N::::::::::N    N::::::N");
										charlength = WriteLine("N:::::::::::N   N::::::N");
										charlength = WriteLine("N:::::::N::::N  N::::::N");
										charlength = WriteLine("N::::::N N::::N N::::::N");
										charlength = WriteLine("N::::::N  N::::N:::::::N");
										charlength = WriteLine("N::::::N   N:::::::::::N");
										charlength = WriteLine("N::::::N    N::::::::::N");
										charlength = WriteLine("N::::::N     N:::::::::N");
										charlength = WriteLine("N::::::N      N::::::::N");
										charlength = WriteLine("N::::::N       N:::::::N");
										charlength = WriteLine("N::::::N        N::::::N");
										charlength = WriteLine("NNNNNNNN         NNNNNNN");
										break;
									}

							}
							break;
						}
					case 'O':
						{
							switch (font) {
								case 1:
									{
										charlength = WriteLine("     OOOOOOOOO     ");
										charlength = WriteLine("   OO:::::::::OO   ");
										charlength = WriteLine(" OO:::::::::::::OO ");
										charlength = WriteLine("O:::::::OOO:::::::O");
										charlength = WriteLine("O::::::O   O::::::O");
										charlength = WriteLine("O:::::O     O:::::O");
										charlength = WriteLine("O:::::O     O:::::O");
										charlength = WriteLine("O:::::O     O:::::O");
										charlength = WriteLine("O:::::O     O:::::O");
										charlength = WriteLine("O:::::O     O:::::O");
										charlength = WriteLine("O:::::O     O:::::O");
										charlength = WriteLine("O::::::O   O::::::O");
										charlength = WriteLine("O:::::::OOO:::::::O");
										charlength = WriteLine(" OO:::::::::::::OO ");
										charlength = WriteLine("   OO:::::::::OO   ");
										charlength = WriteLine("     OOOOOOOOO     ");
										break;
									}

							}
							break;
						}
					case 'P':
						{
							switch (font) {
								case 1:
									{
										charlength = WriteLine("PPPPPPPPPPPPPPPPP   ");
										charlength = WriteLine("P::::::::::::::::P  ");
										charlength = WriteLine("P::::::PPPPPP:::::P ");
										charlength = WriteLine("PP:::::P     P:::::P");
										charlength = WriteLine("  P::::P     P:::::P");
										charlength = WriteLine("  P::::P     P:::::P");
										charlength = WriteLine("  P::::PPPPPP:::::P ");
										charlength = WriteLine("  P:::::::::::::PP  ");
										charlength = WriteLine("  P::::PPPPPPPPP    ");
										charlength = WriteLine("  P::::P            ");
										charlength = WriteLine("  P::::P            ");
										charlength = WriteLine("  P::::P            ");
										charlength = WriteLine("PP::::::PP          ");
										charlength = WriteLine("P::::::::P          ");
										charlength = WriteLine("P::::::::P          ");
										charlength = WriteLine("PPPPPPPPPP          ");
										break;
									}

							}
							break;
						}
					case 'Q':
						{
							switch (font) {
								case 1:
									{
										charlength = WriteLine("     QQQQQQQQQ      ");
										charlength = WriteLine("   QQ:::::::::QQ    ");
										charlength = WriteLine(" QQ:::::::::::::QQ  ");
										charlength = WriteLine("Q:::::::QQQ:::::::Q ");
										charlength = WriteLine("Q::::::O   Q::::::Q ");
										charlength = WriteLine("Q:::::O     Q:::::Q ");
										charlength = WriteLine("Q:::::O     Q:::::Q ");
										charlength = WriteLine("Q:::::O     Q:::::Q ");
										charlength = WriteLine("Q:::::O     Q:::::Q ");
										charlength = WriteLine("Q:::::O     Q:::::Q ");
										charlength = WriteLine("Q:::::O  QQQQ:::::Q ");
										charlength = WriteLine("Q::::::O Q::::::::Q ");
										charlength = WriteLine("Q:::::::QQ::::::::Q ");
										charlength = WriteLine(" QQ::::::::::::::Q  ");
										charlength = WriteLine("   QQ:::::::::::Q   ");
										charlength = WriteLine("     QQQQQQQQ::::QQ ");
										charlength = WriteLine("             Q:::::Q");
										charlength = WriteLine("              QQQQQQ");
										break;
									}

							}
							break;
						}
					case 'R':
						{
							switch (font) {
								case 1:
									{
										charlength = WriteLine("RRRRRRRRRRRRRRRRR   ");
										charlength = WriteLine("R::::::::::::::::R  ");
										charlength = WriteLine("R::::::RRRRRR:::::R ");
										charlength = WriteLine("RR:::::R     R:::::R");
										charlength = WriteLine("  R::::R     R:::::R");
										charlength = WriteLine("  R::::R     R:::::R");
										charlength = WriteLine("  R::::RRRRRR:::::R ");
										charlength = WriteLine("  R:::::::::::::RR  ");
										charlength = WriteLine("  R::::RRRRRR:::::R ");
										charlength = WriteLine("  R::::R     R:::::R");
										charlength = WriteLine("  R::::R     R:::::R");
										charlength = WriteLine("  R::::R     R:::::R");
										charlength = WriteLine("RR:::::R     R:::::R");
										charlength = WriteLine("R::::::R     R:::::R");
										charlength = WriteLine("R::::::R     R:::::R");
										charlength = WriteLine("RRRRRRRR     RRRRRRR");
										break;
									}

							}
							break;
						}
					case 'S':
						{
							switch (font) {
								case 1:
									{
										charlength = WriteLine("   SSSSSSSSSSSSSSS ");
										charlength = WriteLine(" SS:::::::::::::::S");
										charlength = WriteLine("S:::::SSSSSS::::::S");
										charlength = WriteLine("S:::::S     SSSSSSS");
										charlength = WriteLine("S:::::S            ");
										charlength = WriteLine("S:::::S            ");
										charlength = WriteLine(" S::::SSSS         ");
										charlength = WriteLine("  SS::::::SSSSS    ");
										charlength = WriteLine("    SSS::::::::SS  ");
										charlength = WriteLine("       SSSSSS::::S ");
										charlength = WriteLine("            S:::::S");
										charlength = WriteLine("            S:::::S");
										charlength = WriteLine("SSSSSSS     S:::::S");
										charlength = WriteLine("S::::::SSSSSS:::::S");
										charlength = WriteLine("S:::::::::::::::SS ");
										charlength = WriteLine(" SSSSSSSSSSSSSSS   ");
										break;
									}

							}
							break;
						}
					case 'T':
						{
							switch (font) {
								case 1:
									{
										charlength = WriteLine("TTTTTTTTTTTTTTTTTTTTTTT");
										charlength = WriteLine("T:::::::::::::::::::::T");
										charlength = WriteLine("T:::::::::::::::::::::T");
										charlength = WriteLine("T:::::TT:::::::TT:::::T");
										charlength = WriteLine("TTTTTT  T:::::T  TTTTTT");
										charlength = WriteLine("        T:::::T        ");
										charlength = WriteLine("        T:::::T        ");
										charlength = WriteLine("        T:::::T        ");
										charlength = WriteLine("        T:::::T        ");
										charlength = WriteLine("        T:::::T        ");
										charlength = WriteLine("        T:::::T        ");
										charlength = WriteLine("        T:::::T        ");
										charlength = WriteLine("      TT:::::::TT      ");
										charlength = WriteLine("      T:::::::::T      ");
										charlength = WriteLine("      T:::::::::T      ");
										charlength = WriteLine("      TTTTTTTTTTT      ");
										break;
									}

							}
							break;
						}
					case 'U':
						{
							switch (font) {
								case 1:
									{
										charlength = WriteLine("UUUUUUUU     UUUUUUUU");
										charlength = WriteLine("U::::::U     U::::::U");
										charlength = WriteLine("U::::::U     U::::::U");
										charlength = WriteLine("UU:::::U     U:::::UU");
										charlength = WriteLine(" U:::::U     U:::::U ");
										charlength = WriteLine(" U:::::D     D:::::U ");
										charlength = WriteLine(" U:::::D     D:::::U ");
										charlength = WriteLine(" U:::::D     D:::::U ");
										charlength = WriteLine(" U:::::D     D:::::U ");
										charlength = WriteLine(" U:::::D     D:::::U ");
										charlength = WriteLine(" U:::::D     D:::::U ");
										charlength = WriteLine(" U::::::U   U::::::U ");
										charlength = WriteLine(" U:::::::UUU:::::::U ");
										charlength = WriteLine("  UU:::::::::::::UU  ");
										charlength = WriteLine("    UU:::::::::UU    ");
										charlength = WriteLine("      UUUUUUUUU      ");
										break;
									}

							}
							break;
						}
					case 'V':
						{
							switch (font) {
								case 1:
									{
										charlength = WriteLine("VVVVVVVV           VVVVVVVV");
										charlength = WriteLine("V::::::V           V::::::V");
										charlength = WriteLine("V::::::V           V::::::V");
										charlength = WriteLine("V::::::V           V::::::V");
										charlength = WriteLine(" V:::::V           V:::::V ");
										charlength = WriteLine("  V:::::V         V:::::V  ");
										charlength = WriteLine("   V:::::V       V:::::V   ");
										charlength = WriteLine("    V:::::V     V:::::V    ");
										charlength = WriteLine("     V:::::V   V:::::V     ");
										charlength = WriteLine("      V:::::V V:::::V      ");
										charlength = WriteLine("       V:::::V:::::V       ");
										charlength = WriteLine("        V:::::::::V        ");
										charlength = WriteLine("         V:::::::V         ");
										charlength = WriteLine("          V:::::V          ");
										charlength = WriteLine("           V:::V           ");
										charlength = WriteLine("            VVV            ");
										break;
									}

							}
							break;
						}
					case 'W':
						{
							switch (font) {
								case 1:
									{
										charlength = WriteLine("WWWWWWWW                           WWWWWWWW");
										charlength = WriteLine("W::::::W                           W::::::W");
										charlength = WriteLine("W::::::W                           W::::::W");
										charlength = WriteLine("W::::::W                           W::::::W");
										charlength = WriteLine(" W:::::W           WWWWW           W:::::W ");
										charlength = WriteLine("  W:::::W         W:::::W         W:::::W  ");
										charlength = WriteLine("   W:::::W       W:::::::W       W:::::W   ");
										charlength = WriteLine("    W:::::W     W:::::::::W     W:::::W    ");
										charlength = WriteLine("     W:::::W   W:::::W:::::W   W:::::W     ");
										charlength = WriteLine("      W:::::W W:::::W W:::::W W:::::W      ");
										charlength = WriteLine("       W:::::W:::::W   W:::::W:::::W       ");
										charlength = WriteLine("        W:::::::::W     W:::::::::W        ");
										charlength = WriteLine("         W:::::::W       W:::::::W         ");
										charlength = WriteLine("          W:::::W         W:::::W          ");
										charlength = WriteLine("           W:::W           W:::W           ");
										charlength = WriteLine("            WWW             WWW            ");
										break;
									}

							}
							break;
						}
					case 'X':
						{
							switch (font) {
								case 1:
									{
										charlength = WriteLine("XXXXXXX       XXXXXXX");
										charlength = WriteLine("X:::::X       X:::::X");
										charlength = WriteLine("X:::::X       X:::::X");
										charlength = WriteLine("X::::::X     X::::::X");
										charlength = WriteLine("XXX:::::X   X:::::XXX");
										charlength = WriteLine("   X:::::X X:::::X   ");
										charlength = WriteLine("    X:::::X:::::X    ");
										charlength = WriteLine("     X:::::::::X     ");
										charlength = WriteLine("     X:::::::::X     ");
										charlength = WriteLine("    X:::::X:::::X    ");
										charlength = WriteLine("   X:::::X X:::::X   ");
										charlength = WriteLine("XXX:::::X   X:::::XXX");
										charlength = WriteLine("X::::::X     X::::::X");
										charlength = WriteLine("X:::::X       X:::::X");
										charlength = WriteLine("X:::::X       X:::::X");
										charlength = WriteLine("XXXXXXX       XXXXXXX");
										break;
									}

							}
							break;
						}
					case 'Y':
						{
							switch (font) {
								case 1:
									{
										charlength = WriteLine("YYYYYYY       YYYYYYY");
										charlength = WriteLine("Y:::::Y       Y:::::Y");
										charlength = WriteLine("Y:::::Y       Y:::::Y");
										charlength = WriteLine("Y::::::Y     Y::::::Y");
										charlength = WriteLine("YYY:::::Y   Y:::::YYY");
										charlength = WriteLine("   Y:::::Y Y:::::Y   ");
										charlength = WriteLine("    Y:::::Y:::::Y    ");
										charlength = WriteLine("     Y:::::::::Y     ");
										charlength = WriteLine("      Y:::::::Y      ");
										charlength = WriteLine("       Y:::::Y       ");
										charlength = WriteLine("       Y:::::Y       ");
										charlength = WriteLine("       Y:::::Y       ");
										charlength = WriteLine("       Y:::::Y       ");
										charlength = WriteLine("    YYYY:::::YYYY    ");
										charlength = WriteLine("    Y:::::::::::Y    ");
										charlength = WriteLine("    YYYYYYYYYYYYY    ");
										break;
									}

							}
							break;
						}
					case 'Z':
						{
							switch (font) {
								case 1:
									{
										charlength = WriteLine("ZZZZZZZZZZZZZZZZZZZ");
										charlength = WriteLine("Z:::::::::::::::::Z");
										charlength = WriteLine("Z:::::::::::::::::Z");
										charlength = WriteLine("Z:::ZZZZZZZZ:::::Z ");
										charlength = WriteLine("ZZZZZ     Z:::::Z  ");
										charlength = WriteLine("        Z:::::Z    ");
										charlength = WriteLine("       Z:::::Z     ");
										charlength = WriteLine("      Z:::::Z      ");
										charlength = WriteLine("     Z:::::Z       ");
										charlength = WriteLine("    Z:::::Z        ");
										charlength = WriteLine("   Z:::::Z         ");
										charlength = WriteLine("ZZZ:::::Z     ZZZZZ");
										charlength = WriteLine("Z::::::ZZZZZZZZ:::Z");
										charlength = WriteLine("Z:::::::::::::::::Z");
										charlength = WriteLine("Z:::::::::::::::::Z");
										charlength = WriteLine("ZZZZZZZZZZZZZZZZZZZ");
										break;
									}

							}
							break;
						}
					case ' ':
						{
							switch (font) {
								case 1:
									{
										Console.CursorLeft = Console.CursorLeft + (charlength / 2);
										break;
									}
							}
							break;
						}
					default :
						{
							Console.Write(text[i]);
							break;
						}
				}
				Console.CursorLeft = Console.CursorLeft + charlength + 1;
				Console.CursorTop = topcursor;
			}
		
		}
		
		public void Game(char border)
		{
			for (int i = 0; i < Console.BufferWidth - 1; i++) {
				Console.SetCursorPosition(i, 1);
				Console.Write(border);
				Console.SetCursorPosition(i, Console.BufferHeight - 1);
				Console.Write(border);
			}
			for (int i = 1; i < Console.BufferHeight - 1; i++) {
				Console.SetCursorPosition(0, i);
				Console.Write(border);
				Console.SetCursorPosition(Console.BufferWidth - 1, i);
				Console.Write(border);
			}
		}
		
		int WriteLine(string text)
		{
			int cursorposition = Console.CursorLeft;
			Console.WriteLine(text);
			Console.CursorLeft = cursorposition;
			return text.Length;
		}
	}
}

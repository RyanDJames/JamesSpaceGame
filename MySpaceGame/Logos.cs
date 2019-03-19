using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySpaceGame
{
    // all ASCII art in this class
    class Logos
    {
        //Game name logo
        public static void logo()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string title = @" 
╔═╗╔═╗╔═╗╔═╗╔═╗  ╔═╗╔╦╗╦  ╦╔═╗╔╗╔╔╦╗╦ ╦╦═╗╔═╗
╚═╗╠═╝╠═╣║  ║╣   ╠═╣ ║║╚╗╔╝║╣ ║║║ ║ ║ ║╠╦╝║╣ 
╚═╝╩  ╩ ╩╚═╝╚═╝  ╩ ╩═╩╝ ╚╝ ╚═╝╝╚╝ ╩ ╚═╝╩╚═╚═╝
 ";

            Console.WriteLine(title);
            Console.ResetColor();
        }

        //spaceshipt ascii logo
        public static void spaceshiplogo()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            string spaceshipascii = @"
          __,----.____
      _,-' ___// _,','(=
    ,'\        /,' / ~
  ,'\        /_/  /           ____
 /-        /_ /--|        ,--'   ,`-
/-        /__/ []|_______/     ,'- /
|         /  |  /.........\  ,'-,-|
|]      _|,---,  __________ |--|  |
|  []  [__    |] __________ |--|  |
|]       |`---'  .........  |--|  |
|         \__|   \_______ /  `.-`-|
\-        \ _\ []|       \     `.- \
 \-        \ _\--|        `--.____,-
  `./        \_\  \
    `./    ____\`. \ _
       `-.__  \\  `_`,(=
            `----'~
       ";



            Console.WriteLine(spaceshipascii);
            Console.ResetColor();
        }

        //planet earth ascii
        public static void earthlogo()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            string earthascii = @"      
        _____
    ,-:` \;',`'-, 
  .'-;_,;  ':-;_,'.
 /;   '/    ,  _`.-\
| '`. (`     /` ` \`|
|:.  `\`-.   \_   / |
|     (   `,  .`\ ;'|
 \     | .'     `-'/
  `.   ;/        .'
    `'-._____.";
            Console.WriteLine(earthascii);
            Console.ResetColor();
        }

        //earth market ascii
        public static void earthmarket()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            string earthmarketascii = @"             
                             ^                         
                _______     ^^^                       
               |xxxxxxx|  _^^^^^_                      
               |xxxxxxx| | [][]  |                     
            ______xxxxx| |[][][] |                     
           |++++++|xxxx| | [][][]|                     
           |++++++|xxxx| |[][][] |                     
           |++++++|_________ [][]|                     
           |++++++|=|=|=|=|=| [] |                     
           |++++++|=|=|=|=|=|[][]|                    
   ________|++HH++|  _^^^^__|   _|________             ";
            Console.Write(earthmarketascii);
            Console.ResetColor();
        }

        //planet alpha centauri ascii
        public static void aplhacentaurilogo()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            string aplhaascii = @"        ~+

                 *       +
           '                  |
       ()    .-.,=;``''-=.    - o -
             '=/_       \     |
          *   | '=._    |
               \     `=./`,        '
            .   '=.__.=' `= '      *
   + +
        O * '       .";
            Console.WriteLine(aplhaascii);
            Console.ResetColor();
        }

        //alphs centauri market
        public static void alphacentarimarketlgo()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            string alphamarketascii = @"
                       !
                      /^\
                    /     \
 |               | (       ) |               |
/^\  |          /^\ \     / /^\          |  /^\
|O| /^\        (   )|-----|(   )        /^\ |O|
|_| |-|    |^-^|---||-----||---|^-^|    |-| |_|
|O| |O|    |/^\|/^\||  |  ||/^\|/^\|    |O| |O|
|-| |-|    ||_|||_||| /^\ |||_|||_||    |-| |-|
|O| |O|    |/^\|/^\||(   )||/^\|/^\|    |O| |O|
|-| |-|    ||_|||_||||   ||||_|||_||    |-| |-|
|O| |_|----|___|___|||___|||___|_|_|    |O| |O|
|_|                                         |_|
   /_______________________________________\
__|_______________________________________|___|";
            Console.WriteLine(alphamarketascii);
            Console.ResetColor();
        }

        //planet krypton ascii
        public static void planetkryptonlgo()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            string kryptonplanetascii = @"
                     .::.
                  .:'  .:
        ,MMM8&&&.:'   .:'
       MMMMM88&&&&  .:'
      MMMMM88&&&&&&:'
      MMMMM88&&&&&&
    .:MMMMM88&&&&&&
  .:'  MMMMM88&&&&
.:'   .:'MMM8&&&'
:'  .:'
'::'  ";
            Console.WriteLine(kryptonplanetascii);
            Console.ResetColor();
        }

        //planet kryptoon market
        public static void kryptonmarkelogo()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            string kryptonmarketascii = @"
                              A
                             /_\
                     :      /_|_\
                    :::    /|__|_\
                   ::.::  /|_|__|_\      :
                  ::.:.::/__|_|__|_\    :.:
                 :..:.:./_|__|__|__|\  :.:.:
                :.:..:./|__|___|__|__\:.:..::
 ..............::..:../__|___|__|___|_\..:..::................
    ..........:..:..:/_|__|___|___|___|\:..:..::::::::::::::::::::
::::::::::::::.:..:./___|___|___|___|___\....................
        .........../..!...!...!...!...!..\...............";
            Console.WriteLine(kryptonmarketascii);
            Console.ResetColor();
        }

        //travelling through space logo1
        public static void travelinglogo1()
        {
          
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("::CAUTION::");
            Console.WriteLine("WARP DRIVE ACTIVATING");
            Console.WriteLine("::CAUTION::");
            string travelascii = @"
                                       _,'/
                                  _.-''._:
                          ,-:`-.-'    .:.|
                         ;-.''       .::.|
          _..------.._  / (:.       .:::.|
       ,'.   .. . .  .`/  : :.     .::::.|
     ,'. .    .  .   ./    \ ::. .::::::.|
   ,'. .  .    .   . /      `.,,::::::::.;\
  /  .            . /       ,',';_::::::,:_:
 / . .  .   .      /      ,',','::`--'':;._;
: .             . /     ,',',':::::::_:'_,'
|..  .   .   .   /    ,',','::::::_:'_,'
|.              /,-. /,',':::::_:'_,'
| ..    .    . /) /-:/,'::::_:',-'
: . .     .   // / ,'):::_:',' ;
 \ .   .     // /,' /,-.','  ./
  \ . .  `::./,// ,'' ,'   . /
   `. .   . `;;;,/_.'' . . ,'
    ,`. .   :;;' `:.  .  ,'
   /   `-._,'  ..  ` _.-'
  (     _,'``------''  
   `--''";
            Console.WriteLine(travelascii);
            
        }

        //travelling through space logo2
        public static void travelinglogo2()
        {

            string wormhole = @"
     ________________________________         
    /                                --_          
   /      .  |  .                       \          
  /      : \ | / :                       \         
 /        '-___-'                         \      
/_________________________________________ \      
     _______| |________________________-----\ 
    /       F J                              \ 
   /       F   J                              \
  /      :'     ':                            /
 /        '-___-'                            / 
/_________________________________________-- ";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("::CAUTION::");
            Console.WriteLine("WARP DRIVE ACTIVATING");
            Console.WriteLine("::CAUTION::");
            Console.WriteLine(wormhole);
            Console.ResetColor();
        }
    }
}

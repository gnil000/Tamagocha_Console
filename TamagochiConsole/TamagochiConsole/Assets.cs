﻿using System;

namespace TamagochiConsole
{
    public delegate string draw();

    public static class Assets
    {
        public static draw[] arrDraw = new[] {
            new draw(lookAround),
            new draw(looksInCorner),
            new draw(rest)
        };


        //+-+-+-+-+-+-+-+-+-+-+ЕСТЬ В МАССИВЕ ДЕЛЕГАТОВ+-+-+-+-+-+-+-+-+-+-+-+

        public static string lookAround()
        {
            string cat = "                                               .--.\r\n                                               `.  \\\r\n                                                 \\  \\\r\n                                                  .  \\\r\n                                                  :   .\r\n                                                  |    .\r\n                                                  |    :\r\n                                                  |    |\r\n  ..._  ___                                       |    |\r\n `.\"\".`''''\"\"--..___                              |    |\r\n ,-\\  \\             \"\"-...__         _____________/    |\r\n / ` \" '                    `\"\"\"\"\"\"\"\"                  .\r\n \\                                                      L\r\n (>                                                      \\\r\n/                                                         \\\r\n\\_    ___..---.                                            L\r\n  `--'         '.                                           \\\r\n                 .                                           \\_\r\n                _/`.                                           `.._\r\n             .'     -.                                             `.\r\n            /     __.-Y     /''''''-...___,...--------.._            |\r\n           /   _.\"    |    /                ' .      \\   '---..._    |\r\n          /   /      /    /                _,. '    ,/           |   |\r\n          \\_,'     _.'   /              /''     _,-'            _|   |\r\n                  '     /               `-----''               /     |\r\n                  `...-'                                       `...-'";
            Console.WriteLine(cat);
            return "осматривается";
        }

        public static string looksInCorner() //смотрит в угол
        {
            string cat = " ,_     _\r\n |\\\\_,-~/\r\n / _  _ |    ,--.\r\n(  @  @ )   / ,-'\r\n \\  _T_/-._( (\r\n /         `. \\\r\n|         _  \\ |\r\n \\ \\ ,  /      |\r\n  || |-_\\__   /\r\n ((_/`(____,-'\r\n";
            //string cat = "       ,\r\n       \\`-._           __\r\n        \\\\  `-..____,.'  `.\r\n         :`.         /    \\`.\r\n         :  )       :      : \\\r\n          ;'        '   ;  |  :\r\n          )..      .. .:.`.;  :\r\n         /::...  .:::...   ` ;\r\n         ; _ '    __        /:\\\r\n         `:o>   /\\o_>      ;:. `.\r\n        `-`.__ ;   __..--- /:.   \\\r\n        === \\_/   ;=====_.':.     ;\r\n         ,/'`--'...`--....        ;\r\n              ;                    ;\r\n            .'                      ;\r\n          .'                        ;\r\n        .'     ..     ,      .       ;\r\n       :       ::..  /      ;::.     |\r\n      /      `.;::.  |       ;:..    ;\r\n     :         |:.   :       ;:.    ;\r\n     :         ::     ;:..   |.    ;\r\n      :       :;      :::....|     |\r\n      /\\     ,/ \\      ;:::::;     ;\r\n    .:. \\:..|    :     ; '.--|     ;\r\n   ::.  :''  `-.,,;     ;'   ;     ;\r\n.-'. _.'\\      / `;      \\,__:      \\\r\n`---'    `----'   ;      /    \\,.,,,/\r\n                   `----`            ";
            Console.WriteLine(cat);
            return "иступлённо смотрит в угол. Вас это пугает...";
        }

        public static string rest()
        {
            string cat = "\r\n           __..--''``---....___   _..._    __\r\n /// //_.-'    .-/\";  `        ``<._  ``.''_ `. / // /\r\n///_.-' _..--.'_    \\                    `( ) ) // //\r\n/ (_..-' // (< _     ;_..__               ; `' / ///\r\n / // // //  `-._,_)' // / ``--...____..-' /// / //";
            Console.WriteLine(cat);
            return "катается по полу и мурлычит";
        }




        //+-+-+-+-+-+-+-+-+-+-+-+-+-+SPECIAL EVENTS+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+
        public static void spew()
        {
            string cat = "                      __,,,,_\r\n       _ __..-;''`--/'/ /.',-`-.\r\n   (`/' ` |  \\ \\ \\\\ / / / / .-'/`,_\r\n  /'`\\ \\   |  \\ | \\| // // / -.,/_,'-,\r\n /<7' ;  \\ \\  | ; ||/ /| | \\/    |`-/,/-.,_,/')\r\n/  _.-, `,-\\,__|  _-| / \\ \\/|_/  |    '-/.;.\\'\r\n`-`   / ;      / __/ \\__ `/ |__/ |\r\n     `-'      |  -| =|\\_  \\  |-' |\r\n           __/   /_..-' `  ),'  //\r\n          ((__.-'((___..-'' \\__.'";
            Console.WriteLine(cat);
        }

        public static void caress() //гладить
        {
            string cat = "       _                        \r\n       \\`*-.                    \r\n        )  _`-.                 \r\n       .  : `. .                \r\n       : _   '  \\               \r\n       ; *` _.   `*-._          \r\n       `-.-'          `-.       \r\n         ;       `       `.     \r\n         :.       .        \\    \r\n         . \\  .   :   .-'   .   \r\n         '  `+.;  ;  '      :   \r\n         :  '  |    ;       ;-. \r\n         ; '   : :`-:     _.`* ;\r\n      .*' /  .*' ; .*`- +'  `*' \r\n      `*-*   `*-*  `*-*'";
            Console.WriteLine(cat);
        }

        public static void dead()
        {
            string cat = "           ___\r\n          (___)\r\n   ____\r\n _\\___ \\  |\\_/|\r\n\\     \\ \\/ , , \\ ___\r\n \\__   \\ \\ =\"= //|||\\\r\n  |===  \\/____)_)||||\r\n  \\______|    | |||||\r\n      _/_|  | | =====\r\n     (_/  \\_)_)    \r\n  _________________\r\n (                _)\r\n  (__   '          )\r\n    (___    _____)\r\n        '--'";
            Console.WriteLine(cat);
        }

        public static void born()
        {
            string cat = "           .               ,.\r\n          T.\"-._..---.._,-\"/|\r\n          l|\"-.  _.v._   (\" |\r\n          [l /.'_ \\; _~\"-.`-t\r\n          Y \" _(o} _{o)._ ^.|\r\n          j  T  ,--.  T  ]\r\n          \\  l ( /-^-\\ ) !  !\r\n           \\. \\.  \"~\"  ./  /c-..,__\r\n             ^r- .._ .- .-\"  `- .  ~\"--.\r\n              > \\.                      \\\r\n              ]   ^.                     \\\r\n              3  .  \">            .       Y  \r\n ,.__.--._   _j   \\ ~   .         ;       |\r\n(    ~\"-._~\"^._\\   ^.    ^._      I     . l\r\n \"-._ ___ ~\"-,_7    .Z-._   7\"   Y      ;  \\        _\r\n    /\"   \"~-(r r  _/_--._~-/    /      /,.--^-._   / Y\r\n    \"-._    '\"~~~>-._~]>--^---./____,.^~        ^.^  !\r\n        ~--._    '   Y---.                        \\./\r\n             ~~--._  l_   )                        \\\r\n                   ~-._~~~---._,____..---           \\\r\n                       ~----\"~       \\\r\n                                      \\\r\n";
            Console.WriteLine(cat);
        }

        //public static void sitting()
        //{
        //    string cat = "";
        //    Console.WriteLine(cat);
        //}

    }
}

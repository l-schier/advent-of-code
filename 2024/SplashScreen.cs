using System;

namespace AdventOfCode.Y2024;

class SplashScreenImpl : SplashScreen {

    public void Show() {

        var color = Console.ForegroundColor;
        Write(0xcc00, false, "           ▄█▄ ▄▄█ ▄ ▄ ▄▄▄ ▄▄ ▄█▄  ▄▄▄ ▄█  ▄▄ ▄▄▄ ▄▄█ ▄▄▄\n           █▄█ █ █ █ █ █▄█ █ █ █   █ █ █▄ ");
            Write(0xcc00, false, " █  █ █ █ █ █▄█\n           █ █ █▄█ ▀▄▀ █▄▄ █ █ █▄  █▄█ █   █▄ █▄█ █▄█ █▄▄  sub y{2024}\n            \n");
            Write(0xcc00, false, "                  ");
            Write(0xcccccc, false, ".--'");
            Write(0xe3b585, false, "~ ~ ~");
            Write(0xcccccc, false, "|        .-' ");
            Write(0xffff66, true, "*       ");
            Write(0x886655, false, "\\  /     ");
            Write(0xcccccc, false, "'-.   1 ");
            Write(0xffff66, false, "**\n               ");
            Write(0xcccccc, false, ".--'");
            Write(0xe3b585, false, "~  ");
            Write(0xcc00, false, ",");
            Write(0xffff66, true, "* ");
            Write(0xe3b585, false, "~ ");
            Write(0xcccccc, false, "|        |  ");
            Write(0x9900, false, ">");
            Write(0xff9900, true, "o");
            Write(0x9900, false, "<   ");
            Write(0x886655, false, "\\_\\_\\|_/__/   ");
            Write(0xcccccc, false, "|   2 ");
            Write(0xffff66, false, "**\n           ");
            Write(0xcccccc, false, ".---'");
            Write(0xe3b585, false, ": ~ ");
            Write(0xcc00, false, "'");
            Write(0x5555bb, false, "(~)");
            Write(0xcc00, false, ", ");
            Write(0xe3b585, false, "~");
            Write(0xcccccc, false, "|        | ");
            Write(0x9900, false, ">");
            Write(0xff0000, true, "@");
            Write(0x9900, false, ">");
            Write(0x66ff, true, "O");
            Write(0x9900, false, "< ");
            Write(0xff0000, true, "o");
            Write(0x886655, false, "-_/");
            Write(0xcccccc, false, ".()");
            Write(0x886655, false, "__------");
            Write(0xcccccc, false, "|   3 ");
            Write(0xffff66, false, "**\n           ");
            Write(0xcccccc, false, "|");
            Write(0x427322, false, "#");
            Write(0x5eabb4, false, "..");
            Write(0x7fbd39, false, "@");
            Write(0xe3b585, false, "'. ~ ");
            Write(0xcc00, false, "\" ' ");
            Write(0xe3b585, false, "~ ");
            Write(0xcccccc, false, "|        |");
            Write(0x9900, false, ">");
            Write(0x66ff, true, "O");
            Write(0x9900, false, ">");
            Write(0xff9900, true, "o");
            Write(0x9900, false, "<");
            Write(0xff0000, true, "@");
            Write(0x9900, false, "< ");
            Write(0x886655, false, "\\____       ");
            Write(0xcc00, false, ".'");
            Write(0xcccccc, false, "|   4 ");
            Write(0xffff66, false, "**\n           ");
            Write(0xcccccc, false, "|");
            Write(0x427322, false, "_");
            Write(0x5eabb4, false, ".~.");
            Write(0x1461f, false, "_");
            Write(0x488813, false, "@");
            Write(0xe3b585, false, "'.. ~ ~ ");
            Write(0xffff66, true, "*");
            Write(0xcccccc, false, "|        | ");
            Write(0xaaaaaa, false, "_| |_    ");
            Write(0xcccccc, false, "..\\_");
            Write(0x886655, false, "\\_ ");
            Write(0xcc00, false, "..'");
            Write(0xffff66, true, "* ");
            Write(0xcccccc, false, "|   5 ");
            Write(0xffff66, false, "**\n           ");
            Write(0x666666, false, "| ||| @ @ '''...|        |...     .'  '.'''../..|  ");
            Write(0xcccccc, false, " 6 ");
            Write(0xffff66, false, "*");
            Write(0x666666, false, "*\n           ");
            Write(0x333333, false, "|               |        |        |    |        |  ");
            Write(0x666666, false, " 7\n                                                               8\n                                ");
            Write(0x666666, false, "                               9\n                                                              10\n  ");
            Write(0x666666, false, "                                                            11\n                                     ");
            Write(0x666666, false, "                         12\n                                                              13\n       ");
            Write(0x666666, false, "                                                       14\n                                          ");
            Write(0x666666, false, "                    15\n                                                              16\n            ");
            Write(0x666666, false, "                                                  17\n                                               ");
            Write(0x666666, false, "               18\n                                                              19\n                 ");
            Write(0x666666, false, "                                             20\n                                                    ");
            Write(0x666666, false, "          21\n                                                              22\n                      ");
            Write(0x666666, false, "                                        23\n                                                         ");
            Write(0x666666, false, "     24\n                                                              25\n           \n");
            
        Console.ForegroundColor = color;
        Console.WriteLine();
    }

    private static void Write(int rgb, bool bold, string text){
       Console.Write($"\u001b[38;2;{(rgb>>16)&255};{(rgb>>8)&255};{rgb&255}{(bold ? ";1" : "")}m{text}");
    }
}
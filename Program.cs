// See https://aka.ms/new-console-template for more information

using System;

public class Program
{
    public static void Main(string[] args)
    {
        #region 顶部文字
        Console.Write("歡迎光臨  ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("5525回到那一天 ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("（目前共有");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("55255");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("人上線）");
        #endregion

        #region 输入账号
        Console.Write("請輸入代號（試用請輸入‘");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("guest");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("’，註冊請輸入‘");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("new");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("’）：");
        _ = InputStr(false);
        #endregion

        #region 输入密码
        Console.Write("請輸入密碼：");
        _ = InputStr(true);

        // 隐藏掉光标
        Console.CursorVisible = false;
        #endregion

        #region 绘制白雪公主
        Console.WriteLine("");
        var text = "           ::::::::::'.d$N.^''...:::db.^'::::::::::.\r\n          .::::::::: *#' ::::::::'z$$$$$bo.'''::::::\r\n          :::::::''..-:::::::: 'u$$$$$$$$$$$$bu ':::\r\n         ::::::'.::::::::::'.ud$$$$$$$$$$$$$$$$$  :'\r\n         ::::: ::::::::' .ud$$$$$$$$$$$$$$$&eeuJ> :\r\n       . '::::::::::: xd$$$$R'Lued$$$$$$$$$$$$$$>.:\r\n     ::::.::::::::::. 9$$$$Fz$$$$$$$$$$$$$$$$F'' .:\r\n    ::::::::::::::::::'$$$$u$$$F' ''$$$$$$$$.ut  '::\r\n    :::::::::::::::::::'$$$$$FsKxL. 9$$$$$$$edNeo :::\r\n    :::::::::::::::::::'$$$$$FsKxL. 9$$$$$$$edNeo :::\r\n     ':::::::::::::::::: 4$$$$$b$euud$$$$$$$$$$$$$  : %%%\r\n%:%: '::: :::::::::::::: $$$$$$$$$$$$$$$$$$?$$$$$>  %%%%\r\n%%%%%     ::::::::::::: .$$$$$$$$$$$$$$$$I$u$$$$$> %%%%\r\n%%%%%%%:  ::::::::::::' d$$$$$$$$$$$$$$$R???'7$$F %%%%\r\n % %%%%%%  ::::::::::'.$$$$$$$$$$$$$b.-m$$* d$$F %%%'\r\n     %%%%%.  :::::::: t$$$$$$$$$$$$$$$bu..o$$$'.%%'\r\n      '%%%%%%.   :::: '$$$$$$$$$$$$$$$$$$$$$F':%%\r\n      's.'%%%%%%%%::.  $$$$$$$$o.''???$$R?F.:%%%\r\n        '$eu  %%%%%%% '$$$$$$$$$$$$er /%%%%%%%/\r\n          '?$$eu. %%% t$$$$$$$$$$$$$! %%%%%%%%";
        var rand = new Random();
        int idx = 0;
        do
        {
            var len = rand.Next(30, 80);
            var next = idx + len;
            next = Math.Min(next, text.Length);
            Console.Write(text.Substring(idx, next - idx));
            if (next >= text.Length) break;
            idx += len;
            // 修改下边括号中的数字以调整节奏
            System.Threading.Thread.Sleep(200);

        } while (true);
        #endregion

        #region 底部文字

        Console.WriteLine("");
        Console.WriteLine("                                 .___  ");
        Console.WriteLine("          _____ _____  ___.__. __| _/____  ___.__.");
        Console.WriteLine(@"         /     \\__  \<   |  |/ __ |\__  \<   |  |");
        Console.WriteLine(@"        |  Y Y  \/ __ \\___  / /_/ | / __ \\___  |");
        Console.WriteLine(@"        |__|_|  (____  / ____\____ |(____  / ____|");
        Console.WriteLine(@"              \/     \/\/         \/     \/\/");
        Console.WriteLine("");

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("                       歡 迎 光 臨");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("                  5525回到那一天 BBS 站");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("               Welcome to #5525 LIVE TOUR\r\n");
        Console.ForegroundColor = ConsoleColor.Cyan;
        
        ShowProgressBar(Console.CursorTop);
        Console.WriteLine("                 **********************");

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("                   Since 1997 . 3 . 29");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("              本站開放 ");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("5521~5525");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(" 等五個port");
        Console.WriteLine("                      歡迎多加利用");

        Console.WriteLine("                 powered by ringomango");
        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("                     ┌——————┐        ┌——————┐");
        Console.WriteLine("                     |      |        |┌————┐|");
        Console.WriteLine("           ┌——————┐  |      |        |└————┘ \\");
        Console.WriteLine("           |┌————┐|  |      └———┐    |        \\");
        Console.WriteLine("           |└————┘└——┘          |    |         \\");
        Console.WriteLine("           |                    |    |");
        Console.WriteLine("           |                    └————┘");

        Console.ForegroundColor = ConsoleColor.White;
        while (true) Console.ReadKey(true);

        #endregion
    }
    /// <summary>
    /// 在同一行输入文本
    /// </summary>
    /// <param name="isPW"></param>
    /// <returns></returns>
    private static string InputStr(bool isPW)
    {
        string input = string.Empty;
        while (true)
        {
            ConsoleKeyInfo ck = Console.ReadKey(true);
            if (ck.Key != ConsoleKey.Enter)
            {
                if (ck.Key != ConsoleKey.Backspace)
                {
                    var charactor = ck.KeyChar.ToString();
                    input += charactor;
                    Console.Write(isPW ? "*" : charactor);
                }
                else
                {
                    Console.Write("\b \b");
                }
            }
            else
            {
                Console.WriteLine();
                break;
            }
        }

        return input;
    }
    /// <summary>
    /// 显示滚动条
    /// </summary>
    /// <param name="top"></param>
    private static void ShowProgressBar(int top)
    {
        //Console.SetCursorPosition(0, Console.CursorTop);
        //RS.Tools.Common.Utils.ConsoleLog.ClearCurrentConsoleLine();
        //Console.Write(content);

        // "                 ******** *************"
        Task.Run(() =>
        {
            int index = 0;
            do
            {
                System.Threading.Thread.Sleep(200);
                var text = $"                 {new string('*', index)} {new string('*', 21 - index)}";
                Console.SetCursorPosition(0, top);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(0, top);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(text);
                Console.ForegroundColor = ConsoleColor.White;
                index = index == 21 ? 0 : index + 1;
            } while (true);
        });
    }
}





//           ::::::::::'.d$N.^''...:::db.^'::::::::::.
//          .::::::::: *#' ::::::::'z$$$$$bo.'''::::::
//          :::::::''..-:::::::: 'u$$$$$$$$$$$$bu ':::
//         ::::::'.::::::::::'.ud$$$$$$$$$$$$$$$$$  :'
//         ::::: ::::::::' .ud$$$$$$$$$$$$$$$&eeuJ> :
//       . '::::::::::: xd$$$$R'Lued$$$$$$$$$$$$$$>.:
//     ::::.::::::::::. 9$$$$Fz$$$$$$$$$$$$$$$$F'' .:
//    ::::::::::::::::::'$$$$u$$$F' ''$$$$$$$$.ut  '::
//    :::::::::::::::::::'$$$$$FsKxL. 9$$$$$$$edNeo :::
//    :::::::::::::::::::'$$$$$FsKxL. 9$$$$$$$edNeo :::
//     ':::::::::::::::::: 4$$$$$b$euud$$$$$$$$$$$$$  : %%%
//%:%: '::: :::::::::::::: $$$$$$$$$$$$$$$$$$?$$$$$>  %%%%
//%%%%%     ::::::::::::: .$$$$$$$$$$$$$$$$I$u$$$$$> %%%%
//%%%%%%%:  ::::::::::::' d$$$$$$$$$$$$$$$R???'7$$F %%%%
// % %%%%%%  ::::::::::'.$$$$$$$$$$$$$b.-m$$* d$$F %%%'
//     %%%%%.  :::::::: t$$$$$$$$$$$$$$$bu..o$$$'.%%'
//      '%%%%%%.   :::: '$$$$$$$$$$$$$$$$$$$$$F':%%
//      's.'%%%%%%%%::.  $$$$$$$$o.''???$$R?F.:%%%
//        '$eu  %%%%%%% '$$$$$$$$$$$$er /%%%%%%%/
//          '?$$eu. %%% t$$$$$$$$$$$$$! %%%%%%%%


//          ┌——————┐        ┌——————┐
//          |      |        |┌————┐|
//┌——————┐  |      |        |└————┘ \
//|┌————┐|  |      └———┐    |        \
//|└————┘└——┘          |    |         \
//|                    |    |   
//|                    └————┘


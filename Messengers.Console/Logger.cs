using System;

namespace Messengers.Console
{
    static class Logger {

        public static void Error(Exception exception) {
            var currentColor = System.Console.ForegroundColor;
            System.Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine (exception.Message);
            System.Console.ForegroundColor = currentColor;
        }
    }
}
using System;
using Telegram.Bot;

static partial class Program
{
    static readonly TelegramBotClient Bot = new TelegramBotClient(
        "542570203:AAHSruETZeZf2X2mlsba_Ar7x3gCUHorz9Q");

    static void Main(string[] args)
    {
        ConsoleTools.InitConsoleAsync(Bot);
        Bot.OnMessage += OnMessage;
        Bot.StartReceiving();
        ConsoleTools.LockConsole();
    }
}


using static System.Console;

static class ConsoleTools
{
    public static async void InitConsoleAsync(Telegram.Bot.TelegramBotClient bot)
    {
        Write("Идёт запуск бота...");
        Title = $"https://t.me/{(await bot.GetMeAsync()).Username.ToLower()}";
        Clear();
        WriteLine($"Бот успешно запущен по адресу: {Title}");
    }

    public static void LockConsole()
    {
        while (true)
        {
            ReadKey(true);
        }
    }
}


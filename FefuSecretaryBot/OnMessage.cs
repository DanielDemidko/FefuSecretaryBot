using System;
using System.Collections.Generic;
using System.Text;
using Telegram.Bot.Types.Enums;

static partial class Program
{
    static async void OnMessage(object sender, Telegram.Bot.Args.MessageEventArgs e)
    {
        await Bot.SendTextMessageAsync(e.Message.From.Id, e.Message.Text.GetReply());
    }
}

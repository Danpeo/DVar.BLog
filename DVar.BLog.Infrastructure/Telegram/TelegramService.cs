using Microsoft.Extensions.Options;
using Telegram.Bot;

namespace DVar.BLog.Infrastructure.Telegram;

public class TelegramService
{
    private readonly TelegramBotClient _telegramBot;
    private readonly TelegramBotSettings _telegramBotSettings;

    public TelegramService(IOptions<TelegramBotSettings> telegramBotSettingOptions)
    {
        _telegramBotSettings = telegramBotSettingOptions.Value;
        _telegramBot = new TelegramBotClient(_telegramBotSettings.BotToken);
    }

    public async Task SendMessageAsync(string message)
    {
        await _telegramBot.SendTextMessageAsync(_telegramBotSettings.ChatId, message);
    }
}
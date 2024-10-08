﻿using FirehoseFinder.Properties;
using System;
using System.Collections.Generic;
using System.Resources;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace FirehoseFinder
{
    class Bot_Funcs
    {
        internal readonly long channel = -1001227261414; // канал Firehose-Finder issues
        internal static ITelegramBotClient _botClient = new TelegramBotClient(Resources.bot);
        private static ReceiverOptions _receiverOptions;
        //Подтянули перевод на другие языки
        static readonly ResourceManager LocRes = new ResourceManager("FirehoseFinder.Properties.Resources", typeof(Formfhf).Assembly);

        internal static async Task BotWork()
        {
            _receiverOptions = new ReceiverOptions
            {
                AllowedUpdates = new[] // Тут указываем типы получаемых Update`ов, о них подробнее расказано тут https://core.telegram.org/bots/api#update
            {
                UpdateType.Message, // Сообщения (текст, фото/видео, голосовые/видео сообщения и т.д.)
                UpdateType.CallbackQuery, //Inline кнопки
            },
                // Параметр, отвечающий за обработку сообщений, пришедших за то время, когда ваш бот был оффлайн
                // True - не обрабатывать, False (стоит по умолчанию) - обрабаывать
                ThrowPendingUpdates = true,
            };
            var cts = new CancellationTokenSource();
            // UpdateHander - обработчик приходящих Update`ов
            // ErrorHandler - обработчик ошибок, связанных с Bot API
            _botClient.StartReceiving(UpdateHandler, ErrorHandler, _receiverOptions, cts.Token); // Запускаем бота
            var me = await _botClient.GetMeAsync(); // Создаем переменную, в которую помещаем информацию о нашем боте.
            MessageBox.Show(LocRes.GetString("bot_code_start") + Environment.NewLine + Settings.Default.auth_code.ToString(),
                me.FirstName + '\u0020' + LocRes.GetString("bot_title_start_suc"));
            await Task.Delay(-1);
        }
        private static async Task UpdateHandler(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            try
            {
                switch (update.Type)
                {
                    case UpdateType.Message:
                        {
                            // эта переменная будет содержать в себе все связанное с сообщениями
                            var message = update.Message;
                            // From - это от кого пришло сообщение (или любой другой Update)
                            var user = message.From;
                            // Chat - содержит всю информацию о чате
                            var chat = message.Chat;
                            // Обрабатываем команду /старт
                            if (message.Text.StartsWith("/start"))
                            {
                                if (message.Text.Length > 6) //Обрабатываем код авторизации (не забываем про дубликаты!)
                                {
                                    if (Settings.Default.userID != 0)
                                    {
                                        await botClient.SendTextMessageAsync(
                                            chat.Id,
                                            "Не надо больше. Вы уже авторизованы",
                                            replyToMessageId: message.MessageId
                                            );
                                    }
                                    else
                                    {
                                        string authcode = message.Text.Substring(6).Trim(' ');
                                        bool authok = authcode.Equals(Settings.Default.auth_code);
                                        if (authok)
                                        {
                                            Settings.Default.userID = user.Id;
                                            if (string.IsNullOrEmpty(user.FirstName)) Settings.Default.userFN = string.Empty; else Settings.Default.userFN = user.FirstName;
                                            if (string.IsNullOrEmpty(user.LastName)) Settings.Default.userLN = string.Empty; else Settings.Default.userLN = user.LastName;
                                            if (string.IsNullOrEmpty(user.Username)) Settings.Default.userN = string.Empty; else Settings.Default.userN = user.Username;
                                            //Сообщаем администратору о новом участнике рейтинга
                                            await botClient.SendTextMessageAsync(
                                                1008578121,
                                                $"Новый участник рейтинга: {user.FirstName} {user.LastName} ({user.Username}) - {user.Id}",
                                                replyToMessageId: message.MessageId
                                                );
                                            //Авторизация прошла удачно. Перегружаемся.
                                            Application.Restart();
                                        }
                                        else
                                        {
                                            await botClient.SendTextMessageAsync(
                                                chat.Id,
                                                "Авторизация прошла неудачно. Попробуйте ещё раз, используя приложение FhF.",
                                                replyToMessageId: message.MessageId
                                                );
                                        }
                                    }
                                }
                                else //Команда /start без параметров. Поднимаем клавиатуру, просим ввести код авторизации и пр.
                                {
                                    // Создаём клавиатуру
                                    var inlineKeyboard = new InlineKeyboardMarkup(
                                        new List<InlineKeyboardButton[]>() // Создаём лист (массив), который содрежит в себе массив из класса кнопок
                                        {
                                            // Каждый новый массив - это дополнительные строки, а каждая дополнительная кнопка в массиве - это добавление ряда
                                            new InlineKeyboardButton[] // Создаём массив кнопок
                                            {
                                                InlineKeyboardButton.WithCallbackData("Авторизация", "button_auth"),
                                                InlineKeyboardButton.WithCallbackData("Рейтинг", "button_rate"),
                                            },
                                        });
                                    await botClient.SendTextMessageAsync(
                                        chat.Id,
                                        "Пожалуйста, выберите \"Авторизация\", если готовы ввести код из программы FhF или \"Рейтинг\", если хотите посмотреть текущий \"Рейтинг неравнодушных пользователей\"",
                                        replyMarkup: inlineKeyboard); // Все клавиатуры передаются в параметр replyMarkup
                                    return;
                                }
                            }
                            else
                            {
                                //Код авторизации верен
                                if (message.Text.Equals(Settings.Default.auth_code))
                                {
                                    Settings.Default.userID = user.Id;
                                    if (string.IsNullOrEmpty(user.FirstName)) Settings.Default.userFN = string.Empty; else Settings.Default.userFN = user.FirstName;
                                    if (string.IsNullOrEmpty(user.LastName)) Settings.Default.userLN = string.Empty; else Settings.Default.userLN = user.LastName;
                                    if (string.IsNullOrEmpty(user.Username)) Settings.Default.userN = string.Empty; else Settings.Default.userN = user.Username;
                                    await botClient.SendTextMessageAsync(
                                        chat.Id,
                                        "Авторизация прошла успешно. Приложение FhF перезапущено.");
                                    //Сообщаем администратору о новом участнике рейтинга
                                    await botClient.SendTextMessageAsync(
                                        1008578121,
                                        $"Новый участник рейтинга: {user.FirstName} {user.LastName} ({user.Username}) - {user.Id}",
                                        replyToMessageId: message.MessageId
                                        );
                                    //Авторизация прошла удачно. Перегружаемся.
                                    Application.Restart();
                                }
                                else //Ввели неподдерживаемый текст
                                {
                                    await botClient.SendTextMessageAsync(
                                        chat.Id,
                                        "Извините, не понимаю о чём вы. Может быть /start?",
                                        replyToMessageId: message.MessageId
                                        );
                                }
                            }
                            return;
                        }
                    case UpdateType.CallbackQuery:
                        {
                            var callbackQuery = update.CallbackQuery;
                            //var user = callbackQuery.From; //Пока заремарим, т.к. не используется. Думаю о дубликатах!
                            var chat = callbackQuery.Message.Chat;
                            switch (callbackQuery.Data)
                            {
                                case "button_auth":
                                    {   
                                        await botClient.AnswerCallbackQueryAsync(   // Всплывающее сообщение
                                            callbackQuery.Id, 
                                            "При успешной авторизации FhF перезагрузится автоматически!");
                                        await botClient.SendTextMessageAsync(
                                            chat.Id,
                                            "Отправьте 4 цифры кода авторизации из приложения FhF в формате ХХ-ХХ");
                                        return;
                                    }
                                case "button_rate":
                                    {
                                        await botClient.AnswerCallbackQueryAsync(   // Всплывающее сообщение
                                            callbackQuery.Id, 
                                            "Готовлю рейтинг..."); 
                                        string rate_str = string.Empty;
                                        int count_str = 1;
                                        Guide guide = new Guide();
                                        Func funcs = new Func();
                                        foreach (Users_Rating users_Rating in funcs.SortingRate(guide.users_rate))
                                        {
                                            rate_str += $"{count_str}. {users_Rating.User_fullname} - {users_Rating.User_mess + users_Rating.User_reactions}" + Environment.NewLine;
                                            count_str++;
                                        }
                                        await botClient.SendTextMessageAsync(
                                            chat.Id,
                                            rate_str);
                                        return;
                                    }
                                default:
                                    return;
                            }
                        }
                    default:
                        return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private static Task ErrorHandler(ITelegramBotClient botClient, Exception error, CancellationToken cancellationToken)
        {
            // Тут создадим переменную, в которую поместим код ошибки и её сообщение 
            ApiRequestException apiRequestException = new ApiRequestException("Telegram API Error:", error);
            string ErrorMessage = $"Telegram API Error:\n[{apiRequestException.ErrorCode}]\n{apiRequestException.Message}";
            MessageBox.Show(ErrorMessage);
            return Task.CompletedTask;
        }
    }
}

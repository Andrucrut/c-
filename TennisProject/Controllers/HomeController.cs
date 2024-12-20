﻿using Microsoft.AspNetCore.Mvc;
using Telegram.Bot.Types;
using TennisProject.Filters;
using TennisProject.Telegram;

namespace TennisProject.Controllers
{
    public class BotController : ControllerBase
    {
        [HttpPost]
        [ValidateTelegramBot]
        public async Task<IActionResult> Post(
        [FromBody] Update update,
            [FromServices] UpdateHandlers handleUpdateService,
            CancellationToken cancellationToken)
        {
            await handleUpdateService.HandleUpdateAsync(update, cancellationToken);
            return Ok();
        }
    }
}

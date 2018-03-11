using System;
using EEBLAPI;
using EEBLAPI.Chat;
using EEBLAPI.Event;
using EEBLAPI.Player.Utils;

namespace HiPlayer
{
    public class HiPlayer : Bot
    {
        public override string NAME => "HiPlayer";
        public override string VERSION => "1.0.0";
        public override string AUTHOR => "Timothyji";

        IChatQueue chat;
        IPlayerHandler playerHandler;

        //recommended so the bot can log information to console.
        public override bool PreLoad(EEBLPreLoadEvent e)
        {
            Logger = e.GetLogger();
            return base.PreLoad(e);
        }

        public override bool OnPreInit(EEBLPreInitEvent e)
        {
            playerHandler = e.GetPlayerHandler();
            playerHandler.OnPlayerJoin_Subscribe(HiPlayer_OnPlayerJoin);
            return base.OnPreInit(e);
        }

        private void HiPlayer_OnPlayerJoin(EEBLAPI.Player.IPlayer player, EEBLAPI.Message.IMessageAdd message)
        {
            chat.SendChat(ChatPriority.NORMAL, "Hello " + player.Username);
        }

        public override bool OnInit(EEBLInitEvent e)
        {
            chat = e.GetChatQueue();
            return base.OnInit(e);
        }
    }
}

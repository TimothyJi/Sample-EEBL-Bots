using EEBLAPI;
using EEBLAPI.Chat;
using EEBLAPI.Event;

namespace HelloWorld
{
    public class HelloWorld : Bot
    {
        public override string NAME => "HelloWorld";

        public override string VERSION => "1.0.0";

        public override string AUTHOR => "Timothyji";

        IChatQueue chat;

        public override bool PreLoad(EEBLPreLoadEvent e)
        {
            Logger = e.GetLogger();

            return base.PreLoad(e);
        }

        public override bool Load(EEBLLoadEvent e)
        {
            Logger.Info("Hello World!");

            return base.Load(e);
        }

        public override bool OnInit(EEBLInitEvent e)
        {
            chat = e.GetChatQueue();

            chat.SendChat(ChatPriority.NORMAL, "Hello World!");

            return base.OnInit(e);
        }
    }
}

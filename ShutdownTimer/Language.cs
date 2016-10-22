using System.Collections.Generic;

namespace ShutdownTimer
{
    public enum LanguageName { English, chinese};

    public class Language
    {
        
        /// <summary>
        /// Contains language content
        /// </summary>
        public Dictionary<string, string> Items { get; set; }
        
        /// <summary>
        /// Initialize language content
        /// </summary>
        /// <param name="langName"></param>
        public Language(LanguageName langName)
        {
            Items = new Dictionary<string, string>();
            switch (langName)
            {
                case LanguageName.chinese:
                    chinese();
                    break;
                case LanguageName.English:
                    English();
                    break;
            }
        }

        public void English()
        {
            Items.Add("Main.Bar.PowerMenu.Shutdown", "Shutdown Now");
            Items.Add("Main.Bar.PowerMenu.Restart", "Restart Now");
            Items.Add("Main.GroupBoxTime.Title", "Set timer");
            Items.Add("Main.ButtonSet", "Set");
            Items.Add("Main.ButtonCancel", "Cancel");
            Items.Add("Main.Option.Title", "Options");
            Items.Add("Main.Option.Radio.Shutdown", "Shutdown");
            Items.Add("Main.Option.Radio.Restart", "Restart");
            Items.Add("Main.Option.Radio.SignOut", "Sign out");
            Items.Add("Main.Option.Check.UseHybridBoot", "Use Hybrid boot");
            Items.Add("Main.Option.Check.ForceStop", "Force stop");
            Items.Add("Main.Option.Check.Usechinese", "Use chinese interface");
            Items.Add("Main.Option.Check.WarnBefore", "Warn before:");
            Items.Add("Main.Option.Check.minute", "minute(s)");
            Items.Add("Main.Run.TimeRemaining", "Time remaining:");

            Items.Add("Notification.Options", "Options");
            Items.Add("Notification.Shutdown", "Shutdown now");
            Items.Add("Notification.Restart", "Restart now");
            Items.Add("Notification.Exit", "Exit");
            Items.Add("Notification.Balloon.Warn.Title", "You're about to be signed out");
            Items.Add("Notification.Balloon.Warn.Detail", "About {0} minute(s) remaining");

            Items.Add("Status.Default", "Set time then click Set to start the task");
            Items.Add("Status.TaskCompleted", "Time was set. Click Cancel to cancel this task");

            Items.Add("Message.Exit.Title", "Exit program");
            Items.Add("Message.Exit.Text", "Do you want to cancel and exit program?");

            Items.Add("About.Title", "About");
            Items.Add("About.Version", "Version: ");
            Items.Add("About.ButtonClose", "Close");
        }

        public void chinese()
        {
            Items.Add("Main.Bar.PowerMenu.Shutdown", "立刻关机");
            Items.Add("Main.Bar.PowerMenu.Restart", "立刻重启");
            Items.Add("Main.GroupBoxTime.Title", "设置时间");
            Items.Add("Main.ButtonSet", "开始");
            Items.Add("Main.ButtonCancel", "取消");
            Items.Add("Main.Option.Title", "设置");
            Items.Add("Main.Option.Radio.Shutdown", "关机");
            Items.Add("Main.Option.Radio.Restart", "重启");
            Items.Add("Main.Option.Radio.SignOut", "注销");
            Items.Add("Main.Option.Check.UseHybridBoot", "省电模式");
            Items.Add("Main.Option.Check.ForceStop", "强制关闭");
            Items.Add("Main.Option.Check.Usechinese", "中文界面");
            Items.Add("Main.Option.Check.WarnBefore", "警告:");
            Items.Add("Main.Option.Check.minute", "分钟");
            Items.Add("Main.Run.TimeRemaining", "剩余时间:");

            Items.Add("Notification.Options", "设置");
            Items.Add("Notification.Shutdown", "立刻关机");
            Items.Add("Notification.Restart", "立刻重启");
            Items.Add("Notification.Exit", "退出");
            Items.Add("Notification.Balloon.Warn.Title", "电脑即将关闭");
            Items.Add("Notification.Balloon.Warn.Detail", "剩余时间 {0} 分钟");

            Items.Add("Status.Default", "点击 开始 键后开始计时");
            Items.Add("Status.TaskCompleted", "时间已经设定. 点击 \"取消\" 取消任务");

            Items.Add("Message.Exit.Title", "退出程序");
            Items.Add("Message.Exit.Text", "你确定要退出吗?");

            Items.Add("About.Title", "关于");
            Items.Add("About.Version", "版本: ");
            Items.Add("About.ButtonClose", "关闭");
        }
    }
}

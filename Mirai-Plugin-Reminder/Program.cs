using System;
using System.Threading.Tasks;
using System.Timers;
using Mirai_CSharp;
using Mirai_CSharp.Models;
using Mirai_Plugin_Reminder.Utils;

namespace Mirai_Plugin_Reminder
{
    public static class Program
    {
        // INITKEYlYOwwqkX
        public static async Task Main()
        {
            var options = new MiraiHttpSessionOptions("127.0.0.1", 8080, "INITKEYlYOwwqkX");
            await using var session = new MiraiHttpSession();
            await session.ConnectAsync(options, Const.BotQQ);

            await Task.Run(async delegate
            {
                while (true)
                {
                    var timer = new Timer(1000);
                    timer.Elapsed += (sender, args) =>
                    {
                        if (TimeUtil.IsTime(0, 0, 10))
                        {
                            session.SendGroupMessageAsync(Const.ClassGroup,
                                new AtAllMessage(),
                                new PlainMessage("\n现在是早上10点整，请大家准备填写今日校园啦！"),
                                new FaceMessage(200, ""),
                                new PlainMessage("\n「Send by Mirai-Robot M2」"));
                        }
                        else if(TimeUtil.IsTime(0, 0, 18))
                        {
                            session.SendGroupMessageAsync(Const.ClassGroup,
                                new AtAllMessage(),
                                new PlainMessage("\n现在是晚间18点整，请还没有填写今日校园的同学赶快填写喔！"),
                                new FaceMessage(200, ""),
                                new PlainMessage("\n「Send by Mirai-Robot M2」"));
                        }
                        else if (TimeUtil.IsTime(0, 0, 20))
                        {
                            session.SendGroupMessageAsync(Const.ClassGroup,
                                new AtAllMessage(),
                                new PlainMessage("\n现在是晚间20点整，这是最后一次提醒今日校园填写啦！"),
                                new FaceMessage(200, ""),
                                new PlainMessage("\n「Send by Mirai-Robot M2」"));
                        }

                        /*
                         if (TimeUtil.IsTime(18, 30, 0))
                        {
                            session.SendGroupMessageAsync(863156933,
                                new AtAllMessage(),
                                new PlainMessage("\n现在时18:30，请大家准备填写今日校园啦！"),
                                new FaceMessage(200, ""),
                                new PlainMessage("\n「Send by Mirai-Robot」"));
                        }
                        else if (TimeUtil.IsTime(20, 00, 0))
                        {
                            session.SendGroupMessageAsync(863156933,
                                new AtAllMessage(),
                                new PlainMessage("\n现在时20:00，请还没有填写今日校园的同学赶快填写！"),
                                new FaceMessage(200, ""),
                                new PlainMessage("\n「Send by Mirai-Robot」"));
                        }
                        else if (TimeUtil.IsTime(21, 00, 0))
                        {
                            session.SendGroupMessageAsync(863156933,
                                new AtAllMessage(),
                                new PlainMessage("\n现在时21:00，最后一次提醒今日校园填写！"),
                                new FaceMessage(200, ""),
                                new PlainMessage("\n「Send by Mirai-Robot」"));
                        }
                        */
                    };
                    timer.AutoReset = true;
                    timer.Enabled = true;

                    if (await Console.In.ReadLineAsync() == "exit")
                    {
                        return;
                    }
                }
            });

        }
    }
}

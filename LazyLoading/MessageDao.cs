using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LazyLoading
{
    static class MessageDao
    {
        public static List<Message> getMessages(string groupId)
        {
            List<Message> msgs = new List<Message>();
            Thread.Sleep(5000);

            if (groupId == "Penapple")
            {
                msgs.Add(new Message { Content = "  99 little bugs in the code" });
                msgs.Add(new Message { Content = "  99 bugs in the code" });
                msgs.Add(new Message { Content = "  patch one down, compile it around" });
                msgs.Add(new Message { Content = "  123 bugs in the code\n" });
            }
            else
            {
                msgs.Add(new Message { Content = "  A SQL statement walks into a bar and sees two tables. It approaches, and asks “may I join you?\"\n" });
                msgs.Add(new Message { Content = "  Why don't programmers tell jokes in octal?" });
                msgs.Add(new Message { Content = "  Because 7 10 11!\n" });
            }
            return msgs;
        }
    }
}

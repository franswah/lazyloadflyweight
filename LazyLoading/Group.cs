using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoading
{
    class Group
    {
        public string id { get; }
        private Lazy<List<Message>> lazyMessages = null;

        public Group(string id)
        {
            this.id = id;
            lazyMessages = new Lazy<List<Message>>(() => MessageDao.getMessages(id));
        }

        public List<Message> getMessages()
        {
            return lazyMessages.Value;
        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using HelloWorld.Models;

namespace HelloWorld.Repository
{
    public class SimpleHelloWorldRepository : IHelloWorldRepository
    {
        // snippet for later release (Very Simple Entity Framework Core ORM code)
        /*public Message GetMessage()
        {
            var model = appDbContext.Message.FirstOrDefault(x => x.MessageType = "Hello");

            return model;
        }*/

        public Message GetMessage()
        {
            Message message = new Message();
            message.Hello = "Hello World";

            return message;
        }
    }
}

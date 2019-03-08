using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using HelloWorld.Repository;
using HelloWorld.Models;

namespace HelloWorld.Controllers
{
    public class APIController : Controller
    {
        private IHelloWorldRepository helloWorldRepository;
        // can break this out to a seperate project later so that it can be called from various applications
        // cmd prompt, web, android app, ect.

        public APIController(IHelloWorldRepository helloWorldRepository)
        {
            this.helloWorldRepository = helloWorldRepository;
        }

        public string HelloWorld()
        {
            Message message = helloWorldRepository.GetMessage();

            return message.Hello;
        }
    }
}
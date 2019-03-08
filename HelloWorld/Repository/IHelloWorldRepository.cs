using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using HelloWorld.Models;

namespace HelloWorld.Repository
{
    public interface IHelloWorldRepository
    {
        Message GetMessage();
    }
}

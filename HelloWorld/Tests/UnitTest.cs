using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Xunit;

using System.Linq;

using HelloWorld.Controllers;
using HelloWorld.Repository;

namespace web_api_tests
{
    public class HelloWorldTest
    {
        APIController _controller;
        IHelloWorldRepository _repository;

        public HelloWorldTest()
        {
            _repository = new SimpleHelloWorldRepository();
            _controller = new APIController(_repository);
        }

        [Fact]
        public void API_Controller_Returns_Message()
        {
            // Act
            var message = _controller.HelloWorld();

            // Assert
            Assert.Equal("Hello World", message);
        }

    }
}

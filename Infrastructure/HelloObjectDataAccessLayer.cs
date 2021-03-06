﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloWorld.Domain.Abstract;
using HelloWorld.Domain.Entities;

namespace HelloWorld.Infrastructure
{
    public class HelloObjectDataAccessLayer : IHelloObjectDataAccessLayer
    {
        public async Task<HelloObject> GetHelloObjectInformationAsync()
        {
            //This is the mocked async method. I'm using a HelloObject to pass "Hello World!" to the API.
            return await Task.FromResult(new HelloObject
            {
                Id = 1,
                Name = "Hello World!"
            });
        }
    }
}

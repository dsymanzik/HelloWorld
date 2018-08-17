using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HelloWorld.Domain.Abstract;
using HelloWorld.Domain.Entities;
using HelloWorld.Infrastructure;

namespace HelloWorld.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloObjectController : ControllerBase
    {
        private IHelloObjectBusinessLayer _objHelloObjectB;
        public HelloObjectController(IHelloObjectBusinessLayer objHelloObjectB)
        {
            _objHelloObjectB = objHelloObjectB;
        }
        [HttpGet]
        public async Task<HelloObject> Get()
        {
            return await _objHelloObjectB.GetHelloObjectInformationAsync();
        }
        
    }
}
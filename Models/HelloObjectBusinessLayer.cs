using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloWorld.Domain.Entities;
using HelloWorld.Domain.Abstract;

namespace HelloWorld.Models
{
    public class HelloObjectBusinessLayer : IHelloObjectBusinessLayer
    {
        private IHelloObjectDataAccessLayer _objHelloObject;
        public HelloObjectBusinessLayer(IHelloObjectDataAccessLayer objHelloObject)
        {
            _objHelloObject = objHelloObject;
        }
        public async Task<HelloObject> GetHelloObjectInformationAsync()
        {
            return await _objHelloObject.GetHelloObjectInformationAsync();
        }
    }
}

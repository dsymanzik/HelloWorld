using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloWorld.Domain.Entities;

namespace HelloWorld.Domain.Abstract
{
    public interface IHelloObjectBusinessLayer
    {
        Task<HelloObject> GetHelloObjectInformationAsync();
    }
}

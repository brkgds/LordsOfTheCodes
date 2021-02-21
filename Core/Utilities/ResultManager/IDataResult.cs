using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.ResultManager
{
    public interface IDataResult <T> : IResult
    {
        public T Data { get; set; }
    }
}

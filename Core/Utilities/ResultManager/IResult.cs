using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.ResultManager
{
    public interface IResult
    {
        public string Message { get; set; }
        public bool IsSuccess { get; set; }

    }
}

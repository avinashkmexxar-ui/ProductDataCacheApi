using System;
using System.Collections.Generic;
using System.Text;

namespace ProductDataCacheApi.Shared.Results
{
    public sealed class Result<T>
    {
        public T? Value { get; }
        public int StatusCode { get; }
        public string? Error { get; }

        public Result(T value)
        {
            Value = value;
            StatusCode = 200;
        }

        public Result(int statusCode, string error)
        {
            StatusCode = statusCode;
            Error = error;
        }
    }
}

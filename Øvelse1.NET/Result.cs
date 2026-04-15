using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Result<T>
{
    public bool Success { get; }

    public T Value { get; }

    public string ErrorMessage { get; }

    private Result(bool success, T value, string errorMessage)
    {
        Success = success;
        Value = value;
        ErrorMessage = errorMessage;
    }

    public static Result<T> FailureResult(string errorMessage)
    {
        return new Result<T>(false, default, errorMessage);
    }

    public static Result<T> SuccessResult(T value)
    {
        return new Result<T>(true, value, null);
    }
}


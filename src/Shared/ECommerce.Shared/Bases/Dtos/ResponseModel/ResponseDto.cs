﻿namespace ECommerce.Shared.Bases.Dtos.ResponseModel
{
    public class ResponseDto<T>
    {
        public T Data { get; set; }

        public int StatusCode { get; set; }

        public bool IsSuccess { get; set; }

        public List<string> Errors { get; set; } = new List<string>();

        public ResponseDto<T> Success()
        {
            return new ResponseDto<T> { Data = Data, StatusCode = 200, IsSuccess = true, Errors = new List<string>() };
        }
        public ResponseDto<T> Success(T data)
        {
            return new ResponseDto<T> { Data = data, StatusCode = 200, IsSuccess = true, Errors = new List<string>() };
        }
        public ResponseDto<T> Fail(T data, List<string> errors, int statusCode)
        {
            return new ResponseDto<T> { Data = data, Errors = errors, StatusCode = statusCode, IsSuccess = false };
        }
        public ResponseDto<T> Fail(List<string> errors, int statusCode)
        {
            return new ResponseDto<T> { Errors = errors, StatusCode = statusCode, IsSuccess = false };
        }
        public ResponseDto<T> Fail(T data, string errors, int statusCode)
        {
            Errors.Add(errors);
            return new ResponseDto<T> { Errors = Errors, StatusCode = statusCode, IsSuccess = false };
        }
        public ResponseDto<T> Fail(string errors, int statusCode)
        {
            Errors.Add(errors);
            return new ResponseDto<T> { Errors = Errors, StatusCode = statusCode, IsSuccess = false };
        }
        public ResponseDto<T> Fail()
        {
            string message = "Bilinmeyen Bir Hata Oluştu";
            Errors.Add(message);
            return new ResponseDto<T> { Errors = Errors, StatusCode = 400, IsSuccess = false };
        }

    }
}

namespace Core.Utilities.Results
{
    public class ResponseDataResult<T> : DataResult<T>
    {
        public ResponseDataResult(T data, string message) : base(data, true, message) { }
        public ResponseDataResult(T data) : base(data, true) { }
        public ResponseDataResult(string message) : base(default, true, message) { }
        public ResponseDataResult() : base(default, true) { }
    }
}

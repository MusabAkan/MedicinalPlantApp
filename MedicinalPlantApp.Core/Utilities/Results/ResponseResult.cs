namespace Core.Utilities.Results
{
    public class ResponseResult : Result
    {
        public ResponseResult(string message, bool status) : base(status, message) { }
        public ResponseResult(bool status) : base(status) { }
    }
}

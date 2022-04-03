namespace ChainOfResponsibilityPattern
{
    public class Response
    {
        public bool IsSuccessful { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
    }
}
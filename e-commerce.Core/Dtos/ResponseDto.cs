namespace e_commerce.Core.Dtos
{
    public class ResponseDto<T>
    {
        public int ResultCount { get; set; }
        public MetaDataDto MetaData { get; set; }
        public T Data { get; set; }
        public string Message { get; set; }
    }
}

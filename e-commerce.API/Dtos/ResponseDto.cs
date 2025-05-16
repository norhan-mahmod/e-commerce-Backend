namespace e_commerce.API.Dtos
{
    public class ResponseDto<T>
    {
        public int Result { get; set; }
        public MetaDataDto MetaData { get; set; }
        public T Data { get; set; }
    }
}

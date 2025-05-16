namespace e_commerce.API.Dtos
{
    public class MetaDataDto
    {
        public int CurrentPage { get; set; }
        public int NumberOfPages { get; set; }
        public int Limit { get; set; }
        public int NextPage { get; set; }
    }
}

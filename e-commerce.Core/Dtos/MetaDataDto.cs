namespace e_commerce.Core.Dtos
{
    public class MetaDataDto
    {
        public int CurrentPage { get; set; }
        public int NumberOfPages { get; set; }
        public int Limit { get; set; }
        public int NextPage { get; set; }
    }
}

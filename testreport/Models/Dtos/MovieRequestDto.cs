using testreport.Constants;

namespace testreport.Models.Dtos
{
    public class MovieRequestDto
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Owner { get; set; }
        public int PageSize { get; set; } = CommonConst.PageSizeDefault;
        public int PageIndex { get; set; }
    }
}

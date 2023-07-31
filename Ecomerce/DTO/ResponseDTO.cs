namespace Ecomerce.DTO
{
    public class ResponseDTO
    {
        public int ResultCode { get; set; }
        public string? ResultMessage { get; set; }

        public ResponseDTO(int resultCode, string? resultMessage)
        {
            ResultCode = resultCode;
            ResultMessage = resultMessage;
        }
    }

    public class ResultDTO<T> : ResponseDTO
    {
        public T? Data { get; set; }

        public ResultDTO(int resultCode, string? resultMessage, T? data) : base(resultCode, resultMessage)
        {
            Data = data;
        }
    }

    public class ResultListDTO<T> : ResultDTO<T>
    {
        public PaginationDTO? Pagination { get; set; }

        public ResultListDTO(int resultCode, string? resultMessage, T? data, PaginationDTO? pagination) : base(resultCode, resultMessage, data)
        {
            Pagination = pagination;
        }
    }

    public class PaginationDTO
    {
        public int TotalPages { get; set; }
        public int CurrentPage { get; set; }
        public int PerPage { get; set; }
    }
}

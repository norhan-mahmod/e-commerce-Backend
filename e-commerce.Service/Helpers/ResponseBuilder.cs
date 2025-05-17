using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_commerce.Core.Dtos;
using e_commerce.Core.Entities;

namespace e_commerce.Service.Helpers
{
    public static class ResponseBuilder<T> where T : class
    {
        public static ResponseDto<List<T>> BuildResponseWithMetaData<T>
            (List<T> data , int totalCount , int page , int limit) 
        {
            var numberOfPages = (int)Math.Ceiling((double)totalCount / limit);
            var respose = new ResponseDto<List<T>>()
            {
                ResultCount = totalCount,
                MetaData = new MetaDataDto()
                {
                    CurrentPage = page,
                    Limit = limit,
                    NumberOfPages = numberOfPages,
                    NextPage = page < numberOfPages ? page + 1 : numberOfPages
                },
                Data = data
            };
            return respose;
        }
    }
}

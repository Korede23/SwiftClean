using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwiftClean.Application.Dtos.ResponseModel
{
    public class BaseResponse <T>
    {
        public string Message { get; set; }
        public bool IsSuccess { get; set; }
        public  T Data { get; set; }
    }
}

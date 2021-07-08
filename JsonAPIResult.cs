using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DeliveryKing.Core
{
    public class JsonAPIResult : JsonResult
    {
        public JsonAPIResult(object value, int statusCode)
            : base(value)
        {
            StatusCode = statusCode;
        }
    }
}

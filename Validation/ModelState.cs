using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DeliveryKing.Core.ViewModel;

namespace DeliveryKing.Core.Validation
{
    public static class ModelState
    {
        public static IEnumerable<APIResultErrorCodeVM> GetErrors(this ModelStateDictionary modelStateDictionary)
        {
            return from sd in modelStateDictionary.Select(a => new { a.Key, a.Value}).ToList()
                from e in sd.Value.Errors
                select new APIResultErrorCodeVM()
                {
                    Field = sd.Key,
                    ErrorCode = e.ErrorMessage
                };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DeliveryKing.Core.ViewModel
{
    public record SelectListVM
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
    }
}

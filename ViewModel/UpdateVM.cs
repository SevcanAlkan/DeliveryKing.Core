﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DeliveryKing.Core.ViewModel
{
    public interface IUpdateVM
    {
        //DateTime? UpdateDT { get; set; }
        //Guid UpdateBy { get; set; }
    }
    public record UpdateVM : IUpdateVM
    {
        //public DateTime? UpdateDT { get; set; }
        //public Guid UpdateBy { get; set; }
    }
}

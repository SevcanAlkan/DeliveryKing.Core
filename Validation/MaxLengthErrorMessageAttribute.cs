﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DeliveryKing.Core.Validation
{
    public class MaxLengthErrorMessageAttribute : ValidationAttribute
    {
        private readonly int maxLength = 0;

        public MaxLengthErrorMessageAttribute(int maxLength)
        {
            this.maxLength = maxLength;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            try
            {
                int currentLength = 0;
                Type type = value.GetType();

                switch (type)
                {
                    case var _ when type.Equals(typeof(int)):
                        int.TryParse(value.ToString(), out currentLength);
                        break;
                    case var _ when type.Equals(typeof(string)):
                        string stringValue = Convert.ToString(value);
                        currentLength = stringValue.Length;
                        break;
                    default:
                        break;
                }

                if(currentLength > maxLength && maxLength <= 0)
                {
                    string errorMessage = AttributeErrorMessages.CombineWithParams(AttributeErrorMessages.MaxStringLength, maxLength.ToString());

                    return new ValidationResult(errorMessage);
                }
            }
            catch (Exception)
            {
                return new ValidationResult(AttributeErrorMessages.ErrorThrew);
            }

            return null;
        }
    }
}

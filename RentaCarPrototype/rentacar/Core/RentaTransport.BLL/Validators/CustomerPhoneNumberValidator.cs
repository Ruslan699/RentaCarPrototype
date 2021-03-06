﻿using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using RentaTransport.BLL.DTOs;

namespace RentaTransport.BLL.Validators
{
    public class CustomerPhoneNumberValidator : BaseValidator<CustomerPhoneNumberDTO>
    {
        public CustomerPhoneNumberValidator()
        {
            RuleFor(m => m.PhoneNumber).NotEmpty();
        }
    }
}

﻿using ProvaPub.Enums;
using ProvaPub.Models;
using ProvaPub.Services.Interfaces;

namespace ProvaPub.Services
{
    public class PaymentPix : OrderServicePayment
    {
        public override async Task<Order> PayOrder(PaymentMethod paymentMethod, 
            decimal paymentValue, 
            int customerId)
        {
            return await Task.FromResult(new Order()
            {
                Value = paymentValue,
                CustomerId = customerId
            });
        }
    }
}

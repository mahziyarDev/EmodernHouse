﻿using EModernHouse.Application.Services.Interfaces;
using EModernHouse.DataLayer.DTOs.Product;
using Microsoft.AspNetCore.Http;

namespace EModernHouse.Application.Services.Implementations
{
    public class PaymentService : IPaymentService
    {
        public PaymentStatus CreatePaymentRequest(string merchantId, int amount, string description, string callbackUrl, ref string redirectUrl, string userEmail = null, string userMobile = null)
        {
            var payment = new ZarinpalSandbox.Payment(amount);
            var res = payment.PaymentRequest(description, callbackUrl, userEmail, userMobile);

            if (res.Result.Status == (int)PaymentStatus.St100)
            {
                redirectUrl = "https://sandbox.zarinpal.com/pg/StartPay/" + res.Result.Authority;
                return (PaymentStatus)res.Result.Status;
            }

            return (PaymentStatus)res.Status;
        }



        public PaymentStatus PaymentVerification
            (string merchantId, string authority, int amount, ref long refId)
        {
            var payment = new ZarinpalSandbox.Payment(amount);
            var res = payment.Verification(authority).Result;
            refId = res.RefId;
            return (PaymentStatus)res.Status;
        }

        public string GetAuthorityCodeFromCallback(HttpContext context)
        {
            if (context.Request.Query["Status"] == "" ||
                context.Request.Query["Status"].ToString().ToLower() != "ok" ||
                context.Request.Query["Authority"] == "")
            {
                return null;
            }

            string authority = context.Request.Query["Authority"];
            return authority.Length == 36 ? authority : null;
        }
    }
}
using QcProjectSdk.Models;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace QcProjectSdk
{
    public static class QcProjectApiExtension
    {
        public static bool IsError(this QcProjectApiBaseModel input)
        {
            return !string.IsNullOrEmpty(input.Error);
        }
        public static bool IsSuccess(this QcProjectApiBaseModel input)
        {
            return string.IsNullOrEmpty(input.Error);
        }
    }
}

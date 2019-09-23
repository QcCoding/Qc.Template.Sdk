using Qc.QcProjectSdk.Models;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Qc.QcProjectSdk
{
    public static class QcProjectApiExtension
    {
        public static bool IsError(this QcProjectApiBaseModel input)
        {
            return input == null || !string.IsNullOrEmpty(input.Error);
        }
        public static bool IsSuccess(this QcProjectApiBaseModel input)
        {
            return input != null && string.IsNullOrEmpty(input.Error);
        }
    }
}

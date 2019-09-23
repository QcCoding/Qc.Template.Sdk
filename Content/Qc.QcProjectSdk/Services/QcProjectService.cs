using Microsoft.Extensions.Options;
using Qc.QcProjectSdk.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

namespace Qc.QcProjectSdk
{
    public class QcProjectService
    {
        private readonly HttpClient _httpClient;
        private readonly QcProjectConfig _apiConfig;
        private readonly IQcProjectSdkHook _sdkHook;
        public QcProjectService(IHttpClientFactory _httpClientFactory
            , IQcProjectSdkHook QcProjectSdkHook
            )
        {
            _sdkHook = QcProjectSdkHook;
            _apiConfig = QcProjectSdkHook.GetConfig();
            if (_apiConfig == null)
                throw new Exception("QcProject not configured");
            _httpClient = _httpClientFactory.CreateClient("QcProject");
            if (!string.IsNullOrWhiteSpace(_apiConfig.ApiUrl))
                _httpClient.BaseAddress = new Uri(_apiConfig.ApiUrl);
            _httpClient.BaseAddress = new Uri(_apiConfig.ApiUrl);
            if (_apiConfig.Timeout.HasValue)
                _httpClient.Timeout = TimeSpan.FromSeconds(_apiConfig.Timeout.Value);
        }

    }
}

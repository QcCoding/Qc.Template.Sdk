using Microsoft.Extensions.Options;
using Qc.QcProjectSdk.Models;
using Qc.QcProjectSdk.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Qc.QcProjectSdk
{
    public class DefaultQcProjectSdkHook : IQcProjectSdkHook
    {
        private readonly QcProjectConfig _apiConfig;
        public DefaultQcProjectSdkHook(IOptions<QcProjectConfig> options)
        {
            _apiConfig = options.Value;
        }
        /// <summary>
        /// 获取配置
        /// </summary>
        /// <returns></returns>
        public QcProjectConfig GetConfig()
        {
            return _apiConfig;
        }
        /// <summary>
        /// 从缓存中获取AccessToken等信息
        /// </summary>
        /// <returns></returns>
        public QcProjectAccessTokenModel GetTokenInfo(string apikey)
        {
            string readPath = Path.Combine(Path.GetFullPath(_apiConfig.SaveTokenDirPath), apikey + ".txt");
            if (!File.Exists(readPath))
                return null;
            var accessResult = File.ReadAllText(readPath);
            var result = JsonHelper.Deserialize<QcProjectAccessTokenModel>(accessResult);
            if (result.ExpiresEndTime.HasValue && result.ExpiresEndTime.Value <= DateTime.Now)
                return null;
            return result;
        }
        /// <summary>
        /// 保存Token信息
        /// </summary>
        /// <returns></returns>
        public QcProjectAccessTokenModel SaveTokenInfo(QcProjectAccessTokenModel input)
        {
            if (!Directory.Exists(_apiConfig.SaveTokenDirPath))
            {
                Directory.CreateDirectory(_apiConfig.SaveTokenDirPath);
            }
            string savePath = Path.Combine(_apiConfig.SaveTokenDirPath, input.ApiKey + ".txt");
            System.IO.File.WriteAllText(savePath, JsonHelper.Serialize(input));
            return input;
        }
    }
}

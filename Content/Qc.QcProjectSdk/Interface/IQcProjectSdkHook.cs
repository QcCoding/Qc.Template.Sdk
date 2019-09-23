using Qc.QcProjectSdk.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Qc.QcProjectSdk
{
    public interface IQcProjectSdkHook
    {
        /// <summary>
        /// 获取OCR配置
        /// </summary>
        /// <returns></returns>
        QcProjectConfig GetConfig();
        /// <summary>
        /// 从缓存中获取AccessToken
        /// </summary>
        /// <param name="apiKey">应用接口Key</param>
        /// <returns></returns>
        QcProjectAccessTokenModel GetTokenInfo(string apiKey);
        /// <summary>
        /// 保存Token信息
        /// </summary>
        /// <returns></returns>
        QcProjectAccessTokenModel SaveTokenInfo(QcProjectAccessTokenModel input);
    }
}

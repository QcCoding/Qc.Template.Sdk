# Qc.Template.Sdk

一个 sdk 封装模板，可基于此模板构建 .net netstandard2.0 sdk 项目基架

[![Nuget](https://img.shields.io/nuget/v/Qc.Template.Sdk)](https://www.nuget.org/packages/Qc.Template.Sdk/)

## 使用

```
# 导入模板
dotnet new -i Qc.Template.Sdk
# 使用模板创建项目
dotnet new qcsdk -n Wechat  -o ./Qc.WechatSdk --ProjectName 微信公众号平台
```


## clone 后安装/卸载模板

- 安装模板：
  `dotnet new -i .\`

- 卸载模板
  `dotnet new -u %cd%`

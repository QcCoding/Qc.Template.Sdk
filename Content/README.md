# QcProjectSdk

## Qc.QcProjectSdk

`Qc.QcProjectSdk` 时一个基于 `.NET Standard 2.0` 构建，对(ProjectName)平台的常用接口进行了封装。


### 使用 QcProjectSdk


#### 一.安装程序包

[![Nuget](https://img.shields.io/nuget/v/Qc.QcProjectSdk)](https://www.nuget.org/packages/Qc.QcProjectSdk/)

- dotnet cli  
  `dotnet add package Qc.ProjectSdk`
- 包管理器  
  `Install-Package Install-Package Qc.QcProjectSdk`

#### 二.添加配置

> 如需实现自定义存储 AccessToken，动态获取应用配置，可自行实现接口 `IQcProjectSdkHook`  
> 默认提供 `DefaultQcProjectSdkHook`，存储 AccessToken 等信息到指定目录(默认./AppData)

```cs
using QcProjectSdk;
public void ConfigureServices(IServiceCollection services)
{
  //...
  services.AddQcProjectSdk<QcProjectSdk.DefaultQcProjectSdkHook>(opt =>
  {
      opt.ApiKey = "Api Key";
      opt.SecretKey = "Secret Key";
  });
  //...
}
```

#### 三.代码中使用

在需要地方注入`QcProjectService`后即可使用

### QcProjectConfig 配置项

QcProject文档地址: 

## 示例说明

`Qc.QcProjectSdk.Sample` 为示例项目，可进行测试

﻿// 项目展示地址:"http://www.ddxc.org/"
 // 如果你有什么好的建议或者觉得可以加什么功能，请加QQ群：104390185大家交流沟通
// 项目展示地址:"http://www.yoyocms.com/"
//博客地址：http://www.cnblogs.com/wer-ltm/
//代码生成器帮助文档：http://www.cnblogs.com/wer-ltm/p/5777190.html
// <Author-作者>角落的白板笔</Author-作者>
// Copyright © YoYoCms@中国.2017-07-03T17:31:48. All Rights Reserved.
//<生成时间>2017-07-03T17:31:48</生成时间>
using System;
using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Runtime.Validation;
using Abp.Extensions;
using YoYoCms.AbpProjectTemplate.smsmessage;

namespace YoYoCms.AbpProjectTemplate.smsmessage.Dtos
{
    /// <summary>
    /// 短信日志记录表新增和编辑时用Dto
    /// </summary>
    
    public class CreateOrUpdateSmsMessagelogInput  
    {
    /// <summary>
    /// 短信日志记录表编辑Dto
    /// </summary>
		public SmsMessagelogEditDto  SmsMessagelogEditDto {get;set;}
 
    }
}

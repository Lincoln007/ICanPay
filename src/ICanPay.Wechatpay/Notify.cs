﻿using ICanPay.Core;
using System.ComponentModel.DataAnnotations;

namespace ICanPay.Wechatpay
{
    public class Notify : INotify
    {
        /// <summary>
        /// 应用ID
        /// </summary>
        [Display(Name = Constant.APPID)]
        public string AppId { get; set; }

        /// <summary>
        /// 商户号
        /// </summary>
        [Display(Name = Constant.MCH_ID)]
        public string MchId { get; set; }

        /// <summary>
        /// 设备号
        /// </summary>
        [Display(Name = Constant.DEVICE_INFO)]
        public string DeviceInfo { get; set; }

        /// <summary>
        /// 随机字符串
        /// </summary>
        [Display(Name = Constant.NONCE_STR)]
        public string NonceStr { get; set; }

        /// <summary>
        /// 签名
        /// </summary>
        [Display(Name = Constant.SIGN)]
        public string Sign { get; set; }

        /// <summary>
        /// 业务结果
        /// </summary>
        [Display(Name = Constant.RESULT_CODE)]
        public string ResultCode { get; set; }

        /// <summary>
        /// 错误代码
        /// </summary>
        [Display(Name = Constant.ERR_CODE)]
        public string ErrCode { get; set; }

        /// <summary>
        /// 错误代码描述
        /// </summary>
        [Display(Name = Constant.ERR_CODE_DES)]
        public string ErrCodeDes { get; set; }

        /// <summary>
        /// 交易类型
        /// </summary>
        [Display(Name = Constant.TRADE_TYPE)]
        public string TradeType { get; set; }

        /// <summary>
        /// 微信生成的预支付回话标识，用于后续接口调用中使用，该值有效期为2小时
        /// </summary>
        [Display(Name = Constant.PREPAY_ID)]
        public string PrepayId { get; set; }

        /// <summary>
        /// 返回状态码
        /// </summary>
        [Display(Name = Constant.RETURN_CODE)]
        public string ReturnCode { get; set; }

        /// <summary>
        /// 返回信息
        /// </summary>
        [Display(Name = Constant.RETURN_MSG)]
        public string ReturnMsg { get; set; }

        /// <summary>
        /// 支付跳转链接
        /// mweb_url为拉起微信支付收银台的中间页面，可通过访问该url来拉起微信客户端，完成支付,mweb_url的有效期为5分钟。
        /// </summary>
        [Display(Name = Constant.MWEB_URL)]
        public string MWebUrl { get; set; }

        /// <summary>
        /// 二维码链接
        /// trade_type为NATIVE时有返回，用于生成二维码，展示给用户进行扫码支付
        /// </summary>
        [Display(Name = Constant.CODE_URL)]
        public string CodeUrl { get; set; }
    }
}

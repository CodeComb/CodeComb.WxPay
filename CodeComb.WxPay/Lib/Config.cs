using System;
using System.Collections.Generic;
using System.Web;

namespace CodeComb.WxPay
{
    /**
    * 	配置账号信息
    */
    public static class Config
    {
        //=======【基本信息设置】=====================================
        /* 微信公众号信息配置
        * APPID：绑定支付的APPID（必须配置）
        * MCHID：商户号（必须配置）
        * KEY：商户支付密钥，参考开户邮件设置（必须配置）
        * APPSECRET：公众帐号secert（仅JSAPI支付的时候需要配置）
        */

        /// <summary>
        /// 初始化WxPayAPI
        /// </summary>
        /// <param name="AppId">绑定支付的APPID（必须配置）</param>
        /// <param name="MchId">商户号（必须配置）</param>
        /// <param name="Key">商户支付密钥，参考开户邮件设置（必须配置）</param>
        /// <param name="AppSecret">公众帐号secert（仅JSAPI支付的时候需要配置）</param>
        public static void Init(string AppId, string MchId, string Key, string AppSecret = null)
        {
            APPID = AppId;
            MCHID = MchId;
            KEY = Key;
            APPSECRET = AppSecret;
        }

        /// <summary>
        /// 初始化证书信息，证书路径应注意填写绝对路径（仅退款、撤销订单时需要）
        /// </summary>
        /// <param name="Path">证书路径</param>
        /// <param name="Password">密码</param>
        public static void SetCert(string Path, string Password)
        {
            SSLCERT_PATH = Path;
            SSLCERT_PASSWORD = Password;
        }

        public static void SetCallBackURL(string URL)
        {
            NOTIFY_URL = URL;
        }

        public static void SetIP(string Ip)
        {
            IP = Ip;
        }

        public static void SetProxyURL(string ProxyURL)
        {
            PROXY_URL = ProxyURL;
        }

        public static string APPID = null;
        public static string MCHID = null;
        public static string KEY = null;
        public static string APPSECRET = null;

        //=======【证书路径设置】===================================== 
        /* 证书路径,注意应该填写绝对路径（仅退款、撤销订单时需要）
        */
        public static string SSLCERT_PATH = null;
        public static string SSLCERT_PASSWORD = null;



        //=======【支付结果通知url】===================================== 
        /* 支付结果通知回调url，用于商户接收支付结果
        */
        public static string NOTIFY_URL =null;

        //=======【商户系统后台机器IP】===================================== 
        /* 此参数可手动配置也可在程序中自动获取
        */
        public static string IP = "127.0.0.1";


        //=======【代理服务器设置】===================================
        /* 默认IP和端口号分别为0.0.0.0和0，此时不开启代理（如有需要才设置）
        */
        public static string PROXY_URL = "http://0.0.0.0:0";

        //=======【上报信息配置】===================================
        /* 测速上报等级，0.关闭上报; 1.仅错误时上报; 2.全量上报
        */
        public static int REPORT_LEVENL = 1;

        //=======【日志级别】===================================
        /* 日志等级，0.不输出日志；1.只输出错误信息; 2.输出错误和正常信息; 3.输出错误信息、正常信息和调试信息
        */
        public static int LOG_LEVENL = 0;
    }
}
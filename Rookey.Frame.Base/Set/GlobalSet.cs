﻿using Rookey.Frame.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rookey.Frame.Base.Set
{
    /// <summary>
    /// 员工用户名默认配置规则
    /// </summary>
    public enum UserNameAndEmpConfigRule
    {
        /// <summary>
        /// 以工号默认为用户名
        /// </summary>
        EmpCode = 0,

        /// <summary>
        /// 以邮箱前缀默认为用户名
        /// </summary>
        EmailPre = 1,

        /// <summary>
        /// 以邮箱默认为用户名
        /// </summary>
        Email = 2,

        /// <summary>
        /// 以手机号默认为用户名
        /// </summary>
        Mobile = 3
    }

    /// <summary>
    /// 全局设置
    /// </summary>
    public class GlobalSet
    {
        #region 系统设置

        private static UserNameAndEmpConfigRule _empUserNameConfigRule = UserNameAndEmpConfigRule.EmpCode;
        /// <summary>
        /// 员工用户名默认配置规则
        /// </summary>
        public static UserNameAndEmpConfigRule EmpUserNameConfigRule
        {
            get
            {
                string configRule = WebConfigHelper.GetAppSettingValue("UserNameConfigRule");
                if (!string.IsNullOrEmpty(configRule))
                    _empUserNameConfigRule = (UserNameAndEmpConfigRule)Enum.Parse(typeof(UserNameAndEmpConfigRule), configRule);
                return _empUserNameConfigRule;
            }
            set { _empUserNameConfigRule = value; }
        }

        private static bool _isAllowOtherConfigRuleLogin = true;
        /// <summary>
        /// 是否允许除当前配置规则以外的其他方式登录系统
        /// </summary>
        public static bool IsAllowOtherConfigRuleLogin
        {
            get
            {
                string isAllowOtherLogin = WebConfigHelper.GetAppSettingValue("IsAllowOtherConfigRuleLogin");
                if (!string.IsNullOrEmpty(isAllowOtherLogin))
                    _isAllowOtherConfigRuleLogin = isAllowOtherLogin.ObjToBool();
                return _isAllowOtherConfigRuleLogin;
            }
            set { _isAllowOtherConfigRuleLogin = value; }
        }

        private static int _exportDataPagingSize = 2000;
        /// <summary>
        /// 导出数据分页大小，默认500
        /// </summary>
        public static int ExportDataPagingSize
        {
            get { return _exportDataPagingSize; }
            set
            {
                if (value > 500)
                {
                    _exportDataPagingSize = value;
                }
            }
        }

        private static bool _isShowStyleBtn = false;
        /// <summary>
        /// 是否显示样式按钮
        /// </summary>
        public static bool IsShowStyleBtn
        {
            get { return _isShowStyleBtn; }
            set { _isShowStyleBtn = value; }
        }

        private static bool _isStartLoadCache = true;
        /// <summary>
        /// 启动程序时是否加载所有缓存数据
        /// </summary>
        public static bool IsStartLoadCache
        {
            get { return _isStartLoadCache; }
        }

        private static bool _isHorizontalMenu = false;
        /// <summary>
        /// 是否为横向菜单
        /// </summary>
        public static bool IsHorizontalMenu
        {
            get { return _isHorizontalMenu; }
        }

        private static bool _isEnabledPageCache = false;
        /// <summary>
        /// 是否启用页面缓存
        /// </summary>
        public static bool IsEnabledPageCache
        {
            get 
            {
                string isEnabledPageCache = WebConfigHelper.GetAppSettingValue("IsEnabledPageCache");
                if (!string.IsNullOrEmpty(isEnabledPageCache))
                    _isEnabledPageCache = isEnabledPageCache.ObjToBool();
                return _isEnabledPageCache; 
            }
            set { _isEnabledPageCache = value; }
        }

        private static bool _isAllowGridAttachModule = true;
        /// <summary>
        /// 列表是否允许加载明细、附属模块
        /// </summary>
        public static bool IsAllowAttachModule
        {
            get 
            {
                string isAllowGridAttachModule = WebConfigHelper.GetAppSettingValue("IsAllowAttachModule");
                if (!string.IsNullOrEmpty(isAllowGridAttachModule))
                    _isAllowGridAttachModule = isAllowGridAttachModule.ObjToBool();
                return _isAllowGridAttachModule; 
            }
            set { _isAllowGridAttachModule = value; }
        }

        private static bool _isDefaultSimpleSearch = true;
        /// <summary>
        /// 默认显示简单搜索模式
        /// </summary>
        public static bool IsDefaultSimpleSearch
        {
            get { return _isDefaultSimpleSearch; }
            set { _isDefaultSimpleSearch = value; }
        }

        #endregion

        #region 邮箱常量

        private static string _smtpServer = "";
        /// <summary>
        /// Smtp服务器
        /// </summary>
        public static string SmtpServer
        {
            get 
            {
                string smtpServer = WebConfigHelper.GetAppSettingValue("EmailServer");
                if (!string.IsNullOrEmpty(smtpServer))
                    _smtpServer = smtpServer;
                return _smtpServer; 
            }
            set { _smtpServer = value; }
        }

        private static int _smtpPort = 25;
        /// <summary>
        /// Smtp端口号
        /// </summary>
        public static int SmtpPort
        {
            get { return _smtpPort; }
            set { _smtpPort = value; }
        }

        private static string _sysEmail = ""; //oa@abc.com
        /// <summary>
        /// 系统邮箱账号
        /// </summary>
        public static string SysEmail
        {
            get 
            {
                string sysEmail = WebConfigHelper.GetAppSettingValue("SysEmail");
                if (!string.IsNullOrEmpty(sysEmail))
                    _sysEmail = sysEmail;
                return _sysEmail; 
            }
            set { _sysEmail = value; }
        }

        private static string _sysEmailPwd = "";
        /// <summary>
        /// 系统邮箱密码
        /// </summary>
        public static string SysEmailPwd
        {
            get 
            {
                string sysEmailPwd = WebConfigHelper.GetAppSettingValue("SysEmailPwd");
                if (!string.IsNullOrEmpty(sysEmailPwd))
                    _sysEmailPwd = sysEmailPwd;
                return _sysEmailPwd; 
            }
            set { _sysEmailPwd = value; }
        }

        private static string _sysEmailDes = "";
        /// <summary>
        /// 系统邮箱账号描述
        /// </summary>
        public static string SysEmailDes
        {
            get 
            {
                string sysEmailDes = WebConfigHelper.GetAppSettingValue("SysEmailDes");
                if (!string.IsNullOrEmpty(sysEmailDes))
                    _sysEmailDes = sysEmailDes;
                return _sysEmailDes; 
            }
            set { _sysEmailDes = value; }
        }

        #endregion
    }
}

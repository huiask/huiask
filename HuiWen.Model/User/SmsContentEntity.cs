using System;

namespace HuiWen.Model
{
    public class SmsContentEntity
    {
        private int id;
        /// <summary>
        /// 主键
        /// </summary>
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        private int templateId;
        /// <summary>
        /// 模板主键
        /// </summary>
        public int TemplateId
        {
            get
            {
                return templateId;
            }
            set
            {
                templateId = value;
            }
        }

        private int userId;
        /// <summary>
        /// 用户主键
        /// </summary>
        public int UserId
        {
            get
            {
                return userId;
            }
            set
            {
                userId = value;
            }
        }

        private String contents;
        /// <summary>
        /// 短信内容(汉字70个字符,英文140个字符)
        /// </summary>
        public String Contents
        {
            get
            {
                return contents;
            }
            set
            {
                contents = value;
            }
        }

        private String mobile;
        /// <summary>
        /// 手机号码
        /// </summary>
        public String Mobile
        {
            get
            {
                return mobile;
            }
            set
            {
                mobile = value;
            }
        }

        private String validateNumber;
        /// <summary>
        /// 验证码(6位随机数字)
        /// </summary>
        public String ValidateNumber
        {
            get
            {
                return validateNumber;
            }
            set
            {
                validateNumber = value;
            }
        }

        private int statusCode;
        /// <summary>
        /// 短信发送状态编号(0-已提交:1-已发送:2-发送失败)

        ///    
        /// </summary>
        public int StatusCode
        {
            get
            {
                return statusCode;
            }
            set
            {
                statusCode = value;
            }
        }

        private DateTime createOn;
        /// <summary>
        /// 创建日期
        /// </summary>
        public DateTime CreateOn
        {
            get
            {
                return createOn;
            }
            set
            {
                createOn = value;
            }
        }

        /// <summary>
        /// 0=未使用 1=已使用
        /// </summary>
        public int flag { get; set; }
    }
}

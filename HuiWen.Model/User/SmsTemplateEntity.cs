using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuiWen.Model
{
    public class SmsTemplateEntity
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

        private String code;
        /// <summary>
        /// 短信模板编号
        /// </summary>
        public String Code
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
            }
        }

        private String title;
        /// <summary>
        /// 短信模板标题
        /// </summary>
        public String Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        private String contents;
        /// <summary>
        /// 短信模板内容
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

        private String description;
        /// <summary>
        /// 短信模板描述
        /// </summary>
        public String Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }

        private int statusCode;
        /// <summary>
        /// 短信模板状态编号(0-不可用:1-可用)
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

        private int createUserId;
        /// <summary>
        /// 创建用户主键
        /// </summary>
        public int CreateUserId
        {
            get
            {
                return createUserId;
            }
            set
            {
                createUserId = value;
            }
        }

        private DateTime modifiedOn;
        /// <summary>
        /// 修改日期
        /// </summary>
        public DateTime ModifiedOn
        {
            get
            {
                return modifiedOn;
            }
            set
            {
                modifiedOn = value;
            }
        }
    }
}

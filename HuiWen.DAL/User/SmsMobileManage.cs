using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HuiWen.Model;

namespace HuiWen.Dal
{

    public class SmsMobileManage : UserDalBase
    {
        #region 获取短信模板
        /// <summary>
        /// 获取短信模板
        /// </summary>
        public SmsTemplateEntity GetSmsTemplate(string code)
        {
            string sqlQuery = "select * from [SmsTemplate] where Code=@Code";
            return DbContext.Execute(conn => conn.Query<SmsTemplateEntity>(sqlQuery, new { code = code }).FirstOrDefault());
        }
        #endregion

        #region 新增短信内容
        /// <summary>
        /// 新增短信内容
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public int AddSmsContent(SmsContentEntity entity)
        {
            string sqlQuery = "insert into [SysContent] values (@TemplateId,@UserId,@Mobile,@ValidateNumber,@StatusCode,getadate())";
            return DbContext.Execute(conn => conn.Execute(sqlQuery, new { TemplateId = entity.TemplateId, UserId = entity.UserId, Mobile = entity.Mobile, ValidateNumber = entity.ValidateNumber, StatusCode = entity.StatusCode }));
        }
        #endregion

        #region 查询短信信息
        /// <summary>
        /// 查询短信信息
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="templateId"></param>
        /// <param name="mobile"></param>
        /// <returns></returns>
        public SmsContentEntity GetSmsContent(int? userId, int templateId, int mobile)
        {
            string sqlQuery = "select * from [SysContent] where TemplateId=@TemplateId and mobile=@Mobile and Flag=0 and StatusCode=1";
            if (userId != null)
                sqlQuery += " and userId=@userId";
            return DbContext.Execute(conn => conn.Query<SmsContentEntity>(sqlQuery, new { TemplateId = templateId, Mobile = mobile, userId = userId }).FirstOrDefault());
        }
        #endregion
    }
}

using HuiWen.Dal;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HuiWen.Dal;
using HuiWen.Model;

namespace KaFen.Service.User
{

    #region 获取短信模板 HuiAsk/Event/GetSmsTemplateService

    [RestService("HuiAsk/User/GetSmsTemplateService")]
    public class SmsMobileServiceRequset
    {

        public string code { get; set; }

    }
    public class GetSmsTemplateService : RestServiceBase<SmsMobileServiceRequset>
    {

        public override object OnGet(SmsMobileServiceRequset request)
        {
            return new SmsMobileManage().GetSmsTemplate(request.code);

        }

    }

    #endregion

    #region 新增短信内容 HuiAsk/Event/AddSmsContentService

    [RestService("HuiAsk/User/AddSmsContentService")]
    public class AddSmsContentRequset : SmsContentEntity
    {

    }
    public class AddSmsContentService : RestServiceBase<AddSmsContentRequset>
    {

        public override object OnPut(AddSmsContentRequset request)
        {
            return new SmsMobileManage().AddSmsContent(request);

        }

    }

    #endregion

    #region 新建用户 HuiAsk/User/GetSmsContentRequest

    [RestService("HuiAsk/User/GetSmsContentRequest")]
    public class GetSmsContentRequest
    {

        public int? userId { get; set; }

        public int templateId { get; set; }

        public int mobile { get; set; }
    }
    public class GetSmsContentRequestService : RestServiceBase<GetSmsContentRequest>
    {

        public override object OnGet(GetSmsContentRequest request)
        {
            return new SmsMobileManage().GetSmsContent(request.userId, request.templateId, request.mobile);

        }

    }

    #endregion
}

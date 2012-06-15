using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Chukou1Demo.CK1V2_1;

namespace Chukou1Demo.Aspnet
{
    public partial class M2CGetPackage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var client = new CK1SoapClient();
            UserKeyAndToken ukt = new UserKeyAndToken();
            var req = new M2CGetPackageRequest()
            {
                Token = ukt.getToken(),
                UserKey = ukt.getUserKey(),
                Sign = "ETX120605TST000015",
                MessageID = DateTime.Now.ToString("yyyyMMddHHmmss") + "M2CGetPackage Demo",
                Version = "V2.1",
            };

            var resp = client.M2CGetPackage(req);
            if (resp.Ack == EnumAck.Success)
            {
                Response.Write("查询包裹成功" + req.Sign);
            }
            else
            {
                Response.Write("查询包裹失败" + req.Sign + resp.Message);
            }
        }
    }
}
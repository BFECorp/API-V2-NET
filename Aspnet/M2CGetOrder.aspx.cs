using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Chukou1Demo.CK1;

namespace Chukou1Demo.Aspnet
{
    public partial class M2CGetOrder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var client = new CK1SoapClient();
            UserKeyAndToken ukt = new UserKeyAndToken();
            var req = new M2CGetOrderRequest()
            {
                Token = ukt.getToken(),
                UserKey = ukt.getUserKey(),
                OrderSign = "ETST12060500019",
                MessageID = DateTime.Now.ToString("yyyyMMddHHmmss") + "M2CGetOrder Demo",
                Version = "V2.1",
            };

            var resp = client.M2CGetOrder(req);
            if (resp.Ack == EnumAck.Success)
            {
                Response.Write("查询订单成功" + req.OrderSign);
            }
            else
            {
                Response.Write("查询订单失败" + req.OrderSign + resp.Message);
            }
        }
    }
}

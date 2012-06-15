using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Chukou1Demo.CK1V2_1;

namespace Chukou1Demo.Aspnet
{
    public partial class M2CCompleteOrder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var client = new CK1SoapClient();
            UserKeyAndToken ukt = new UserKeyAndToken();
            var req = new M2CCompleteOrderRequest()
            {
                Token = ukt.getToken(),
                UserKey = ukt.getUserKey(),
                ActionType = EnumActionType.Submit,
                OrderSign = "ETST12060500019",
                MessageID = DateTime.Now.ToString("yyyyMMddHHmmss") + "M2CCompleteOrder Demo",
                Version = "V2.1",
            };

            var resp = client.M2CCompleteOrder(req);
            if (resp.Ack == EnumAck.Success)
            {
                Response.Write("提审订单成功" + req.OrderSign);
            }
            else
            {
                Response.Write("提审订单失败" + req.OrderSign + resp.Message);
            }
        }
    }
}
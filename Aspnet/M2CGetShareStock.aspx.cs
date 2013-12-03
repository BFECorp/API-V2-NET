using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Chukou1Demo.CK1;

namespace Chukou1Demo.Aspnet
{
    public partial class M2CGetShareStock : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var client = new CK1SoapClient();
            UserKeyAndToken ukt = new UserKeyAndToken();
            var req = new M2CGetShareStockRequest()
            {
                Token = ukt.getToken(),
                UserKey = ukt.getUserKey(),
                StorageNo = "EJLW00000006",
                MessageID = DateTime.Now.ToString("yyyyMMddHHmmss") + "M2CGetShareStock Demo",
                Version = "V2.1",
            };

            var resp = client.M2CGetShareStock(req);
            if (resp.Ack == EnumAck.Success)
            {
                Response.Write("查询共享库存成功" + req.StorageNo + "可用库存" + resp.StockDetail.AvailableAmount);
            }
            else
            {
                Response.Write("查询共享库存失败" + req.StorageNo + resp.Message);
            }
        }
    }
}

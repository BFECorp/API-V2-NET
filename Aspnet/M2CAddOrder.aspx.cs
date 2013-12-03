using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Chukou1Demo.CK1;

namespace Chukou1Demo.Aspnet
{
    public partial class M2CAddOrder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var client = new CK1SoapClient();
            UserKeyAndToken ukt = new UserKeyAndToken();
            var req = new M2CAddOrderRequest()
            {
                Token = ukt.getToken(),
                UserKey = ukt.getUserKey(),
                MessageID = DateTime.Now.ToString("yyyyMMddHHmmss") + "M2CAddOrder Demo",
                Version = "V2.1",
                Submit = false,
                OrderDetail = new M2COrder()
                {
                    Remark = DateTime.Now.ToString("yyyyMMddHHmmss"),
                    Warehouse = EnumWarehouse.UK,
                }
            };

            var lstPackage = new List<M2CPackage>();
            var package = new M2CPackage()
            {
                ShipToAddress = new ShipToAddress()
                {
                    Contact = "Wills",
                    Street1 = "street1",
                    Street2 = "street2",
                    City = "city",
                    Province = "province",
                    PostCode = "510026",
                    Country = "United Kingdom",
                    Phone = "82312191",
                    Email = "xi.zhou@chukou1.com"
                },
                Custom = DateTime.Now.ToString("yyyyMMddHHmmssfff"),
                Shipping = "None",
                ShippingV2_1 =  OutStoreShippingV2_1.UKRRM,
            };
            var lstProduct = new List<OutStoreProduct>();
            lstProduct.Add(new OutStoreProduct()
            {
                StorageNo = "EJLW00000006",
                Quantity = 1
            });
            package.ProductList = lstProduct.ToArray();
            lstPackage.Add(package);
            req.OrderDetail.PackageList = lstPackage.ToArray();

            var resp = client.M2CAddOrder(req);
            if (resp.Ack == EnumAck.Success)
            {
                Response.Write("添加订单成功" + resp.OrderSign);
            }
            else
            {
                Response.Write("添加订单失败" + resp.Message);
            }

        }
    }
}

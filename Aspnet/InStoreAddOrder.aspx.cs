using System;
using System.Collections.Generic;

namespace Chukou1Demo.Aspnet
{
    public partial class InStoreAddOrder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Initialize();
            }
        }

        private void Initialize()
        {
            txtMessageID.Text = "";
            txtVersion.Text = "";
            pnlResponse.Visible = false;
            pnlRequest.Visible = true;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            var clint = new CK1.CK1SoapClient();

            #region 生成包裹

            var productList = new List<CK1.InStoreProduct>();
            productList.Add(new CK1.InStoreProduct()
            {
                DeclaredName = "水龍頭",
                DeclaredValue = 100,
                Quantity = 100,
                SKU = "水龙头",
            });


            var caseList = new List<CK1.InStoreCase>();
            caseList.Add(new CK1.InStoreCase()
            {
                CaseNo = 0,
                CaseSign = "Test123",
                Packing = new CK1.Packing()
                {
                    Height = 10,
                    Length = 10,
                    Width = 10,
                },
                State = CK1.OrderInState.Initial,
                Weight = 200,
                ProductList = productList.ToArray(),
            });

            var orderDetail = new CK1.InStoreOrder()
            {
                ArriveTime = DateTime.Today,
                PickupType = ddlPickupType.SelectedIndex,
                OrderSign = txtOrderSign.Text,
                Remark = txtRemark.Text,
                CaseList = caseList.ToArray(),
                PickUpAddress = new CK1.PickUpAddress()
                {
                    Country = "United States",
                    Street1 = "1712 Jones Street",
                    Contact = "Curtis Wilson",
                    Province= "United States",
                    District = "United States",
                    PostCode = "77511",
                    City = "Alvin",
                },
                State=CK1.OrderInState.Initial,  
            };

            switch (ddlLocation.SelectedIndex)
            {
                case 0:
                    orderDetail.Location = CK1.EnumLocation.GZ;
                    break;
                case 1:
                    orderDetail.Location = CK1.EnumLocation.SZ;
                    break;
                default:
                    orderDetail.Location = CK1.EnumLocation.SH;
                    break;
            }
            switch (ddlShippingMethod.SelectedIndex)
            {
                case 0:
                    orderDetail.ShippingMethod = CK1.LogisticsShippingMethod.AIR;
                    break;
                case 1:
                    orderDetail.ShippingMethod = CK1.LogisticsShippingMethod.SEA;
                    break;
                case 2:
                    orderDetail.ShippingMethod = CK1.LogisticsShippingMethod.EMS;
                    break;
                case 3:
                    orderDetail.ShippingMethod = CK1.LogisticsShippingMethod.DHL;
                    break;
                default:
                    orderDetail.ShippingMethod = CK1.LogisticsShippingMethod.UPS;
                    break;
            }
            switch (ddlWarehouse.SelectedIndex)
            {
                case 0:
                    orderDetail.Warehouse = CK1.EnumWarehouse.US;
                    break;
                case 1:
                    orderDetail.Warehouse = CK1.EnumWarehouse.AU;
                    break;
                case 2:
                    orderDetail.Warehouse = CK1.EnumWarehouse.UK;
                    break;
                default:
                    orderDetail.Warehouse = CK1.EnumWarehouse.MA;
                    break;
            }
            #endregion
            UserKeyAndToken ukt = new UserKeyAndToken();

            var request = new CK1.InStoreAddOrderRequest()
            {
                MessageID = txtMessageID.Text,
                UserKey = ukt.getUserKey(),
                Token = ukt.getToken(),
                Submit = ccbSubmit.Checked,
                Version = txtVersion.Text,
                OrderDetail = orderDetail,
            };

            CK1.InStoreAddOrderResponse response = clint.InStoreAddOrder(request);

            lblAck.Text = response.Ack.ToString();
            lblInvocationID.Text = response.InvocationID;
            lblMessage.Text = response.Message;
            lblOrderSign.Text = response.OrderSign;

            pnlResponse.Visible = true;
            pnlRequest.Visible = false;
        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            Initialize();
        }
    }
}
using System;
using System.Web.UI.MobileControls;
using System.Collections.Generic;
using Chukou1Demo.CK1;


namespace Chukou1Demo.Aspnet
{
    public partial class ExpressAddOrder : System.Web.UI.Page
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
            pnlResponse.Visible = false;
            pnlRequest.Visible = true;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            #region 生成包裹

            var product = new List<ExpressProduct>();
            product.Add(new ExpressProduct
            {
                CustomsTitleCN = "怀表",
                CustomsTitleEN = "POCKET WATCH",
                Quantity = 1,
                SKU = "WP083",
                StorageNo = "test",
                Weight = 100,
                DeclareValue = Convert.ToDecimal(5.67),
            });

            var packageList = new List<ExpressPackage>();
            packageList.Add(new ExpressPackage
            {
                Custom = "OR201112230076",
                ShipToAddress = new ShipToAddress
                {
                    Contact= "nicolas courtais",
                    Street1= "37 rue general ferrié",
                    City= "grenoble",
                    Province= "Rhône-Alpes",
                    Country = "France",
                    PostCode = "38100",
                },
                Packing = new Packing
                {
                    Height = 1,
                    Length = 1,
                    Width = 1,
                },
                Remark = "备注信息",
                Status = OrderExpressState.Initial,
                TrackCode = "",
                Weight = 500,
                ProductList = product.ToArray(),
            });

            var orderDetail = new ExpressOrder
            {
                IsTracking = false,
                Location = "GZ",
                Remark = "测试订单",
                PackageList = packageList.ToArray(),
                PickUpAddress = new PickUpAddress
                {
                    Country = "United States",
                    Street1 = "1712 Jones Street",
                    Contact = "Curtis Wilson",
                    Province = "United States",
                    District = "United States",
                    PostCode = "77511",
                    City = "Alvin",
                    Company = "ABC",
                },

            };

            #endregion

            var clint = new CK1SoapClient();
            UserKeyAndToken ukt = new UserKeyAndToken();
            var request = new ExpressAddOrderNewRequest
            {
                UserKey = ukt.getUserKey(),
                Token = ukt.getToken(),
                Submit = false,
                OrderDetail = orderDetail,
                ExpressTypeNew = "HTM",
                MessageID = "SampleCallId"
            };
           
            ExpressAddOrderResponse response = clint.ExpressAddOrderNew(request);

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

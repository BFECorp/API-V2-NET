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
            txtMessageID.Text = "";
            txtVersion.Text = "";
            pnlResponse.Visible = false;
            pnlRequest.Visible = true;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            #region 生成包裹

            var product = new List<ExpressProduct>();
            product.Add(new ExpressProduct()
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
            packageList.Add(new ExpressPackage()
            {
                Custom = "OR201112230076",
                ShipToAddress = new ShipToAddress()
                {
                    Contact= "nicolas courtais",
                    Street1= "37 rue general ferrié",
                    City= "grenoble",
                    Province= "Rhône-Alpes",
                    Country = "France",
                    PostCode = "38100",
                },
                //ItemSign = "test123",
                Packing = new Packing()
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
                Location = txtLocation.Text,
                OrderSign = txtOrderSign.Text,
                PickupType = ddlPickUpType.SelectedIndex,
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
                //ExpressType = ExpressType.HKP,

            };

            #endregion

            var clint = new CK1SoapClient();
            UserKeyAndToken ukt = new UserKeyAndToken();
            var request = new ExpressAddOrderNewRequest
            {
                MessageID = txtMessageID.Text,
                UserKey = ukt.getUserKey(),
                Token = ukt.getToken(),
                Submit = false,
                Version = txtVersion.Text,
                OrderDetail = orderDetail,
                ExpressTypeNew = "HTM",
            };
           
            //switch (ddlExpressType.SelectedIndex)
            //{
            //    case 0:
            //        request.OrderDetail.ExpressType = ExpressType.CDD;
            //        break;
            //    case 1:
            //        request.OrderDetail.ExpressType = ExpressType.CEE;
            //        break;
            //    case 2:
            //        request.OrderDetail.ExpressType = ExpressType.CES;
            //        break;
            //    case 3:
            //        request.OrderDetail.ExpressType = ExpressType.CNP;
            //        break;
            //    case 4:
            //        request.OrderDetail.ExpressType = ExpressType.CTU;
            //        break;
            //    case 5:
            //        request.OrderDetail.ExpressType = ExpressType.CUE;
            //        break;
            //    case 6:
            //        request.OrderDetail.ExpressType = ExpressType.EMD;
            //        break;
            //    case 7:
            //        request.OrderDetail.ExpressType = ExpressType.EMS;
            //        break;
            //    case 8:
            //        request.OrderDetail.ExpressType = ExpressType.EUB;
            //        break;
            //    case 9:
            //        request.OrderDetail.ExpressType = ExpressType.HKD;
            //        break;
            //    case 10:
            //        request.OrderDetail.ExpressType = ExpressType.HKP;
            //        break;
            //    case 11:
            //        request.OrderDetail.ExpressType = ExpressType.SGP;
            //        break;
            //    case 12:
            //        request.OrderDetail.ExpressType = ExpressType.SHD;
            //        break;
            //    default:
            //        request.OrderDetail.ExpressType = ExpressType.UPS;
            //        break;
            //}
           
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

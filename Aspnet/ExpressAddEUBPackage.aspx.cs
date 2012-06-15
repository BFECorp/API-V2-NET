using System;
using System.Web.UI.MobileControls;
using System.Collections.Generic;

namespace Chukou1Demo.Aspnet
{
    public partial class ExpressAddEUBPackage : System.Web.UI.Page
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
            txtCustom.Text = "";
            pnlResponse.Visible = false;
            pnlRequest.Visible = true;
        }
        
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            CK1.CK1SoapClient clint = new CK1.CK1SoapClient();

            #region 生成E邮宝包裹
            
            var productList = new List<CK1.ExpressProduct>();   
            productList.Add(new CK1.ExpressProduct()
            {
                CustomsTitleEN = "Curtis Wilson",
                DeclareValue = 100,
                Quantity = 100,
                SKU = "水龙头",
                StorageNo = "STN110617TST000003",
                Weight = 10,
            });

            var packingList = new CK1.ExpressPackage()
            {
                Custom = "4CJ60689SW925",
                ItemSign = "Test123",
                Packing = new CK1.Packing()
                {
                    Height = 10,
                    Length = 10,
                    Width = 10,
                },
                ProductList = productList.ToArray(),
                Remark = "备注",
                ShipToAddress = new CK1.ShipToAddress()
                {
                    Country = "United States",
                    Street1 = "1712 Jones Street",
                    Contact = "Curtis Wilson",
                    PostCode = "77511",
                    City = "Alvin",
                    Province = "United States",
                },
                Status = CK1.OrderExpressState.Initial,
                TrackCode = txtTrackCode.Text,
                Weight = 10,
            };
            #endregion

            UserKeyAndToken ukt = new UserKeyAndToken();
            var request = new CK1.ExpressAddEUBPackageRequest()
            {
                MessageID = txtMessageID.Text,

                UserKey = ukt.getUserKey(),
                Token = ukt.getToken(),
                PackageDetail=packingList,
                PickUpAddress=new CK1.PickUpAddress()
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
                PickupType=ddlPickupType.SelectedIndex,
                Version = txtVersion.Text,
            };

            var response = clint.ExpressAddEUBPackage(request);

            lblAck.Text = response.Ack.ToString();
            lblInvocationID.Text = response.InvocationID;
            lblMessage.Text = response.Message;
            lblCustom.Text = response.Custom;
            lblItemSign.Text = response.ItemSign;
            lblTrackCode.Text = response.TrackCode;
            pnlResponse.Visible = true;
            pnlRequest.Visible = false;
        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            Initialize();
        }
    }
}
using System;
using System.Collections.Generic;


namespace Chukou1Demo.Aspnet
{
    using Chukou1Demo.CK1;

    public partial class OutStoreAddOrderNew : System.Web.UI.Page
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
            var client = new CK1.CK1SoapClient();

            #region 生成包裹

            var productList = new List<CK1.OutStoreProduct>();
            productList.Add(new CK1.OutStoreProduct()
            {
                SKU = txtSKU.Text,
                Quantity = Convert.ToInt32(txtQuantity.Text),
                StorageNo = txtStorageNo.Text
            });


            var packageList = new List<CK1.OutStorePackageNew>();
            packageList.Add(new CK1.OutStorePackageNew()
            {
                Custom = txtCustom.Text,
                Remark = txtRemark1.Text,
                Services = string.Empty,
                Sign = txtSign.Text,
                TrackingNumber = txtTrackingNumer.Text,
                State = CK1.OrderOutState.Initial,
                ProductList = productList.ToArray(),
                ShipToAddress = new CK1.ShipToAddress()
                {
                    Company = txtCompany.Text,
                    Contact = txtContact.Text,
                    Country = txtCountry.Text,
                    Email = txtEmail.Text,
                    Phone = txtPhone.Text,
                    PostCode = txtpostCode.Text,
                    Province = txtProvince.Text,
                    Street1 = txtStreet1.Text,
                    Street2 = txtStreet2.Text,
                    City = txtCity.Text,
                },
                Shipping = OutStoreShipping.None, //这个参数使用默认值
                ShippingV2_1 = OutStoreShippingV2_1.None, //这个参数使用默认值
                ShippingNew = Request["ServiceCode"] //字符类型的服务代码
            });
            #endregion

            UserKeyAndToken ukt = new UserKeyAndToken();
            var request = new CK1.OutStoreAddOrderNewRequest()
            {
                MessageID = txtMessageID.Text,
                UserKey = ukt.getUserKey(),
                Token = ukt.getToken(),
                Submit = ccbSubmit.Checked,
                Version = txtVersion.Text,
                OrderDetailNew = new CK1.OutStoreOrderNew()
                {
                    OrderSign = txtOrderSign.Text,
                    Remark = txtRemark.Text,
                    State = CK1.OrderOutState.Initial,
                    PackageListNew = packageList.ToArray(),
                },
            };

            request.OrderDetailNew.Warehouse = EnumWarehouse.None; //这个参数使用默认值

            request.OrderDetailNew.WarehouseNew = ddlWarehouse.SelectedValue;   //字符类型的仓库代码

            CK1.OutStoreAddOrderResponse response = client.OutStoreAddOrderNew(request);

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
using System;
using System.Collections.Generic;


namespace Chukou1Demo.Aspnet
{
    public partial class OutStoreAddOrder : System.Web.UI.Page
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

            var productList = new List<CK1.OutStoreProduct>();
            productList.Add(new CK1.OutStoreProduct()
            {
                SKU = txtSKU.Text,
                Quantity = Convert.ToInt32(txtQuantity.Text),
                StorageNo = txtStorageNo.Text
            });


            var packageList = new List<CK1.OutStorePackage>();
            packageList.Add(new CK1.OutStorePackage()
            {
                Custom = txtCustom.Text,
                Remark = txtRemark1.Text,
                Services = txtServices.Text,
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
                //Shipping = CK1.OutStoreShipping.DHL,
                
            });         
            switch (ddlShipping.SelectedIndex)
            {
                case 1:
                    packageList[0].Shipping = CK1.OutStoreShipping.Royalmail;
                    break;
                case 2:
                    packageList[0].Shipping = CK1.OutStoreShipping.DHL;
                    break;
                case 3:
                    packageList[0].Shipping = CK1.OutStoreShipping.UPS;
                    break;
                case 4:
                    packageList[0].Shipping = CK1.OutStoreShipping.USPS;
                    break;
                case 5:
                    packageList[0].Shipping = CK1.OutStoreShipping.AuPost;
                    break;
                case 6:
                    packageList[0].Shipping = CK1.OutStoreShipping.Parcelforce;
                    break;
                case 7:
                    packageList[0].Shipping = CK1.OutStoreShipping.Fedex;
                    break;
                default:
                    packageList[0].Shipping = CK1.OutStoreShipping.DPD;
                    break;
            }
            #endregion

            UserKeyAndToken ukt = new UserKeyAndToken();
            var request = new CK1.OutStoreAddOrderRequest()
            {
                MessageID = txtMessageID.Text,
                UserKey = ukt.getUserKey(),
                Token = ukt.getToken(),
                Submit = ccbSubmit.Checked,
                Version = txtVersion.Text,
                OrderDetail = new CK1.OutStoreOrder()
                {
                    OrderSign = txtOrderSign.Text,
                    Remark = txtRemark.Text,
                    State = CK1.OrderOutState.Initial,
                    PackageList = packageList.ToArray(),
                },
            };

            switch (ddlWarehouse.SelectedIndex + 1)
            {
                case 1:
                    request.OrderDetail.Warehouse = CK1.EnumWarehouse.US;
                    break;
                case 2:
                    request.OrderDetail.Warehouse = CK1.EnumWarehouse.AU;
                    break;
                case 3:
                    request.OrderDetail.Warehouse = CK1.EnumWarehouse.UK;
                    break;
                default:
                    request.OrderDetail.Warehouse = CK1.EnumWarehouse.MA;
                    break;
            }

            CK1.OutStoreAddOrderResponse response = clint.OutStoreAddOrder(request);

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
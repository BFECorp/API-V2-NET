using System;
using System.Collections.Generic;
using Chukou1Demo.CK1;
//using Chukou1Demo.CK1;

namespace Chukou1Demo.Aspnet
{
    public partial class OutStoreAddOrder_V2_1 : System.Web.UI.Page
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
            var clint = new CK1SoapClient();

            

            #region 生成包裹

            var productList = new List<OutStoreProduct>();
            productList.Add(new OutStoreProduct()
            {
                SKU = txtSKU.Text,
                Quantity = Convert.ToInt32(txtQuantity.Text),
                StorageNo = txtStorageNo.Text,
                DeclareName = txtDeclareName.Text,
                DeclareValue = txtDeclareValue.Text
            });

            var packageList = new List<OutStorePackage>();
            packageList.Add(new OutStorePackage()
            {
                Custom = txtCustom.Text,
                Remark = txtRemark1.Text,
                Services = txtServices.Text,
                Sign = txtSign.Text,
                TrackingNumber = txtTrackingNumer.Text,
                State = OrderOutState.Initial,
                ProductList = productList.ToArray(),
                ShipToAddress = new ShipToAddress()
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
                Shipping = OutStoreShipping.None,
                ShippingV2_1 = ConvertOutStoreShippingV2_1(ddlShipping.SelectedValue)
            });
            /*
            switch (ddlShipping.SelectedIndex)
            {
                case 1:
                    packageList[0].Shipping = OutStoreShipping.Royalmail;
                    break;
                case 2:
                    packageList[0].Shipping = OutStoreShipping.DHL;
                    break;
                case 3:
                    packageList[0].Shipping = OutStoreShipping.UPS;
                    break;
                case 4:
                    packageList[0].Shipping = OutStoreShipping.USPS;
                    break;
                case 5:
                    packageList[0].Shipping = OutStoreShipping.AuPost;
                    break;
                case 6:
                    packageList[0].Shipping = OutStoreShipping.Parcelforce;
                    break;
                case 7:
                    packageList[0].Shipping = OutStoreShipping.Fedex;
                    break;
                default:
                    packageList[0].Shipping = OutStoreShipping.DPD;
                    break;
            }*/

            #endregion 生成包裹

            UserKeyAndToken ukt = new UserKeyAndToken();
            var request = new OutStoreAddOrderRequest()
            {
                MessageID = txtMessageID.Text,
                UserKey = ukt.getUserKey(),
                Token = ukt.getToken(),
                Submit = ccbSubmit.Checked,
                Version = txtVersion.Text,
                OrderDetail = new OutStoreOrder()
                {
                    OrderSign = txtOrderSign.Text,
                    Remark = txtRemark.Text,
                    State = OrderOutState.Initial,
                    PackageList = packageList.ToArray(),
                    Warehouse = EnumWarehouse.US,
                },
            };

            //request.OrderDetail.Warehouse = EnumWarehouse.US;
            /*
            switch (ddlWarehouse.SelectedIndex)
            {
                case 1:
                    request.OrderDetail.Warehouse = EnumWarehouse.US;
                    break;
                case 2:
                    request.OrderDetail.Warehouse = EnumWarehouse.AU;
                    break;
                case 3:
                    request.OrderDetail.Warehouse = EnumWarehouse.UK;
                    break;
                default:
                    request.OrderDetail.Warehouse = EnumWarehouse.MA;
                    break;
            }*/

            OutStoreAddOrderResponse response = clint.OutStoreAddOrder(request);

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

        public static Chukou1Demo.CK1.OutStoreShippingV2_1 ConvertOutStoreShippingV2_1(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("can't be null or empty.", "name");
            }
            Chukou1Demo.CK1.OutStoreShippingV2_1 eenum;
            var result = Enum.TryParse<Chukou1Demo.CK1.OutStoreShippingV2_1>(name, true, out eenum);
            if (!result)
                throw new ArgumentException(" Invalid", "name");

            return eenum;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var clint = new CK1SoapClient();

            var EWH = EnumWarehouse.US;

            #region

            switch (ddlWarehouse.SelectedIndex + 1)
            {
                case 1:
                    EWH = EnumWarehouse.US;
                    break;
                case 2:
                    EWH = EnumWarehouse.AU;
                    break;
                case 3:
                    EWH = EnumWarehouse.UK;
                    break;
                default:
                    EWH = EnumWarehouse.MA;
                    break;
            }
            UserKeyAndToken ukt = new UserKeyAndToken();

            #endregion

            var request = new OutStoreAddOrderRequest()
            {
                MessageID = txtMessageID.Text,
                UserKey = ukt.getUserKey(),
                Token = ukt.getToken(),
                Submit = ccbSubmit.Checked,
                Version = txtVersion.Text,
                OrderDetail = new OutStoreOrder()
                {
                    OrderSign = txtOrderSign.Text,
                    Remark = txtRemark.Text,
                    State = OrderOutState.Initial,
                    PackageList = new List<OutStorePackage>() {
                        new OutStorePackage()
                        {
                            Custom = txtCustom.Text,
                            Remark = txtRemark1.Text,
                            Services = txtServices.Text,
                            Sign = txtSign.Text,
                            TrackingNumber = txtTrackingNumer.Text,
                            State = OrderOutState.Initial,
                            ProductList = new List<OutStoreProduct>(){
                                new OutStoreProduct()
                                {
                                    SKU = txtSKU.Text,
                                    Quantity = Convert.ToInt32(txtQuantity.Text),
                                    StorageNo = txtStorageNo.Text,
                                    DeclareName = txtDeclareName.Text,
                                    DeclareValue = txtDeclareValue.Text
                                },
                                new OutStoreProduct()
                                {
                                    Quantity = Convert.ToInt32(txtQuantity.Text),
                                    StorageNo = StorageNoAdd1.Text,
                                    DeclareName = txtDeclareName.Text,
                                    DeclareValue = txtDeclareValue.Text
                                },
                                new OutStoreProduct()
                                {
                                    SKU = txtSKU.Text,
                                    Quantity = Convert.ToInt32(txtQuantity.Text),
                                    StorageNo = StorageNoAdd2.Text,
                                    DeclareName = txtDeclareName.Text,
                                    DeclareValue = txtDeclareValue.Text
                                }
                            }
                            .ToArray(),
                            ShipToAddress = new ShipToAddress()
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
                            Shipping = OutStoreShipping.None,
                            ShippingV2_1 = ConvertOutStoreShippingV2_1(ddlShipping.SelectedValue)
                        }
                    }
                    .ToArray(),
                    Warehouse = EWH, // EnumWarehouse.US,
                },
            };

            OutStoreAddOrderResponse response = clint.OutStoreAddOrder(request);

            lblAck.Text = response.Ack.ToString();
            lblInvocationID.Text = response.InvocationID;
            lblMessage.Text = response.Message;
            lblOrderSign.Text = response.OrderSign;

            pnlResponse.Visible = true;
            pnlRequest.Visible = false;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            var clint = new CK1SoapClient();
            var EWH = EnumWarehouse.US;
            #region
            switch (ddlWarehouse.SelectedIndex + 1)
            {
                case 1:
                    EWH = EnumWarehouse.US;
                    break;
                case 2:
                    EWH = EnumWarehouse.AU;
                    break;
                case 3:
                    EWH = EnumWarehouse.UK;
                    break;
                default:
                    EWH = EnumWarehouse.MA;
                    break;
            }
            UserKeyAndToken ukt = new UserKeyAndToken();

            #endregion

            var request = new OutStoreAddOrderRequest()
            {
                MessageID = txtMessageID.Text,
                UserKey = ukt.getUserKey(),
                Token = ukt.getToken(),
                Submit = ccbSubmit.Checked,
                Version = txtVersion.Text,
                OrderDetail = new OutStoreOrder()
                {
                    OrderSign = txtOrderSign.Text,
                    Remark = txtRemark.Text,
                    State = OrderOutState.Initial,
                    PackageList = new List<OutStorePackage>() {
                        new OutStorePackage()
                        {
                            Custom = txtCustom.Text,
                            Remark = txtRemark1.Text,
                            Services = txtServices.Text,
                            Sign = txtSign.Text,
                            TrackingNumber = txtTrackingNumer.Text,
                            State = OrderOutState.Initial,
                            ProductList = new List<OutStoreProduct>(){
                                new OutStoreProduct()
                                {
                                    SKU = txtSKU.Text,
                                    Quantity = Convert.ToInt32(txtQuantity.Text),
                                    StorageNo = txtStorageNo.Text,
                                    DeclareName = txtDeclareName.Text,
                                    DeclareValue = txtDeclareValue.Text
                                },
                                
                            }
                            .ToArray(),
                            ShipToAddress = new ShipToAddress()
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
                            Shipping = OutStoreShipping.None,
                            ShippingV2_1 = ConvertOutStoreShippingV2_1(ddlShipping.SelectedValue)
                        },
                        new OutStorePackage()
                        {
                            Custom = txtCustom.Text,
                            Remark = txtRemark1.Text,
                            Services = txtServices.Text,
                            Sign = txtSign.Text,
                            TrackingNumber = txtTrackingNumer.Text,
                            State = OrderOutState.Initial,
                            ProductList = new List<OutStoreProduct>(){
                                new OutStoreProduct()
                                {
                                    Quantity = Convert.ToInt32(txtQuantity.Text),
                                    StorageNo = StorageNoAdd1.Text,
                                    DeclareName = txtDeclareName.Text,
                                    DeclareValue = txtDeclareValue.Text
                                },                                
                            }
                            .ToArray(),
                            ShipToAddress = new ShipToAddress()
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
                            Shipping = OutStoreShipping.None,
                            ShippingV2_1 = ConvertOutStoreShippingV2_1(ddlShipping.SelectedValue)
                        },
                        new OutStorePackage()
                        {
                            Custom = txtCustom.Text,
                            Remark = txtRemark1.Text,
                            Services = txtServices.Text,
                            Sign = txtSign.Text,
                            TrackingNumber = txtTrackingNumer.Text,
                            State = OrderOutState.Initial,
                            ProductList = new List<OutStoreProduct>(){
                                new OutStoreProduct()
                                {
                                    SKU = txtSKU.Text,
                                    Quantity = Convert.ToInt32(txtQuantity.Text),
                                    StorageNo = StorageNoAdd2.Text,
                                    DeclareName = txtDeclareName.Text,
                                    DeclareValue = txtDeclareValue.Text
                                }
                                
                            }
                            .ToArray(),
                            ShipToAddress = new ShipToAddress()
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
                            Shipping = OutStoreShipping.None,
                            ShippingV2_1 = ConvertOutStoreShippingV2_1(ddlShipping.SelectedValue)
                        }
                    }
                    .ToArray(),
                    Warehouse = EWH, // EnumWarehouse.US,
                },
            };

            OutStoreAddOrderResponse response = clint.OutStoreAddOrder(request);

            lblAck.Text = response.Ack.ToString();
            lblInvocationID.Text = response.InvocationID;
            lblMessage.Text = response.Message;
            lblOrderSign.Text = response.OrderSign;

            pnlResponse.Visible = true;
            pnlRequest.Visible = false;
        }

        protected void btnOrderSubmit_Click(object sender, EventArgs e)
        {
            var clint = new CK1SoapClient();
            clint.OutStoreCompleteOrder(new OutStoreCompleteOrderRequest()
            {
                

            });


            clint.Close();

        }
    }
}

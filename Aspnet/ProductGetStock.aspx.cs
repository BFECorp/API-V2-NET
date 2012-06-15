using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Chukou1Demo.Aspnet
{
    public partial class ProductGetStock : System.Web.UI.Page
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
            ddlWarehouse.DataSource = "US";
            txtSKU.Text = "";
            txtMessageID.Text = "";
            txtVersion.Text = "";
            pnlResponse.Visible = false;
            pnlRequest.Visible = true;
        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            Initialize();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            var clint = new CK1.CK1SoapClient();
            UserKeyAndToken ukt = new UserKeyAndToken();
            var request = new CK1.ProductGetStockRequest()
            {
                MessageID = txtMessageID.Text,
                UserKey = ukt.getUserKey(),
                Token = ukt.getToken(),
                SKU = txtSKU.Text,
                Version = txtVersion.Text,
            };

            switch (ddlWarehouse.SelectedIndex)
            {
                case 0:
                    request.Warehouse = CK1.EnumWarehouse.US;
                    break;
                case 1:
                    request.Warehouse = CK1.EnumWarehouse.UK;
                    break;
                case 2:
                    request.Warehouse = CK1.EnumWarehouse.AU;
                    break;
                default:
                    request.Warehouse = CK1.EnumWarehouse.MA;
                    break;

            }

            var response = clint.ProductGetStock(request);

            lblAck.Text = response.Ack.ToString();
            lblInvocationID.Text = response.InvocationID;
            lblMessage.Text = response.Message;
            if (response.StockDetail != null)
            {
                lblAmount.Text = response.StockDetail.Amount.ToString();
                lblAvailableAmount.Text = response.StockDetail.AvailableAmount.ToString();
                lblPacking.Text = response.StockDetail.Packing.Length.ToString() + "*" + response.StockDetail.Packing.Width.ToString() + "*" + response.StockDetail.Packing.Height.ToString();
                lblStorageNo.Text = response.StockDetail.StorageNo;
                lblWeight.Text = response.StockDetail.Weight.ToString();
                lblStorageNo.Text = response.StockDetail.StorageNo;
                lblSKU.Text = response.StockDetail.SKU;
            }

            pnlResponse.Visible = true;
            pnlRequest.Visible = false;
        }
    }
}
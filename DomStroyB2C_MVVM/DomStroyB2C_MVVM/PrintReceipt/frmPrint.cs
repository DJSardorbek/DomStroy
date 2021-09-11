using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DomStroyB2C_MVVM.PrintReceipt
{
    public partial class frmPrint : Form
    {
        List<ReceiptModel> _list;

        DBAccess ObjDbAccess = new DBAccess();

        string _traded_at, _shop, _seller, _total_sum, _discount_sum, _payment, _loan_sum;
        public frmPrint(List<ReceiptModel> dataSource, string traded_at, string shop, string seller, string total_sum, string discount_sum, string payment, string loan_sum) 
        {
            InitializeComponent();
            _list = dataSource;
            _traded_at = traded_at;
            _shop = shop;
            _seller = seller;
            _total_sum = total_sum;
            _discount_sum = discount_sum;
            _payment = payment;
            _loan_sum = loan_sum;
        }

        private static MySqlConnection connection = new MySqlConnection();
        public string strConnString = "datasource=127.0.0.1;port=3306;username=domstroy;password=2427651701;database=domstroy";
        private static MySqlDataAdapter adapter = new MySqlDataAdapter();
        DataSet ds = new DataSet();
        public void createConn()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.ConnectionString = strConnString;
                    connection.Open();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        private void frmPrint_Load(object sender, EventArgs e)
        {
            //bindingSource1.DataSource = _list;
            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pDate",_traded_at),
                new Microsoft.Reporting.WinForms.ReportParameter("pCheque", _shop),
                new Microsoft.Reporting.WinForms.ReportParameter("pSeller", _seller),
                new Microsoft.Reporting.WinForms.ReportParameter("pTotal", _total_sum),
                new Microsoft.Reporting.WinForms.ReportParameter("Pdiscount_sum", _discount_sum),
                new Microsoft.Reporting.WinForms.ReportParameter("Ppayment", _payment),
                new Microsoft.Reporting.WinForms.ReportParameter("pLoan_sum", _loan_sum)
            };

            ReportDataSource reportDataSource = new ReportDataSource();

            string query = "select cart.* , product.name, product.selling_price from cart inner join product on cart.product = product.product_id";
            DataTable tb = new DataTable();
            ObjDbAccess.readDatathroughAdapter(query, tb);

            List<ReceiptModel> list = (from DataRow dr in tb.Rows
                                       select new ReceiptModel()
                                       {
                                           product_name = dr["name"].ToString(),
                                           selling_price = Convert.ToDouble(dr["selling_price"]),
                                           amount = Convert.ToDouble(dr["amount"])
                                       }).ToList();

            reportDataSource.Name = "Receipt";
            reportDataSource.Value = list;

            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);

            this.reportViewer1.LocalReport.SetParameters(para);

            ////////////////this.reportViewer1.RefreshReport();
        }

        
    }
}

using ExcelDataReader;
using System;
using System.IO;
using System.Security;
using System.Windows.Forms;

namespace ReadExcelKH2207
{
    public partial class FrmMain : Form
    {
        //private List<string> excelFiles=new List<string>();
        public FrmMain()
        {
            InitializeComponent();
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            listView1.View = View.List;
        }

        private void BtnLoadExxcel_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var filePath = openFileDialog1.FileName;
                    using (Stream stream = openFileDialog1.OpenFile())
                    {
                        //Process.Start("notepad.exe", filePath);
                        using (var reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            //// Choose one of either 1 or 2:

                            //// 1. Use the reader methods
                            //do
                            //{
                            //    while (reader.Read())
                            //    {
                            //        // reader.GetDouble(0);
                            //    }
                            //} while (reader.NextResult());

                            // 2. Use the AsDataSet extension method
                            var conf = new ExcelDataSetConfiguration
                            {
                                ConfigureDataTable = _ => new ExcelDataTableConfiguration
                                {
                                    UseHeaderRow = true,
                                    //Filter column Excel
                                    FilterColumn = (columnReader, columnIndex) =>
                                    {
                                        string header = columnReader.GetString(columnIndex);
                                        return (
                                                header == "maDvi" ||
                                                header == "maHuyen" ||
                                                header == "soKcb" ||
                                                header == "hoTen" ||
                                                header == "gioiTinh" ||
                                                header == "ngaySinh" ||
                                                header == "soCmnd" ||
                                                header == "DANG_NHAP_VSSID" ||
                                                header == "DA_DANG_KY_VSSID" ||
                                                header == "TRANG_THAI_XAC_THUC" ||
                                                header == "SO_DDCN_CCCD_BCA" ||
                                                header == "THONG_TIN_KHONG_CHINH_XAC"
                                               );
                                    }
                                }
                            };
                            var dataset = reader.AsDataSet(conf);
                            //merge all table  in dataset
                            //code here

                            //display result to datagridview
                            dataGridView1.AutoGenerateColumns = true;
                            dataGridView1.DataSource = dataset.Tables[0];
                            LbFilePath.Text = filePath;
                            LbTotalRecord.Text = $"Total records:{dataset.Tables[0].Rows.Count}";
                        }
                    }
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void BtnInsert2SqlServer_Click(object sender, EventArgs e)
        {
            //install Dapper
            //sử dụng khi insert thành công
            listView1.Items.Add(LbFilePath.Text);
        }
    }
}
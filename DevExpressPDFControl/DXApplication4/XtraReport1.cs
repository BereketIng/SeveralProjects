using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.IO;

namespace DXApplication4
{
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport1()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            var path = @"D:\FILES\Getachew_11072021093423_0000006717_523715_Clinical Data_12162021093552.pdf";
            dataSet11.DataTable1.AddDataTable1Row(File.ReadAllBytes(path));
        }

    }
}

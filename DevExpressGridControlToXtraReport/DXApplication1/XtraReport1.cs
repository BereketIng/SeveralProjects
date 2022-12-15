using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System.Data;

namespace DXApplication1
{
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport1()
        {
            InitializeComponent();

            var dtTable = new DataTable();

            

            var dtCol1 = new DataColumn();
            dtCol1.Caption = "TEST01";
            dtCol1.ColumnName = "TEST01";
            dtCol1.DataType = typeof(string);
            dtTable.Columns.Add(dtCol1);

            var dtRow = dtTable.NewRow();
            //dtRow.SetField<string>("TEST01", "ROWTEST01");
            dtRow["TEST01"] = "ROWTEST01";
            dtTable.Rows.Add(dtRow);

            var gridControl = new GridControl();
            var gridView = new GridView();
            gridControl.Name = "gridControl1";
            gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            gridControl.Location = new System.Drawing.Point(0, 0);
            gridControl.MainView = gridView;
            gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView });
            gridView.GridControl = gridControl;

            gridControl.DataSource = dtTable;


            printableComponentContainer1.WinControl = gridControl;
        }

    }
}

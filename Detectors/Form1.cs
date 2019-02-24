using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using Microsoft.Win32.SafeHandles;

namespace Detectors
{
    public partial class MainForm : Form
    {
        private readonly List<List<double>> _data;

        public MainForm()
        {
            InitializeComponent();
            _data = new List<List<double>>();
            CtrlDGV.RowCount = 2;
            CtrlDGV.ColumnCount = 9;
            for (int i = 0; i < 9; i++)
            {
                CtrlDGV.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            CtrlDGV.Rows[0].Cells[0].Value = "i1";
            CtrlDGV.Rows[0].Cells[1].Value = "n";
            CtrlDGV.Rows[0].Cells[2].Value = "z0";
            CtrlDGV.Rows[0].Cells[3].Value = "R0";
            CtrlDGV.Rows[0].Cells[4].Value = "L";
            CtrlDGV.Rows[0].Cells[5].Value = "l";
            CtrlDGV.Rows[0].Cells[6].Value = "M";
            CtrlDGV.Rows[0].Cells[7].Value = "D";
            CtrlDGV.Rows[0].Cells[8].Value = "x^2";

        }

        private void CtrlBatonNoL_Click(object sender, EventArgs e)
        {
            int n = int.Parse(CtrlTBN.Text);
            double z0 = double.Parse(CtrlTBZ.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture);
            double R0 = double.Parse(CtrlTBR.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture);
            int experiments = int.Parse(CtrlTBExps.Text);
            int i1 = int.Parse(CtrlTBi1.Text);

            var md = Logics.Instance.GetMathAndDisp(new[] {z0, R0}, new[] {experiments, n});

            _data.Add(new List<double>
            {
                i1, n, z0, R0, -1, -1, md[0], md[1], 0
            });
            for (int j = 0; j < CtrlDGV.ColumnCount; j++)
            {
                CtrlDGV.Rows[CtrlDGV.RowCount - 1].Cells[j].Value = _data[CtrlDGV.RowCount - 2][j];
            }
            CtrlDGV.RowCount++;

        }
        
        private void CtrlBaton_Click(object sender, EventArgs e)
        {
            int n = int.Parse(CtrlTBN.Text);
            int i1 = int.Parse(CtrlTBi1.Text);
            int experiments = int.Parse(CtrlTBExps.Text);

            double z0 = double.Parse(CtrlTBZ.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture);
            double R0 = double.Parse(CtrlTBR.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture);

            long[] ar = Logics.Instance.GetPeriods(new[] {z0, R0}, new[] {n, i1});
            long L = ar[0];
            long l = ar[1];
            

            CtrlLblL.Text = ar[0].ToString(CultureInfo.InvariantCulture);
            CtrlLblLmin.Text = ar[1].ToString(CultureInfo.InvariantCulture);


            var md = Logics.Instance.GetMathAndDisp(new[] {z0, R0}, new[] {experiments, n});

            
            _data.Add(new List<double>
            {
                i1, n, z0, R0, L, l, md[0], md[1], 0
            });
            for (int j = 0; j < CtrlDGV.ColumnCount; j++)
            {
                CtrlDGV.Rows[CtrlDGV.RowCount - 1].Cells[j].Value = _data[CtrlDGV.RowCount - 2][j];
            }
            CtrlDGV.RowCount++;
        }
    }
}
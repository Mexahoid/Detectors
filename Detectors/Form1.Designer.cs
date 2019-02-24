namespace Detectors
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.CtrlTBN = new System.Windows.Forms.TextBox();
            this.CtrlTBZ = new System.Windows.Forms.TextBox();
            this.CtrlTBR = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CtrlLblLmin = new System.Windows.Forms.Label();
            this.CtrlLblL = new System.Windows.Forms.Label();
            this.CtrlBaton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CtrlTBi1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CtrlDGV = new System.Windows.Forms.DataGridView();
            this.CtrlBatonNoL = new System.Windows.Forms.Button();
            this.CtrlTBExps = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CtrlDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // CtrlTBN
            // 
            this.CtrlTBN.Location = new System.Drawing.Point(42, 157);
            this.CtrlTBN.Name = "CtrlTBN";
            this.CtrlTBN.Size = new System.Drawing.Size(100, 20);
            this.CtrlTBN.TabIndex = 0;
            this.CtrlTBN.Text = "9";
            // 
            // CtrlTBZ
            // 
            this.CtrlTBZ.Location = new System.Drawing.Point(42, 183);
            this.CtrlTBZ.Name = "CtrlTBZ";
            this.CtrlTBZ.Size = new System.Drawing.Size(100, 20);
            this.CtrlTBZ.TabIndex = 0;
            this.CtrlTBZ.Text = "0.011";
            // 
            // CtrlTBR
            // 
            this.CtrlTBR.Location = new System.Drawing.Point(42, 209);
            this.CtrlTBR.Name = "CtrlTBR";
            this.CtrlTBR.Size = new System.Drawing.Size(100, 20);
            this.CtrlTBR.TabIndex = 0;
            this.CtrlTBR.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "z0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "R0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "L = ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "l = ";
            // 
            // CtrlLblLmin
            // 
            this.CtrlLblLmin.AutoSize = true;
            this.CtrlLblLmin.Location = new System.Drawing.Point(179, 186);
            this.CtrlLblLmin.Name = "CtrlLblLmin";
            this.CtrlLblLmin.Size = new System.Drawing.Size(13, 13);
            this.CtrlLblLmin.TabIndex = 2;
            this.CtrlLblLmin.Text = "0";
            // 
            // CtrlLblL
            // 
            this.CtrlLblL.AutoSize = true;
            this.CtrlLblL.Location = new System.Drawing.Point(179, 160);
            this.CtrlLblL.Name = "CtrlLblL";
            this.CtrlLblL.Size = new System.Drawing.Size(13, 13);
            this.CtrlLblL.TabIndex = 2;
            this.CtrlLblL.Text = "0";
            // 
            // CtrlBaton
            // 
            this.CtrlBaton.Location = new System.Drawing.Point(28, 301);
            this.CtrlBaton.Name = "CtrlBaton";
            this.CtrlBaton.Size = new System.Drawing.Size(75, 23);
            this.CtrlBaton.TabIndex = 3;
            this.CtrlBaton.Text = "Рассчитать";
            this.CtrlBaton.UseVisualStyleBackColor = true;
            this.CtrlBaton.Click += new System.EventHandler(this.CtrlBaton_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(800, 63);
            this.label7.TabIndex = 4;
            this.label7.Text = resources.GetString("label7.Text");
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(25, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 19);
            this.label8.TabIndex = 5;
            this.label8.Text = "z(i+1) = z(i) + 10^-n";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(25, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(182, 19);
            this.label9.TabIndex = 5;
            this.label9.Text = "R(i+1) = FRAC((R(i) / z(i+ 1) + pi)";
            // 
            // CtrlTBi1
            // 
            this.CtrlTBi1.Location = new System.Drawing.Point(42, 131);
            this.CtrlTBi1.Name = "CtrlTBi1";
            this.CtrlTBi1.Size = new System.Drawing.Size(100, 20);
            this.CtrlTBi1.TabIndex = 0;
            this.CtrlTBi1.Text = "8000000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "i1";
            // 
            // CtrlDGV
            // 
            this.CtrlDGV.AllowUserToAddRows = false;
            this.CtrlDGV.AllowUserToDeleteRows = false;
            this.CtrlDGV.AllowUserToResizeColumns = false;
            this.CtrlDGV.AllowUserToResizeRows = false;
            this.CtrlDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CtrlDGV.ColumnHeadersVisible = false;
            this.CtrlDGV.EnableHeadersVisualStyles = false;
            this.CtrlDGV.Location = new System.Drawing.Point(288, 64);
            this.CtrlDGV.Name = "CtrlDGV";
            this.CtrlDGV.RowHeadersVisible = false;
            this.CtrlDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.CtrlDGV.Size = new System.Drawing.Size(524, 414);
            this.CtrlDGV.TabIndex = 6;
            // 
            // CtrlBatonNoL
            // 
            this.CtrlBatonNoL.Location = new System.Drawing.Point(132, 301);
            this.CtrlBatonNoL.Name = "CtrlBatonNoL";
            this.CtrlBatonNoL.Size = new System.Drawing.Size(139, 23);
            this.CtrlBatonNoL.TabIndex = 3;
            this.CtrlBatonNoL.Text = "Рассчитать без периода";
            this.CtrlBatonNoL.UseVisualStyleBackColor = true;
            this.CtrlBatonNoL.Click += new System.EventHandler(this.CtrlBatonNoL_Click);
            // 
            // CtrlTBExps
            // 
            this.CtrlTBExps.Location = new System.Drawing.Point(151, 261);
            this.CtrlTBExps.Name = "CtrlTBExps";
            this.CtrlTBExps.Size = new System.Drawing.Size(100, 20);
            this.CtrlTBExps.TabIndex = 0;
            this.CtrlTBExps.Text = "10000";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(148, 245);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Эксперименты:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 490);
            this.Controls.Add(this.CtrlDGV);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CtrlBatonNoL);
            this.Controls.Add(this.CtrlBaton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CtrlLblL);
            this.Controls.Add(this.CtrlLblLmin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CtrlTBExps);
            this.Controls.Add(this.CtrlTBR);
            this.Controls.Add(this.CtrlTBZ);
            this.Controls.Add(this.CtrlTBi1);
            this.Controls.Add(this.CtrlTBN);
            this.Name = "MainForm";
            this.Text = "Детектор 7";
            ((System.ComponentModel.ISupportInitialize)(this.CtrlDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CtrlTBN;
        private System.Windows.Forms.TextBox CtrlTBZ;
        private System.Windows.Forms.TextBox CtrlTBR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label CtrlLblLmin;
        private System.Windows.Forms.Label CtrlLblL;
        private System.Windows.Forms.Button CtrlBaton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox CtrlTBi1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView CtrlDGV;
        private System.Windows.Forms.Button CtrlBatonNoL;
        private System.Windows.Forms.TextBox CtrlTBExps;
        private System.Windows.Forms.Label label10;
    }
}


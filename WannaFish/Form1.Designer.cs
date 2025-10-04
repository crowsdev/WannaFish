
namespace WannaFish
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            Telerik.WinControls.UI.CartesianArea cartesianArea1 = new Telerik.WinControls.UI.CartesianArea();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.vlcControl1 = new Vlc.DotNet.Forms.VlcControl();
            this.label_top = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.vlcControl2 = new Vlc.DotNet.Forms.VlcControl();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.radChartView1 = new Telerik.WinControls.UI.RadChartView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label_weatherids = new System.Windows.Forms.Label();
            this.label_weatherdata_1 = new System.Windows.Forms.Label();
            this.label_weatherdata_2 = new System.Windows.Forms.Label();
            this.label_weatherdata_3 = new System.Windows.Forms.Label();
            this.label_weatherdata_4 = new System.Windows.Forms.Label();
            this.label_weatherdata_5 = new System.Windows.Forms.Label();
            this.label_weatherdata_6 = new System.Windows.Forms.Label();
            this.label_weatherdata_7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl2)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radChartView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(1015, 770);
            this.splitContainer1.SplitterDistance = 656;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.vlcControl1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_top, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.vlcControl2, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(353, 768);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // vlcControl1
            // 
            this.vlcControl1.BackColor = System.Drawing.Color.Black;
            this.vlcControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vlcControl1.ForeColor = System.Drawing.Color.Black;
            this.vlcControl1.Location = new System.Drawing.Point(3, 79);
            this.vlcControl1.Name = "vlcControl1";
            this.vlcControl1.Size = new System.Drawing.Size(347, 301);
            this.vlcControl1.Spu = -1;
            this.vlcControl1.TabIndex = 2;
            this.vlcControl1.Text = "vlcControl1";
            this.vlcControl1.VlcLibDirectory = ((System.IO.DirectoryInfo)(resources.GetObject("vlcControl1.VlcLibDirectory")));
            this.vlcControl1.VlcMediaplayerOptions = new string[] {
        "-vv"};
            this.vlcControl1.VlcLibDirectoryNeeded += new System.EventHandler<Vlc.DotNet.Forms.VlcLibDirectoryNeededEventArgs>(this.vlcControl1_VlcLibDirectoryNeeded);
            // 
            // label_top
            // 
            this.label_top.AutoSize = true;
            this.label_top.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_top.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_top.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_top.Location = new System.Drawing.Point(3, 0);
            this.label_top.Name = "label_top";
            this.label_top.Size = new System.Drawing.Size(347, 76);
            this.label_top.TabIndex = 0;
            this.label_top.Text = "Carolina Beach - North End";
            this.label_top.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 76);
            this.label1.TabIndex = 3;
            this.label1.Text = "Carolina Beach - Center";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // vlcControl2
            // 
            this.vlcControl2.BackColor = System.Drawing.Color.Black;
            this.vlcControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vlcControl2.Location = new System.Drawing.Point(3, 462);
            this.vlcControl2.Name = "vlcControl2";
            this.vlcControl2.Size = new System.Drawing.Size(347, 303);
            this.vlcControl2.Spu = -1;
            this.vlcControl2.TabIndex = 4;
            this.vlcControl2.Text = "vlcControl2";
            this.vlcControl2.VlcLibDirectory = null;
            this.vlcControl2.VlcMediaplayerOptions = null;
            this.vlcControl2.VlcLibDirectoryNeeded += new System.EventHandler<Vlc.DotNet.Forms.VlcLibDirectoryNeededEventArgs>(this.vlcControl1_VlcLibDirectoryNeeded);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 10;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Controls.Add(this.label_weatherdata_7, 7, 3);
            this.tableLayoutPanel2.Controls.Add(this.label_weatherdata_6, 6, 3);
            this.tableLayoutPanel2.Controls.Add(this.label_weatherdata_5, 5, 3);
            this.tableLayoutPanel2.Controls.Add(this.label_weatherdata_4, 4, 3);
            this.tableLayoutPanel2.Controls.Add(this.label_weatherdata_3, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.label_weatherdata_2, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.label11, 9, 2);
            this.tableLayoutPanel2.Controls.Add(this.label10, 8, 2);
            this.tableLayoutPanel2.Controls.Add(this.label9, 7, 2);
            this.tableLayoutPanel2.Controls.Add(this.label8, 6, 2);
            this.tableLayoutPanel2.Controls.Add(this.label7, 5, 2);
            this.tableLayoutPanel2.Controls.Add(this.label6, 4, 2);
            this.tableLayoutPanel2.Controls.Add(this.label5, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.label3, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.radChartView1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label_weatherids, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label_weatherdata_1, 1, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(654, 768);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // radChartView1
            // 
            cartesianArea1.ShowGrid = true;
            this.radChartView1.AreaDesign = cartesianArea1;
            this.tableLayoutPanel2.SetColumnSpan(this.radChartView1, 10);
            this.radChartView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radChartView1.Location = new System.Drawing.Point(3, 3);
            this.radChartView1.Name = "radChartView1";
            this.tableLayoutPanel2.SetRowSpan(this.radChartView1, 2);
            this.radChartView1.ShowToolTip = true;
            this.radChartView1.Size = new System.Drawing.Size(648, 300);
            this.radChartView1.TabIndex = 0;
            this.radChartView1.Title = "TideChart";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 76);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(68, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 76);
            this.label3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(133, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 76);
            this.label4.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(198, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 76);
            this.label5.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(263, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 76);
            this.label6.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(328, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 76);
            this.label7.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(393, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 76);
            this.label8.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(458, 306);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 76);
            this.label9.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(523, 306);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 76);
            this.label10.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(588, 306);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 76);
            this.label11.TabIndex = 10;
            // 
            // label_weatherids
            // 
            this.label_weatherids.AutoSize = true;
            this.label_weatherids.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_weatherids.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_weatherids.Location = new System.Drawing.Point(3, 382);
            this.label_weatherids.Name = "label_weatherids";
            this.label_weatherids.Size = new System.Drawing.Size(59, 345);
            this.label_weatherids.TabIndex = 11;
            this.label_weatherids.Text = "Temp\r\n\r\n\r\nWind\r\nSpeed\r\n\r\n\r\nWind\r\nDirection\r\n\r\n\r\nRain";
            // 
            // label_weatherdata_1
            // 
            this.label_weatherdata_1.AutoSize = true;
            this.label_weatherdata_1.BackColor = System.Drawing.Color.White;
            this.label_weatherdata_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_weatherdata_1.Location = new System.Drawing.Point(68, 382);
            this.label_weatherdata_1.Name = "label_weatherdata_1";
            this.label_weatherdata_1.Size = new System.Drawing.Size(59, 345);
            this.label_weatherdata_1.TabIndex = 12;
            this.label_weatherdata_1.Text = "1";
            // 
            // label_weatherdata_2
            // 
            this.label_weatherdata_2.AutoSize = true;
            this.label_weatherdata_2.BackColor = System.Drawing.Color.White;
            this.label_weatherdata_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_weatherdata_2.Location = new System.Drawing.Point(133, 382);
            this.label_weatherdata_2.Name = "label_weatherdata_2";
            this.label_weatherdata_2.Size = new System.Drawing.Size(59, 345);
            this.label_weatherdata_2.TabIndex = 13;
            this.label_weatherdata_2.Text = "1";
            // 
            // label_weatherdata_3
            // 
            this.label_weatherdata_3.AutoSize = true;
            this.label_weatherdata_3.BackColor = System.Drawing.Color.White;
            this.label_weatherdata_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_weatherdata_3.Location = new System.Drawing.Point(198, 382);
            this.label_weatherdata_3.Name = "label_weatherdata_3";
            this.label_weatherdata_3.Size = new System.Drawing.Size(59, 345);
            this.label_weatherdata_3.TabIndex = 14;
            this.label_weatherdata_3.Text = "1";
            // 
            // label_weatherdata_4
            // 
            this.label_weatherdata_4.AutoSize = true;
            this.label_weatherdata_4.BackColor = System.Drawing.Color.White;
            this.label_weatherdata_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_weatherdata_4.Location = new System.Drawing.Point(263, 382);
            this.label_weatherdata_4.Name = "label_weatherdata_4";
            this.label_weatherdata_4.Size = new System.Drawing.Size(59, 345);
            this.label_weatherdata_4.TabIndex = 15;
            this.label_weatherdata_4.Text = "1";
            // 
            // label_weatherdata_5
            // 
            this.label_weatherdata_5.AutoSize = true;
            this.label_weatherdata_5.BackColor = System.Drawing.Color.White;
            this.label_weatherdata_5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_weatherdata_5.Location = new System.Drawing.Point(328, 382);
            this.label_weatherdata_5.Name = "label_weatherdata_5";
            this.label_weatherdata_5.Size = new System.Drawing.Size(59, 345);
            this.label_weatherdata_5.TabIndex = 16;
            this.label_weatherdata_5.Text = "1";
            // 
            // label_weatherdata_6
            // 
            this.label_weatherdata_6.AutoSize = true;
            this.label_weatherdata_6.BackColor = System.Drawing.Color.White;
            this.label_weatherdata_6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_weatherdata_6.Location = new System.Drawing.Point(393, 382);
            this.label_weatherdata_6.Name = "label_weatherdata_6";
            this.label_weatherdata_6.Size = new System.Drawing.Size(59, 345);
            this.label_weatherdata_6.TabIndex = 17;
            this.label_weatherdata_6.Text = "1";
            // 
            // label_weatherdata_7
            // 
            this.label_weatherdata_7.AutoSize = true;
            this.label_weatherdata_7.BackColor = System.Drawing.Color.White;
            this.label_weatherdata_7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_weatherdata_7.Location = new System.Drawing.Point(458, 382);
            this.label_weatherdata_7.Name = "label_weatherdata_7";
            this.label_weatherdata_7.Size = new System.Drawing.Size(59, 345);
            this.label_weatherdata_7.TabIndex = 18;
            this.label_weatherdata_7.Text = "1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1015, 770);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMain";
            this.Text = "WannaFish: Fishing and boating info for Wilmington NC from NothingSussIndustries." +
    "";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl2)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radChartView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public Vlc.DotNet.Forms.VlcControl vlcControl1;
        public System.Windows.Forms.Label label_top;
        private System.Windows.Forms.Label label1;
        private Vlc.DotNet.Forms.VlcControl vlcControl2;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        public System.Windows.Forms.Label label_weatherdata_7;
        public System.Windows.Forms.Label label_weatherdata_6;
        public System.Windows.Forms.Label label_weatherdata_5;
        public System.Windows.Forms.Label label_weatherdata_4;
        public System.Windows.Forms.Label label_weatherdata_3;
        public System.Windows.Forms.Label label_weatherdata_2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public Telerik.WinControls.UI.RadChartView radChartView1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label_weatherids;
        public System.Windows.Forms.Label label_weatherdata_1;
    }
}


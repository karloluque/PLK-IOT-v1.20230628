
namespace PLK_IIOT_V1
{

    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.label85 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.picbx_logo = new System.Windows.Forms.PictureBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.sg_overall = new LiveCharts.WinForms.SolidGauge();
            this.label84 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.sg_today_fl_total = new LiveCharts.WinForms.SolidGauge();
            this.label83 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.sg_yday_fl_total = new LiveCharts.WinForms.SolidGauge();
            this.label82 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.sg_today_ml_total = new LiveCharts.WinForms.SolidGauge();
            this.label81 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.sg_yday_ml_total = new LiveCharts.WinForms.SolidGauge();
            this.label80 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_shift_record = new System.Windows.Forms.Label();
            this.pnl_PLC2 = new System.Windows.Forms.Panel();
            this.pnl_PLC1 = new System.Windows.Forms.Panel();
            this.tmr_update = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_logo)).BeginInit();
            this.panel9.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // label85
            // 
            this.label85.Location = new System.Drawing.Point(0, 0);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(100, 23);
            this.label85.TabIndex = 0;
            this.label85.Text = "label85";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(43)))), ((int)(((byte)(87)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.Controls.Add(this.picbx_logo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel9, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbl_shift_record, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.pnl_PLC2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnl_PLC1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1904, 1041);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // picbx_logo
            // 
            this.picbx_logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picbx_logo.Image = ((System.Drawing.Image)(resources.GetObject("picbx_logo.Image")));
            this.picbx_logo.Location = new System.Drawing.Point(859, 3);
            this.picbx_logo.Name = "picbx_logo";
            this.picbx_logo.Size = new System.Drawing.Size(184, 46);
            this.picbx_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbx_logo.TabIndex = 19;
            this.picbx_logo.TabStop = false;
            this.picbx_logo.Click += new System.EventHandler(this.picbx_logo_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.tableLayoutPanel10);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(856, 52);
            this.panel9.Margin = new System.Windows.Forms.Padding(0);
            this.panel9.Name = "panel9";
            this.tableLayoutPanel1.SetRowSpan(this.panel9, 3);
            this.panel9.Size = new System.Drawing.Size(190, 863);
            this.panel9.TabIndex = 9;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 1;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel10.Controls.Add(this.panel14, 0, 4);
            this.tableLayoutPanel10.Controls.Add(this.panel13, 0, 3);
            this.tableLayoutPanel10.Controls.Add(this.panel12, 0, 2);
            this.tableLayoutPanel10.Controls.Add(this.panel11, 0, 1);
            this.tableLayoutPanel10.Controls.Add(this.panel10, 0, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 5;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(190, 863);
            this.tableLayoutPanel10.TabIndex = 0;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.sg_overall);
            this.panel14.Controls.Add(this.label84);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel14.Location = new System.Drawing.Point(0, 688);
            this.panel14.Margin = new System.Windows.Forms.Padding(0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(190, 175);
            this.panel14.TabIndex = 4;
            // 
            // sg_overall
            // 
            this.sg_overall.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sg_overall.Location = new System.Drawing.Point(0, 30);
            this.sg_overall.Margin = new System.Windows.Forms.Padding(0);
            this.sg_overall.Name = "sg_overall";
            this.sg_overall.Size = new System.Drawing.Size(190, 145);
            this.sg_overall.TabIndex = 1;
            this.sg_overall.Text = "solidGauge1";
            // 
            // label84
            // 
            this.label84.Dock = System.Windows.Forms.DockStyle.Top;
            this.label84.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label84.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label84.Location = new System.Drawing.Point(0, 0);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(190, 30);
            this.label84.TabIndex = 0;
            this.label84.Text = "Overall";
            this.label84.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.sg_today_fl_total);
            this.panel13.Controls.Add(this.label83);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(0, 516);
            this.panel13.Margin = new System.Windows.Forms.Padding(0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(190, 172);
            this.panel13.TabIndex = 3;
            // 
            // sg_today_fl_total
            // 
            this.sg_today_fl_total.Dock = System.Windows.Forms.DockStyle.Top;
            this.sg_today_fl_total.Location = new System.Drawing.Point(0, 61);
            this.sg_today_fl_total.Name = "sg_today_fl_total";
            this.sg_today_fl_total.Size = new System.Drawing.Size(190, 127);
            this.sg_today_fl_total.TabIndex = 1;
            this.sg_today_fl_total.Text = "solidGauge1";
            // 
            // label83
            // 
            this.label83.Dock = System.Windows.Forms.DockStyle.Top;
            this.label83.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label83.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label83.Location = new System.Drawing.Point(0, 0);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(190, 61);
            this.label83.TabIndex = 0;
            this.label83.Text = "Today\'s Flex Total";
            this.label83.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.sg_yday_fl_total);
            this.panel12.Controls.Add(this.label82);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(0, 344);
            this.panel12.Margin = new System.Windows.Forms.Padding(0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(190, 172);
            this.panel12.TabIndex = 2;
            // 
            // sg_yday_fl_total
            // 
            this.sg_yday_fl_total.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sg_yday_fl_total.Location = new System.Drawing.Point(0, 45);
            this.sg_yday_fl_total.Name = "sg_yday_fl_total";
            this.sg_yday_fl_total.Size = new System.Drawing.Size(190, 127);
            this.sg_yday_fl_total.TabIndex = 1;
            this.sg_yday_fl_total.Text = "solidGauge1";
            // 
            // label82
            // 
            this.label82.Dock = System.Windows.Forms.DockStyle.Top;
            this.label82.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label82.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label82.Location = new System.Drawing.Point(0, 0);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(190, 51);
            this.label82.TabIndex = 0;
            this.label82.Text = "Yesterday\'s \r\nFlex Total";
            this.label82.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.sg_today_ml_total);
            this.panel11.Controls.Add(this.label81);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(0, 172);
            this.panel11.Margin = new System.Windows.Forms.Padding(0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(190, 172);
            this.panel11.TabIndex = 1;
            // 
            // sg_today_ml_total
            // 
            this.sg_today_ml_total.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sg_today_ml_total.Location = new System.Drawing.Point(0, 22);
            this.sg_today_ml_total.Name = "sg_today_ml_total";
            this.sg_today_ml_total.Size = new System.Drawing.Size(190, 150);
            this.sg_today_ml_total.TabIndex = 1;
            this.sg_today_ml_total.Text = "solidGauge1";
            // 
            // label81
            // 
            this.label81.Dock = System.Windows.Forms.DockStyle.Top;
            this.label81.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label81.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label81.Location = new System.Drawing.Point(0, 0);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(190, 22);
            this.label81.TabIndex = 0;
            this.label81.Text = "Today\'s Main Total";
            this.label81.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.sg_yday_ml_total);
            this.panel10.Controls.Add(this.label80);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Margin = new System.Windows.Forms.Padding(0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(190, 172);
            this.panel10.TabIndex = 0;
            // 
            // sg_yday_ml_total
            // 
            this.sg_yday_ml_total.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sg_yday_ml_total.Location = new System.Drawing.Point(0, 45);
            this.sg_yday_ml_total.Name = "sg_yday_ml_total";
            this.sg_yday_ml_total.Size = new System.Drawing.Size(190, 127);
            this.sg_yday_ml_total.TabIndex = 1;
            this.sg_yday_ml_total.Text = "solidGauge1";
            // 
            // label80
            // 
            this.label80.Dock = System.Windows.Forms.DockStyle.Top;
            this.label80.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label80.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label80.Location = new System.Drawing.Point(0, 0);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(190, 45);
            this.label80.TabIndex = 0;
            this.label80.Text = "Yesterday\'s \r\nMain Total";
            this.label80.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gold;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(860, 919);
            this.label4.Margin = new System.Windows.Forms.Padding(4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 23);
            this.label4.TabIndex = 20;
            this.label4.Text = "★LINE RECORD ★";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_shift_record
            // 
            this.lbl_shift_record.AutoSize = true;
            this.lbl_shift_record.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(43)))), ((int)(((byte)(87)))));
            this.lbl_shift_record.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_shift_record.Font = new System.Drawing.Font("Segoe UI", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_shift_record.ForeColor = System.Drawing.Color.Gold;
            this.lbl_shift_record.Location = new System.Drawing.Point(859, 946);
            this.lbl_shift_record.Name = "lbl_shift_record";
            this.lbl_shift_record.Size = new System.Drawing.Size(184, 95);
            this.lbl_shift_record.TabIndex = 21;
            this.lbl_shift_record.Text = "XXX";
            this.lbl_shift_record.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_PLC2
            // 
            this.pnl_PLC2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_PLC2.Location = new System.Drawing.Point(1046, 0);
            this.pnl_PLC2.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_PLC2.Name = "pnl_PLC2";
            this.tableLayoutPanel1.SetRowSpan(this.pnl_PLC2, 6);
            this.pnl_PLC2.Size = new System.Drawing.Size(858, 1041);
            this.pnl_PLC2.TabIndex = 22;
            // 
            // pnl_PLC1
            // 
            this.pnl_PLC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_PLC1.Location = new System.Drawing.Point(0, 0);
            this.pnl_PLC1.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_PLC1.Name = "pnl_PLC1";
            this.tableLayoutPanel1.SetRowSpan(this.pnl_PLC1, 6);
            this.pnl_PLC1.Size = new System.Drawing.Size(856, 1041);
            this.pnl_PLC1.TabIndex = 23;
            // 
            // tmr_update
            // 
            this.tmr_update.Interval = 250;
            this.tmr_update.Tick += new System.EventHandler(this.tmr_update_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(43)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormMain";
            this.Text = "YF Lines";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_logo)).EndInit();
            this.panel9.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.Label label85;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Timer tmr_update;
        private System.Windows.Forms.PictureBox picbx_logo;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Panel panel14;
        private LiveCharts.WinForms.SolidGauge sg_overall;
        private System.Windows.Forms.Label label84;
        private System.Windows.Forms.Panel panel13;
        private LiveCharts.WinForms.SolidGauge sg_today_fl_total;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.Panel panel12;
        private LiveCharts.WinForms.SolidGauge sg_yday_fl_total;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.Panel panel11;
        private LiveCharts.WinForms.SolidGauge sg_today_ml_total;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.Panel panel10;
        private LiveCharts.WinForms.SolidGauge sg_yday_ml_total;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_shift_record;
        private System.Windows.Forms.Panel pnl_PLC2;
        private System.Windows.Forms.Panel pnl_PLC1;
    }
}


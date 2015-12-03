namespace SqlQueryTester
{
    partial class MainForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.StartButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TimeoutControl = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.ConnectionsCountControl = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ConnectionStringControl = new System.Windows.Forms.TextBox();
            this.QueryControl = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeoutControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectionsCountControl)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(642, 376);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.StartButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(144, 44);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(3, 3);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(141, 29);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TimeoutControl);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ConnectionsCountControl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(144, 320);
            this.panel1.TabIndex = 2;
            // 
            // TimeoutControl
            // 
            this.TimeoutControl.Location = new System.Drawing.Point(6, 55);
            this.TimeoutControl.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.TimeoutControl.Name = "TimeoutControl";
            this.TimeoutControl.Size = new System.Drawing.Size(135, 20);
            this.TimeoutControl.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Timeout (ms)";
            // 
            // ConnectionsCountControl
            // 
            this.ConnectionsCountControl.Location = new System.Drawing.Point(6, 16);
            this.ConnectionsCountControl.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ConnectionsCountControl.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ConnectionsCountControl.Name = "ConnectionsCountControl";
            this.ConnectionsCountControl.Size = new System.Drawing.Size(135, 20);
            this.ConnectionsCountControl.TabIndex = 1;
            this.ConnectionsCountControl.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connections count";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.QueryControl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(153, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(486, 320);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ConnectionStringControl);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(153, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(486, 44);
            this.panel3.TabIndex = 4;
            // 
            // ConnectionStringControl
            // 
            this.ConnectionStringControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConnectionStringControl.Location = new System.Drawing.Point(0, 0);
            this.ConnectionStringControl.Multiline = true;
            this.ConnectionStringControl.Name = "ConnectionStringControl";
            this.ConnectionStringControl.Size = new System.Drawing.Size(486, 44);
            this.ConnectionStringControl.TabIndex = 0;
            // 
            // QueryControl
            // 
            this.QueryControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QueryControl.Location = new System.Drawing.Point(0, 0);
            this.QueryControl.Multiline = true;
            this.QueryControl.Name = "QueryControl";
            this.QueryControl.Size = new System.Drawing.Size(486, 320);
            this.QueryControl.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 376);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "Tester";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeoutControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectionsCountControl)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown TimeoutControl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown ConnectionsCountControl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox QueryControl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox ConnectionStringControl;
    }
}


namespace Shadowsocks.View
{
    partial class AboutForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.productName = new System.Windows.Forms.Label();
            this.version = new System.Windows.Forms.Label();
            this.copyright = new System.Windows.Forms.Label();
            this.companyName = new System.Windows.Forms.Label();
            this.boxDescription = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67F));
            this.tableLayoutPanel.Controls.Add(this.logoPictureBox, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.productName, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.version, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.copyright, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.companyName, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.boxDescription, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.okButton, 1, 5);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(9, 8);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 6;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(417, 245);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(3, 3);
            this.logoPictureBox.Name = "logoPictureBox";
            this.tableLayoutPanel.SetRowSpan(this.logoPictureBox, 6);
            this.logoPictureBox.Size = new System.Drawing.Size(131, 239);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 12;
            this.logoPictureBox.TabStop = false;
            // 
            // productName
            // 
            this.productName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productName.Location = new System.Drawing.Point(143, 0);
            this.productName.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.productName.MaximumSize = new System.Drawing.Size(0, 16);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(271, 16);
            this.productName.TabIndex = 19;
            this.productName.Text = "产品名称";
            this.productName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // version
            // 
            this.version.Dock = System.Windows.Forms.DockStyle.Fill;
            this.version.Location = new System.Drawing.Point(143, 24);
            this.version.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.version.MaximumSize = new System.Drawing.Size(0, 16);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(271, 16);
            this.version.TabIndex = 0;
            this.version.Text = "版本";
            this.version.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.version.Click += new System.EventHandler(this.labelVersion_Click);
            // 
            // copyright
            // 
            this.copyright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.copyright.Location = new System.Drawing.Point(143, 48);
            this.copyright.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.copyright.MaximumSize = new System.Drawing.Size(0, 16);
            this.copyright.Name = "copyright";
            this.copyright.Size = new System.Drawing.Size(271, 16);
            this.copyright.TabIndex = 21;
            this.copyright.Text = "版权";
            this.copyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // companyName
            // 
            this.companyName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.companyName.Location = new System.Drawing.Point(143, 72);
            this.companyName.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.companyName.MaximumSize = new System.Drawing.Size(0, 16);
            this.companyName.Name = "companyName";
            this.companyName.Size = new System.Drawing.Size(271, 16);
            this.companyName.TabIndex = 22;
            this.companyName.Text = "公司名称";
            this.companyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // boxDescription
            // 
            this.boxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boxDescription.Location = new System.Drawing.Point(143, 99);
            this.boxDescription.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.boxDescription.Multiline = true;
            this.boxDescription.Name = "boxDescription";
            this.boxDescription.ReadOnly = true;
            this.boxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.boxDescription.Size = new System.Drawing.Size(271, 116);
            this.boxDescription.TabIndex = 23;
            this.boxDescription.TabStop = false;
            this.boxDescription.Text = "说明";
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.okButton.Location = new System.Drawing.Point(339, 221);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 21);
            this.okButton.TabIndex = 24;
            this.okButton.Text = "确定(&O)";
            // 
            // AboutForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 261);
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AboutForm";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label productName;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.Label copyright;
        private System.Windows.Forms.TextBox boxDescription;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label companyName;
    }
}

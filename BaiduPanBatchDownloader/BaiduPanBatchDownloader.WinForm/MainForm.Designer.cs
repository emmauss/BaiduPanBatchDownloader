namespace BaiduPanBatchDownloader.WinForm
{
    partial class MainForm
    {
        /// <summary>
        /// Declaring design variable
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.downloadItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.addToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.startToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.stopToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.SetAllAddedToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.removeStripButton = new System.Windows.Forms.ToolStripButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cookieTextBox = new System.Windows.Forms.TextBox();
            this.tradeTextBox = new System.Windows.Forms.TextBox();
            this.bdstokenTextBox = new System.Windows.Forms.TextBox();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.downloadItemBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.statusDataGridViewTextBoxColumn,
            this.saveToDataGridViewTextBoxColumn,
            this.urlDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.downloadItemBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(981, 248);
            this.dataGridView1.TabIndex = 0;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 54;
            // 
            // saveToDataGridViewTextBoxColumn
            // 
            this.saveToDataGridViewTextBoxColumn.DataPropertyName = "SaveTo";
            this.saveToDataGridViewTextBoxColumn.HeaderText = "Save To:";
            this.saveToDataGridViewTextBoxColumn.Name = "saveToDataGridViewTextBoxColumn";
            this.saveToDataGridViewTextBoxColumn.ReadOnly = true;
            this.saveToDataGridViewTextBoxColumn.Width = 78;
            // 
            // urlDataGridViewTextBoxColumn
            // 
            this.urlDataGridViewTextBoxColumn.DataPropertyName = "Url";
            this.urlDataGridViewTextBoxColumn.HeaderText = "Url";
            this.urlDataGridViewTextBoxColumn.Name = "urlDataGridViewTextBoxColumn";
            this.urlDataGridViewTextBoxColumn.ReadOnly = true;
            this.urlDataGridViewTextBoxColumn.Width = 48;
            // 
            // downloadItemBindingSource
            // 
            this.downloadItemBindingSource.DataSource = typeof(BaiduPanBatchDownloader.WinForm.DownloadItem);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripButton,
            this.startToolStripButton,
            this.stopToolStripButton,
            this.SetAllAddedToolStripButton,
            this.removeStripButton,
            this.saveToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(981, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // addToolStripButton
            // 
            this.addToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.addToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("addToolStripButton.Image")));
            this.addToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addToolStripButton.Name = "addToolStripButton";
            this.addToolStripButton.Size = new System.Drawing.Size(52, 22);
            this.addToolStripButton.Text = "Add To(&A)";
            this.addToolStripButton.Click += new System.EventHandler(this.addToolStripButton_Click);
            // 
            // startToolStripButton
            // 
            this.startToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.startToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("startToolStripButton.Image")));
            this.startToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.startToolStripButton.Name = "startToolStripButton";
            this.startToolStripButton.Size = new System.Drawing.Size(52, 22);
            this.startToolStripButton.Text = "Start(&B)";
            this.startToolStripButton.ToolTipText = "Start(&B)";
            this.startToolStripButton.Click += new System.EventHandler(this.startToolStripButton_Click);
            // 
            // stopToolStripButton
            // 
            this.stopToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.stopToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("stopToolStripButton.Image")));
            this.stopToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stopToolStripButton.Name = "stopToolStripButton";
            this.stopToolStripButton.Size = new System.Drawing.Size(51, 22);
            this.stopToolStripButton.Text = "Stop(&E)";
            this.stopToolStripButton.Click += new System.EventHandler(this.stopToolStripButton_Click);
            // 
            // SetAllAddedToolStripButton
            // 
            this.SetAllAddedToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SetAllAddedToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("SetAllAddedToolStripButton.Image")));
            this.SetAllAddedToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SetAllAddedToolStripButton.Name = "SetAllAddedToolStripButton";
            this.SetAllAddedToolStripButton.Size = new System.Drawing.Size(76, 22);
            this.SetAllAddedToolStripButton.Text = "Start All(R)";
            this.SetAllAddedToolStripButton.ToolTipText = "Start All(R)";
            this.SetAllAddedToolStripButton.Click += new System.EventHandler(this.SetAllAddedToolStripButton_Click);
            // 
            // removeStripButton
            // 
            this.removeStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.removeStripButton.Image = ((System.Drawing.Image)(resources.GetObject("removeStripButton.Image")));
            this.removeStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.removeStripButton.Name = "removeStripButton";
            this.removeStripButton.Size = new System.Drawing.Size(53, 22);
            this.removeStripButton.Text = "Delete(&D)";
            this.removeStripButton.Click += new System.EventHandler(this.removeStripButton_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // cookieTextBox
            // 
            this.cookieTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cookieTextBox.Location = new System.Drawing.Point(0, 28);
            this.cookieTextBox.Multiline = true;
            this.cookieTextBox.Name = "cookieTextBox";
            this.cookieTextBox.Size = new System.Drawing.Size(981, 39);
            this.cookieTextBox.TabIndex = 2;
            // 
            // tradeTextBox
            // 
            this.tradeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tradeTextBox.BackColor = System.Drawing.Color.Black;
            this.tradeTextBox.ForeColor = System.Drawing.Color.White;
            this.tradeTextBox.Location = new System.Drawing.Point(0, 340);
            this.tradeTextBox.Multiline = true;
            this.tradeTextBox.Name = "tradeTextBox";
            this.tradeTextBox.Size = new System.Drawing.Size(981, 178);
            this.tradeTextBox.TabIndex = 3;
            // 
            // bdstokenTextBox
            // 
            this.bdstokenTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bdstokenTextBox.Location = new System.Drawing.Point(0, 69);
            this.bdstokenTextBox.Name = "bdstokenTextBox";
            this.bdstokenTextBox.Size = new System.Drawing.Size(981, 21);
            this.bdstokenTextBox.TabIndex = 4;
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(51, 22);
            this.saveToolStripButton.Text = "Save(&S)";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 520);
            this.Controls.Add(this.bdstokenTextBox);
            this.Controls.Add(this.tradeTextBox);
            this.Controls.Add(this.cookieTextBox);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.downloadItemBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton addToolStripButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripButton startToolStripButton;
        private System.Windows.Forms.ToolStripButton stopToolStripButton;
        private System.Windows.Forms.TextBox cookieTextBox;
        private System.Windows.Forms.TextBox tradeTextBox;
        private System.Windows.Forms.ToolStripButton SetAllAddedToolStripButton;
        private System.Windows.Forms.TextBox bdstokenTextBox;
        private System.Windows.Forms.ToolStripButton removeStripButton;
        private System.Windows.Forms.BindingSource downloadItemBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saveToDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urlDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
    }
}


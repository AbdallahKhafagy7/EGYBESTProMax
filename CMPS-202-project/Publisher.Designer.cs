namespace CMPS_202_project
{
    partial class PublisherForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.layoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.panelControls = new System.Windows.Forms.Panel();
            this.grpAddShow = new System.Windows.Forms.GroupBox();
            this.panelActions = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.layoutMain.SuspendLayout();
            this.panelControls.SuspendLayout();
            this.grpAddShow.SuspendLayout();
            this.panelActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(17, 53);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(249, 30);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(17, 109);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(249, 30);
            this.textBox3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(17, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 23);
            this.label1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number Of Episodes";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Show\'s Name";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(17, 148);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(249, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(314, 2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(483, 390);
            this.dataGridView1.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(287, 80);
            this.button2.TabIndex = 8;
            this.button2.Text = "View My Shows";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 56);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(18, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(284, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Publisher Dashboard";
            // 
            // layoutMain
            // 
            this.layoutMain.ColumnCount = 2;
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 311F));
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutMain.Controls.Add(this.panelControls, 0, 0);
            this.layoutMain.Controls.Add(this.dataGridView1, 1, 0);
            this.layoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutMain.Location = new System.Drawing.Point(0, 56);
            this.layoutMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutMain.Name = "layoutMain";
            this.layoutMain.RowCount = 1;
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutMain.Size = new System.Drawing.Size(800, 394);
            this.layoutMain.TabIndex = 1;
            // 
            // panelControls
            // 
            this.panelControls.Controls.Add(this.grpAddShow);
            this.panelControls.Controls.Add(this.panelActions);
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControls.Location = new System.Drawing.Point(3, 2);
            this.panelControls.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControls.Name = "panelControls";
            this.panelControls.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.panelControls.Size = new System.Drawing.Size(305, 390);
            this.panelControls.TabIndex = 0;
            // 
            // grpAddShow
            // 
            this.grpAddShow.Controls.Add(this.label3);
            this.grpAddShow.Controls.Add(this.textBox2);
            this.grpAddShow.Controls.Add(this.label2);
            this.grpAddShow.Controls.Add(this.textBox3);
            this.grpAddShow.Controls.Add(this.button1);
            this.grpAddShow.Controls.Add(this.label1);
            this.grpAddShow.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpAddShow.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpAddShow.Location = new System.Drawing.Point(9, 8);
            this.grpAddShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAddShow.Name = "grpAddShow";
            this.grpAddShow.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpAddShow.Size = new System.Drawing.Size(287, 224);
            this.grpAddShow.TabIndex = 0;
            this.grpAddShow.TabStop = false;
            this.grpAddShow.Text = "Add New Show";
            // 
            // panelActions
            // 
            this.panelActions.Controls.Add(this.button2);
            this.panelActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelActions.Location = new System.Drawing.Point(9, 302);
            this.panelActions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(287, 80);
            this.panelActions.TabIndex = 1;
            // 
            // PublisherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.layoutMain);
            this.Controls.Add(this.panelHeader);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PublisherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Publisher";
            this.Load += new System.EventHandler(this.Publisher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.layoutMain.ResumeLayout(false);
            this.panelControls.ResumeLayout(false);
            this.grpAddShow.ResumeLayout(false);
            this.grpAddShow.PerformLayout();
            this.panelActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TableLayoutPanel layoutMain;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.GroupBox grpAddShow;
        private System.Windows.Forms.Panel panelActions;
    }
}
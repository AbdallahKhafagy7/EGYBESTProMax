namespace CMPS_202_project
{
    partial class Admin_with_publisher
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.layoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.grpPublishers = new System.Windows.Forms.GroupBox();
            this.panelPubControls = new System.Windows.Forms.Panel();
            this.btnAddPublisher = new System.Windows.Forms.Button();
            this.grpShows = new System.Windows.Forms.GroupBox();
            this.panelShowControls = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.layoutMain.SuspendLayout();
            this.grpPublishers.SuspendLayout();
            this.panelPubControls.SuspendLayout();
            this.grpShows.SuspendLayout();
            this.panelShowControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.button5);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1100, 70);
            this.panelHeader.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button5.Location = new System.Drawing.Point(920, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(160, 45);
            this.button5.TabIndex = 1;
            this.button5.Text = "Data Entry Form";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(423, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Publisher && Show Management";
            // 
            // layoutMain
            // 
            this.layoutMain.ColumnCount = 2;
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutMain.Controls.Add(this.grpPublishers, 0, 0);
            this.layoutMain.Controls.Add(this.grpShows, 1, 0);
            this.layoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutMain.Location = new System.Drawing.Point(0, 70);
            this.layoutMain.Name = "layoutMain";
            this.layoutMain.Padding = new System.Windows.Forms.Padding(10);
            this.layoutMain.RowCount = 1;
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutMain.Size = new System.Drawing.Size(1100, 680);
            this.layoutMain.TabIndex = 1;
            // 
            // grpPublishers
            // 
            this.grpPublishers.Controls.Add(this.dataGridView2);
            this.grpPublishers.Controls.Add(this.panelPubControls);
            this.grpPublishers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpPublishers.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpPublishers.Location = new System.Drawing.Point(13, 13);
            this.grpPublishers.Name = "grpPublishers";
            this.grpPublishers.Size = new System.Drawing.Size(534, 654);
            this.grpPublishers.TabIndex = 0;
            this.grpPublishers.TabStop = false;
            this.grpPublishers.Text = "Manage Publishers";
            // 
            // panelPubControls
            // 
            this.panelPubControls.Controls.Add(this.btnAddPublisher);
            this.panelPubControls.Controls.Add(this.button3);
            this.panelPubControls.Controls.Add(this.button1);
            this.panelPubControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPubControls.Location = new System.Drawing.Point(3, 26);
            this.panelPubControls.Name = "panelPubControls";
            this.panelPubControls.Size = new System.Drawing.Size(528, 80);
            this.panelPubControls.TabIndex = 0;
            // 
            // btnAddPublisher
            // 
            this.btnAddPublisher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPublisher.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddPublisher.Location = new System.Drawing.Point(165, 15);
            this.btnAddPublisher.Name = "btnAddPublisher";
            this.btnAddPublisher.Size = new System.Drawing.Size(140, 50);
            this.btnAddPublisher.TabIndex = 10;
            this.btnAddPublisher.Text = "Add Publisher";
            this.btnAddPublisher.UseVisualStyleBackColor = true;
            this.btnAddPublisher.Click += new System.EventHandler(this.btnAddPublisher_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(15, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 50);
            this.button3.TabIndex = 6;
            this.button3.Text = "Load";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(315, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 106);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(528, 545);
            this.dataGridView2.TabIndex = 8;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // grpShows
            // 
            this.grpShows.Controls.Add(this.dataGridView1);
            this.grpShows.Controls.Add(this.panelShowControls);
            this.grpShows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpShows.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpShows.Location = new System.Drawing.Point(553, 13);
            this.grpShows.Name = "grpShows";
            this.grpShows.Size = new System.Drawing.Size(534, 654);
            this.grpShows.TabIndex = 1;
            this.grpShows.TabStop = false;
            this.grpShows.Text = "Manage Shows";
            // 
            // panelShowControls
            // 
            this.panelShowControls.Controls.Add(this.button4);
            this.panelShowControls.Controls.Add(this.button2);
            this.panelShowControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShowControls.Location = new System.Drawing.Point(3, 26);
            this.panelShowControls.Name = "panelShowControls";
            this.panelShowControls.Size = new System.Drawing.Size(528, 80);
            this.panelShowControls.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Location = new System.Drawing.Point(15, 15);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(180, 50);
            this.button4.TabIndex = 9;
            this.button4.Text = "Load Shows";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(210, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 50);
            this.button2.TabIndex = 5;
            this.button2.Text = "Delete Show";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(528, 545);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Admin_with_publisher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 750);
            this.Controls.Add(this.layoutMain);
            this.Controls.Add(this.panelHeader);
            this.Name = "Admin_with_publisher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Publisher & Show Management";
            this.Load += new System.EventHandler(this.Admin_with_publisher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.layoutMain.ResumeLayout(false);
            this.grpPublishers.ResumeLayout(false);
            this.panelPubControls.ResumeLayout(false);
            this.grpShows.ResumeLayout(false);
            this.panelShowControls.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1; // Delete Publisher
        private System.Windows.Forms.Button button2; // Delete Show
        private System.Windows.Forms.Button button3; // Load Publishers
        private System.Windows.Forms.Button button4; // Load Shows
        private System.Windows.Forms.Button button5; // Data Entry Form Link
        private System.Windows.Forms.Button btnAddPublisher; // Add Publisher
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TableLayoutPanel layoutMain;
        private System.Windows.Forms.GroupBox grpPublishers;
        private System.Windows.Forms.GroupBox grpShows;
        private System.Windows.Forms.Panel panelPubControls;
        private System.Windows.Forms.Panel panelShowControls;
    }
}
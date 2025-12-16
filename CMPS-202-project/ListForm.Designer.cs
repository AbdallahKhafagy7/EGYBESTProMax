namespace CMPS_202_project
{
    partial class ListForm
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.layoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.panelControls = new System.Windows.Forms.Panel();
            this.grpCreateList = new System.Windows.Forms.GroupBox();
            this.btnCreateList = new System.Windows.Forms.Button();
            this.lblNewList = new System.Windows.Forms.Label();
            this.txtNewListName = new System.Windows.Forms.TextBox();
            this.grpAction = new System.Windows.Forms.GroupBox();
            this.lblListSelect = new System.Windows.Forms.Label();
            this.grpSearchActor = new System.Windows.Forms.GroupBox();
            this.lblSearchActor = new System.Windows.Forms.Label();
            this.txtSearchActor = new System.Windows.Forms.TextBox();
            this.btnSearchActor = new System.Windows.Forms.Button();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.layoutMain.SuspendLayout();
            this.panelControls.SuspendLayout();
            this.grpCreateList.SuspendLayout();
            this.grpAction.SuspendLayout();
            this.grpSearchActor.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(19, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(280, 31);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(353, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(544, 639);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(280, 30);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search Name";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(19, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(280, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(19, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(280, 50);
            this.button2.TabIndex = 5;
            this.button2.Text = "Add Show to List";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(15, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Status Message";
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(12, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 45);
            this.button3.TabIndex = 7;
            this.button3.Text = "← Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.button3);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(900, 70);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(130, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(233, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Manage My Lists";
            // 
            // layoutMain
            // 
            this.layoutMain.ColumnCount = 2;
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutMain.Controls.Add(this.panelControls, 0, 0);
            this.layoutMain.Controls.Add(this.dataGridView1, 1, 0);
            this.layoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutMain.Location = new System.Drawing.Point(0, 70);
            this.layoutMain.Name = "layoutMain";
            this.layoutMain.RowCount = 1;
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutMain.Size = new System.Drawing.Size(900, 645);
            this.layoutMain.TabIndex = 1;
            // 
            // panelControls
            // 
            this.panelControls.AutoScroll = true;
            this.panelControls.Controls.Add(this.grpCreateList);
            this.panelControls.Controls.Add(this.grpAction);
            this.panelControls.Controls.Add(this.grpSearchActor);
            this.panelControls.Controls.Add(this.grpSearch);
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControls.Location = new System.Drawing.Point(3, 3);
            this.panelControls.Name = "panelControls";
            this.panelControls.Padding = new System.Windows.Forms.Padding(10);
            this.panelControls.Size = new System.Drawing.Size(344, 639);
            this.panelControls.TabIndex = 0;
            // 
            // grpCreateList
            // 
            this.grpCreateList.Controls.Add(this.btnCreateList);
            this.grpCreateList.Controls.Add(this.lblNewList);
            this.grpCreateList.Controls.Add(this.txtNewListName);
            this.grpCreateList.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpCreateList.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpCreateList.Location = new System.Drawing.Point(10, 540);
            this.grpCreateList.Name = "grpCreateList";
            this.grpCreateList.Size = new System.Drawing.Size(303, 150);
            this.grpCreateList.TabIndex = 2;
            this.grpCreateList.TabStop = false;
            this.grpCreateList.Text = "Create New List";
            // 
            // btnCreateList
            // 
            this.btnCreateList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateList.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCreateList.Location = new System.Drawing.Point(19, 100);
            this.btnCreateList.Name = "btnCreateList";
            this.btnCreateList.Size = new System.Drawing.Size(280, 40);
            this.btnCreateList.TabIndex = 2;
            this.btnCreateList.Text = "Create List";
            this.btnCreateList.UseVisualStyleBackColor = true;
            this.btnCreateList.Click += new System.EventHandler(this.btnCreateList_Click);
            // 
            // lblNewList
            // 
            this.lblNewList.AutoSize = true;
            this.lblNewList.Location = new System.Drawing.Point(15, 35);
            this.lblNewList.Name = "lblNewList";
            this.lblNewList.Size = new System.Drawing.Size(86, 23);
            this.lblNewList.TabIndex = 1;
            this.lblNewList.Text = "List Name";
            // 
            // txtNewListName
            // 
            this.txtNewListName.Location = new System.Drawing.Point(19, 61);
            this.txtNewListName.Name = "txtNewListName";
            this.txtNewListName.Size = new System.Drawing.Size(280, 30);
            this.txtNewListName.TabIndex = 0;
            // 
            // grpAction
            // 
            this.grpAction.Controls.Add(this.lblListSelect);
            this.grpAction.Controls.Add(this.comboBox1);
            this.grpAction.Controls.Add(this.button2);
            this.grpAction.Controls.Add(this.label2);
            this.grpAction.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpAction.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpAction.Location = new System.Drawing.Point(10, 320);
            this.grpAction.Name = "grpAction";
            this.grpAction.Size = new System.Drawing.Size(303, 220);
            this.grpAction.TabIndex = 1;
            this.grpAction.TabStop = false;
            this.grpAction.Text = "Add to List";
            // 
            // lblListSelect
            // 
            this.lblListSelect.AutoSize = true;
            this.lblListSelect.Location = new System.Drawing.Point(15, 40);
            this.lblListSelect.Name = "lblListSelect";
            this.lblListSelect.Size = new System.Drawing.Size(124, 23);
            this.lblListSelect.TabIndex = 8;
            this.lblListSelect.Text = "Select Your List";
            // 
            // grpSearchActor
            // 
            this.grpSearchActor.Controls.Add(this.lblSearchActor);
            this.grpSearchActor.Controls.Add(this.txtSearchActor);
            this.grpSearchActor.Controls.Add(this.btnSearchActor);
            this.grpSearchActor.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpSearchActor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpSearchActor.Location = new System.Drawing.Point(10, 170);
            this.grpSearchActor.Name = "grpSearchActor";
            this.grpSearchActor.Size = new System.Drawing.Size(303, 150);
            this.grpSearchActor.TabIndex = 3;
            this.grpSearchActor.TabStop = false;
            this.grpSearchActor.Text = "Search by Actor";
            // 
            // lblSearchActor
            // 
            this.lblSearchActor.AutoSize = true;
            this.lblSearchActor.Location = new System.Drawing.Point(15, 35);
            this.lblSearchActor.Name = "lblSearchActor";
            this.lblSearchActor.Size = new System.Drawing.Size(102, 23);
            this.lblSearchActor.TabIndex = 3;
            this.lblSearchActor.Text = "Actor Name";
            // 
            // txtSearchActor
            // 
            this.txtSearchActor.Location = new System.Drawing.Point(19, 61);
            this.txtSearchActor.Name = "txtSearchActor";
            this.txtSearchActor.Size = new System.Drawing.Size(280, 30);
            this.txtSearchActor.TabIndex = 2;
            this.txtSearchActor.TextChanged += new System.EventHandler(this.txtSearchActor_TextChanged);
            // 
            // btnSearchActor
            // 
            this.btnSearchActor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchActor.Location = new System.Drawing.Point(19, 105);
            this.btnSearchActor.Name = "btnSearchActor";
            this.btnSearchActor.Size = new System.Drawing.Size(280, 35);
            this.btnSearchActor.TabIndex = 4;
            this.btnSearchActor.Text = "Search by Actor";
            this.btnSearchActor.UseVisualStyleBackColor = true;
            this.btnSearchActor.Click += new System.EventHandler(this.btnSearchActor_Click_1);
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.label1);
            this.grpSearch.Controls.Add(this.textBox1);
            this.grpSearch.Controls.Add(this.button1);
            this.grpSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpSearch.Location = new System.Drawing.Point(10, 10);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(303, 160);
            this.grpSearch.TabIndex = 0;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Find Shows";
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 715);
            this.Controls.Add(this.layoutMain);
            this.Controls.Add(this.panelHeader);
            this.Name = "ListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List Manager";
            this.Load += new System.EventHandler(this.ListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.layoutMain.ResumeLayout(false);
            this.panelControls.ResumeLayout(false);
            this.grpCreateList.ResumeLayout(false);
            this.grpCreateList.PerformLayout();
            this.grpAction.ResumeLayout(false);
            this.grpAction.PerformLayout();
            this.grpSearchActor.ResumeLayout(false);
            this.grpSearchActor.PerformLayout();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TableLayoutPanel layoutMain;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.GroupBox grpAction;
        private System.Windows.Forms.Label lblListSelect;
        private System.Windows.Forms.GroupBox grpCreateList;
        private System.Windows.Forms.Button btnCreateList;
        private System.Windows.Forms.Label lblNewList;
        private System.Windows.Forms.TextBox txtNewListName;

        // New Controls
        private System.Windows.Forms.GroupBox grpSearchActor;
        private System.Windows.Forms.Label lblSearchActor;
        private System.Windows.Forms.TextBox txtSearchActor;
        private System.Windows.Forms.Button btnSearchActor;
    }
}
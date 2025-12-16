namespace CMPS_202_project
{
    partial class publisher_actor
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.layoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.grpPublisher = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.grpActor = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.grpCasting = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.lblMedia = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblActor = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.grpUpdate = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.lblUpdateName = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.lblUpdateAge = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.lblSelect = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.panelHeader.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.layoutMain.SuspendLayout();
            this.grpPublisher.SuspendLayout();
            this.grpActor.SuspendLayout();
            this.grpCasting.SuspendLayout();
            this.grpUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.btnBack);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1100, 70);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(130, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(245, 37);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Admin Data Entry";
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 45);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "← Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.Controls.Add(this.layoutMain);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 70);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(20);
            this.panelMain.Size = new System.Drawing.Size(1100, 800);
            this.panelMain.TabIndex = 1;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // layoutMain
            // 
            this.layoutMain.ColumnCount = 3;
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.layoutMain.Controls.Add(this.grpPublisher, 0, 0);
            this.layoutMain.Controls.Add(this.grpActor, 1, 0);
            this.layoutMain.Controls.Add(this.grpCasting, 2, 0);
            this.layoutMain.Controls.Add(this.grpUpdate, 1, 1);
            this.layoutMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutMain.Location = new System.Drawing.Point(20, 20);
            this.layoutMain.Name = "layoutMain";
            this.layoutMain.RowCount = 2;
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layoutMain.Size = new System.Drawing.Size(1039, 850);
            this.layoutMain.TabIndex = 0;
            // 
            // grpPublisher
            // 
            this.grpPublisher.Controls.Add(this.label8);
            this.grpPublisher.Controls.Add(this.textBox8);
            this.grpPublisher.Controls.Add(this.label3);
            this.grpPublisher.Controls.Add(this.textBox3);
            this.grpPublisher.Controls.Add(this.label5);
            this.grpPublisher.Controls.Add(this.textBox5);
            this.grpPublisher.Controls.Add(this.label4);
            this.grpPublisher.Controls.Add(this.textBox4);
            this.grpPublisher.Controls.Add(this.button2);
            this.grpPublisher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpPublisher.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpPublisher.Location = new System.Drawing.Point(3, 3);
            this.grpPublisher.Name = "grpPublisher";
            this.grpPublisher.Size = new System.Drawing.Size(340, 494);
            this.grpPublisher.TabIndex = 0;
            this.grpPublisher.TabStop = false;
            this.grpPublisher.Text = "Add Publisher";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label8.Location = new System.Drawing.Point(15, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Name";
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBox8.Location = new System.Drawing.Point(19, 63);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(300, 30);
            this.textBox8.TabIndex = 0;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.Location = new System.Drawing.Point(15, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Website";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBox3.Location = new System.Drawing.Point(19, 243);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(300, 30);
            this.textBox3.TabIndex = 3;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label5.Location = new System.Drawing.Point(15, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Password";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBox5.Location = new System.Drawing.Point(19, 183);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(300, 30);
            this.textBox5.TabIndex = 2;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label4.Location = new System.Drawing.Point(15, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBox4.Location = new System.Drawing.Point(19, 123);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(300, 30);
            this.textBox4.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(19, 290);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(300, 40);
            this.button2.TabIndex = 4;
            this.button2.Text = "Add Publisher";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // grpActor
            // 
            this.grpActor.Controls.Add(this.label2);
            this.grpActor.Controls.Add(this.textBox2);
            this.grpActor.Controls.Add(this.label1);
            this.grpActor.Controls.Add(this.textBox1);
            this.grpActor.Controls.Add(this.button1);
            this.grpActor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpActor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpActor.Location = new System.Drawing.Point(349, 3);
            this.grpActor.Name = "grpActor";
            this.grpActor.Size = new System.Drawing.Size(340, 494);
            this.grpActor.TabIndex = 1;
            this.grpActor.TabStop = false;
            this.grpActor.Text = "Add Actor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(15, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "age";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBox2.Location = new System.Drawing.Point(19, 123);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(300, 30);
            this.textBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.Location = new System.Drawing.Point(15, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBox1.Location = new System.Drawing.Point(19, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 30);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(19, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add Actor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpCasting
            // 
            this.grpCasting.Controls.Add(this.label7);
            this.grpCasting.Controls.Add(this.textBox7);
            this.grpCasting.Controls.Add(this.label6);
            this.grpCasting.Controls.Add(this.textBox6);
            this.grpCasting.Controls.Add(this.lblMedia);
            this.grpCasting.Controls.Add(this.comboBox2);
            this.grpCasting.Controls.Add(this.lblActor);
            this.grpCasting.Controls.Add(this.comboBox1);
            this.grpCasting.Controls.Add(this.button3);
            this.grpCasting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCasting.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpCasting.Location = new System.Drawing.Point(695, 3);
            this.grpCasting.Name = "grpCasting";
            this.grpCasting.Size = new System.Drawing.Size(341, 494);
            this.grpCasting.TabIndex = 2;
            this.grpCasting.TabStop = false;
            this.grpCasting.Text = "Manage Casting";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label7.Location = new System.Drawing.Point(15, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Media";
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBox7.Location = new System.Drawing.Point(19, 243);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(300, 30);
            this.textBox7.TabIndex = 3;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label6.Location = new System.Drawing.Point(15, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Actor";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBox6.Location = new System.Drawing.Point(19, 183);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(300, 30);
            this.textBox6.TabIndex = 2;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged_1);
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMedia.Location = new System.Drawing.Point(15, 100);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(51, 20);
            this.lblMedia.TabIndex = 4;
            this.lblMedia.Text = "Media";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(19, 123);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(300, 31);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged_1);
            // 
            // lblActor
            // 
            this.lblActor.AutoSize = true;
            this.lblActor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblActor.Location = new System.Drawing.Point(15, 40);
            this.lblActor.Name = "lblActor";
            this.lblActor.Size = new System.Drawing.Size(45, 20);
            this.lblActor.TabIndex = 2;
            this.lblActor.Text = "Actor";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(19, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(300, 31);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(19, 290);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(300, 40);
            this.button3.TabIndex = 4;
            this.button3.Text = "Link Actor to Media";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // grpUpdate
            // 
            this.grpUpdate.Controls.Add(this.button4);
            this.grpUpdate.Controls.Add(this.lblUpdateName);
            this.grpUpdate.Controls.Add(this.textBox11);
            this.grpUpdate.Controls.Add(this.lblUpdateAge);
            this.grpUpdate.Controls.Add(this.textBox10);
            this.grpUpdate.Controls.Add(this.lblSelect);
            this.grpUpdate.Controls.Add(this.comboBox3);
            this.grpUpdate.Controls.Add(this.lblSearch);
            this.grpUpdate.Controls.Add(this.textBox9);
            this.grpUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpUpdate.Location = new System.Drawing.Point(349, 503);
            this.grpUpdate.Name = "grpUpdate";
            this.grpUpdate.Size = new System.Drawing.Size(340, 344);
            this.grpUpdate.TabIndex = 3;
            this.grpUpdate.TabStop = false;
            this.grpUpdate.Text = "Update Actor";
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(19, 290);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(300, 40);
            this.button4.TabIndex = 4;
            this.button4.Text = "Update Actor";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblUpdateName
            // 
            this.lblUpdateName.AutoSize = true;
            this.lblUpdateName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblUpdateName.Location = new System.Drawing.Point(15, 220);
            this.lblUpdateName.Name = "lblUpdateName";
            this.lblUpdateName.Size = new System.Drawing.Size(111, 20);
            this.lblUpdateName.TabIndex = 7;
            this.lblUpdateName.Text = "Updated Name";
            // 
            // textBox11
            // 
            this.textBox11.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBox11.Location = new System.Drawing.Point(19, 243);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(300, 30);
            this.textBox11.TabIndex = 3;
            this.textBox11.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // lblUpdateAge
            // 
            this.lblUpdateAge.AutoSize = true;
            this.lblUpdateAge.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblUpdateAge.Location = new System.Drawing.Point(15, 160);
            this.lblUpdateAge.Name = "lblUpdateAge";
            this.lblUpdateAge.Size = new System.Drawing.Size(98, 20);
            this.lblUpdateAge.TabIndex = 5;
            this.lblUpdateAge.Text = "Updated Age";
            // 
            // textBox10
            // 
            this.textBox10.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBox10.Location = new System.Drawing.Point(19, 183);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(300, 30);
            this.textBox10.TabIndex = 2;
            this.textBox10.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSelect.Location = new System.Drawing.Point(15, 100);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(89, 20);
            this.lblSelect.TabIndex = 3;
            this.lblSelect.Text = "Select Actor";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(19, 123);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(300, 31);
            this.comboBox3.TabIndex = 1;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSearch.Location = new System.Drawing.Point(15, 40);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(97, 20);
            this.lblSearch.TabIndex = 8;
            this.lblSearch.Text = "Search Name";
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBox9.Location = new System.Drawing.Point(19, 63);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(300, 30);
            this.textBox9.TabIndex = 0;
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // publisher_actor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 870);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.Name = "publisher_actor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Data Entry";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.layoutMain.ResumeLayout(false);
            this.grpPublisher.ResumeLayout(false);
            this.grpPublisher.PerformLayout();
            this.grpActor.ResumeLayout(false);
            this.grpActor.PerformLayout();
            this.grpCasting.ResumeLayout(false);
            this.grpCasting.PerformLayout();
            this.grpUpdate.ResumeLayout(false);
            this.grpUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TableLayoutPanel layoutMain;

        // Publisher Group
        private System.Windows.Forms.GroupBox grpPublisher;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;

        // Actor Group
        private System.Windows.Forms.GroupBox grpActor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        // Casting Group
        private System.Windows.Forms.GroupBox grpCasting;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblActor;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;

        // Update Group (New)
        private System.Windows.Forms.GroupBox grpUpdate;
        private System.Windows.Forms.TextBox textBox9; // Search
        private System.Windows.Forms.ComboBox comboBox3; // Select
        private System.Windows.Forms.TextBox textBox10; // New Age
        private System.Windows.Forms.TextBox textBox11; // New Name
        private System.Windows.Forms.Button button4; // Update
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Label lblUpdateAge;
        private System.Windows.Forms.Label lblUpdateName;
    }
}
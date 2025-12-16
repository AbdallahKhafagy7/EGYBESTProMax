namespace CMPS_202_project
{
    partial class SubscriptionPlan
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
            this.grpSubscription = new System.Windows.Forms.GroupBox();
            this.lblCurrentPlan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.grpSubscription.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.btnBack);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 70);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(130, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(289, 37);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Manage Subscription";
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
            this.panelMain.Controls.Add(this.grpSubscription);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 70);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(50);
            this.panelMain.Size = new System.Drawing.Size(800, 380);
            this.panelMain.TabIndex = 1;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // grpSubscription
            // 
            this.grpSubscription.Controls.Add(this.lblCurrentPlan);
            this.grpSubscription.Controls.Add(this.label1);
            this.grpSubscription.Controls.Add(this.comboBox1);
            this.grpSubscription.Controls.Add(this.label2);
            this.grpSubscription.Controls.Add(this.textBox1);
            this.grpSubscription.Controls.Add(this.button1);
            this.grpSubscription.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpSubscription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpSubscription.Location = new System.Drawing.Point(50, 50);
            this.grpSubscription.Name = "grpSubscription";
            this.grpSubscription.Size = new System.Drawing.Size(700, 280);
            this.grpSubscription.TabIndex = 0;
            this.grpSubscription.TabStop = false;
            this.grpSubscription.Text = "Plan Details";
            // 
            // lblCurrentPlan
            // 
            this.lblCurrentPlan.AutoSize = true;
            this.lblCurrentPlan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCurrentPlan.Location = new System.Drawing.Point(40, 40);
            this.lblCurrentPlan.Name = "lblCurrentPlan";
            this.lblCurrentPlan.Size = new System.Drawing.Size(231, 28);
            this.lblCurrentPlan.TabIndex = 2;
            this.lblCurrentPlan.Text = "Current Plan: Loading...";
            this.lblCurrentPlan.Click += new System.EventHandler(this.lblCurrentPlan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select New Plan";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(44, 116);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(250, 31);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Confirm Password";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(344, 117);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '•';
            this.textBox1.Size = new System.Drawing.Size(250, 30);
            this.textBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(44, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(550, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Update Subscription";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SubscriptionPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.Name = "SubscriptionPlan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Subscription Plan";
            this.Load += new System.EventHandler(this.SubscriptionPlan_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.grpSubscription.ResumeLayout(false);
            this.grpSubscription.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.GroupBox grpSubscription;
        private System.Windows.Forms.Label lblCurrentPlan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}
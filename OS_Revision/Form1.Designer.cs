namespace OS_Revision
{
    partial class mainform
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
            lblname = new Label();
            txtname = new TextBox();
            lblage = new Label();
            txtage = new TextBox();
            lblgender = new Label();
            rdmale = new RadioButton();
            rdfemale = new RadioButton();
            lblcity = new Label();
            cmbcity = new ComboBox();
            chlcourses = new CheckedListBox();
            lblcourses = new Label();
            btnsend = new Button();
            SuspendLayout();
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblname.ForeColor = Color.Blue;
            lblname.Location = new Point(55, 31);
            lblname.Margin = new Padding(5, 0, 5, 0);
            lblname.Name = "lblname";
            lblname.Size = new Size(137, 31);
            lblname.TabIndex = 0;
            lblname.Text = "User Name:";
            // 
            // txtname
            // 
            txtname.Location = new Point(262, 41);
            txtname.Margin = new Padding(5);
            txtname.Name = "txtname";
            txtname.Size = new Size(480, 38);
            txtname.TabIndex = 1;
            // 
            // lblage
            // 
            lblage.AutoSize = true;
            lblage.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblage.ForeColor = Color.Blue;
            lblage.Location = new Point(55, 88);
            lblage.Margin = new Padding(5, 0, 5, 0);
            lblage.Name = "lblage";
            lblage.Size = new Size(62, 31);
            lblage.TabIndex = 2;
            lblage.Text = "Age:";
            // 
            // txtage
            // 
            txtage.Location = new Point(262, 109);
            txtage.Margin = new Padding(5);
            txtage.Name = "txtage";
            txtage.Size = new Size(480, 38);
            txtage.TabIndex = 3;
            // 
            // lblgender
            // 
            lblgender.AutoSize = true;
            lblgender.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblgender.ForeColor = Color.Blue;
            lblgender.Location = new Point(55, 192);
            lblgender.Margin = new Padding(5, 0, 5, 0);
            lblgender.Name = "lblgender";
            lblgender.Size = new Size(98, 31);
            lblgender.TabIndex = 4;
            lblgender.Text = "Gender:";
            // 
            // rdmale
            // 
            rdmale.AutoSize = true;
            rdmale.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            rdmale.ForeColor = Color.FromArgb(64, 64, 64);
            rdmale.Location = new Point(262, 178);
            rdmale.Margin = new Padding(5);
            rdmale.Name = "rdmale";
            rdmale.Size = new Size(86, 35);
            rdmale.TabIndex = 5;
            rdmale.TabStop = true;
            rdmale.Text = "Male";
            rdmale.UseVisualStyleBackColor = true;
            // 
            // rdfemale
            // 
            rdfemale.AutoSize = true;
            rdfemale.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            rdfemale.ForeColor = Color.FromArgb(64, 64, 64);
            rdfemale.Location = new Point(262, 232);
            rdfemale.Margin = new Padding(5);
            rdfemale.Name = "rdfemale";
            rdfemale.Size = new Size(108, 35);
            rdfemale.TabIndex = 6;
            rdfemale.TabStop = true;
            rdfemale.Text = "Female";
            rdfemale.UseVisualStyleBackColor = true;
            // 
            // lblcity
            // 
            lblcity.AutoSize = true;
            lblcity.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblcity.ForeColor = Color.Blue;
            lblcity.Location = new Point(55, 343);
            lblcity.Margin = new Padding(5, 0, 5, 0);
            lblcity.Name = "lblcity";
            lblcity.Size = new Size(62, 31);
            lblcity.TabIndex = 7;
            lblcity.Text = "City:";
            // 
            // cmbcity
            // 
            cmbcity.BackColor = SystemColors.HighlightText;
            cmbcity.ForeColor = Color.Black;
            cmbcity.FormattingEnabled = true;
            cmbcity.Items.AddRange(new object[] { "Cairo", "Alexandria", "El-Mansoura", "El-Mahalla", "El-Fayoum" });
            cmbcity.Location = new Point(236, 335);
            cmbcity.Margin = new Padding(5);
            cmbcity.Name = "cmbcity";
            cmbcity.Size = new Size(316, 39);
            cmbcity.TabIndex = 8;
            cmbcity.Text = "Choose Your City";
            // 
            // chlcourses
            // 
            chlcourses.CheckOnClick = true;
            chlcourses.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            chlcourses.ForeColor = Color.Black;
            chlcourses.FormattingEnabled = true;
            chlcourses.Items.AddRange(new object[] { "Data Structure", "Operating Systems", "Computer Organization & Architecture", "Linear Algebra ", "Web Programming ", "C Programming " });
            chlcourses.Location = new Point(236, 405);
            chlcourses.Name = "chlcourses";
            chlcourses.Size = new Size(476, 136);
            chlcourses.TabIndex = 9;
            // 
            // lblcourses
            // 
            lblcourses.AutoSize = true;
            lblcourses.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblcourses.ForeColor = Color.Blue;
            lblcourses.Location = new Point(50, 435);
            lblcourses.Margin = new Padding(5, 0, 5, 0);
            lblcourses.Name = "lblcourses";
            lblcourses.Size = new Size(103, 31);
            lblcourses.TabIndex = 10;
            lblcourses.Text = "Courses:";
            // 
            // btnsend
            // 
            btnsend.BackColor = Color.Red;
            btnsend.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnsend.ForeColor = Color.FromArgb(0, 0, 64);
            btnsend.Location = new Point(549, 635);
            btnsend.Name = "btnsend";
            btnsend.Size = new Size(257, 71);
            btnsend.TabIndex = 11;
            btnsend.Text = "Send ";
            btnsend.UseVisualStyleBackColor = false;
            btnsend.Click += btnsend_Click;
            // 
            // mainform
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1228, 718);
            Controls.Add(btnsend);
            Controls.Add(lblcourses);
            Controls.Add(chlcourses);
            Controls.Add(cmbcity);
            Controls.Add(lblcity);
            Controls.Add(rdfemale);
            Controls.Add(rdmale);
            Controls.Add(lblgender);
            Controls.Add(txtage);
            Controls.Add(lblage);
            Controls.Add(txtname);
            Controls.Add(lblname);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Red;
            Margin = new Padding(5);
            Name = "mainform";
            Text = "Main Form ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblname;
        private TextBox txtname;
        private Label lblage;
        private TextBox txtage;
        private Label lblgender;
        private RadioButton rdmale;
        private RadioButton rdfemale;
        private Label lblcity;
        private ComboBox cmbcity;
        private CheckedListBox chlcourses;
        private Label lblcourses;
        private Button btnsend;
    }
}
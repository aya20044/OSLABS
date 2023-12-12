namespace OS_Revision
{
    partial class Form2
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
            btnShowInfo = new Button();
            rchshow = new RichTextBox();
            lblwelcom = new Label();
            SuspendLayout();
            // 
            // btnShowInfo
            // 
            btnShowInfo.BackColor = Color.Red;
            btnShowInfo.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnShowInfo.Location = new Point(164, 328);
            btnShowInfo.Name = "btnShowInfo";
            btnShowInfo.Size = new Size(499, 110);
            btnShowInfo.TabIndex = 0;
            btnShowInfo.Text = "Show My Information";
            btnShowInfo.UseVisualStyleBackColor = false;
            btnShowInfo.Click += btnShowInfo_Click;
            // 
            // rchshow
            // 
            rchshow.BackColor = Color.White;
            rchshow.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            rchshow.Location = new Point(-3, 50);
            rchshow.Name = "rchshow";
            rchshow.Size = new Size(802, 247);
            rchshow.TabIndex = 1;
            rchshow.Text = "";
            // 
            // lblwelcom
            // 
            lblwelcom.AutoSize = true;
            lblwelcom.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblwelcom.ForeColor = Color.Red;
            lblwelcom.Location = new Point(348, 9);
            lblwelcom.Name = "lblwelcom";
            lblwelcom.Size = new Size(100, 38);
            lblwelcom.TabIndex = 2;
            lblwelcom.Text = "label1";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(800, 450);
            Controls.Add(lblwelcom);
            Controls.Add(rchshow);
            Controls.Add(btnShowInfo);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnShowInfo;
        private RichTextBox rchshow;
        public static Label lblwelcom;
    }
}
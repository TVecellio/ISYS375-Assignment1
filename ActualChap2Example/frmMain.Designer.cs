namespace ActualChap2Example
{
    partial class frmMain
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
            btn_hello = new Button();
            lblstash = new Label();
            btnShow = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // btn_hello
            // 
            btn_hello.Location = new Point(450, 200);
            btn_hello.Name = "btn_hello";
            btn_hello.Size = new Size(206, 135);
            btn_hello.TabIndex = 0;
            btn_hello.Text = "Hello World";
            btn_hello.UseVisualStyleBackColor = true;
            btn_hello.Click += button1_Click;
            // 
            // lblstash
            // 
            lblstash.Font = new Font("Verdana", 20F);
            lblstash.Location = new Point(148, 80);
            lblstash.Name = "lblstash";
            lblstash.Size = new Size(296, 348);
            lblstash.TabIndex = 1;
            lblstash.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(512, 341);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(94, 124);
            btnShow.TabIndex = 2;
            btnShow.Text = "Show/Hide";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(1139, -2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 3;
            btnClose.Text = "close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1235, 628);
            ControlBox = false;
            Controls.Add(btnClose);
            Controls.Add(btnShow);
            Controls.Add(lblstash);
            Controls.Add(btn_hello);
            Name = "frmMain";
            Text = "The First Program";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_hello;
        private Label lblstash;
        private Button btnShow;
        private Button btnClose;
    }
}

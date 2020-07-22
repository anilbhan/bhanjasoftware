namespace BhanjaPoultrySuppliers
{
    partial class cashdeposite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cashdeposite));
            this.button1 = new System.Windows.Forms.Button();
            this.cashcompanyname_textbox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.purpose_textbox = new System.Windows.Forms.TextBox();
            this.deposite_textbox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.amount_textbox = new System.Windows.Forms.TextBox();
            this.cashsave_textbox = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.date_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Company Name";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cashcompanyname_textbox
            // 
            this.cashcompanyname_textbox.Location = new System.Drawing.Point(145, 26);
            this.cashcompanyname_textbox.Multiline = true;
            this.cashcompanyname_textbox.Name = "cashcompanyname_textbox";
            this.cashcompanyname_textbox.Size = new System.Drawing.Size(172, 23);
            this.cashcompanyname_textbox.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(353, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Amount";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(353, 28);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Purpose";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // purpose_textbox
            // 
            this.purpose_textbox.Location = new System.Drawing.Point(479, 28);
            this.purpose_textbox.Multiline = true;
            this.purpose_textbox.Name = "purpose_textbox";
            this.purpose_textbox.Size = new System.Drawing.Size(172, 23);
            this.purpose_textbox.TabIndex = 1;
            // 
            // deposite_textbox
            // 
            this.deposite_textbox.Location = new System.Drawing.Point(145, 78);
            this.deposite_textbox.Multiline = true;
            this.deposite_textbox.Name = "deposite_textbox";
            this.deposite_textbox.Size = new System.Drawing.Size(172, 23);
            this.deposite_textbox.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 76);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "Deposited by";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // amount_textbox
            // 
            this.amount_textbox.Location = new System.Drawing.Point(479, 76);
            this.amount_textbox.Multiline = true;
            this.amount_textbox.Name = "amount_textbox";
            this.amount_textbox.Size = new System.Drawing.Size(172, 23);
            this.amount_textbox.TabIndex = 1;
            // 
            // cashsave_textbox
            // 
            this.cashsave_textbox.Image = ((System.Drawing.Image)(resources.GetObject("cashsave_textbox.Image")));
            this.cashsave_textbox.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cashsave_textbox.Location = new System.Drawing.Point(600, 142);
            this.cashsave_textbox.Name = "cashsave_textbox";
            this.cashsave_textbox.Size = new System.Drawing.Size(51, 23);
            this.cashsave_textbox.TabIndex = 2;
            this.cashsave_textbox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cashsave_textbox.UseVisualStyleBackColor = true;
            this.cashsave_textbox.Click += new System.EventHandler(this.cashsave_textbox_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(242, 172);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 3;
            this.button5.Text = "Date";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // date_lbl
            // 
            this.date_lbl.AutoSize = true;
            this.date_lbl.Location = new System.Drawing.Point(373, 182);
            this.date_lbl.Name = "date_lbl";
            this.date_lbl.Size = new System.Drawing.Size(35, 13);
            this.date_lbl.TabIndex = 4;
            this.date_lbl.Text = "label1";
            // 
            // cashdeposite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 261);
            this.Controls.Add(this.date_lbl);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.cashsave_textbox);
            this.Controls.Add(this.amount_textbox);
            this.Controls.Add(this.deposite_textbox);
            this.Controls.Add(this.purpose_textbox);
            this.Controls.Add(this.cashcompanyname_textbox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "cashdeposite";
            this.Text = "cashdeposite";
            this.Load += new System.EventHandler(this.cashdeposite_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox cashcompanyname_textbox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox purpose_textbox;
        private System.Windows.Forms.TextBox deposite_textbox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox amount_textbox;
        private System.Windows.Forms.Button cashsave_textbox;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label date_lbl;
    }
}
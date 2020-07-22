namespace BhanjaPoultrySuppliers
{
    partial class cashcollection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cashcollection));
            this.name_btnbox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.amount_txtbox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.collectedby_txtbox = new System.Windows.Forms.TextBox();
            this.name_btn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Search_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // name_btnbox
            // 
            this.name_btnbox.Location = new System.Drawing.Point(159, 42);
            this.name_btnbox.Multiline = true;
            this.name_btnbox.Name = "name_btnbox";
            this.name_btnbox.Size = new System.Drawing.Size(226, 33);
            this.name_btnbox.TabIndex = 1;
            this.name_btnbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(38, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Amount";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // amount_txtbox
            // 
            this.amount_txtbox.Location = new System.Drawing.Point(159, 103);
            this.amount_txtbox.Multiline = true;
            this.amount_txtbox.Name = "amount_txtbox";
            this.amount_txtbox.Size = new System.Drawing.Size(226, 33);
            this.amount_txtbox.TabIndex = 2;
            this.amount_txtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.amount_txtbox_KeyPress);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(441, 50);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Collected by";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // collectedby_txtbox
            // 
            this.collectedby_txtbox.Location = new System.Drawing.Point(547, 50);
            this.collectedby_txtbox.Multiline = true;
            this.collectedby_txtbox.Name = "collectedby_txtbox";
            this.collectedby_txtbox.Size = new System.Drawing.Size(226, 33);
            this.collectedby_txtbox.TabIndex = 3;
            this.collectedby_txtbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // name_btn
            // 
            this.name_btn.Location = new System.Drawing.Point(38, 52);
            this.name_btn.Name = "name_btn";
            this.name_btn.Size = new System.Drawing.Size(95, 23);
            this.name_btn.TabIndex = 0;
            this.name_btn.Text = "Customer Name";
            this.name_btn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(168, 210);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(444, 36);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(127, 263);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(595, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // Search_btn
            // 
            this.Search_btn.Image = ((System.Drawing.Image)(resources.GetObject("Search_btn.Image")));
            this.Search_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Search_btn.Location = new System.Drawing.Point(647, 223);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(75, 23);
            this.Search_btn.TabIndex = 6;
            this.Search_btn.Text = "Search";
            this.Search_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Search_btn.UseVisualStyleBackColor = true;
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.Ivory;
            this.save_btn.Image = ((System.Drawing.Image)(resources.GetObject("save_btn.Image")));
            this.save_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.save_btn.Location = new System.Drawing.Point(717, 124);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(56, 23);
            this.save_btn.TabIndex = 4;
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(687, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // cashcollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(861, 413);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Search_btn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.amount_txtbox);
            this.Controls.Add(this.collectedby_txtbox);
            this.Controls.Add(this.name_btnbox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.name_btn);
            this.MaximizeBox = false;
            this.Name = "cashcollection";
            this.Text = "cashcollection";
            this.Load += new System.EventHandler(this.cashcollection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button name_btn;
        private System.Windows.Forms.TextBox name_btnbox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox amount_txtbox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox collectedby_txtbox;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
    }
}
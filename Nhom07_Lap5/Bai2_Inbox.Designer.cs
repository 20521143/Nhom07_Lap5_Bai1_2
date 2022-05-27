
namespace Nhom07_Lap5
{
    partial class Bai2_Inbox
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Email = new System.Windows.Forms.Label();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.tb_PassWord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.label_Total = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_Recent = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(40, 41);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(42, 17);
            this.Email.TabIndex = 0;
            this.Email.Text = "Email";
            // 
            // tb_Email
            // 
            this.tb_Email.Location = new System.Drawing.Point(196, 41);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(334, 22);
            this.tb_Email.TabIndex = 1;
            // 
            // tb_PassWord
            // 
            this.tb_PassWord.Location = new System.Drawing.Point(196, 105);
            this.tb_PassWord.Name = "tb_PassWord";
            this.tb_PassWord.Size = new System.Drawing.Size(334, 22);
            this.tb_PassWord.TabIndex = 3;
            this.tb_PassWord.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "PassWord";
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(835, 81);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(75, 23);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(102, 250);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(891, 298);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total";
            // 
            // label_Total
            // 
            this.label_Total.AutoSize = true;
            this.label_Total.Location = new System.Drawing.Point(246, 205);
            this.label_Total.Name = "label_Total";
            this.label_Total.Size = new System.Drawing.Size(0, 17);
            this.label_Total.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(373, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Reccent";
            // 
            // label_Recent
            // 
            this.label_Recent.AutoSize = true;
            this.label_Recent.Location = new System.Drawing.Point(505, 205);
            this.label_Recent.Name = "label_Recent";
            this.label_Recent.Size = new System.Drawing.Size(0, 17);
            this.label_Recent.TabIndex = 9;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(335, 144);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 21);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Bai2_Inbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 560);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label_Recent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_Total);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.tb_PassWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Email);
            this.Controls.Add(this.Email);
            this.Name = "Bai2_Inbox";
            this.Text = "Bai2_Inbox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.TextBox tb_PassWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_Total;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_Recent;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
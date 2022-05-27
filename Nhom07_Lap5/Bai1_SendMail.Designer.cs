
namespace Nhom07_Lap5
{
    partial class Bai1_SendMail
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_From = new System.Windows.Forms.TextBox();
            this.tb_To = new System.Windows.Forms.TextBox();
            this.To = new System.Windows.Forms.Label();
            this.tb_PassWord = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Subject = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Body = new System.Windows.Forms.TextBox();
            this.Body = new System.Windows.Forms.Label();
            this.bt_Login = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // tb_From
            // 
            this.tb_From.Location = new System.Drawing.Point(230, 27);
            this.tb_From.Name = "tb_From";
            this.tb_From.Size = new System.Drawing.Size(228, 22);
            this.tb_From.TabIndex = 1;
            // 
            // tb_To
            // 
            this.tb_To.Location = new System.Drawing.Point(230, 104);
            this.tb_To.Name = "tb_To";
            this.tb_To.Size = new System.Drawing.Size(228, 22);
            this.tb_To.TabIndex = 3;
            // 
            // To
            // 
            this.To.AutoSize = true;
            this.To.Location = new System.Drawing.Point(138, 104);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(25, 17);
            this.To.TabIndex = 2;
            this.To.Text = "To";
            // 
            // tb_PassWord
            // 
            this.tb_PassWord.Location = new System.Drawing.Point(644, 38);
            this.tb_PassWord.Name = "tb_PassWord";
            this.tb_PassWord.Size = new System.Drawing.Size(269, 22);
            this.tb_PassWord.TabIndex = 5;
            this.tb_PassWord.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(525, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "PassWord";
            // 
            // tb_Subject
            // 
            this.tb_Subject.Location = new System.Drawing.Point(144, 183);
            this.tb_Subject.Name = "tb_Subject";
            this.tb_Subject.Size = new System.Drawing.Size(416, 22);
            this.tb_Subject.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Subject";
            // 
            // tb_Body
            // 
            this.tb_Body.Location = new System.Drawing.Point(144, 259);
            this.tb_Body.Multiline = true;
            this.tb_Body.Name = "tb_Body";
            this.tb_Body.Size = new System.Drawing.Size(428, 265);
            this.tb_Body.TabIndex = 9;
            // 
            // Body
            // 
            this.Body.AutoSize = true;
            this.Body.Location = new System.Drawing.Point(52, 259);
            this.Body.Name = "Body";
            this.Body.Size = new System.Drawing.Size(40, 17);
            this.Body.TabIndex = 8;
            this.Body.Text = "Body";
            // 
            // bt_Login
            // 
            this.bt_Login.Location = new System.Drawing.Point(41, 27);
            this.bt_Login.Name = "bt_Login";
            this.bt_Login.Size = new System.Drawing.Size(75, 23);
            this.bt_Login.TabIndex = 10;
            this.bt_Login.Text = "Login";
            this.bt_Login.UseVisualStyleBackColor = true;
            this.bt_Login.Click += new System.EventHandler(this.bt_Login_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(725, 87);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(133, 21);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Show PassWord";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Bai1_SendMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 536);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.bt_Login);
            this.Controls.Add(this.tb_Body);
            this.Controls.Add(this.Body);
            this.Controls.Add(this.tb_Subject);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_PassWord);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_To);
            this.Controls.Add(this.To);
            this.Controls.Add(this.tb_From);
            this.Controls.Add(this.label1);
            this.Name = "Bai1_SendMail";
            this.Text = "Bai1_SendMail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_From;
        private System.Windows.Forms.TextBox tb_To;
        private System.Windows.Forms.Label To;
        private System.Windows.Forms.TextBox tb_PassWord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Subject;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Body;
        private System.Windows.Forms.Label Body;
        private System.Windows.Forms.Button bt_Login;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
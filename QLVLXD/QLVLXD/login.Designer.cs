namespace QLVLXD
{
	partial class login
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
			this.tx_tk = new System.Windows.Forms.TextBox();
			this.tx_mk = new System.Windows.Forms.TextBox();
			this.bt_login = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// tx_tk
			// 
			this.tx_tk.Location = new System.Drawing.Point(153, 96);
			this.tx_tk.Multiline = true;
			this.tx_tk.Name = "tx_tk";
			this.tx_tk.Size = new System.Drawing.Size(238, 38);
			this.tx_tk.TabIndex = 0;
			// 
			// tx_mk
			// 
			this.tx_mk.Location = new System.Drawing.Point(153, 194);
			this.tx_mk.Multiline = true;
			this.tx_mk.Name = "tx_mk";
			this.tx_mk.Size = new System.Drawing.Size(238, 38);
			this.tx_mk.TabIndex = 1;
			// 
			// bt_login
			// 
			this.bt_login.Location = new System.Drawing.Point(292, 301);
			this.bt_login.Name = "bt_login";
			this.bt_login.Size = new System.Drawing.Size(99, 39);
			this.bt_login.TabIndex = 2;
			this.bt_login.Text = "login";
			this.bt_login.UseVisualStyleBackColor = true;
			this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(33, 109);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 16);
			this.label1.TabIndex = 3;
			this.label1.Text = "Tài Khoản";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(33, 207);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 16);
			this.label2.TabIndex = 4;
			this.label2.Text = "Mặt khẩu";
			// 
			// login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(517, 431);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.bt_login);
			this.Controls.Add(this.tx_mk);
			this.Controls.Add(this.tx_tk);
			this.Name = "login";
			this.Text = "login";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tx_tk;
		private System.Windows.Forms.TextBox tx_mk;
		private System.Windows.Forms.Button bt_login;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}
namespace QLVLXD
{
    partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.panel1 = new System.Windows.Forms.Panel();
			this.grview_hang = new System.Windows.Forms.DataGridView();
			this.bt_create = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btn_fix = new System.Windows.Forms.Button();
			this.btn_search = new System.Windows.Forms.Button();
			this.txb_Search = new System.Windows.Forms.TextBox();
			this.btn_Delete = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.grview_hang)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Location = new System.Drawing.Point(3, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(248, 699);
			this.panel1.TabIndex = 0;
			// 
			// grview_hang
			// 
			this.grview_hang.AllowUserToResizeColumns = false;
			this.grview_hang.AllowUserToResizeRows = false;
			this.grview_hang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grview_hang.Cursor = System.Windows.Forms.Cursors.Hand;
			this.grview_hang.Location = new System.Drawing.Point(254, 67);
			this.grview_hang.Name = "grview_hang";
			this.grview_hang.ReadOnly = true;
			this.grview_hang.RowHeadersWidth = 51;
			this.grview_hang.RowTemplate.Height = 24;
			this.grview_hang.Size = new System.Drawing.Size(983, 634);
			this.grview_hang.TabIndex = 2;
			this.grview_hang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grview_hang_CellContentClick);
			// 
			// bt_create
			// 
			this.bt_create.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.bt_create.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_create.BackgroundImage")));
			this.bt_create.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.bt_create.Location = new System.Drawing.Point(925, 9);
			this.bt_create.Name = "bt_create";
			this.bt_create.Size = new System.Drawing.Size(46, 39);
			this.bt_create.TabIndex = 0;
			this.bt_create.UseVisualStyleBackColor = false;
			this.bt_create.Click += new System.EventHandler(this.bt_create_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btn_fix);
			this.panel2.Controls.Add(this.btn_search);
			this.panel2.Controls.Add(this.txb_Search);
			this.panel2.Controls.Add(this.btn_Delete);
			this.panel2.Controls.Add(this.bt_create);
			this.panel2.Location = new System.Drawing.Point(254, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(982, 64);
			this.panel2.TabIndex = 3;
			// 
			// btn_fix
			// 
			this.btn_fix.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn_fix.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_fix.BackgroundImage")));
			this.btn_fix.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btn_fix.Location = new System.Drawing.Point(805, 9);
			this.btn_fix.Name = "btn_fix";
			this.btn_fix.Size = new System.Drawing.Size(39, 39);
			this.btn_fix.TabIndex = 7;
			this.btn_fix.UseVisualStyleBackColor = false;
			this.btn_fix.Click += new System.EventHandler(this.btn_fix_Click);
			// 
			// btn_search
			// 
			this.btn_search.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_search.BackgroundImage")));
			this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btn_search.Location = new System.Drawing.Point(396, 15);
			this.btn_search.Name = "btn_search";
			this.btn_search.Size = new System.Drawing.Size(30, 25);
			this.btn_search.TabIndex = 6;
			this.btn_search.UseVisualStyleBackColor = false;
			this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
			// 
			// txb_Search
			// 
			this.txb_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_Search.Location = new System.Drawing.Point(31, 14);
			this.txb_Search.Name = "txb_Search";
			this.txb_Search.Size = new System.Drawing.Size(395, 26);
			this.txb_Search.TabIndex = 5;
			this.txb_Search.TextChanged += new System.EventHandler(this.txb_Search_TextChanged);
			// 
			// btn_Delete
			// 
			this.btn_Delete.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn_Delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Delete.BackgroundImage")));
			this.btn_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btn_Delete.Location = new System.Drawing.Point(863, 9);
			this.btn_Delete.Name = "btn_Delete";
			this.btn_Delete.Size = new System.Drawing.Size(43, 39);
			this.btn_Delete.TabIndex = 4;
			this.btn_Delete.UseVisualStyleBackColor = false;
			this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1237, 705);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.grview_hang);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.grview_hang)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView grview_hang;
        private System.Windows.Forms.Button bt_create;
        private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btn_Delete;
		private System.Windows.Forms.Button btn_search;
		private System.Windows.Forms.TextBox txb_Search;
		private System.Windows.Forms.Button btn_fix;
	}
}


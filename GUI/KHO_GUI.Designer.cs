namespace GUI
{
    partial class KHO_GUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.artanPanel1 = new ArtanComponent.ArtanPanel();
            this.artanPanel2 = new ArtanComponent.ArtanPanel();
            this.artanPanel3 = new ArtanComponent.ArtanPanel();
            this.artanPanel4 = new ArtanComponent.ArtanPanel();
            this.k_datagrview_hang_hoa = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.artanPanel1.SuspendLayout();
            this.artanPanel2.SuspendLayout();
            this.artanPanel3.SuspendLayout();
            this.artanPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.k_datagrview_hang_hoa)).BeginInit();
            this.SuspendLayout();
            // 
            // artanPanel1
            // 
            this.artanPanel1.BackColor = System.Drawing.Color.White;
            this.artanPanel1.BorderRadius = 25;
            this.artanPanel1.Controls.Add(this.label3);
            this.artanPanel1.ForeColor = System.Drawing.Color.Black;
            this.artanPanel1.GradientAngle = 90F;
            this.artanPanel1.GradientBottomColor = System.Drawing.Color.WhiteSmoke;
            this.artanPanel1.GradientTopColor = System.Drawing.Color.WhiteSmoke;
            this.artanPanel1.Location = new System.Drawing.Point(11, 12);
            this.artanPanel1.Name = "artanPanel1";
            this.artanPanel1.Size = new System.Drawing.Size(1044, 59);
            this.artanPanel1.TabIndex = 0;
            // 
            // artanPanel2
            // 
            this.artanPanel2.BackColor = System.Drawing.Color.Gainsboro;
            this.artanPanel2.BorderRadius = 0;
            this.artanPanel2.Controls.Add(this.artanPanel3);
            this.artanPanel2.Controls.Add(this.artanPanel1);
            this.artanPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.artanPanel2.ForeColor = System.Drawing.Color.Black;
            this.artanPanel2.GradientAngle = 90F;
            this.artanPanel2.GradientBottomColor = System.Drawing.Color.White;
            this.artanPanel2.GradientTopColor = System.Drawing.Color.White;
            this.artanPanel2.Location = new System.Drawing.Point(0, 0);
            this.artanPanel2.Name = "artanPanel2";
            this.artanPanel2.Size = new System.Drawing.Size(1068, 700);
            this.artanPanel2.TabIndex = 1;
            // 
            // artanPanel3
            // 
            this.artanPanel3.BackColor = System.Drawing.Color.White;
            this.artanPanel3.BorderRadius = 25;
            this.artanPanel3.Controls.Add(this.artanPanel4);
            this.artanPanel3.ForeColor = System.Drawing.Color.Black;
            this.artanPanel3.GradientAngle = 90F;
            this.artanPanel3.GradientBottomColor = System.Drawing.Color.WhiteSmoke;
            this.artanPanel3.GradientTopColor = System.Drawing.Color.Gainsboro;
            this.artanPanel3.Location = new System.Drawing.Point(12, 81);
            this.artanPanel3.Name = "artanPanel3";
            this.artanPanel3.Size = new System.Drawing.Size(1043, 607);
            this.artanPanel3.TabIndex = 96;
            // 
            // artanPanel4
            // 
            this.artanPanel4.BackColor = System.Drawing.Color.White;
            this.artanPanel4.BorderRadius = 25;
            this.artanPanel4.Controls.Add(this.k_datagrview_hang_hoa);
            this.artanPanel4.ForeColor = System.Drawing.Color.Black;
            this.artanPanel4.GradientAngle = 90F;
            this.artanPanel4.GradientBottomColor = System.Drawing.Color.CadetBlue;
            this.artanPanel4.GradientTopColor = System.Drawing.Color.DodgerBlue;
            this.artanPanel4.Location = new System.Drawing.Point(13, 24);
            this.artanPanel4.Name = "artanPanel4";
            this.artanPanel4.Size = new System.Drawing.Size(1015, 567);
            this.artanPanel4.TabIndex = 3;
            // 
            // k_datagrview_hang_hoa
            // 
            this.k_datagrview_hang_hoa.AllowUserToAddRows = false;
            this.k_datagrview_hang_hoa.AllowUserToResizeColumns = false;
            this.k_datagrview_hang_hoa.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            this.k_datagrview_hang_hoa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.k_datagrview_hang_hoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.k_datagrview_hang_hoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.k_datagrview_hang_hoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.k_datagrview_hang_hoa.Location = new System.Drawing.Point(0, 0);
            this.k_datagrview_hang_hoa.Margin = new System.Windows.Forms.Padding(2);
            this.k_datagrview_hang_hoa.Name = "k_datagrview_hang_hoa";
            this.k_datagrview_hang_hoa.RowHeadersVisible = false;
            this.k_datagrview_hang_hoa.RowHeadersWidth = 51;
            this.k_datagrview_hang_hoa.RowTemplate.Height = 24;
            this.k_datagrview_hang_hoa.Size = new System.Drawing.Size(1015, 567);
            this.k_datagrview_hang_hoa.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.k_datagrview_hang_hoa.StateCommon.Background.Color2 = System.Drawing.Color.White;
            this.k_datagrview_hang_hoa.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.k_datagrview_hang_hoa.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.White;
            this.k_datagrview_hang_hoa.StateCommon.DataCell.Border.Color2 = System.Drawing.Color.White;
            this.k_datagrview_hang_hoa.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.k_datagrview_hang_hoa.StateCommon.DataCell.Border.Width = 0;
            this.k_datagrview_hang_hoa.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.Black;
            this.k_datagrview_hang_hoa.StateCommon.DataCell.Content.Color2 = System.Drawing.Color.Black;
            this.k_datagrview_hang_hoa.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.k_datagrview_hang_hoa.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.WhiteSmoke;
            this.k_datagrview_hang_hoa.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.White;
            this.k_datagrview_hang_hoa.StateCommon.HeaderColumn.Border.Color2 = System.Drawing.Color.White;
            this.k_datagrview_hang_hoa.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.k_datagrview_hang_hoa.StateCommon.HeaderColumn.Border.Width = 0;
            this.k_datagrview_hang_hoa.StateCommon.HeaderColumn.Content.MultiLine = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.k_datagrview_hang_hoa.StateCommon.HeaderColumn.Content.Padding = new System.Windows.Forms.Padding(0);
            this.k_datagrview_hang_hoa.StateCommon.HeaderRow.Back.Color1 = System.Drawing.Color.Black;
            this.k_datagrview_hang_hoa.StateCommon.HeaderRow.Content.MultiLine = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.k_datagrview_hang_hoa.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(432, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 29);
            this.label3.TabIndex = 96;
            this.label3.Text = "KHO HÀNG";
            // 
            // KHO_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 700);
            this.Controls.Add(this.artanPanel2);
            this.Name = "KHO_GUI";
            this.Text = "KHO_GUI";
            this.artanPanel1.ResumeLayout(false);
            this.artanPanel1.PerformLayout();
            this.artanPanel2.ResumeLayout(false);
            this.artanPanel3.ResumeLayout(false);
            this.artanPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.k_datagrview_hang_hoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ArtanComponent.ArtanPanel artanPanel1;
        private ArtanComponent.ArtanPanel artanPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView k_datagrview_hang_hoa;
        private ArtanComponent.ArtanPanel artanPanel3;
        private ArtanComponent.ArtanPanel artanPanel4;
        private System.Windows.Forms.Label label3;
    }
}
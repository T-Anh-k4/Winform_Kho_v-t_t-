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
            this.label1 = new System.Windows.Forms.Label();
            this.artanPanel2 = new ArtanComponent.ArtanPanel();
            this.k_datagrview_hang_hoa = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.artanPanel1.SuspendLayout();
            this.artanPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.k_datagrview_hang_hoa)).BeginInit();
            this.SuspendLayout();
            // 
            // artanPanel1
            // 
            this.artanPanel1.BackColor = System.Drawing.Color.White;
            this.artanPanel1.BorderRadius = 0;
            this.artanPanel1.Controls.Add(this.label1);
            this.artanPanel1.ForeColor = System.Drawing.Color.Black;
            this.artanPanel1.GradientAngle = 90F;
            this.artanPanel1.GradientBottomColor = System.Drawing.Color.Transparent;
            this.artanPanel1.GradientTopColor = System.Drawing.Color.Transparent;
            this.artanPanel1.Location = new System.Drawing.Point(11, 7);
            this.artanPanel1.Name = "artanPanel1";
            this.artanPanel1.Size = new System.Drawing.Size(1044, 84);
            this.artanPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(452, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "KHO HÀNG";
            // 
            // artanPanel2
            // 
            this.artanPanel2.BackColor = System.Drawing.Color.Gainsboro;
            this.artanPanel2.BorderRadius = 0;
            this.artanPanel2.Controls.Add(this.k_datagrview_hang_hoa);
            this.artanPanel2.Controls.Add(this.artanPanel1);
            this.artanPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.artanPanel2.ForeColor = System.Drawing.Color.Black;
            this.artanPanel2.GradientAngle = 90F;
            this.artanPanel2.GradientBottomColor = System.Drawing.Color.Gainsboro;
            this.artanPanel2.GradientTopColor = System.Drawing.Color.Gainsboro;
            this.artanPanel2.Location = new System.Drawing.Point(0, 0);
            this.artanPanel2.Name = "artanPanel2";
            this.artanPanel2.Size = new System.Drawing.Size(1068, 700);
            this.artanPanel2.TabIndex = 1;
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
            this.k_datagrview_hang_hoa.Location = new System.Drawing.Point(11, 103);
            this.k_datagrview_hang_hoa.Margin = new System.Windows.Forms.Padding(2);
            this.k_datagrview_hang_hoa.Name = "k_datagrview_hang_hoa";
            this.k_datagrview_hang_hoa.RowHeadersVisible = false;
            this.k_datagrview_hang_hoa.RowHeadersWidth = 51;
            this.k_datagrview_hang_hoa.RowTemplate.Height = 24;
            this.k_datagrview_hang_hoa.Size = new System.Drawing.Size(1044, 595);
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
            ((System.ComponentModel.ISupportInitialize)(this.k_datagrview_hang_hoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ArtanComponent.ArtanPanel artanPanel1;
        private System.Windows.Forms.Label label1;
        private ArtanComponent.ArtanPanel artanPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView k_datagrview_hang_hoa;
    }
}
﻿namespace GUI
{
    partial class KHACHHANG_GUI
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txb_tim_kiem_ncc = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryBtShowCreate_NCC = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kry_Clear = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryBt_Edit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryBt_Add = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryTb_Address = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryTb_Number = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryTb_Name = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryTb_Id = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.createTransition = new System.Windows.Forms.Timer(this.components);
            this.artanPanel1 = new ArtanComponent.ArtanPanel();
            this.panel0_ncc = new ArtanComponent.ArtanPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.kryBt_Next = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.labelSoTrang = new System.Windows.Forms.Label();
            this.kryBtPre = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.artanPanel2 = new ArtanComponent.ArtanPanel();
            this.dataViewKh = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.panel2_ncc = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.artanPanel3 = new ArtanComponent.ArtanPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.artanPanel1.SuspendLayout();
            this.panel0_ncc.SuspendLayout();
            this.panel4.SuspendLayout();
            this.artanPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewKh)).BeginInit();
            this.panel2_ncc.SuspendLayout();
            this.artanPanel3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txb_tim_kiem_ncc
            // 
            this.txb_tim_kiem_ncc.Location = new System.Drawing.Point(662, 41);
            this.txb_tim_kiem_ncc.Margin = new System.Windows.Forms.Padding(4);
            this.txb_tim_kiem_ncc.Name = "txb_tim_kiem_ncc";
            this.txb_tim_kiem_ncc.Size = new System.Drawing.Size(650, 49);
            this.txb_tim_kiem_ncc.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.txb_tim_kiem_ncc.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.txb_tim_kiem_ncc.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txb_tim_kiem_ncc.StateCommon.Border.Rounding = 15;
            this.txb_tim_kiem_ncc.StateCommon.Content.Color1 = System.Drawing.Color.LightGray;
            this.txb_tim_kiem_ncc.TabIndex = 28;
            // 
            // kryBtShowCreate_NCC
            // 
            this.kryBtShowCreate_NCC.Location = new System.Drawing.Point(1936, 25);
            this.kryBtShowCreate_NCC.Margin = new System.Windows.Forms.Padding(6);
            this.kryBtShowCreate_NCC.Name = "kryBtShowCreate_NCC";
            this.kryBtShowCreate_NCC.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kryBtShowCreate_NCC.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryBtShowCreate_NCC.OverrideDefault.Back.ColorAngle = 45F;
            this.kryBtShowCreate_NCC.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kryBtShowCreate_NCC.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryBtShowCreate_NCC.OverrideDefault.Border.ColorAngle = 45F;
            this.kryBtShowCreate_NCC.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryBtShowCreate_NCC.OverrideDefault.Border.Rounding = 20;
            this.kryBtShowCreate_NCC.OverrideDefault.Border.Width = 1;
            this.kryBtShowCreate_NCC.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryBtShowCreate_NCC.Size = new System.Drawing.Size(112, 65);
            this.kryBtShowCreate_NCC.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kryBtShowCreate_NCC.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryBtShowCreate_NCC.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kryBtShowCreate_NCC.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryBtShowCreate_NCC.StateCommon.Border.ColorAngle = 45F;
            this.kryBtShowCreate_NCC.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryBtShowCreate_NCC.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryBtShowCreate_NCC.StateCommon.Border.Rounding = 25;
            this.kryBtShowCreate_NCC.StateCommon.Border.Width = 1;
            this.kryBtShowCreate_NCC.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryBtShowCreate_NCC.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryBtShowCreate_NCC.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryBtShowCreate_NCC.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryBtShowCreate_NCC.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kryBtShowCreate_NCC.StatePressed.Back.ColorAngle = 135F;
            this.kryBtShowCreate_NCC.StatePressed.Border.ColorAngle = 135F;
            this.kryBtShowCreate_NCC.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryBtShowCreate_NCC.StatePressed.Border.Rounding = 25;
            this.kryBtShowCreate_NCC.StatePressed.Border.Width = 1;
            this.kryBtShowCreate_NCC.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kryBtShowCreate_NCC.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryBtShowCreate_NCC.StateTracking.Back.ColorAngle = 45F;
            this.kryBtShowCreate_NCC.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kryBtShowCreate_NCC.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryBtShowCreate_NCC.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryBtShowCreate_NCC.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryBtShowCreate_NCC.StateTracking.Border.Rounding = 25;
            this.kryBtShowCreate_NCC.StateTracking.Border.Width = 1;
            this.kryBtShowCreate_NCC.TabIndex = 27;
            this.kryBtShowCreate_NCC.Values.Text = "+";
            // 
            // kry_Clear
            // 
            this.kry_Clear.Location = new System.Drawing.Point(1760, 152);
            this.kry_Clear.Margin = new System.Windows.Forms.Padding(6);
            this.kry_Clear.Name = "kry_Clear";
            this.kry_Clear.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kry_Clear.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kry_Clear.OverrideDefault.Back.ColorAngle = 45F;
            this.kry_Clear.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kry_Clear.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kry_Clear.OverrideDefault.Border.ColorAngle = 45F;
            this.kry_Clear.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kry_Clear.OverrideDefault.Border.Rounding = 20;
            this.kry_Clear.OverrideDefault.Border.Width = 1;
            this.kry_Clear.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kry_Clear.Size = new System.Drawing.Size(112, 65);
            this.kry_Clear.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kry_Clear.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kry_Clear.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kry_Clear.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kry_Clear.StateCommon.Border.ColorAngle = 45F;
            this.kry_Clear.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kry_Clear.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kry_Clear.StateCommon.Border.Rounding = 25;
            this.kry_Clear.StateCommon.Border.Width = 1;
            this.kry_Clear.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kry_Clear.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kry_Clear.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kry_Clear.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kry_Clear.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kry_Clear.StatePressed.Back.ColorAngle = 135F;
            this.kry_Clear.StatePressed.Border.ColorAngle = 135F;
            this.kry_Clear.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kry_Clear.StatePressed.Border.Rounding = 25;
            this.kry_Clear.StatePressed.Border.Width = 1;
            this.kry_Clear.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kry_Clear.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kry_Clear.StateTracking.Back.ColorAngle = 45F;
            this.kry_Clear.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kry_Clear.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kry_Clear.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kry_Clear.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kry_Clear.StateTracking.Border.Rounding = 25;
            this.kry_Clear.StateTracking.Border.Width = 1;
            this.kry_Clear.TabIndex = 30;
            this.kry_Clear.Values.Text = "Thoát";
            // 
            // kryBt_Edit
            // 
            this.kryBt_Edit.Location = new System.Drawing.Point(132, 152);
            this.kryBt_Edit.Margin = new System.Windows.Forms.Padding(6);
            this.kryBt_Edit.Name = "kryBt_Edit";
            this.kryBt_Edit.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kryBt_Edit.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryBt_Edit.OverrideDefault.Back.ColorAngle = 45F;
            this.kryBt_Edit.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kryBt_Edit.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryBt_Edit.OverrideDefault.Border.ColorAngle = 45F;
            this.kryBt_Edit.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryBt_Edit.OverrideDefault.Border.Rounding = 20;
            this.kryBt_Edit.OverrideDefault.Border.Width = 1;
            this.kryBt_Edit.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryBt_Edit.Size = new System.Drawing.Size(112, 65);
            this.kryBt_Edit.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kryBt_Edit.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryBt_Edit.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kryBt_Edit.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryBt_Edit.StateCommon.Border.ColorAngle = 45F;
            this.kryBt_Edit.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryBt_Edit.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryBt_Edit.StateCommon.Border.Rounding = 25;
            this.kryBt_Edit.StateCommon.Border.Width = 1;
            this.kryBt_Edit.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryBt_Edit.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryBt_Edit.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryBt_Edit.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryBt_Edit.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kryBt_Edit.StatePressed.Back.ColorAngle = 135F;
            this.kryBt_Edit.StatePressed.Border.ColorAngle = 135F;
            this.kryBt_Edit.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryBt_Edit.StatePressed.Border.Rounding = 25;
            this.kryBt_Edit.StatePressed.Border.Width = 1;
            this.kryBt_Edit.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kryBt_Edit.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryBt_Edit.StateTracking.Back.ColorAngle = 45F;
            this.kryBt_Edit.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kryBt_Edit.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryBt_Edit.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryBt_Edit.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryBt_Edit.StateTracking.Border.Rounding = 25;
            this.kryBt_Edit.StateTracking.Border.Width = 1;
            this.kryBt_Edit.TabIndex = 29;
            this.kryBt_Edit.Values.Text = "Sửa";
            // 
            // kryBt_Add
            // 
            this.kryBt_Add.Location = new System.Drawing.Point(132, 152);
            this.kryBt_Add.Margin = new System.Windows.Forms.Padding(6);
            this.kryBt_Add.Name = "kryBt_Add";
            this.kryBt_Add.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kryBt_Add.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryBt_Add.OverrideDefault.Back.ColorAngle = 45F;
            this.kryBt_Add.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kryBt_Add.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryBt_Add.OverrideDefault.Border.ColorAngle = 45F;
            this.kryBt_Add.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryBt_Add.OverrideDefault.Border.Rounding = 20;
            this.kryBt_Add.OverrideDefault.Border.Width = 1;
            this.kryBt_Add.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryBt_Add.Size = new System.Drawing.Size(112, 65);
            this.kryBt_Add.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kryBt_Add.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryBt_Add.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kryBt_Add.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryBt_Add.StateCommon.Border.ColorAngle = 45F;
            this.kryBt_Add.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryBt_Add.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryBt_Add.StateCommon.Border.Rounding = 25;
            this.kryBt_Add.StateCommon.Border.Width = 1;
            this.kryBt_Add.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryBt_Add.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kryBt_Add.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryBt_Add.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryBt_Add.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kryBt_Add.StatePressed.Back.ColorAngle = 135F;
            this.kryBt_Add.StatePressed.Border.ColorAngle = 135F;
            this.kryBt_Add.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryBt_Add.StatePressed.Border.Rounding = 25;
            this.kryBt_Add.StatePressed.Border.Width = 1;
            this.kryBt_Add.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kryBt_Add.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryBt_Add.StateTracking.Back.ColorAngle = 45F;
            this.kryBt_Add.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kryBt_Add.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryBt_Add.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryBt_Add.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryBt_Add.StateTracking.Border.Rounding = 25;
            this.kryBt_Add.StateTracking.Border.Width = 1;
            this.kryBt_Add.TabIndex = 28;
            this.kryBt_Add.Values.Text = "Thêm";
            // 
            // kryTb_Address
            // 
            this.kryTb_Address.Location = new System.Drawing.Point(1512, 65);
            this.kryTb_Address.Margin = new System.Windows.Forms.Padding(4);
            this.kryTb_Address.Name = "kryTb_Address";
            this.kryTb_Address.Size = new System.Drawing.Size(360, 46);
            this.kryTb_Address.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryTb_Address.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.kryTb_Address.StateCommon.Border.Color2 = System.Drawing.Color.Silver;
            this.kryTb_Address.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryTb_Address.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryTb_Address.StateCommon.Border.Rounding = 20;
            this.kryTb_Address.StateCommon.Border.Width = 1;
            this.kryTb_Address.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.kryTb_Address.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.kryTb_Address.TabIndex = 24;
            // 
            // kryTb_Number
            // 
            this.kryTb_Number.Location = new System.Drawing.Point(1062, 65);
            this.kryTb_Number.Margin = new System.Windows.Forms.Padding(4);
            this.kryTb_Number.Name = "kryTb_Number";
            this.kryTb_Number.Size = new System.Drawing.Size(360, 46);
            this.kryTb_Number.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryTb_Number.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.kryTb_Number.StateCommon.Border.Color2 = System.Drawing.Color.Silver;
            this.kryTb_Number.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryTb_Number.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryTb_Number.StateCommon.Border.Rounding = 20;
            this.kryTb_Number.StateCommon.Border.Width = 1;
            this.kryTb_Number.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.kryTb_Number.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.kryTb_Number.TabIndex = 23;
            // 
            // kryTb_Name
            // 
            this.kryTb_Name.Location = new System.Drawing.Point(592, 65);
            this.kryTb_Name.Margin = new System.Windows.Forms.Padding(4);
            this.kryTb_Name.Name = "kryTb_Name";
            this.kryTb_Name.Size = new System.Drawing.Size(360, 46);
            this.kryTb_Name.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryTb_Name.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.kryTb_Name.StateCommon.Border.Color2 = System.Drawing.Color.Silver;
            this.kryTb_Name.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryTb_Name.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryTb_Name.StateCommon.Border.Rounding = 20;
            this.kryTb_Name.StateCommon.Border.Width = 1;
            this.kryTb_Name.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.kryTb_Name.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.kryTb_Name.TabIndex = 22;
            // 
            // kryTb_Id
            // 
            this.kryTb_Id.Location = new System.Drawing.Point(130, 65);
            this.kryTb_Id.Margin = new System.Windows.Forms.Padding(4);
            this.kryTb_Id.Name = "kryTb_Id";
            this.kryTb_Id.Size = new System.Drawing.Size(360, 46);
            this.kryTb_Id.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryTb_Id.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.kryTb_Id.StateCommon.Border.Color2 = System.Drawing.Color.Silver;
            this.kryTb_Id.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryTb_Id.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryTb_Id.StateCommon.Border.Rounding = 20;
            this.kryTb_Id.StateCommon.Border.Width = 1;
            this.kryTb_Id.StateCommon.Content.Color1 = System.Drawing.Color.Red;
            this.kryTb_Id.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.kryTb_Id.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1510, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Địa chỉ";
            // 
            // createTransition
            // 
            this.createTransition.Enabled = true;
            this.createTransition.Interval = 10;
            // 
            // artanPanel1
            // 
            this.artanPanel1.BackColor = System.Drawing.Color.White;
            this.artanPanel1.BorderRadius = 25;
            this.artanPanel1.Controls.Add(this.panel0_ncc);
            this.artanPanel1.ForeColor = System.Drawing.Color.Black;
            this.artanPanel1.GradientAngle = 90F;
            this.artanPanel1.GradientBottomColor = System.Drawing.Color.Gainsboro;
            this.artanPanel1.GradientTopColor = System.Drawing.Color.WhiteSmoke;
            this.artanPanel1.Location = new System.Drawing.Point(33, 187);
            this.artanPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.artanPanel1.Name = "artanPanel1";
            this.artanPanel1.Size = new System.Drawing.Size(2088, 1146);
            this.artanPanel1.TabIndex = 9;
            // 
            // panel0_ncc
            // 
            this.panel0_ncc.BackColor = System.Drawing.Color.White;
            this.panel0_ncc.BorderRadius = 25;
            this.panel0_ncc.Controls.Add(this.panel4);
            this.panel0_ncc.Controls.Add(this.artanPanel2);
            this.panel0_ncc.Controls.Add(this.panel2_ncc);
            this.panel0_ncc.ForeColor = System.Drawing.Color.Black;
            this.panel0_ncc.GradientAngle = 90F;
            this.panel0_ncc.GradientBottomColor = System.Drawing.Color.White;
            this.panel0_ncc.GradientTopColor = System.Drawing.Color.White;
            this.panel0_ncc.Location = new System.Drawing.Point(70, 46);
            this.panel0_ncc.Margin = new System.Windows.Forms.Padding(4);
            this.panel0_ncc.Name = "panel0_ncc";
            this.panel0_ncc.Size = new System.Drawing.Size(1946, 1052);
            this.panel0_ncc.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.kryBt_Next);
            this.panel4.Controls.Add(this.labelSoTrang);
            this.panel4.Controls.Add(this.kryBtPre);
            this.panel4.Location = new System.Drawing.Point(1796, 977);
            this.panel4.Margin = new System.Windows.Forms.Padding(6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(128, 48);
            this.panel4.TabIndex = 6;
            // 
            // kryBt_Next
            // 
            this.kryBt_Next.Location = new System.Drawing.Point(82, 6);
            this.kryBt_Next.Margin = new System.Windows.Forms.Padding(6);
            this.kryBt_Next.Name = "kryBt_Next";
            this.kryBt_Next.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.kryBt_Next.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.kryBt_Next.OverrideDefault.Border.Color1 = System.Drawing.Color.White;
            this.kryBt_Next.OverrideDefault.Border.Color2 = System.Drawing.Color.White;
            this.kryBt_Next.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryBt_Next.OverrideDefault.Border.Rounding = 20;
            this.kryBt_Next.OverrideDefault.Border.Width = 1;
            this.kryBt_Next.Size = new System.Drawing.Size(40, 38);
            this.kryBt_Next.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryBt_Next.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryBt_Next.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterLeft;
            this.kryBt_Next.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.kryBt_Next.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.kryBt_Next.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryBt_Next.StateCommon.Border.Rounding = 20;
            this.kryBt_Next.StateCommon.Border.Width = 1;
            this.kryBt_Next.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryBt_Next.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kryBt_Next.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryBt_Next.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterRight;
            this.kryBt_Next.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryBt_Next.StatePressed.Border.Rounding = 20;
            this.kryBt_Next.StatePressed.Border.Width = 0;
            this.kryBt_Next.TabIndex = 6;
            this.kryBt_Next.Values.Text = "kryptonButton2";
            // 
            // labelSoTrang
            // 
            this.labelSoTrang.AutoSize = true;
            this.labelSoTrang.Location = new System.Drawing.Point(46, 12);
            this.labelSoTrang.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelSoTrang.Name = "labelSoTrang";
            this.labelSoTrang.Size = new System.Drawing.Size(24, 25);
            this.labelSoTrang.TabIndex = 5;
            this.labelSoTrang.Text = "1";
            // 
            // kryBtPre
            // 
            this.kryBtPre.Location = new System.Drawing.Point(0, 6);
            this.kryBtPre.Margin = new System.Windows.Forms.Padding(6);
            this.kryBtPre.Name = "kryBtPre";
            this.kryBtPre.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.kryBtPre.OverrideDefault.Back.Color2 = System.Drawing.Color.White;
            this.kryBtPre.OverrideDefault.Border.Color1 = System.Drawing.Color.White;
            this.kryBtPre.OverrideDefault.Border.Color2 = System.Drawing.Color.White;
            this.kryBtPre.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryBtPre.OverrideDefault.Border.Rounding = 20;
            this.kryBtPre.OverrideDefault.Border.Width = 1;
            this.kryBtPre.Size = new System.Drawing.Size(40, 38);
            this.kryBtPre.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryBtPre.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryBtPre.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterRight;
            this.kryBtPre.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.kryBtPre.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.kryBtPre.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryBtPre.StateCommon.Border.Rounding = 20;
            this.kryBtPre.StateCommon.Border.Width = 1;
            this.kryBtPre.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryBtPre.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.kryBtPre.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryBtPre.StatePressed.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterRight;
            this.kryBtPre.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryBtPre.StatePressed.Border.Rounding = 20;
            this.kryBtPre.StatePressed.Border.Width = 0;
            this.kryBtPre.TabIndex = 3;
            this.kryBtPre.Values.Text = "kryptonButton1";
            // 
            // artanPanel2
            // 
            this.artanPanel2.BackColor = System.Drawing.Color.White;
            this.artanPanel2.BorderRadius = 25;
            this.artanPanel2.Controls.Add(this.dataViewKh);
            this.artanPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.artanPanel2.ForeColor = System.Drawing.Color.Black;
            this.artanPanel2.GradientAngle = 90F;
            this.artanPanel2.GradientBottomColor = System.Drawing.Color.White;
            this.artanPanel2.GradientTopColor = System.Drawing.Color.White;
            this.artanPanel2.Location = new System.Drawing.Point(0, 231);
            this.artanPanel2.Margin = new System.Windows.Forms.Padding(6);
            this.artanPanel2.Name = "artanPanel2";
            this.artanPanel2.Size = new System.Drawing.Size(1946, 579);
            this.artanPanel2.TabIndex = 4;
            // 
            // dataViewKh
            // 
            this.dataViewKh.AllowUserToAddRows = false;
            this.dataViewKh.AllowUserToResizeColumns = false;
            this.dataViewKh.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            this.dataViewKh.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataViewKh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataViewKh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewKh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataViewKh.Location = new System.Drawing.Point(0, 0);
            this.dataViewKh.Margin = new System.Windows.Forms.Padding(4);
            this.dataViewKh.Name = "dataViewKh";
            this.dataViewKh.RowHeadersVisible = false;
            this.dataViewKh.RowHeadersWidth = 51;
            this.dataViewKh.RowTemplate.Height = 24;
            this.dataViewKh.Size = new System.Drawing.Size(1946, 579);
            this.dataViewKh.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dataViewKh.StateCommon.Background.Color2 = System.Drawing.Color.White;
            this.dataViewKh.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dataViewKh.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.White;
            this.dataViewKh.StateCommon.DataCell.Border.Color2 = System.Drawing.Color.White;
            this.dataViewKh.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dataViewKh.StateCommon.DataCell.Border.Width = 0;
            this.dataViewKh.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.Black;
            this.dataViewKh.StateCommon.DataCell.Content.Color2 = System.Drawing.Color.Black;
            this.dataViewKh.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.dataViewKh.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.WhiteSmoke;
            this.dataViewKh.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.White;
            this.dataViewKh.StateCommon.HeaderColumn.Border.Color2 = System.Drawing.Color.White;
            this.dataViewKh.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dataViewKh.StateCommon.HeaderColumn.Border.Width = 0;
            this.dataViewKh.StateCommon.HeaderColumn.Content.MultiLine = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.dataViewKh.StateCommon.HeaderColumn.Content.Padding = new System.Windows.Forms.Padding(0);
            this.dataViewKh.StateCommon.HeaderRow.Back.Color1 = System.Drawing.Color.Black;
            this.dataViewKh.StateCommon.HeaderRow.Content.MultiLine = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.dataViewKh.TabIndex = 0;
            // 
            // panel2_ncc
            // 
            this.panel2_ncc.Controls.Add(this.kry_Clear);
            this.panel2_ncc.Controls.Add(this.kryBt_Edit);
            this.panel2_ncc.Controls.Add(this.kryBt_Add);
            this.panel2_ncc.Controls.Add(this.kryTb_Address);
            this.panel2_ncc.Controls.Add(this.kryTb_Number);
            this.panel2_ncc.Controls.Add(this.kryTb_Name);
            this.panel2_ncc.Controls.Add(this.kryTb_Id);
            this.panel2_ncc.Controls.Add(this.label4);
            this.panel2_ncc.Controls.Add(this.label3);
            this.panel2_ncc.Controls.Add(this.label2);
            this.panel2_ncc.Controls.Add(this.label1);
            this.panel2_ncc.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2_ncc.Location = new System.Drawing.Point(0, 0);
            this.panel2_ncc.Margin = new System.Windows.Forms.Padding(4);
            this.panel2_ncc.Name = "panel2_ncc";
            this.panel2_ncc.Size = new System.Drawing.Size(1946, 231);
            this.panel2_ncc.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1058, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Số điện thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(588, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(334, 50);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tên khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 50);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã khách hàng";
            // 
            // artanPanel3
            // 
            this.artanPanel3.BackColor = System.Drawing.Color.White;
            this.artanPanel3.BorderRadius = 25;
            this.artanPanel3.Controls.Add(this.panel3);
            this.artanPanel3.ForeColor = System.Drawing.Color.Black;
            this.artanPanel3.GradientAngle = 90F;
            this.artanPanel3.GradientBottomColor = System.Drawing.Color.CadetBlue;
            this.artanPanel3.GradientTopColor = System.Drawing.Color.DodgerBlue;
            this.artanPanel3.Location = new System.Drawing.Point(33, 41);
            this.artanPanel3.Margin = new System.Windows.Forms.Padding(6);
            this.artanPanel3.Name = "artanPanel3";
            this.artanPanel3.Size = new System.Drawing.Size(2088, 121);
            this.artanPanel3.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.kryptonLabel1);
            this.panel3.Controls.Add(this.txb_tim_kiem_ncc);
            this.panel3.Controls.Add(this.kryBtShowCreate_NCC);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2088, 121);
            this.panel3.TabIndex = 5;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(32, 38);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(6);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(318, 50);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.Gray;
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 6;
            this.kryptonLabel1.Values.Text = "Khách hàng (99)";
            // 
            // KHACHHANG_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2136, 1346);
            this.Controls.Add(this.artanPanel1);
            this.Controls.Add(this.artanPanel3);
            this.Name = "KHACHHANG_GUI";
            this.Text = "KHACHHANG_GUI";
            this.artanPanel1.ResumeLayout(false);
            this.panel0_ncc.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.artanPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataViewKh)).EndInit();
            this.panel2_ncc.ResumeLayout(false);
            this.panel2_ncc.PerformLayout();
            this.artanPanel3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txb_tim_kiem_ncc;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryBtShowCreate_NCC;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kry_Clear;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryBt_Edit;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryBt_Add;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryTb_Address;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryTb_Number;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryTb_Name;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryTb_Id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer createTransition;
        private ArtanComponent.ArtanPanel artanPanel1;
        private ArtanComponent.ArtanPanel panel0_ncc;
        private System.Windows.Forms.Panel panel4;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryBt_Next;
        private System.Windows.Forms.Label labelSoTrang;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryBtPre;
        private ArtanComponent.ArtanPanel artanPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dataViewKh;
        private System.Windows.Forms.Panel panel2_ncc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ArtanComponent.ArtanPanel artanPanel3;
        private System.Windows.Forms.Panel panel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
    }
}
using System.Collections.Generic;
using System.Windows.Forms;

namespace PokemonTypeAnalyzer
{
    partial class MainFrame
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrame));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgEA = new System.Windows.Forms.DataGridView();
            this.EAImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.EAText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EAOwner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDark = new System.Windows.Forms.Button();
            this.btnElectric = new System.Windows.Forms.Button();
            this.btnFighting = new System.Windows.Forms.Button();
            this.btnFlying = new System.Windows.Forms.Button();
            this.btnGrass = new System.Windows.Forms.Button();
            this.btnIce = new System.Windows.Forms.Button();
            this.btnPoison = new System.Windows.Forms.Button();
            this.btnRock = new System.Windows.Forms.Button();
            this.btnWater = new System.Windows.Forms.Button();
            this.btnBug = new System.Windows.Forms.Button();
            this.btnDragon = new System.Windows.Forms.Button();
            this.btnFairy = new System.Windows.Forms.Button();
            this.btnFire = new System.Windows.Forms.Button();
            this.btnGhost = new System.Windows.Forms.Button();
            this.btnGround = new System.Windows.Forms.Button();
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnPsychic = new System.Windows.Forms.Button();
            this.btnSteel = new System.Windows.Forms.Button();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgNEA = new System.Windows.Forms.DataGridView();
            this.NEAImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.NEAOwner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NEAText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgWT = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgRT = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonFont = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgEA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgNEA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgWT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRT)).BeginInit();
            this.SuspendLayout();
            // 
            // dgEA
            // 
            this.dgEA.AllowUserToAddRows = false;
            this.dgEA.AllowUserToDeleteRows = false;
            this.dgEA.AllowUserToResizeColumns = false;
            this.dgEA.AllowUserToResizeRows = false;
            this.dgEA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgEA.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgEA.BackgroundColor = System.Drawing.Color.Black;
            this.dgEA.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgEA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgEA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEA.ColumnHeadersVisible = false;
            this.dgEA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EAImage,
            this.EAText,
            this.EAOwner});
            this.dgEA.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgEA.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgEA.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgEA.Location = new System.Drawing.Point(290, 130);
            this.dgEA.Name = "dgEA";
            this.dgEA.ReadOnly = true;
            this.dgEA.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgEA.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgEA.RowHeadersVisible = false;
            this.dgEA.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgEA.RowTemplate.ReadOnly = true;
            this.dgEA.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgEA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgEA.ShowCellToolTips = false;
            this.dgEA.ShowEditingIcon = false;
            this.dgEA.Size = new System.Drawing.Size(175, 174);
            this.dgEA.TabIndex = 1;
            this.dgEA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // EAImage
            // 
            this.EAImage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle2.NullValue")));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.EAImage.DefaultCellStyle = dataGridViewCellStyle2;
            this.EAImage.HeaderText = "";
            this.EAImage.Name = "EAImage";
            this.EAImage.ReadOnly = true;
            this.EAImage.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.EAImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.EAImage.Width = 99;
            // 
            // EAText
            // 
            this.EAText.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Adobe Gothic Std B", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.EAText.DefaultCellStyle = dataGridViewCellStyle3;
            this.EAText.HeaderText = "";
            this.EAText.Name = "EAText";
            this.EAText.ReadOnly = true;
            this.EAText.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.EAText.Width = 98;
            // 
            // EAOwner
            // 
            this.EAOwner.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Adobe Gothic Std B", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.EAOwner.DefaultCellStyle = dataGridViewCellStyle4;
            this.EAOwner.HeaderText = "";
            this.EAOwner.Name = "EAOwner";
            this.EAOwner.ReadOnly = true;
            this.EAOwner.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Gothic Std B", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "Pick One Or Two Types";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnDark
            // 
            this.btnDark.BackgroundImage = global::PokemonTypeAnalyzer.Properties.Resources.Dark;
            this.btnDark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDark.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnDark.Location = new System.Drawing.Point(125, 65);
            this.btnDark.Name = "btnDark";
            this.btnDark.Size = new System.Drawing.Size(107, 44);
            this.btnDark.TabIndex = 27;
            this.btnDark.UseVisualStyleBackColor = true;
            this.btnDark.Click += new System.EventHandler(this.btnDark_Click);
            // 
            // btnElectric
            // 
            this.btnElectric.BackgroundImage = global::PokemonTypeAnalyzer.Properties.Resources.Electric;
            this.btnElectric.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnElectric.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnElectric.Location = new System.Drawing.Point(125, 115);
            this.btnElectric.Name = "btnElectric";
            this.btnElectric.Size = new System.Drawing.Size(107, 44);
            this.btnElectric.TabIndex = 26;
            this.btnElectric.UseVisualStyleBackColor = true;
            this.btnElectric.Click += new System.EventHandler(this.btnElectric_Click);
            // 
            // btnFighting
            // 
            this.btnFighting.BackgroundImage = global::PokemonTypeAnalyzer.Properties.Resources.Fighting;
            this.btnFighting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFighting.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnFighting.Location = new System.Drawing.Point(125, 165);
            this.btnFighting.Name = "btnFighting";
            this.btnFighting.Size = new System.Drawing.Size(107, 44);
            this.btnFighting.TabIndex = 25;
            this.btnFighting.UseVisualStyleBackColor = true;
            this.btnFighting.Click += new System.EventHandler(this.btnFighting_Click);
            // 
            // btnFlying
            // 
            this.btnFlying.BackgroundImage = global::PokemonTypeAnalyzer.Properties.Resources.Flying;
            this.btnFlying.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFlying.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnFlying.Location = new System.Drawing.Point(125, 215);
            this.btnFlying.Name = "btnFlying";
            this.btnFlying.Size = new System.Drawing.Size(107, 44);
            this.btnFlying.TabIndex = 24;
            this.btnFlying.UseVisualStyleBackColor = true;
            this.btnFlying.Click += new System.EventHandler(this.btnFlying_Click);
            // 
            // btnGrass
            // 
            this.btnGrass.BackgroundImage = global::PokemonTypeAnalyzer.Properties.Resources.Grass;
            this.btnGrass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGrass.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnGrass.Location = new System.Drawing.Point(125, 265);
            this.btnGrass.Name = "btnGrass";
            this.btnGrass.Size = new System.Drawing.Size(107, 44);
            this.btnGrass.TabIndex = 23;
            this.btnGrass.UseVisualStyleBackColor = true;
            this.btnGrass.Click += new System.EventHandler(this.btnGrass_Click);
            // 
            // btnIce
            // 
            this.btnIce.BackgroundImage = global::PokemonTypeAnalyzer.Properties.Resources.Ice;
            this.btnIce.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIce.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnIce.Location = new System.Drawing.Point(125, 315);
            this.btnIce.Name = "btnIce";
            this.btnIce.Size = new System.Drawing.Size(107, 44);
            this.btnIce.TabIndex = 22;
            this.btnIce.UseVisualStyleBackColor = true;
            this.btnIce.Click += new System.EventHandler(this.btnIce_Click);
            // 
            // btnPoison
            // 
            this.btnPoison.BackgroundImage = global::PokemonTypeAnalyzer.Properties.Resources.Poison;
            this.btnPoison.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPoison.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnPoison.Location = new System.Drawing.Point(125, 365);
            this.btnPoison.Name = "btnPoison";
            this.btnPoison.Size = new System.Drawing.Size(107, 44);
            this.btnPoison.TabIndex = 21;
            this.btnPoison.UseVisualStyleBackColor = true;
            this.btnPoison.Click += new System.EventHandler(this.btnPoison_Click);
            // 
            // btnRock
            // 
            this.btnRock.BackgroundImage = global::PokemonTypeAnalyzer.Properties.Resources.Rock;
            this.btnRock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRock.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnRock.Location = new System.Drawing.Point(125, 415);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(107, 44);
            this.btnRock.TabIndex = 20;
            this.btnRock.UseVisualStyleBackColor = true;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // btnWater
            // 
            this.btnWater.BackgroundImage = global::PokemonTypeAnalyzer.Properties.Resources.Water;
            this.btnWater.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnWater.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnWater.Location = new System.Drawing.Point(125, 465);
            this.btnWater.Name = "btnWater";
            this.btnWater.Size = new System.Drawing.Size(107, 44);
            this.btnWater.TabIndex = 19;
            this.btnWater.UseVisualStyleBackColor = true;
            this.btnWater.Click += new System.EventHandler(this.btnWater_Click);
            // 
            // btnBug
            // 
            this.btnBug.BackgroundImage = global::PokemonTypeAnalyzer.Properties.Resources.Bug;
            this.btnBug.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBug.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnBug.Location = new System.Drawing.Point(12, 65);
            this.btnBug.Name = "btnBug";
            this.btnBug.Size = new System.Drawing.Size(107, 44);
            this.btnBug.TabIndex = 18;
            this.btnBug.UseVisualStyleBackColor = true;
            this.btnBug.Click += new System.EventHandler(this.btnBug_Click);
            // 
            // btnDragon
            // 
            this.btnDragon.BackgroundImage = global::PokemonTypeAnalyzer.Properties.Resources.Dragon;
            this.btnDragon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDragon.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnDragon.Location = new System.Drawing.Point(12, 115);
            this.btnDragon.Name = "btnDragon";
            this.btnDragon.Size = new System.Drawing.Size(107, 44);
            this.btnDragon.TabIndex = 17;
            this.btnDragon.UseVisualStyleBackColor = true;
            this.btnDragon.Click += new System.EventHandler(this.btnDragon_Click);
            // 
            // btnFairy
            // 
            this.btnFairy.BackgroundImage = global::PokemonTypeAnalyzer.Properties.Resources.Fairy;
            this.btnFairy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFairy.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnFairy.Location = new System.Drawing.Point(12, 165);
            this.btnFairy.Name = "btnFairy";
            this.btnFairy.Size = new System.Drawing.Size(107, 44);
            this.btnFairy.TabIndex = 16;
            this.btnFairy.UseVisualStyleBackColor = true;
            this.btnFairy.Click += new System.EventHandler(this.btnFairy_Click);
            // 
            // btnFire
            // 
            this.btnFire.BackgroundImage = global::PokemonTypeAnalyzer.Properties.Resources.Fire;
            this.btnFire.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFire.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnFire.Location = new System.Drawing.Point(12, 215);
            this.btnFire.Name = "btnFire";
            this.btnFire.Size = new System.Drawing.Size(107, 44);
            this.btnFire.TabIndex = 15;
            this.btnFire.UseVisualStyleBackColor = true;
            this.btnFire.Click += new System.EventHandler(this.btnFire_Click);
            // 
            // btnGhost
            // 
            this.btnGhost.BackgroundImage = global::PokemonTypeAnalyzer.Properties.Resources.Ghost;
            this.btnGhost.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGhost.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnGhost.Location = new System.Drawing.Point(12, 265);
            this.btnGhost.Name = "btnGhost";
            this.btnGhost.Size = new System.Drawing.Size(107, 44);
            this.btnGhost.TabIndex = 14;
            this.btnGhost.UseVisualStyleBackColor = true;
            this.btnGhost.Click += new System.EventHandler(this.btnGhost_Click);
            // 
            // btnGround
            // 
            this.btnGround.BackgroundImage = global::PokemonTypeAnalyzer.Properties.Resources.Ground;
            this.btnGround.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGround.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnGround.Location = new System.Drawing.Point(12, 315);
            this.btnGround.Name = "btnGround";
            this.btnGround.Size = new System.Drawing.Size(107, 44);
            this.btnGround.TabIndex = 13;
            this.btnGround.UseVisualStyleBackColor = true;
            this.btnGround.Click += new System.EventHandler(this.btnGround_Click);
            // 
            // btnNormal
            // 
            this.btnNormal.BackgroundImage = global::PokemonTypeAnalyzer.Properties.Resources.Normal;
            this.btnNormal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNormal.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnNormal.Location = new System.Drawing.Point(12, 365);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(107, 44);
            this.btnNormal.TabIndex = 9;
            this.btnNormal.UseVisualStyleBackColor = true;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // btnPsychic
            // 
            this.btnPsychic.BackgroundImage = global::PokemonTypeAnalyzer.Properties.Resources.Psychic;
            this.btnPsychic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPsychic.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnPsychic.Location = new System.Drawing.Point(12, 415);
            this.btnPsychic.Name = "btnPsychic";
            this.btnPsychic.Size = new System.Drawing.Size(107, 44);
            this.btnPsychic.TabIndex = 8;
            this.btnPsychic.UseVisualStyleBackColor = true;
            this.btnPsychic.Click += new System.EventHandler(this.btnPsychic_Click);
            // 
            // btnSteel
            // 
            this.btnSteel.BackgroundImage = global::PokemonTypeAnalyzer.Properties.Resources.Steel;
            this.btnSteel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSteel.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnSteel.Location = new System.Drawing.Point(12, 465);
            this.btnSteel.Name = "btnSteel";
            this.btnSteel.Size = new System.Drawing.Size(107, 44);
            this.btnSteel.TabIndex = 7;
            this.btnSteel.UseVisualStyleBackColor = true;
            this.btnSteel.Click += new System.EventHandler(this.btnSteel_Click);
            // 
            // pb2
            // 
            this.pb2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pb2.Location = new System.Drawing.Point(482, 24);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(177, 74);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb2.TabIndex = 6;
            this.pb2.TabStop = false;
            this.pb2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pb1
            // 
            this.pb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pb1.Location = new System.Drawing.Point(288, 24);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(177, 74);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 5;
            this.pb1.TabStop = false;
            this.pb1.Click += new System.EventHandler(this.pbOne_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Adobe Gothic Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(287, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 24);
            this.label2.TabIndex = 29;
            this.label2.Text = "Effective Against";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Adobe Gothic Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(478, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 24);
            this.label3.TabIndex = 30;
            this.label3.Text = "Not Effective Against";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Adobe Gothic Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(287, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 24);
            this.label4.TabIndex = 31;
            this.label4.Text = "Weak To";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Adobe Gothic Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(478, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 24);
            this.label5.TabIndex = 32;
            this.label5.Text = "Resistant To";
            // 
            // dgNEA
            // 
            this.dgNEA.AllowUserToAddRows = false;
            this.dgNEA.AllowUserToDeleteRows = false;
            this.dgNEA.AllowUserToResizeColumns = false;
            this.dgNEA.AllowUserToResizeRows = false;
            this.dgNEA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgNEA.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgNEA.BackgroundColor = System.Drawing.Color.Black;
            this.dgNEA.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgNEA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgNEA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNEA.ColumnHeadersVisible = false;
            this.dgNEA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NEAImage,
            this.NEAOwner,
            this.NEAText});
            this.dgNEA.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgNEA.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgNEA.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgNEA.Location = new System.Drawing.Point(481, 130);
            this.dgNEA.Name = "dgNEA";
            this.dgNEA.ReadOnly = true;
            this.dgNEA.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgNEA.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgNEA.RowHeadersVisible = false;
            this.dgNEA.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgNEA.RowTemplate.ReadOnly = true;
            this.dgNEA.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgNEA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgNEA.ShowCellToolTips = false;
            this.dgNEA.ShowEditingIcon = false;
            this.dgNEA.Size = new System.Drawing.Size(175, 174);
            this.dgNEA.TabIndex = 33;
            // 
            // NEAImage
            // 
            this.NEAImage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle8.NullValue")));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.NEAImage.DefaultCellStyle = dataGridViewCellStyle8;
            this.NEAImage.HeaderText = "";
            this.NEAImage.Name = "NEAImage";
            this.NEAImage.ReadOnly = true;
            this.NEAImage.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NEAImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.NEAImage.Width = 99;
            // 
            // NEAOwner
            // 
            this.NEAOwner.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Adobe Gothic Std B", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.NEAOwner.DefaultCellStyle = dataGridViewCellStyle9;
            this.NEAOwner.HeaderText = "";
            this.NEAOwner.Name = "NEAOwner";
            this.NEAOwner.ReadOnly = true;
            this.NEAOwner.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // NEAText
            // 
            this.NEAText.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Adobe Gothic Std B", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.NEAText.DefaultCellStyle = dataGridViewCellStyle10;
            this.NEAText.HeaderText = "";
            this.NEAText.Name = "NEAText";
            this.NEAText.ReadOnly = true;
            this.NEAText.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NEAText.Width = 98;
            // 
            // dgWT
            // 
            this.dgWT.AllowUserToAddRows = false;
            this.dgWT.AllowUserToDeleteRows = false;
            this.dgWT.AllowUserToResizeColumns = false;
            this.dgWT.AllowUserToResizeRows = false;
            this.dgWT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgWT.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgWT.BackgroundColor = System.Drawing.Color.Black;
            this.dgWT.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgWT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgWT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgWT.ColumnHeadersVisible = false;
            this.dgWT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewImageColumn2,
            this.dataGridViewTextBoxColumn2});
            this.dgWT.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgWT.DefaultCellStyle = dataGridViewCellStyle16;
            this.dgWT.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgWT.Location = new System.Drawing.Point(290, 334);
            this.dgWT.Name = "dgWT";
            this.dgWT.ReadOnly = true;
            this.dgWT.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgWT.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgWT.RowHeadersVisible = false;
            this.dgWT.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgWT.RowTemplate.ReadOnly = true;
            this.dgWT.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgWT.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgWT.ShowCellToolTips = false;
            this.dgWT.ShowEditingIcon = false;
            this.dgWT.Size = new System.Drawing.Size(175, 174);
            this.dgWT.TabIndex = 34;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle14.NullValue")));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewImageColumn2.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn2.Width = 99;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Adobe Gothic Std B", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewTextBoxColumn2.HeaderText = "";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn2.Width = 98;
            // 
            // dgRT
            // 
            this.dgRT.AllowUserToAddRows = false;
            this.dgRT.AllowUserToDeleteRows = false;
            this.dgRT.AllowUserToResizeColumns = false;
            this.dgRT.AllowUserToResizeRows = false;
            this.dgRT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgRT.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgRT.BackgroundColor = System.Drawing.Color.Black;
            this.dgRT.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgRT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgRT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRT.ColumnHeadersVisible = false;
            this.dgRT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewImageColumn3,
            this.dataGridViewTextBoxColumn3});
            this.dgRT.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgRT.DefaultCellStyle = dataGridViewCellStyle21;
            this.dgRT.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgRT.Location = new System.Drawing.Point(481, 334);
            this.dgRT.Name = "dgRT";
            this.dgRT.ReadOnly = true;
            this.dgRT.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgRT.RowHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgRT.RowHeadersVisible = false;
            this.dgRT.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgRT.RowTemplate.ReadOnly = true;
            this.dgRT.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgRT.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgRT.ShowCellToolTips = false;
            this.dgRT.ShowEditingIcon = false;
            this.dgRT.Size = new System.Drawing.Size(175, 174);
            this.dgRT.TabIndex = 35;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle19.NullValue")));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewImageColumn3.DefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.ReadOnly = true;
            this.dataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn3.Width = 99;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Adobe Gothic Std B", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridViewTextBoxColumn3.HeaderText = "";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn3.Width = 98;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Adobe Gothic Std B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(355, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 14);
            this.label6.TabIndex = 36;
            this.label6.Text = "Left (L)";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Adobe Gothic Std B", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(549, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 14);
            this.label7.TabIndex = 37;
            this.label7.Text = "Right (R)";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // buttonFont
            // 
            this.buttonFont.BackColor = System.Drawing.Color.Black;
            this.buttonFont.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonFont.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFont.ForeColor = System.Drawing.Color.Silver;
            this.buttonFont.Location = new System.Drawing.Point(17, 7);
            this.buttonFont.Name = "buttonFont";
            this.buttonFont.Size = new System.Drawing.Size(53, 23);
            this.buttonFont.TabIndex = 38;
            this.buttonFont.Text = "Font";
            this.buttonFont.UseVisualStyleBackColor = false;
            this.buttonFont.Click += new System.EventHandler(this.buttonFont_Click);
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(684, 521);
            this.Controls.Add(this.buttonFont);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgRT);
            this.Controls.Add(this.dgWT);
            this.Controls.Add(this.dgNEA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDark);
            this.Controls.Add(this.btnElectric);
            this.Controls.Add(this.btnFighting);
            this.Controls.Add(this.btnFlying);
            this.Controls.Add(this.btnGrass);
            this.Controls.Add(this.btnIce);
            this.Controls.Add(this.btnPoison);
            this.Controls.Add(this.btnRock);
            this.Controls.Add(this.btnWater);
            this.Controls.Add(this.btnBug);
            this.Controls.Add(this.btnDragon);
            this.Controls.Add(this.btnFairy);
            this.Controls.Add(this.btnFire);
            this.Controls.Add(this.btnGhost);
            this.Controls.Add(this.btnGround);
            this.Controls.Add(this.btnNormal);
            this.Controls.Add(this.btnPsychic);
            this.Controls.Add(this.btnSteel);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.dgEA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainFrame";
            this.Text = "Marko\'s Pokèmon Type Analyzer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgNEA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgWT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgEA;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.Button btnSteel;
        private System.Windows.Forms.Button btnPsychic;
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.Button btnFire;
        private System.Windows.Forms.Button btnGhost;
        private System.Windows.Forms.Button btnGround;
        private System.Windows.Forms.Button btnFairy;
        private System.Windows.Forms.Button btnDragon;
        private System.Windows.Forms.Button btnBug;
        private System.Windows.Forms.Button btnDark;
        private System.Windows.Forms.Button btnElectric;
        private System.Windows.Forms.Button btnFighting;
        private System.Windows.Forms.Button btnFlying;
        private System.Windows.Forms.Button btnGrass;
        private System.Windows.Forms.Button btnIce;
        private System.Windows.Forms.Button btnPoison;
        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnWater;
        private System.Windows.Forms.Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridView dgNEA;
        private DataGridView dgWT;
        private DataGridView dgRT;
        private DataGridViewImageColumn dataGridViewImageColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewImageColumn dataGridViewImageColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewImageColumn NEAImage;
        private DataGridViewTextBoxColumn NEAOwner;
        private DataGridViewTextBoxColumn NEAText;
        private DataGridViewImageColumn EAImage;
        private DataGridViewTextBoxColumn EAText;
        private DataGridViewTextBoxColumn EAOwner;
        private Label label6;
        private Label label7;
        private Button buttonFont;
        private TextBox textBox;
        private IList<string> fontNames;
        private ComboBox comboBox;
        private Form prompt;
        private string path;
    }
}


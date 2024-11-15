namespace Simple_Calculator
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
            this.btnexit = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btndiv = new Guna.UI2.WinForms.Guna2Button();
            this.btnmul = new Guna.UI2.WinForms.Guna2Button();
            this.btnmin = new Guna.UI2.WinForms.Guna2Button();
            this.btnadd = new Guna.UI2.WinForms.Guna2Button();
            this.btnthree = new Guna.UI2.WinForms.Guna2Button();
            this.btnsix = new Guna.UI2.WinForms.Guna2Button();
            this.btnnine = new Guna.UI2.WinForms.Guna2Button();
            this.btnmod = new Guna.UI2.WinForms.Guna2Button();
            this.btntwo = new Guna.UI2.WinForms.Guna2Button();
            this.btnfive = new Guna.UI2.WinForms.Guna2Button();
            this.btneight = new Guna.UI2.WinForms.Guna2Button();
            this.btnone = new Guna.UI2.WinForms.Guna2Button();
            this.btnfour = new Guna.UI2.WinForms.Guna2Button();
            this.btnseven = new Guna.UI2.WinForms.Guna2Button();
            this.btnclear = new Guna.UI2.WinForms.Guna2Button();
            this.btnzero = new Guna.UI2.WinForms.Guna2Button();
            this.btndot = new Guna.UI2.WinForms.Guna2Button();
            this.btnequal = new Guna.UI2.WinForms.Guna2Button();
            this.textstore = new Guna.UI2.WinForms.Guna2TextBox();
            this.textresult = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnexit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnexit
            // 
            this.btnexit.Image = ((System.Drawing.Image)(resources.GetObject("btnexit.Image")));
            this.btnexit.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Horizontal;
            this.btnexit.ImageRotate = 0F;
            this.btnexit.Location = new System.Drawing.Point(313, -1);
            this.btnexit.Name = "btnexit";
            this.btnexit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnexit.Size = new System.Drawing.Size(59, 58);
            this.btnexit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnexit.TabIndex = 0;
            this.btnexit.TabStop = false;
            this.btnexit.Click += new System.EventHandler(this.guna2CirclePictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Calculator";
            // 
            // btndiv
            // 
            this.btndiv.BackColor = System.Drawing.Color.Transparent;
            this.btndiv.BorderRadius = 15;
            this.btndiv.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btndiv.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btndiv.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btndiv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btndiv.FillColor = System.Drawing.Color.Black;
            this.btndiv.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndiv.ForeColor = System.Drawing.Color.Cyan;
            this.btndiv.HoverState.BorderColor = System.Drawing.Color.Cyan;
            this.btndiv.HoverState.FillColor = System.Drawing.Color.Cyan;
            this.btndiv.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btndiv.Location = new System.Drawing.Point(309, 227);
            this.btndiv.Name = "btndiv";
            this.btndiv.ShadowDecoration.BorderRadius = 15;
            this.btndiv.ShadowDecoration.Color = System.Drawing.Color.Cyan;
            this.btndiv.ShadowDecoration.Enabled = true;
            this.btndiv.Size = new System.Drawing.Size(63, 45);
            this.btndiv.TabIndex = 2;
            this.btndiv.Text = "/";
            this.btndiv.Click += new System.EventHandler(this.btndiv_Click);
            // 
            // btnmul
            // 
            this.btnmul.BackColor = System.Drawing.Color.Transparent;
            this.btnmul.BorderRadius = 15;
            this.btnmul.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnmul.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnmul.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnmul.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnmul.FillColor = System.Drawing.Color.Black;
            this.btnmul.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmul.ForeColor = System.Drawing.Color.Cyan;
            this.btnmul.HoverState.BorderColor = System.Drawing.Color.Cyan;
            this.btnmul.HoverState.FillColor = System.Drawing.Color.Cyan;
            this.btnmul.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnmul.Location = new System.Drawing.Point(309, 295);
            this.btnmul.Name = "btnmul";
            this.btnmul.ShadowDecoration.BorderRadius = 15;
            this.btnmul.ShadowDecoration.Color = System.Drawing.Color.Cyan;
            this.btnmul.ShadowDecoration.Enabled = true;
            this.btnmul.Size = new System.Drawing.Size(63, 45);
            this.btnmul.TabIndex = 3;
            this.btnmul.Text = "X";
            this.btnmul.Click += new System.EventHandler(this.btnmul_Click);
            // 
            // btnmin
            // 
            this.btnmin.BackColor = System.Drawing.Color.Transparent;
            this.btnmin.BorderRadius = 15;
            this.btnmin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnmin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnmin.FillColor = System.Drawing.Color.Black;
            this.btnmin.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmin.ForeColor = System.Drawing.Color.Cyan;
            this.btnmin.HoverState.BorderColor = System.Drawing.Color.Cyan;
            this.btnmin.HoverState.FillColor = System.Drawing.Color.Cyan;
            this.btnmin.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnmin.Location = new System.Drawing.Point(309, 423);
            this.btnmin.Name = "btnmin";
            this.btnmin.ShadowDecoration.BorderRadius = 15;
            this.btnmin.ShadowDecoration.Color = System.Drawing.Color.Cyan;
            this.btnmin.ShadowDecoration.Enabled = true;
            this.btnmin.Size = new System.Drawing.Size(63, 45);
            this.btnmin.TabIndex = 5;
            this.btnmin.Text = "-";
            this.btnmin.Click += new System.EventHandler(this.btnmin_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Transparent;
            this.btnadd.BorderRadius = 15;
            this.btnadd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnadd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnadd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnadd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnadd.FillColor = System.Drawing.Color.Black;
            this.btnadd.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.Cyan;
            this.btnadd.HoverState.BorderColor = System.Drawing.Color.Cyan;
            this.btnadd.HoverState.FillColor = System.Drawing.Color.Cyan;
            this.btnadd.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnadd.Location = new System.Drawing.Point(309, 359);
            this.btnadd.Name = "btnadd";
            this.btnadd.ShadowDecoration.BorderRadius = 15;
            this.btnadd.ShadowDecoration.Color = System.Drawing.Color.Cyan;
            this.btnadd.ShadowDecoration.Enabled = true;
            this.btnadd.Size = new System.Drawing.Size(63, 45);
            this.btnadd.TabIndex = 4;
            this.btnadd.Text = "+";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnthree
            // 
            this.btnthree.BackColor = System.Drawing.Color.Transparent;
            this.btnthree.BorderRadius = 15;
            this.btnthree.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnthree.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnthree.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnthree.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnthree.FillColor = System.Drawing.Color.Black;
            this.btnthree.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthree.ForeColor = System.Drawing.Color.Cyan;
            this.btnthree.HoverState.BorderColor = System.Drawing.Color.Cyan;
            this.btnthree.HoverState.FillColor = System.Drawing.Color.Cyan;
            this.btnthree.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnthree.Location = new System.Drawing.Point(206, 423);
            this.btnthree.Name = "btnthree";
            this.btnthree.ShadowDecoration.BorderRadius = 15;
            this.btnthree.ShadowDecoration.Color = System.Drawing.Color.Cyan;
            this.btnthree.ShadowDecoration.Enabled = true;
            this.btnthree.Size = new System.Drawing.Size(65, 45);
            this.btnthree.TabIndex = 9;
            this.btnthree.Text = "3";
            this.btnthree.Click += new System.EventHandler(this.btnthree_Click);
            // 
            // btnsix
            // 
            this.btnsix.BackColor = System.Drawing.Color.Transparent;
            this.btnsix.BorderRadius = 15;
            this.btnsix.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnsix.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnsix.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnsix.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnsix.FillColor = System.Drawing.Color.Black;
            this.btnsix.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsix.ForeColor = System.Drawing.Color.Cyan;
            this.btnsix.HoverState.BorderColor = System.Drawing.Color.Cyan;
            this.btnsix.HoverState.FillColor = System.Drawing.Color.Cyan;
            this.btnsix.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnsix.Location = new System.Drawing.Point(206, 359);
            this.btnsix.Name = "btnsix";
            this.btnsix.ShadowDecoration.BorderRadius = 15;
            this.btnsix.ShadowDecoration.Color = System.Drawing.Color.Cyan;
            this.btnsix.ShadowDecoration.Enabled = true;
            this.btnsix.Size = new System.Drawing.Size(65, 45);
            this.btnsix.TabIndex = 8;
            this.btnsix.Text = "6";
            this.btnsix.Click += new System.EventHandler(this.btnsix_Click);
            // 
            // btnnine
            // 
            this.btnnine.BackColor = System.Drawing.Color.Transparent;
            this.btnnine.BorderRadius = 15;
            this.btnnine.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnnine.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnnine.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnnine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnnine.FillColor = System.Drawing.Color.Black;
            this.btnnine.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnine.ForeColor = System.Drawing.Color.Cyan;
            this.btnnine.HoverState.BorderColor = System.Drawing.Color.Cyan;
            this.btnnine.HoverState.FillColor = System.Drawing.Color.Cyan;
            this.btnnine.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnnine.Location = new System.Drawing.Point(206, 295);
            this.btnnine.Name = "btnnine";
            this.btnnine.ShadowDecoration.BorderRadius = 15;
            this.btnnine.ShadowDecoration.Color = System.Drawing.Color.Cyan;
            this.btnnine.ShadowDecoration.Enabled = true;
            this.btnnine.Size = new System.Drawing.Size(65, 45);
            this.btnnine.TabIndex = 7;
            this.btnnine.Text = "9";
            this.btnnine.Click += new System.EventHandler(this.btnnine_Click);
            // 
            // btnmod
            // 
            this.btnmod.BackColor = System.Drawing.Color.Transparent;
            this.btnmod.BorderRadius = 15;
            this.btnmod.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnmod.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnmod.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnmod.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnmod.FillColor = System.Drawing.Color.Black;
            this.btnmod.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmod.ForeColor = System.Drawing.Color.Cyan;
            this.btnmod.HoverState.BorderColor = System.Drawing.Color.Cyan;
            this.btnmod.HoverState.FillColor = System.Drawing.Color.Cyan;
            this.btnmod.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnmod.Location = new System.Drawing.Point(206, 227);
            this.btnmod.Name = "btnmod";
            this.btnmod.ShadowDecoration.BorderRadius = 15;
            this.btnmod.ShadowDecoration.Color = System.Drawing.Color.Cyan;
            this.btnmod.ShadowDecoration.Enabled = true;
            this.btnmod.Size = new System.Drawing.Size(65, 45);
            this.btnmod.TabIndex = 6;
            this.btnmod.Text = "%";
            this.btnmod.Click += new System.EventHandler(this.btnmod_Click);
            // 
            // btntwo
            // 
            this.btntwo.BackColor = System.Drawing.Color.Transparent;
            this.btntwo.BorderRadius = 15;
            this.btntwo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btntwo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btntwo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btntwo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btntwo.FillColor = System.Drawing.Color.Black;
            this.btntwo.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntwo.ForeColor = System.Drawing.Color.Cyan;
            this.btntwo.HoverState.BorderColor = System.Drawing.Color.Cyan;
            this.btntwo.HoverState.FillColor = System.Drawing.Color.Cyan;
            this.btntwo.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btntwo.Location = new System.Drawing.Point(105, 423);
            this.btntwo.Name = "btntwo";
            this.btntwo.ShadowDecoration.BorderRadius = 15;
            this.btntwo.ShadowDecoration.Color = System.Drawing.Color.Cyan;
            this.btntwo.ShadowDecoration.Enabled = true;
            this.btntwo.Size = new System.Drawing.Size(58, 45);
            this.btntwo.TabIndex = 13;
            this.btntwo.Text = "2";
            this.btntwo.Click += new System.EventHandler(this.btntwo_Click);
            // 
            // btnfive
            // 
            this.btnfive.BackColor = System.Drawing.Color.Transparent;
            this.btnfive.BorderRadius = 15;
            this.btnfive.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnfive.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnfive.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnfive.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnfive.FillColor = System.Drawing.Color.Black;
            this.btnfive.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfive.ForeColor = System.Drawing.Color.Cyan;
            this.btnfive.HoverState.BorderColor = System.Drawing.Color.Cyan;
            this.btnfive.HoverState.FillColor = System.Drawing.Color.Cyan;
            this.btnfive.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnfive.Location = new System.Drawing.Point(105, 359);
            this.btnfive.Name = "btnfive";
            this.btnfive.ShadowDecoration.BorderRadius = 15;
            this.btnfive.ShadowDecoration.Color = System.Drawing.Color.Cyan;
            this.btnfive.ShadowDecoration.Enabled = true;
            this.btnfive.Size = new System.Drawing.Size(58, 45);
            this.btnfive.TabIndex = 12;
            this.btnfive.Text = "5";
            this.btnfive.Click += new System.EventHandler(this.btnfive_Click);
            // 
            // btneight
            // 
            this.btneight.BackColor = System.Drawing.Color.Transparent;
            this.btneight.BorderRadius = 15;
            this.btneight.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btneight.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btneight.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btneight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btneight.FillColor = System.Drawing.Color.Black;
            this.btneight.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneight.ForeColor = System.Drawing.Color.Cyan;
            this.btneight.HoverState.BorderColor = System.Drawing.Color.Cyan;
            this.btneight.HoverState.FillColor = System.Drawing.Color.Cyan;
            this.btneight.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btneight.Location = new System.Drawing.Point(105, 295);
            this.btneight.Name = "btneight";
            this.btneight.ShadowDecoration.BorderRadius = 15;
            this.btneight.ShadowDecoration.Color = System.Drawing.Color.Cyan;
            this.btneight.ShadowDecoration.Enabled = true;
            this.btneight.Size = new System.Drawing.Size(58, 45);
            this.btneight.TabIndex = 11;
            this.btneight.Text = "8";
            this.btneight.Click += new System.EventHandler(this.btneight_Click);
            // 
            // btnone
            // 
            this.btnone.BackColor = System.Drawing.Color.Transparent;
            this.btnone.BorderRadius = 15;
            this.btnone.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnone.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnone.FillColor = System.Drawing.Color.Black;
            this.btnone.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnone.ForeColor = System.Drawing.Color.Cyan;
            this.btnone.HoverState.BorderColor = System.Drawing.Color.Cyan;
            this.btnone.HoverState.FillColor = System.Drawing.Color.Cyan;
            this.btnone.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnone.Location = new System.Drawing.Point(14, 423);
            this.btnone.Name = "btnone";
            this.btnone.ShadowDecoration.BorderRadius = 15;
            this.btnone.ShadowDecoration.Color = System.Drawing.Color.Cyan;
            this.btnone.ShadowDecoration.Enabled = true;
            this.btnone.Size = new System.Drawing.Size(62, 45);
            this.btnone.TabIndex = 17;
            this.btnone.Text = "1";
            this.btnone.Click += new System.EventHandler(this.btnone_Click);
            // 
            // btnfour
            // 
            this.btnfour.BackColor = System.Drawing.Color.Transparent;
            this.btnfour.BorderRadius = 15;
            this.btnfour.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnfour.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnfour.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnfour.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnfour.FillColor = System.Drawing.Color.Black;
            this.btnfour.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfour.ForeColor = System.Drawing.Color.Cyan;
            this.btnfour.HoverState.BorderColor = System.Drawing.Color.Cyan;
            this.btnfour.HoverState.FillColor = System.Drawing.Color.Cyan;
            this.btnfour.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnfour.Location = new System.Drawing.Point(14, 359);
            this.btnfour.Name = "btnfour";
            this.btnfour.ShadowDecoration.BorderRadius = 15;
            this.btnfour.ShadowDecoration.Color = System.Drawing.Color.Cyan;
            this.btnfour.ShadowDecoration.Enabled = true;
            this.btnfour.Size = new System.Drawing.Size(62, 45);
            this.btnfour.TabIndex = 16;
            this.btnfour.Text = "4";
            this.btnfour.Click += new System.EventHandler(this.btnfour_Click);
            // 
            // btnseven
            // 
            this.btnseven.BackColor = System.Drawing.Color.Transparent;
            this.btnseven.BorderRadius = 15;
            this.btnseven.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnseven.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnseven.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnseven.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnseven.FillColor = System.Drawing.Color.Black;
            this.btnseven.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnseven.ForeColor = System.Drawing.Color.Cyan;
            this.btnseven.HoverState.BorderColor = System.Drawing.Color.Cyan;
            this.btnseven.HoverState.FillColor = System.Drawing.Color.Cyan;
            this.btnseven.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnseven.Location = new System.Drawing.Point(14, 295);
            this.btnseven.Name = "btnseven";
            this.btnseven.ShadowDecoration.BorderRadius = 15;
            this.btnseven.ShadowDecoration.Color = System.Drawing.Color.Cyan;
            this.btnseven.ShadowDecoration.Enabled = true;
            this.btnseven.Size = new System.Drawing.Size(62, 45);
            this.btnseven.TabIndex = 15;
            this.btnseven.Text = "7";
            this.btnseven.Click += new System.EventHandler(this.btnseven_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Transparent;
            this.btnclear.BorderRadius = 15;
            this.btnclear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnclear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnclear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnclear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnclear.FillColor = System.Drawing.Color.Black;
            this.btnclear.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.Color.Cyan;
            this.btnclear.HoverState.BorderColor = System.Drawing.Color.Cyan;
            this.btnclear.HoverState.FillColor = System.Drawing.Color.Cyan;
            this.btnclear.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnclear.Location = new System.Drawing.Point(14, 227);
            this.btnclear.Name = "btnclear";
            this.btnclear.ShadowDecoration.BorderRadius = 15;
            this.btnclear.ShadowDecoration.Color = System.Drawing.Color.Cyan;
            this.btnclear.ShadowDecoration.Enabled = true;
            this.btnclear.Size = new System.Drawing.Size(62, 45);
            this.btnclear.TabIndex = 14;
            this.btnclear.Text = "C";
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnzero
            // 
            this.btnzero.BackColor = System.Drawing.Color.Transparent;
            this.btnzero.BorderRadius = 15;
            this.btnzero.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnzero.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnzero.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnzero.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnzero.FillColor = System.Drawing.Color.Black;
            this.btnzero.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnzero.ForeColor = System.Drawing.Color.Cyan;
            this.btnzero.HoverState.BorderColor = System.Drawing.Color.Cyan;
            this.btnzero.HoverState.FillColor = System.Drawing.Color.Cyan;
            this.btnzero.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnzero.Location = new System.Drawing.Point(14, 485);
            this.btnzero.Name = "btnzero";
            this.btnzero.ShadowDecoration.BorderRadius = 15;
            this.btnzero.ShadowDecoration.Color = System.Drawing.Color.Cyan;
            this.btnzero.ShadowDecoration.Enabled = true;
            this.btnzero.Size = new System.Drawing.Size(62, 45);
            this.btnzero.TabIndex = 21;
            this.btnzero.Text = "0";
            this.btnzero.Click += new System.EventHandler(this.btnzero_Click);
            // 
            // btndot
            // 
            this.btndot.BackColor = System.Drawing.Color.Transparent;
            this.btndot.BorderRadius = 15;
            this.btndot.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btndot.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btndot.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btndot.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btndot.FillColor = System.Drawing.Color.Black;
            this.btndot.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndot.ForeColor = System.Drawing.Color.Cyan;
            this.btndot.HoverState.BorderColor = System.Drawing.Color.Cyan;
            this.btndot.HoverState.FillColor = System.Drawing.Color.Cyan;
            this.btndot.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btndot.Location = new System.Drawing.Point(105, 485);
            this.btndot.Name = "btndot";
            this.btndot.ShadowDecoration.BorderRadius = 15;
            this.btndot.ShadowDecoration.Color = System.Drawing.Color.Cyan;
            this.btndot.ShadowDecoration.Enabled = true;
            this.btndot.Size = new System.Drawing.Size(58, 45);
            this.btndot.TabIndex = 20;
            this.btndot.Text = ".";
            this.btndot.Click += new System.EventHandler(this.btndot_Click);
            // 
            // btnequal
            // 
            this.btnequal.BackColor = System.Drawing.Color.Transparent;
            this.btnequal.BorderRadius = 15;
            this.btnequal.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnequal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnequal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnequal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnequal.FillColor = System.Drawing.Color.Black;
            this.btnequal.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnequal.ForeColor = System.Drawing.Color.Cyan;
            this.btnequal.HoverState.BorderColor = System.Drawing.Color.Cyan;
            this.btnequal.HoverState.FillColor = System.Drawing.Color.Cyan;
            this.btnequal.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnequal.Location = new System.Drawing.Point(206, 485);
            this.btnequal.Name = "btnequal";
            this.btnequal.ShadowDecoration.BorderRadius = 15;
            this.btnequal.ShadowDecoration.Color = System.Drawing.Color.Cyan;
            this.btnequal.ShadowDecoration.Enabled = true;
            this.btnequal.Size = new System.Drawing.Size(166, 45);
            this.btnequal.TabIndex = 19;
            this.btnequal.Text = "=";
            this.btnequal.Click += new System.EventHandler(this.btnequal_Click);
            // 
            // textstore
            // 
            this.textstore.BorderThickness = 0;
            this.textstore.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textstore.DefaultText = "";
            this.textstore.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textstore.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textstore.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textstore.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textstore.FillColor = System.Drawing.Color.Black;
            this.textstore.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textstore.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textstore.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textstore.Location = new System.Drawing.Point(34, 153);
            this.textstore.Name = "textstore";
            this.textstore.PasswordChar = '\0';
            this.textstore.PlaceholderText = "";
            this.textstore.SelectedText = "";
            this.textstore.Size = new System.Drawing.Size(325, 36);
            this.textstore.TabIndex = 22;
            this.textstore.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textresult
            // 
            this.textresult.BorderThickness = 0;
            this.textresult.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textresult.DefaultText = "";
            this.textresult.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textresult.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textresult.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textresult.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textresult.FillColor = System.Drawing.Color.Black;
            this.textresult.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textresult.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textresult.ForeColor = System.Drawing.Color.White;
            this.textresult.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textresult.Location = new System.Drawing.Point(20, 87);
            this.textresult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textresult.Name = "textresult";
            this.textresult.PasswordChar = '\0';
            this.textresult.PlaceholderText = "0";
            this.textresult.SelectedText = "";
            this.textresult.Size = new System.Drawing.Size(339, 44);
            this.textresult.TabIndex = 23;
            this.textresult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 15;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Black;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Cyan;
            this.guna2Button1.HoverState.BorderColor = System.Drawing.Color.Cyan;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.Cyan;
            this.guna2Button1.HoverState.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Location = new System.Drawing.Point(98, 227);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.BorderRadius = 15;
            this.guna2Button1.ShadowDecoration.Color = System.Drawing.Color.Cyan;
            this.guna2Button1.ShadowDecoration.Enabled = true;
            this.guna2Button1.Size = new System.Drawing.Size(65, 45);
            this.guna2Button1.TabIndex = 24;
            this.guna2Button1.Text = "AC";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(384, 540);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.textresult);
            this.Controls.Add(this.textstore);
            this.Controls.Add(this.btnzero);
            this.Controls.Add(this.btndot);
            this.Controls.Add(this.btnequal);
            this.Controls.Add(this.btnone);
            this.Controls.Add(this.btnfour);
            this.Controls.Add(this.btnseven);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btntwo);
            this.Controls.Add(this.btnfive);
            this.Controls.Add(this.btneight);
            this.Controls.Add(this.btnthree);
            this.Controls.Add(this.btnsix);
            this.Controls.Add(this.btnnine);
            this.Controls.Add(this.btnmod);
            this.Controls.Add(this.btnmin);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnmul);
            this.Controls.Add(this.btndiv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnexit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.btnexit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox btnexit;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btndiv;
        private Guna.UI2.WinForms.Guna2Button btnmul;
        private Guna.UI2.WinForms.Guna2Button btnmin;
        private Guna.UI2.WinForms.Guna2Button btnadd;
        private Guna.UI2.WinForms.Guna2Button btnthree;
        private Guna.UI2.WinForms.Guna2Button btnsix;
        private Guna.UI2.WinForms.Guna2Button btnnine;
        private Guna.UI2.WinForms.Guna2Button btnmod;
        private Guna.UI2.WinForms.Guna2Button btntwo;
        private Guna.UI2.WinForms.Guna2Button btnfive;
        private Guna.UI2.WinForms.Guna2Button btneight;
        private Guna.UI2.WinForms.Guna2Button btnone;
        private Guna.UI2.WinForms.Guna2Button btnfour;
        private Guna.UI2.WinForms.Guna2Button btnseven;
        private Guna.UI2.WinForms.Guna2Button btnclear;
        private Guna.UI2.WinForms.Guna2Button btnzero;
        private Guna.UI2.WinForms.Guna2Button btndot;
        private Guna.UI2.WinForms.Guna2Button btnequal;
        private Guna.UI2.WinForms.Guna2TextBox textstore;
        private Guna.UI2.WinForms.Guna2TextBox textresult;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}


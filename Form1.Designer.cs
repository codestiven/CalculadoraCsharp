namespace Calculadora
{
    partial class Calculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculadora));
            this.salida = new System.Windows.Forms.TextBox();
            this.promedio = new System.Windows.Forms.Button();
            this.CE = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.borrar = new System.Windows.Forms.Button();
            this.divicion = new System.Windows.Forms.Button();
            this.raiz = new System.Windows.Forms.Button();
            this.expo = new System.Windows.Forms.Button();
            this.fracc = new System.Windows.Forms.Button();
            this.multiplicacion = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.resta = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.suma = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.res = new System.Windows.Forms.Button();
            this.point = new System.Windows.Forms.Button();
            this.cero = new System.Windows.Forms.Button();
            this.signo = new System.Windows.Forms.Button();
            this.demo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // salida
            // 
            this.salida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.salida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.salida.Font = new System.Drawing.Font("Segoe UI", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.salida.Location = new System.Drawing.Point(12, 58);
            this.salida.MaxLength = 21;
            this.salida.Multiline = true;
            this.salida.Name = "salida";
            this.salida.ReadOnly = true;
            this.salida.Size = new System.Drawing.Size(423, 87);
            this.salida.TabIndex = 1;
            this.salida.Text = "0";
            this.salida.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.salida.TextChanged += new System.EventHandler(this.salida_TextChanged);
            // 
            // promedio
            // 
            this.promedio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.promedio.BackColor = System.Drawing.SystemColors.ControlLight;
            this.promedio.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.promedio.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.promedio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.promedio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.promedio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.promedio.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.promedio.Location = new System.Drawing.Point(6, 160);
            this.promedio.Name = "promedio";
            this.promedio.Size = new System.Drawing.Size(104, 63);
            this.promedio.TabIndex = 6;
            this.promedio.Text = "%";
            this.promedio.UseVisualStyleBackColor = false;
            this.promedio.Click += new System.EventHandler(this.operaciones);
            // 
            // CE
            // 
            this.CE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CE.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CE.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.CE.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.CE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.CE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CE.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CE.Location = new System.Drawing.Point(116, 160);
            this.CE.Name = "CE";
            this.CE.Size = new System.Drawing.Size(104, 63);
            this.CE.TabIndex = 7;
            this.CE.Text = "CE";
            this.CE.UseVisualStyleBackColor = false;
            this.CE.Click += new System.EventHandler(this.CE_Click);
            // 
            // C
            // 
            this.C.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.C.BackColor = System.Drawing.SystemColors.ControlLight;
            this.C.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.C.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.C.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.C.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.C.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.C.Location = new System.Drawing.Point(226, 160);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(104, 63);
            this.C.TabIndex = 8;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = false;
            this.C.Click += new System.EventHandler(this.C_Click);
            // 
            // borrar
            // 
            this.borrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.borrar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.borrar.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.borrar.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.borrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.borrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.borrar.Image = ((System.Drawing.Image)(resources.GetObject("borrar.Image")));
            this.borrar.Location = new System.Drawing.Point(336, 160);
            this.borrar.Name = "borrar";
            this.borrar.Size = new System.Drawing.Size(104, 63);
            this.borrar.TabIndex = 9;
            this.borrar.UseVisualStyleBackColor = false;
            this.borrar.Click += new System.EventHandler(this.borrar_Click);
            // 
            // divicion
            // 
            this.divicion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.divicion.BackColor = System.Drawing.SystemColors.ControlLight;
            this.divicion.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.divicion.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.divicion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.divicion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.divicion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.divicion.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.divicion.Location = new System.Drawing.Point(336, 229);
            this.divicion.Name = "divicion";
            this.divicion.Size = new System.Drawing.Size(104, 63);
            this.divicion.TabIndex = 13;
            this.divicion.Text = "/";
            this.divicion.UseVisualStyleBackColor = false;
            this.divicion.Click += new System.EventHandler(this.operaciones);
            // 
            // raiz
            // 
            this.raiz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.raiz.BackColor = System.Drawing.SystemColors.ControlLight;
            this.raiz.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.raiz.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.raiz.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.raiz.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.raiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.raiz.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.raiz.Location = new System.Drawing.Point(226, 229);
            this.raiz.Name = "raiz";
            this.raiz.Size = new System.Drawing.Size(104, 63);
            this.raiz.TabIndex = 12;
            this.raiz.Text = "2√x";
            this.raiz.UseVisualStyleBackColor = false;
            this.raiz.Click += new System.EventHandler(this.operaciones);
            // 
            // expo
            // 
            this.expo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.expo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.expo.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.expo.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.expo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.expo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.expo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.expo.Location = new System.Drawing.Point(116, 229);
            this.expo.Name = "expo";
            this.expo.Size = new System.Drawing.Size(104, 63);
            this.expo.TabIndex = 11;
            this.expo.Text = "x^2";
            this.expo.UseVisualStyleBackColor = false;
            this.expo.Click += new System.EventHandler(this.operaciones);
            // 
            // fracc
            // 
            this.fracc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.fracc.BackColor = System.Drawing.SystemColors.ControlLight;
            this.fracc.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.fracc.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.fracc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fracc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.fracc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fracc.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fracc.Location = new System.Drawing.Point(6, 229);
            this.fracc.Name = "fracc";
            this.fracc.Size = new System.Drawing.Size(104, 63);
            this.fracc.TabIndex = 10;
            this.fracc.Text = "1/x";
            this.fracc.UseVisualStyleBackColor = false;
            this.fracc.Click += new System.EventHandler(this.operaciones);
            // 
            // multiplicacion
            // 
            this.multiplicacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.multiplicacion.BackColor = System.Drawing.SystemColors.ControlLight;
            this.multiplicacion.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.multiplicacion.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.multiplicacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.multiplicacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.multiplicacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multiplicacion.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.multiplicacion.Location = new System.Drawing.Point(336, 298);
            this.multiplicacion.Name = "multiplicacion";
            this.multiplicacion.Size = new System.Drawing.Size(104, 63);
            this.multiplicacion.TabIndex = 17;
            this.multiplicacion.Text = "X";
            this.multiplicacion.UseVisualStyleBackColor = false;
            this.multiplicacion.Click += new System.EventHandler(this.operaciones);
            // 
            // b9
            // 
            this.b9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.b9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.b9.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.b9.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.b9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.b9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.b9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b9.Location = new System.Drawing.Point(226, 298);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(104, 63);
            this.b9.TabIndex = 16;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = false;
            this.b9.Click += new System.EventHandler(this.entrada_numero);
            // 
            // b8
            // 
            this.b8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.b8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.b8.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.b8.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.b8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.b8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.b8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b8.Location = new System.Drawing.Point(116, 298);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(104, 63);
            this.b8.TabIndex = 15;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = false;
            this.b8.Click += new System.EventHandler(this.entrada_numero);
            // 
            // b7
            // 
            this.b7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.b7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.b7.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.b7.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.b7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.b7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.b7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b7.Location = new System.Drawing.Point(6, 298);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(104, 63);
            this.b7.TabIndex = 14;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = false;
            this.b7.Click += new System.EventHandler(this.entrada_numero);
            // 
            // resta
            // 
            this.resta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.resta.BackColor = System.Drawing.SystemColors.ControlLight;
            this.resta.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.resta.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.resta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.resta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.resta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resta.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resta.Location = new System.Drawing.Point(336, 367);
            this.resta.Name = "resta";
            this.resta.Size = new System.Drawing.Size(104, 63);
            this.resta.TabIndex = 21;
            this.resta.Text = "-";
            this.resta.UseVisualStyleBackColor = false;
            this.resta.Click += new System.EventHandler(this.operaciones);
            // 
            // b6
            // 
            this.b6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.b6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.b6.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.b6.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.b6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.b6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.b6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b6.Location = new System.Drawing.Point(226, 367);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(104, 63);
            this.b6.TabIndex = 20;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = false;
            this.b6.Click += new System.EventHandler(this.entrada_numero);
            // 
            // b5
            // 
            this.b5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.b5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.b5.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.b5.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.b5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.b5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.b5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b5.Location = new System.Drawing.Point(116, 367);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(104, 63);
            this.b5.TabIndex = 19;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = false;
            this.b5.Click += new System.EventHandler(this.entrada_numero);
            // 
            // b4
            // 
            this.b4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.b4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.b4.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.b4.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.b4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.b4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.b4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b4.Location = new System.Drawing.Point(6, 367);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(104, 63);
            this.b4.TabIndex = 18;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = false;
            this.b4.Click += new System.EventHandler(this.entrada_numero);
            // 
            // suma
            // 
            this.suma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.suma.BackColor = System.Drawing.SystemColors.ControlLight;
            this.suma.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.suma.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.suma.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.suma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.suma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.suma.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.suma.Location = new System.Drawing.Point(336, 436);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(104, 63);
            this.suma.TabIndex = 25;
            this.suma.Text = "+";
            this.suma.UseVisualStyleBackColor = false;
            this.suma.Click += new System.EventHandler(this.operaciones);
            // 
            // b3
            // 
            this.b3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.b3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.b3.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.b3.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.b3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.b3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.b3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b3.Location = new System.Drawing.Point(226, 436);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(104, 63);
            this.b3.TabIndex = 24;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = false;
            this.b3.Click += new System.EventHandler(this.entrada_numero);
            // 
            // b2
            // 
            this.b2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.b2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.b2.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.b2.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.b2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.b2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.b2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b2.Location = new System.Drawing.Point(116, 436);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(104, 63);
            this.b2.TabIndex = 23;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = false;
            this.b2.Click += new System.EventHandler(this.entrada_numero);
            // 
            // b1
            // 
            this.b1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.b1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.b1.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.b1.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.b1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.b1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.b1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b1.Location = new System.Drawing.Point(6, 436);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(104, 63);
            this.b1.TabIndex = 22;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Click += new System.EventHandler(this.entrada_numero);
            // 
            // res
            // 
            this.res.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.res.BackColor = System.Drawing.Color.LightSkyBlue;
            this.res.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.res.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.res.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.res.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.res.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.res.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.res.Location = new System.Drawing.Point(336, 505);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(104, 63);
            this.res.TabIndex = 29;
            this.res.Text = "=";
            this.res.UseVisualStyleBackColor = false;
            this.res.Click += new System.EventHandler(this.resultado);
            // 
            // point
            // 
            this.point.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.point.BackColor = System.Drawing.SystemColors.ControlLight;
            this.point.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.point.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.point.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.point.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.point.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.point.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.point.Location = new System.Drawing.Point(226, 505);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(104, 63);
            this.point.TabIndex = 28;
            this.point.Text = ".";
            this.point.UseVisualStyleBackColor = false;
            this.point.Click += new System.EventHandler(this.entrada_numero);
            // 
            // cero
            // 
            this.cero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cero.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cero.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.cero.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.cero.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.cero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cero.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cero.Location = new System.Drawing.Point(116, 505);
            this.cero.Name = "cero";
            this.cero.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cero.Size = new System.Drawing.Size(104, 63);
            this.cero.TabIndex = 27;
            this.cero.Text = "0";
            this.cero.UseVisualStyleBackColor = false;
            this.cero.Click += new System.EventHandler(this.entrada_numero);
            // 
            // signo
            // 
            this.signo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.signo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.signo.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.signo.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkGray;
            this.signo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.signo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.signo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.signo.Location = new System.Drawing.Point(6, 505);
            this.signo.Name = "signo";
            this.signo.Size = new System.Drawing.Size(104, 63);
            this.signo.TabIndex = 26;
            this.signo.Text = "+/-";
            this.signo.UseVisualStyleBackColor = false;
            this.signo.Click += new System.EventHandler(this.signo_Click);
            // 
            // demo
            // 
            this.demo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.demo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.demo.Cursor = System.Windows.Forms.Cursors.No;
            this.demo.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.demo.ForeColor = System.Drawing.Color.Silver;
            this.demo.Location = new System.Drawing.Point(17, 12);
            this.demo.MaxLength = 21;
            this.demo.Multiline = true;
            this.demo.Name = "demo";
            this.demo.ReadOnly = true;
            this.demo.Size = new System.Drawing.Size(423, 40);
            this.demo.TabIndex = 30;
            this.demo.Text = "0";
            this.demo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 579);
            this.Controls.Add(this.demo);
            this.Controls.Add(this.res);
            this.Controls.Add(this.point);
            this.Controls.Add(this.cero);
            this.Controls.Add(this.signo);
            this.Controls.Add(this.suma);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.resta);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.multiplicacion);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.divicion);
            this.Controls.Add(this.raiz);
            this.Controls.Add(this.expo);
            this.Controls.Add(this.fracc);
            this.Controls.Add(this.borrar);
            this.Controls.Add(this.C);
            this.Controls.Add(this.CE);
            this.Controls.Add(this.promedio);
            this.Controls.Add(this.salida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox salida;
        private Button promedio;
        private Button CE;
        private Button C;
        private Button borrar;
        private Button divicion;
        private Button raiz;
        private Button expo;
        private Button fracc;
        private Button multiplicacion;
        private Button b9;
        private Button b8;
        private Button b7;
        private Button resta;
        private Button b6;
        private Button b5;
        private Button b4;
        private Button suma;
        private Button b3;
        private Button b2;
        private Button b1;
        private Button res;
        private Button point;
        private Button cero;
        private Button signo;
        private TextBox demo;
    }
}
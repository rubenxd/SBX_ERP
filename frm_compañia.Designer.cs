
namespace SBX_ERP
{
    partial class frm_compañia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_compañia));
            this.pnl_botones = new System.Windows.Forms.Panel();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_consultas = new System.Windows.Forms.Button();
            this.btn_buscar_2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_telefonos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.cbx_tipo_persona = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_razon_social = new System.Windows.Forms.TextBox();
            this.cbx_tipo_identificacion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_identificacion = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnl_botones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_botones
            // 
            this.pnl_botones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_botones.Controls.Add(this.btn_guardar);
            this.pnl_botones.Controls.Add(this.btn_consultas);
            this.pnl_botones.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_botones.Location = new System.Drawing.Point(0, 0);
            this.pnl_botones.Name = "pnl_botones";
            this.pnl_botones.Size = new System.Drawing.Size(438, 42);
            this.pnl_botones.TabIndex = 1;
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.Location = new System.Drawing.Point(10, 8);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(26, 26);
            this.btn_guardar.TabIndex = 1;
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_consultas
            // 
            this.btn_consultas.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_consultas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_consultas.FlatAppearance.BorderSize = 0;
            this.btn_consultas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_consultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_consultas.Image = ((System.Drawing.Image)(resources.GetObject("btn_consultas.Image")));
            this.btn_consultas.Location = new System.Drawing.Point(44, 8);
            this.btn_consultas.Name = "btn_consultas";
            this.btn_consultas.Size = new System.Drawing.Size(26, 26);
            this.btn_consultas.TabIndex = 2;
            this.btn_consultas.UseVisualStyleBackColor = false;
            this.btn_consultas.Click += new System.EventHandler(this.btn_consultas_Click);
            // 
            // btn_buscar_2
            // 
            this.btn_buscar_2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_buscar_2.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_buscar_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscar_2.FlatAppearance.BorderSize = 0;
            this.btn_buscar_2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_buscar_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar_2.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar_2.Image")));
            this.btn_buscar_2.Location = new System.Drawing.Point(393, 52);
            this.btn_buscar_2.Name = "btn_buscar_2";
            this.btn_buscar_2.Size = new System.Drawing.Size(22, 15);
            this.btn_buscar_2.TabIndex = 61;
            this.btn_buscar_2.UseVisualStyleBackColor = false;
            this.btn_buscar_2.Click += new System.EventHandler(this.btn_buscar_2_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 16);
            this.label8.TabIndex = 74;
            this.label8.Text = "Email";
            // 
            // txt_email
            // 
            this.txt_email.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(142, 224);
            this.txt_email.MaxLength = 50;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(232, 23);
            this.txt_email.TabIndex = 67;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 73;
            this.label7.Text = "Telefonos *";
            // 
            // txt_telefonos
            // 
            this.txt_telefonos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_telefonos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefonos.Location = new System.Drawing.Point(142, 195);
            this.txt_telefonos.MaxLength = 50;
            this.txt_telefonos.Name = "txt_telefonos";
            this.txt_telefonos.Size = new System.Drawing.Size(232, 23);
            this.txt_telefonos.TabIndex = 66;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 72;
            this.label6.Text = "Direccion";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_direccion.Location = new System.Drawing.Point(142, 166);
            this.txt_direccion.MaxLength = 50;
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(232, 23);
            this.txt_direccion.TabIndex = 65;
            // 
            // cbx_tipo_persona
            // 
            this.cbx_tipo_persona.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbx_tipo_persona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_tipo_persona.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_tipo_persona.FormattingEnabled = true;
            this.cbx_tipo_persona.Items.AddRange(new object[] {
            "Juridico",
            "Natural"});
            this.cbx_tipo_persona.Location = new System.Drawing.Point(142, 136);
            this.cbx_tipo_persona.Name = "cbx_tipo_persona";
            this.cbx_tipo_persona.Size = new System.Drawing.Size(232, 24);
            this.cbx_tipo_persona.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 71;
            this.label5.Text = "Tipo persona";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 70;
            this.label4.Text = "Razon social *";
            // 
            // txt_razon_social
            // 
            this.txt_razon_social.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_razon_social.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_razon_social.Location = new System.Drawing.Point(142, 107);
            this.txt_razon_social.MaxLength = 50;
            this.txt_razon_social.Name = "txt_razon_social";
            this.txt_razon_social.Size = new System.Drawing.Size(232, 23);
            this.txt_razon_social.TabIndex = 63;
            // 
            // cbx_tipo_identificacion
            // 
            this.cbx_tipo_identificacion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbx_tipo_identificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_tipo_identificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_tipo_identificacion.FormattingEnabled = true;
            this.cbx_tipo_identificacion.Items.AddRange(new object[] {
            "NIT",
            "RUT",
            "CEDULA"});
            this.cbx_tipo_identificacion.Location = new System.Drawing.Point(142, 77);
            this.cbx_tipo_identificacion.Name = "cbx_tipo_identificacion";
            this.cbx_tipo_identificacion.Size = new System.Drawing.Size(232, 24);
            this.cbx_tipo_identificacion.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 16);
            this.label3.TabIndex = 69;
            this.label3.Text = "Tipo Identificacion";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 68;
            this.label1.Text = "Identificacion *";
            // 
            // txt_identificacion
            // 
            this.txt_identificacion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_identificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_identificacion.Location = new System.Drawing.Point(142, 48);
            this.txt_identificacion.MaxLength = 50;
            this.txt_identificacion.Name = "txt_identificacion";
            this.txt_identificacion.Size = new System.Drawing.Size(232, 23);
            this.txt_identificacion.TabIndex = 60;
            this.txt_identificacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_identificacion_KeyPress);
            this.txt_identificacion.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_identificacion_PreviewKeyDown);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frm_compañia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 260);
            this.Controls.Add(this.btn_buscar_2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_telefonos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.cbx_tipo_persona);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_razon_social);
            this.Controls.Add(this.cbx_tipo_identificacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_identificacion);
            this.Controls.Add(this.pnl_botones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_compañia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compañia";
            this.Load += new System.EventHandler(this.frm_compañia_Load);
            this.pnl_botones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_botones;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_consultas;
        private System.Windows.Forms.Button btn_buscar_2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_telefonos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.ComboBox cbx_tipo_persona;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_razon_social;
        private System.Windows.Forms.ComboBox cbx_tipo_identificacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_identificacion;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
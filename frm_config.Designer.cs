
namespace SBX_ERP
{
    partial class frm_config
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_config));
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.cbx_tipo_busq_doc = new System.Windows.Forms.ComboBox();
            this.pnl_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 16);
            this.label1.TabIndex = 52;
            this.label1.Text = "Tipo Busqueda Doc";
            // 
            // pnl_menu
            // 
            this.pnl_menu.BackColor = System.Drawing.Color.Gray;
            this.pnl_menu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_menu.Controls.Add(this.btn_guardar);
            this.pnl_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_menu.Location = new System.Drawing.Point(0, 0);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(346, 41);
            this.pnl_menu.TabIndex = 53;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_guardar.Location = new System.Drawing.Point(0, 0);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(39, 37);
            this.btn_guardar.TabIndex = 1;
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // cbx_tipo_busq_doc
            // 
            this.cbx_tipo_busq_doc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_tipo_busq_doc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_tipo_busq_doc.FormattingEnabled = true;
            this.cbx_tipo_busq_doc.Items.AddRange(new object[] {
            "Placa",
            "Identificacion"});
            this.cbx_tipo_busq_doc.Location = new System.Drawing.Point(146, 46);
            this.cbx_tipo_busq_doc.Name = "cbx_tipo_busq_doc";
            this.cbx_tipo_busq_doc.Size = new System.Drawing.Size(187, 24);
            this.cbx_tipo_busq_doc.TabIndex = 54;
            // 
            // frm_config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 105);
            this.Controls.Add(this.cbx_tipo_busq_doc);
            this.Controls.Add(this.pnl_menu);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_config";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_config";
            this.Load += new System.EventHandler(this.frm_config_Load);
            this.pnl_menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_menu;
        public System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.ComboBox cbx_tipo_busq_doc;
    }
}
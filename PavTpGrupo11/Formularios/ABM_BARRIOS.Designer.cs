﻿
namespace PavTpGrupo11.Formularios
{
    partial class ABM_BARRIOS
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
            this.TxtIDBarrio = new System.Windows.Forms.TextBox();
            this.txtNombreB = new System.Windows.Forms.TextBox();
            this.GrillaBarrio = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalirB = new System.Windows.Forms.Button();
            this.btnElimarB = new System.Windows.Forms.Button();
            this.btnModificarBarrio = new System.Windows.Forms.Button();
            this.BtnAgregarB = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Btn_LimpiarCamposObra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaBarrio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtIDBarrio
            // 
            this.TxtIDBarrio.Location = new System.Drawing.Point(280, 57);
            this.TxtIDBarrio.Name = "TxtIDBarrio";
            this.TxtIDBarrio.Size = new System.Drawing.Size(99, 20);
            this.TxtIDBarrio.TabIndex = 0;
            this.TxtIDBarrio.TextChanged += new System.EventHandler(this.TxtIDBarrio_TextChanged);
            // 
            // txtNombreB
            // 
            this.txtNombreB.Location = new System.Drawing.Point(280, 103);
            this.txtNombreB.Name = "txtNombreB";
            this.txtNombreB.Size = new System.Drawing.Size(99, 20);
            this.txtNombreB.TabIndex = 1;
            // 
            // GrillaBarrio
            // 
            this.GrillaBarrio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaBarrio.Location = new System.Drawing.Point(12, 179);
            this.GrillaBarrio.Name = "GrillaBarrio";
            this.GrillaBarrio.Size = new System.Drawing.Size(228, 140);
            this.GrillaBarrio.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(190, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID barrio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(183, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nombre Barrio:";
            // 
            // btnSalirB
            // 
            this.btnSalirB.Location = new System.Drawing.Point(236, 395);
            this.btnSalirB.Name = "btnSalirB";
            this.btnSalirB.Size = new System.Drawing.Size(75, 23);
            this.btnSalirB.TabIndex = 5;
            this.btnSalirB.Text = "salir";
            this.btnSalirB.UseVisualStyleBackColor = true;
            this.btnSalirB.Click += new System.EventHandler(this.btnSalirB_Click);
            // 
            // btnElimarB
            // 
            this.btnElimarB.Image = global::PavTpGrupo11.Properties.Resources.boton_eliminar;
            this.btnElimarB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnElimarB.Location = new System.Drawing.Point(224, 339);
            this.btnElimarB.Name = "btnElimarB";
            this.btnElimarB.Size = new System.Drawing.Size(87, 31);
            this.btnElimarB.TabIndex = 4;
            this.btnElimarB.Text = "Eliminar";
            this.btnElimarB.UseVisualStyleBackColor = true;
            this.btnElimarB.Click += new System.EventHandler(this.btnElimarB_Click);
            // 
            // btnModificarBarrio
            // 
            this.btnModificarBarrio.Image = global::PavTpGrupo11.Properties.Resources.editar;
            this.btnModificarBarrio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarBarrio.Location = new System.Drawing.Point(115, 339);
            this.btnModificarBarrio.Name = "btnModificarBarrio";
            this.btnModificarBarrio.Size = new System.Drawing.Size(87, 31);
            this.btnModificarBarrio.TabIndex = 3;
            this.btnModificarBarrio.Text = "Modificar";
            this.btnModificarBarrio.UseVisualStyleBackColor = true;
            this.btnModificarBarrio.Click += new System.EventHandler(this.btnModificarBarrio_Click);
            // 
            // BtnAgregarB
            // 
            this.BtnAgregarB.Image = global::PavTpGrupo11.Properties.Resources.agregar_usuario;
            this.BtnAgregarB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgregarB.Location = new System.Drawing.Point(12, 339);
            this.BtnAgregarB.Name = "BtnAgregarB";
            this.BtnAgregarB.Size = new System.Drawing.Size(87, 31);
            this.BtnAgregarB.TabIndex = 2;
            this.BtnAgregarB.Text = "Agregar";
            this.BtnAgregarB.UseVisualStyleBackColor = true;
            this.BtnAgregarB.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PavTpGrupo11.Properties.Resources.pueblo;
            this.pictureBox2.Location = new System.Drawing.Point(12, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(152, 127);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Btn_LimpiarCamposObra
            // 
            this.Btn_LimpiarCamposObra.Location = new System.Drawing.Point(261, 140);
            this.Btn_LimpiarCamposObra.Name = "Btn_LimpiarCamposObra";
            this.Btn_LimpiarCamposObra.Size = new System.Drawing.Size(118, 22);
            this.Btn_LimpiarCamposObra.TabIndex = 9;
            this.Btn_LimpiarCamposObra.Text = "Limpiar campos";
            this.Btn_LimpiarCamposObra.UseVisualStyleBackColor = true;
            this.Btn_LimpiarCamposObra.Click += new System.EventHandler(this.Btn_LimpiarCamposObra_Click);
            // 
            // ABM_BARRIOS
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(412, 430);
            this.Controls.Add(this.Btn_LimpiarCamposObra);
            this.Controls.Add(this.btnSalirB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GrillaBarrio);
            this.Controls.Add(this.txtNombreB);
            this.Controls.Add(this.TxtIDBarrio);
            this.Controls.Add(this.btnElimarB);
            this.Controls.Add(this.btnModificarBarrio);
            this.Controls.Add(this.BtnAgregarB);
            this.Controls.Add(this.pictureBox2);
            this.Name = "ABM_BARRIOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ABM_BARRIOS_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaBarrio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBarrio;
        private System.Windows.Forms.MaskedTextBox txtNombreBarrio;
        private System.Windows.Forms.DataGridView grillaBarrios;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnModificarB;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BtnAgregarB;
        private System.Windows.Forms.Button btnModificarBarrio;
        private System.Windows.Forms.Button btnElimarB;
        private System.Windows.Forms.TextBox TxtIDBarrio;
        private System.Windows.Forms.TextBox txtNombreB;
        private System.Windows.Forms.DataGridView GrillaBarrio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalirB;
        private System.Windows.Forms.Button Btn_LimpiarCamposObra;
    }
}
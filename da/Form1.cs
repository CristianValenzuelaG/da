using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace da
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private System.Windows.Forms.Button btnEliminacli;
        private System.Windows.Forms.Button btnModificacli;
        private System.Windows.Forms.Button btnSalcli;
        private System.Windows.Forms.TextBox txtBcli;
        private System.Windows.Forms.Button btnBuscarcli;
        private System.Windows.Forms.ListBox listBox1;
        private void Form1_Load(object sender, EventArgs e)
        {
           
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 362);
            //this.Controls.Add(this.label4);
            //this.Controls.Add(this.label3);
            //this.Controls.Add(this.label2);
            //this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalcli);
            this.Controls.Add(this.btnModificacli);
            this.Controls.Add(this.btnEliminacli);
            this.Controls.Add(this.btnAgregacli);
            //this.Controls.Add(this.txtTelecli);
            //this.Controls.Add(this.txtDomicli);
            //this.Controls.Add(this.txtNomcli);
            //this.Controls.Add(this.txtClavecli);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnBuscarcli);
            this.Controls.Add(this.txtBcli);
            this.Name = "Form1";
            this.Text = "Form1";
            //this.Load += new System.EventHandler(this.frmCliente_Load);
            //this.ResizeEnd += new System.EventHandler(this.frmCliente_ResizeEnd);
            this.ResumeLayout(false);
            this.PerformLayout();

            }
            // txtBcli
            // 
            this.txtBcli = new System.Windows.Forms.TextBox();
            txtBcli.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            txtBcli.ForeColor = System.Drawing.SystemColors.GrayText;
            txtBcli.Location = new System.Drawing.Point(12, 12);
            txtBcli.Name = "txtBcli";
            txtBcli.Size = new System.Drawing.Size(534, 20);
            txtBcli.TabIndex = 0;
            // 
            // btnBuscarcli
            // 
            this.btnBuscarcli = new System.Windows.Forms.Button();
            this.btnBuscarcli.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarcli.Location = new System.Drawing.Point(552, 10);
            this.btnBuscarcli.Name = "btnBuscarcli";
            this.btnBuscarcli.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarcli.TabIndex = 1;
            this.btnBuscarcli.Text = "Buscar";
            this.btnBuscarcli.UseVisualStyleBackColor = true;
            this.btnBuscarcli.Click += new System.EventHandler(this.btnBuscarcli_Click);
            // 
            // listBox1
            // 
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 14;
            this.listBox1.Location = new System.Drawing.Point(12, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(615, 228);

            // btnAgregacli
            // 
            private System.Windows.Forms.Button btnAgregacli;
            btnAgregacli = new System.Windows.Forms.Button();
            this.btnAgregacli.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregacli.Location = new System.Drawing.Point(12, 327);
            this.btnAgregacli.Name = "btnAgregacli";
            this.btnAgregacli.Size = new System.Drawing.Size(75, 23);
            this.btnAgregacli.TabIndex = 4;
            this.btnAgregacli.Text = "Agregar";
            this.btnAgregacli.UseVisualStyleBackColor = true;
            this.btnAgregacli.Click += new System.EventHandler(this.btnAgregacli_Click);
            // 
            // btnEliminacli
            // 
            this.btnEliminacli = new System.Windows.Forms.Button();
            this.btnEliminacli.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminacli.Location = new System.Drawing.Point(93, 327);
            this.btnEliminacli.Name = "btnEliminacli";
            this.btnEliminacli.Size = new System.Drawing.Size(75, 23);
            this.btnEliminacli.TabIndex = 5;
            this.btnEliminacli.Text = "Eliminar";
            this.btnEliminacli.UseVisualStyleBackColor = true;
            this.btnEliminacli.Click += new System.EventHandler(this.btnEliminacli_Click);
            // 
            // btnModificacli
            // 
            this.btnModificacli = new System.Windows.Forms.Button();
            this.btnModificacli.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModificacli.Location = new System.Drawing.Point(174, 327);
            this.btnModificacli.Name = "btnModificacli";
            this.btnModificacli.Size = new System.Drawing.Size(75, 23);
            this.btnModificacli.TabIndex = 6;
            this.btnModificacli.Text = "Modificar";
            this.btnModificacli.UseVisualStyleBackColor = true;
            this.btnModificacli.Click += new System.EventHandler(this.btnModificacli_Click);
            // 
            // btnSalcli
            // 
            this.btnSalcli = new System.Windows.Forms.Button();
            this.btnSalcli.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalcli.Location = new System.Drawing.Point(255, 327);
            this.btnSalcli.Name = "btnSalcli";
            this.btnSalcli.Size = new System.Drawing.Size(75, 23);
            this.btnSalcli.TabIndex = 7;
            this.btnSalcli.Text = "Salir";
            this.btnSalcli.UseVisualStyleBackColor = true;
            this.btnSalcli.Click += new System.EventHandler(this.btnSalcli_Click);
        }
    }
}

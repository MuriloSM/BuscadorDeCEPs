using System.Drawing.Drawing2D;

namespace consultarCep
{
    partial class Form1
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
            groupBox1 = new GroupBox();
            txtEstado = new TextBox();
            label5 = new Label();
            txtRua = new TextBox();
            label4 = new Label();
            txtBairro = new TextBox();
            label3 = new Label();
            txtCidade = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtCEP = new TextBox();
            btBuscar = new Button();
            btLimpar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtEstado);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtRua);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtBairro);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtCidade);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(489, 137);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtEstado
            // 
            txtEstado.BackColor = SystemColors.InactiveCaption;
            txtEstado.Location = new Point(266, 92);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(217, 23);
            txtEstado.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(262, 74);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 9;
            label5.Text = "Estado:";
            // 
            // txtRua
            // 
            txtRua.BackColor = SystemColors.InactiveCaption;
            txtRua.Location = new Point(6, 40);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(235, 23);
            txtRua.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 22);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 7;
            label4.Text = "Rua:";
            // 
            // txtBairro
            // 
            txtBairro.BackColor = SystemColors.InactiveCaption;
            txtBairro.Location = new Point(266, 40);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(217, 23);
            txtBairro.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 74);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 5;
            label3.Text = "Cidade:";
            // 
            // txtCidade
            // 
            txtCidade.BackColor = SystemColors.InactiveCaption;
            txtCidade.Location = new Point(6, 92);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(235, 23);
            txtCidade.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(266, 22);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 3;
            label2.Text = "Bairro:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 9);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 1;
            label1.Text = "CEP:";
            // 
            // txtCEP
            // 
            txtCEP.Location = new Point(18, 27);
            txtCEP.Name = "txtCEP";
            txtCEP.Size = new Size(143, 23);
            txtCEP.TabIndex = 2;
            txtCEP.TextChanged += txtCEP_TextChanged;
            // 
            // btBuscar
            // 
            btBuscar.BackgroundImage = Properties.Resources._66d716b822ff33d9aeb8df257de65197;
            btBuscar.BackgroundImageLayout = ImageLayout.Zoom;
            btBuscar.Location = new Point(183, 18);
            btBuscar.Name = "btBuscar";
            btBuscar.Size = new Size(70, 38);
            btBuscar.TabIndex = 3;
            btBuscar.TextAlign = ContentAlignment.MiddleRight;
            btBuscar.UseVisualStyleBackColor = true;
            // 
            // btLimpar
            // 
            btLimpar.Location = new Point(420, 205);
            btLimpar.Name = "btLimpar";
            btLimpar.Size = new Size(75, 23);
            btLimpar.TabIndex = 4;
            btLimpar.Text = "Limpar";
            btLimpar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(507, 239);
            Controls.Add(btLimpar);
            Controls.Add(btBuscar);
            Controls.Add(txtCEP);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultar CEPs";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtEstado;
        private Label label5;
        private TextBox txtRua;
        private Label label4;
        private TextBox txtBairro;
        private Label label3;
        private TextBox txtCidade;
        private Label label2;
        private Label label1;
        private TextBox txtCEP;
        private Button btBuscar;
        private Button btLimpar;
        
    }
}
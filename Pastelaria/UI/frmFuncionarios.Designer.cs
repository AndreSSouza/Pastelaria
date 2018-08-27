namespace Pastelaria.UI
{
    partial class frmFuncionarios
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnLimparFunc = new System.Windows.Forms.Button();
            this.btnCadastrarFunc = new System.Windows.Forms.Button();
            this.lblSalarioFunc = new System.Windows.Forms.Label();
            this.txtSalarioFunc = new System.Windows.Forms.TextBox();
            this.lblFuncaoFunc = new System.Windows.Forms.Label();
            this.txtFuncaoFunc = new System.Windows.Forms.TextBox();
            this.lblCelularFunc = new System.Windows.Forms.Label();
            this.mtxtCelularFunc = new System.Windows.Forms.MaskedTextBox();
            this.lblNomeFunc = new System.Windows.Forms.Label();
            this.txtNomeFunc = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(556, 332);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnLimparFunc);
            this.tabPage1.Controls.Add(this.btnCadastrarFunc);
            this.tabPage1.Controls.Add(this.lblSalarioFunc);
            this.tabPage1.Controls.Add(this.txtSalarioFunc);
            this.tabPage1.Controls.Add(this.lblFuncaoFunc);
            this.tabPage1.Controls.Add(this.txtFuncaoFunc);
            this.tabPage1.Controls.Add(this.lblCelularFunc);
            this.tabPage1.Controls.Add(this.mtxtCelularFunc);
            this.tabPage1.Controls.Add(this.lblNomeFunc);
            this.tabPage1.Controls.Add(this.txtNomeFunc);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(548, 297);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CADASTRO";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnLimparFunc
            // 
            this.btnLimparFunc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLimparFunc.Location = new System.Drawing.Point(311, 219);
            this.btnLimparFunc.Name = "btnLimparFunc";
            this.btnLimparFunc.Size = new System.Drawing.Size(128, 34);
            this.btnLimparFunc.TabIndex = 23;
            this.btnLimparFunc.Text = "Limpar";
            this.btnLimparFunc.UseVisualStyleBackColor = true;
            this.btnLimparFunc.Click += new System.EventHandler(this.btnLimparFunc_Click);
            // 
            // btnCadastrarFunc
            // 
            this.btnCadastrarFunc.Location = new System.Drawing.Point(89, 219);
            this.btnCadastrarFunc.Name = "btnCadastrarFunc";
            this.btnCadastrarFunc.Size = new System.Drawing.Size(151, 34);
            this.btnCadastrarFunc.TabIndex = 22;
            this.btnCadastrarFunc.Text = "Cadastrar";
            this.btnCadastrarFunc.UseVisualStyleBackColor = true;
            this.btnCadastrarFunc.Click += new System.EventHandler(this.btnCadastrarFunc_Click);
            // 
            // lblSalarioFunc
            // 
            this.lblSalarioFunc.AutoSize = true;
            this.lblSalarioFunc.Location = new System.Drawing.Point(41, 136);
            this.lblSalarioFunc.Name = "lblSalarioFunc";
            this.lblSalarioFunc.Size = new System.Drawing.Size(66, 22);
            this.lblSalarioFunc.TabIndex = 17;
            this.lblSalarioFunc.Text = "Salário:";
            // 
            // txtSalarioFunc
            // 
            this.txtSalarioFunc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSalarioFunc.Location = new System.Drawing.Point(116, 134);
            this.txtSalarioFunc.Name = "txtSalarioFunc";
            this.txtSalarioFunc.Size = new System.Drawing.Size(128, 28);
            this.txtSalarioFunc.TabIndex = 16;
            // 
            // lblFuncaoFunc
            // 
            this.lblFuncaoFunc.AutoSize = true;
            this.lblFuncaoFunc.Location = new System.Drawing.Point(41, 86);
            this.lblFuncaoFunc.Name = "lblFuncaoFunc";
            this.lblFuncaoFunc.Size = new System.Drawing.Size(66, 22);
            this.lblFuncaoFunc.TabIndex = 15;
            this.lblFuncaoFunc.Text = "Função:";
            // 
            // txtFuncaoFunc
            // 
            this.txtFuncaoFunc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFuncaoFunc.Location = new System.Drawing.Point(116, 84);
            this.txtFuncaoFunc.Name = "txtFuncaoFunc";
            this.txtFuncaoFunc.Size = new System.Drawing.Size(356, 28);
            this.txtFuncaoFunc.TabIndex = 14;
            // 
            // lblCelularFunc
            // 
            this.lblCelularFunc.AutoSize = true;
            this.lblCelularFunc.Location = new System.Drawing.Point(273, 136);
            this.lblCelularFunc.Name = "lblCelularFunc";
            this.lblCelularFunc.Size = new System.Drawing.Size(65, 22);
            this.lblCelularFunc.TabIndex = 10;
            this.lblCelularFunc.Text = "Celular:";
            // 
            // mtxtCelularFunc
            // 
            this.mtxtCelularFunc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtxtCelularFunc.Location = new System.Drawing.Point(344, 134);
            this.mtxtCelularFunc.Mask = "(00)00000-0000";
            this.mtxtCelularFunc.Name = "mtxtCelularFunc";
            this.mtxtCelularFunc.Size = new System.Drawing.Size(128, 28);
            this.mtxtCelularFunc.TabIndex = 9;
            // 
            // lblNomeFunc
            // 
            this.lblNomeFunc.AutoSize = true;
            this.lblNomeFunc.Location = new System.Drawing.Point(50, 33);
            this.lblNomeFunc.Name = "lblNomeFunc";
            this.lblNomeFunc.Size = new System.Drawing.Size(57, 22);
            this.lblNomeFunc.TabIndex = 4;
            this.lblNomeFunc.Text = "Nome:";
            // 
            // txtNomeFunc
            // 
            this.txtNomeFunc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeFunc.Location = new System.Drawing.Point(116, 31);
            this.txtNomeFunc.Name = "txtNomeFunc";
            this.txtNomeFunc.Size = new System.Drawing.Size(356, 28);
            this.txtNomeFunc.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(548, 297);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CONSULTA";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // frmFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 332);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionários";
            this.Load += new System.EventHandler(this.frmFuncionarios_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.Label lblFuncaoFunc;
        private System.Windows.Forms.MaskedTextBox mtxtCelularFunc;
        public System.Windows.Forms.Label lblNomeFunc;
        private System.Windows.Forms.Button btnLimparFunc;
        private System.Windows.Forms.Button btnCadastrarFunc;
        public System.Windows.Forms.Label lblSalarioFunc;
        private System.Windows.Forms.TextBox txtSalarioFunc;
        private System.Windows.Forms.TextBox txtFuncaoFunc;
        private System.Windows.Forms.Label lblCelularFunc;
        private System.Windows.Forms.TextBox txtNomeFunc;
    }
}
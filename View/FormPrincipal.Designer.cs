
namespace View
{
    partial class FormPrincipal
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
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelSobrenome = new System.Windows.Forms.Label();
            this.labelCPF = new System.Windows.Forms.Label();
            this.labelDataNascimento = new System.Windows.Forms.Label();
            this.comboBoxVaga = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxSobrenome = new System.Windows.Forms.TextBox();
            this.textBoxCPF = new System.Windows.Forms.TextBox();
            this.dataGridViewCandidatos = new System.Windows.Forms.DataGridView();
            this.dateTimePickerDataDeNascimento = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCandidatos)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAdicionar.Location = new System.Drawing.Point(615, 19);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(120, 59);
            this.buttonAdicionar.TabIndex = 6;
            this.buttonAdicionar.Text = "Adicionar na Lista";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSalvar.Location = new System.Drawing.Point(615, 96);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(120, 67);
            this.buttonSalvar.TabIndex = 7;
            this.buttonSalvar.Text = "Salvar no Banco de Dados";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNome.Location = new System.Drawing.Point(29, 37);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(68, 21);
            this.labelNome.TabIndex = 2;
            this.labelNome.Text = "Nome *";
            // 
            // labelSobrenome
            // 
            this.labelSobrenome.AutoSize = true;
            this.labelSobrenome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSobrenome.Location = new System.Drawing.Point(29, 112);
            this.labelSobrenome.Name = "labelSobrenome";
            this.labelSobrenome.Size = new System.Drawing.Size(109, 21);
            this.labelSobrenome.TabIndex = 3;
            this.labelSobrenome.Text = "Sobrenome *";
            // 
            // labelCPF
            // 
            this.labelCPF.AutoSize = true;
            this.labelCPF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCPF.Location = new System.Drawing.Point(230, 37);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(49, 21);
            this.labelCPF.TabIndex = 4;
            this.labelCPF.Text = "CPF *";
            // 
            // labelDataNascimento
            // 
            this.labelDataNascimento.AutoSize = true;
            this.labelDataNascimento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDataNascimento.Location = new System.Drawing.Point(230, 112);
            this.labelDataNascimento.Name = "labelDataNascimento";
            this.labelDataNascimento.Size = new System.Drawing.Size(176, 21);
            this.labelDataNascimento.TabIndex = 5;
            this.labelDataNascimento.Text = "Data de Nascimento *";
            // 
            // comboBoxVaga
            // 
            this.comboBoxVaga.FormattingEnabled = true;
            this.comboBoxVaga.Location = new System.Drawing.Point(443, 65);
            this.comboBoxVaga.Name = "comboBoxVaga";
            this.comboBoxVaga.Size = new System.Drawing.Size(121, 23);
            this.comboBoxVaga.TabIndex = 5;
            this.comboBoxVaga.TextChanged += new System.EventHandler(this.comboBoxVaga_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(443, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Vaga *";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(29, 65);
            this.textBoxNome.MaxLength = 15;
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(173, 23);
            this.textBoxNome.TabIndex = 1;
            // 
            // textBoxSobrenome
            // 
            this.textBoxSobrenome.Location = new System.Drawing.Point(29, 140);
            this.textBoxSobrenome.MaxLength = 100;
            this.textBoxSobrenome.Name = "textBoxSobrenome";
            this.textBoxSobrenome.Size = new System.Drawing.Size(173, 23);
            this.textBoxSobrenome.TabIndex = 2;
            // 
            // textBoxCPF
            // 
            this.textBoxCPF.Location = new System.Drawing.Point(230, 65);
            this.textBoxCPF.MaxLength = 11;
            this.textBoxCPF.Name = "textBoxCPF";
            this.textBoxCPF.Size = new System.Drawing.Size(176, 23);
            this.textBoxCPF.TabIndex = 3;
            // 
            // dataGridViewCandidatos
            // 
            this.dataGridViewCandidatos.AllowUserToAddRows = false;
            this.dataGridViewCandidatos.AllowUserToDeleteRows = false;
            this.dataGridViewCandidatos.AllowUserToResizeColumns = false;
            this.dataGridViewCandidatos.AllowUserToResizeRows = false;
            this.dataGridViewCandidatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewCandidatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCandidatos.Location = new System.Drawing.Point(29, 176);
            this.dataGridViewCandidatos.MultiSelect = false;
            this.dataGridViewCandidatos.Name = "dataGridViewCandidatos";
            this.dataGridViewCandidatos.ReadOnly = true;
            this.dataGridViewCandidatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewCandidatos.RowTemplate.Height = 25;
            this.dataGridViewCandidatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCandidatos.Size = new System.Drawing.Size(706, 333);
            this.dataGridViewCandidatos.TabIndex = 12;
            // 
            // dateTimePickerDataDeNascimento
            // 
            this.dateTimePickerDataDeNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataDeNascimento.Location = new System.Drawing.Point(230, 140);
            this.dateTimePickerDataDeNascimento.Name = "dateTimePickerDataDeNascimento";
            this.dateTimePickerDataDeNascimento.Size = new System.Drawing.Size(176, 23);
            this.dateTimePickerDataDeNascimento.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(29, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Os campos com * são obrigatórios preencher.";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 541);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerDataDeNascimento);
            this.Controls.Add(this.dataGridViewCandidatos);
            this.Controls.Add(this.textBoxCPF);
            this.Controls.Add(this.textBoxSobrenome);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxVaga);
            this.Controls.Add(this.labelDataNascimento);
            this.Controls.Add(this.labelCPF);
            this.Controls.Add(this.labelSobrenome);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonAdicionar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empresa XPTO - casdastro de candidatos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCandidatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelSobrenome;
        private System.Windows.Forms.Label labelCPF;
        private System.Windows.Forms.Label labelDataNascimento;
        private System.Windows.Forms.ComboBox comboBoxVaga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxSobrenome;
        private System.Windows.Forms.TextBox textBoxCPF;
        private System.Windows.Forms.DataGridView dataGridViewCandidatos;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataDeNascimento;
        private System.Windows.Forms.Label label2;
    }
}


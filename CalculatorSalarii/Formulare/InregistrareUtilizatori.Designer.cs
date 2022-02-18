
namespace CalculatorSalarii
{
    partial class FrmInregistrareUtilizatori
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
            this.btnInchide = new System.Windows.Forms.Button();
            this.btnInregistrareUtilizator = new System.Windows.Forms.Button();
            this.btnActualizareUtilizator = new System.Windows.Forms.Button();
            this.btnResetareUtilizator = new System.Windows.Forms.Button();
            this.btnStergereUtilizator = new System.Windows.Forms.Button();
            this.lblPontajOre = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtUtilizatoriParola = new System.Windows.Forms.TextBox();
            this.lblparolainregistrare = new System.Windows.Forms.Label();
            this.txtPozitie = new System.Windows.Forms.TextBox();
            this.lblPozitieinregistrare = new System.Windows.Forms.Label();
            this.txtUtilizatorConfirmaParola = new System.Windows.Forms.TextBox();
            this.lblNumeinregistrare = new System.Windows.Forms.Label();
            this.txtNumeUtilizator = new System.Windows.Forms.TextBox();
            this.lblconfirmparolainregistrare = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvUtilizatoriInregistrati = new System.Windows.Forms.DataGridView();
            this.calculatorSalariiDataSet3 = new CalculatorSalarii.CalculatorSalariiDataSet3();
            this.utilizatorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.utilizatorTableAdapter = new CalculatorSalarii.CalculatorSalariiDataSet3TableAdapters.UtilizatorTableAdapter();
            this.utilizatorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeUtilizatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parolaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pozitieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtilizatoriInregistrati)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculatorSalariiDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizatorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInchide
            // 
            this.btnInchide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInchide.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnInchide.ForeColor = System.Drawing.Color.White;
            this.btnInchide.Location = new System.Drawing.Point(1060, 12);
            this.btnInchide.Name = "btnInchide";
            this.btnInchide.Size = new System.Drawing.Size(115, 45);
            this.btnInchide.TabIndex = 51;
            this.btnInchide.Text = "Închide";
            this.btnInchide.UseVisualStyleBackColor = true;
            this.btnInchide.Click += new System.EventHandler(this.btnInchide_Click);
            // 
            // btnInregistrareUtilizator
            // 
            this.btnInregistrareUtilizator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInregistrareUtilizator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnInregistrareUtilizator.ForeColor = System.Drawing.Color.White;
            this.btnInregistrareUtilizator.Location = new System.Drawing.Point(711, 530);
            this.btnInregistrareUtilizator.Name = "btnInregistrareUtilizator";
            this.btnInregistrareUtilizator.Size = new System.Drawing.Size(141, 45);
            this.btnInregistrareUtilizator.TabIndex = 52;
            this.btnInregistrareUtilizator.Text = "Înregistrare";
            this.btnInregistrareUtilizator.UseVisualStyleBackColor = true;
            this.btnInregistrareUtilizator.Click += new System.EventHandler(this.btnInregistrareUtilizator_Click);
            // 
            // btnActualizareUtilizator
            // 
            this.btnActualizareUtilizator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizareUtilizator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnActualizareUtilizator.ForeColor = System.Drawing.Color.White;
            this.btnActualizareUtilizator.Location = new System.Drawing.Point(548, 530);
            this.btnActualizareUtilizator.Name = "btnActualizareUtilizator";
            this.btnActualizareUtilizator.Size = new System.Drawing.Size(141, 45);
            this.btnActualizareUtilizator.TabIndex = 53;
            this.btnActualizareUtilizator.Text = "Actualizare";
            this.btnActualizareUtilizator.UseVisualStyleBackColor = true;
            this.btnActualizareUtilizator.Click += new System.EventHandler(this.btnActualizareUtilizator_Click);
            // 
            // btnResetareUtilizator
            // 
            this.btnResetareUtilizator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetareUtilizator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnResetareUtilizator.ForeColor = System.Drawing.Color.White;
            this.btnResetareUtilizator.Location = new System.Drawing.Point(871, 530);
            this.btnResetareUtilizator.Name = "btnResetareUtilizator";
            this.btnResetareUtilizator.Size = new System.Drawing.Size(141, 45);
            this.btnResetareUtilizator.TabIndex = 54;
            this.btnResetareUtilizator.Text = "Resetare";
            this.btnResetareUtilizator.UseVisualStyleBackColor = true;
            this.btnResetareUtilizator.Click += new System.EventHandler(this.btnResetareUtilizator_Click);
            // 
            // btnStergereUtilizator
            // 
            this.btnStergereUtilizator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStergereUtilizator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStergereUtilizator.ForeColor = System.Drawing.Color.White;
            this.btnStergereUtilizator.Location = new System.Drawing.Point(1034, 530);
            this.btnStergereUtilizator.Name = "btnStergereUtilizator";
            this.btnStergereUtilizator.Size = new System.Drawing.Size(141, 45);
            this.btnStergereUtilizator.TabIndex = 55;
            this.btnStergereUtilizator.Text = "Șterge";
            this.btnStergereUtilizator.UseVisualStyleBackColor = true;
            this.btnStergereUtilizator.Click += new System.EventHandler(this.btnStergereUtilizator_Click);
            // 
            // lblPontajOre
            // 
            this.lblPontajOre.AutoSize = true;
            this.lblPontajOre.BackColor = System.Drawing.Color.Purple;
            this.lblPontajOre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPontajOre.ForeColor = System.Drawing.Color.Yellow;
            this.lblPontajOre.Location = new System.Drawing.Point(433, 35);
            this.lblPontajOre.Name = "lblPontajOre";
            this.lblPontajOre.Size = new System.Drawing.Size(316, 36);
            this.lblPontajOre.TabIndex = 56;
            this.lblPontajOre.Text = "Înregistrare utilizatori";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtUtilizatoriParola);
            this.groupBox1.Controls.Add(this.lblparolainregistrare);
            this.groupBox1.Controls.Add(this.txtPozitie);
            this.groupBox1.Controls.Add(this.lblPozitieinregistrare);
            this.groupBox1.Controls.Add(this.txtUtilizatorConfirmaParola);
            this.groupBox1.Controls.Add(this.lblNumeinregistrare);
            this.groupBox1.Controls.Add(this.txtNumeUtilizator);
            this.groupBox1.Controls.Add(this.lblconfirmparolainregistrare);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 365);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Înregistrare";
            // 
            // txtUtilizatoriParola
            // 
            this.txtUtilizatoriParola.Location = new System.Drawing.Point(286, 141);
            this.txtUtilizatoriParola.Name = "txtUtilizatoriParola";
            this.txtUtilizatoriParola.Size = new System.Drawing.Size(196, 27);
            this.txtUtilizatoriParola.TabIndex = 36;
            // 
            // lblparolainregistrare
            // 
            this.lblparolainregistrare.AutoSize = true;
            this.lblparolainregistrare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblparolainregistrare.ForeColor = System.Drawing.Color.White;
            this.lblparolainregistrare.Location = new System.Drawing.Point(120, 143);
            this.lblparolainregistrare.Name = "lblparolainregistrare";
            this.lblparolainregistrare.Size = new System.Drawing.Size(74, 25);
            this.lblparolainregistrare.TabIndex = 42;
            this.lblparolainregistrare.Text = "Parolă";
            // 
            // txtPozitie
            // 
            this.txtPozitie.Location = new System.Drawing.Point(286, 235);
            this.txtPozitie.Name = "txtPozitie";
            this.txtPozitie.Size = new System.Drawing.Size(196, 27);
            this.txtPozitie.TabIndex = 38;
            // 
            // lblPozitieinregistrare
            // 
            this.lblPozitieinregistrare.AutoSize = true;
            this.lblPozitieinregistrare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPozitieinregistrare.ForeColor = System.Drawing.Color.White;
            this.lblPozitieinregistrare.Location = new System.Drawing.Point(117, 234);
            this.lblPozitieinregistrare.Name = "lblPozitieinregistrare";
            this.lblPozitieinregistrare.Size = new System.Drawing.Size(77, 25);
            this.lblPozitieinregistrare.TabIndex = 41;
            this.lblPozitieinregistrare.Text = "Poziție";
            // 
            // txtUtilizatorConfirmaParola
            // 
            this.txtUtilizatorConfirmaParola.Location = new System.Drawing.Point(286, 189);
            this.txtUtilizatorConfirmaParola.Name = "txtUtilizatorConfirmaParola";
            this.txtUtilizatorConfirmaParola.Size = new System.Drawing.Size(196, 27);
            this.txtUtilizatorConfirmaParola.TabIndex = 37;
            // 
            // lblNumeinregistrare
            // 
            this.lblNumeinregistrare.AutoSize = true;
            this.lblNumeinregistrare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNumeinregistrare.ForeColor = System.Drawing.Color.White;
            this.lblNumeinregistrare.Location = new System.Drawing.Point(126, 92);
            this.lblNumeinregistrare.Name = "lblNumeinregistrare";
            this.lblNumeinregistrare.Size = new System.Drawing.Size(68, 25);
            this.lblNumeinregistrare.TabIndex = 40;
            this.lblNumeinregistrare.Text = "Nume";
            // 
            // txtNumeUtilizator
            // 
            this.txtNumeUtilizator.Location = new System.Drawing.Point(286, 90);
            this.txtNumeUtilizator.Name = "txtNumeUtilizator";
            this.txtNumeUtilizator.Size = new System.Drawing.Size(196, 27);
            this.txtNumeUtilizator.TabIndex = 35;
 
            // 
            // lblconfirmparolainregistrare
            // 
            this.lblconfirmparolainregistrare.AutoSize = true;
            this.lblconfirmparolainregistrare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblconfirmparolainregistrare.ForeColor = System.Drawing.Color.White;
            this.lblconfirmparolainregistrare.Location = new System.Drawing.Point(62, 188);
            this.lblconfirmparolainregistrare.Name = "lblconfirmparolainregistrare";
            this.lblconfirmparolainregistrare.Size = new System.Drawing.Size(184, 25);
            this.lblconfirmparolainregistrare.TabIndex = 39;
            this.lblconfirmparolainregistrare.Text = "Confirmare parolă";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvUtilizatoriInregistrati);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(615, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(559, 365);
            this.groupBox2.TabIndex = 58;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Utilizatori înregistrați";
            // 
            // dgvUtilizatoriInregistrati
            // 
            this.dgvUtilizatoriInregistrati.AutoGenerateColumns = false;
            this.dgvUtilizatoriInregistrati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUtilizatoriInregistrati.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.utilizatorIDDataGridViewTextBoxColumn,
            this.numeUtilizatorDataGridViewTextBoxColumn,
            this.parolaDataGridViewTextBoxColumn,
            this.pozitieDataGridViewTextBoxColumn});
            this.dgvUtilizatoriInregistrati.DataSource = this.utilizatorBindingSource;
            this.dgvUtilizatoriInregistrati.Location = new System.Drawing.Point(20, 44);
            this.dgvUtilizatoriInregistrati.Name = "dgvUtilizatoriInregistrati";
            this.dgvUtilizatoriInregistrati.RowHeadersWidth = 51;
            this.dgvUtilizatoriInregistrati.RowTemplate.Height = 24;
            this.dgvUtilizatoriInregistrati.Size = new System.Drawing.Size(521, 294);
            this.dgvUtilizatoriInregistrati.TabIndex = 0;
            this.dgvUtilizatoriInregistrati.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUtilizatoriInregistrati_CellEnter);
            // 
            // calculatorSalariiDataSet3
            // 
            this.calculatorSalariiDataSet3.DataSetName = "CalculatorSalariiDataSet3";
            this.calculatorSalariiDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // utilizatorBindingSource
            // 
            this.utilizatorBindingSource.DataMember = "Utilizator";
            this.utilizatorBindingSource.DataSource = this.calculatorSalariiDataSet3;
            // 
            // utilizatorTableAdapter
            // 
            this.utilizatorTableAdapter.ClearBeforeFill = true;
            // 
            // utilizatorIDDataGridViewTextBoxColumn
            // 
            this.utilizatorIDDataGridViewTextBoxColumn.DataPropertyName = "UtilizatorID";
            this.utilizatorIDDataGridViewTextBoxColumn.HeaderText = "UtilizatorID";
            this.utilizatorIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.utilizatorIDDataGridViewTextBoxColumn.Name = "utilizatorIDDataGridViewTextBoxColumn";
            this.utilizatorIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.utilizatorIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // numeUtilizatorDataGridViewTextBoxColumn
            // 
            this.numeUtilizatorDataGridViewTextBoxColumn.DataPropertyName = "NumeUtilizator";
            this.numeUtilizatorDataGridViewTextBoxColumn.HeaderText = "NumeUtilizator";
            this.numeUtilizatorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numeUtilizatorDataGridViewTextBoxColumn.Name = "numeUtilizatorDataGridViewTextBoxColumn";
            this.numeUtilizatorDataGridViewTextBoxColumn.Width = 125;
            // 
            // parolaDataGridViewTextBoxColumn
            // 
            this.parolaDataGridViewTextBoxColumn.DataPropertyName = "Parola";
            this.parolaDataGridViewTextBoxColumn.HeaderText = "Parola";
            this.parolaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.parolaDataGridViewTextBoxColumn.Name = "parolaDataGridViewTextBoxColumn";
            this.parolaDataGridViewTextBoxColumn.Width = 125;
            // 
            // pozitieDataGridViewTextBoxColumn
            // 
            this.pozitieDataGridViewTextBoxColumn.DataPropertyName = "Pozitie";
            this.pozitieDataGridViewTextBoxColumn.HeaderText = "Pozitie";
            this.pozitieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pozitieDataGridViewTextBoxColumn.Name = "pozitieDataGridViewTextBoxColumn";
            this.pozitieDataGridViewTextBoxColumn.Width = 125;
            // 
            // FrmInregistrareUtilizatori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(1187, 642);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblPontajOre);
            this.Controls.Add(this.btnStergereUtilizator);
            this.Controls.Add(this.btnResetareUtilizator);
            this.Controls.Add(this.btnActualizareUtilizator);
            this.Controls.Add(this.btnInregistrareUtilizator);
            this.Controls.Add(this.btnInchide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInregistrareUtilizatori";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InregistrareUtilizatori";
            this.Load += new System.EventHandler(this.FrmInregistrareUtilizatori_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtilizatoriInregistrati)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculatorSalariiDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utilizatorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInchide;
        private System.Windows.Forms.Button btnInregistrareUtilizator;
        private System.Windows.Forms.Button btnActualizareUtilizator;
        private System.Windows.Forms.Button btnResetareUtilizator;
        private System.Windows.Forms.Button btnStergereUtilizator;
        private System.Windows.Forms.Label lblPontajOre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtUtilizatoriParola;
        private System.Windows.Forms.Label lblparolainregistrare;
        private System.Windows.Forms.TextBox txtPozitie;
        private System.Windows.Forms.Label lblPozitieinregistrare;
        private System.Windows.Forms.TextBox txtUtilizatorConfirmaParola;
        private System.Windows.Forms.Label lblNumeinregistrare;
        private System.Windows.Forms.TextBox txtNumeUtilizator;
        private System.Windows.Forms.Label lblconfirmparolainregistrare;
        private System.Windows.Forms.DataGridView dgvUtilizatoriInregistrati;
        private CalculatorSalariiDataSet3 calculatorSalariiDataSet3;
        private System.Windows.Forms.BindingSource utilizatorBindingSource;
        private CalculatorSalariiDataSet3TableAdapters.UtilizatorTableAdapter utilizatorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn utilizatorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeUtilizatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parolaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pozitieDataGridViewTextBoxColumn;
    }
}

namespace CalculatorSalarii
{
    partial class FrmRapoarte
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
            this.lblRapoarte = new System.Windows.Forms.Label();
            this.btninchide = new System.Windows.Forms.Button();
            this.btnRapoarteExportExcel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.plataSalariuIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.angajatIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPlatiiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodaPlataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lunaPlataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarifOrarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarifOreSuplimentareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oreContractDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oreSuplimentareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalOreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salariuOreContractDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salariuOreSuplimentareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salariuBrutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.impozitVenitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cASSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deducerePersonalaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDeducereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salariuNetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.platiSalariuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calculatorSalariiDataSet4 = new CalculatorSalarii.CalculatorSalariiDataSet4();
            this.platiSalariuTableAdapter = new CalculatorSalarii.CalculatorSalariiDataSet4TableAdapters.PlatiSalariuTableAdapter();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CircleButton2 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CircleButton3 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CircleButton4 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CircleButton5 = new Guna.UI2.WinForms.Guna2CircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.platiSalariuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculatorSalariiDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRapoarte
            // 
            this.lblRapoarte.AutoSize = true;
            this.lblRapoarte.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRapoarte.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRapoarte.Location = new System.Drawing.Point(366, 62);
            this.lblRapoarte.Name = "lblRapoarte";
            this.lblRapoarte.Size = new System.Drawing.Size(223, 32);
            this.lblRapoarte.TabIndex = 0;
            this.lblRapoarte.Text = "Rapoarte Excel";
            // 
            // btninchide
            // 
            this.btninchide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninchide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btninchide.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btninchide.Location = new System.Drawing.Point(758, 12);
            this.btninchide.Name = "btninchide";
            this.btninchide.Size = new System.Drawing.Size(135, 48);
            this.btninchide.TabIndex = 1;
            this.btninchide.Text = "Închide";
            this.btninchide.UseVisualStyleBackColor = true;
            this.btninchide.Click += new System.EventHandler(this.btninchide_Click);
            // 
            // btnRapoarteExportExcel
            // 
            this.btnRapoarteExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRapoarteExportExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRapoarteExportExcel.ForeColor = System.Drawing.Color.Yellow;
            this.btnRapoarteExportExcel.Location = new System.Drawing.Point(708, 432);
            this.btnRapoarteExportExcel.Name = "btnRapoarteExportExcel";
            this.btnRapoarteExportExcel.Size = new System.Drawing.Size(185, 50);
            this.btnRapoarteExportExcel.TabIndex = 2;
            this.btnRapoarteExportExcel.Text = "Export Excel";
            this.btnRapoarteExportExcel.UseVisualStyleBackColor = true;
            this.btnRapoarteExportExcel.Click += new System.EventHandler(this.btnRapoarteExportExcel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.plataSalariuIDDataGridViewTextBoxColumn,
            this.angajatIDDataGridViewTextBoxColumn,
            this.numeDataGridViewTextBoxColumn,
            this.prenumeDataGridViewTextBoxColumn,
            this.cNPDataGridViewTextBoxColumn,
            this.dataPlatiiDataGridViewTextBoxColumn,
            this.periodaPlataDataGridViewTextBoxColumn,
            this.lunaPlataDataGridViewTextBoxColumn,
            this.tarifOrarDataGridViewTextBoxColumn,
            this.tarifOreSuplimentareDataGridViewTextBoxColumn,
            this.oreContractDataGridViewTextBoxColumn,
            this.oreSuplimentareDataGridViewTextBoxColumn,
            this.totalOreDataGridViewTextBoxColumn,
            this.salariuOreContractDataGridViewTextBoxColumn,
            this.salariuOreSuplimentareDataGridViewTextBoxColumn,
            this.salariuBrutDataGridViewTextBoxColumn,
            this.impozitVenitDataGridViewTextBoxColumn,
            this.cASDataGridViewTextBoxColumn,
            this.cASSDataGridViewTextBoxColumn,
            this.deducerePersonalaDataGridViewTextBoxColumn,
            this.totalDeducereDataGridViewTextBoxColumn,
            this.salariuNetDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.platiSalariuBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(56, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(826, 267);
            this.dataGridView1.TabIndex = 3;
            // 
            // plataSalariuIDDataGridViewTextBoxColumn
            // 
            this.plataSalariuIDDataGridViewTextBoxColumn.DataPropertyName = "PlataSalariuID";
            this.plataSalariuIDDataGridViewTextBoxColumn.HeaderText = "PlataSalariuID";
            this.plataSalariuIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.plataSalariuIDDataGridViewTextBoxColumn.Name = "plataSalariuIDDataGridViewTextBoxColumn";
            this.plataSalariuIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.plataSalariuIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // angajatIDDataGridViewTextBoxColumn
            // 
            this.angajatIDDataGridViewTextBoxColumn.DataPropertyName = "AngajatID";
            this.angajatIDDataGridViewTextBoxColumn.HeaderText = "AngajatID";
            this.angajatIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.angajatIDDataGridViewTextBoxColumn.Name = "angajatIDDataGridViewTextBoxColumn";
            this.angajatIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // numeDataGridViewTextBoxColumn
            // 
            this.numeDataGridViewTextBoxColumn.DataPropertyName = "Nume";
            this.numeDataGridViewTextBoxColumn.HeaderText = "Nume";
            this.numeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numeDataGridViewTextBoxColumn.Name = "numeDataGridViewTextBoxColumn";
            this.numeDataGridViewTextBoxColumn.Width = 125;
            // 
            // prenumeDataGridViewTextBoxColumn
            // 
            this.prenumeDataGridViewTextBoxColumn.DataPropertyName = "Prenume";
            this.prenumeDataGridViewTextBoxColumn.HeaderText = "Prenume";
            this.prenumeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prenumeDataGridViewTextBoxColumn.Name = "prenumeDataGridViewTextBoxColumn";
            this.prenumeDataGridViewTextBoxColumn.Width = 125;
            // 
            // cNPDataGridViewTextBoxColumn
            // 
            this.cNPDataGridViewTextBoxColumn.DataPropertyName = "CNP";
            this.cNPDataGridViewTextBoxColumn.HeaderText = "CNP";
            this.cNPDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cNPDataGridViewTextBoxColumn.Name = "cNPDataGridViewTextBoxColumn";
            this.cNPDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataPlatiiDataGridViewTextBoxColumn
            // 
            this.dataPlatiiDataGridViewTextBoxColumn.DataPropertyName = "DataPlatii";
            this.dataPlatiiDataGridViewTextBoxColumn.HeaderText = "DataPlatii";
            this.dataPlatiiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataPlatiiDataGridViewTextBoxColumn.Name = "dataPlatiiDataGridViewTextBoxColumn";
            this.dataPlatiiDataGridViewTextBoxColumn.Width = 125;
            // 
            // periodaPlataDataGridViewTextBoxColumn
            // 
            this.periodaPlataDataGridViewTextBoxColumn.DataPropertyName = "PeriodaPlata";
            this.periodaPlataDataGridViewTextBoxColumn.HeaderText = "PeriodaPlata";
            this.periodaPlataDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.periodaPlataDataGridViewTextBoxColumn.Name = "periodaPlataDataGridViewTextBoxColumn";
            this.periodaPlataDataGridViewTextBoxColumn.Width = 125;
            // 
            // lunaPlataDataGridViewTextBoxColumn
            // 
            this.lunaPlataDataGridViewTextBoxColumn.DataPropertyName = "LunaPlata";
            this.lunaPlataDataGridViewTextBoxColumn.HeaderText = "LunaPlata";
            this.lunaPlataDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lunaPlataDataGridViewTextBoxColumn.Name = "lunaPlataDataGridViewTextBoxColumn";
            this.lunaPlataDataGridViewTextBoxColumn.Width = 125;
            // 
            // tarifOrarDataGridViewTextBoxColumn
            // 
            this.tarifOrarDataGridViewTextBoxColumn.DataPropertyName = "TarifOrar";
            this.tarifOrarDataGridViewTextBoxColumn.HeaderText = "TarifOrar";
            this.tarifOrarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tarifOrarDataGridViewTextBoxColumn.Name = "tarifOrarDataGridViewTextBoxColumn";
            this.tarifOrarDataGridViewTextBoxColumn.Width = 125;
            // 
            // tarifOreSuplimentareDataGridViewTextBoxColumn
            // 
            this.tarifOreSuplimentareDataGridViewTextBoxColumn.DataPropertyName = "TarifOreSuplimentare";
            this.tarifOreSuplimentareDataGridViewTextBoxColumn.HeaderText = "TarifOreSuplimentare";
            this.tarifOreSuplimentareDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tarifOreSuplimentareDataGridViewTextBoxColumn.Name = "tarifOreSuplimentareDataGridViewTextBoxColumn";
            this.tarifOreSuplimentareDataGridViewTextBoxColumn.Width = 125;
            // 
            // oreContractDataGridViewTextBoxColumn
            // 
            this.oreContractDataGridViewTextBoxColumn.DataPropertyName = "OreContract";
            this.oreContractDataGridViewTextBoxColumn.HeaderText = "OreContract";
            this.oreContractDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oreContractDataGridViewTextBoxColumn.Name = "oreContractDataGridViewTextBoxColumn";
            this.oreContractDataGridViewTextBoxColumn.Width = 125;
            // 
            // oreSuplimentareDataGridViewTextBoxColumn
            // 
            this.oreSuplimentareDataGridViewTextBoxColumn.DataPropertyName = "OreSuplimentare";
            this.oreSuplimentareDataGridViewTextBoxColumn.HeaderText = "OreSuplimentare";
            this.oreSuplimentareDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oreSuplimentareDataGridViewTextBoxColumn.Name = "oreSuplimentareDataGridViewTextBoxColumn";
            this.oreSuplimentareDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalOreDataGridViewTextBoxColumn
            // 
            this.totalOreDataGridViewTextBoxColumn.DataPropertyName = "TotalOre";
            this.totalOreDataGridViewTextBoxColumn.HeaderText = "TotalOre";
            this.totalOreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalOreDataGridViewTextBoxColumn.Name = "totalOreDataGridViewTextBoxColumn";
            this.totalOreDataGridViewTextBoxColumn.Width = 125;
            // 
            // salariuOreContractDataGridViewTextBoxColumn
            // 
            this.salariuOreContractDataGridViewTextBoxColumn.DataPropertyName = "SalariuOreContract";
            this.salariuOreContractDataGridViewTextBoxColumn.HeaderText = "SalariuOreContract";
            this.salariuOreContractDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.salariuOreContractDataGridViewTextBoxColumn.Name = "salariuOreContractDataGridViewTextBoxColumn";
            this.salariuOreContractDataGridViewTextBoxColumn.Width = 125;
            // 
            // salariuOreSuplimentareDataGridViewTextBoxColumn
            // 
            this.salariuOreSuplimentareDataGridViewTextBoxColumn.DataPropertyName = "SalariuOreSuplimentare";
            this.salariuOreSuplimentareDataGridViewTextBoxColumn.HeaderText = "SalariuOreSuplimentare";
            this.salariuOreSuplimentareDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.salariuOreSuplimentareDataGridViewTextBoxColumn.Name = "salariuOreSuplimentareDataGridViewTextBoxColumn";
            this.salariuOreSuplimentareDataGridViewTextBoxColumn.Width = 125;
            // 
            // salariuBrutDataGridViewTextBoxColumn
            // 
            this.salariuBrutDataGridViewTextBoxColumn.DataPropertyName = "SalariuBrut";
            this.salariuBrutDataGridViewTextBoxColumn.HeaderText = "SalariuBrut";
            this.salariuBrutDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.salariuBrutDataGridViewTextBoxColumn.Name = "salariuBrutDataGridViewTextBoxColumn";
            this.salariuBrutDataGridViewTextBoxColumn.Width = 125;
            // 
            // impozitVenitDataGridViewTextBoxColumn
            // 
            this.impozitVenitDataGridViewTextBoxColumn.DataPropertyName = "ImpozitVenit";
            this.impozitVenitDataGridViewTextBoxColumn.HeaderText = "ImpozitVenit";
            this.impozitVenitDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.impozitVenitDataGridViewTextBoxColumn.Name = "impozitVenitDataGridViewTextBoxColumn";
            this.impozitVenitDataGridViewTextBoxColumn.Width = 125;
            // 
            // cASDataGridViewTextBoxColumn
            // 
            this.cASDataGridViewTextBoxColumn.DataPropertyName = "CAS";
            this.cASDataGridViewTextBoxColumn.HeaderText = "CAS";
            this.cASDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cASDataGridViewTextBoxColumn.Name = "cASDataGridViewTextBoxColumn";
            this.cASDataGridViewTextBoxColumn.Width = 125;
            // 
            // cASSDataGridViewTextBoxColumn
            // 
            this.cASSDataGridViewTextBoxColumn.DataPropertyName = "CASS";
            this.cASSDataGridViewTextBoxColumn.HeaderText = "CASS";
            this.cASSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cASSDataGridViewTextBoxColumn.Name = "cASSDataGridViewTextBoxColumn";
            this.cASSDataGridViewTextBoxColumn.Width = 125;
            // 
            // deducerePersonalaDataGridViewTextBoxColumn
            // 
            this.deducerePersonalaDataGridViewTextBoxColumn.DataPropertyName = "DeducerePersonala";
            this.deducerePersonalaDataGridViewTextBoxColumn.HeaderText = "DeducerePersonala";
            this.deducerePersonalaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deducerePersonalaDataGridViewTextBoxColumn.Name = "deducerePersonalaDataGridViewTextBoxColumn";
            this.deducerePersonalaDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalDeducereDataGridViewTextBoxColumn
            // 
            this.totalDeducereDataGridViewTextBoxColumn.DataPropertyName = "TotalDeducere";
            this.totalDeducereDataGridViewTextBoxColumn.HeaderText = "TotalDeducere";
            this.totalDeducereDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalDeducereDataGridViewTextBoxColumn.Name = "totalDeducereDataGridViewTextBoxColumn";
            this.totalDeducereDataGridViewTextBoxColumn.Width = 125;
            // 
            // salariuNetDataGridViewTextBoxColumn
            // 
            this.salariuNetDataGridViewTextBoxColumn.DataPropertyName = "SalariuNet";
            this.salariuNetDataGridViewTextBoxColumn.HeaderText = "SalariuNet";
            this.salariuNetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.salariuNetDataGridViewTextBoxColumn.Name = "salariuNetDataGridViewTextBoxColumn";
            this.salariuNetDataGridViewTextBoxColumn.Width = 125;
            // 
            // platiSalariuBindingSource
            // 
            this.platiSalariuBindingSource.DataMember = "PlatiSalariu";
            this.platiSalariuBindingSource.DataSource = this.calculatorSalariiDataSet4;
            // 
            // calculatorSalariiDataSet4
            // 
            this.calculatorSalariiDataSet4.DataSetName = "CalculatorSalariiDataSet4";
            this.calculatorSalariiDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // platiSalariuTableAdapter
            // 
            this.platiSalariuTableAdapter.ClearBeforeFill = true;
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.CheckedState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.CustomImages.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton1.DisabledState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.FillColor = System.Drawing.Color.YellowGreen;
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.HoverState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Location = new System.Drawing.Point(-2, 451);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.ShadowDecoration.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Size = new System.Drawing.Size(427, 121);
            this.guna2CircleButton1.TabIndex = 0;
            // 
            // guna2CircleButton2
            // 
            this.guna2CircleButton2.CheckedState.Parent = this.guna2CircleButton2;
            this.guna2CircleButton2.CustomImages.Parent = this.guna2CircleButton2;
            this.guna2CircleButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton2.DisabledState.Parent = this.guna2CircleButton2;
            this.guna2CircleButton2.FillColor = System.Drawing.Color.Aqua;
            this.guna2CircleButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton2.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton2.HoverState.Parent = this.guna2CircleButton2;
            this.guna2CircleButton2.Location = new System.Drawing.Point(-74, -52);
            this.guna2CircleButton2.Name = "guna2CircleButton2";
            this.guna2CircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton2.ShadowDecoration.Parent = this.guna2CircleButton2;
            this.guna2CircleButton2.Size = new System.Drawing.Size(317, 112);
            this.guna2CircleButton2.TabIndex = 4;
            // 
            // guna2CircleButton3
            // 
            this.guna2CircleButton3.CheckedState.Parent = this.guna2CircleButton3;
            this.guna2CircleButton3.CustomImages.Parent = this.guna2CircleButton3;
            this.guna2CircleButton3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton3.DisabledState.Parent = this.guna2CircleButton3;
            this.guna2CircleButton3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2CircleButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton3.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton3.HoverState.Parent = this.guna2CircleButton3;
            this.guna2CircleButton3.Location = new System.Drawing.Point(899, 62);
            this.guna2CircleButton3.Name = "guna2CircleButton3";
            this.guna2CircleButton3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton3.ShadowDecoration.Parent = this.guna2CircleButton3;
            this.guna2CircleButton3.Size = new System.Drawing.Size(151, 261);
            this.guna2CircleButton3.TabIndex = 5;
            // 
            // guna2CircleButton4
            // 
            this.guna2CircleButton4.CheckedState.Parent = this.guna2CircleButton4;
            this.guna2CircleButton4.CustomImages.Parent = this.guna2CircleButton4;
            this.guna2CircleButton4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton4.DisabledState.Parent = this.guna2CircleButton4;
            this.guna2CircleButton4.FillColor = System.Drawing.Color.SlateBlue;
            this.guna2CircleButton4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton4.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton4.HoverState.Parent = this.guna2CircleButton4;
            this.guna2CircleButton4.Location = new System.Drawing.Point(419, -68);
            this.guna2CircleButton4.Name = "guna2CircleButton4";
            this.guna2CircleButton4.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton4.ShadowDecoration.Parent = this.guna2CircleButton4;
            this.guna2CircleButton4.Size = new System.Drawing.Size(299, 112);
            this.guna2CircleButton4.TabIndex = 6;
            // 
            // guna2CircleButton5
            // 
            this.guna2CircleButton5.CheckedState.Parent = this.guna2CircleButton5;
            this.guna2CircleButton5.CustomImages.Parent = this.guna2CircleButton5;
            this.guna2CircleButton5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton5.DisabledState.Parent = this.guna2CircleButton5;
            this.guna2CircleButton5.FillColor = System.Drawing.Color.Gold;
            this.guna2CircleButton5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton5.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton5.HoverState.Parent = this.guna2CircleButton5;
            this.guna2CircleButton5.Location = new System.Drawing.Point(899, 432);
            this.guna2CircleButton5.Name = "guna2CircleButton5";
            this.guna2CircleButton5.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton5.ShadowDecoration.Parent = this.guna2CircleButton5;
            this.guna2CircleButton5.Size = new System.Drawing.Size(67, 189);
            this.guna2CircleButton5.TabIndex = 7;
            // 
            // FrmRapoarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(134)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(940, 523);
            this.Controls.Add(this.guna2CircleButton5);
            this.Controls.Add(this.guna2CircleButton4);
            this.Controls.Add(this.guna2CircleButton3);
            this.Controls.Add(this.guna2CircleButton2);
            this.Controls.Add(this.guna2CircleButton1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRapoarteExportExcel);
            this.Controls.Add(this.btninchide);
            this.Controls.Add(this.lblRapoarte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRapoarte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rapoarte";
            this.Load += new System.EventHandler(this.FrmRapoarte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.platiSalariuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculatorSalariiDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRapoarte;
        private System.Windows.Forms.Button btninchide;
        private System.Windows.Forms.Button btnRapoarteExportExcel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CalculatorSalariiDataSet4 calculatorSalariiDataSet4;
        private System.Windows.Forms.BindingSource platiSalariuBindingSource;
        private CalculatorSalariiDataSet4TableAdapters.PlatiSalariuTableAdapter platiSalariuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn plataSalariuIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn angajatIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPlatiiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodaPlataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lunaPlataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarifOrarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarifOreSuplimentareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oreContractDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oreSuplimentareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalOreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salariuOreContractDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salariuOreSuplimentareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salariuBrutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn impozitVenitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cASDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cASSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deducerePersonalaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDeducereDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salariuNetDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton2;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton3;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton4;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton5;
    }
}
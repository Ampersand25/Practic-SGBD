namespace SucuriNaturaleWindowsFormsApplication
{
    partial class SucuriNaturaleMasterDetailForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.parentDataGridView = new System.Windows.Forms.DataGridView();
            this.childDataGridView = new System.Windows.Forms.DataGridView();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.dataExpirareDatePicker = new System.Windows.Forms.DateTimePicker();
            this.dataExpirareLbl = new System.Windows.Forms.Label();
            this.pretNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.pretLbl = new System.Windows.Forms.Label();
            this.gramajNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.producatorInput = new System.Windows.Forms.TextBox();
            this.sidNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.sidLbl = new System.Windows.Forms.Label();
            this.TSidComboBox = new System.Windows.Forms.ComboBox();
            this.denumireInput = new System.Windows.Forms.TextBox();
            this.TSidLbl = new System.Windows.Forms.Label();
            this.gramajLbl = new System.Windows.Forms.Label();
            this.producatorLbl = new System.Windows.Forms.Label();
            this.denumireLbl = new System.Windows.Forms.Label();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.stergereBtn = new System.Windows.Forms.Button();
            this.modificareBtn = new System.Windows.Forms.Button();
            this.adaugareBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.parentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.childDataGridView)).BeginInit();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pretNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gramajNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sidNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // parentDataGridView
            // 
            this.parentDataGridView.AllowUserToAddRows = false;
            this.parentDataGridView.AllowUserToDeleteRows = false;
            this.parentDataGridView.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.parentDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.parentDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Orbitron ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.parentDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.parentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Orbitron", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.parentDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.parentDataGridView.GridColor = System.Drawing.Color.DarkOrange;
            this.parentDataGridView.Location = new System.Drawing.Point(12, 234);
            this.parentDataGridView.Name = "parentDataGridView";
            this.parentDataGridView.ReadOnly = true;
            this.parentDataGridView.RowHeadersWidth = 62;
            this.parentDataGridView.RowTemplate.Height = 28;
            this.parentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.parentDataGridView.Size = new System.Drawing.Size(675, 448);
            this.parentDataGridView.TabIndex = 0;
            this.parentDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.parentDataGridView_CellClick);
            // 
            // childDataGridView
            // 
            this.childDataGridView.AllowUserToAddRows = false;
            this.childDataGridView.AllowUserToDeleteRows = false;
            this.childDataGridView.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.childDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.childDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Orbitron ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.childDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.childDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Orbitron", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.childDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.childDataGridView.GridColor = System.Drawing.Color.DarkOrange;
            this.childDataGridView.Location = new System.Drawing.Point(12, 12);
            this.childDataGridView.Name = "childDataGridView";
            this.childDataGridView.ReadOnly = true;
            this.childDataGridView.RowHeadersWidth = 62;
            this.childDataGridView.RowTemplate.Height = 28;
            this.childDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.childDataGridView.Size = new System.Drawing.Size(1354, 184);
            this.childDataGridView.TabIndex = 1;
            this.childDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.childDataGridView_CellClick);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.PeachPuff;
            this.mainPanel.Controls.Add(this.dataExpirareDatePicker);
            this.mainPanel.Controls.Add(this.dataExpirareLbl);
            this.mainPanel.Controls.Add(this.pretNumericUpDown);
            this.mainPanel.Controls.Add(this.pretLbl);
            this.mainPanel.Controls.Add(this.gramajNumericUpDown);
            this.mainPanel.Controls.Add(this.producatorInput);
            this.mainPanel.Controls.Add(this.sidNumericUpDown);
            this.mainPanel.Controls.Add(this.sidLbl);
            this.mainPanel.Controls.Add(this.TSidComboBox);
            this.mainPanel.Controls.Add(this.denumireInput);
            this.mainPanel.Controls.Add(this.TSidLbl);
            this.mainPanel.Controls.Add(this.gramajLbl);
            this.mainPanel.Controls.Add(this.producatorLbl);
            this.mainPanel.Controls.Add(this.denumireLbl);
            this.mainPanel.Controls.Add(this.refreshBtn);
            this.mainPanel.Controls.Add(this.stergereBtn);
            this.mainPanel.Controls.Add(this.modificareBtn);
            this.mainPanel.Controls.Add(this.adaugareBtn);
            this.mainPanel.Location = new System.Drawing.Point(736, 234);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(630, 448);
            this.mainPanel.TabIndex = 2;
            // 
            // dataExpirareDatePicker
            // 
            this.dataExpirareDatePicker.CalendarFont = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataExpirareDatePicker.Font = new System.Drawing.Font("Orbitron", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataExpirareDatePicker.Location = new System.Drawing.Point(217, 297);
            this.dataExpirareDatePicker.Name = "dataExpirareDatePicker";
            this.dataExpirareDatePicker.Size = new System.Drawing.Size(399, 33);
            this.dataExpirareDatePicker.TabIndex = 21;
            // 
            // dataExpirareLbl
            // 
            this.dataExpirareLbl.AutoSize = true;
            this.dataExpirareLbl.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataExpirareLbl.Location = new System.Drawing.Point(9, 300);
            this.dataExpirareLbl.Name = "dataExpirareLbl";
            this.dataExpirareLbl.Size = new System.Drawing.Size(202, 30);
            this.dataExpirareLbl.TabIndex = 20;
            this.dataExpirareLbl.Text = "Data expirare";
            // 
            // pretNumericUpDown
            // 
            this.pretNumericUpDown.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pretNumericUpDown.Font = new System.Drawing.Font("Orbitron", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pretNumericUpDown.Location = new System.Drawing.Point(217, 245);
            this.pretNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.pretNumericUpDown.Name = "pretNumericUpDown";
            this.pretNumericUpDown.Size = new System.Drawing.Size(399, 33);
            this.pretNumericUpDown.TabIndex = 19;
            // 
            // pretLbl
            // 
            this.pretLbl.AutoSize = true;
            this.pretLbl.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pretLbl.Location = new System.Drawing.Point(9, 245);
            this.pretLbl.Name = "pretLbl";
            this.pretLbl.Size = new System.Drawing.Size(73, 30);
            this.pretLbl.TabIndex = 18;
            this.pretLbl.Text = "Pret";
            // 
            // gramajNumericUpDown
            // 
            this.gramajNumericUpDown.BackColor = System.Drawing.SystemColors.HighlightText;
            this.gramajNumericUpDown.Font = new System.Drawing.Font("Orbitron", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gramajNumericUpDown.Location = new System.Drawing.Point(217, 190);
            this.gramajNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.gramajNumericUpDown.Name = "gramajNumericUpDown";
            this.gramajNumericUpDown.Size = new System.Drawing.Size(399, 33);
            this.gramajNumericUpDown.TabIndex = 17;
            // 
            // producatorInput
            // 
            this.producatorInput.BackColor = System.Drawing.SystemColors.HighlightText;
            this.producatorInput.Font = new System.Drawing.Font("Orbitron", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.producatorInput.Location = new System.Drawing.Point(217, 130);
            this.producatorInput.Name = "producatorInput";
            this.producatorInput.Size = new System.Drawing.Size(399, 33);
            this.producatorInput.TabIndex = 16;
            // 
            // sidNumericUpDown
            // 
            this.sidNumericUpDown.BackColor = System.Drawing.SystemColors.HighlightText;
            this.sidNumericUpDown.Font = new System.Drawing.Font("Orbitron", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sidNumericUpDown.Location = new System.Drawing.Point(217, 12);
            this.sidNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.sidNumericUpDown.Name = "sidNumericUpDown";
            this.sidNumericUpDown.Size = new System.Drawing.Size(399, 33);
            this.sidNumericUpDown.TabIndex = 13;
            // 
            // sidLbl
            // 
            this.sidLbl.AutoSize = true;
            this.sidLbl.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sidLbl.Location = new System.Drawing.Point(9, 12);
            this.sidLbl.Name = "sidLbl";
            this.sidLbl.Size = new System.Drawing.Size(54, 30);
            this.sidLbl.TabIndex = 12;
            this.sidLbl.Text = "Sid";
            // 
            // TSidComboBox
            // 
            this.TSidComboBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.TSidComboBox.Font = new System.Drawing.Font("Orbitron", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSidComboBox.FormattingEnabled = true;
            this.TSidComboBox.Location = new System.Drawing.Point(217, 342);
            this.TSidComboBox.Name = "TSidComboBox";
            this.TSidComboBox.Size = new System.Drawing.Size(399, 33);
            this.TSidComboBox.TabIndex = 10;
            // 
            // denumireInput
            // 
            this.denumireInput.BackColor = System.Drawing.SystemColors.HighlightText;
            this.denumireInput.Font = new System.Drawing.Font("Orbitron", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.denumireInput.Location = new System.Drawing.Point(217, 70);
            this.denumireInput.Name = "denumireInput";
            this.denumireInput.Size = new System.Drawing.Size(399, 33);
            this.denumireInput.TabIndex = 8;
            // 
            // TSidLbl
            // 
            this.TSidLbl.AutoSize = true;
            this.TSidLbl.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSidLbl.Location = new System.Drawing.Point(10, 350);
            this.TSidLbl.Name = "TSidLbl";
            this.TSidLbl.Size = new System.Drawing.Size(72, 30);
            this.TSidLbl.TabIndex = 7;
            this.TSidLbl.Text = "TSid";
            // 
            // gramajLbl
            // 
            this.gramajLbl.AutoSize = true;
            this.gramajLbl.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gramajLbl.Location = new System.Drawing.Point(9, 190);
            this.gramajLbl.Name = "gramajLbl";
            this.gramajLbl.Size = new System.Drawing.Size(108, 30);
            this.gramajLbl.TabIndex = 6;
            this.gramajLbl.Text = "Gramaj";
            // 
            // producatorLbl
            // 
            this.producatorLbl.AutoSize = true;
            this.producatorLbl.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.producatorLbl.Location = new System.Drawing.Point(9, 130);
            this.producatorLbl.Name = "producatorLbl";
            this.producatorLbl.Size = new System.Drawing.Size(169, 30);
            this.producatorLbl.TabIndex = 5;
            this.producatorLbl.Text = "Producator";
            // 
            // denumireLbl
            // 
            this.denumireLbl.AutoSize = true;
            this.denumireLbl.Font = new System.Drawing.Font("Orbitron", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.denumireLbl.Location = new System.Drawing.Point(9, 70);
            this.denumireLbl.Name = "denumireLbl";
            this.denumireLbl.Size = new System.Drawing.Size(143, 30);
            this.denumireLbl.TabIndex = 4;
            this.denumireLbl.Text = "Denumire";
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.refreshBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshBtn.Font = new System.Drawing.Font("Orbitron ExtraBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn.Location = new System.Drawing.Point(488, 391);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(138, 54);
            this.refreshBtn.TabIndex = 3;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // stergereBtn
            // 
            this.stergereBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.stergereBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stergereBtn.Font = new System.Drawing.Font("Orbitron ExtraBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stergereBtn.Location = new System.Drawing.Point(318, 391);
            this.stergereBtn.Name = "stergereBtn";
            this.stergereBtn.Size = new System.Drawing.Size(164, 54);
            this.stergereBtn.TabIndex = 2;
            this.stergereBtn.Text = "Stergere";
            this.stergereBtn.UseVisualStyleBackColor = false;
            this.stergereBtn.Click += new System.EventHandler(this.stergereBtn_Click);
            // 
            // modificareBtn
            // 
            this.modificareBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.modificareBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modificareBtn.Font = new System.Drawing.Font("Orbitron ExtraBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificareBtn.Location = new System.Drawing.Point(162, 391);
            this.modificareBtn.Name = "modificareBtn";
            this.modificareBtn.Size = new System.Drawing.Size(150, 54);
            this.modificareBtn.TabIndex = 1;
            this.modificareBtn.Text = "Modificare";
            this.modificareBtn.UseVisualStyleBackColor = false;
            this.modificareBtn.Click += new System.EventHandler(this.modificareBtn_Click);
            // 
            // adaugareBtn
            // 
            this.adaugareBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.adaugareBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adaugareBtn.Font = new System.Drawing.Font("Orbitron ExtraBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adaugareBtn.Location = new System.Drawing.Point(5, 391);
            this.adaugareBtn.Name = "adaugareBtn";
            this.adaugareBtn.Size = new System.Drawing.Size(151, 54);
            this.adaugareBtn.TabIndex = 0;
            this.adaugareBtn.Text = "Adaugare";
            this.adaugareBtn.UseVisualStyleBackColor = false;
            this.adaugareBtn.Click += new System.EventHandler(this.adaugareBtn_Click);
            // 
            // SucuriNaturaleMasterDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(1378, 694);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.childDataGridView);
            this.Controls.Add(this.parentDataGridView);
            this.Name = "SucuriNaturaleMasterDetailForm";
            this.Text = "SucuriNaturaleForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MasterDetailsForm_FormClosing);
            this.Load += new System.EventHandler(this.SucuriNaturaleMasterDetailWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.parentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.childDataGridView)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pretNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gramajNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sidNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView parentDataGridView;
        private System.Windows.Forms.DataGridView childDataGridView;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button stergereBtn;
        private System.Windows.Forms.Button modificareBtn;
        private System.Windows.Forms.Button adaugareBtn;
        private System.Windows.Forms.Label TSidLbl;
        private System.Windows.Forms.Label gramajLbl;
        private System.Windows.Forms.Label producatorLbl;
        private System.Windows.Forms.Label denumireLbl;
        private System.Windows.Forms.ComboBox TSidComboBox;
        private System.Windows.Forms.TextBox denumireInput;
        private System.Windows.Forms.NumericUpDown sidNumericUpDown;
        private System.Windows.Forms.Label sidLbl;
        private System.Windows.Forms.TextBox producatorInput;
        private System.Windows.Forms.NumericUpDown gramajNumericUpDown;
        private System.Windows.Forms.NumericUpDown pretNumericUpDown;
        private System.Windows.Forms.Label pretLbl;
        private System.Windows.Forms.DateTimePicker dataExpirareDatePicker;
        private System.Windows.Forms.Label dataExpirareLbl;
    }
}


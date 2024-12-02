namespace Responsi2Junpro
{
    partial class FormHome
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
            tbNama = new TextBox();
            lblNama = new Label();
            lblDep = new Label();
            btnInsert = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            dgvData = new DataGridView();
            cbDepartemen = new ComboBox();
            lblLogo = new Label();
            pnlImage = new Panel();
            tbDep = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // tbNama
            // 
            tbNama.Location = new Point(139, 108);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(154, 23);
            tbNama.TabIndex = 0;
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Location = new Point(39, 111);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(99, 15);
            lblNama.TabIndex = 2;
            lblNama.Text = "Nama Karyawan :";
            // 
            // lblDep
            // 
            lblDep.AutoSize = true;
            lblDep.Location = new Point(39, 177);
            lblDep.Name = "lblDep";
            lblDep.Size = new Size(91, 15);
            lblDep.TabIndex = 3;
            lblDep.Text = "Dep. Karyawan :";
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(39, 233);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(99, 23);
            btnInsert.TabIndex = 4;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(247, 233);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(87, 23);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(444, 233);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(88, 23);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(39, 276);
            dgvData.Name = "dgvData";
            dgvData.RowTemplate.Height = 25;
            dgvData.Size = new Size(528, 150);
            dgvData.TabIndex = 7;
            dgvData.CellContentClick += dgvData_CellContentClick;
            // 
            // cbDepartemen
            // 
            cbDepartemen.FormattingEnabled = true;
            cbDepartemen.Location = new Point(139, 174);
            cbDepartemen.Name = "cbDepartemen";
            cbDepartemen.Size = new Size(154, 23);
            cbDepartemen.TabIndex = 8;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Location = new Point(118, 40);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(37, 15);
            lblLogo.TabIndex = 9;
            lblLogo.Text = "Logo ";
            // 
            // pnlImage
            // 
            pnlImage.Location = new Point(39, 23);
            pnlImage.Name = "pnlImage";
            pnlImage.Size = new Size(61, 49);
            pnlImage.TabIndex = 10;
            // 
            // tbDep
            // 
            tbDep.Location = new Point(315, 174);
            tbDep.Name = "tbDep";
            tbDep.Size = new Size(154, 23);
            tbDep.TabIndex = 11;
            // 
            // FormHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 460);
            Controls.Add(tbDep);
            Controls.Add(pnlImage);
            Controls.Add(lblLogo);
            Controls.Add(cbDepartemen);
            Controls.Add(dgvData);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnInsert);
            Controls.Add(lblDep);
            Controls.Add(lblNama);
            Controls.Add(tbNama);
            Name = "FormHome";
            Text = "FormHome";
            Load += FormHome_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbNama;
        private Label lblNama;
        private Label lblDep;
        private Button btnInsert;
        private Button btnEdit;
        private Button btnDelete;
        private DataGridView dgvData;
        private ComboBox cbDepartemen;
        private Label lblLogo;
        private Panel pnlImage;
        private TextBox tbDep;
    }
}
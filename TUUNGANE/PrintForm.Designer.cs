namespace TUUNGANE
{
    partial class PrintForm
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
            this.dtDebut = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFin = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnLoad = new System.Windows.Forms.Button();
            this.Btnprint = new System.Windows.Forms.Button();
            this.studentsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postNomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datedeNaissanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lieudeNaissanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomdupereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomdelamereDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtDebut
            // 
            this.dtDebut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDebut.Location = new System.Drawing.Point(172, 39);
            this.dtDebut.Name = "dtDebut";
            this.dtDebut.Size = new System.Drawing.Size(96, 20);
            this.dtDebut.TabIndex = 0;
            this.dtDebut.Value = new System.DateTime(2019, 6, 21, 8, 37, 56, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Debut echeance";
            // 
            // dtFin
            // 
            this.dtFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFin.Location = new System.Drawing.Point(379, 39);
            this.dtFin.Name = "dtFin";
            this.dtFin.Size = new System.Drawing.Size(96, 20);
            this.dtFin.TabIndex = 0;
            this.dtFin.Value = new System.DateTime(2019, 6, 21, 8, 37, 56, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(278, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fin echeance";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.postNomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.datedeNaissanceDataGridViewTextBoxColumn,
            this.classDataGridViewTextBoxColumn,
            this.lieudeNaissanceDataGridViewTextBoxColumn,
            this.nomdupereDataGridViewTextBoxColumn,
            this.nomdelamereDataGridViewTextBoxColumn,
            this.tutelDataGridViewTextBoxColumn,
            this.telephoneDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.photosDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentsBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(17, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(754, 379);
            this.dataGridView1.TabIndex = 2;
            // 
            // BtnLoad
            // 
            this.BtnLoad.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoad.Location = new System.Drawing.Point(533, 31);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(95, 33);
            this.BtnLoad.TabIndex = 3;
            this.BtnLoad.Text = "Actualiser";
            this.BtnLoad.UseVisualStyleBackColor = true;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // Btnprint
            // 
            this.Btnprint.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnprint.Location = new System.Drawing.Point(676, 485);
            this.Btnprint.Name = "Btnprint";
            this.Btnprint.Size = new System.Drawing.Size(95, 33);
            this.Btnprint.TabIndex = 3;
            this.Btnprint.Text = "Imprimer";
            this.Btnprint.UseVisualStyleBackColor = true;
            // 
            // studentsBindingSource1
            // 
            this.studentsBindingSource1.DataSource = typeof(TUUNGANE.Students);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            // 
            // postNomDataGridViewTextBoxColumn
            // 
            this.postNomDataGridViewTextBoxColumn.DataPropertyName = "PostNom";
            this.postNomDataGridViewTextBoxColumn.HeaderText = "PostNom";
            this.postNomDataGridViewTextBoxColumn.Name = "postNomDataGridViewTextBoxColumn";
            // 
            // prenomDataGridViewTextBoxColumn
            // 
            this.prenomDataGridViewTextBoxColumn.DataPropertyName = "Prenom";
            this.prenomDataGridViewTextBoxColumn.HeaderText = "Prenom";
            this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "Sex";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            // 
            // datedeNaissanceDataGridViewTextBoxColumn
            // 
            this.datedeNaissanceDataGridViewTextBoxColumn.DataPropertyName = "Date_de_Naissance";
            this.datedeNaissanceDataGridViewTextBoxColumn.HeaderText = "Date_de_Naissance";
            this.datedeNaissanceDataGridViewTextBoxColumn.Name = "datedeNaissanceDataGridViewTextBoxColumn";
            // 
            // classDataGridViewTextBoxColumn
            // 
            this.classDataGridViewTextBoxColumn.DataPropertyName = "Class";
            this.classDataGridViewTextBoxColumn.HeaderText = "Class";
            this.classDataGridViewTextBoxColumn.Name = "classDataGridViewTextBoxColumn";
            // 
            // lieudeNaissanceDataGridViewTextBoxColumn
            // 
            this.lieudeNaissanceDataGridViewTextBoxColumn.DataPropertyName = "Lieu_de_Naissance";
            this.lieudeNaissanceDataGridViewTextBoxColumn.HeaderText = "Lieu_de_Naissance";
            this.lieudeNaissanceDataGridViewTextBoxColumn.Name = "lieudeNaissanceDataGridViewTextBoxColumn";
            // 
            // nomdupereDataGridViewTextBoxColumn
            // 
            this.nomdupereDataGridViewTextBoxColumn.DataPropertyName = "Nom_du_pere";
            this.nomdupereDataGridViewTextBoxColumn.HeaderText = "Nom_du_pere";
            this.nomdupereDataGridViewTextBoxColumn.Name = "nomdupereDataGridViewTextBoxColumn";
            // 
            // nomdelamereDataGridViewTextBoxColumn
            // 
            this.nomdelamereDataGridViewTextBoxColumn.DataPropertyName = "Nom_de_la_mere";
            this.nomdelamereDataGridViewTextBoxColumn.HeaderText = "Nom_de_la_mere";
            this.nomdelamereDataGridViewTextBoxColumn.Name = "nomdelamereDataGridViewTextBoxColumn";
            // 
            // tutelDataGridViewTextBoxColumn
            // 
            this.tutelDataGridViewTextBoxColumn.DataPropertyName = "Tutel";
            this.tutelDataGridViewTextBoxColumn.HeaderText = "Tutel";
            this.tutelDataGridViewTextBoxColumn.Name = "tutelDataGridViewTextBoxColumn";
            // 
            // telephoneDataGridViewTextBoxColumn
            // 
            this.telephoneDataGridViewTextBoxColumn.DataPropertyName = "Telephone";
            this.telephoneDataGridViewTextBoxColumn.HeaderText = "Telephone";
            this.telephoneDataGridViewTextBoxColumn.Name = "telephoneDataGridViewTextBoxColumn";
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "mail";
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            // 
            // photosDataGridViewTextBoxColumn
            // 
            this.photosDataGridViewTextBoxColumn.DataPropertyName = "Photos";
            this.photosDataGridViewTextBoxColumn.HeaderText = "Photos";
            this.photosDataGridViewTextBoxColumn.Name = "photosDataGridViewTextBoxColumn";
            // 
            // PrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 530);
            this.Controls.Add(this.Btnprint);
            this.Controls.Add(this.BtnLoad);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtFin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtDebut);
            this.Name = "PrintForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " PrintForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtDebut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtFin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnLoad;
        private System.Windows.Forms.Button Btnprint;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postNomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datedeNaissanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lieudeNaissanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomdupereDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomdelamereDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn photosDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource studentsBindingSource1;
    }
}
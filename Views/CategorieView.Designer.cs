namespace Supermarket_mvp.Views
{
    partial class CategorieView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategorieView));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lbl1 = new Label();
            tabControl1 = new TabControl();
            tabPageCategorieList = new TabPage();
            tabPageCategorieDetail = new TabPage();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            label1 = new Label();
            DgCategorie = new DataGridView();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            label2 = new Label();
            TxtCategorieId = new TextBox();
            TxtCategorieName = new TextBox();
            label3 = new Label();
            TxtCategorieObservation = new TextBox();
            label4 = new Label();
            BtnCancel = new Button();
            BtnSave = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageCategorieList.SuspendLayout();
            tabPageCategorieDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgCategorie).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lbl1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 100);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.categorias;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.BackColor = SystemColors.Control;
            lbl1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl1.Location = new Point(127, 23);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(95, 21);
            lbl1.TabIndex = 1;
            lbl1.Text = "CATEGORIE";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageCategorieList);
            tabControl1.Controls.Add(tabPageCategorieDetail);
            tabControl1.Location = new Point(12, 106);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 332);
            tabControl1.TabIndex = 3;
            // 
            // tabPageCategorieList
            // 
            tabPageCategorieList.Controls.Add(BtnClose);
            tabPageCategorieList.Controls.Add(BtnDelete);
            tabPageCategorieList.Controls.Add(BtnEdit);
            tabPageCategorieList.Controls.Add(BtnNew);
            tabPageCategorieList.Controls.Add(DgCategorie);
            tabPageCategorieList.Controls.Add(BtnSearch);
            tabPageCategorieList.Controls.Add(TxtSearch);
            tabPageCategorieList.Controls.Add(label1);
            tabPageCategorieList.Location = new Point(4, 24);
            tabPageCategorieList.Name = "tabPageCategorieList";
            tabPageCategorieList.Padding = new Padding(3);
            tabPageCategorieList.Size = new Size(768, 304);
            tabPageCategorieList.TabIndex = 0;
            tabPageCategorieList.Text = "Categorie List";
            tabPageCategorieList.UseVisualStyleBackColor = true;
            // 
            // tabPageCategorieDetail
            // 
            tabPageCategorieDetail.Controls.Add(BtnCancel);
            tabPageCategorieDetail.Controls.Add(BtnSave);
            tabPageCategorieDetail.Controls.Add(TxtCategorieObservation);
            tabPageCategorieDetail.Controls.Add(label4);
            tabPageCategorieDetail.Controls.Add(TxtCategorieName);
            tabPageCategorieDetail.Controls.Add(label3);
            tabPageCategorieDetail.Controls.Add(TxtCategorieId);
            tabPageCategorieDetail.Controls.Add(label2);
            tabPageCategorieDetail.Location = new Point(4, 24);
            tabPageCategorieDetail.Name = "tabPageCategorieDetail";
            tabPageCategorieDetail.Padding = new Padding(3);
            tabPageCategorieDetail.Size = new Size(768, 304);
            tabPageCategorieDetail.TabIndex = 1;
            tabPageCategorieDetail.Text = "Categorie Detail";
            tabPageCategorieDetail.UseVisualStyleBackColor = true;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(466, 10);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(38, 44);
            BtnSearch.TabIndex = 8;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearch.Location = new Point(11, 31);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(428, 23);
            TxtSearch.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(6, 3);
            label1.Name = "label1";
            label1.Size = new Size(169, 21);
            label1.TabIndex = 6;
            label1.Text = "SEARCH CATEGORIES";
            // 
            // DgCategorie
            // 
            DgCategorie.AllowUserToAddRows = false;
            DgCategorie.AllowUserToDeleteRows = false;
            DgCategorie.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgCategorie.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgCategorie.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgCategorie.Location = new Point(12, 63);
            DgCategorie.Name = "DgCategorie";
            DgCategorie.ReadOnly = true;
            DgCategorie.RowTemplate.Height = 25;
            DgCategorie.Size = new Size(427, 223);
            DgCategorie.TabIndex = 9;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(522, 232);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(199, 59);
            BtnClose.TabIndex = 15;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(522, 156);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(199, 64);
            BtnDelete.TabIndex = 14;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.Image = (Image)resources.GetObject("BtnEdit.Image");
            BtnEdit.Location = new Point(522, 90);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(199, 62);
            BtnEdit.TabIndex = 13;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.Image = (Image)resources.GetObject("BtnNew.Image");
            BtnNew.Location = new Point(522, 22);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(199, 65);
            BtnNew.TabIndex = 12;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(10, 13);
            label2.Name = "label2";
            label2.Size = new Size(116, 21);
            label2.TabIndex = 3;
            label2.Text = "CATEGORIE ID";
            // 
            // TxtCategorieId
            // 
            TxtCategorieId.Location = new Point(13, 37);
            TxtCategorieId.Name = "TxtCategorieId";
            TxtCategorieId.Size = new Size(193, 23);
            TxtCategorieId.TabIndex = 4;
            TxtCategorieId.Text = "0";
            TxtCategorieId.TextAlign = HorizontalAlignment.Right;
            // 
            // TxtCategorieName
            // 
            TxtCategorieName.Location = new Point(13, 97);
            TxtCategorieName.Name = "TxtCategorieName";
            TxtCategorieName.PlaceholderText = "CategorieName";
            TxtCategorieName.Size = new Size(193, 23);
            TxtCategorieName.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(13, 73);
            label3.Name = "label3";
            label3.Size = new Size(147, 21);
            label3.TabIndex = 6;
            label3.Text = "CATEGORIE NAME";
            // 
            // TxtCategorieObservation
            // 
            TxtCategorieObservation.Location = new Point(13, 158);
            TxtCategorieObservation.Multiline = true;
            TxtCategorieObservation.Name = "TxtCategorieObservation";
            TxtCategorieObservation.PlaceholderText = "Categorie Observation";
            TxtCategorieObservation.Size = new Size(226, 98);
            TxtCategorieObservation.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(13, 134);
            label4.Name = "label4";
            label4.Size = new Size(208, 21);
            label4.TabIndex = 8;
            label4.Text = "CATEGORIE OBSERVATION\r\n";
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(476, 110);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(75, 45);
            BtnCancel.TabIndex = 12;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(331, 110);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(75, 45);
            BtnSave.TabIndex = 11;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // CategorieView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "CategorieView";
            Text = "CategorieView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageCategorieList.ResumeLayout(false);
            tabPageCategorieList.PerformLayout();
            tabPageCategorieDetail.ResumeLayout(false);
            tabPageCategorieDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgCategorie).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lbl1;
        private TabControl tabControl1;
        private TabPage tabPageCategorieList;
        private TabPage tabPageCategorieDetail;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private Label label1;
        private DataGridView DgCategorie;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private Label label2;
        private TextBox TxtCategorieId;
        private TextBox TxtCategorieName;
        private Label label3;
        private TextBox TxtCategorieObservation;
        private Label label4;
        private Button BtnCancel;
        private Button BtnSave;
    }
}
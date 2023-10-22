namespace Supermarket_mvp.Views
{
    partial class ProviderView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProviderView));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lbl1 = new Label();
            tabControl1 = new TabControl();
            tabPageProviderList = new TabPage();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            DgProvider = new DataGridView();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            label1 = new Label();
            tabPageProviderDetail = new TabPage();
            BtnCancel = new Button();
            BtnSave = new Button();
            TxtProviderObservation = new TextBox();
            label4 = new Label();
            TxtProviderName = new TextBox();
            label3 = new Label();
            TxtProviderId = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageProviderList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgProvider).BeginInit();
            tabPageProviderDetail.SuspendLayout();
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
            pictureBox1.Image = Properties.Resources.providers;
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
            lbl1.Size = new Size(98, 21);
            lbl1.TabIndex = 1;
            lbl1.Text = "PROVIDERS";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageProviderList);
            tabControl1.Controls.Add(tabPageProviderDetail);
            tabControl1.Location = new Point(12, 106);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 332);
            tabControl1.TabIndex = 3;
            // 
            // tabPageProviderList
            // 
            tabPageProviderList.Controls.Add(BtnClose);
            tabPageProviderList.Controls.Add(BtnDelete);
            tabPageProviderList.Controls.Add(BtnEdit);
            tabPageProviderList.Controls.Add(BtnNew);
            tabPageProviderList.Controls.Add(DgProvider);
            tabPageProviderList.Controls.Add(BtnSearch);
            tabPageProviderList.Controls.Add(TxtSearch);
            tabPageProviderList.Controls.Add(label1);
            tabPageProviderList.Location = new Point(4, 24);
            tabPageProviderList.Name = "tabPageProviderList";
            tabPageProviderList.Padding = new Padding(3);
            tabPageProviderList.Size = new Size(768, 304);
            tabPageProviderList.TabIndex = 0;
            tabPageProviderList.Text = "Provider List";
            tabPageProviderList.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(494, 235);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(199, 59);
            BtnClose.TabIndex = 15;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(494, 159);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(199, 64);
            BtnDelete.TabIndex = 14;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.Image = (Image)resources.GetObject("BtnEdit.Image");
            BtnEdit.Location = new Point(494, 93);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(199, 62);
            BtnEdit.TabIndex = 13;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.Image = (Image)resources.GetObject("BtnNew.Image");
            BtnNew.Location = new Point(494, 25);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(199, 65);
            BtnNew.TabIndex = 12;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // DgProvider
            // 
            DgProvider.AllowUserToAddRows = false;
            DgProvider.AllowUserToDeleteRows = false;
            DgProvider.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgProvider.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgProvider.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgProvider.Location = new Point(16, 76);
            DgProvider.Name = "DgProvider";
            DgProvider.ReadOnly = true;
            DgProvider.RowTemplate.Height = 25;
            DgProvider.Size = new Size(404, 222);
            DgProvider.TabIndex = 7;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(382, 15);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(38, 44);
            BtnSearch.TabIndex = 6;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Location = new Point(16, 36);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(320, 23);
            TxtSearch.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(16, 12);
            label1.Name = "label1";
            label1.Size = new Size(163, 21);
            label1.TabIndex = 2;
            label1.Text = "SEARCH PROVIDERS";
            // 
            // tabPageProviderDetail
            // 
            tabPageProviderDetail.Controls.Add(BtnCancel);
            tabPageProviderDetail.Controls.Add(BtnSave);
            tabPageProviderDetail.Controls.Add(TxtProviderObservation);
            tabPageProviderDetail.Controls.Add(label4);
            tabPageProviderDetail.Controls.Add(TxtProviderName);
            tabPageProviderDetail.Controls.Add(label3);
            tabPageProviderDetail.Controls.Add(TxtProviderId);
            tabPageProviderDetail.Controls.Add(label2);
            tabPageProviderDetail.Location = new Point(4, 24);
            tabPageProviderDetail.Name = "tabPageProviderDetail";
            tabPageProviderDetail.Padding = new Padding(3);
            tabPageProviderDetail.Size = new Size(768, 304);
            tabPageProviderDetail.TabIndex = 1;
            tabPageProviderDetail.Text = "Provider Detail";
            tabPageProviderDetail.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(489, 114);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(75, 45);
            BtnCancel.TabIndex = 11;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(362, 114);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(75, 45);
            BtnSave.TabIndex = 10;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxtProviderObservation
            // 
            TxtProviderObservation.Location = new Point(21, 171);
            TxtProviderObservation.Multiline = true;
            TxtProviderObservation.Name = "TxtProviderObservation";
            TxtProviderObservation.PlaceholderText = "Provider Observation";
            TxtProviderObservation.Size = new Size(246, 109);
            TxtProviderObservation.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(16, 140);
            label4.Name = "label4";
            label4.Size = new Size(211, 21);
            label4.TabIndex = 6;
            label4.Text = "PROVIDERS OBSERVATION";
            // 
            // TxtProviderName
            // 
            TxtProviderName.Location = new Point(21, 114);
            TxtProviderName.Name = "TxtProviderName";
            TxtProviderName.PlaceholderText = "Provider Name";
            TxtProviderName.Size = new Size(156, 23);
            TxtProviderName.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(16, 83);
            label3.Name = "label3";
            label3.Size = new Size(150, 21);
            label3.TabIndex = 4;
            label3.Text = "PROVIDERS NAME";
            // 
            // TxtProviderId
            // 
            TxtProviderId.Location = new Point(21, 43);
            TxtProviderId.Name = "TxtProviderId";
            TxtProviderId.PlaceholderText = "0";
            TxtProviderId.Size = new Size(156, 23);
            TxtProviderId.TabIndex = 3;
            TxtProviderId.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(16, 12);
            label2.Name = "label2";
            label2.Size = new Size(119, 21);
            label2.TabIndex = 2;
            label2.Text = "PROVIDERS ID";
            // 
            // ProviderView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "ProviderView";
            Text = "ProviderView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageProviderList.ResumeLayout(false);
            tabPageProviderList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgProvider).EndInit();
            tabPageProviderDetail.ResumeLayout(false);
            tabPageProviderDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lbl1;
        private TabControl tabControl1;
        private TabPage tabPageProviderList;
        private TabPage tabPageProviderDetail;
        private TextBox TxtSearch;
        private Label label1;
        private DataGridView DgProvider;
        private Button BtnSearch;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private TextBox TxtProviderId;
        private Label label2;
        private TextBox TxtProviderName;
        private Label label3;
        private TextBox TxtProviderObservation;
        private Label label4;
        private Button BtnSave;
        private Button BtnCancel;
    }
}
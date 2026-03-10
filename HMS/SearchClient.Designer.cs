namespace HMS
{
    partial class SearchClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchClient));
            label1 = new Label();
            key = new TextBox();
            findBtn = new Button();
            dataGridViewAllclients = new DataGridView();
            label2 = new Label();
            groupBoxSearch = new GroupBox();
            radioButtonCname = new RadioButton();
            radioButtonCphoneNumber = new RadioButton();
            radioButtonCid = new RadioButton();
            pictureBox1 = new PictureBox();
            dataGridViewSearchResult = new DataGridView();
            label3 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllclients).BeginInit();
            groupBoxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSearchResult).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("JetBrains Mono", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(145, 75);
            label1.Name = "label1";
            label1.Size = new Size(839, 44);
            label1.TabIndex = 0;
            label1.Text = "Search Client by ID / Phone Number / Name";
            // 
            // key
            // 
            key.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            key.Location = new Point(145, 513);
            key.Name = "key";
            key.Size = new Size(517, 51);
            key.TabIndex = 1;
            // 
            // findBtn
            // 
            findBtn.BackColor = Color.Teal;
            findBtn.Font = new Font("JetBrains Mono", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            findBtn.Location = new Point(684, 513);
            findBtn.Name = "findBtn";
            findBtn.Size = new Size(173, 51);
            findBtn.TabIndex = 2;
            findBtn.Text = "F I N D";
            findBtn.UseVisualStyleBackColor = false;
            findBtn.Click += findBtn_Click;
            // 
            // dataGridViewAllclients
            // 
            dataGridViewAllclients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAllclients.Location = new Point(1140, 146);
            dataGridViewAllclients.Name = "dataGridViewAllclients";
            dataGridViewAllclients.RowHeadersWidth = 51;
            dataGridViewAllclients.Size = new Size(673, 875);
            dataGridViewAllclients.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("JetBrains Mono", 22.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(1208, 75);
            label2.Name = "label2";
            label2.Size = new Size(528, 49);
            label2.TabIndex = 6;
            label2.Text = "List of onboard clients";
            // 
            // groupBoxSearch
            // 
            groupBoxSearch.Controls.Add(radioButtonCname);
            groupBoxSearch.Controls.Add(radioButtonCphoneNumber);
            groupBoxSearch.Controls.Add(radioButtonCid);
            groupBoxSearch.Font = new Font("JetBrains Mono", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxSearch.ForeColor = Color.Crimson;
            groupBoxSearch.Location = new Point(145, 178);
            groupBoxSearch.Name = "groupBoxSearch";
            groupBoxSearch.Size = new Size(536, 297);
            groupBoxSearch.TabIndex = 7;
            groupBoxSearch.TabStop = false;
            groupBoxSearch.Text = "Search by,";
            groupBoxSearch.Enter += groupBoxSearch_Enter;
            // 
            // radioButtonCname
            // 
            radioButtonCname.AutoSize = true;
            radioButtonCname.ForeColor = Color.Indigo;
            radioButtonCname.Location = new Point(91, 200);
            radioButtonCname.Name = "radioButtonCname";
            radioButtonCname.Size = new Size(259, 41);
            radioButtonCname.TabIndex = 0;
            radioButtonCname.TabStop = true;
            radioButtonCname.Text = "Customer Name";
            radioButtonCname.UseVisualStyleBackColor = true;
            // 
            // radioButtonCphoneNumber
            // 
            radioButtonCphoneNumber.AutoSize = true;
            radioButtonCphoneNumber.ForeColor = Color.Indigo;
            radioButtonCphoneNumber.Location = new Point(91, 132);
            radioButtonCphoneNumber.Name = "radioButtonCphoneNumber";
            radioButtonCphoneNumber.Size = new Size(395, 41);
            radioButtonCphoneNumber.TabIndex = 0;
            radioButtonCphoneNumber.TabStop = true;
            radioButtonCphoneNumber.Text = "Customer Phone Number";
            radioButtonCphoneNumber.UseVisualStyleBackColor = true;
            // 
            // radioButtonCid
            // 
            radioButtonCid.AutoSize = true;
            radioButtonCid.ForeColor = Color.Indigo;
            radioButtonCid.Location = new Point(91, 61);
            radioButtonCid.Name = "radioButtonCid";
            radioButtonCid.Size = new Size(157, 41);
            radioButtonCid.TabIndex = 0;
            radioButtonCid.TabStop = true;
            radioButtonCid.Text = "Room ID";
            radioButtonCid.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(52, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(95, 104);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // dataGridViewSearchResult
            // 
            dataGridViewSearchResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSearchResult.Location = new Point(145, 694);
            dataGridViewSearchResult.Name = "dataGridViewSearchResult";
            dataGridViewSearchResult.RowHeadersWidth = 51;
            dataGridViewSearchResult.Size = new Size(675, 272);
            dataGridViewSearchResult.TabIndex = 3;
            dataGridViewSearchResult.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("JetBrains Mono", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Crimson;
            label3.Location = new Point(145, 621);
            label3.Name = "label3";
            label3.Size = new Size(319, 44);
            label3.TabIndex = 9;
            label3.Text = "Search result :";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // SearchClient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(1963, 1067);
            Controls.Add(label3);
            Controls.Add(dataGridViewSearchResult);
            Controls.Add(pictureBox1);
            Controls.Add(groupBoxSearch);
            Controls.Add(label2);
            Controls.Add(dataGridViewAllclients);
            Controls.Add(findBtn);
            Controls.Add(key);
            Controls.Add(label1);
            Name = "SearchClient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SearchClient";
            Load += SearchClient_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAllclients).EndInit();
            groupBoxSearch.ResumeLayout(false);
            groupBoxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSearchResult).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox key;
        private Button findBtn;
        private DataGridView dataGridViewAllclients;
        private Label label2;
        private GroupBox groupBoxSearch;
        private RadioButton radioButtonCid;
        private RadioButton radioButtonCname;
        private RadioButton radioButtonCphoneNumber;
        private PictureBox pictureBox1;
        private DataGridView dataGridViewSearchResult;
        private Label label3;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}
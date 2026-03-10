namespace HMS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            exitBtn = new Button();
            label1 = new Label();
            RegistrationBtn = new Button();
            label2 = new Label();
            SearchBtn = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            update = new Button();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // exitBtn
            // 
            exitBtn.BackColor = Color.Crimson;
            exitBtn.Font = new Font("Lucida Sans", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitBtn.ForeColor = SystemColors.ActiveCaptionText;
            exitBtn.Location = new Point(1163, 808);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(532, 154);
            exitBtn.TabIndex = 0;
            exitBtn.Text = "E X I T ";
            exitBtn.UseVisualStyleBackColor = false;
            exitBtn.Click += exitBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("JetBrains Mono", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(1163, 136);
            label1.Name = "label1";
            label1.Size = new Size(357, 37);
            label1.TabIndex = 1;
            label1.Text = "Client Registration ";
            // 
            // RegistrationBtn
            // 
            RegistrationBtn.BackColor = Color.MediumTurquoise;
            RegistrationBtn.Font = new Font("JetBrains Mono", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RegistrationBtn.Location = new Point(1295, 194);
            RegistrationBtn.Name = "RegistrationBtn";
            RegistrationBtn.Size = new Size(240, 50);
            RegistrationBtn.TabIndex = 2;
            RegistrationBtn.Text = "Reg.Form";
            RegistrationBtn.UseVisualStyleBackColor = false;
            RegistrationBtn.Click += RegistrationBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("JetBrains Mono", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(1163, 355);
            label2.Name = "label2";
            label2.Size = new Size(255, 37);
            label2.TabIndex = 1;
            label2.Text = "Search Client ";
            // 
            // SearchBtn
            // 
            SearchBtn.BackColor = Color.CornflowerBlue;
            SearchBtn.Font = new Font("JetBrains Mono", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SearchBtn.Location = new Point(1295, 407);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(240, 50);
            SearchBtn.TabIndex = 3;
            SearchBtn.Text = "Search ";
            SearchBtn.UseVisualStyleBackColor = false;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 72);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1027, 938);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1550, 329);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(145, 141);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1550, 113);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(145, 131);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("JetBrains Mono", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(1163, 579);
            label3.Name = "label3";
            label3.Size = new Size(323, 37);
            label3.TabIndex = 1;
            label3.Text = "Update / Check-Out";
            // 
            // update
            // 
            update.BackColor = Color.Chocolate;
            update.Font = new Font("JetBrains Mono", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            update.Location = new Point(1295, 637);
            update.Name = "update";
            update.Size = new Size(240, 57);
            update.TabIndex = 7;
            update.Text = "Update";
            update.UseVisualStyleBackColor = false;
            update.Click += update_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(1546, 567);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(154, 161);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // FormHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1956, 1082);
            ControlBox = false;
            Controls.Add(update);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(SearchBtn);
            Controls.Add(RegistrationBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(exitBtn);
            Name = "FormHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DASHBOARD ~ Hotel Management System";
            Load += FormHome_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button exitBtn;
        private Label label1;
        private Button RegistrationBtn;
        private Label label2;
        private Button SearchBtn;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label3;
        private Button update;
        private PictureBox pictureBox4;
    }
}
namespace WinFormsApp1
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            lstPlayer = new ListBox();
            bindingSource2 = new BindingSource(components);
            picPlayer = new PictureBox();
            btnDelete = new Button();
            cardPanel = new Panel();
            lblName = new Label();
            lblTeam = new Label();
            lblPPG = new Label();
            lblSPG = new Label();
            lblRPG = new Label();
            lblAPG = new Label();
            btnUpdate = new Button();
            btnAdd = new Button();
            txtName = new TextBox();
            txtPPG = new TextBox();
            txtRPG = new TextBox();
            txtAPG = new TextBox();
            cmbTeam = new ComboBox();
            txtSPG = new TextBox();
            label1 = new Label();
            t = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label2 = new Label();
            label6 = new Label();
            txtPhotoPath = new TextBox();
            label7 = new Label();
            txtNewPhotoPath = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            txtNewSPG = new TextBox();
            cmbNewTeam = new ComboBox();
            txtNewAPG = new TextBox();
            txtNewRPG = new TextBox();
            txtNewPPG = new TextBox();
            txtNewName = new TextBox();
            label14 = new Label();
            bindingSource1 = new BindingSource(components);
            panel1 = new Panel();
            panel2 = new Panel();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            ((System.ComponentModel.ISupportInitialize)bindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPlayer).BeginInit();
            cardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lstPlayer
            // 
            lstPlayer.DataSource = bindingSource2;
            lstPlayer.FormattingEnabled = true;
            lstPlayer.Location = new Point(9, 63);
            lstPlayer.Name = "lstPlayer";
            lstPlayer.Size = new Size(989, 84);
            lstPlayer.TabIndex = 0;
            // 
            // bindingSource2
            // 
            bindingSource2.DataSource = typeof(Player);
            // 
            // picPlayer
            // 
            picPlayer.Location = new Point(84, 15);
            picPlayer.Name = "picPlayer";
            picPlayer.Size = new Size(157, 196);
            picPlayer.SizeMode = PictureBoxSizeMode.StretchImage;
            picPlayer.TabIndex = 1;
            picPlayer.TabStop = false;
            // 
            // btnDelete
            // 
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatStyle = FlatStyle.System;
            btnDelete.Font = new Font("Century Schoolbook", 9F);
            btnDelete.Location = new Point(29, 422);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // cardPanel
            // 
            cardPanel.BackColor = Color.White;
            cardPanel.Controls.Add(picPlayer);
            cardPanel.Controls.Add(lblName);
            cardPanel.Controls.Add(lblTeam);
            cardPanel.Controls.Add(lblPPG);
            cardPanel.Controls.Add(lblSPG);
            cardPanel.Controls.Add(lblRPG);
            cardPanel.Controls.Add(lblAPG);
            cardPanel.ForeColor = SystemColors.ControlText;
            cardPanel.Location = new Point(671, 153);
            cardPanel.Name = "cardPanel";
            cardPanel.Size = new Size(327, 467);
            cardPanel.TabIndex = 11;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblName.Location = new Point(60, 261);
            lblName.Name = "lblName";
            lblName.Size = new Size(80, 30);
            lblName.TabIndex = 2;
            lblName.Text = "Name:";
            // 
            // lblTeam
            // 
            lblTeam.AutoSize = true;
            lblTeam.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            lblTeam.Location = new Point(61, 292);
            lblTeam.Name = "lblTeam";
            lblTeam.Size = new Size(57, 23);
            lblTeam.TabIndex = 3;
            lblTeam.Text = "Team:";
            // 
            // lblPPG
            // 
            lblPPG.AutoSize = true;
            lblPPG.Font = new Font("Segoe UI", 10.2F);
            lblPPG.Location = new Point(61, 319);
            lblPPG.Name = "lblPPG";
            lblPPG.Size = new Size(144, 23);
            lblPPG.TabIndex = 4;
            lblPPG.Text = "Points Per Game :";
            // 
            // lblSPG
            // 
            lblSPG.AutoSize = true;
            lblSPG.Font = new Font("Segoe UI", 10.2F);
            lblSPG.Location = new Point(61, 403);
            lblSPG.Name = "lblSPG";
            lblSPG.Size = new Size(141, 23);
            lblSPG.TabIndex = 7;
            lblSPG.Text = "Steals Per Game :";
            // 
            // lblRPG
            // 
            lblRPG.AutoSize = true;
            lblRPG.Font = new Font("Segoe UI", 10.2F);
            lblRPG.Location = new Point(61, 347);
            lblRPG.Name = "lblRPG";
            lblRPG.Size = new Size(174, 23);
            lblRPG.TabIndex = 5;
            lblRPG.Text = "Rebounds Per Game :";
            // 
            // lblAPG
            // 
            lblAPG.AutoSize = true;
            lblAPG.Font = new Font("Segoe UI", 10.2F);
            lblAPG.Location = new Point(61, 375);
            lblAPG.Name = "lblAPG";
            lblAPG.Size = new Size(147, 23);
            lblAPG.TabIndex = 6;
            lblAPG.Text = "Assists Per Game :";
            // 
            // btnUpdate
            // 
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatStyle = FlatStyle.System;
            btnUpdate.Font = new Font("Century Schoolbook", 9F);
            btnUpdate.Location = new Point(192, 422);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatStyle = FlatStyle.System;
            btnAdd.Font = new Font("Century Schoolbook", 9F);
            btnAdd.Location = new Point(111, 422);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.Control;
            txtName.Location = new Point(161, 92);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 12;
            // 
            // txtPPG
            // 
            txtPPG.BackColor = SystemColors.Control;
            txtPPG.Location = new Point(161, 138);
            txtPPG.Name = "txtPPG";
            txtPPG.Size = new Size(125, 27);
            txtPPG.TabIndex = 13;
            // 
            // txtRPG
            // 
            txtRPG.BackColor = SystemColors.Control;
            txtRPG.Location = new Point(161, 187);
            txtRPG.Name = "txtRPG";
            txtRPG.Size = new Size(125, 27);
            txtRPG.TabIndex = 14;
            // 
            // txtAPG
            // 
            txtAPG.BackColor = SystemColors.Control;
            txtAPG.Location = new Point(161, 234);
            txtAPG.Name = "txtAPG";
            txtAPG.Size = new Size(125, 27);
            txtAPG.TabIndex = 15;
            // 
            // cmbTeam
            // 
            cmbTeam.FormattingEnabled = true;
            cmbTeam.Location = new Point(161, 372);
            cmbTeam.Name = "cmbTeam";
            cmbTeam.Size = new Size(125, 28);
            cmbTeam.TabIndex = 16;
            // 
            // txtSPG
            // 
            txtSPG.BackColor = SystemColors.Control;
            txtSPG.Location = new Point(161, 276);
            txtSPG.Name = "txtSPG";
            txtSPG.Size = new Size(125, 27);
            txtSPG.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 98);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 8;
            label1.Text = "Name";
            // 
            // t
            // 
            t.AutoSize = true;
            t.Location = new Point(8, 143);
            t.Name = "t";
            t.Size = new Size(115, 20);
            t.TabIndex = 18;
            t.Text = "Points Per Game";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 187);
            label3.Name = "label3";
            label3.Size = new Size(142, 20);
            label3.TabIndex = 19;
            label3.Text = "Rebounds Per Game";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 234);
            label4.Name = "label4";
            label4.Size = new Size(119, 20);
            label4.TabIndex = 20;
            label4.Text = "Assists Per Game";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 279);
            label5.Name = "label5";
            label5.Size = new Size(119, 20);
            label5.TabIndex = 21;
            label5.Text = "Steals Per Game ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 372);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 22;
            label2.Text = "Team";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 325);
            label6.Name = "label6";
            label6.Size = new Size(90, 20);
            label6.TabIndex = 24;
            label6.Text = "Image Path: ";
            // 
            // txtPhotoPath
            // 
            txtPhotoPath.BackColor = SystemColors.Control;
            txtPhotoPath.Location = new Point(161, 322);
            txtPhotoPath.Name = "txtPhotoPath";
            txtPhotoPath.Size = new Size(125, 27);
            txtPhotoPath.TabIndex = 23;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 316);
            label7.Name = "label7";
            label7.Size = new Size(90, 20);
            label7.TabIndex = 38;
            label7.Text = "Image Path: ";
            // 
            // txtNewPhotoPath
            // 
            txtNewPhotoPath.BackColor = SystemColors.Control;
            txtNewPhotoPath.Location = new Point(171, 316);
            txtNewPhotoPath.Name = "txtNewPhotoPath";
            txtNewPhotoPath.Size = new Size(125, 27);
            txtNewPhotoPath.TabIndex = 37;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 362);
            label8.Name = "label8";
            label8.Size = new Size(45, 20);
            label8.TabIndex = 36;
            label8.Text = "Team";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(16, 273);
            label9.Name = "label9";
            label9.Size = new Size(119, 20);
            label9.TabIndex = 35;
            label9.Text = "Steals Per Game ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(18, 228);
            label10.Name = "label10";
            label10.Size = new Size(119, 20);
            label10.TabIndex = 34;
            label10.Text = "Assists Per Game";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(18, 181);
            label11.Name = "label11";
            label11.Size = new Size(142, 20);
            label11.TabIndex = 33;
            label11.Text = "Rebounds Per Game";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(18, 137);
            label12.Name = "label12";
            label12.Size = new Size(115, 20);
            label12.TabIndex = 32;
            label12.Text = "Points Per Game";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(18, 92);
            label13.Name = "label13";
            label13.Size = new Size(49, 20);
            label13.TabIndex = 25;
            label13.Text = "Name";
            // 
            // txtNewSPG
            // 
            txtNewSPG.BackColor = SystemColors.Control;
            txtNewSPG.Location = new Point(171, 270);
            txtNewSPG.Name = "txtNewSPG";
            txtNewSPG.Size = new Size(125, 27);
            txtNewSPG.TabIndex = 31;
            // 
            // cmbNewTeam
            // 
            cmbNewTeam.FormattingEnabled = true;
            cmbNewTeam.Location = new Point(171, 359);
            cmbNewTeam.Name = "cmbNewTeam";
            cmbNewTeam.Size = new Size(125, 28);
            cmbNewTeam.TabIndex = 30;
            // 
            // txtNewAPG
            // 
            txtNewAPG.BackColor = SystemColors.Control;
            txtNewAPG.Location = new Point(171, 228);
            txtNewAPG.Name = "txtNewAPG";
            txtNewAPG.Size = new Size(125, 27);
            txtNewAPG.TabIndex = 29;
            // 
            // txtNewRPG
            // 
            txtNewRPG.BackColor = SystemColors.Control;
            txtNewRPG.Location = new Point(171, 181);
            txtNewRPG.Name = "txtNewRPG";
            txtNewRPG.Size = new Size(125, 27);
            txtNewRPG.TabIndex = 28;
            // 
            // txtNewPPG
            // 
            txtNewPPG.BackColor = SystemColors.Control;
            txtNewPPG.Location = new Point(171, 132);
            txtNewPPG.Name = "txtNewPPG";
            txtNewPPG.Size = new Size(125, 27);
            txtNewPPG.TabIndex = 27;
            // 
            // txtNewName
            // 
            txtNewName.BackColor = SystemColors.Control;
            txtNewName.Location = new Point(171, 86);
            txtNewName.Name = "txtNewName";
            txtNewName.Size = new Size(125, 27);
            txtNewName.TabIndex = 26;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(81, 35);
            label14.Name = "label14";
            label14.Size = new Size(144, 19);
            label14.TabIndex = 39;
            label14.Text = "Add a new Player";
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(Player);
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtNewPhotoPath);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(txtNewSPG);
            panel1.Controls.Add(cmbNewTeam);
            panel1.Controls.Add(txtNewAPG);
            panel1.Controls.Add(txtNewRPG);
            panel1.Controls.Add(txtNewPPG);
            panel1.Controls.Add(txtNewName);
            panel1.Controls.Add(btnAdd);
            panel1.Location = new Point(338, 154);
            panel1.Name = "panel1";
            panel1.Size = new Size(315, 466);
            panel1.TabIndex = 40;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label15);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtPhotoPath);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(t);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtSPG);
            panel2.Controls.Add(cmbTeam);
            panel2.Controls.Add(txtAPG);
            panel2.Controls.Add(txtRPG);
            panel2.Controls.Add(txtPPG);
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnUpdate);
            panel2.Location = new Point(9, 154);
            panel2.Name = "panel2";
            panel2.Size = new Size(307, 466);
            panel2.TabIndex = 41;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(84, 38);
            label15.Name = "label15";
            label15.Size = new Size(126, 19);
            label15.TabIndex = 40;
            label15.Text = "Modify Players";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.White;
            label16.FlatStyle = FlatStyle.System;
            label16.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold);
            label16.Location = new Point(400, 9);
            label16.Name = "label16";
            label16.Size = new Size(212, 25);
            label16.TabIndex = 41;
            label16.Text = "  TRADING CARDS";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.White;
            label17.FlatStyle = FlatStyle.System;
            label17.Font = new Font("Century Schoolbook", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(9, 41);
            label17.Name = "label17";
            label17.Size = new Size(102, 19);
            label17.TabIndex = 40;
            label17.Text = "  Player List";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 634);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(cardPanel);
            Controls.Add(lstPlayer);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPlayer).EndInit();
            cardPanel.ResumeLayout(false);
            cardPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstPlayer;
        private PictureBox picPlayer;
        private Button btnDelete;
        private Panel cardPanel;
        private Label lblName;
        private Button btnUpdate;
        private Label lblTeam;
        private Button btnAdd;
        private Label lblPPG;
        private Label lblSPG;
        private Label lblRPG;
        private Label lblAPG;
        private TextBox txtName;
        private TextBox txtPPG;
        private TextBox txtRPG;
        private TextBox txtAPG;
        private ComboBox cmbTeam;
        private TextBox txtSPG;
        private Label label1;
        private Label t;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label2;
        private Label label6;
        private TextBox txtPhotoPath;
        private Label label7;
        private TextBox txtNewPhotoPath;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox txtNewSPG;
        private ComboBox cmbNewTeam;
        private TextBox txtNewAPG;
        private TextBox txtNewRPG;
        private TextBox txtNewPPG;
        private TextBox txtNewName;
        private Label label14;
        private BindingSource bindingSource2;
        private BindingSource bindingSource1;
        private Panel panel1;
        private Panel panel2;
        private Label label15;
        private Label label16;
        private Label label17;
    }
}

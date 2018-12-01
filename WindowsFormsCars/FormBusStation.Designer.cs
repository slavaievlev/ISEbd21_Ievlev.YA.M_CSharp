namespace WindowsFormsCars
{
    partial class FormBusStation
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
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBoxForBusDraw = new System.Windows.Forms.PictureBox();
            this.buttonGetBus = new System.Windows.Forms.Button();
            this.textBoxPlaceNumber = new System.Windows.Forms.TextBox();
            this.textBoxGetBus = new System.Windows.Forms.TextBox();
            this.maskedTextBoxPlaceNumber = new System.Windows.Forms.MaskedTextBox();
            this.listBoxLevels = new System.Windows.Forms.ListBox();
            this.buttonAddBus = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForBusDraw)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Location = new System.Drawing.Point(12, 44);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(1230, 797);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBoxForBusDraw);
            this.groupBox1.Controls.Add(this.buttonGetBus);
            this.groupBox1.Controls.Add(this.textBoxPlaceNumber);
            this.groupBox1.Controls.Add(this.textBoxGetBus);
            this.groupBox1.Controls.Add(this.maskedTextBoxPlaceNumber);
            this.groupBox1.Location = new System.Drawing.Point(1248, 422);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 308);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // pictureBoxForBusDraw
            // 
            this.pictureBoxForBusDraw.Location = new System.Drawing.Point(6, 120);
            this.pictureBoxForBusDraw.Name = "pictureBoxForBusDraw";
            this.pictureBoxForBusDraw.Size = new System.Drawing.Size(210, 182);
            this.pictureBoxForBusDraw.TabIndex = 4;
            this.pictureBoxForBusDraw.TabStop = false;
            // 
            // buttonGetBus
            // 
            this.buttonGetBus.Location = new System.Drawing.Point(30, 83);
            this.buttonGetBus.Name = "buttonGetBus";
            this.buttonGetBus.Size = new System.Drawing.Size(163, 31);
            this.buttonGetBus.TabIndex = 3;
            this.buttonGetBus.Text = "Забрать";
            this.buttonGetBus.UseVisualStyleBackColor = true;
            this.buttonGetBus.Click += new System.EventHandler(this.buttonGetBus_Click);
            // 
            // textBoxPlaceNumber
            // 
            this.textBoxPlaceNumber.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxPlaceNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPlaceNumber.Location = new System.Drawing.Point(6, 58);
            this.textBoxPlaceNumber.Name = "textBoxPlaceNumber";
            this.textBoxPlaceNumber.Size = new System.Drawing.Size(114, 15);
            this.textBoxPlaceNumber.TabIndex = 2;
            this.textBoxPlaceNumber.Text = "Место:";
            this.textBoxPlaceNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxGetBus
            // 
            this.textBoxGetBus.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxGetBus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxGetBus.Location = new System.Drawing.Point(6, 21);
            this.textBoxGetBus.Name = "textBoxGetBus";
            this.textBoxGetBus.Size = new System.Drawing.Size(210, 15);
            this.textBoxGetBus.TabIndex = 1;
            this.textBoxGetBus.Text = "Забрать автобус";
            this.textBoxGetBus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // maskedTextBoxPlaceNumber
            // 
            this.maskedTextBoxPlaceNumber.Location = new System.Drawing.Point(126, 55);
            this.maskedTextBoxPlaceNumber.Mask = "00";
            this.maskedTextBoxPlaceNumber.Name = "maskedTextBoxPlaceNumber";
            this.maskedTextBoxPlaceNumber.Size = new System.Drawing.Size(23, 22);
            this.maskedTextBoxPlaceNumber.TabIndex = 0;
            // 
            // listBoxLevels
            // 
            this.listBoxLevels.FormattingEnabled = true;
            this.listBoxLevels.ItemHeight = 16;
            this.listBoxLevels.Location = new System.Drawing.Point(1248, 44);
            this.listBoxLevels.Name = "listBoxLevels";
            this.listBoxLevels.Size = new System.Drawing.Size(222, 148);
            this.listBoxLevels.TabIndex = 4;
            this.listBoxLevels.SelectedIndexChanged += new System.EventHandler(this.listBoxLevels_SelectedIndexChanged);
            // 
            // buttonAddBus
            // 
            this.buttonAddBus.Location = new System.Drawing.Point(1278, 279);
            this.buttonAddBus.Name = "buttonAddBus";
            this.buttonAddBus.Size = new System.Drawing.Size(171, 50);
            this.buttonAddBus.TabIndex = 5;
            this.buttonAddBus.Text = "Заказать автобус";
            this.buttonAddBus.UseVisualStyleBackColor = true;
            this.buttonAddBus.Click += new System.EventHandler(this.buttonAddBus_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1482, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.saveToolStripMenuItem.Text = "Сохранить";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.openToolStripMenuItem.Text = "Загрузить";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "txt file | *.txt";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "txt file | *.txt";
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 853);
            this.Controls.Add(this.buttonAddBus);
            this.Controls.Add(this.listBoxLevels);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBoxParking);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormParking";
            this.Text = "Автовокзал";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForBusDraw)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPlaceNumber;
        private System.Windows.Forms.TextBox textBoxPlaceNumber;
        private System.Windows.Forms.TextBox textBoxGetBus;
        private System.Windows.Forms.PictureBox pictureBoxForBusDraw;
        private System.Windows.Forms.Button buttonGetBus;
        private System.Windows.Forms.ListBox listBoxLevels;
        private System.Windows.Forms.Button buttonAddBus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}
namespace WindowsFormsCars
{
    partial class FormParking
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
            this.buttonSetBus = new System.Windows.Forms.Button();
            this.buttonSetDoubleBus = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBoxForBusDraw = new System.Windows.Forms.PictureBox();
            this.buttonGetBus = new System.Windows.Forms.Button();
            this.textBoxPlaceNumber = new System.Windows.Forms.TextBox();
            this.textBoxGetBus = new System.Windows.Forms.TextBox();
            this.maskedTextBoxPlaceNumber = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForBusDraw)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(1230, 829);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // buttonSetBus
            // 
            this.buttonSetBus.Location = new System.Drawing.Point(1248, 12);
            this.buttonSetBus.Name = "buttonSetBus";
            this.buttonSetBus.Size = new System.Drawing.Size(222, 81);
            this.buttonSetBus.TabIndex = 1;
            this.buttonSetBus.Text = "Поставить автобус";
            this.buttonSetBus.UseVisualStyleBackColor = true;
            this.buttonSetBus.Click += new System.EventHandler(this.buttonSetBus_Click);
            // 
            // buttonSetDoubleBus
            // 
            this.buttonSetDoubleBus.Location = new System.Drawing.Point(1248, 99);
            this.buttonSetDoubleBus.Name = "buttonSetDoubleBus";
            this.buttonSetDoubleBus.Size = new System.Drawing.Size(222, 81);
            this.buttonSetDoubleBus.TabIndex = 2;
            this.buttonSetDoubleBus.Text = "Поставить двуярусный автобус";
            this.buttonSetDoubleBus.UseVisualStyleBackColor = true;
            this.buttonSetDoubleBus.Click += new System.EventHandler(this.buttonSetDoubleBus_Click);
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
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 853);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSetDoubleBus);
            this.Controls.Add(this.buttonSetBus);
            this.Controls.Add(this.pictureBoxParking);
            this.Name = "FormParking";
            this.Text = "Автовокзал";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForBusDraw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.Button buttonSetBus;
        private System.Windows.Forms.Button buttonSetDoubleBus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPlaceNumber;
        private System.Windows.Forms.TextBox textBoxPlaceNumber;
        private System.Windows.Forms.TextBox textBoxGetBus;
        private System.Windows.Forms.PictureBox pictureBoxForBusDraw;
        private System.Windows.Forms.Button buttonGetBus;
    }
}
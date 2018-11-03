namespace WindowsFormsCars
{
    partial class FormBusConfig
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
            this.groupBoxForDrawBus = new System.Windows.Forms.GroupBox();
            this.doublebusLabel = new System.Windows.Forms.Label();
            this.busLabel = new System.Windows.Forms.Label();
            this.drawBusPictureBox = new System.Windows.Forms.PictureBox();
            this.panelForDrawBusPictureBox = new System.Windows.Forms.Panel();
            this.colorLabel = new System.Windows.Forms.Label();
            this.dopColorLabel = new System.Windows.Forms.Label();
            this.blackColorPanel = new System.Windows.Forms.Panel();
            this.whiteColorPanel = new System.Windows.Forms.Panel();
            this.greenColorPanel = new System.Windows.Forms.Panel();
            this.blueColorPanel = new System.Windows.Forms.Panel();
            this.yellowColorPanel = new System.Windows.Forms.Panel();
            this.redColorPanel = new System.Windows.Forms.Panel();
            this.grayColorPanel = new System.Windows.Forms.Panel();
            this.orangeColorPanel = new System.Windows.Forms.Panel();
            this.groupBoxForDrawBus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drawBusPictureBox)).BeginInit();
            this.panelForDrawBusPictureBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxForDrawBus
            // 
            this.groupBoxForDrawBus.Controls.Add(this.doublebusLabel);
            this.groupBoxForDrawBus.Controls.Add(this.busLabel);
            this.groupBoxForDrawBus.Location = new System.Drawing.Point(31, 58);
            this.groupBoxForDrawBus.Name = "groupBoxForDrawBus";
            this.groupBoxForDrawBus.Size = new System.Drawing.Size(211, 159);
            this.groupBoxForDrawBus.TabIndex = 1;
            this.groupBoxForDrawBus.TabStop = false;
            this.groupBoxForDrawBus.Text = "Тип автобуса";
            // 
            // doublebusLabel
            // 
            this.doublebusLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.doublebusLabel.Location = new System.Drawing.Point(6, 91);
            this.doublebusLabel.Name = "doublebusLabel";
            this.doublebusLabel.Size = new System.Drawing.Size(199, 53);
            this.doublebusLabel.TabIndex = 1;
            this.doublebusLabel.Text = "Двухярусный автобус";
            this.doublebusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.doublebusLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.doublebusLabel_MouseDown);
            // 
            // busLabel
            // 
            this.busLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.busLabel.Location = new System.Drawing.Point(6, 31);
            this.busLabel.Name = "busLabel";
            this.busLabel.Size = new System.Drawing.Size(199, 53);
            this.busLabel.TabIndex = 0;
            this.busLabel.Text = "Обычный автобус";
            this.busLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.busLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.busLabel_MouseDown);
            // 
            // drawBusPictureBox
            // 
            this.drawBusPictureBox.Location = new System.Drawing.Point(19, 22);
            this.drawBusPictureBox.Name = "drawBusPictureBox";
            this.drawBusPictureBox.Size = new System.Drawing.Size(275, 158);
            this.drawBusPictureBox.TabIndex = 0;
            this.drawBusPictureBox.TabStop = false;
            // 
            // panelForDrawBusPictureBox
            // 
            this.panelForDrawBusPictureBox.AllowDrop = true;
            this.panelForDrawBusPictureBox.Controls.Add(this.colorLabel);
            this.panelForDrawBusPictureBox.Controls.Add(this.dopColorLabel);
            this.panelForDrawBusPictureBox.Controls.Add(this.drawBusPictureBox);
            this.panelForDrawBusPictureBox.Location = new System.Drawing.Point(278, 47);
            this.panelForDrawBusPictureBox.Name = "panelForDrawBusPictureBox";
            this.panelForDrawBusPictureBox.Size = new System.Drawing.Size(312, 286);
            this.panelForDrawBusPictureBox.TabIndex = 3;
            this.panelForDrawBusPictureBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelForDrawBusPictureBox_DragDrop);
            this.panelForDrawBusPictureBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelForDrawBusPictureBox_DragEnter);
            // 
            // colorLabel
            // 
            this.colorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorLabel.Location = new System.Drawing.Point(57, 194);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(199, 41);
            this.colorLabel.TabIndex = 3;
            this.colorLabel.Text = "Основной цвет";
            this.colorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.colorLabel.DragDrop += new System.Windows.Forms.DragEventHandler(this.colorLabel_DragDrop);
            this.colorLabel.DragEnter += new System.Windows.Forms.DragEventHandler(this.colorLabel_DragEnter);
            // 
            // dopColorLabel
            // 
            this.dopColorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dopColorLabel.Location = new System.Drawing.Point(57, 235);
            this.dopColorLabel.Name = "dopColorLabel";
            this.dopColorLabel.Size = new System.Drawing.Size(199, 41);
            this.dopColorLabel.TabIndex = 2;
            this.dopColorLabel.Text = "Дополнительный цвет";
            this.dopColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // blackColorPanel
            // 
            this.blackColorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.blackColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.blackColorPanel.Location = new System.Drawing.Point(630, 58);
            this.blackColorPanel.Name = "blackColorPanel";
            this.blackColorPanel.Size = new System.Drawing.Size(46, 46);
            this.blackColorPanel.TabIndex = 4;
            // 
            // whiteColorPanel
            // 
            this.whiteColorPanel.BackColor = System.Drawing.Color.White;
            this.whiteColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.whiteColorPanel.Location = new System.Drawing.Point(682, 58);
            this.whiteColorPanel.Name = "whiteColorPanel";
            this.whiteColorPanel.Size = new System.Drawing.Size(46, 46);
            this.whiteColorPanel.TabIndex = 5;
            // 
            // greenColorPanel
            // 
            this.greenColorPanel.BackColor = System.Drawing.Color.Lime;
            this.greenColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.greenColorPanel.Location = new System.Drawing.Point(630, 110);
            this.greenColorPanel.Name = "greenColorPanel";
            this.greenColorPanel.Size = new System.Drawing.Size(46, 46);
            this.greenColorPanel.TabIndex = 5;
            // 
            // blueColorPanel
            // 
            this.blueColorPanel.BackColor = System.Drawing.Color.SkyBlue;
            this.blueColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.blueColorPanel.Location = new System.Drawing.Point(682, 110);
            this.blueColorPanel.Name = "blueColorPanel";
            this.blueColorPanel.Size = new System.Drawing.Size(46, 46);
            this.blueColorPanel.TabIndex = 5;
            // 
            // yellowColorPanel
            // 
            this.yellowColorPanel.BackColor = System.Drawing.Color.Yellow;
            this.yellowColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yellowColorPanel.Location = new System.Drawing.Point(682, 162);
            this.yellowColorPanel.Name = "yellowColorPanel";
            this.yellowColorPanel.Size = new System.Drawing.Size(46, 46);
            this.yellowColorPanel.TabIndex = 5;
            // 
            // redColorPanel
            // 
            this.redColorPanel.BackColor = System.Drawing.Color.Red;
            this.redColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.redColorPanel.Location = new System.Drawing.Point(630, 162);
            this.redColorPanel.Name = "redColorPanel";
            this.redColorPanel.Size = new System.Drawing.Size(46, 46);
            this.redColorPanel.TabIndex = 5;
            // 
            // grayColorPanel
            // 
            this.grayColorPanel.BackColor = System.Drawing.Color.Gray;
            this.grayColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grayColorPanel.Location = new System.Drawing.Point(630, 214);
            this.grayColorPanel.Name = "grayColorPanel";
            this.grayColorPanel.Size = new System.Drawing.Size(46, 46);
            this.grayColorPanel.TabIndex = 5;
            // 
            // orangeColorPanel
            // 
            this.orangeColorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.orangeColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.orangeColorPanel.Location = new System.Drawing.Point(682, 214);
            this.orangeColorPanel.Name = "orangeColorPanel";
            this.orangeColorPanel.Size = new System.Drawing.Size(46, 46);
            this.orangeColorPanel.TabIndex = 5;
            // 
            // FormBusConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.orangeColorPanel);
            this.Controls.Add(this.grayColorPanel);
            this.Controls.Add(this.redColorPanel);
            this.Controls.Add(this.yellowColorPanel);
            this.Controls.Add(this.blueColorPanel);
            this.Controls.Add(this.greenColorPanel);
            this.Controls.Add(this.whiteColorPanel);
            this.Controls.Add(this.blackColorPanel);
            this.Controls.Add(this.panelForDrawBusPictureBox);
            this.Controls.Add(this.groupBoxForDrawBus);
            this.Name = "FormBusConfig";
            this.Text = "FormBusConfig";
            this.groupBoxForDrawBus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.drawBusPictureBox)).EndInit();
            this.panelForDrawBusPictureBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxForDrawBus;
        private System.Windows.Forms.Label doublebusLabel;
        private System.Windows.Forms.Label busLabel;
        private System.Windows.Forms.PictureBox drawBusPictureBox;
        private System.Windows.Forms.Panel panelForDrawBusPictureBox;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.Label dopColorLabel;
        private System.Windows.Forms.Panel blackColorPanel;
        private System.Windows.Forms.Panel whiteColorPanel;
        private System.Windows.Forms.Panel greenColorPanel;
        private System.Windows.Forms.Panel blueColorPanel;
        private System.Windows.Forms.Panel yellowColorPanel;
        private System.Windows.Forms.Panel redColorPanel;
        private System.Windows.Forms.Panel grayColorPanel;
        private System.Windows.Forms.Panel orangeColorPanel;
    }
}
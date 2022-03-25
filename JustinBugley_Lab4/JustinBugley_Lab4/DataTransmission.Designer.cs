namespace JustinBugley_Lab4
{
    partial class DataTransmission
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.btnWrite = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.boxDataOut = new System.Windows.Forms.TextBox();
            this.boxDataRead = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closePortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClear = new System.Windows.Forms.Button();
            this.PortButton = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.HexText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Data To Write:";
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(12, 435);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(124, 23);
            this.btnWrite.TabIndex = 9;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Data Recieved:";
            // 
            // boxDataOut
            // 
            this.boxDataOut.Location = new System.Drawing.Point(12, 77);
            this.boxDataOut.Multiline = true;
            this.boxDataOut.Name = "boxDataOut";
            this.boxDataOut.Size = new System.Drawing.Size(268, 62);
            this.boxDataOut.TabIndex = 8;
            // 
            // boxDataRead
            // 
            this.boxDataRead.Location = new System.Drawing.Point(12, 305);
            this.boxDataRead.Multiline = true;
            this.boxDataRead.Name = "boxDataRead";
            this.boxDataRead.ReadOnly = true;
            this.boxDataRead.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.boxDataRead.Size = new System.Drawing.Size(268, 124);
            this.boxDataRead.TabIndex = 12;
            this.boxDataRead.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(314, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openPortToolStripMenuItem,
            this.closePortToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // openPortToolStripMenuItem
            // 
            this.openPortToolStripMenuItem.Name = "openPortToolStripMenuItem";
            this.openPortToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.openPortToolStripMenuItem.Text = "Open Port";
            this.openPortToolStripMenuItem.Click += new System.EventHandler(this.openPortToolStripMenuItem_Click);
            // 
            // closePortToolStripMenuItem
            // 
            this.closePortToolStripMenuItem.Name = "closePortToolStripMenuItem";
            this.closePortToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.closePortToolStripMenuItem.Text = "Close Port";
            this.closePortToolStripMenuItem.Click += new System.EventHandler(this.closePortToolStripMenuItem_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(142, 435);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(138, 23);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear Data Recieved";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // PortButton
            // 
            this.PortButton.Location = new System.Drawing.Point(81, 27);
            this.PortButton.Name = "PortButton";
            this.PortButton.Size = new System.Drawing.Size(127, 23);
            this.PortButton.TabIndex = 16;
            this.PortButton.Text = "Configure Com Port";
            this.PortButton.UseVisualStyleBackColor = true;
            this.PortButton.Click += new System.EventHandler(this.PortButton_Click_1);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(12, 464);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(121, 23);
            this.btnRead.TabIndex = 17;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // HexText
            // 
            this.HexText.Location = new System.Drawing.Point(12, 158);
            this.HexText.Multiline = true;
            this.HexText.Name = "HexText";
            this.HexText.Size = new System.Drawing.Size(268, 108);
            this.HexText.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Hex Dump:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // DataTransmission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 542);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HexText);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.PortButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxDataOut);
            this.Controls.Add(this.boxDataRead);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnClear);
            this.Name = "DataTransmission";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox boxDataOut;
        private System.Windows.Forms.TextBox boxDataRead;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openPortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closePortToolStripMenuItem;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button PortButton;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.TextBox HexText;
        private System.Windows.Forms.Label label3;
    }
}


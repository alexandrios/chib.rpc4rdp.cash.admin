namespace chib.rpc4rdp.cash.admin
{
    partial class MainForm
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
            this._reportsGroupBox = new System.Windows.Forms.GroupBox();
            this._zReportButton = new System.Windows.Forms.Button();
            this._xReportButton = new System.Windows.Forms.Button();
            this._cashGroupBox = new System.Windows.Forms.GroupBox();
            this._cashInButton = new System.Windows.Forms.Button();
            this._summaTextBox = new System.Windows.Forms.TextBox();
            this._summaLabel = new System.Windows.Forms.Label();
            this._cashOutButton = new System.Windows.Forms.Button();
            this._reportsGroupBox.SuspendLayout();
            this._cashGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // _reportsGroupBox
            // 
            this._reportsGroupBox.Controls.Add(this._zReportButton);
            this._reportsGroupBox.Controls.Add(this._xReportButton);
            this._reportsGroupBox.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._reportsGroupBox.Location = new System.Drawing.Point(12, 12);
            this._reportsGroupBox.Name = "_reportsGroupBox";
            this._reportsGroupBox.Size = new System.Drawing.Size(279, 85);
            this._reportsGroupBox.TabIndex = 0;
            this._reportsGroupBox.TabStop = false;
            this._reportsGroupBox.Text = "Отчеты";
            // 
            // _zReportButton
            // 
            this._zReportButton.Location = new System.Drawing.Point(142, 32);
            this._zReportButton.Name = "_zReportButton";
            this._zReportButton.Size = new System.Drawing.Size(130, 33);
            this._zReportButton.TabIndex = 1;
            this._zReportButton.Text = "Z - отчет";
            this._zReportButton.UseVisualStyleBackColor = true;
            this._zReportButton.Click += new System.EventHandler(this._zReportButton_Click);
            // 
            // _xReportButton
            // 
            this._xReportButton.Location = new System.Drawing.Point(6, 32);
            this._xReportButton.Name = "_xReportButton";
            this._xReportButton.Size = new System.Drawing.Size(130, 33);
            this._xReportButton.TabIndex = 0;
            this._xReportButton.Text = "X - отчет";
            this._xReportButton.UseVisualStyleBackColor = true;
            this._xReportButton.Click += new System.EventHandler(this._xReportButton_Click);
            // 
            // _cashGroupBox
            // 
            this._cashGroupBox.Controls.Add(this._cashInButton);
            this._cashGroupBox.Controls.Add(this._summaTextBox);
            this._cashGroupBox.Controls.Add(this._summaLabel);
            this._cashGroupBox.Controls.Add(this._cashOutButton);
            this._cashGroupBox.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._cashGroupBox.Location = new System.Drawing.Point(12, 113);
            this._cashGroupBox.Name = "_cashGroupBox";
            this._cashGroupBox.Size = new System.Drawing.Size(279, 125);
            this._cashGroupBox.TabIndex = 1;
            this._cashGroupBox.TabStop = false;
            this._cashGroupBox.Text = "Операции с наличностью";
            // 
            // _cashInButton
            // 
            this._cashInButton.Location = new System.Drawing.Point(142, 71);
            this._cashInButton.Name = "_cashInButton";
            this._cashInButton.Size = new System.Drawing.Size(130, 33);
            this._cashInButton.TabIndex = 3;
            this._cashInButton.Text = "Внесение";
            this._cashInButton.UseVisualStyleBackColor = true;
            this._cashInButton.Click += new System.EventHandler(this._cashInButton_Click);
            // 
            // _summaTextBox
            // 
            this._summaTextBox.Location = new System.Drawing.Point(61, 32);
            this._summaTextBox.Name = "_summaTextBox";
            this._summaTextBox.Size = new System.Drawing.Size(211, 24);
            this._summaTextBox.TabIndex = 1;
            this._summaTextBox.Text = "0.00";
            this._summaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this._summaTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this._summaTextBox_KeyDown);
            this._summaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._summaTextBox_KeyPress);
            // 
            // _summaLabel
            // 
            this._summaLabel.AutoSize = true;
            this._summaLabel.Location = new System.Drawing.Point(6, 35);
            this._summaLabel.Name = "_summaLabel";
            this._summaLabel.Size = new System.Drawing.Size(49, 16);
            this._summaLabel.TabIndex = 0;
            this._summaLabel.Text = "Сумма:";
            // 
            // _cashOutButton
            // 
            this._cashOutButton.Location = new System.Drawing.Point(6, 71);
            this._cashOutButton.Name = "_cashOutButton";
            this._cashOutButton.Size = new System.Drawing.Size(130, 33);
            this._cashOutButton.TabIndex = 2;
            this._cashOutButton.Text = "Выплата";
            this._cashOutButton.UseVisualStyleBackColor = true;
            this._cashOutButton.Click += new System.EventHandler(this._cashOutButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 255);
            this.Controls.Add(this._cashGroupBox);
            this.Controls.Add(this._reportsGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Аминистратор ККТ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this._reportsGroupBox.ResumeLayout(false);
            this._cashGroupBox.ResumeLayout(false);
            this._cashGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox _reportsGroupBox;
        private System.Windows.Forms.Button _zReportButton;
        private System.Windows.Forms.Button _xReportButton;
        private System.Windows.Forms.GroupBox _cashGroupBox;
        private System.Windows.Forms.TextBox _summaTextBox;
        private System.Windows.Forms.Label _summaLabel;
        private System.Windows.Forms.Button _cashOutButton;
        private System.Windows.Forms.Button _cashInButton;
    }
}


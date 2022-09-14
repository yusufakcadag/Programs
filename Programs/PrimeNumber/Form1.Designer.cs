namespace PrimeNumber
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
            this.lblUpperPN = new System.Windows.Forms.Label();
            this.lblPN = new System.Windows.Forms.Label();
            this.lblBottomPN = new System.Windows.Forms.Label();
            this.tbxPN = new System.Windows.Forms.TextBox();
            this.btnIsPN = new System.Windows.Forms.Button();
            this.lbxHistory = new System.Windows.Forms.ListBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUpperPN
            // 
            this.lblUpperPN.AutoSize = true;
            this.lblUpperPN.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUpperPN.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblUpperPN.Location = new System.Drawing.Point(334, 218);
            this.lblUpperPN.Name = "lblUpperPN";
            this.lblUpperPN.Size = new System.Drawing.Size(221, 40);
            this.lblUpperPN.TabIndex = 0;
            this.lblUpperPN.Text = "Üst Asal Sayı";
            this.lblUpperPN.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPN
            // 
            this.lblPN.AutoSize = true;
            this.lblPN.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPN.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblPN.Location = new System.Drawing.Point(334, 258);
            this.lblPN.Name = "lblPN";
            this.lblPN.Size = new System.Drawing.Size(245, 40);
            this.lblPN.TabIndex = 1;
            this.lblPN.Text = "Asal/Asal Değil";
            this.lblPN.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblBottomPN
            // 
            this.lblBottomPN.AutoSize = true;
            this.lblBottomPN.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBottomPN.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblBottomPN.Location = new System.Drawing.Point(334, 298);
            this.lblBottomPN.Name = "lblBottomPN";
            this.lblBottomPN.Size = new System.Drawing.Size(208, 40);
            this.lblBottomPN.TabIndex = 2;
            this.lblBottomPN.Text = "Alt Asal Sayı";
            this.lblBottomPN.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbxPN
            // 
            this.tbxPN.BackColor = System.Drawing.Color.White;
            this.tbxPN.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxPN.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbxPN.Location = new System.Drawing.Point(341, 341);
            this.tbxPN.MaxLength = 9;
            this.tbxPN.Name = "tbxPN";
            this.tbxPN.Size = new System.Drawing.Size(214, 47);
            this.tbxPN.TabIndex = 3;
            // 
            // btnIsPN
            // 
            this.btnIsPN.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnIsPN.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIsPN.ForeColor = System.Drawing.Color.White;
            this.btnIsPN.Location = new System.Drawing.Point(387, 394);
            this.btnIsPN.Name = "btnIsPN";
            this.btnIsPN.Size = new System.Drawing.Size(123, 51);
            this.btnIsPN.TabIndex = 4;
            this.btnIsPN.Text = "Asal mı?";
            this.btnIsPN.UseVisualStyleBackColor = false;
            this.btnIsPN.Click += new System.EventHandler(this.btnIsPN_Click);
            // 
            // lbxHistory
            // 
            this.lbxHistory.BackColor = System.Drawing.Color.White;
            this.lbxHistory.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbxHistory.FormattingEnabled = true;
            this.lbxHistory.ItemHeight = 24;
            this.lbxHistory.Location = new System.Drawing.Point(12, 82);
            this.lbxHistory.Name = "lbxHistory";
            this.lbxHistory.Size = new System.Drawing.Size(221, 460);
            this.lbxHistory.TabIndex = 5;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumber.ForeColor = System.Drawing.Color.Gray;
            this.lblNumber.Location = new System.Drawing.Point(334, 165);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(139, 40);
            this.lblNumber.TabIndex = 6;
            this.lblNumber.Text = "Number";
            this.lblNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lbxHistory);
            this.Controls.Add(this.btnIsPN);
            this.Controls.Add(this.tbxPN);
            this.Controls.Add(this.lblBottomPN);
            this.Controls.Add(this.lblPN);
            this.Controls.Add(this.lblUpperPN);
            this.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asal Sayı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblUpperPN;
        private Label lblPN;
        private Label lblBottomPN;
        private TextBox tbxPN;
        private Button btnIsPN;
        private ListBox lbxHistory;
        private Label lblNumber;
    }
}
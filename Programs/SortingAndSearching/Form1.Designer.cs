namespace SortingAndSearching
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
            this.label1 = new System.Windows.Forms.Label();
            this.gbxDataEntrySettings = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnDigital = new System.Windows.Forms.RadioButton();
            this.rbtnCharacteristic = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnManuel = new System.Windows.Forms.RadioButton();
            this.rbtnAuto = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxDataInput = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInput = new System.Windows.Forms.Button();
            this.tbxInput = new System.Windows.Forms.TextBox();
            this.gbxDataEntrySettings.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbxDataInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(118, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(579, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Verileri kendiniz mi girmek istersiniz?\r\nYoksa verileri bilgisayar tarafından olu" +
    "şturmak mı istersiniz?";
            // 
            // gbxDataEntrySettings
            // 
            this.gbxDataEntrySettings.BackColor = System.Drawing.Color.DarkGray;
            this.gbxDataEntrySettings.Controls.Add(this.groupBox2);
            this.gbxDataEntrySettings.Controls.Add(this.groupBox1);
            this.gbxDataEntrySettings.Controls.Add(this.label2);
            this.gbxDataEntrySettings.Controls.Add(this.label1);
            this.gbxDataEntrySettings.Location = new System.Drawing.Point(50, 25);
            this.gbxDataEntrySettings.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.gbxDataEntrySettings.Name = "gbxDataEntrySettings";
            this.gbxDataEntrySettings.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.gbxDataEntrySettings.Size = new System.Drawing.Size(900, 290);
            this.gbxDataEntrySettings.TabIndex = 3;
            this.gbxDataEntrySettings.TabStop = false;
            this.gbxDataEntrySettings.Text = "Veri Giriş Ayarları";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnDigital);
            this.groupBox2.Controls.Add(this.rbtnCharacteristic);
            this.groupBox2.Location = new System.Drawing.Point(118, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 70);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // rbtnDigital
            // 
            this.rbtnDigital.AutoSize = true;
            this.rbtnDigital.BackColor = System.Drawing.Color.Tomato;
            this.rbtnDigital.Checked = true;
            this.rbtnDigital.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnDigital.Location = new System.Drawing.Point(14, 28);
            this.rbtnDigital.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.rbtnDigital.Name = "rbtnDigital";
            this.rbtnDigital.Size = new System.Drawing.Size(101, 29);
            this.rbtnDigital.TabIndex = 4;
            this.rbtnDigital.TabStop = true;
            this.rbtnDigital.Text = "Sayısal";
            this.rbtnDigital.UseVisualStyleBackColor = false;
            // 
            // rbtnCharacteristic
            // 
            this.rbtnCharacteristic.AutoSize = true;
            this.rbtnCharacteristic.BackColor = System.Drawing.Color.Tomato;
            this.rbtnCharacteristic.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnCharacteristic.Location = new System.Drawing.Point(123, 28);
            this.rbtnCharacteristic.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.rbtnCharacteristic.Name = "rbtnCharacteristic";
            this.rbtnCharacteristic.Size = new System.Drawing.Size(138, 29);
            this.rbtnCharacteristic.TabIndex = 5;
            this.rbtnCharacteristic.Text = "Karaktersel";
            this.rbtnCharacteristic.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnManuel);
            this.groupBox1.Controls.Add(this.rbtnAuto);
            this.groupBox1.Location = new System.Drawing.Point(118, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 70);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // rbtnManuel
            // 
            this.rbtnManuel.AutoSize = true;
            this.rbtnManuel.BackColor = System.Drawing.Color.Tomato;
            this.rbtnManuel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnManuel.Location = new System.Drawing.Point(150, 28);
            this.rbtnManuel.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.rbtnManuel.Name = "rbtnManuel";
            this.rbtnManuel.Size = new System.Drawing.Size(103, 29);
            this.rbtnManuel.TabIndex = 1;
            this.rbtnManuel.Text = "Kendim";
            this.rbtnManuel.UseVisualStyleBackColor = false;
            // 
            // rbtnAuto
            // 
            this.rbtnAuto.AutoSize = true;
            this.rbtnAuto.BackColor = System.Drawing.Color.Tomato;
            this.rbtnAuto.Checked = true;
            this.rbtnAuto.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnAuto.Location = new System.Drawing.Point(14, 28);
            this.rbtnAuto.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.rbtnAuto.Name = "rbtnAuto";
            this.rbtnAuto.Size = new System.Drawing.Size(124, 29);
            this.rbtnAuto.TabIndex = 2;
            this.rbtnAuto.TabStop = true;
            this.rbtnAuto.Text = "Bilgisayar";
            this.rbtnAuto.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(118, 163);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(449, 50);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sayısal veriler mi girmek istersiniz?\r\nYoksa Karaktersel veriler mi girmek isters" +
    "iniz?";
            // 
            // gbxDataInput
            // 
            this.gbxDataInput.BackColor = System.Drawing.Color.DarkGray;
            this.gbxDataInput.Controls.Add(this.label4);
            this.gbxDataInput.Controls.Add(this.label3);
            this.gbxDataInput.Controls.Add(this.btnInput);
            this.gbxDataInput.Controls.Add(this.tbxInput);
            this.gbxDataInput.Location = new System.Drawing.Point(50, 350);
            this.gbxDataInput.Name = "gbxDataInput";
            this.gbxDataInput.Size = new System.Drawing.Size(900, 310);
            this.gbxDataInput.TabIndex = 4;
            this.gbxDataInput.TabStop = false;
            this.gbxDataInput.Text = "Veri Girişi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(34, 99);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(825, 50);
            this.label4.TabIndex = 7;
            this.label4.Text = "Gireceği Sayısal veriler [-10000, 10000] aralığındaki tam sayılar olabilir.\r\nGire" +
    "ceği Karaktersel veriler \"a, b, c, ..., A, ..., V, Y, Z\" olarak Türkçe karakterl" +
    "er olabilir.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(34, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(486, 50);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sayısal veriyi \"2, 8, 7, ..., 0\" formatında giriniz.\r\nKaraktersel veriyi \"a, g, E" +
    ", ..., l\" formatında giriniz.";
            // 
            // btnInput
            // 
            this.btnInput.BackColor = System.Drawing.Color.Tomato;
            this.btnInput.Location = new System.Drawing.Point(380, 264);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(140, 40);
            this.btnInput.TabIndex = 1;
            this.btnInput.Text = "Veriyi gir";
            this.btnInput.UseVisualStyleBackColor = false;
            // 
            // tbxInput
            // 
            this.tbxInput.Location = new System.Drawing.Point(6, 158);
            this.tbxInput.Multiline = true;
            this.tbxInput.Name = "tbxInput";
            this.tbxInput.Size = new System.Drawing.Size(888, 100);
            this.tbxInput.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(984, 961);
            this.Controls.Add(this.gbxDataInput);
            this.Controls.Add(this.gbxDataEntrySettings);
            this.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxDataEntrySettings.ResumeLayout(false);
            this.gbxDataEntrySettings.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxDataInput.ResumeLayout(false);
            this.gbxDataInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private GroupBox gbxDataEntrySettings;
        private Label label2;
        private RadioButton rbtnCharacteristic;
        private RadioButton rbtnDigital;
        private GroupBox gbxDataInput;
        private Button btnInput;
        private TextBox tbxInput;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private RadioButton rbtnManuel;
        private RadioButton rbtnAuto;
        private GroupBox groupBox2;
    }
}
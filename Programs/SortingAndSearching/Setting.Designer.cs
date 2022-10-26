namespace SortingAndSearching
{
    partial class Setting
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
            this.btnConfirmDataEntrySettings = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnCharacteristic = new System.Windows.Forms.RadioButton();
            this.rbtnDigital = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnManuel = new System.Windows.Forms.RadioButton();
            this.rbtnAuto = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxDataInput = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEnterData = new System.Windows.Forms.Button();
            this.tbxInput = new System.Windows.Forms.TextBox();
            this.gbxAutoDataSettings = new System.Windows.Forms.GroupBox();
            this.btnCreateData = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAutoDataCount = new System.Windows.Forms.Label();
            this.tbrAutoDataCount = new System.Windows.Forms.TrackBar();
            this.gbxDataEntrySettings.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbxDataInput.SuspendLayout();
            this.gbxAutoDataSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbrAutoDataCount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(579, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Verileri kendiniz mi girmek istersiniz?\r\nYoksa verileri bilgisayar tarafından olu" +
    "şturmak mı istersiniz?";
            // 
            // gbxDataEntrySettings
            // 
            this.gbxDataEntrySettings.BackColor = System.Drawing.Color.DarkGray;
            this.gbxDataEntrySettings.Controls.Add(this.btnConfirmDataEntrySettings);
            this.gbxDataEntrySettings.Controls.Add(this.groupBox2);
            this.gbxDataEntrySettings.Controls.Add(this.groupBox1);
            this.gbxDataEntrySettings.Controls.Add(this.label2);
            this.gbxDataEntrySettings.Controls.Add(this.label1);
            this.gbxDataEntrySettings.Location = new System.Drawing.Point(12, 15);
            this.gbxDataEntrySettings.Name = "gbxDataEntrySettings";
            this.gbxDataEntrySettings.Size = new System.Drawing.Size(760, 338);
            this.gbxDataEntrySettings.TabIndex = 3;
            this.gbxDataEntrySettings.TabStop = false;
            this.gbxDataEntrySettings.Text = "Veri Giriş Ayarları";
            // 
            // btnConfirmDataEntrySettings
            // 
            this.btnConfirmDataEntrySettings.BackColor = System.Drawing.Color.Tomato;
            this.btnConfirmDataEntrySettings.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmDataEntrySettings.Location = new System.Drawing.Point(651, 286);
            this.btnConfirmDataEntrySettings.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirmDataEntrySettings.Name = "btnConfirmDataEntrySettings";
            this.btnConfirmDataEntrySettings.Size = new System.Drawing.Size(104, 47);
            this.btnConfirmDataEntrySettings.TabIndex = 8;
            this.btnConfirmDataEntrySettings.Text = "Onayla";
            this.btnConfirmDataEntrySettings.UseVisualStyleBackColor = false;
            this.btnConfirmDataEntrySettings.Click += new System.EventHandler(this.btnConfirmDataEntrySettings_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnCharacteristic);
            this.groupBox2.Controls.Add(this.rbtnDigital);
            this.groupBox2.Location = new System.Drawing.Point(27, 260);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(302, 60);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // rbtnCharacteristic
            // 
            this.rbtnCharacteristic.AutoSize = true;
            this.rbtnCharacteristic.BackColor = System.Drawing.Color.Tomato;
            this.rbtnCharacteristic.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnCharacteristic.Location = new System.Drawing.Point(151, 18);
            this.rbtnCharacteristic.Name = "rbtnCharacteristic";
            this.rbtnCharacteristic.Size = new System.Drawing.Size(138, 29);
            this.rbtnCharacteristic.TabIndex = 5;
            this.rbtnCharacteristic.Text = "Karaktersel";
            this.rbtnCharacteristic.UseVisualStyleBackColor = false;
            // 
            // rbtnDigital
            // 
            this.rbtnDigital.AutoSize = true;
            this.rbtnDigital.BackColor = System.Drawing.Color.Tomato;
            this.rbtnDigital.Checked = true;
            this.rbtnDigital.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnDigital.Location = new System.Drawing.Point(11, 18);
            this.rbtnDigital.Name = "rbtnDigital";
            this.rbtnDigital.Size = new System.Drawing.Size(101, 29);
            this.rbtnDigital.TabIndex = 4;
            this.rbtnDigital.TabStop = true;
            this.rbtnDigital.Text = "Sayısal";
            this.rbtnDigital.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnManuel);
            this.groupBox1.Controls.Add(this.rbtnAuto);
            this.groupBox1.Location = new System.Drawing.Point(27, 97);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(302, 60);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // rbtnManuel
            // 
            this.rbtnManuel.AutoSize = true;
            this.rbtnManuel.BackColor = System.Drawing.Color.Tomato;
            this.rbtnManuel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnManuel.Location = new System.Drawing.Point(186, 18);
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
            this.rbtnAuto.Location = new System.Drawing.Point(11, 18);
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
            this.label2.Location = new System.Drawing.Point(27, 186);
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
            this.gbxDataInput.Controls.Add(this.btnEnterData);
            this.gbxDataInput.Controls.Add(this.tbxInput);
            this.gbxDataInput.Enabled = false;
            this.gbxDataInput.Location = new System.Drawing.Point(12, 371);
            this.gbxDataInput.Margin = new System.Windows.Forms.Padding(2);
            this.gbxDataInput.Name = "gbxDataInput";
            this.gbxDataInput.Padding = new System.Windows.Forms.Padding(2);
            this.gbxDataInput.Size = new System.Drawing.Size(760, 392);
            this.gbxDataInput.TabIndex = 4;
            this.gbxDataInput.TabStop = false;
            this.gbxDataInput.Text = "Veri Girişi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(27, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(560, 100);
            this.label4.TabIndex = 7;
            this.label4.Text = "Gireceğiniz Sayısal veriler:\r\n[-10000, 10000] aralığındaki tam sayılar olabilir.\r" +
    "\nGireceğiniz Karaktersel veriler:\r\n\"a, b, c, ..., A, ..., V, Y, Z\" olarak Türkçe" +
    " karakterler olabilir.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(27, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(486, 50);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sayısal veriyi \"2, 8, 7, ..., 0\" formatında giriniz.\r\nKaraktersel veriyi \"a, g, E" +
    ", ..., l\" formatında giriniz.";
            // 
            // btnEnterData
            // 
            this.btnEnterData.BackColor = System.Drawing.Color.Tomato;
            this.btnEnterData.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEnterData.Location = new System.Drawing.Point(27, 329);
            this.btnEnterData.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnterData.Name = "btnEnterData";
            this.btnEnterData.Size = new System.Drawing.Size(146, 47);
            this.btnEnterData.TabIndex = 1;
            this.btnEnterData.Text = "Veriyi gir";
            this.btnEnterData.UseVisualStyleBackColor = false;
            this.btnEnterData.Click += new System.EventHandler(this.btnEnterData_Click);
            // 
            // tbxInput
            // 
            this.tbxInput.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxInput.Location = new System.Drawing.Point(26, 240);
            this.tbxInput.Margin = new System.Windows.Forms.Padding(2);
            this.tbxInput.Multiline = true;
            this.tbxInput.Name = "tbxInput";
            this.tbxInput.Size = new System.Drawing.Size(703, 64);
            this.tbxInput.TabIndex = 0;
            // 
            // gbxAutoDataSettings
            // 
            this.gbxAutoDataSettings.BackColor = System.Drawing.Color.DarkGray;
            this.gbxAutoDataSettings.Controls.Add(this.btnCreateData);
            this.gbxAutoDataSettings.Controls.Add(this.label5);
            this.gbxAutoDataSettings.Controls.Add(this.lblAutoDataCount);
            this.gbxAutoDataSettings.Controls.Add(this.tbrAutoDataCount);
            this.gbxAutoDataSettings.Enabled = false;
            this.gbxAutoDataSettings.Location = new System.Drawing.Point(12, 781);
            this.gbxAutoDataSettings.Margin = new System.Windows.Forms.Padding(2);
            this.gbxAutoDataSettings.Name = "gbxAutoDataSettings";
            this.gbxAutoDataSettings.Padding = new System.Windows.Forms.Padding(2);
            this.gbxAutoDataSettings.Size = new System.Drawing.Size(760, 169);
            this.gbxAutoDataSettings.TabIndex = 5;
            this.gbxAutoDataSettings.TabStop = false;
            this.gbxAutoDataSettings.Text = "Üretilecek Veri Ayarları";
            // 
            // btnCreateData
            // 
            this.btnCreateData.BackColor = System.Drawing.Color.Tomato;
            this.btnCreateData.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreateData.Location = new System.Drawing.Point(26, 125);
            this.btnCreateData.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateData.Name = "btnCreateData";
            this.btnCreateData.Size = new System.Drawing.Size(152, 40);
            this.btnCreateData.TabIndex = 8;
            this.btnCreateData.Text = "Veriyi Oluştur";
            this.btnCreateData.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Tomato;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(309, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(420, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Sayıyı yavaş yavaş arttırmak için klavye ok tuşlarını kullanınız!";
            // 
            // lblAutoDataCount
            // 
            this.lblAutoDataCount.AutoSize = true;
            this.lblAutoDataCount.BackColor = System.Drawing.Color.Tomato;
            this.lblAutoDataCount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAutoDataCount.Location = new System.Drawing.Point(27, 26);
            this.lblAutoDataCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAutoDataCount.Name = "lblAutoDataCount";
            this.lblAutoDataCount.Size = new System.Drawing.Size(17, 18);
            this.lblAutoDataCount.TabIndex = 1;
            this.lblAutoDataCount.Text = "2";
            // 
            // tbrAutoDataCount
            // 
            this.tbrAutoDataCount.BackColor = System.Drawing.Color.Tomato;
            this.tbrAutoDataCount.LargeChange = 1;
            this.tbrAutoDataCount.Location = new System.Drawing.Point(26, 55);
            this.tbrAutoDataCount.Margin = new System.Windows.Forms.Padding(2);
            this.tbrAutoDataCount.Maximum = 100000;
            this.tbrAutoDataCount.Minimum = 2;
            this.tbrAutoDataCount.Name = "tbrAutoDataCount";
            this.tbrAutoDataCount.Size = new System.Drawing.Size(703, 45);
            this.tbrAutoDataCount.TabIndex = 0;
            this.tbrAutoDataCount.Value = 2;
            this.tbrAutoDataCount.Scroll += new System.EventHandler(this.tbrAutoDataCount_Scroll);
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(784, 961);
            this.Controls.Add(this.gbxAutoDataSettings);
            this.Controls.Add(this.gbxDataInput);
            this.Controls.Add(this.gbxDataEntrySettings);
            this.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Setting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sıralama ve Arama";
            this.gbxDataEntrySettings.ResumeLayout(false);
            this.gbxDataEntrySettings.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxDataInput.ResumeLayout(false);
            this.gbxDataInput.PerformLayout();
            this.gbxAutoDataSettings.ResumeLayout(false);
            this.gbxAutoDataSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbrAutoDataCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private GroupBox gbxDataEntrySettings;
        private Label label2;
        private RadioButton rbtnCharacteristic;
        private RadioButton rbtnDigital;
        private GroupBox gbxDataInput;
        private Button btnEnterData;
        private TextBox tbxInput;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private RadioButton rbtnManuel;
        private RadioButton rbtnAuto;
        private GroupBox groupBox2;
        private GroupBox gbxAutoDataSettings;
        private TrackBar tbrAutoDataCount;
        private Label lblAutoDataCount;
        private Label label5;
        private Button btnCreateData;
        private Button btnConfirmDataEntrySettings;
    }
}
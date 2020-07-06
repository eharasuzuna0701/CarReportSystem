namespace CarReportSystem
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.cBRecorder = new System.Windows.Forms.ComboBox();
            this.dTPDate = new System.Windows.Forms.DateTimePicker();
            this.cBCarName = new System.Windows.Forms.ComboBox();
            this.rBToyota = new System.Windows.Forms.RadioButton();
            this.rBNissan = new System.Windows.Forms.RadioButton();
            this.rBhonda = new System.Windows.Forms.RadioButton();
            this.rBSubaru = new System.Windows.Forms.RadioButton();
            this.rBImportedCar = new System.Windows.Forms.RadioButton();
            this.rBOthers = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tBReportText = new System.Windows.Forms.TextBox();
            this.dGVCarDate = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btImageOapen = new System.Windows.Forms.Button();
            this.btImageClear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btDetaOapen = new System.Windows.Forms.Button();
            this.btDetaSave = new System.Windows.Forms.Button();
            this.btDateAdditional = new System.Windows.Forms.Button();
            this.btDateCorrection = new System.Windows.Forms.Button();
            this.btDateDelete = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVCarDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // cBRecorder
            // 
            this.cBRecorder.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cBRecorder.FormattingEnabled = true;
            this.cBRecorder.Location = new System.Drawing.Point(95, 75);
            this.cBRecorder.Name = "cBRecorder";
            this.cBRecorder.Size = new System.Drawing.Size(200, 24);
            this.cBRecorder.TabIndex = 0;
            // 
            // dTPDate
            // 
            this.dTPDate.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dTPDate.Location = new System.Drawing.Point(95, 12);
            this.dTPDate.Name = "dTPDate";
            this.dTPDate.Size = new System.Drawing.Size(200, 23);
            this.dTPDate.TabIndex = 1;
            // 
            // cBCarName
            // 
            this.cBCarName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cBCarName.FormattingEnabled = true;
            this.cBCarName.Location = new System.Drawing.Point(95, 127);
            this.cBCarName.Name = "cBCarName";
            this.cBCarName.Size = new System.Drawing.Size(200, 24);
            this.cBCarName.TabIndex = 3;
            // 
            // rBToyota
            // 
            this.rBToyota.AutoSize = true;
            this.rBToyota.Location = new System.Drawing.Point(95, 105);
            this.rBToyota.Name = "rBToyota";
            this.rBToyota.Size = new System.Drawing.Size(47, 16);
            this.rBToyota.TabIndex = 4;
            this.rBToyota.TabStop = true;
            this.rBToyota.Text = "トヨタ";
            this.rBToyota.UseVisualStyleBackColor = true;
            // 
            // rBNissan
            // 
            this.rBNissan.AutoSize = true;
            this.rBNissan.Location = new System.Drawing.Point(148, 105);
            this.rBNissan.Name = "rBNissan";
            this.rBNissan.Size = new System.Drawing.Size(47, 16);
            this.rBNissan.TabIndex = 5;
            this.rBNissan.TabStop = true;
            this.rBNissan.Text = "日産";
            this.rBNissan.UseVisualStyleBackColor = true;
            // 
            // rBhonda
            // 
            this.rBhonda.AutoSize = true;
            this.rBhonda.Location = new System.Drawing.Point(201, 105);
            this.rBhonda.Name = "rBhonda";
            this.rBhonda.Size = new System.Drawing.Size(51, 16);
            this.rBhonda.TabIndex = 6;
            this.rBhonda.TabStop = true;
            this.rBhonda.Text = "ホンダ";
            this.rBhonda.UseVisualStyleBackColor = true;
            // 
            // rBSubaru
            // 
            this.rBSubaru.AutoSize = true;
            this.rBSubaru.Location = new System.Drawing.Point(258, 105);
            this.rBSubaru.Name = "rBSubaru";
            this.rBSubaru.Size = new System.Drawing.Size(52, 16);
            this.rBSubaru.TabIndex = 7;
            this.rBSubaru.TabStop = true;
            this.rBSubaru.Text = "スバル";
            this.rBSubaru.UseVisualStyleBackColor = true;
            // 
            // rBImportedCar
            // 
            this.rBImportedCar.AutoSize = true;
            this.rBImportedCar.Location = new System.Drawing.Point(316, 105);
            this.rBImportedCar.Name = "rBImportedCar";
            this.rBImportedCar.Size = new System.Drawing.Size(47, 16);
            this.rBImportedCar.TabIndex = 8;
            this.rBImportedCar.TabStop = true;
            this.rBImportedCar.Text = "外車";
            this.rBImportedCar.UseVisualStyleBackColor = true;
            // 
            // rBOthers
            // 
            this.rBOthers.AutoSize = true;
            this.rBOthers.Location = new System.Drawing.Point(369, 105);
            this.rBOthers.Name = "rBOthers";
            this.rBOthers.Size = new System.Drawing.Size(54, 16);
            this.rBOthers.TabIndex = 9;
            this.rBOthers.TabStop = true;
            this.rBOthers.Text = "その他";
            this.rBOthers.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(41, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "日付：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(9, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "記録者名：";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(557, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 198);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // tBReportText
            // 
            this.tBReportText.Location = new System.Drawing.Point(95, 189);
            this.tBReportText.Multiline = true;
            this.tBReportText.Name = "tBReportText";
            this.tBReportText.Size = new System.Drawing.Size(453, 114);
            this.tBReportText.TabIndex = 13;
            // 
            // dGVCarDate
            // 
            this.dGVCarDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVCarDate.Location = new System.Drawing.Point(98, 317);
            this.dGVCarDate.Name = "dGVCarDate";
            this.dGVCarDate.RowTemplate.Height = 21;
            this.dGVCarDate.Size = new System.Drawing.Size(679, 154);
            this.dGVCarDate.TabIndex = 14;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::CarReportSystem.Properties.Resources.illust3784;
            this.pictureBox2.Location = new System.Drawing.Point(12, 157);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(539, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CarReportSystem.Properties.Resources.illust3784;
            this.pictureBox3.Location = new System.Drawing.Point(12, 43);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(536, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // btImageOapen
            // 
            this.btImageOapen.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.btImageOapen.Location = new System.Drawing.Point(618, 240);
            this.btImageOapen.Name = "btImageOapen";
            this.btImageOapen.Size = new System.Drawing.Size(75, 63);
            this.btImageOapen.TabIndex = 17;
            this.btImageOapen.Text = "開く";
            this.btImageOapen.UseVisualStyleBackColor = true;
            // 
            // btImageClear
            // 
            this.btImageClear.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.btImageClear.Location = new System.Drawing.Point(699, 240);
            this.btImageClear.Name = "btImageClear";
            this.btImageClear.Size = new System.Drawing.Size(75, 63);
            this.btImageClear.TabIndex = 18;
            this.btImageClear.Text = "クリア";
            this.btImageClear.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(25, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "メーカー：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(41, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "車名：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(24, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "レポート：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(9, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "記録一覧：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(554, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "画像：";
            // 
            // btDetaOapen
            // 
            this.btDetaOapen.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.btDetaOapen.Location = new System.Drawing.Point(14, 350);
            this.btDetaOapen.Name = "btDetaOapen";
            this.btDetaOapen.Size = new System.Drawing.Size(75, 23);
            this.btDetaOapen.TabIndex = 24;
            this.btDetaOapen.Text = "開く";
            this.btDetaOapen.UseVisualStyleBackColor = true;
            // 
            // btDetaSave
            // 
            this.btDetaSave.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.btDetaSave.Location = new System.Drawing.Point(14, 379);
            this.btDetaSave.Name = "btDetaSave";
            this.btDetaSave.Size = new System.Drawing.Size(75, 23);
            this.btDetaSave.TabIndex = 25;
            this.btDetaSave.Text = "保存";
            this.btDetaSave.UseVisualStyleBackColor = true;
            // 
            // btDateAdditional
            // 
            this.btDateAdditional.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.btDateAdditional.Location = new System.Drawing.Point(510, 477);
            this.btDateAdditional.Name = "btDateAdditional";
            this.btDateAdditional.Size = new System.Drawing.Size(75, 23);
            this.btDateAdditional.TabIndex = 26;
            this.btDateAdditional.Text = "追加";
            this.btDateAdditional.UseVisualStyleBackColor = true;
            // 
            // btDateCorrection
            // 
            this.btDateCorrection.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.btDateCorrection.Location = new System.Drawing.Point(603, 477);
            this.btDateCorrection.Name = "btDateCorrection";
            this.btDateCorrection.Size = new System.Drawing.Size(75, 23);
            this.btDateCorrection.TabIndex = 27;
            this.btDateCorrection.Text = "更新";
            this.btDateCorrection.UseVisualStyleBackColor = true;
            // 
            // btDateDelete
            // 
            this.btDateDelete.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.btDateDelete.Location = new System.Drawing.Point(699, 477);
            this.btDateDelete.Name = "btDateDelete";
            this.btDateDelete.Size = new System.Drawing.Size(75, 23);
            this.btDateDelete.TabIndex = 28;
            this.btDateDelete.Text = "削除";
            this.btDateDelete.UseVisualStyleBackColor = true;
            // 
            // btClose
            // 
            this.btClose.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btClose.Location = new System.Drawing.Point(14, 448);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 29;
            this.btClose.Text = "終了";
            this.btClose.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btDateDelete);
            this.Controls.Add(this.btDateCorrection);
            this.Controls.Add(this.btDateAdditional);
            this.Controls.Add(this.btDetaSave);
            this.Controls.Add(this.btDetaOapen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btImageClear);
            this.Controls.Add(this.btImageOapen);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dGVCarDate);
            this.Controls.Add(this.tBReportText);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rBOthers);
            this.Controls.Add(this.rBImportedCar);
            this.Controls.Add(this.rBSubaru);
            this.Controls.Add(this.rBhonda);
            this.Controls.Add(this.rBNissan);
            this.Controls.Add(this.rBToyota);
            this.Controls.Add(this.cBCarName);
            this.Controls.Add(this.dTPDate);
            this.Controls.Add(this.cBRecorder);
            this.Name = "Form1";
            this.Text = "試乗レポート管理システム";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVCarDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBRecorder;
        private System.Windows.Forms.DateTimePicker dTPDate;
        private System.Windows.Forms.ComboBox cBCarName;
        private System.Windows.Forms.RadioButton rBToyota;
        private System.Windows.Forms.RadioButton rBNissan;
        private System.Windows.Forms.RadioButton rBhonda;
        private System.Windows.Forms.RadioButton rBSubaru;
        private System.Windows.Forms.RadioButton rBImportedCar;
        private System.Windows.Forms.RadioButton rBOthers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tBReportText;
        private System.Windows.Forms.DataGridView dGVCarDate;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btImageOapen;
        private System.Windows.Forms.Button btImageClear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btDetaOapen;
        private System.Windows.Forms.Button btDetaSave;
        private System.Windows.Forms.Button btDateAdditional;
        private System.Windows.Forms.Button btDateCorrection;
        private System.Windows.Forms.Button btDateDelete;
        private System.Windows.Forms.Button btClose;
    }
}


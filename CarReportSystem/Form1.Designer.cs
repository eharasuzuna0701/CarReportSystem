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
            this.components = new System.ComponentModel.Container();
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
            this.pBCarImage = new System.Windows.Forms.PictureBox();
            this.tbReport = new System.Windows.Forms.TextBox();
            this.carReprtBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.btDateAdd = new System.Windows.Forms.Button();
            this.btDateCorrection = new System.Windows.Forms.Button();
            this.btDateDelete = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.oFDImage = new System.Windows.Forms.OpenFileDialog();
            this.sfdSaveData = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oFDsaveFile = new System.Windows.Forms.OpenFileDialog();
            this.gBMaker = new System.Windows.Forms.GroupBox();
            this.dGVCarDate = new System.Windows.Forms.DataGridView();
            this.tBSearchCarName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tBSarchMaker = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btSearchExe = new System.Windows.Forms.Button();
            this.dTPSarchCrenderDate = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.carReprtBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.infosys202017DataSet1 = new CarReportSystem.infosys202017DataSet1();
            this.carReprtTableAdapter1 = new CarReportSystem.infosys202017DataSet1TableAdapters.CarReprtTableAdapter();
            this.tableAdapterManager1 = new CarReportSystem.infosys202017DataSet1TableAdapters.TableAdapterManager();
            this.infosys202017DataSet11 = new CarReportSystem.infosys202017DataSet1();
            ((System.ComponentModel.ISupportInitialize)(this.pBCarImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carReprtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.gBMaker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVCarDate)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carReprtBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202017DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202017DataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // cBRecorder
            // 
            this.cBRecorder.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cBRecorder.FormattingEnabled = true;
            this.cBRecorder.Location = new System.Drawing.Point(95, 92);
            this.cBRecorder.Name = "cBRecorder";
            this.cBRecorder.Size = new System.Drawing.Size(200, 24);
            this.cBRecorder.TabIndex = 0;
            // 
            // dTPDate
            // 
            this.dTPDate.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dTPDate.Location = new System.Drawing.Point(95, 63);
            this.dTPDate.Name = "dTPDate";
            this.dTPDate.Size = new System.Drawing.Size(200, 23);
            this.dTPDate.TabIndex = 1;
            // 
            // cBCarName
            // 
            this.cBCarName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cBCarName.FormattingEnabled = true;
            this.cBCarName.Location = new System.Drawing.Point(98, 168);
            this.cBCarName.Name = "cBCarName";
            this.cBCarName.Size = new System.Drawing.Size(200, 24);
            this.cBCarName.TabIndex = 3;
            // 
            // rBToyota
            // 
            this.rBToyota.AutoSize = true;
            this.rBToyota.Location = new System.Drawing.Point(6, 16);
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
            this.rBNissan.Location = new System.Drawing.Point(69, 16);
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
            this.rBhonda.Location = new System.Drawing.Point(134, 16);
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
            this.rBSubaru.Location = new System.Drawing.Point(203, 16);
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
            this.rBImportedCar.Location = new System.Drawing.Point(274, 16);
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
            this.rBOthers.Location = new System.Drawing.Point(341, 16);
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
            this.label1.Location = new System.Drawing.Point(44, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "日付：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "記録者名：";
            // 
            // pBCarImage
            // 
            this.pBCarImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBCarImage.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.carReprtBindingSource1, "Pictre", true));
            this.pBCarImage.Location = new System.Drawing.Point(632, 69);
            this.pBCarImage.Name = "pBCarImage";
            this.pBCarImage.Size = new System.Drawing.Size(217, 198);
            this.pBCarImage.TabIndex = 12;
            this.pBCarImage.TabStop = false;
            // 
            // tbReport
            // 
            this.tbReport.Location = new System.Drawing.Point(95, 217);
            this.tbReport.Multiline = true;
            this.tbReport.Name = "tbReport";
            this.tbReport.Size = new System.Drawing.Size(453, 83);
            this.tbReport.TabIndex = 13;
            // 
            // carReprtBindingSource
            // 
            this.carReprtBindingSource.DataMember = "CarReprt";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::CarReportSystem.Properties.Resources.illust3784;
            this.pictureBox2.Location = new System.Drawing.Point(15, 306);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(587, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CarReportSystem.Properties.Resources.illust3784;
            this.pictureBox3.Location = new System.Drawing.Point(15, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(834, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // btImageOapen
            // 
            this.btImageOapen.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.btImageOapen.Location = new System.Drawing.Point(693, 273);
            this.btImageOapen.Name = "btImageOapen";
            this.btImageOapen.Size = new System.Drawing.Size(75, 63);
            this.btImageOapen.TabIndex = 17;
            this.btImageOapen.Text = "開く";
            this.btImageOapen.UseVisualStyleBackColor = true;
            this.btImageOapen.Click += new System.EventHandler(this.btImageOapen_Click);
            // 
            // btImageClear
            // 
            this.btImageClear.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.btImageClear.Location = new System.Drawing.Point(774, 273);
            this.btImageClear.Name = "btImageClear";
            this.btImageClear.Size = new System.Drawing.Size(75, 63);
            this.btImageClear.TabIndex = 18;
            this.btImageClear.Text = "クリア";
            this.btImageClear.UseVisualStyleBackColor = true;
            this.btImageClear.Click += new System.EventHandler(this.btImageClear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(25, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "メーカー：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(41, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "車名：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(24, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "レポート：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(9, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "記録一覧：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(629, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "画像：";
            // 
            // btDetaOapen
            // 
            this.btDetaOapen.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.btDetaOapen.Location = new System.Drawing.Point(12, 361);
            this.btDetaOapen.Name = "btDetaOapen";
            this.btDetaOapen.Size = new System.Drawing.Size(75, 23);
            this.btDetaOapen.TabIndex = 24;
            this.btDetaOapen.Text = "接続";
            this.btDetaOapen.UseVisualStyleBackColor = true;
            this.btDetaOapen.Click += new System.EventHandler(this.btDetaOapen_Click);
            // 
            // btDateAdd
            // 
            this.btDateAdd.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.btDateAdd.Location = new System.Drawing.Point(612, 509);
            this.btDateAdd.Name = "btDateAdd";
            this.btDateAdd.Size = new System.Drawing.Size(75, 23);
            this.btDateAdd.TabIndex = 26;
            this.btDateAdd.Text = "追加";
            this.btDateAdd.UseVisualStyleBackColor = true;
            this.btDateAdd.Click += new System.EventHandler(this.btDateAdd_Click);
            // 
            // btDateCorrection
            // 
            this.btDateCorrection.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.btDateCorrection.Location = new System.Drawing.Point(693, 508);
            this.btDateCorrection.Name = "btDateCorrection";
            this.btDateCorrection.Size = new System.Drawing.Size(75, 23);
            this.btDateCorrection.TabIndex = 27;
            this.btDateCorrection.Text = "更新";
            this.btDateCorrection.UseVisualStyleBackColor = true;
            this.btDateCorrection.Click += new System.EventHandler(this.btDateCorrection_Click);
            // 
            // btDateDelete
            // 
            this.btDateDelete.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.btDateDelete.Location = new System.Drawing.Point(774, 509);
            this.btDateDelete.Name = "btDateDelete";
            this.btDateDelete.Size = new System.Drawing.Size(75, 23);
            this.btDateDelete.TabIndex = 28;
            this.btDateDelete.Text = "削除";
            this.btDateDelete.UseVisualStyleBackColor = true;
            this.btDateDelete.Click += new System.EventHandler(this.btDateDelete_Click);
            // 
            // btClose
            // 
            this.btClose.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btClose.Location = new System.Drawing.Point(12, 480);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 29;
            this.btClose.Text = "終了";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // oFDImage
            // 
            this.oFDImage.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1107, 24);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // oFDsaveFile
            // 
            this.oFDsaveFile.FileName = "openFileDialog1";
            // 
            // gBMaker
            // 
            this.gBMaker.Controls.Add(this.rBOthers);
            this.gBMaker.Controls.Add(this.rBToyota);
            this.gBMaker.Controls.Add(this.rBNissan);
            this.gBMaker.Controls.Add(this.rBhonda);
            this.gBMaker.Controls.Add(this.rBSubaru);
            this.gBMaker.Controls.Add(this.rBImportedCar);
            this.gBMaker.Location = new System.Drawing.Point(98, 122);
            this.gBMaker.Name = "gBMaker";
            this.gBMaker.Size = new System.Drawing.Size(401, 40);
            this.gBMaker.TabIndex = 31;
            this.gBMaker.TabStop = false;
            this.gBMaker.Text = "メーカー";
            // 
            // dGVCarDate
            // 
            this.dGVCarDate.AutoGenerateColumns = false;
            this.dGVCarDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVCarDate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewImageColumn1});
            this.dGVCarDate.DataSource = this.carReprtBindingSource1;
            this.dGVCarDate.Location = new System.Drawing.Point(98, 342);
            this.dGVCarDate.Name = "dGVCarDate";
            this.dGVCarDate.RowTemplate.Height = 21;
            this.dGVCarDate.Size = new System.Drawing.Size(751, 161);
            this.dGVCarDate.TabIndex = 31;
            this.dGVCarDate.Click += new System.EventHandler(this.dGVCarDate_CellContentClick);
            // 
            // tBSearchCarName
            // 
            this.tBSearchCarName.Location = new System.Drawing.Point(67, 27);
            this.tBSearchCarName.Name = "tBSearchCarName";
            this.tBSearchCarName.Size = new System.Drawing.Size(138, 19);
            this.tBSearchCarName.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 33;
            this.label8.Text = "車名";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dTPSarchCrenderDate);
            this.groupBox1.Controls.Add(this.tBSarchMaker);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btSearchExe);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tBSearchCarName);
            this.groupBox1.Location = new System.Drawing.Point(884, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 174);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "検索";
            // 
            // tBSarchMaker
            // 
            this.tBSarchMaker.Location = new System.Drawing.Point(67, 91);
            this.tBSarchMaker.Name = "tBSarchMaker";
            this.tBSarchMaker.Size = new System.Drawing.Size(138, 19);
            this.tBSarchMaker.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 12);
            this.label10.TabIndex = 36;
            this.label10.Text = "メーカー";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 35;
            this.label9.Text = "日付";
            // 
            // btSearchExe
            // 
            this.btSearchExe.Location = new System.Drawing.Point(77, 135);
            this.btSearchExe.Name = "btSearchExe";
            this.btSearchExe.Size = new System.Drawing.Size(75, 23);
            this.btSearchExe.TabIndex = 34;
            this.btSearchExe.Text = "探す";
            this.btSearchExe.UseVisualStyleBackColor = true;
            this.btSearchExe.Click += new System.EventHandler(this.btSearchExe_Click);
            // 
            // dTPSarchCrenderDate
            // 
            this.dTPSarchCrenderDate.Location = new System.Drawing.Point(67, 57);
            this.dTPSarchCrenderDate.Name = "dTPSarchCrenderDate";
            this.dTPSarchCrenderDate.Size = new System.Drawing.Size(138, 19);
            this.dTPSarchCrenderDate.TabIndex = 39;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CrenderData";
            this.dataGridViewTextBoxColumn2.HeaderText = "CrenderData";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Recorder";
            this.dataGridViewTextBoxColumn3.HeaderText = "Recorder";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Maker";
            this.dataGridViewTextBoxColumn4.HeaderText = "Maker";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CarName";
            this.dataGridViewTextBoxColumn5.HeaderText = "CarName";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Reprt";
            this.dataGridViewTextBoxColumn6.HeaderText = "Reprt";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Pictre";
            this.dataGridViewImageColumn1.HeaderText = "Pictre";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // carReprtBindingSource1
            // 
            this.carReprtBindingSource1.DataMember = "CarReprt";
            this.carReprtBindingSource1.DataSource = this.infosys202017DataSet1;
            // 
            // infosys202017DataSet1
            // 
            this.infosys202017DataSet1.DataSetName = "infosys202017DataSet1";
            this.infosys202017DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carReprtTableAdapter1
            // 
            this.carReprtTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CarReprtTableAdapter = this.carReprtTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = CarReportSystem.infosys202017DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // infosys202017DataSet11
            // 
            this.infosys202017DataSet11.DataSetName = "infosys202017DataSet1";
            this.infosys202017DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1107, 543);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dGVCarDate);
            this.Controls.Add(this.gBMaker);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btDateDelete);
            this.Controls.Add(this.btDateCorrection);
            this.Controls.Add(this.btDateAdd);
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
            this.Controls.Add(this.tbReport);
            this.Controls.Add(this.pBCarImage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBCarName);
            this.Controls.Add(this.dTPDate);
            this.Controls.Add(this.cBRecorder);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "試乗レポート管理システム";
            ((System.ComponentModel.ISupportInitialize)(this.pBCarImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carReprtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.gBMaker.ResumeLayout(false);
            this.gBMaker.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVCarDate)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carReprtBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202017DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202017DataSet11)).EndInit();
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
        private System.Windows.Forms.PictureBox pBCarImage;
        private System.Windows.Forms.TextBox tbReport;
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
        private System.Windows.Forms.Button btDateAdd;
        private System.Windows.Forms.Button btDateCorrection;
        private System.Windows.Forms.Button btDateDelete;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.OpenFileDialog oFDImage;
        private System.Windows.Forms.SaveFileDialog sfdSaveData;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.OpenFileDialog oFDsaveFile;
        private System.Windows.Forms.GroupBox gBMaker;
        private System.Windows.Forms.BindingSource carReprtBindingSource;
        private infosys202017DataSet1 infosys202017DataSet1;
        private System.Windows.Forms.BindingSource carReprtBindingSource1;
        private infosys202017DataSet1TableAdapters.CarReprtTableAdapter carReprtTableAdapter1;
        private infosys202017DataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView dGVCarDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private infosys202017DataSet1 infosys202017DataSet11;
        private System.Windows.Forms.TextBox tBSearchCarName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btSearchExe;
        private System.Windows.Forms.TextBox tBSarchMaker;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dTPSarchCrenderDate;
    }
}


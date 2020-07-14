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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label crenderDataLabel;
            System.Windows.Forms.Label recorderLabel;
            System.Windows.Forms.Label makerLabel;
            System.Windows.Forms.Label carNameLabel;
            System.Windows.Forms.Label reprtLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.dgd = new System.Windows.Forms.TextBox();
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
            this.btDetaSave = new System.Windows.Forms.Button();
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
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.crenderDataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.recorderTextBox = new System.Windows.Forms.TextBox();
            this.makerTextBox = new System.Windows.Forms.TextBox();
            this.carNameTextBox = new System.Windows.Forms.TextBox();
            this.reprtTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.carReprtBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.infosys202017DataSet1 = new CarReportSystem.infosys202017DataSet1();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crenderDataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recorderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reprtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carReprtTableAdapter1 = new CarReportSystem.infosys202017DataSet1TableAdapters.CarReprtTableAdapter();
            this.tableAdapterManager1 = new CarReportSystem.infosys202017DataSet1TableAdapters.TableAdapterManager();
            idLabel = new System.Windows.Forms.Label();
            crenderDataLabel = new System.Windows.Forms.Label();
            recorderLabel = new System.Windows.Forms.Label();
            makerLabel = new System.Windows.Forms.Label();
            carNameLabel = new System.Windows.Forms.Label();
            reprtLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBCarImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carReprtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.gBMaker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVCarDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carReprtBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202017DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(784, 64);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(16, 12);
            idLabel.TabIndex = 31;
            idLabel.Text = "id:";
            // 
            // crenderDataLabel
            // 
            crenderDataLabel.AutoSize = true;
            crenderDataLabel.Location = new System.Drawing.Point(784, 90);
            crenderDataLabel.Name = "crenderDataLabel";
            crenderDataLabel.Size = new System.Drawing.Size(75, 12);
            crenderDataLabel.TabIndex = 33;
            crenderDataLabel.Text = "Crender Data:";
            // 
            // recorderLabel
            // 
            recorderLabel.AutoSize = true;
            recorderLabel.Location = new System.Drawing.Point(784, 114);
            recorderLabel.Name = "recorderLabel";
            recorderLabel.Size = new System.Drawing.Size(53, 12);
            recorderLabel.TabIndex = 35;
            recorderLabel.Text = "Recorder:";
            // 
            // makerLabel
            // 
            makerLabel.AutoSize = true;
            makerLabel.Location = new System.Drawing.Point(784, 139);
            makerLabel.Name = "makerLabel";
            makerLabel.Size = new System.Drawing.Size(38, 12);
            makerLabel.TabIndex = 37;
            makerLabel.Text = "Maker:";
            // 
            // carNameLabel
            // 
            carNameLabel.AutoSize = true;
            carNameLabel.Location = new System.Drawing.Point(784, 164);
            carNameLabel.Name = "carNameLabel";
            carNameLabel.Size = new System.Drawing.Size(58, 12);
            carNameLabel.TabIndex = 39;
            carNameLabel.Text = "Car Name:";
            // 
            // reprtLabel
            // 
            reprtLabel.AutoSize = true;
            reprtLabel.Location = new System.Drawing.Point(784, 189);
            reprtLabel.Name = "reprtLabel";
            reprtLabel.Size = new System.Drawing.Size(35, 12);
            reprtLabel.TabIndex = 41;
            reprtLabel.Text = "Reprt:";
            // 
            // cBRecorder
            // 
            this.cBRecorder.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carReprtBindingSource1, "Recorder", true));
            this.cBRecorder.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cBRecorder.FormattingEnabled = true;
            this.cBRecorder.Location = new System.Drawing.Point(95, 75);
            this.cBRecorder.Name = "cBRecorder";
            this.cBRecorder.Size = new System.Drawing.Size(200, 24);
            this.cBRecorder.TabIndex = 0;
            // 
            // dTPDate
            // 
            this.dTPDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carReprtBindingSource1, "CrenderData", true));
            this.dTPDate.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dTPDate.Location = new System.Drawing.Point(95, 46);
            this.dTPDate.Name = "dTPDate";
            this.dTPDate.Size = new System.Drawing.Size(200, 23);
            this.dTPDate.TabIndex = 1;
            // 
            // cBCarName
            // 
            this.cBCarName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carReprtBindingSource1, "CarName", true));
            this.cBCarName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cBCarName.FormattingEnabled = true;
            this.cBCarName.Location = new System.Drawing.Point(98, 151);
            this.cBCarName.Name = "cBCarName";
            this.cBCarName.Size = new System.Drawing.Size(200, 24);
            this.cBCarName.TabIndex = 3;
            // 
            // rBToyota
            // 
            this.rBToyota.AutoSize = true;
            this.rBToyota.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carReprtBindingSource1, "Maker", true));
            this.rBToyota.Location = new System.Drawing.Point(0, 18);
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
            this.rBNissan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carReprtBindingSource1, "Maker", true));
            this.rBNissan.Location = new System.Drawing.Point(53, 18);
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
            this.rBhonda.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carReprtBindingSource1, "Maker", true));
            this.rBhonda.Location = new System.Drawing.Point(106, 18);
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
            this.rBSubaru.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carReprtBindingSource1, "Maker", true));
            this.rBSubaru.Location = new System.Drawing.Point(163, 18);
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
            this.rBImportedCar.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carReprtBindingSource1, "Maker", true));
            this.rBImportedCar.Location = new System.Drawing.Point(221, 18);
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
            this.rBOthers.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carReprtBindingSource1, "Maker", true));
            this.rBOthers.Location = new System.Drawing.Point(274, 16);
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
            this.label1.Location = new System.Drawing.Point(44, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "日付：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "記録者名：";
            // 
            // pBCarImage
            // 
            this.pBCarImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBCarImage.Location = new System.Drawing.Point(557, 38);
            this.pBCarImage.Name = "pBCarImage";
            this.pBCarImage.Size = new System.Drawing.Size(217, 198);
            this.pBCarImage.TabIndex = 12;
            this.pBCarImage.TabStop = false;
            // 
            // dgd
            // 
            this.dgd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carReprtBindingSource1, "Reprt", true));
            this.dgd.Location = new System.Drawing.Point(95, 188);
            this.dgd.Multiline = true;
            this.dgd.Name = "dgd";
            this.dgd.Size = new System.Drawing.Size(453, 83);
            this.dgd.TabIndex = 13;
            // 
            // carReprtBindingSource
            // 
            this.carReprtBindingSource.DataMember = "CarReprt";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::CarReportSystem.Properties.Resources.illust3784;
            this.pictureBox2.Location = new System.Drawing.Point(15, 277);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(533, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CarReportSystem.Properties.Resources.illust3784;
            this.pictureBox3.Location = new System.Drawing.Point(15, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(533, 26);
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
            this.btImageOapen.Click += new System.EventHandler(this.btImageOapen_Click);
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
            this.btImageClear.Click += new System.EventHandler(this.btImageClear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(25, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "メーカー：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(41, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "車名：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(24, 188);
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
            this.btDetaOapen.Click += new System.EventHandler(this.btDetaOapen_Click);
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
            this.btDetaSave.Click += new System.EventHandler(this.btDetaSave_Click);
            // 
            // btDateAdd
            // 
            this.btDateAdd.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.btDateAdd.Location = new System.Drawing.Point(510, 477);
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
            this.btDateCorrection.Location = new System.Drawing.Point(603, 477);
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
            this.btDateDelete.Location = new System.Drawing.Point(699, 477);
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
            this.btClose.Location = new System.Drawing.Point(14, 448);
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
            this.menuStrip1.Size = new System.Drawing.Size(1138, 24);
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
            this.gBMaker.Location = new System.Drawing.Point(98, 105);
            this.gBMaker.Name = "gBMaker";
            this.gBMaker.Size = new System.Drawing.Size(350, 40);
            this.gBMaker.TabIndex = 31;
            this.gBMaker.TabStop = false;
            this.gBMaker.Text = "メーカー";
            // 
            // dGVCarDate
            // 
            this.dGVCarDate.AutoGenerateColumns = false;
            this.dGVCarDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVCarDate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.crenderDataDataGridViewTextBoxColumn,
            this.recorderDataGridViewTextBoxColumn,
            this.makerDataGridViewTextBoxColumn,
            this.carNameDataGridViewTextBoxColumn,
            this.reprtDataGridViewTextBoxColumn});
            this.dGVCarDate.DataSource = this.carReprtBindingSource1;
            this.dGVCarDate.Location = new System.Drawing.Point(95, 310);
            this.dGVCarDate.Name = "dGVCarDate";
            this.dGVCarDate.RowTemplate.Height = 21;
            this.dGVCarDate.Size = new System.Drawing.Size(676, 161);
            this.dGVCarDate.TabIndex = 31;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carReprtBindingSource1, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(865, 61);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 19);
            this.idTextBox.TabIndex = 32;
            // 
            // crenderDataDateTimePicker
            // 
            this.crenderDataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.carReprtBindingSource1, "CrenderData", true));
            this.crenderDataDateTimePicker.Location = new System.Drawing.Point(865, 86);
            this.crenderDataDateTimePicker.Name = "crenderDataDateTimePicker";
            this.crenderDataDateTimePicker.Size = new System.Drawing.Size(200, 19);
            this.crenderDataDateTimePicker.TabIndex = 34;
            // 
            // recorderTextBox
            // 
            this.recorderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carReprtBindingSource1, "Recorder", true));
            this.recorderTextBox.Location = new System.Drawing.Point(865, 111);
            this.recorderTextBox.Name = "recorderTextBox";
            this.recorderTextBox.Size = new System.Drawing.Size(200, 19);
            this.recorderTextBox.TabIndex = 36;
            // 
            // makerTextBox
            // 
            this.makerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carReprtBindingSource1, "Maker", true));
            this.makerTextBox.Location = new System.Drawing.Point(865, 136);
            this.makerTextBox.Name = "makerTextBox";
            this.makerTextBox.Size = new System.Drawing.Size(200, 19);
            this.makerTextBox.TabIndex = 38;
            // 
            // carNameTextBox
            // 
            this.carNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carReprtBindingSource1, "CarName", true));
            this.carNameTextBox.Location = new System.Drawing.Point(865, 161);
            this.carNameTextBox.Name = "carNameTextBox";
            this.carNameTextBox.Size = new System.Drawing.Size(200, 19);
            this.carNameTextBox.TabIndex = 40;
            // 
            // reprtTextBox
            // 
            this.reprtTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.carReprtBindingSource1, "Reprt", true));
            this.reprtTextBox.Location = new System.Drawing.Point(865, 186);
            this.reprtTextBox.Name = "reprtTextBox";
            this.reprtTextBox.Size = new System.Drawing.Size(200, 19);
            this.reprtTextBox.TabIndex = 42;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 24);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1138, 25);
            this.bindingNavigator1.TabIndex = 43;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "新規追加";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目の総数";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "削除";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "最初に移動";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "前に戻る";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "現在の場所";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "次に移動";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "最後に移動";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // crenderDataDataGridViewTextBoxColumn
            // 
            this.crenderDataDataGridViewTextBoxColumn.DataPropertyName = "CrenderData";
            this.crenderDataDataGridViewTextBoxColumn.HeaderText = "CrenderData";
            this.crenderDataDataGridViewTextBoxColumn.Name = "crenderDataDataGridViewTextBoxColumn";
            // 
            // recorderDataGridViewTextBoxColumn
            // 
            this.recorderDataGridViewTextBoxColumn.DataPropertyName = "Recorder";
            this.recorderDataGridViewTextBoxColumn.HeaderText = "Recorder";
            this.recorderDataGridViewTextBoxColumn.Name = "recorderDataGridViewTextBoxColumn";
            // 
            // makerDataGridViewTextBoxColumn
            // 
            this.makerDataGridViewTextBoxColumn.DataPropertyName = "Maker";
            this.makerDataGridViewTextBoxColumn.HeaderText = "Maker";
            this.makerDataGridViewTextBoxColumn.Name = "makerDataGridViewTextBoxColumn";
            // 
            // carNameDataGridViewTextBoxColumn
            // 
            this.carNameDataGridViewTextBoxColumn.DataPropertyName = "CarName";
            this.carNameDataGridViewTextBoxColumn.HeaderText = "CarName";
            this.carNameDataGridViewTextBoxColumn.Name = "carNameDataGridViewTextBoxColumn";
            // 
            // reprtDataGridViewTextBoxColumn
            // 
            this.reprtDataGridViewTextBoxColumn.DataPropertyName = "Reprt";
            this.reprtDataGridViewTextBoxColumn.HeaderText = "Reprt";
            this.reprtDataGridViewTextBoxColumn.Name = "reprtDataGridViewTextBoxColumn";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1138, 520);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(crenderDataLabel);
            this.Controls.Add(this.crenderDataDateTimePicker);
            this.Controls.Add(recorderLabel);
            this.Controls.Add(this.recorderTextBox);
            this.Controls.Add(makerLabel);
            this.Controls.Add(this.makerTextBox);
            this.Controls.Add(carNameLabel);
            this.Controls.Add(this.carNameTextBox);
            this.Controls.Add(reprtLabel);
            this.Controls.Add(this.reprtTextBox);
            this.Controls.Add(this.dGVCarDate);
            this.Controls.Add(this.gBMaker);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btDateDelete);
            this.Controls.Add(this.btDateCorrection);
            this.Controls.Add(this.btDateAdd);
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
            this.Controls.Add(this.dgd);
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
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carReprtBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202017DataSet1)).EndInit();
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
        private System.Windows.Forms.TextBox dgd;
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
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.DateTimePicker crenderDataDateTimePicker;
        private System.Windows.Forms.TextBox recorderTextBox;
        private System.Windows.Forms.TextBox makerTextBox;
        private System.Windows.Forms.TextBox carNameTextBox;
        private System.Windows.Forms.TextBox reprtTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn crenderDataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recorderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn makerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reprtDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
    }
}


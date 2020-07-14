using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem
{
    public partial class Form1 : Form
    {
        BindingList<CarReport> cars = new BindingList<CarReport>();

        public Form1()
        {
            InitializeComponent();
            dGVCarDate.DataSource = cars;
            InitButton();
            this.carReprtTableAdapter1.Fill(this.infosys202017DataSet1.CarReprt);
        }
       

        private void btDateAdd_Click(object sender, EventArgs e)
        {
            if (cBCarName.Text != "")
            {
                CarReport car = new CarReport
                {
                    CreatedDate = dTPDate.Value,
                    Maker = RadioBottonChckNumber(),
                    Recorder = cBRecorder.Text,
                    CarName = cBCarName.Text,
                    CarPicture = pBCarImage.Image,
                    Report = dgd.Text,
                };
                CbCarNameBox(cBCarName.Text);
                CbRecorderBox(cBRecorder.Text);
                cars.Insert(0, car);
                dGVCarDate.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                Claer();
                SaidButton();
                RadioBottonClaer();
            }
            else
            {

                MessageBox.Show("入力してください。",
                 "エラー",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);

            }
        }
        // クリアメゾット
        void Claer()
        {

            cBRecorder.Text = "";
            cBCarName.Text = "";
            dgd.Text = "";
            pBCarImage.Image = null;

        }
        void RadioBottonClaer()
        {
            rBhonda.Checked = false;
            rBToyota.Checked = false;
            rBSubaru.Checked = false;
            rBOthers.Checked = false;
            rBOthers.Checked = false;
            rBNissan.Checked = false;
            rBImportedCar.Checked = false;
        }
        //ラジオボックスの操作
        private CarReport.CarMaker RadioBottonChckNumber()
        {
            CarReport car = new CarReport();
            if (rBToyota.Checked)
            {
                return CarReport.CarMaker.トヨタ;
            }
            else if (rBSubaru.Checked)
            {
                return CarReport.CarMaker.スバル;
            }
            else if (rBhonda.Checked)
            {
                return CarReport.CarMaker.ホンダ;
            }
            else if (rBNissan.Checked)
            {
                return CarReport.CarMaker.日産;
            }
            else if (rBImportedCar.Checked)
            {
                return CarReport.CarMaker.外車;
            }
            else if (rBOthers.Checked)
            {
                return CarReport.CarMaker.その他;
            }
            else
            {
                return CarReport.CarMaker.DEFARUT;
            }

        }
        //画像を開く
        private void btImageOapen_Click(object sender, EventArgs e)
        {
            if (oFDImage.ShowDialog() == DialogResult.OK)
            {
                pBCarImage.Image = Image.FromFile(oFDImage.FileName);
                pBCarImage.SizeMode = PictureBoxSizeMode.StretchImage;
                btImageClear.Enabled = true;
            }
        }
        //画像を消す
        private void btImageClear_Click(object sender, EventArgs e)
        {
            pBCarImage.Image = null;
            btImageClear.Enabled = false;

        }

        private void dGVCarDate_Click(object sender, EventArgs e)
        {
            CarReport selectedCar = cars[dGVCarDate.CurrentRow.Index];
            cBRecorder.Text = selectedCar.Recorder;

            cBCarName.Text = selectedCar.CarName;
            dgd.Text = selectedCar.Report;
            pBCarImage.Image = selectedCar.CarPicture;
            switch (selectedCar.Maker)
            {
                case CarReport.CarMaker.トヨタ:
                    rBToyota.Checked = true;
                    break;
                case CarReport.CarMaker.ホンダ:
                    rBhonda.Checked = true;
                    break;
                case CarReport.CarMaker.日産:
                    rBNissan.Checked = true;
                    break;
                case CarReport.CarMaker.スバル:
                    rBSubaru.Checked = true;
                    break;
                case CarReport.CarMaker.外車:
                    rBImportedCar.Checked = true;
                    break;
                case CarReport.CarMaker.その他:
                    rBOthers.Checked = true;
                    break;
            }

        }
        //データを更新する
        private void btDateCorrection_Click(object sender, EventArgs e)
        {
            if (cars.Count != 0)
            {
                int carsList = dGVCarDate.CurrentRow.Index;

                cars[carsList].Recorder = cBRecorder.Text;
                cars[carsList].Maker = RadioBottonChckNumber();
                cars[carsList].CarName = cBCarName.Text;
                cars[carsList].Report = dgd.Text;
                cars[carsList].CarPicture = pBCarImage.Image;
                this.dGVCarDate.Refresh();
            }
        }
        // 削除ボタン
        private void btDateDelete_Click(object sender, EventArgs e)
        {
            if (cars.Count != 0)
            {
                CarReport selectedCar = cars[dGVCarDate.CurrentRow.Index];
                cars.Remove(selectedCar);
                this.dGVCarDate.Refresh();
            }
        }
        // 重複無し
        private void CbCarNameBox(string CarName)
        {
            if (!cBCarName.Items.Contains(CarName))
            {
                cBCarName.Items.Add(CarName);
            }
        }
        private void CbRecorderBox(string Recorder)
        {
            if (!cBRecorder.Items.Contains(Recorder))
            {
                cBRecorder.Items.Add(Recorder);
            }
        }
        //マスクメゾット
        void InitButton()
        {
            btDateCorrection.Enabled = false;
            btDateDelete.Enabled = false;
            btImageClear.Enabled = false;
        }
        void SaidButton()
        {
            btDateCorrection.Enabled = true;
            btDateDelete.Enabled = true;
        }
        //開くボタン
        private void btDetaOapen_Click(object sender, EventArgs e)
        {
            //セーブファイルダイアログを開く
            //オープンファイルダイアログを開く

            if (oFDsaveFile.ShowDialog() == DialogResult.OK)
            {

                using (FileStream fs = new FileStream(oFDsaveFile.FileName, FileMode.Open))
                {
                    try
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        //逆シリアル化して読み込む
                        cars = (BindingList<CarReport>)formatter.Deserialize(fs);
                        //データグリットビューに再設定
                        dGVCarDate.DataSource = cars;
                        //選択されている箇所を各コントロールへ表示
                        dGVCarDate_Click(sender, e);
                    }
                    catch (SerializationException se)
                    {
                        Console.WriteLine("Failed to serialize. Reason: " + se.Message);
                        throw;
                    }
                }
            }
        }
        //保存ボタン
        private void btDetaSave_Click(object sender, EventArgs e)
        {
            //セーブファイルダイアログを開く
            if (sfdSaveData.ShowDialog() == DialogResult.OK)
            {

                BinaryFormatter formatter = new BinaryFormatter();

                //ファイルストリームを表示する
                using (FileStream fs = new FileStream(sfdSaveData.FileName, FileMode.Create))
                {
                    try
                    {
                        //シリアル化する
                        formatter.Serialize(fs, cars);
                    }
                    catch (SerializationException se)
                    {
                        Console.WriteLine("Failed to deserialize. Reason: " + se.Message);
                        throw;
                    }

                }
            }

        }
        //終了ボタン
        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

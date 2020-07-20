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
            //dGVCarDate.DataSource = cars;
            InitButton();
            dGVCarDate.Columns[0].Visible = false;
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
                    Report = tbReport.Text,
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
            tbReport.Text = "";
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
            tbReport.Text = selectedCar.Report;
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

            dGVCarDate.CurrentRow.Cells[3].Value = dataRadioButtonMaker();
            dGVCarDate.CurrentRow.Cells[1].Value = dTPDate.Value;
            dGVCarDate.CurrentRow.Cells[2].Value = cBRecorder.Text;
            dGVCarDate.CurrentRow.Cells[4].Value = cBCarName.Text;
            dGVCarDate.CurrentRow.Cells[5].Value = tbReport.Text;
            dGVCarDate.CurrentRow.Cells[6].Value = pBCarImage.Image;
            this.Validate();
            this.carReprtBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.infosys202017DataSet1);
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
            this.carReprtTableAdapter1.Fill(this.infosys202017DataSet1.CarReprt);
           
        }
        public static Image ByteArrayToImage(byte[] byteData)
        {
            ImageConverter imgconv = new ImageConverter();
            Image img = (Image)imgconv.ConvertFrom(byteData);
            return img;
        }

        // Imageオブジェクトをバイト配列に変換
        public static byte[] ImageToByteArray(Image img)
        {
            ImageConverter imgconv = new ImageConverter();
            byte[] byteData = (byte[])imgconv.ConvertTo(img, typeof(byte[]));
            return byteData;
        }
        //終了ボタン
        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string dataRadioButtonMaker()
        {
            if (rBToyota.Checked == true){
                return rBToyota.Text;
            }else if(rBhonda.Checked == true){
                return rBhonda.Text;
            }else if(rBNissan.Checked == true){
                return rBNissan.Text;
            }else if(rBSubaru.Checked == true)
            {   return rBSubaru.Text;
            }else if(rBOthers.Checked == true){
                return rBOthers.Text;
            }else {
                return rBOthers.Text;
            }
          
        }

        private void setRadioButtonMaker(String carMaker)
        {
            switch (carMaker)
            {
                case "DEFALT":
                    break;
                case "トヨタ":
                    rBToyota.Checked = true;
                    break;
                case "ホンダ":
                    rBhonda.Checked = true;
                    break;
                case "日産":
                    rBNissan.Checked = true;
                    break;
                case "スバル":
                    rBSubaru.Checked = true;
                    break;
                case "外車":
                    rBImportedCar.Checked = true;
                    break;
                case "その他":
                    rBOthers.Checked = true;
                    break;
            }
        }

        private void dGVCarDate_CellContentClick(object sender, EventArgs e)
        {
            dTPDate.Value = (DateTime)dGVCarDate.CurrentRow.Cells[1].Value;
            cBRecorder.Text = dGVCarDate.CurrentRow.Cells[2].Value.ToString();
            var maker = dGVCarDate.CurrentRow.Cells[3].Value;
            cBCarName.Text = dGVCarDate.CurrentRow.Cells[4].Value.ToString();
            tbReport.Text = dGVCarDate.CurrentRow.Cells[5].Value.ToString();
            SaidButton();
            setRadioButtonMaker((String)maker);

        }
    }
}

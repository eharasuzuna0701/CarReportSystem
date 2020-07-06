﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarReportSystem
{
    class CarReport
    {
        //日付
        [System.ComponentModel.DisplayName("日付")]
        public DateTime CreatedDate { get; set; }
        //記録者
        [System.ComponentModel.DisplayName("記録者")]
        public string Recorder { get; set; }
        //メーカー
        [System.ComponentModel.DisplayName("メーカー")]
        //車名
        public CarMaker Maker { get; set; }
        [System.ComponentModel.DisplayName("車名")]
        //レポート
        public string Name { get; set; }
        [System.ComponentModel.DisplayName("レポート")]
        public string Report { get; set; }
        //画像
        [System.ComponentModel.DisplayName("画像")]
        public Image Picture  { get; set; }

        public enum CarMaker
        {
            DEFARUT,
            トヨタ,
            日産,
            ホンダ,
            スバル,
            外車,
            その他
        }
    }
}
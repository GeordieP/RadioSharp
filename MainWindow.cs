using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RadioSharp {
    public partial class MainWindow : Form {

        Radio radio;

        public MainWindow() {
            InitializeComponent();
            radio = new Radio();
        }

        private void PlayStopBtn_Click(object sender, EventArgs e) {
            radio.StartStop();
            radio.ChangeVolume((float)VolumeSlider.Value / 100);
        }

        private void VolumeSlider_Scroll(object sender, EventArgs e) {
            radio.ChangeVolume((float)VolumeSlider.Value / 100);
        }
    }
}

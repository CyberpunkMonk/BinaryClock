using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryClock {
    //STEP ONE:   GET CLOCK TIME        - DONE
    //STEP TWO:   CONVERT TO BINARY     - DONE
    //STEP THREE: DISPLAY AS BITS/BOXES - TODO
    public partial class Form1:Form {
        TimeManager timemanager;
        bool BinaryFlag;
        public Form1() {
            InitializeComponent();
            timemanager=new TimeManager();
            BinaryFlag=false;
        }

        private void button1_Click(Object sender,EventArgs e) {
            setLabel();
        }

        private void checkBox1_CheckedChanged(Object sender,EventArgs e) {
            BinaryFlag=checkBox1.Checked;
            setLabel();
        }

        private void setLabel() {
            timemanager.Update();
            if(BinaryFlag)
                label1.Text=$"Hours: {Convert.ToString(Int32.Parse(timemanager.Hours),2)}\nLabels: {Convert.ToString(Int32.Parse(timemanager.Minutes),2)}\nSeconds: {Convert.ToString(Int32.Parse(timemanager.Seconds),2)}";
            else
                label1.Text=$"{timemanager.Hours}:{timemanager.Minutes}:{timemanager.Seconds}";
        }
    }
}

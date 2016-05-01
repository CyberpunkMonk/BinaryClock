using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
namespace BinaryClock {
    //STEP ONE:   GET CLOCK TIME        - DONE
    //STEP TWO:   CONVERT TO BINARY     - DONE
    //STEP THREE: DISPLAY AS BITS/BOXES - TODO
    public partial class Form1:Form {
        TimeManager timemanager;
        List<Button> seconds;
        List<Button> minutes;
        List<Button> hours;
        public Form1() {
            InitializeComponent();
            timemanager=new TimeManager();
            seconds=new List<Button> { seconds1,seconds2,seconds4,seconds8,seconds16,seconds32 };
            minutes=new List<Button> { minutes1,minutes2,minutes4,minutes8,minutes16,minutes32 };
            hours=  new List<Button> { hours1,hours2,hours4,hours8,hours16 };
            setLabels();
        }

        private void button1_Click(Object sender,EventArgs e) {
            //setLabels();
            timemanager.Update();
            drawSeconds();
            drawMinutes();
            drawHours();
        }
        //Refactor this to eliminate need
        private void setLabels() {
            timemanager.Update();
            labelHours.Text=Convert.ToString(Int32.Parse(timemanager.Hours),2).PadLeft(5,'0');
            labelMinutes.Text=Convert.ToString(Int32.Parse(timemanager.Minutes),2).PadLeft(6,'0');
            labelSeconds.Text=Convert.ToString(Int32.Parse(timemanager.Seconds),2).PadLeft(6,'0');
        }

        private void updateButtons() {
            drawSeconds();
            drawMinutes();
            drawHours();
        }

        private void drawSeconds() {
            char[] arr = labelSeconds.Text.ToCharArray();
            Array.Reverse(arr);
            string s = new string(arr);
            for(int x = 0;x<s.Length;x++) {
                setBox(seconds[x],s.Substring(x,1));
            }
        }
        private void drawMinutes() {
            char[] arr = labelMinutes.Text.ToCharArray();
            Array.Reverse(arr);
            string s = new string(arr);
            for(int x = 0;x<s.Length;x++) {
                setBox(minutes[x],s.Substring(x,1));
            }
        }
        private void drawHours() {
            char[] arr = labelHours.Text.ToCharArray();
            Array.Reverse(arr);
            string s = new string(arr);
            for(int x = 0;x<s.Length;x++) {
                setBox(hours[x],s.Substring(x,1));
            }
        }
        private void setBox(Object o,string flag) {
            Button b = o as Button;
            if(flag.Equals("1"))
                b.BackColor=Color.Green;
            else
                b.BackColor=Color.Gray;
        }

        private void timer1_Tick(Object sender,EventArgs e) {
            timemanager.Update();
            setLabels();
            updateButtons();
        }
    }
}
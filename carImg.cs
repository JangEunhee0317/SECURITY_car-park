using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace security_admin
{
    public partial class carImg : Form
    {

         
        public carImg()
        {
            InitializeComponent();
            admin.carNumber = carNo_lb.Text;   //자동차 번호가 db에 있는지 비교하기 위한 선언

            Console.WriteLine("현재 차번호는? " + admin.carNumber);

            //carImg 열릴 때 carTable도 열기
        }

        private void carImg_Load(object sender, EventArgs e)
        {
            timer1.Interval = 100; //타이머 간격 100m
            timer1.Start(); //타이머 시작
            


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time_lb.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        }


    }
}

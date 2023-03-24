using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Threading;
using MySql.Data.MySqlClient;
using System.IO;

namespace security_admin
{
    public partial class admin : Form
    {
        // 자식 폼 객체로 선언
        private carImg mcarImg = null;
        private carTable mcarTable = null; //사용되지 않음


        public carImg carImgMDI;
        public carTable carTableMDI;


        public Thread randomThread;

        static public string carNumber; //carImg의 방문차량번호 라벨 텍스트 저장

        //public static bool carStat_trigger = false; // 차등록상태 트리거

        ////생성할 커넥션을 담을 변수
        //public static MySqlConnection myConn;
        ////커맨드 담을 변수
        //public static MySqlCommand cmd; // db 테이블 = security.vehicle_account 조회 쿼리문 담을 변수
        //public static MySqlCommand cmdrecord; // db 테이블 = security.access_record 조회 쿼리문 담을 변수


        public admin()
        {
            InitializeComponent();
        }

        public void admin_Load(object sender, EventArgs e)
        {
            // carImg를 admin의 자식폼으로 선언
            carImgMDI = new carImg();
            carImgMDI.MdiParent = this;
            carImgMDI.Show();

            carTableMDI = new carTable();
            carTableMDI.MdiParent = this;
            carTableMDI.Show();

            randomThread = new Thread(UpdateLabel);
            randomThread.Start();
        }

        public void 차량관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //// carImg를 admin의 자식폼으로 선언
            carImgMDI = new carImg();
            carImgMDI.MdiParent = this;
            carImgMDI.Show();

            carTableMDI = new carTable();
            carTableMDI.MdiParent = this;
            carTableMDI.Show();

            randomThread = new Thread(UpdateLabel);
            randomThread.Start();

        }

        public void 영상통화ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void UpdateLabel()
        {
            string[] words = { "32나5073", "100하7777", "경기51바7777", "RA53 YNB", "" };

            Random random = new Random();

            while (true)
            {
                // 1초마다 랜덤한 요소를 선택하여 라벨에 표시
                int index = random.Next(words.Length);
                string randomWord = words[index];
                carImgMDI.carNo_lb.Invoke((MethodInvoker)delegate ()
                {
                    carImgMDI.carNo_lb.Text = randomWord;
                    carNumber = randomWord;   //자동차 번호가 db에 있는지 비교하기 위한 선언
                    Console.WriteLine("1  " +carImgMDI.carNo_lb.Text);
                    Console.WriteLine("2  " +carNumber);

                    carTableMDI.carTable_set();                    

                    if (carTableMDI.CarTable1.RowCount != 0)
                    {
                        carImgMDI.label_carStat.Text = "상태 : 등록";
                    }
                    else
                    {
                        carImgMDI.label_carStat.Text = "상태 : 미등록";
                    }

                });
                Thread.Sleep(8000);
                
            }

            
        }


 

        public void 모든창닫기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (System.Windows.Forms.Form TheForm in this.MdiChildren)
            {
                TheForm.Dispose();
                randomThread.Abort();

            }
        }

        private void admin_Closing(object sender, FormClosingEventArgs e)
        {
            // 쓰레드 종료
            randomThread.Abort();
        }










        ////라벨에 있는 차번호가 등록이 된 상태(db에 있을때)일 때 테이블에 해당 차 데이터를 보여주기.
        //public void carTable_set()
        //{

        //    carTableMDI.CarTable1.Rows.Clear();
        //    carTableMDI.CarTable2.Rows.Clear();

        //    carTableMDI.FaceID.Image = null;

        //    if (myConn != null && myConn.State == ConnectionState.Open)
        //        myConn.Close();
        //    myConn = new MySqlConnection(Program._connection);

        //    string selectQuery = string.Format("SELECT * FROM vehicleaccount");

        //    myConn.Open();

        //    cmd = new MySqlCommand(selectQuery, myConn);

        //    // sql 데이터를 읽을 때 저장할 변수 선언
        //    MySqlDataReader rdr = cmd.ExecuteReader();


        //    // 이미지를 저장할 변수 선언
        //    byte[] bImage = null;

        //    while (rdr.Read())
        //    {
        //        if (carNumber.ToString() == rdr.GetString(1)) //방문한 차번호가 db에 있을 때
        //        {
        //            Console.WriteLine(carNumber.ToString());
        //            Console.WriteLine(rdr.GetString(1));

        //            carTableMDI.CarTable1.Rows.Add(rdr["idx"].ToString(), // No.
        //                                rdr["license_plate"], // 등록차 번호판
        //                                rdr["Entry_space"].ToString() // 주차구역
        //                                );
        //            bImage = (byte[])rdr["Face"];
        //            carTableMDI.FaceID.Image = new Bitmap(new MemoryStream(bImage));// Face ID                    

        //            carStat_trigger = true; // 차등록상태 트리거                    


        //        }
        //    } //CarTable1에 데이터 넣는 while문 끝 
        //      //cmd.ExecuteNonQuery();
        //    cmd.Connection.Close();
        //    ////////////////////////////////
        //    if (myConn != null && myConn.State == ConnectionState.Open)
        //        myConn.Close();

        //    myConn = new MySqlConnection(Program._connection);

        //    if (carTableMDI.CarTable1.RowCount != 0)
        //    {
        //        DataGridViewRow row = carTableMDI.CarTable1.SelectedRows[0]; //선택된 Row 값 가져옴.
        //        string idx = row.Cells[0].Value.ToString();

        //        string selectQuery2 = string.Format($"SELECT * FROM security.accessrecord WHERE vehicleId = " +
        //                                            $"(SELECT idx FROM security.vehicleaccount WHERE idx = {idx})");
        //        myConn.Open();
        //        cmd = new MySqlCommand(selectQuery2, myConn);

        //        MySqlDataReader rdrRecord = cmd.ExecuteReader();

        //        while (rdrRecord.Read())
        //        {
        //            carTableMDI.CarTable2.Rows.Add(rdrRecord["idx"].ToString(),
        //                            rdrRecord["Enrty_time"].ToString(), // 입차시간
        //                            rdrRecord["Exit_time"] // 출차시간
        //                            );
        //        }//CarTable2에 데이터 넣는 while문 끝 
        //        cmd.Connection.Close();
        //    }

        //}// 현재 방문차량에 해당하는 데이터 시각화


        //private void carTable_Load(object sender, EventArgs e)
        //{
        //    carTable_set();


        //}// 폼 처음 실행할 때

        //private void carTable_Deactivate(object sender, EventArgs e)
        //{
        //    carTable_set();

        //}// 폼 비활성활 되었을 때 
    }
}

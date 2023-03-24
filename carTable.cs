using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;
using Mysqlx.Connection;
using Org.BouncyCastle.Asn1.X509.SigI;
using Org.BouncyCastle.Cms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace security_admin
{
    public partial class carTable : Form
    {

        static public string carStat; //  carImg의 등록상태 확인 라벨 텍스트 저장

        public static bool carStat_trigger = false; // 차등록상태 트리거


        //생성할 커넥션을 담을 변수
        public static MySqlConnection myConn;
        //커맨드 담을 변수
        public static MySqlCommand cmd; // db 테이블 = security.vehicle_account 조회 쿼리문 담을 변수
        public static MySqlCommand cmdrecord; // db 테이블 = security.access_record 조회 쿼리문 담을 변수



        public carTable()
        {
            InitializeComponent();

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        //라벨에 있는 차번호가 등록이 된 상태(db에 있을때)일 때 테이블에 해당 차 데이터를 보여주기.
        public void carTable_set()
        {

            CarTable1.Rows.Clear();
            CarTable2.Rows.Clear();

            FaceID.Image = null;

            if (myConn != null && myConn.State == ConnectionState.Open)
                myConn.Close();
            myConn = new MySqlConnection(Program._connection);

            string selectQuery = string.Format("SELECT * FROM vehicleaccount");

            myConn.Open();

            cmd = new MySqlCommand(selectQuery, myConn);

            // sql 데이터를 읽을 때 저장할 변수 선언
            MySqlDataReader rdr = cmd.ExecuteReader();


            // 이미지를 저장할 변수 선언
            byte[] bImage = null;

            while (rdr.Read())
            {
                if (admin.carNumber.ToString() == rdr.GetString(1)) //방문한 차번호가 db에 있을 때
                {
                    Console.WriteLine(admin.carNumber.ToString());
                    Console.WriteLine(rdr.GetString(1));

                    CarTable1.Rows.Add(rdr["idx"].ToString(), // No.
                                        rdr["license_plate"], // 등록차 번호판
                                        rdr["Entry_space"].ToString() // 주차구역
                                        );
                    bImage = (byte[])rdr["Face"];
                    FaceID.Image = new Bitmap(new MemoryStream(bImage));// Face ID                                     

                    //carStat_trigger = true;
                }


            } //CarTable1에 데이터 넣는 while문 끝 
              //cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            ////////////////////////////////
            if (myConn != null && myConn.State == ConnectionState.Open)
                myConn.Close();

            myConn = new MySqlConnection(Program._connection);

            if (CarTable1.RowCount != 0)
            {
                DataGridViewRow row = CarTable1.SelectedRows[0]; //선택된 Row 값 가져옴.
                string idx = row.Cells[0].Value.ToString();

                string selectQuery2 = string.Format($"SELECT * FROM security.accessrecord WHERE vehicleId = " +
                                                    $"(SELECT idx FROM security.vehicleaccount WHERE idx = {idx})");
                myConn.Open();
                cmd = new MySqlCommand(selectQuery2, myConn);

                MySqlDataReader rdrRecord = cmd.ExecuteReader();

                while (rdrRecord.Read())
                {
                    CarTable2.Rows.Add(rdrRecord["idx"].ToString(),
                                    rdrRecord["Enrty_time"].ToString(), // 입차시간
                                    rdrRecord["Exit_time"] // 출차시간
                                    );
                }//CarTable2에 데이터 넣는 while문 끝 
                cmd.Connection.Close();
            }

        }// 현재 방문차량에 해당하는 데이터 시각화


        private void carTable_Load(object sender, EventArgs e)
        {
            carTable_set();


        }// 폼 처음 실행할 때

        private void carTable_Deactivate(object sender, EventArgs e)
        {
            carTable_set();

        }// 폼 비활성활 되었을 때 


        private void btn_search_Click(object sender, EventArgs e)
        {

            CarTable1.Rows.Clear();
            CarTable2.Rows.Clear();

            if (myConn != null && myConn.State == ConnectionState.Open)
                myConn.Close();


            myConn = new MySqlConnection(Program._connection);

            string selectQuery = string.Format("SELECT * FROM security.vehicleaccount");

            myConn.Open();

            cmd = new MySqlCommand(selectQuery, myConn);

            // sql 데이터를 읽을 때 저장할 변수 선언
            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                CarTable1.Rows.Add(rdr["idx"].ToString(), // No.
                    rdr["license_plate"], // 등록차 번호판
                    rdr["Entry_space"].ToString() // 주차구역
                    ); // Face ID

            }
            //cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }//전체조회



        private void CarTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CarTable2.Rows.Clear();

            DataGridViewRow row = CarTable1.SelectedRows[0]; //선택된 Row 값 가져옴.
            string idx = row.Cells[0].Value.ToString();
            string license_plate = row.Cells[1].Value.ToString();
            //https://build.tistory.com/4


            if (myConn != null && myConn.State == ConnectionState.Open)
                myConn.Close();
            myConn = new MySqlConnection(Program._connection);
            string selectQuery1 = string.Format("SELECT * FROM security.vehicleaccount");

            myConn.Open();

            cmd = new MySqlCommand(selectQuery1, myConn);

            // sql 데이터를 읽을 때 저장할 변수 선언
            MySqlDataReader rdrImg = cmd.ExecuteReader();

            // 이미지를 저장할 변수 선언
            byte[] bImage = null;
            while (rdrImg.Read())
            {
                bImage = (byte[])rdrImg["Face"];
                if (idx == rdrImg.GetString(0) && license_plate == rdrImg.GetString(1))
                    FaceID.Image = new Bitmap(new MemoryStream(bImage));
            }
            rdrImg.Close();
            myConn.Close();
            ////////////////////////////////
            if (myConn != null && myConn.State == ConnectionState.Open)
                myConn.Close();

            myConn = new MySqlConnection(Program._connection);

            string selectQuery2 = string.Format($"SELECT * FROM security.accessrecord WHERE vehicleId = " +
                                                $"(SELECT idx FROM security.vehicleaccount WHERE idx = {idx})");
            myConn.Open();
            cmd = new MySqlCommand(selectQuery2, myConn);

            MySqlDataReader rdrRecord = cmd.ExecuteReader();

            while (rdrRecord.Read())
            {
                CarTable2.Rows.Add(rdrRecord["idx"].ToString(),
                                rdrRecord["Enrty_time"].ToString(), // 입차시간
                                rdrRecord["Exit_time"] // 출차시간
                                );
            }//CarTable2에 데이터 넣는 while문 끝 
            cmd.Connection.Close();


        }//셀 클릭할때마다


    }
}

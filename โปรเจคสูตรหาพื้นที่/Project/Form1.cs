using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void okok(TabPage p)//สร้างฟังชั่น okok คื่อชื่อเม็ดตอด pคือตัวไว่้เก็บค่า
        {
            tabControl2.TabPages.Clear(); //เคลียร์
            tabControl2.TabPages.Add(tp0);//เพิ่มแถบ tp0 ** tp0คือหน้าหลัก
            tabControl2.TabPages.Add(p);//เมื่อกดแกบลิ้งหาtpต่างๆ จะถูกเก็บไว้ใน p แล้วจะแสดง p
            tabControl2.SelectedTab = p;//ลิ้ง 
        }
        private void button1_Click(object sender, EventArgs e)//เมื่อกดปุ่ม button1 นี้
        {
            okok(tp1);// ฟังก์ชัน okok จะแสดง tp1 ที่เก็บไว้ใน p มาแสดง
        }

        private void button2_Click(object sender, EventArgs e)//เมื่อกดปุ่ม button2 นี้
        {
            okok(tp2);//ฟังก์ชัน okok จะแสดง tp2 ที่เก็บไว้ใน p มาแสดง
        }

        private void button3_Click(object sender, EventArgs e)//เมื่อกดปุ่ม button3 นี้ 
        {
            okok(tp3);//ฟังก์ชัน okok จะแสดง tp3 ที่เก็บไว้ใน p มาแสดง
        }

        private void button4_Click(object sender, EventArgs e)//เมื่อกดปุ่ม button4 นี้
        {
            okok(tp4); //ฟังก์ชัน okok จะแสดง tp4 ที่เก็บไว้ใน p มาแสดง
        }

        private void button5_Click(object sender, EventArgs e)//เมื่อกดปุ่ม button5 นี้ 
        {
            okok(tp5);//ฟังก์ชัน okok  จะแสดง tp5 ที่เก็บไว้ใน p มาแสดง
        }

        private void button6_Click(object sender, EventArgs e)//เมื่อกดปุ่ม button6 นี้ 
        {
            okok(tp6);//ฟังก์ชัน okok จะแสดง tp6 ที่เก็บไว้ใน p มาแสดง
        }

        private void button7_Click(object sender, EventArgs e)//เมื่อกดปุ่ม button7 นี้
        {
            okok(tp7);//ฟังก์ชัน okok จะแสดง tp7 ที่เก็บไว้ใน p มาแสดง
        }

        private void button8_Click(object sender, EventArgs e)//เมื่อกดปุ่ม button8 นี้ 
        {
            okok(tp8);//ฟังก์ชัน okok จะแสดง tp8 ที่เก็บไว้ใน p มาแสดง
        }

        private void bt9_Click(object sender, EventArgs e)//เมื่อกดปุ่ม bt9
        {
            Close(); //จะเป็นโค้ดออกจากโปรแกรม
        }
        
        private void button10_Click(object sender, EventArgs e)//เมื่อคลิก button10
        {
            try //กันเออเลอที่ใส่เป็นตัวอักษร  โดยใช้วิธี *try คือ ทดลอง
            {
                int num1 = int.Parse(textBox1.Text);//สร้างตัวแปรชื่อ num1 รับค่าจากtextBox1
                int num2 = int.Parse(textBox2.Text);//สร้างตัวแปรชื่อ num2 รับค่าจากtextBox2
                int ans = num1 * num2;//สร้างตัวแปร ans เพื่อเก็บค่าของ num1*num2
                textBox3.Text = ans.ToString();//ผลลัพธ์ ans แสดงค่าในtextBox3
            }
            catch  //เมื่อผิดพลาด  **เม่อใส่ัวอักษร
            {
                MessageBox.Show("กรุณาใส่ตัวเลข");//จะแสดงข้อความว่า "กรุณาใส่ตัวเลข"
            }
        }

        private void button9_Click(object sender, EventArgs e)//เมื่อคลิก button9
        {
            try//กันเออเลอที่ใส่เป็นตัวอักษร  โดยใช้วิธี *try คือ ทดลอง
            {
                  int num1 = int.Parse(textBox6.Text);//สร้างตัวแปรชื่อ num1 รับค่าจากtextBox6
                int num2 = int.Parse(textBox5.Text);//สร้างตัวแปรชื่อ num1 รับค่าจากtextBox5
                int ans = num1 * num2;//สร้างตัวแปร ans เพื่อเก็บค่าของ num1*num2
                textBox4.Text = ans.ToString();//ผลลัพธ์ ans แสดงค่าในtextBox4
            }
            catch  //เมื่อผิดพลาด **เมือใส่ัวอักษร
            {
                MessageBox.Show("กรุณาใส่ตัวเลข");//จะแสดงข้อความว่า "กรุณาใส่ตัวเลข"
            }

        }

        private void button11_Click(object sender, EventArgs e)//เมื่อคลิก button11
        {
            try//กันเออเลอที่ใส่เป็นตัวอักษร  โดยใช้วิธี *try คือ ทดลอง
            {
                int num1 = int.Parse(textBox9.Text);//สร้างตัวแปรชื่อ num1 รับค่าจากtextBox9
                int num2 = int.Parse(textBox8.Text);//สร้างตัวแปรชื่อ num2 รับค่าจากtextBox8
                int ans = num1 * num2;//สร้างตัวแปร ans เพื่อเก็บค่าของ num1*num2
                textBox7.Text = ans.ToString();//ผลลัพธ์ ans แสดงค่าในtextBox7
            }
            catch  //เมื่อผิดพลาด **เมือใส่ตัวอักษร
            {
                MessageBox.Show("กรุณาใส่ตัวเลข");//จะแสดงข้อความว่า "กรุณาใส่ตัวเลข"
            }
        }

        private void button12_Click(object sender, EventArgs e)//เมื่อคลิก button12
        {
            try//กันเออเลอที่ใส่เป็นตัวอักษร  โดยใช้วิธี *try คือ ทดลอง
            {
                int num1 = int.Parse(textBox12.Text);//สร้างตัวแปรชื่อ num1 รับค่าจากtextBox12
                int num2 = int.Parse(textBox11.Text);//สร้างตัวแปรชื่อ num2 รับค่าจากtextBox11
                int ans = num1 * num2;//สร้างตัวแปร ans เพื่อเก็บค่าของ num1*num2
                textBox10.Text = ans.ToString();//ผลลัพธ์ ans แสดงค่าในtextBox10
            }
            catch  //เมื่อผิดพลาด**เมือใส่ตัวอักษร
            {
                MessageBox.Show("กรุณาใส่ตัวเลข");//จะแสดงข้อความว่า "กรุณาใส่ตัวเลข"
            }
        }

        private void button13_Click(object sender, EventArgs e)//เมื่อคลิก button13
        {
            try//กันเออเลอที่ใส่เป็นตัวอักษร  โดยใช้วิธี *try คือ ทดลอง
            {
                int num1 = int.Parse(textBox15.Text);//สร้างตัวแปรชื่อ num1 รับค่าจากtextBox15
                int num2 = int.Parse(textBox14.Text);//สร้างตัวแปรชื่อ num2 รับค่าจากtextBox14
                double ans = 0.5 * num1 * num2;//สร้างตัวแปร ans เพื่อเก็บค่าของ 0.5*num1*num2
                textBox13.Text = ans.ToString();//ผลลัพธ์ ans แสดงค่าในtextBox13
            }
            catch  //เมื่อผิดพลาด **เมือใส่ตัวอักษร
            {
                MessageBox.Show("กรุณาใส่ตัวเลข");//จะแสดงข้อความว่า "กรุณาใส่ตัวเลข"
            }
        }

        private void button14_Click(object sender, EventArgs e)//เมื่อคลิก button14
        {
            try//กันเออเลอที่ใส่เป็นตัวอักษร  โดยใช้วิธี *try คือ ทดลอง
            {
                int num1 = int.Parse(textBox17.Text);//สร้างตัวแปรชื่อ num1 รับค่าจากtextBox17
                double ans = 0.5 * num1;//สร้างตัวแปร ans เพื่อเก็บค่าของ 0.5*num1
                textBox16.Text = ans.ToString();//ผลลัพธ์ ans แสดงค่าในtextBox16
            }
            catch  //เมื่อผิดพลาด**เมือใส่ตัวอักษร
            {
                MessageBox.Show("กรุณาใส่ตัวเลข");//จะแสดงข้อความว่า "กรุณาใส่ตัวเลข"
            }
        }

        private void button15_Click(object sender, EventArgs e)//เมื่อคลิก button15
        {
            try//กันเออเลอที่ใส่เป็นตัวอักษร  โดยใช้วิธี *try คือ ทดลอง
            {
                int num1 = int.Parse(textBox20.Text);//สร้างตัวแปรชื่อ num1 รับค่าจากtextBox20
                int num2 = int.Parse(textBox19.Text);//สร้างตัวแปรชื่อ num2 รับค่าจากtextBox19
                double ans = 0.5 * num1 * num2;//สร้างตัวแปร ans เพื่อเก็บค่าของ 0.5*num1*num2
                textBox18.Text = ans.ToString();//ผลลัพธ์ ans แสดงค่าในtextBox18
            }
            catch  //เมื่อผิดพลาด**เมือใส่ตัวอักษร
            {
                MessageBox.Show("กรุณาใส่ตัวเลข");//จะแสดงข้อความว่า "กรุณาใส่ตัวเลข"
            }
        }

        private void button16_Click(object sender, EventArgs e)//เมื่อคลิก button16
        {
            try//กันเออเลอที่ใส่เป็นตัวอักษร  โดยใช้วิธี *try คือ ทดลอง
            {
                int num1 = int.Parse(textBox22.Text);//สร้างตัวแปรชื่อ num1 รับค่าจากtextBox22
                double ans = 3.14 * Math.Pow(num1, 2);//สร้างตัวแปร ans เพื่อเก็บค่าของ 3.14* num1ยกกำลัง2
                textBox21.Text = ans.ToString();//ผลลัพธ์ ans แสดงค่าในtextBox21
            }
            catch  //เมื่อผิดพลาด**เมือใส่ตัวอักษร
            {
                MessageBox.Show("กรุณาใส่ตัวเลข");//จะแสดงข้อความว่า "กรุณาใส่ตัวเลข"
            }
        }

        private void button17_Click(object sender, EventArgs e)//เมื่อคลิก button17
        {
            textBox15.Text = "";//textBox15 จะเป็นช่องว่าง
            textBox14.Text = "";//textBox14 จะเป็นช่องว่าง
            textBox13.Text = "";//textBox13 จะเป็นช่องว่าง
        }

        private void button18_Click(object sender, EventArgs e)//เมื่อคลิก button18
        {
            textBox1.Text = "";//textBox1 จะเป็นช่องว่าง
            textBox2.Text = "";//textBox2 จะเป็นช่องว่าง
            textBox3.Text = "";//textBox3 จะเป็นช่องว่าง
        }

        private void button19_Click(object sender, EventArgs e)//เมื่อคลิก button19
        {
            textBox4.Text = "";//textBox4 จะเป็นช่องว่าง เหมือนเป็นการเคลียร์ช่องของtextBox
            textBox5.Text = "";//textBox5 จะเป็นช่องว่าง เหมือนเป็นการเคลียร์ช่องของtextBox
            textBox6.Text = "";//textBox6 จะเป็นช่องว่าง เหมือนเป็นการเคลียร์ช่องของtextBox
        }

        private void button20_Click(object sender, EventArgs e)//เมื่อคลิก button20
        {
            textBox7.Text = "";//textBox7 จะเป็นช่องว่าง เหมือนเป็นการเคลียร์ช่องของtextBox
            textBox8.Text = "";//textBox8 จะเป็นช่องว่าง เหมือนเป็นการเคลียร์ช่องของtextBox
            textBox9.Text = "";//textBox9 จะเป็นช่องว่าง เหมือนเป็นการเคลียร์ช่องของtextBox
        }

        private void button21_Click(object sender, EventArgs e)//เมื่อคลิก button21
        {
            textBox10.Text = "";//textBox10 จะเป็นช่องว่าง เหมือนเป็นการเคลียร์ช่องของtextBox
            textBox11.Text = "";//textBox11 จะเป็นช่องว่าง เหมือนเป็นการเคลียร์ช่องของtextBox
            textBox12.Text = "";//textBox12 จะเป็นช่องว่าง เหมือนเป็นการเคลียร์ช่องของtextBox
        }

        private void button22_Click(object sender, EventArgs e)//เมื่อคลิก button22
        {
            textBox16.Text = "";//textBox16 จะเป็นช่องว่าง เหมือนเป็นการเคลียร์ช่องของtextBox
            textBox17.Text = "";//textBox17 จะเป็นช่องว่าง เหมือนเป็นการเคลียร์ช่องของtextBox
        }

        private void button23_Click(object sender, EventArgs e)//เมื่อคลิก button23
        {
            textBox18.Text = "";//textBox18 จะเป็นช่องว่าง เหมือนเป็นการเคลียร์ช่องของtextBox
            textBox19.Text = "";//textBox19 จะเป็นช่องว่าง เหมือนเป็นการเคลียร์ช่องของtextBox
            textBox20.Text = "";//textBox20 จะเป็นช่องว่าง เหมือนเป็นการเคลียร์ช่องของtextBox
        }

        private void button24_Click(object sender, EventArgs e)//เมื่อคลิก button24
        {
            textBox21.Text = "";//textBox21 จะเป็นช่องว่าง เหมือนเป็นการเคลียร์ช่องของtextBox
            textBox22.Text = "";//textBox22 จะเป็นช่องว่าง เหมือนเป็นการเคลียร์ช่องของtextBox
        }

        private void Form1_Load(object sender, EventArgs e)//เมื่อหน้าForm1_Load ขึ้น
        {
            tabControl2.TabPages.Clear();//ลบแถบ **ลบทุก tp
            tabControl2.TabPages.Add(tp0);//เพิ่มแถบtp0
        }
    }
}

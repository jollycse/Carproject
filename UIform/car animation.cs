using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bolayer;
using Entity;



namespace UIform
{
    public partial class Form1 : Form
    {
        carbo s = new carbo();
        Car v = new Car();
        enum position{
            left,Right,Up,Down,stop
        }
        int x;
        int y;
        Graphics g;
       
        private position objposition;
        private int objectId;
        public Form1()
        {
            InitializeComponent();
            
             x = s.x;
             y = s.y;
            
            objectId = 0;
            objposition = position.stop;
           
            
            
        }

       
        private void cardrawPanel_paint(object sender, PaintEventArgs e)
        {
            g = carpanel.CreateGraphics();
            carpanel.Location=new Point(x, y);
            v.DrawCar(g, objectId);
           
          

        }

        private void savebtn_Click(object sender, EventArgs e)
        {
          
            try
            {

                v.speed = Convert.ToInt32(textBox1.Text);
                if (s.saveSpeed(v))
                {

                    label3.Text = Convert.ToString(v.speed);
                    MessageBox.Show("saved successfully");
                }

            }
            catch (Exception)
            {

                MessageBox.Show("unsaved");


            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Car v = new Car();
            try
            {

                v.speed = Convert.ToInt32(textBox1.Text);
                s.saveSpeed(v);
            }
            catch (Exception)
            {


            }
            
            carpanel.Invalidate();
            if (objposition == position.Right&&x<900)
            {
                x = s.getCarControltoRight(x,v.speed);
                objectId = 0;
            
            }
            if (objposition == position.left&&x>0)
            {
                x =s.getCarControltoLeft(x,v.speed);
                objectId = 1;
                
            }
            if (objposition == position.Up&&y>0)
            {
                y=s.getCarControltoLeft(y,v.speed);
                objectId = 2;
                
            }
            if (objposition == position.Down&&y<180)
            {
                y =s.getCarControltoRight(y,v.speed);
                objectId = 3;
               
            }
            
          

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            objposition = position.Right;
            carpanel.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            objposition = position.left;
            carpanel.Invalidate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            objposition = position.Up;
            carpanel.Invalidate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            objposition = position.Down;
            carpanel.Invalidate();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            objposition = position.stop;
        }

        private void Road_dwaw(object sender, PaintEventArgs e)
        {
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

       

       
    }
}
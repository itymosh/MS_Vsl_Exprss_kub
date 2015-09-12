using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace GDI__prog1
{
    public partial class Form1 : Form
    {

        int[,] mas =  {
                {0, 0,  0,  57, 46, 43, 0,  0,  0,  0,  0,  0},
		        {0, 0,  0,  24, 65, 68, 0,  0,  0,  0,  0,  0},
		        {0, 0,  0,  27, 64, 67, 0,  0,  0,  0,  0,  0},
		        {0, 0,  0,  11, 54, 51, 0,  0,  0,  0,  0,  0},
		        {0, 0,  0,  14, 25, 66, 0,  0,  0,  0,  0,  0},
		        {0, 0,  0,  17, 28, 69, 0,  0,  0,  0,  0,  0},
                {53,56,59,  47, 12, 23,33, 36, 21, 67, 64, 27},
		        {52,55,58,  44, 15, 26,32, 35, 22, 68, 65, 24},
		        {41,42,19,  37, 18, 29,31, 34, 63, 43, 46, 57},
                {0, 0,  0,  49, 48, 13, 0,  0,  0,  0,  0,  0},
		        {0, 0,  0,  62, 45, 16, 0,  0,  0,  0,  0,  0},
		        {0, 0,  0,  61, 38, 39, 0,  0,  0,  0,  0,  0},         
                        };
        int[,] mas1= new int[12,12];

        public Form1()
        {
            InitializeComponent();
            Start(null, null);
            Start(null, null);
        }
        //move=================================================================================
        public void fcu()
        {
            f_r_up(); f_r_up(); f_r_up();
            f_l_up(); f_l_up(); f_l_up(); Up(); matrycia();
        }
           public void fcd()
        {
            f_r_up(); f_l_up(); for (int i = 0; i < 3; i++) Up(); matrycia();
        }   

          public void fru()
        {
            f_r_up();
            matrycia();
        }
          public void flu()
          {
              f_l_up();
              matrycia();
          }
          public void frd()
          {
              f_r_up(); f_r_up(); f_r_up(); matrycia();
          }
          public void fld()
          {
              f_l_up(); f_l_up(); f_l_up(); matrycia();
          }
        public void rcr()
        {
            po_z_vl(); f_l_up(); f_l_up(); f_l_up(); po_z_vr();
            po_z_vr(); f_l_up(); po_z_vl();
            for (int i = 0; i < 3; i++) left(); matrycia(); 
        }
        public void rcl()
        {
            po_z_vl(); f_l_up(); po_z_vr();
            po_z_vr(); f_l_up(); f_l_up(); f_l_up(); po_z_vl();
            left(); matrycia();
        }
        public void rul()
        {
            po_z_vl(); f_l_up(); f_l_up(); f_l_up(); po_z_vr(); matrycia();
        }
        public void rur()
        {
            po_z_vl(); f_l_up(); po_z_vr(); matrycia();
        }
        public void rdr()
        {
            po_z_vr(); f_l_up(); f_l_up(); f_l_up(); po_z_vl(); matrycia();
        }
        public void rdl()
        {
            po_z_vr(); f_l_up(); po_z_vl(); matrycia();
        } 
        public void ucl()
        {
            Up(); Up(); Up(); po_z_vl(); po_z_vl(); po_z_vl(); f_r_up(); f_r_up(); f_r_up(); po_z_vl(); Up();
            Up(); Up(); Up(); po_z_vl(); f_r_up(); po_z_vl(); po_z_vl(); po_z_vl(); Up();
            po_z_vl();
            matrycia();
        }
        public void ucr()
        {
            Up(); Up(); Up(); po_z_vl(); po_z_vl(); po_z_vl(); f_r_up(); po_z_vl(); Up();
            Up(); Up(); Up(); po_z_vl(); f_r_up(); f_r_up(); f_r_up(); po_z_vl(); po_z_vl(); po_z_vl(); Up();
            po_z_vr();
            matrycia();
        }
        public void uur()
        {
            Up(); Up(); Up(); po_z_vl(); po_z_vl(); po_z_vl(); f_r_up(); f_r_up(); f_r_up(); po_z_vl(); Up(); matrycia();
        }
        public void uul()
        {
            Up(); Up(); Up(); po_z_vl(); po_z_vl(); po_z_vl(); f_r_up(); po_z_vl(); Up(); matrycia();
        }
        public void udl()
        {
            Up(); Up(); Up(); po_z_vl(); f_r_up(); f_r_up(); f_r_up(); po_z_vl(); po_z_vl(); po_z_vl(); Up(); matrycia();
        }
        public void udr()
        {
            Up(); Up(); Up(); po_z_vl(); f_r_up(); po_z_vl(); po_z_vl(); po_z_vl(); Up(); matrycia();
        }
        public void u()
        {
            Up(); matrycia();
        }
        public void l()
        {
            left(); matrycia();
        }
       //======================================================================================
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.E) mas[5, 5] = 45;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Start(null, null);
            Start(null, null);
        }
        private void Solve(object sender, EventArgs e)
        {
         
            int m, n, q, w = 0, i, x,y;
            if (mas[6, 3] == 11) goto m1;
            for (i = 0; i < 8; i++)
            {
                if (i < 4) { Up(); matrycia(); } else { left(); matrycia(); }
                if ((mas[6, 5] == 11) || (mas[8, 3] == 11) || (mas[8, 5] == 11)) break; if (mas[6, 3] == 11) goto m1;
            }
            for (i = 0; i < 3; i++)
            {
                po_z_vr(); matrycia(); if (mas[6, 3] == 11) break;
            }
        //=======================11 orientovano here 
        //here start orienting 12
        m1:
            if (mas[6, 4] == 12) goto m2;
            for (n = 4; n < 12; n += 3) if (mas[6, n] == 12)
                {
                    f_l_up(); f_l_up(); f_l_up();
                    while (mas[6, 4] != 12) { po_z_vl(); f_l_up(); f_l_up(); f_l_up(); po_z_vr(); matrycia(); }
                    f_l_up(); matrycia();
                }
            if (mas[6, 1] == 12)
            {//button22
                Up(); Up(); Up(); po_z_vl(); po_z_vl(); po_z_vl(); f_r_up(); po_z_vl(); Up();
                Up(); Up(); Up(); po_z_vl(); f_r_up(); f_r_up(); f_r_up(); po_z_vl(); po_z_vl(); po_z_vl(); Up();
                po_z_vr();
                matrycia();
            }
            for (i = 0; i < 8; i++)
            {
                if ((mas[6, 4] == 12) || (mas[8, 4] == 12) || (mas[7, 3] == 12) || (mas[7, 5] == 12)) goto m2;
                else
                {

                    if (i < 4) //button 11,25  ->  
                    {
                        po_z_vl(); f_l_up(); f_l_up(); f_l_up(); po_z_vr();
                        po_z_vr(); f_l_up(); po_z_vl();
                        for (int i1 = 0; i1 < 3; i1++) left(); 
                        po_z_vr(); f_l_up(); f_l_up(); f_l_up(); po_z_vl(); matrycia();
                    }
                    if ((i > 3) & (i < 8))  //button 26,10
                    {
                        f_r_up(); f_r_up(); f_r_up();
                        f_l_up(); f_l_up(); f_l_up(); Up(); 
                        f_r_up(); matrycia();
                    }
                }

            }

        m2: for (i = 0; i < 3; i++)
            {
                if (mas[6, 4] == 12) goto m13;
                else
                {
                    if (mas[7, 3] != 12)
                    {
                        f_l_up();
                        Up(); Up(); Up(); po_z_vl(); f_r_up(); f_r_up(); f_r_up(); po_z_vl(); po_z_vl(); po_z_vl(); Up(); matrycia();
                        f_l_up(); f_l_up(); f_l_up(); matrycia();
                    }
                    else //(here 
                    {
                        rul(); udr(); fcd(); rur(); fcu();
                  
                    }
                }
            }
   
            // here start orienting 13
        m13:  if (mas[6, 5] == 13) goto m14;
            for (x = 0; x < 12; x++)
            {
                for (y = 0; y < 12; y++)
                {
                    if (mas[x, y] == 13)
                    {
                        if ((x == 6 && y == 11) || (x == 6 && y == 0))
                        {
                            { uur(); uur(); goto m13_1; }
                        }
                        else if ((x == 6 && y != 11) || (x == 6 && y != 0))
                        {
                            for (i = 0; i < 2; i++) { fru();} goto m13_1; 
                        } 
                    } 
                }
            }m13_1:
            for (x = 0; x < 12; x++)
            {
                for (y = 0; y < 12; y++)
                {
                    if (mas[x, y] == 13)
                    {
                        if ((y < 3 || y > 5))//&&x!=6)
                        do {  rdr(); y += 3; } while (y < 3 || (y > 5 && y < 15));
                      //do { l(); } while (y < 3 || x > 5);
                        goto m13_2;
                    } 
                }
            }
        m13_2: for (x = 0; x < 12; x++)
            {
                for (y = 0; y < 12; y++)
                {
                    if (mas[x, y] == 13)
                    { if (y == 3 && x == 3) { uur(); uur(); rdl(); fru(); goto m14; } }/* */ //}
                }
            }
        for (x = 0; x < 12; x++)
        {
            for (y = 0; y < 12; y++)
            {
                if (mas[x, y] == 13)
                { if (y == 3 && x == 9) { rdr(); fru();  goto m14; } }/* */ //}
            }
        }
        for (x = 0; x < 12; x++)
        {
            for (y = 0; y < 12; y++)
            {
                if (mas[x, y] == 13)
                { if (y == 3 && x == 11) { rdr(); rdr(); fru(); goto m14; } }/* */ //}
            }
        }
        for (x = 0; x < 12; x++)
        {
            for (y = 0; y < 12; y++)
            {
                if (mas[x, y] == 13)
                 
                { if ((y == 5 && x < 6) || (y == 5 && x > 8))
                { do { frd(); x += 3; } while (x < 6 || (x > 8 && x < 18));
                       goto m13_3;
                }
                }
            }
        }
    m13_3:    for (x = 0; x < 12; x++)
        {
            for (y = 0; y < 12; y++)
            {
                if (mas[x, y] == 13)
                { if (y == 5 && x == 8) { udl(); fru(); udr(); frd(); goto m14; } }/* */ //}
            }
        }
        for (x = 0; x < 12; x++)
        {
            for (y = 0; y < 12; y++)
            {
                if (mas[x, y] == 13)
                { if (y == 3 && x == 8) { rdr(); rdr(); frd(); frd(); goto m14; } }/* */ //}
            }
        }
            //here start orienting 14
            m14:  if (mas[7, 3] == 14) goto m15;
            for (x = 0; x < 12; x++)
            {
                for (y = 0; y < 12; y++)
                {
                    if (mas[x, y] == 14)
                    {
                        if (x == 1 && y == 5) goto m14_2;
                        if (x == 7 && y == 5) { rcr(); rcr(); uur(); uur(); rcr(); rcr(); goto m15; }
                        if (x == 8 && y == 4) { rcr(); rcr(); uul(); rcr(); rcr(); goto m15; }
                        if (y < 3) { rcl(); rdl(); y += 9; } else if (y > 5 && y < 9) { rcl(); rdl(); y -= 3; }
                        if (x < 6 && x > 2) { if (x == 4) { ucr(); ucr(); x += 6; if (y == 3) y = 5; else y = 3; } else { uur(); uur(); x += 9; } }
                        else if (y != 5 && x < 3) { if (y == 3) { uur(); uur(); y += 2; goto m14_2; } else if (x == 0) { uur(); x += 1; y += 1; goto m14_2; } else if (x == 2) { uur(); x -= 1; y += 1; goto m14_2; } }
                        else
                        {
                            if (y == 3 && x == 7) { goto m15; }
                                 else if (x == 7 && y == 9) { goto m14_2; }
                            else if    (x == 7 && y == 5) { rcr(); rcr(); uur(); uur(); rcr(); rcr(); goto m15; }
                                         else goto m14_1;
                                } 
                        if (x > 8)
                        {
                            if (x == 11) { goto m14_1; }
                            else if (x == 9) { rdr(); rdr(); x += 2; goto m14_1; }
                            else if (y == 3) { rdl(); y += 1; x += 1; goto m14_1; }
                            else { rdr(); y -= 1; x += 1; goto m14_1; }
                        }
                      
                        if (x == 8 && y == 4) { rcr(); rcr(); uul(); rcr(); rcr(); }
                    } 
                }
            }
   
        m14_1: uur(); rcr();goto m15;
    m14_2: rcl();rcl(); goto m15;
        m15: ;
        }

       


        private void Start(object sender, EventArgs e)
        {
            mas1[0, 0] = 1;
            //=============mas1
            for (int q = 6, w = 3, y = 6, u = 6,w1=11,w2=5, u1 = 9, o = 0; o < 9; u++, o++,w++,  u1++ ,w1--)
            {
                if (u1 == 12) { q++; w = 3; y++; u = 6; u1 = 9; w1 = 11; w2--; }
                mas1[q, w] = mas[q, w1];
                mas1[q, u] = mas[q, w1-9];
                mas1[w2, u - 3] = mas[q + 3, u - 3];
                
            }
            
            
            Point[] par1 = { new Point(60, 60), new Point(160, 60), new Point(210, 110), new Point(50, 50) };
            Point[] pt = {new Point(100,150), new Point(700,150) };
            //-----------------------------------------------------------

            int i, j, c, k = 0, x=100, y1 = 200, l = 0;
            int m = 0, p = 0,z1=0;
            for(i=0;i<9;i++)
            {
                if ((i == 3)) { k = 110; l = 110; } else
                if ((i == 4)) { k = 55; l = 55; }else
                l = 0;
                
                for (j = 0; j < 9; j++)
                {

                    if ((j > 2) & (j < 9))
                    {

                        if ((i == 6) || (i == 5)) { k = 0; }
                        if (i == 7) { k = 110; }
                        if (i == 8) { k = 220; }

                        Brush brush1 = new LinearGradientBrush(pt[0], pt[1], Color.FromArgb(100, 100, 100), Color.FromArgb(200, 200, 200));
                        Brush brush2 = new LinearGradientBrush(pt[0], pt[1], Color.FromArgb(220, 220, 0), Color.FromName("Yellow"));
                        Brush brush3 = new LinearGradientBrush(pt[0], pt[1], Color.FromArgb(100, 0, 100), Color.FromName("Pink"));
                        Brush brush4 = new LinearGradientBrush(pt[0], pt[1], Color.FromArgb(0, 0, 100), Color.FromName("Blue"));
                        Brush brush5 = new LinearGradientBrush(pt[0], pt[1], Color.FromArgb(100, 0, 0), Color.FromName("Red"));
                        Brush brush6 = new LinearGradientBrush(pt[0], pt[1], Color.FromArgb(0, 100, 0), Color.FromName("Green"));
                        for (int r = 0; r < 2; r++)
                        {
                            if (r == 0)
                            {
                                y1 = 200;
                                c = mas[i, j] / 10;
                                x = 100; z1 = 0;
                            }
                            else
                            {
                                
                                c = mas1[i, j] / 10;
                                x = 900;
                                l -= 110;
                                if (mas1[0, 0] == 1)
                                {
                                    if ((i > 5) & (i < 9) & (j > 5)) { m -= 55; p += 55; x = 420; }
                                    if ((i < 6) & (j < 6)) { x = 740; z1 = 320; }
                                if ((i > 6) & (j == 5)) { m -= 165; p += 165; }
                                
                                    y1 = 40;
                                }
                            } 

                            Point[] paralelepiped1 = { new Point(x + l, 200 - k+z1), new Point(x + 100 + l, 200 - k+z1), new Point(x + 150 + l, 150 - k+z1), new Point(x + 50 + l, 150 - k+z1) };
                            Point[] paralelepiped2 = { new Point(x + 320 + m, 200 + k + p), new Point(x + 370 + m, 150 + k + p), new Point(x + 370 + m, 250 + k + p), new Point(x + 320 + m, 300 + k + p) };

                            if (c == 1)  mal_kub(brush1, i, j, x, l, y1, k, m, p, paralelepiped1, paralelepiped2);  
                            if (c == 2)  mal_kub(brush2, i, j, x, l, y1, k, m, p, paralelepiped1, paralelepiped2);  
                            if (c == 3)  mal_kub(brush3, i, j, x, l, y1, k, m, p, paralelepiped1, paralelepiped2);  
                            if (c == 4)  mal_kub(brush4, i, j, x, l, y1, k, m, p, paralelepiped1, paralelepiped2);  
                            if (c == 5)  mal_kub(brush5, i, j, x, l, y1, k, m, p, paralelepiped1, paralelepiped2);  
                            if (c == 6)  mal_kub(brush6, i, j, x, l, y1, k, m, p, paralelepiped1, paralelepiped2);
                            l += 110; if ((i > 5) & (i < 9) & (j > 5)) { m += 55; p -= 55;  }
                        }
                    }

                }
             
            }// end for 
         
        }
        public  void  mal_kub(Brush b, int i, int j, int x, int l, int y, int k, int m, int p,Point[] par1,Point[] par2)
        {
            Graphics g = panelDraw.CreateGraphics();
            if ((i > 5) & (i < 9) & (j < 6)) { g.FillRectangle(b, new Rectangle(x + l, y + k, 100, 100)); }
            if ((i > 5) & (i < 9) & (j > 5)) { g.FillPolygon(b, par2); }//m += 55; p -= 55; }
            if ((i > 2) & (i < 6)) { g.FillPolygon(b, par1); } 
            l += 110;
    /*        Pen pen = new Pen(Color.Black, 10);
                Brush brush7 = new SolidBrush(Color.Black);
            g.DrawLine(pen, 740, 205, 1060, 205);//FillRectangle(brush7, new Rectangle(740, 200, 320, 10));
            g.FillRectangle(brush7, new Rectangle(1050, 200, 10, 320));
            g.DrawLine(pen, 1055, 205, 1220, 40);
            g.DrawLine(pen, 1220, 40, 1220, 360);
            g.DrawLine(pen, 1220, 356, 1055, 520);//rd
            g.DrawLine(pen, 1058, 520, 740, 520);
            g.DrawLine(pen, 740, 525,740,200 );
            g.DrawLine(pen, 738, 205,905,33 );
            g.DrawLine(pen, 902, 34,1224,35 );
            float[] dashValues = { 3,3,3,3 };
          
            pen.DashPattern = dashValues;
            g.DrawLine(pen, new Point(902, 360), new Point(1220, 360));
            g.DrawLine(pen, new Point(902, 360), new Point(902, 34));
            g.DrawLine(pen, new Point(902, 360), new Point(740, 520));
            */
        }

        public void left()
        {
            int z1, z2, z3, i,j;
            for(i=6;i<9;i++)
            {
            z1 = mas[i, 0];
            z2 = mas[i, 1];
            z3 = mas[i, 2];

            for (j = 0; j < 9;j++ ) { mas[i,j]=mas[i,j+3];  }
            mas[i, 9] = z1;
            mas[i, 10] = z2;
            mas[i, 11] = z3;
            }

            verhinyz(3,3);
            zadnia_st(true);
               
            //==================end left
        }

        public void Up()
        {
            int z1, z2, z3,i,j;
            for ( j = 3; j < 6; j++)
            {
                z1 = mas[0,j];
                z2 = mas[1,j];
                z3 = mas[2,j];

                for ( i = 0; i < 9; i++) { mas[i, j] = mas[i+3, j]; }
                mas[9,j] = z1;
                mas[10,j] = z2;
                mas[11,j] = z3;
            }
            verhinyz(6, 6);
            zadnia_st(false); 
               
        }

        public void verhinyz(int i,int j)
        { int z;
            z = mas[i, j];
            mas[i, j] = mas[i + 2, j];
            mas[i + 2, j] = mas[i + 2, j + 2];
            mas[i + 2, j + 2] = mas[i, j + 2];
            mas[i, j + 2] = z;

            z = mas[i, j + 1];
            mas[i, j + 1] = mas[i + 1, j];
            mas[i + 1, j] = mas[i + 2, j + 1];
            mas[i + 2, j + 1] = mas[i + 1, j + 2];
            mas[i + 1, j + 2] = z;
            if (i==3)  i += 6;
            else j -= 6;
            z = mas[i, j];
            mas[i, j] = mas[i, j + 2];
            mas[i, j + 2] = mas[i + 2, j + 2];
            mas[i + 2, j + 2] = mas[i + 2, j];
            mas[i + 2, j] = z;
            z = mas[i, j + 1];
            mas[i, j + 1] = mas[i + 1, j + 2];
            mas[i + 1, j + 2] = mas[i + 2, j + 1];
            mas[i + 2, j + 1] = mas[i + 1, j];
            mas[i + 1, j] = z;
        }


        public void zadnia_st(bool w)
        {
            int i = 0, j = 3, m = 8, n = 11;
                    for (int k = 0; k < 9; k++)
                    {
                        if (!w) mas[m, n] = mas[i, j];
                        else mas[i, j] = mas[m, n];
                        i++; m--;
                        if (m == 5) { n--; j++; i = 0; m = 8; }
                    }
         }


        public void matrycia()
        {
            Start(null, null);
            string pr = " ";
            label1.Text = label2.Text = "";
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    if (mas[i, j] == 0) pr = "    "; else pr = "  ";
                    label1.Text += Convert.ToString(mas[i, j]) + pr;
                    label2.Text += Convert.ToString(mas1[i, j]) + pr;
                }
                label1.Text += "\n";
                label2.Text += "\n";
            }
            
        }

        public void f_r_up()
        {
            int z1, z2, z3, m;
            z1 = mas[0, 5];
            z2 = mas[1, 5];
            z3 = mas[2, 5];
            for (int n = 0; n < 9; n++)
            { mas[n, 5] = mas[n + 3, 5]; }

            mas[9, 5] = z1;
            mas[10, 5] = z2;
            mas[11, 5] = z3;

            m = mas[6, 6];
            mas[6, 6] = mas[8, 6];
            mas[8, 6] = mas[8, 8];
            mas[8, 8] = mas[6, 8];
            mas[6, 8] = m;

            m = mas[6, 7];
            mas[6, 7] = mas[7, 6];
            mas[7, 6] = mas[8, 7];
            mas[8, 7] = mas[7, 8];
            mas[7, 8] = m;

            mas[6, 9] = mas[2, 5];
            mas[7, 9] = mas[1, 5];
            mas[8, 9] = mas[0, 5];
        }
       
        public void po_z_vl()
        {
            Up(); for (int i = 0; i < 3; i++) { left(); } Up(); Up(); Up();
        }
        public void po_z_vr()
        {
        Up(); Up(); Up(); left(); left(); left(); Up();
        }
        public void f_l_up()
        {
            po_z_vl(); po_z_vl(); f_r_up(); f_r_up(); f_r_up(); po_z_vl(); po_z_vl();
        }
        //===========================================================
        private void r(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++) left(); matrycia(); 
        }
        private void l(object sender, EventArgs e)
        {
            l();
        }

        private void u(object sender, EventArgs e)
        {
            u();
        }

        private void d(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++) Up(); matrycia();
        }

        private void po_z_l(object sender, EventArgs e)
        {
            po_z_vr();
            matrycia(); 
        }
        private void po_z_r(object sender, EventArgs e)
        {
            
            po_z_vl();
            matrycia();
        }
        private void min_misc(object sender, EventArgs e)
        {
            Up(); Up(); left(); left(); left();
            matrycia();
        }

        private void b3(object sender, EventArgs e)
        {
            fru();
        }

        private void b1(object sender, EventArgs e)
        {
            flu();
        }


        private void fld(object sender, EventArgs e)
        {
            fld();
        }

        private void frd(object sender, EventArgs e)
        {
            frd();
        }
        private void button18_Click(object sender, EventArgs e)
        {
            uul();
        }
        private void button17_Click(object sender, EventArgs e)
        {
            uur();
        }
        private void button16_Click(object sender, EventArgs e)
        {
            udl();

        }
        private void button19_Click(object sender, EventArgs e)
        {

            udr();
        }
        private void button13_Click(object sender, EventArgs e)
        {
            rul();
        }
        private void button15_Click(object sender, EventArgs e)
        {
            rur();
        }
        private void button11_Click(object sender, EventArgs e)
        {
            rdr();
        }
        private void button14_Click(object sender, EventArgs e)
        {
            rdl();
        }
        private void button22_Click(object sender, EventArgs e)
        {
            ucr();
        }
        private void button23_Click(object sender, EventArgs e)
        {
            ucl();
        }
        private void button24_Click(object sender, EventArgs e)
        {
            rcl();
        }
        private void rcr(object sender, EventArgs e)
        {
            rcr();
        }
        private void fcu(object sender, EventArgs e)
        {
            fcu();
        }
        private void fcd(object sender, EventArgs e)
        {
            fcd();
  
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Start(null, null);
            Start(null, null);
        }
        //============================================================

       

       
        
    }
      
      
        
}

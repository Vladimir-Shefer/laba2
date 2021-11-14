using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DarkUI.Forms;

namespace VitchMat_SLAY
{
    public partial class Form1 : DarkForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        void Razmer()
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            dataGridView1.RowCount = Convert.ToInt32(t_raz.Text);
            dataGridView1.ColumnCount = Convert.ToInt32(t_raz.Text);
            dataGridView2.RowCount = Convert.ToInt32(1);
            dataGridView2.ColumnCount = Convert.ToInt32(t_raz.Text);
            dataGridView3.RowCount = Convert.ToInt32(2);
            dataGridView3.ColumnCount = Convert.ToInt32(t_raz.Text);
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView2.Rows[0].Cells[i].Value = 1;
                dataGridView3.Rows[0].Cells[i].Value = 0;
                dataGridView3.Rows[1].Cells[i].Value = 0;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = 0;
                     
                }
                
            }

        }
        double Slay(int i, int j)
        {
            return Convert.ToDouble(dataGridView1.Rows[i].Cells[j].Value.ToString());
        }
        



        private void darkButton1_Click(object sender, EventArgs e)
        {
            if (Chek() == false)
            {

            }
            else
            {
                Razmer();
            }
        }
        private void darkButton2_Click(object sender, EventArgs e) //степенной
        {
            if (Chek() && Chek2())
            {


            }
        }


        /*Ниже куча проверочтек*/

        bool Chek()
        {
            double h;
            try
            {
                if (Convert.ToInt32(t_raz.Text) > 10 || Convert.ToInt32(t_raz.Text) < 2)
                {
                    MessageBox.Show("Размерность должна быть больше 1 и меньше 11", "Ошибка",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (!Double.TryParse(t_raz.Text, out h))
                {
                    MessageBox.Show("Неверная размерность", "Ошибка",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                
                else
                {
                    return true;
                }
            }
            catch { return false; }
        }

        bool Chek2()
        {
            double h;

            if (!Double.TryParse(darkTextBox2.Text, out h))
            {
                MessageBox.Show("Неверная погрешность", "Ошибка",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            for (int g = 0; g < Convert.ToInt32(t_raz.Text); g++)
            {
                try
                {
                    h = Convert.ToDouble(dataGridView2.Rows[0].Cells[g].Value);
                }
                catch
                {
                    MessageBox.Show("Неверные данные вектора приблежения", "Ошибка",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                for (int k = 0; k < Convert.ToInt32(t_raz.Text); k++)
                {
                    try
                    {
                        h = Convert.ToDouble(dataGridView1.Rows[g].Cells[k].Value);
                    }
                    catch
                    {
                        MessageBox.Show("Неверные данные матрицы", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }


                if (dataGridView1.RowCount <= 1) {

                    MessageBox.Show("Пуста матрица коэффициентов", "Ошибка",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;

                }



            }

            return true;

        }

        List<double> FirstStep()
        {
            double p = 0;
            double q = 0;
            double d = 0;
            int maxi = 0;
            int maxj = 1;
            double max =Convert.ToDouble(dataGridView1.Rows[0].Cells[1].Value);

            for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                        {

                    if ((Math.Abs(Convert.ToDouble(dataGridView1.Rows[i].Cells[j].Value)) >= Math.Abs(max)) && (i != j))
                    {   maxi = i;
                        maxj = j;
                        max = Convert.ToDouble(dataGridView1.Rows[maxi].Cells[maxj].Value);
                    }


                        }
            }

            p = 2 * Convert.ToDouble(dataGridView1.Rows[maxi].Cells[maxj].Value);
            q = Convert.ToDouble(dataGridView1.Rows[maxi].Cells[maxi].Value) - Convert.ToDouble(dataGridView1.Rows[maxj].Cells[maxj].Value);
            d = Math.Sqrt(p * p + q * q);

            return new List<double>()
                { p, q, d, maxi, maxj };
        }

       
       
        bool StopCondition(List<double> l1, List<double> l2)
        {

            double eps = Convert.ToDouble(darkTextBox2.Text);
            for (int h = 0; h < Convert.ToInt32(t_raz.Text); h++)
            {
                if ((Math.Abs(l1[h] - l2[h])) > Math.Abs(eps)) return false;
            }
            return true;
        }

        List<double> M(List<double> Second)
            {
            int length = Convert.ToInt32(t_raz.Text);
            List<double> Third = new List<double>();
           
            for (var h = 0; h < length; h++)
            {
                Third.Add(0);
                    for (var k = 0; k < length; k++)
                    {
                        Third[h] += Slay(h,k) * Second[k];
                    }
                
            }
            return Third; 
        }


        List<double> M1(List<double> First, List<double> Second)
        {
            int length = Convert.ToInt32(t_raz.Text);
            List<double> Third = new List<double>();

            for (var h = 0; h < length; h++)
            {
                Third.Add(0);
                for (var k = 0; k < length; k++)
                {
                    Third[h] += First[h*length+ k] * Second[k];
                }

            }
            return Third;
        }





        private void t_raz_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && e.KeyChar != '-' && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox tb = (TextBox)e.Control;
            tb.KeyPress += new KeyPressEventHandler(dataGridView1_KeyPress);
        }

        private void darkButton3_Click(object sender, EventArgs e)  //степ
        {
            if (Chek() && Chek2())
            {



                darkTextBox4.Clear();
                for (int h = 0; h < Convert.ToInt32(t_raz.Text); h++)
                {
                    for (int f = 0; f < 1; f++)
                    {
                        dataGridView3.Rows[f].Cells[h].Value = 0;
                    }

                }

                List<double> X1 = new List<double>();
                List<double> X2 = new List<double>();
                double m = 0;
                int iter = 4;
                List<double> Y = new List<double>();
                List<double> l1 = new List<double>();
                List<double> l2 = new List<double>();
                for (int h = 0; h < Convert.ToInt32(t_raz.Text); h++)
                {
                    X1.Add(Convert.ToDouble(dataGridView2.Rows[0].Cells[h].Value.ToString()));
                    X2.Add(0);
                    m += Convert.ToDouble(dataGridView2.Rows[0].Cells[h].Value.ToString()) * Convert.ToDouble(dataGridView2.Rows[0].Cells[h].Value.ToString());
                    Y.Add(0);
                    l1.Add(0);
                    l2.Add(0);

                }
                m = Math.Sqrt(m);
                for (int h = 0; h < Convert.ToInt32(t_raz.Text); h++)
                {
                    X1[h] = X1[h] / m;

                }

                Y = M(X1);
                m = 0;
                for (int h = 0; h < Convert.ToInt32(t_raz.Text); h++)
                {
                    m += Y[h] * Y[h];
                }
                m = Math.Sqrt(m);
                for (int h = 0; h < Convert.ToInt32(t_raz.Text); h++)
                {
                    X2[h] = Y[h] / m;

                }
                for (int h = 0; h < Convert.ToInt32(t_raz.Text); h++)
                {
                    l1[h] = Y[h] / X1[h];

                }


                for (int h = 0; h < Convert.ToInt32(t_raz.Text); h++)
                {
                   X1[h]  = X2[h];
                }
            

                Y = M(X1);
                m = 0;
                for (int h = 0; h < Convert.ToInt32(t_raz.Text); h++)
                {
                    m += Y[h]*Y[h];
                }
                m = Math.Sqrt(m);
                for (int h = 0; h < Convert.ToInt32(t_raz.Text); h++)
                {
                    X2[h] = Y[h] / m;

                }
                for (int h = 0; h < Convert.ToInt32(t_raz.Text); h++)
                {
                    l2[h] = Y[h] /X1[h];

                }

                int hoho = 9;

                while (!StopCondition(l1,l2))
                {
                    for (int h = 0; h < Convert.ToInt32(t_raz.Text); h++)
                    {
                        X1[h] = X2[h];
                    }
                    for (int h = 0; h < Convert.ToInt32(t_raz.Text); h++)
                    {
                        l1[h] = l2[h];
                    }
                    
                    Y = M(X1);
                    m = 0;
                    for (int h = 0; h < Convert.ToInt32(t_raz.Text); h++)
                    {
                        m += Y[h] * Y[h];
                    }
                    m = Math.Sqrt(m);
                    for (int h = 0; h < Convert.ToInt32(t_raz.Text); h++)
                    {
                        X2[h] = Y[h] / m;

                    }
                    for (int h = 0; h < Convert.ToInt32(t_raz.Text); h++)
                    {
                        l2[h] = Y[h]/X1[h];

                    }
                    iter++;
                    if (iter > 1000)
                    {
                        MessageBox.Show("Все собственные числа - мнимые"
,
 "Пердупреждение",
            MessageBoxButtons.OK, MessageBoxIcon.Error); break;
                    }

                }
                double max= 0;

                if (iter <= 1000)
                {
                    for (int h = 0; h < Convert.ToInt32(t_raz.Text); h++)
                    {
                        max += l2[h] / Convert.ToInt32(t_raz.Text);
                        dataGridView3.Rows[0].Cells[h].Value = X2[h];


                    }
                    darkTextBox3.Text = Convert.ToString(max);
                }
                
                //////////////////////////////////////////////////////////////////////////////////////////////////////
                
                List<double> A = new List<double>();
                for (int h = 0; h < Convert.ToInt32(t_raz.Text); h++)
                {
                    for (int g = 0; g < Convert.ToInt32(t_raz.Text); g++)
                    {
                        if (g != h)
                            A.Add(Slay(h, g));
                        else A.Add(Slay(h, g) - max);
                    }    

                    
                    X2[h] =0;
                    X1[h] = Convert.ToDouble(dataGridView2.Rows[0].Cells[h].Value.ToString());
                    m += Convert.ToDouble(dataGridView2.Rows[0].Cells[h].Value.ToString()) * Convert.ToDouble(dataGridView2.Rows[0].Cells[h].Value.ToString());
                    Y[h] = 0;
                    l1[h] =0;
                    l2[h] = 0;

                }

                m = Math.Sqrt(m);
                for (int h = 0; h < Convert.ToInt32(t_raz.Text); h++)
                {
                    X1[h] = X1[h] / m;

                }

                Y = M1(A,X1);
                m = 0;
                for (int h = 0; h < Convert.ToInt32(t_raz.Text); h++)
                {
                    m += Y[h] * Y[h];
                }
                m = Math.Sqrt(m);
                for (int h = 0; h < Convert.ToInt32(t_raz.Text); h++)
                {
                    X2[h] = Y[h] / m;

                }
                for (int h = 0; h < Convert.ToInt32(t_raz.Text); h++)
                {
                    l1[h] = Y[h] / X1[h];

                }


                for (int h = 0; h < Convert.ToInt32(t_raz.Text); h++)
                {
                    X1[h] = X2[h];
                }

                Y = M1(A,X1);
                m = 0;
                for (int h = 0; h < Convert.ToInt32(t_raz.Text); h++)
                {
                    m += Y[h] * Y[h];
                }
                m = Math.Sqrt(m);
                for (int h = 0; h < Convert.ToInt32(t_raz.Text); h++)
                {
                    X2[h] = Y[h] / m;

                }
                for (int h = 0; h < Convert.ToInt32(t_raz.Text); h++)
                {
                    l2[h] = Y[h] / X1[h];

                }



                while (!StopCondition(l1, l2))
                {
                    for (int h = 0; h < Convert.ToInt32(t_raz.Text); h++)
                    {
                        X1[h] = X2[h];
                    }
                    for (int h = 0; h < Convert.ToInt32(t_raz.Text); h++)
                    {
                        l1[h] = l2[h];
                    }
                    Y = M1(A,X1);
                    m = 0;
                    for (int h = 0; h < Convert.ToInt32(t_raz.Text); h++)
                    {
                        m += Y[h] * Y[h];
                    }
                    m = Math.Sqrt(m);
                    for (int h = 0; h < Convert.ToInt32(t_raz.Text); h++)
                    {
                        X2[h] = Y[h] / m;

                    }
                    for (int h = 0; h < Convert.ToInt32(t_raz.Text); h++)
                    {
                        l2[h] = Y[h] / X1[h];

                    }
                    iter++;
                    if (iter > 1000)
                    {
                        MessageBox.Show("Второе искомое собственное число - мнимое, значит, существует только одно действительное собственное число"
,
 "Предупреждение",
            MessageBoxButtons.OK, MessageBoxIcon.Error); break;
                    }

                }
                if (iter <= 1000)
                {
                    double max1 = 0;

                    for (int h = 0; h < Convert.ToInt32(t_raz.Text); h++)
                    {
                        max1 += l2[h] / Convert.ToInt32(t_raz.Text);
                        dataGridView3.Rows[1].Cells[h].Value = X2[h];


                    }
                    max1 -= max;
                    darkTextBox4.Text = Convert.ToString(max1);
                }
                


                darkTextBox1.Text = Convert.ToString(iter);

            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Данное ПО находит две ненулевые собственные пары для симметричной матрицы степенным методом . Для начала работы" +
                "укажите размерность матрицы в пределах от 2 до 10, заполните левую матрицу. Укажите погрешность и нажмите на кнопку 'Вычислить стпеннным методом'." 
               , 
                "Инструкция",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
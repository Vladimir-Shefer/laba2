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
            dataGridView2.RowCount = Convert.ToInt32(t_raz.Text);
            dataGridView2.ColumnCount = Convert.ToInt32(t_raz.Text);
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {

                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = 0;
                    dataGridView2.Rows[i].Cells[j].Value = 0;
                    if (i ==j)
                        dataGridView1.Rows[i].Cells[i].Style.BackColor = Color.LightGreen;

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

        List<double> SecondStep(double p, double q, double d)
        {
            double s = 0;
            double c = 0;
            
            if (q==0)
            {
                s = c = Math.Sqrt(2) / 2;

            }
            else
            {
                if(p<=q*10)
                {
                    double r = 0;
                    r = Math.Abs(q) / (2 * d);
                    c = Math.Sqrt(0.5 + r);
                    s = Math.Abs(p) * (p * q / Math.Abs(p * q)) / (2 * c * d);
                }
                else
                {
                    double r = 0;
                    r = Math.Abs(q) / (2 * d);
                    c = Math.Sqrt(0.5 + r);
                    s = Math.Sqrt(0.5 - r) * (p * q / Math.Abs(p * q));
                }
            }


            return new List<double>()
                { s, c };
        }
        void ThirdStep(int i, int j, double s, double c)
        {
            List<double> b = new List<double>(); //Convert.ToInt32(t_raz.Text)* Convert.ToInt32(t_raz.Text)
            int length = Convert.ToInt32(t_raz.Text);
            for (int h = 0; h < dataGridView1.RowCount; h++)
            {
                for (int g = 0; g < dataGridView1.ColumnCount; g++)
                {
                    b.Add(Convert.ToDouble(dataGridView1.Rows[h].Cells[g].Value));
                }
            }
            for (int h = 0; h < dataGridView1.RowCount; h++)
            {
                for (int g = 0; g < dataGridView1.ColumnCount; g++)
                {
                    if (h==g && i==h)
                    {
                        b[i * length + i] = c * c * Slay(i, i) + 2 * c * s * Slay(i, j) + s * s * Slay(j, j);
                    }
                    
                    
                    else if (h == g && j == h)
                    {
                        b[j * length + j] = s * s * Slay(i, i) - 2 * c * s * Slay(i, j) + c * c * Slay(j, j);
                    }


                    else if((h == i && g == j) || (h == j && g == i))
                    {
                        b[h * length + g] = 0;
                    }


                    else if (h == i && g != j)
                    {
                        b[h * length + g] = c * Slay(g, i) + s * Slay(g, j);
                    }
                    else if(g == i && h != j)
                    {
                        b[h * length + g] = c * Slay(h, i) + s * Slay(h, j);
                    }


                    else if(h == j && g != i)
                    {
                        b[h * length + g] = c * Slay(g, j) - s * Slay(g, i);
                    }
                    else if(g == j && h != i)
                    {
                        b[h * length + g] = c * Slay(h,j) - s * Slay(h, i);
                    }

                    
                }
            }
         
            for (int h = 0; h < dataGridView1.RowCount; h++)
            {
                for (int g = 0; g < dataGridView1.ColumnCount; g++)
                {
                    dataGridView1.Rows[h].Cells[g].Value = b[h * length + g];
                }
            }
            dataGridView1.Update();

        }

        bool StopCondition(double eps)
        {
            dataGridView1.Update();
            double sum = 0;
            for (int h = 0; h < dataGridView1.RowCount; h++)
            {
                for (int g = 0; g < dataGridView1.ColumnCount; g++)
                {
                   if(h!=g)
                    {
                        sum += (Slay(h, g) * Slay(h, g));
                    } 

                }
            }
            if (Math.Abs(sum) < Math.Abs(eps))
                return true;
            else 
                return false;
        }

        List<double> Eiqenvectors(List<double> First, double s, double c, int i, int j)
            {
            int length = Convert.ToInt32(t_raz.Text);
            List<double> Third = new List<double>();
            List<double> Second = new List<double>();
            for (var h = 0; h < length; h++)
            {
                for (int g = 0; g < length; g++)
                {
                    Third.Add(0);
                    if (h == g)
                        Second.Add(1);
                    else
                        Second.Add(0);
                }
            }
            if (i>j) { int temp = i;
                i = j;
                j = temp;
            }
            Second[i * length + i] = c;
            Second[i * length + j] = s*(-1);
            Second[j * length + i] = s;
            Second[j * length + j] = c;

            for (var h = 0; h < length; h++)
            {
                for (var g = 0; g < length; g++)
                {
                    for (var k = 0; k < length; k++)
                    {
                        Third[h * length + g] += First[h * length + k] * Second[k * length + g];
                    }
                }
            }
            return Third; 
        }



        bool IsSymmetricalView()
        {
            for (int k = 0; k < dataGridView1.RowCount; k++)
                {
                    for (int i = k; i < dataGridView1.ColumnCount; i++)
                    {
                        if (Slay(k,i) != Slay(i,k))
                        {
                        MessageBox.Show("Матрица не симметричная. Пожалуйста, введите симметричную", "Ошибка",
                           MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }
                    }

                
                }
            return true;
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

        private void darkButton3_Click(object sender, EventArgs e)  //Якоби
        {
            if (Chek() && Chek2()) 
            {
                if (IsSymmetricalView()) {
                    int iter = 0;
                    int length = Convert.ToInt32(t_raz.Text);
                    List<double> eiqenvectors = new List<double>();
                    for (int h = 0; h < dataGridView1.RowCount; h++)
                    {
                        for (int g = 0; g < dataGridView1.ColumnCount; g++)
                        {
                            if (h == g)
                                eiqenvectors.Add(1);
                            else
                                eiqenvectors.Add(0);
                        }
                    }
                    try
                    {
                        while (StopCondition(Convert.ToDouble(darkTextBox2.Text)) == false)
                        {
                            List<double> consts = FirstStep(); // (_) / (p, q, d ,i , j)
                            List<double> angleinfo = SecondStep(consts[0], consts[1], consts[2]); // (p, q, d) / (s,c)
                            ThirdStep(Convert.ToInt32(consts[3]), Convert.ToInt32(consts[4]), angleinfo[0], angleinfo[1]); // ( i, j, s, c)/ (_)
                            eiqenvectors = Eiqenvectors(eiqenvectors, angleinfo[0], angleinfo[1], Convert.ToInt32(consts[3]), Convert.ToInt32(consts[4]));
                            iter++;



                        }
                    }
                    catch {
                        MessageBox.Show("",
                   "Ошибка алгоритма",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    for (int h = 0; h < dataGridView1.RowCount; h++)
                    {
                        for (int g = 0; g < dataGridView1.ColumnCount; g++)
                        {
                            dataGridView2.Rows[h].Cells[g].Value = eiqenvectors[h * length + g];
                        }
                    }
                    darkTextBox1.Text = Convert.ToString(iter);
                    

                }
            } 
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Данное ПО находит ненулевые собственные пары для симметричной матрицы методом Якоби. Для начала работы " +
                "укажите размерность матрицы в пределах от 2 до 10, заполните левую матрицу. Укажите погрешность и нажмите на кнопку 'Вычислить методом Якоби'. " +
                "На зеленых полях левой таблицы указаны собственные числа, а в правой - соответсвующие собственные векторы.", 
                "Инструкция",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
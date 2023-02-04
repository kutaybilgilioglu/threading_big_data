using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int senaryo;
            int look_for=0;
            int same;
            int id;
            if (radioButton1.Checked)
            {
                senaryo = 1;
            }
            else if (radioButton2.Checked)
            {
                senaryo = 2;
            }
            else if(radioButton3.Checked)
            {
                senaryo = 3;
            }
           
            else
            {
                senaryo = 0;
            }
            if (same_product.Checked)
            {
                same = 1;
            }
            else if (same_issue.Checked)
            {
                same = 2;
            }
            else if (same_company.Checked)
            {
                same = 3;
            }
            else if (same_state.Checked)
            {
                same = 4;
            }

            if (comp_product.Checked)
            {
                look_for = 1;
            }
            else if (comp_issue.Checked)
            {
                look_for = 2;
            }
            else if (comp_company.Checked)
            {
                look_for = 3;
            }
            else if (comp_state.Checked)
            {
                look_for = 4;
            }

            Globals.ui_info.Comp = look_for;
            Globals.ui_info.Oran = int.Parse(oran_goal.Text);
            
            Globals.ui_info.Thread_ = int.Parse(textBox1.Text);
            Globals.ui_info.Count_ = int.Parse(textBox2.Text);
            Globals.ui_info.Scenario = senaryo;
            Globals.is_pressed = true;
            Thread[] workerThreads = new Thread[Globals.ui_info.Thread_];
            var timer = System.Diagnostics.Stopwatch.StartNew();
            for (int a = 0; a < Globals.ui_info.Thread_; a++)
            {
                Console.WriteLine("thread start");
                workerThreads[a] = new Thread(Program.thread_method);
                workerThreads[a].IsBackground = false;
                workerThreads[a].Start(a);
            }
            
            for (int a = 0; a < Globals.ui_info.Thread_; a++)
            {
                workerThreads[a].Join();
            }
            timer.Stop();
            var runtime = (float)(timer.ElapsedMilliseconds / 1000);
            
            for(var s = Globals.ui_info.Thread_; s < 15; s++)
            {
                Globals.thr_runtime[s] = 0;
            }
            box_run.Text = Convert.ToString(runtime);
            box_thr0.Text = Convert.ToString(Globals.thr_runtime[0]);
            box_thr1.Text = Convert.ToString(Globals.thr_runtime[1]);
            box_thr2.Text = Convert.ToString(Globals.thr_runtime[2]);
            box_thr3.Text = Convert.ToString(Globals.thr_runtime[3]);
            box_thr4.Text = Convert.ToString(Globals.thr_runtime[4]);
            box_thr5.Text = Convert.ToString(Globals.thr_runtime[5]);
            box_thr6.Text = Convert.ToString(Globals.thr_runtime[6]);
            box_thr7.Text = Convert.ToString(Globals.thr_runtime[7]);
            box_thr8.Text = Convert.ToString(Globals.thr_runtime[8]);
            box_thr9.Text = Convert.ToString(Globals.thr_runtime[9]);
            box_thr10.Text = Convert.ToString(Globals.thr_runtime[10]);
            box_thr11.Text = Convert.ToString(Globals.thr_runtime[11]);
            box_thr12.Text = Convert.ToString(Globals.thr_runtime[12]);
            box_thr13.Text = Convert.ToString(Globals.thr_runtime[13]);
            box_thr14.Text = Convert.ToString(Globals.thr_runtime[14]);
            int row = dataGridView1.Rows.Add();
            row = 0;
            /*foreach(found_index data in Globals.result_i)
            {
                
                if(data == null)
                {
                    continue;
                }
                if (show_product.Checked)
                {
                    
                    dataGridView1.Rows[row].Cells[0].Value = Globals.yazlab_list.ElementAt(data.I).Product;
                    dataGridView1.Rows[row].Cells[5].Value = Globals.yazlab_list.ElementAt(data.J).Product;
                    
                }
                if (show_issue.Checked)
                {
                    dataGridView1.Rows[row].Cells[1].Value = Globals.yazlab_list.ElementAt(data.I).Issue;
                    dataGridView1.Rows[row].Cells[6].Value = Globals.yazlab_list.ElementAt(data.J).Issue;
                }
                if (show_company.Checked)
                {
                    dataGridView1.Rows[row].Cells[2].Value = Globals.yazlab_list.ElementAt(data.I).Company;
                    dataGridView1.Rows[row].Cells[7].Value = Globals.yazlab_list.ElementAt(data.J).Company;
                }
                if (show_complaint.Checked)
                {
                    dataGridView1.Rows[row].Cells[3].Value = Globals.yazlab_list.ElementAt(data.I).ID;
                    dataGridView1.Rows[row].Cells[8].Value = Globals.yazlab_list.ElementAt(data.J).ID;
                }
                if (show_state.Checked)
                {
                    dataGridView1.Rows[row].Cells[4].Value = Globals.yazlab_list.ElementAt(data.I).State;
                    dataGridView1.Rows[row].Cells[9].Value = Globals.yazlab_list.ElementAt(data.J).State;
                }
                if (show_oran.Checked)
                {
                    dataGridView1.Rows[row].Cells[10].Value = data.Diff;
                    
                }
                row = dataGridView1.Rows.Add();
            }*/
            for(var a = 0; a < 400; a++)
            {
                if (Globals.result_i.ElementAt(a) == null)
                {
                    continue;
                }
                if (show_product.Checked)
                {

                    dataGridView1.Rows[row].Cells[0].Value = Globals.yazlab_list.ElementAt(Globals.result_i.ElementAt(a).I).Product;
                    dataGridView1.Rows[row].Cells[5].Value = Globals.yazlab_list.ElementAt(Globals.result_i.ElementAt(a).J).Product;

                }
                if (show_issue.Checked)
                {
                    dataGridView1.Rows[row].Cells[1].Value = Globals.yazlab_list.ElementAt(Globals.result_i.ElementAt(a).I).Issue;
                    dataGridView1.Rows[row].Cells[6].Value = Globals.yazlab_list.ElementAt(Globals.result_i.ElementAt(a).J).Issue;
                }
                if (show_company.Checked)
                {
                    dataGridView1.Rows[row].Cells[2].Value = Globals.yazlab_list.ElementAt(Globals.result_i.ElementAt(a).I).Company;
                    dataGridView1.Rows[row].Cells[7].Value = Globals.yazlab_list.ElementAt(Globals.result_i.ElementAt(a).J).Company;
                }
                if (show_complaint.Checked)
                {
                    dataGridView1.Rows[row].Cells[3].Value = Globals.yazlab_list.ElementAt(Globals.result_i.ElementAt(a).I).ID;
                    dataGridView1.Rows[row].Cells[8].Value = Globals.yazlab_list.ElementAt(Globals.result_i.ElementAt(a).J).ID;
                }
                if (show_state.Checked)
                {
                    dataGridView1.Rows[row].Cells[4].Value = Globals.yazlab_list.ElementAt(Globals.result_i.ElementAt(a).I).State;
                    dataGridView1.Rows[row].Cells[9].Value = Globals.yazlab_list.ElementAt(Globals.result_i.ElementAt(a).J).State;
                }
                if (show_oran.Checked)
                {
                    dataGridView1.Rows[row].Cells[10].Value = Globals.result_i.ElementAt(a).Diff;

                }
                row = dataGridView1.Rows.Add();
            }


        }
        public void insert_table(int row, int i, int j, int diff)
        {
            
            
            if (show_product.Checked)
            {
                dataGridView1.Rows[row].Cells[0].Value = Globals.yazlab_list.ElementAt(i).Product;
                dataGridView1.Rows[row].Cells[5].Value = Globals.yazlab_list.ElementAt(j).Product;
            }
            if (show_issue.Checked)
            {
                dataGridView1.Rows[row].Cells[1].Value = Globals.yazlab_list.ElementAt(i).Issue;
                dataGridView1.Rows[row].Cells[6].Value = Globals.yazlab_list.ElementAt(j).Issue;
            }
            if (show_company.Checked)
            {
                dataGridView1.Rows[row].Cells[2].Value = Globals.yazlab_list.ElementAt(i).Company;
                dataGridView1.Rows[row].Cells[7].Value = Globals.yazlab_list.ElementAt(j).Company;
            }
            if (show_complaint.Checked)
            {
                dataGridView1.Rows[row].Cells[3].Value = Globals.yazlab_list.ElementAt(i).ID;
                dataGridView1.Rows[row].Cells[8].Value = Globals.yazlab_list.ElementAt(j).ID;
            }
            if (show_state.Checked)
            {
                dataGridView1.Rows[row].Cells[4].Value = Globals.yazlab_list.ElementAt(i).State;
                dataGridView1.Rows[row].Cells[9].Value = Globals.yazlab_list.ElementAt(j).State;
            }
            if (show_oran.Checked)
            {
                dataGridView1.Rows[row].Cells[10].Value = diff;

            }
        }








        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void product_Same_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void show_complaint_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}

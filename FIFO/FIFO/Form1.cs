using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIFO
{
    public partial class Form1 : Form
    {
        private List<Procedure> pList = new List<Procedure>();
        public Form1()
        {
            InitializeComponent();
            
        }
        
        
        int[] arr ;
         
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("\n");
            string disp = "";
            while (pList.Count != 0)
            {
                Procedure temp = new Procedure();
                temp.ProcedureName = pList[0].ProcedureName;
                temp.CycleLength = pList[0].CycleLength;

                 pList.Remove(pList[0]);

                while (temp.CycleLength != 0)
                {
                    disp += temp.ProcedureName + "  ";
                    temp.CycleLength--;
                }

              
               

            }
            textBox1.AppendText(disp+"\n"); ;


            }

        private void button2_Click(object sender, EventArgs e)
        {
            Shortest_Job_First form = new Shortest_Job_First();
            form.Show();
        }
        int counter = 0;
        private void button2_Click_1(object sender, EventArgs e)
        {
            counter++;
            Procedure obj = new Procedure();
            obj.ProcedureName = "P" + Convert.ToString(counter);
            obj.CycleLength = Convert.ToInt32(textBox2.Text);
            pList.Add(obj);
            textBox1.AppendText(obj.ProcedureName + "," + obj.CycleLength+" ");
            textBox2.Clear();
        }
    }
}

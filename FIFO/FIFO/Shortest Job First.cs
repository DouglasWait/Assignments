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
    public partial class Shortest_Job_First : Form
    {
        public Shortest_Job_First()
        {
            InitializeComponent();
        }
        
        int[] arr = new int[5] {5,3,8,1,6 };

        int[] arrpositions = new int[5] { 0, 1, 2,3, 4 };

        

        private void button1_Click(object sender, EventArgs e)
        {
            int smallest = 10;
            int smalindex=0 ;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        int temp = arrpositions[j];
                        arrpositions[j] = arrpositions[i];
                        arrpositions[i] = temp;
                    }
                }
                
              //  textBox1.AppendText("Execution time of process " + (smalindex + 1) + " :\t" + arr[i] + "\n");
            }
            for (int i = 0; i < arr.Length; i++)
            {
                textBox1.AppendText("Execution time of process " + (arrpositions[i]+1) + " :\t" + arr[arrpositions[i]] + "\n");
            }
            
        }

        private void Shortest_Job_First_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                textBox1.AppendText("Execution time of process " + (i + 1) + " :\t" + arr[i]+"\n");
            }
            textBox1.AppendText("\n\n");
        }
    }
}

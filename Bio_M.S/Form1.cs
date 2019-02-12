using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bio_M.S;

namespace Bio_M.S
{
    public partial class Form1 : Form
    {
        private int[][] Agents;
        private double[] AgentsIC;

        private double[][] MatIC;
        private double[] Back;

        public Form1()
        {
            InitializeComponent();
            Agents = new int[int.Parse(AgentNum.Text)][];
            AgentsIC = new double[int.Parse(AgentNum.Text)];

            MatIC = new double[4][];

            int i;
            for (i = 0; i < 4; i++)
                MatIC[i] = new double[int.Parse(Size.Text)];

            Back = new double[4];   //0->A , 1->T , 2->G , 3->C
            for (i = 0; i < 4; i++)
                Back[i] = 0;
        }

        private void run_Click(object sender, EventArgs e)
        {
            Seq.Text = Seq.Text.ToUpper();

            string tmp = Seq.Text.Replace("\r", "");
            string[] SeqArray = tmp.Split('\n');

            int i,j;

            //Cal Background
            for(i=0;i<SeqArray.Length;i++)
                for(j=0;j<SeqArray[i].Length;j++)
                {
                    if(SeqArray[i][j]=='A')
                        Back[0]++;
                    else if(SeqArray[i][j]=='T')
                        Back[1]++;
                    else if(SeqArray[i][j]=='G')
                        Back[2]++;
                    else if(SeqArray[i][j]=='C')
                        Back[3]++;
                }

            double k = 0;
            for (i = 0; i < 4; i++)
                k += Back[i];
            for (i = 0; i < 4; i++)
                Back[i]/=k;
            //End Cal Background

            for (i = 0; i < Agents.Length; i++)
                Agents[i] = new int[SeqArray.Length];

            Random r = new Random(DateTime.Now.DayOfYear + DateTime.Now.Second + DateTime.Now.Millisecond);

            for (i = 0; i < Agents.Length; i++)
                for (j = 0; j < Agents[i].Length; j++)
                    Agents[i][j] = r.Next(SeqArray[j].Length-int.Parse(Size.Text));

            MakeMatIC(SeqArray);
        }

        private string SubSeq(string s)
        {
            Random r = new Random(DateTime.Now.DayOfYear + DateTime.Now.Second + DateTime.Now.Millisecond);

            return s.Substring(r.Next(s.Length), int.Parse(Size.Text));
        }

        private void MakeMatIC(string[] SeqArray)
        {
            int i;
            for (i = 0; i < Agents.Length; i++)
            {
                int k ,j;
                for(k=0;k<4;k++)
                    for (j = 0; j < int.Parse(Size.Text); j++)
                    {
                        double result = FindProbab(i, j, k, SeqArray);
                        MatIC[k][j]=result*Math.Log(result/Back[k]);
                    }

                AgentsIC[i] = 0;
                for (k = 0; k < 4; k++)
                    for (j = 0; j < int.Parse(Size.Text); j++)
                        AgentsIC[i] += MatIC[k][j];
            }
        }

        private double FindProbab(int i, int j, int type, string[] SeqArray)//type =0 means A and etc.
        {
            int y=0;
            char c;

            if(type==0)
                c='A';
            else if(type==1)
                c='T';
            else if(type==2)
                c='G';
            else
                c='C';


            int x;
            for(x=0;x<SeqArray.Length;x++)
                if (SeqArray[x][Agents[i][x]+j] == c)
                    y++;

            return (y/SeqArray.Length);

        }
    }
}

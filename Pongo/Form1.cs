using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace Pongo
{
    public partial class Form1 : Form
    {
        byte k = 0,pL =0;
        ushort[] pings = new ushort[25],maxs = new ushort[20],avrgs = new ushort[20],pLoss = new ushort[10];
        TrackBar SpdTb = new TrackBar();
        private void StBtn_Click(object sender, EventArgs e)
        {
            if(StBtn.Text == "Start")
            {
                StBtn.Text = "Stop";
                PingTmr.Start();
            }
            else
            {
                StBtn.Text = "Start";
                PingTmr.Stop();
            }
        }

        public Form1()
        {
            InitializeComponent();
            chart1.Series.Clear();
            chart1.Series.Add("MaxPing");
            chart1.Series.Add("AvrPing");
            for(byte i = 0; i<20; i++)
            {
                maxs[i] = 0;
                avrgs[i] = 0;
                pLoss[i / 2] = 0;
            }


            SpdTb.Height = 30;
            SpdTb.Width = 200;
            SpdTb.Minimum = 0;
            SpdTb.Maximum = 10;
            SpdTb.Value = 5;
            SpdTb.Top = 10;
            SpdTb.Left = 250;
            Controls.Add(SpdTb);
            SpdTb.Scroll += new System.EventHandler(SpdTb_Scroll);
        }

        private void SpdTb_Scroll(object sender, EventArgs e)
        {
            PingTmr.Interval = SpdTb.Value *20 +1;
        }

        async private void timer1_Tick(object sender, EventArgs e)
        {
           
           Ping p = new Ping();
            PingReply pr;
      
             pr = await p.SendPingAsync("8.8.8.8");
        
            
            pings[k] = (ushort)pr.RoundtripTime;
            if (pings[k] == 0)
            {
               
                label1.Text +=pr.Status + "\n";
                pL++;
               k--;
            }
            else
                label1.Text += pings[k].ToString() + "ms\n";
            k++;
            if (k >= 24)
            {
                PlLbl.Text = "Loss = ";
                ushort loss = (ushort)(1000* pL / (25 + pL));
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
                for (byte i =0;i<19;i++)
                {
                    maxs[i] = maxs[i+1];
                    avrgs[i] = avrgs[i+1];
                    chart1.Series[0].Points.Add(maxs[i]);
                    chart1.Series[1].Points.Add(avrgs[i]);

               }
                ushort avrg=0;
                foreach(ushort q in pings)
                {
                    avrg += q;
                }
                avrg /= 25;
                maxs[19] = pings.Max();
                avrgs[19] = avrg;
                chart1.Series[0].Points.Add(maxs[19]);
                chart1.Series[1].Points.Add(avrgs[19]);
                label1.Text = "";
                k = 0;

                for (byte i = 0; i < 9; i++)
                 pLoss[i] = pLoss[i + 1];

                pLoss[9] = loss;
                loss = 0;
                foreach (ushort pl in pLoss)
                    loss += pl;
                loss /= 10;
                
                 var l = loss.ToString().ToCharArray();
                    for (byte i = 0; i < l.Length - 1; i++)
                    {
                        PlLbl.Text += l[i];
                    }
                    if (l.Length > 0)
                    {
                        if (l.Length == 1)
                            PlLbl.Text += '0';
                        PlLbl.Text += '.';
                        PlLbl.Text += l[l.Length - 1].ToString() + '%';
                    }
                
                pL = 0;
            }
        }
    }
}






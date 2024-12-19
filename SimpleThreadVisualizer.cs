using System;
using System.Windows.Forms;
using System.Threading;
using System.Drawing;

namespace ThreadTest
{
    public class ColorChangerForm : Form
    {
        static int threads = 16;

        public ColorChangerForm()
        {
            Panel[] panels = new Panel[threads];

            this.Size = new System.Drawing.Size(215, 238);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Text = "Work";

            int x = (int)Math.Ceiling(Math.Sqrt(10));

            int t = 0;
            for (int i = 0; i < x; i++)
            {
                if (t >= threads)
                    break;

                for (int j = 0; j < x; j++)
                {
                    if (t >= threads)
                        break;

                    panels[t] = new Panel
                    {
                        Width = 50,
                        Height = 50,
                        BorderStyle = BorderStyle.Fixed3D,
                        Location = new System.Drawing.Point(50 * j, 50 * i)
                    };

                    panels[t].Controls.Add(new Label 
                    { 
                        Text = t.ToString("D2"),
                        Location = new Point(10, 15),
                        Font = new Font("Arial", 12, FontStyle.Bold)
                });

                    this.Controls.Add(panels[t]);
                    t++;
                }
            }

            foreach (Panel panel in panels)
            {
                Thread.Sleep(100);
                Thread thread = new Thread(() =>
                {
                    ColorChangeLoop(panel);
                });
                thread.Start();
            }
        }

        private void ColorChangeLoop(object obj)
        {
            while (true)
            {
                Thread.Sleep(500);
                Panel panel = (Panel)obj;
                if (panel == null)
                    continue;
                int randomIndex = new Random().Next(4);

                if (randomIndex == 0)
                {
                    panel.BackColor = Color.Red;
                }
                else if (randomIndex == 1)
                {
                    panel.BackColor = Color.Blue;
                }
                else if (randomIndex == 2)
                {
                    panel.BackColor = Color.Green;
                }
                else
                {
                    panel.BackColor = Color.Yellow;
                }

                try
                {
                    Label label = (Label)panel.Controls[0];
                    MethodInvoker inv = delegate
                    {
                        label.Text = randomIndex.ToString("D2");
                    };
                    this.Invoke(inv);
                }
                catch { }
                
                this.Invalidate();
            }
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ColorChangerForm());
        }
    }
}

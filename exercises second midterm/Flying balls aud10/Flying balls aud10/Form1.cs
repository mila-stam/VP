using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flying_balls_aud10
{
    
    public partial class Form1 : Form
    {
        public Scene Scene { get; set; }
        public int TimerTicks { get; set; }
        public bool Stareted { get; set; } = true;
        public Form1()
        {
            InitializeComponent();
            Scene = new Scene(this.Height, this.Width);
            timer1.Interval = 200;
            timer1.Start();
            TimerTicks = 0;
            DoubleBuffered = true;
        }
        private void UpdateStatusLabels()
        { 
            tsslHits.Text = String.Format("Hits: {0}", Scene.Hits);
            tsslMisses.Text = String.Format("Misses: {0}", Scene.Misses );

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            ++TimerTicks;
            if (TimerTicks % 10 == 0)//na izminata edna sekunda
            {
                Scene.AddBall();
            }
            Scene.Move();
            UpdateStatusLabels();
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Scene.Draw(e.Graphics); 
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            Scene.Height = this.Height;
            Scene.Width = this.Width;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Scene.Hit(e.Location);
            Invalidate();
        }

        public void SaveScene(string path)
        {
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, Scene);
            fs.Close();
        }

        public void OpenScene(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open);
            IFormatter formatter = new BinaryFormatter();
            Scene = formatter.Deserialize(fs) as Scene;
            fs.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                SaveScene(openFileDialog.FileName);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                SaveScene(saveFileDialog.FileName);
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Scene = new Scene(this.Height, this.Width);
            Invalidate();
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stareted = !Stareted;
            if (Stareted)
            {
                timer1.Start();
                pauseToolStripMenuItem.Text = "Pause";
            }
            else
            {
                timer1.Stop();
                pauseToolStripMenuItem.Text = "Resume";
            }
        }
    }
}

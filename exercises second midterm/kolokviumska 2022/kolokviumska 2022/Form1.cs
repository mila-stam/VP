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

namespace kolokviumska_2022
{
    public partial class Form1 : Form
    {
        public Scene scene;
        public int Ticks;
        public Random Random = new Random();
        public bool Started { get; set; } = true;
        

        public Form1()
        {
            InitializeComponent();
            scene = new Scene();
            timer1.Start();
            DoubleBuffered = true;
            Ticks = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            scene.Init(this.Width, this.Height);
            scene.Init(this.Width, this.Height);
            scene.Init(this.Width, this.Height);
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            scene.DrawAll(e.Graphics);
            scene.DrawBlack(e.Graphics);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ++Ticks;
            if(Ticks%10 == 0)
            {
                scene.Init(this.Width, this.Height);
            }
            scene.Move(this.Width, this.Height);
            
            Invalidate();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                scene.BlackBall = new BlackBall(e.Location);
            }
            Invalidate();
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Started = !Started;
            if(Started)
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
        public void SaveScene(string path)
        {
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, scene);
            fs.Close();
        }
        public void OpenScene(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open);
            IFormatter formatter = new BinaryFormatter();
            scene = formatter.Deserialize(fs) as Scene;
            fs.Close();
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
            scene = new Scene();
            Invalidate();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                SaveScene(openFileDialog.FileName);
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(scene.BlackBall != null)
            {
                scene.BlackBall.Center = e.Location;
            }
            
        }
    }
}

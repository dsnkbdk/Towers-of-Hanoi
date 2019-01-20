using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Towers_of_Hanoi
{
    public partial class MainForm : Form
    {
        Board MyBoard;
        Disk CurDisk;
        int MinMoves = 15;
        bool IsPlay = false;
        ArrayList AllMoves;
        int CurMove;

        public MainForm()
        {
            InitializeComponent();

            CurDisk = null;
            MyBoard = new Board(
                new Disk(lblDisk1, 0, 3, 0), new Disk(lblDisk2, 0, 2, 0),
                new Disk(lblDisk3, 0, 1, 0), new Disk(lblDisk4, 0, 0, 0)
            );
        }

        //MouseDown
        private void Disk_MouseDown(object sender, MouseEventArgs e)
        {
            if (IsPlay)
                return;

            Label alabel = (sender as Label);
            CurDisk = MyBoard.FindDisk(alabel);
            if (!MyBoard.canStartMove(CurDisk))
            {
                txtMoves.Text += "Unable to start move." + Environment.NewLine;
                return;
            }

            alabel.DoDragDrop(alabel, DragDropEffects.All);
        }

        //DragDrop
        private void Disk_DragDrop(object sender, DragEventArgs e)
        {
            if (IsPlay)
                return;

            Label alabel = (sender as Label);
            int peg = int.Parse(alabel.Tag.ToString());
            if (!MyBoard.canDrop(CurDisk, peg))
            {
                txtMoves.Text += "Unable to drop." + Environment.NewLine;
                return;
            }

            Move(CurDisk, peg);
        }

        private void Move(Disk disk, int peg)
        {
            MyBoard.move(disk, peg);
            txtMoves.Text += MyBoard.getLastMoveString() + Environment.NewLine;
            MyBoard.Display();
            lblMoves.Text = (int.Parse(lblMoves.Text) + 1).ToString();

            if (MyBoard.isFinished())
            {
                string tips = "You have successfully completed the game but not with the minimum number of moves.";
                if (MinMoves == int.Parse(lblMoves.Text))
                    tips = "You have successfully completed the game with the minimum number of moves.";
                MessageBox.Show(tips);
                txtMoves.Text += tips;
            }
        }

        private void Disk_DragEnter(object sender, DragEventArgs e)
        {
            if (IsPlay)
                return;

            e.Effect = DragDropEffects.All;
        }

        private void txtMoves_TextChanged(object sender, EventArgs e)
        {
            if (txtMoves.TextLength > 0)
            {
                txtMoves.Select(txtMoves.TextLength - 1, 0);
                txtMoves.ScrollToCaret();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void reset()
        {
            MyBoard = new Board(
                new Disk(lblDisk1, 0, 3, 0), new Disk(lblDisk2, 0, 2, 0),
                new Disk(lblDisk3, 0, 1, 0), new Disk(lblDisk4, 0, 0, 0)
            );
            lblDisk1.Left = 96; lblDisk1.Top = 203;
            lblDisk2.Left = 80; lblDisk2.Top = 225;
            lblDisk3.Left = 64; lblDisk3.Top = 247;
            lblDisk4.Left = 48; lblDisk4.Top = 269;

            lblMoves.Text = "0";
            txtMoves.Clear();

            IsPlay = false;
            CurMove = 0;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            load(false);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            load(true);
        }

        private void load(bool play)
        {
            reset();
            openFileDialog1.Filter = "txt files|*.txt"; //Open file
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Stream myStream = null;
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        StreamReader st = new StreamReader(openFileDialog1.FileName);
                        AllMoves = new ArrayList();
                        string str = st.ReadLine();
                        while (str != null)
                        {
                            AllMoves.Add(str);
                            str = st.ReadLine();
                        }

                        IsPlay = play;
                        if (IsPlay)
                            timer1.Enabled = true; //Play animation
                        else
                        {
                            for (int i = 0; i < AllMoves.Count; i++)
                            {
                                DiskMove move = new DiskMove(AllMoves[i].ToString());
                                Move(MyBoard.getDisk(move.getDiskInd()), move.getPegInd());
                            }
                        }
                    }

                }
                catch (Exception ex) //Error file
                {
                    MessageBox.Show("Open file error：" + ex.Message);
                }
            }
        }

        private bool MoveNext()
        {
            if (CurMove >= AllMoves.Count)
                return false;
            DiskMove move = new DiskMove(AllMoves[CurMove++].ToString());
            Move(MyBoard.getDisk(move.getDiskInd()), move.getPegInd());
            return true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!MoveNext())
            {
                timer1.Enabled = false;
                IsPlay = false;
            }
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "txt files|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //File name
                string fileName = saveFileDialog1.FileName;
                //Create a file
                FileStream fs = File.Open(fileName,
                        FileMode.Create,
                        FileAccess.Write);
                StreamWriter wr = new StreamWriter(fs);
                wr.Write(MyBoard.allMovesAsString());

                //Close
                wr.Flush();
                wr.Close();
                fs.Close();
            }
        }
    }
}
namespace Towers_of_Hanoi
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtMoves = new System.Windows.Forms.TextBox();
            this.lblDisk1 = new System.Windows.Forms.Label();
            this.lblDisk2 = new System.Windows.Forms.Label();
            this.lblDisk3 = new System.Windows.Forms.Label();
            this.lblDisk4 = new System.Windows.Forms.Label();
            this.pnlBase = new System.Windows.Forms.Panel();
            this.lblPeg1 = new System.Windows.Forms.Label();
            this.lblPeg2 = new System.Windows.Forms.Label();
            this.lblPeg3 = new System.Windows.Forms.Label();
            this.lblMoves = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnStore = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtMoves
            // 
            this.txtMoves.Location = new System.Drawing.Point(603, 94);
            this.txtMoves.Multiline = true;
            this.txtMoves.Name = "txtMoves";
            this.txtMoves.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMoves.Size = new System.Drawing.Size(180, 241);
            this.txtMoves.TabIndex = 17;
            this.txtMoves.TextChanged += new System.EventHandler(this.txtMoves_TextChanged);
            // 
            // lblDisk1
            // 
            this.lblDisk1.BackColor = System.Drawing.Color.Lime;
            this.lblDisk1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisk1.Location = new System.Drawing.Point(96, 203);
            this.lblDisk1.Name = "lblDisk1";
            this.lblDisk1.Size = new System.Drawing.Size(48, 22);
            this.lblDisk1.TabIndex = 16;
            this.lblDisk1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Disk_MouseDown);
            // 
            // lblDisk2
            // 
            this.lblDisk2.BackColor = System.Drawing.Color.Lime;
            this.lblDisk2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisk2.Location = new System.Drawing.Point(80, 225);
            this.lblDisk2.Name = "lblDisk2";
            this.lblDisk2.Size = new System.Drawing.Size(80, 22);
            this.lblDisk2.TabIndex = 15;
            this.lblDisk2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Disk_MouseDown);
            // 
            // lblDisk3
            // 
            this.lblDisk3.BackColor = System.Drawing.Color.Lime;
            this.lblDisk3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisk3.Location = new System.Drawing.Point(64, 247);
            this.lblDisk3.Name = "lblDisk3";
            this.lblDisk3.Size = new System.Drawing.Size(112, 22);
            this.lblDisk3.TabIndex = 14;
            this.lblDisk3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Disk_MouseDown);
            // 
            // lblDisk4
            // 
            this.lblDisk4.BackColor = System.Drawing.Color.Lime;
            this.lblDisk4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisk4.Location = new System.Drawing.Point(48, 269);
            this.lblDisk4.Name = "lblDisk4";
            this.lblDisk4.Size = new System.Drawing.Size(144, 22);
            this.lblDisk4.TabIndex = 13;
            this.lblDisk4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Disk_MouseDown);
            // 
            // pnlBase
            // 
            this.pnlBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pnlBase.Location = new System.Drawing.Point(13, 291);
            this.pnlBase.Name = "pnlBase";
            this.pnlBase.Size = new System.Drawing.Size(584, 44);
            this.pnlBase.TabIndex = 9;
            // 
            // lblPeg1
            // 
            this.lblPeg1.AllowDrop = true;
            this.lblPeg1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblPeg1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPeg1.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.lblPeg1.Location = new System.Drawing.Point(109, 173);
            this.lblPeg1.Name = "lblPeg1";
            this.lblPeg1.Size = new System.Drawing.Size(24, 133);
            this.lblPeg1.TabIndex = 10;
            this.lblPeg1.Tag = "0";
            this.lblPeg1.Text = "A";
            this.lblPeg1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPeg1.DragDrop += new System.Windows.Forms.DragEventHandler(this.Disk_DragDrop);
            this.lblPeg1.DragEnter += new System.Windows.Forms.DragEventHandler(this.Disk_DragEnter);
            // 
            // lblPeg2
            // 
            this.lblPeg2.AllowDrop = true;
            this.lblPeg2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblPeg2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPeg2.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.lblPeg2.Location = new System.Drawing.Point(293, 173);
            this.lblPeg2.Name = "lblPeg2";
            this.lblPeg2.Size = new System.Drawing.Size(24, 133);
            this.lblPeg2.TabIndex = 11;
            this.lblPeg2.Tag = "1";
            this.lblPeg2.Text = "B";
            this.lblPeg2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPeg2.DragDrop += new System.Windows.Forms.DragEventHandler(this.Disk_DragDrop);
            this.lblPeg2.DragEnter += new System.Windows.Forms.DragEventHandler(this.Disk_DragEnter);
            // 
            // lblPeg3
            // 
            this.lblPeg3.AllowDrop = true;
            this.lblPeg3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblPeg3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPeg3.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.lblPeg3.Location = new System.Drawing.Point(469, 173);
            this.lblPeg3.Name = "lblPeg3";
            this.lblPeg3.Size = new System.Drawing.Size(24, 133);
            this.lblPeg3.TabIndex = 12;
            this.lblPeg3.Tag = "2";
            this.lblPeg3.Text = "C";
            this.lblPeg3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblPeg3.DragDrop += new System.Windows.Forms.DragEventHandler(this.Disk_DragDrop);
            this.lblPeg3.DragEnter += new System.Windows.Forms.DragEventHandler(this.Disk_DragEnter);
            // 
            // lblMoves
            // 
            this.lblMoves.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblMoves.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMoves.Location = new System.Drawing.Point(357, 18);
            this.lblMoves.Name = "lblMoves";
            this.lblMoves.Size = new System.Drawing.Size(48, 22);
            this.lblMoves.TabIndex = 21;
            this.lblMoves.Text = "0";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(275, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 22);
            this.label1.TabIndex = 20;
            this.label1.Text = "Moves:";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReset.Location = new System.Drawing.Point(12, 12);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(73, 32);
            this.btnReset.TabIndex = 19;
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLoad.Location = new System.Drawing.Point(12, 50);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(164, 32);
            this.btnLoad.TabIndex = 22;
            this.btnLoad.Text = "Load an incomplete ";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPlay.Location = new System.Drawing.Point(12, 88);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(164, 32);
            this.btnPlay.TabIndex = 23;
            this.btnPlay.Text = "Play a completed";
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnStore
            // 
            this.btnStore.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStore.Location = new System.Drawing.Point(103, 12);
            this.btnStore.Name = "btnStore";
            this.btnStore.Size = new System.Drawing.Size(73, 32);
            this.btnStore.TabIndex = 24;
            this.btnStore.Text = "Store";
            this.btnStore.Click += new System.EventHandler(this.btnStore_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Interval = 800;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 366);
            this.Controls.Add(this.btnStore);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lblMoves);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtMoves);
            this.Controls.Add(this.lblDisk1);
            this.Controls.Add(this.lblDisk2);
            this.Controls.Add(this.lblDisk3);
            this.Controls.Add(this.lblDisk4);
            this.Controls.Add(this.pnlBase);
            this.Controls.Add(this.lblPeg1);
            this.Controls.Add(this.lblPeg2);
            this.Controls.Add(this.lblPeg3);
            this.Name = "MainForm";
            this.Text = "The Towers of Hanoi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMoves;
        private System.Windows.Forms.Label lblDisk1;
        private System.Windows.Forms.Label lblDisk2;
        private System.Windows.Forms.Label lblDisk3;
        private System.Windows.Forms.Label lblDisk4;
        private System.Windows.Forms.Panel pnlBase;
        private System.Windows.Forms.Label lblPeg1;
        private System.Windows.Forms.Label lblPeg2;
        private System.Windows.Forms.Label lblPeg3;
        private System.Windows.Forms.Label lblMoves;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnStore;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
    }
}
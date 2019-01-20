using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Towers_of_Hanoi
{
    class Board
    {
        Disk[,] board; //condition says TWO dimentional array            
        ArrayList movements;
        Disk[] disks; //Array of disks

        private const int NUM_DISKS = 4;
        private const int NUM_PEGS = 3;

        public Board()
        {
            board = new Disk[NUM_PEGS, NUM_DISKS];
            movements = new ArrayList();

            //Array of disk objects
            disks = new Disk[NUM_DISKS];
            disks[0] = null;
            disks[1] = null;
            disks[2] = null;
            disks[3] = null;

            //Storing disk object into board array(Two dimensional arrray) 
            board = new Disk[NUM_PEGS, NUM_DISKS]; //condition says TWO dimentional array  

            board[0, 3] = new Disk();
            board[0, 2] = new Disk();
            board[0, 1] = new Disk();
            board[0, 0] = new Disk();

            //Creating arraylist of movement 
            movements = new ArrayList();
        }

        //Alterntative constructor
        public Board(Disk d1, Disk d2, Disk d3, Disk d4)
        {
            //Storing into disks array
            disks = new Disk[NUM_DISKS];
            disks[0] = d1;
            disks[1] = d2;
            disks[2] = d3;
            disks[3] = d4;

            //Storing disk object into board array(Two dimensional arrray) 
            board = new Disk[NUM_PEGS, NUM_DISKS]; //condition says TWO dimentional array  
            board[0, 3] = d1;
            board[0, 2] = d2;
            board[0, 1] = d3;
            board[0, 0] = d4;

            //Arraylist of movement.
            movements = new ArrayList();
        }


        public void reset()
        {
            for (int iP = 0; iP < NUM_PEGS; iP++)
            {
                //Remove all elements from board array
                for (int iD = 0; iD < NUM_DISKS; iD++)
                {
                    board[iP, iD] = null;

                    //Update disks array
                    disks[iD].setPegNum(0);
                    disks[iD].setLevel(NUM_DISKS - 1 - iD);
                }
            }

            //Reallocate elements 
            board[0, 3] = disks[0]; //Peg 1/Level4 
            board[0, 2] = disks[1]; //Peg 1/Level3 
            board[0, 1] = disks[2]; //Peg 1/Level2
            board[0, 0] = disks[3]; //Peg 1/Level1 

            //Remove all elements from movement arraylist
            movements.Clear();
        }


        public bool isFinished()
        {
            if (board[2, 3] == disks[0] && board[2, 2] == disks[1] && board[2, 1] == disks[2] && board[2, 0] == disks[3])
                return true;
            return false;
        }


        public bool canStartMove(Disk aDisk)
        {
            if (aDisk.getLevel() == NUM_DISKS - 1 || board[aDisk.getPegNum(), aDisk.getLevel() + 1] == null)
                return true;
            return false;
        }


        public bool canDrop(Disk aDisk, int aPeg)
        {
            int top = getLevel(aPeg);
            if (top < 0 || top == NUM_DISKS - 1)
                return true;
            else
                return board[aPeg, top].getDiameter() > aDisk.getDiameter();
        }


        public void move(Disk aDisk, int newLevel)
        {
            movements.Add(new DiskMove(getDiskNo(aDisk), newLevel));
            board[aDisk.getPegNum(), aDisk.getLevel()] = null;
            aDisk.setPegNum(newLevel);
            aDisk.setLevel(newLevInPeg(newLevel));
            board[newLevel, aDisk.getLevel()] = aDisk;
        }


        public string allMovesAsString()
        {
            string moves = "";
            for (int i = 0; i < movements.Count; i++)
                moves += (movements[i] as DiskMove).commaText() + Environment.NewLine;
            return moves;
        }


        public string getLastMoveString()
        {
            return movements.Count > 0 ? (movements[movements.Count - 1] as DiskMove).AsText() : "";
        }


        public void Display()
        {
            DiskMove move = (movements[movements.Count - 1] as DiskMove);
            int peg = move.getDiskInd();
            int newPeg = move.getPegInd();
            Label label = disks[peg].getLabel();
            label.Left = 124 + (newPeg * 180) - (label.Width / 2);
            label.Top = 270 - (getLevel(newPeg) * label.Height);
        }


        public Disk FindDisk(Label aLabel)
        {
            for (int i = 0; i < NUM_DISKS; i++)
                if (disks[i].getDiameter() == aLabel.Width)
                    return disks[i];
            return null;
        }


        public int newLevInPeg(int pegNum)
        {
            int top = getLevel(pegNum);
            return top + 1;
        }


        public int getDiskNo(Disk aDisk)
        {
            int num = NUM_DISKS - 1;
            while (num >= 0)
                if (aDisk == disks[num--])
                    return num + 1;
            return -1;
        }


        public String getText(int cnt)
        {
            return "";
        }


        public void backToSelected(int ind)
        {

        }


        public int getPegInd(int ind)
        {
            return 1;    // Dummy return to avoid syntax error - must be changed
        }


        public Disk getDisk(int ind)
        {
            return disks[ind];
        }


        public int getLevel(int ind)
        {
            int i = NUM_DISKS - 1;
            while (i >= 0)
                if (board[ind, i--] != null)
                    return i + 1;
            return -1;
        }


        public void unDo()
        {

        }


        public void loadData(ArrayList dm)
        {

        }
    }
}
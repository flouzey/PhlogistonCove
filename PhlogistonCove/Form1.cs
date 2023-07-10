using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using PhlogistonCove;

namespace PhlogistonCove
{
    public partial class Mainfrm : Form
    {
        private List<Cell> _cells = new List<Cell>();

        private Cell _selectedCell = null;

        private Random rng = new Random();

        private bool Running = true;

        private int PauseCount = 0; 

        public Mainfrm()
        {
            InitializeComponent();
            btnPause.BackColor = Color.Tomato;
            GridGeneration();
        }

        //Checks upon a click event to see if a cell has been chosen
        private void SelectCell(object sender, EventArgs e)
        {
            if (_selectedCell != null)
            {
                _selectedCell.BorderStyle = BorderStyle.None;
            }

            _selectedCell = ((Cell)sender);
            _selectedCell.BorderStyle = BorderStyle.Fixed3D;
            ;
            ShowInformationForCell(_selectedCell);
        }

        //the method used for grid re/generations
        public void GridGeneration()
        {
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    Cell cell = new Cell();
                    cell.Size = new Size(25, 25);
                    cell.SizeMode = PictureBoxSizeMode.StretchImage;

                    if (!cell.IsOccupied)
                    {
                        switch (rng.Next(0, 3))
                        {
                            case 0:
                                cell.Image = Properties.Resources.DuneTile1;
                                break;
                            case 1:
                                cell.Image = Properties.Resources.DuneTile2;
                                break;
                            case 2:
                                cell.Image = Properties.Resources.DuneTile3;
                                break;
                        }
                    }

                    cell.Location = new Point((i * cell.Size.Width), (j * cell.Size.Width));
                    cell.Click += SelectCell;
                    pnlMap.Controls.Add(cell);
                    _cells.Add(cell);
                }
            }
        }

        //shows the information for a cell once it is clicked on
        private void ShowInformationForCell(Cell selectedCell)
        {
            switch (selectedCell.IsOccupied)
            {
                case true:
                    lblSelectedCellInfo.Text = string.Format("A {0} occupies this land they have been alive for {1} days", selectedCell.Title, selectedCell.Lifespan);
                    break;

                case false:
                    lblSelectedCellInfo.Text = string.Format("This land is barren...");
                    break;
            }
        }
        
        //a button option to reset the grid
        private void btnReset_Click(object sender, EventArgs e)
        {
            pnlMap.Controls.Clear();
            _cells.Clear();
            GridGeneration();
        }

        //This timer depicts the days going by
        private void tmrGeneration_Tick(object sender, EventArgs e)
        {
            if (Running)
            {
                for (int i = 0; i < _cells.Count; i++)
                {
                    if (_cells[i].IsOccupied)
                    {
                        _cells[i].Lifespan++;
                    }
                }
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            switch (PauseCount)
            {
                case 0:
                    btnPause.BackColor = Color.MediumAquamarine;
                    btnPause.Text = "Resume the desert";
                    Running = false;
                    PauseCount++;
                    break;
                case 1:
                    btnPause.BackColor = Color.Coral;
                    btnPause.Text = "Pause the desert";
                    Running = true;
                    PauseCount--;
                    break;
            }
        }
    }
}

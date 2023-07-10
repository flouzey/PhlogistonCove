using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhlogistonCove
{
    class Cell : PictureBox
    {
        public bool IsOccupied = false;
        public bool IsPhlog = false;
        public bool IsSol = false;
        public bool IsMor = false;
        private Random rng = new Random();
        public string Title;
        public int Lifespan;

        public Cell()
        {
            int Odds = rng.Next(0,100);

            if (Odds >= 90)
                InstantiatePhlog();
            else if ((Odds < 90) && (Odds >= 85))
                InstantiateSol();
            else if ((Odds < 85) && (Odds >= 80))
                InstantiateMor();
        }

        public void InstantiatePhlog()
        { 
            //Phlogen phlogen = new Phlogen();
            this.Image = Properties.Resources.PhlogenTile;
            this.Title = "Phlogen";
            IsOccupied = true;
        }

        public void InstantiateSol()
        {
            //Solaire solaire = new Solaire();
            this.Image = Properties.Resources.SolaireTile;
            this.Title = "Solaire";
            IsOccupied = true;

        }

        public void InstantiateMor()
        {
            //Morcentt morcentt = new Morcentt();
            this.Image = Properties.Resources.MorcenttTile;
            this.Title = "Morcentt";
            IsOccupied = true;
        }
    }
}

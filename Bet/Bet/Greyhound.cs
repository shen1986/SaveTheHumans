using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bet
{
    public class Greyhound
    {
        public int StartingPosition; // Where my PictureBox starts
        public int RacetrackLength; // How long the racetrack is
        public PictureBox MyPictureBox = null; // My PictureBox object
        public int Location = 0; // My Location on the racetrack
        public Random Randomizer; // An instance of Random

        public bool Run()
        {
            // Move forward either 1,2,3 or 4 spaces at random
            // Update the position of my PrctureBox on the form like this:
            //   MyPictureBox.Left = StartingPosition + Location;
            // Return true if I won the race
        }

        public void TakeStartingPosition()
        {
            // Reset my location to 0 and my PictureBox to starting position
        }
    }
}

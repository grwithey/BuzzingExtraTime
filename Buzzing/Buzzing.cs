using Buzzing.Bees;
using Buzzing.Controls;
using Buzzing.Interfaces;
using System;
using System.Collections.Generic;using System.Windows.Forms;

namespace Buzzing
{
    // Normally this View layer would be driven from the ViewModel and be very lightweight.
    // I have only done it this way to try and meet the full functionality specified in the brief so
    // It can be demonstrated.
    public partial class Buzzing : Form
    {
        private List<IBee> _bees;

        public Buzzing()
        {
            InitializeComponent();

            _bees = CreateBees();

            PopulateUIWithBees();
        }

        private void PopulateUIWithBees()
        {
            // Add all bees to thier correct layers on the UI
            foreach (var bee in _bees)
            {
                var typeOfBee = bee.GetType();

                if (typeOfBee == typeof(Worker))
                {
                    flpWorkerBees.Controls.Add(new BeeView() { Bee = bee });
                }
                else if(typeOfBee == typeof(Drone))
                {
                    flpDroneBees.Controls.Add(new BeeView() { Bee = bee });
                }
                else if (typeOfBee == typeof(Queen))
                {
                    flpQueenBees.Controls.Add(new BeeView() { Bee = bee });
                }
            }

            UpdateAllViews();
        }

        private void UpdateAllViews()
        {
            foreach(var view in flpWorkerBees.Controls)
            {
                ((BeeView)view).Update();
                flpWorkerBees.Refresh();
            }
            foreach (var view in flpDroneBees.Controls)
            {
                ((BeeView)view).Update();
            }
            foreach (var view in flpQueenBees.Controls)
            {
                ((BeeView)view).Update();
            }
        }

        private List<IBee> CreateBees()
        {
            var bees = new List<IBee>();

            for(int i = 0; i<10; i++)
            {
                bees.Add(new Worker());
                bees.Add(new Queen());
                bees.Add(new Drone());
            }
            
            return bees;
        }

        private void btnDamageBee_Click(object sender, System.EventArgs e)
        {
            var randomNoGenerator = new Random();

            foreach(var bee in _bees)
            {
                bee.Damage(randomNoGenerator.Next(0,80));
            }
        }
    }
}

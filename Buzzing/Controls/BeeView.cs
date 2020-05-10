using Buzzing.Bees;
using Buzzing.Interfaces;
using System.Windows.Forms;

namespace Buzzing.Controls
{
    public partial class BeeView : UserControl
    {
        // Ideally we would use MVVM etc and the ViewModel would handle updating the view
        // but due to the time this would take i have done it this way for now just to get something working.
        public IBee Bee;

        public BeeView()
        {
            InitializeComponent();
        }

        private void UpdateStatus()
        {
            var status = Bee.IsDead ? "Dead" : "Alive";
            lblStatus.Text = "Status: " + status;
        }

        private void UpdateHealth()
        {
            lblHealth.Text = "Health: " + Bee.Health.ToString();
        }

        public void Update()
        {
            if (Bee != null)
            {
                UpdateStatus();
                UpdateHealth();
                Refresh();
            }
        }
    }
}

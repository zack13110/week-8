using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace twozerofoureight
{
    public partial class TwoZeroFourEightScoreView : Form, View
    {
        public TwoZeroFourEightScoreView()
        {
            InitializeComponent();   
        }
    public void Notify(Model m)
        {
            Updatescore(((TwoZeroFourEightModel)m).GetScore());
        }

        private void Updatescore(int getscore)
        {
            string s;
            s = getscore.ToString();
            lblScore.Text = s;
        }
    }
}

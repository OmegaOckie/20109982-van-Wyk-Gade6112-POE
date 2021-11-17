using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20109982_van_Wyk_POE
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
            GameEngine myGameEngine = new GameEngine(5,15, 5, 15, 10);

            myGameEngine.mapTextBox = mapRichTextBox;
            myGameEngine.Redrawmap();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}

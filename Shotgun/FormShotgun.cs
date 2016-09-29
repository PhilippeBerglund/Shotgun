using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shotgun
{
    public partial class FormShotgun : Form
    {
        public FormShotgun()
        {
            InitializeComponent();
        }


        Player NewPlayer = new Player(0);

        Cpu NewCpu = new Cpu(0);


     public void btnLoad_Click(object sender, EventArgs e)
        {
            if (NewPlayer.Ammo < 3 ) 
            {
                int shots = int.Parse(lblPlayShots.Text);
                shots++;
                lblPlayShots.Text = shots.ToString();

                NewPlayer.Ammo++;
            }

            if (NewPlayer.Ammo == 3)
            {
                btnShotgun.Visible = true;
                btnLoad.Visible = false;
            } 

            CpuActions cpuActions = new CpuActions();

            var cpu =  cpuActions.CpuRandom(NewCpu);

            lblCpuShots.Text = cpu.Ammo.ToString();

        }

        private void FormShotgun_Load(object sender, EventArgs e)
        {
          
          
        }

       
    }
}

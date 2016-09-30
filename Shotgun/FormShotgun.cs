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
            if (NewPlayer.Ammo < 3)
            {
                int shots = int.Parse(lblPlayShots.Text);
                shots++;
                lblPlayShots.Text = shots.ToString();

                lblPlAction.Text = "Shotgun Loaded"; //nytt

                NewPlayer.Ammo++;

                btnShoot.Visible = true; // nytt!!!!!!!!!!!!!!!!!!!!
            }

            if (NewPlayer.Ammo == 3)
            {
                btnShotgun.Visible = true;
                btnLoad.Visible = false;
            }

            if (NewCpu.Ammo < 3) //nytt!!!!!!!!!!!!!!!! add label text
            {

                CpuActions cpuActions = new CpuActions();

                var cpu = cpuActions.CpuRandom(NewCpu);

                lblCpuShots.Text = cpu.Ammo.ToString();


            }

        }


        private void btnShoot_Click(object sender, EventArgs e) // nytt!!!!!!!!!!!!!
        {
            if (NewPlayer.Ammo < 3)
            {
                int shots = int.Parse(lblPlayShots.Text);
                shots--;
                lblPlayShots.Text = shots.ToString();

                lblPlAction.Text = "Shot Fired"; //nytt

                NewPlayer.Ammo--;
            }

            if (NewPlayer.Ammo >= 1)
            {
                // btnShotgun.Visible = true;
                //btnLoad.Visible = false;
                btnShoot.Visible = true;
            }
            else btnShoot.Visible = false;



            //if (NewPlayer.Ammo <= 1)
            //{

            //    btnShoot.Visible = true;
            //}

        }

      
        private void btnBlock_Click(object sender, EventArgs e)
        {
            lblPlAction.Text = "Blocked"; //nytt
        }


        private void FormShotgun_Load
          (object sender, EventArgs e) // Laddar Forms Bakgrund
        {


        }


    }

}


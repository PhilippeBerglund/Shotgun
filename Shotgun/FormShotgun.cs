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


        public Player NewPlayer = new Player();

        public Cpu NewCpu = new Cpu();

       
        public void btnLoad_Click(object sender, EventArgs e)
        {
            NewPlayer.Ammo++;
            lblPlAction.Text = "Loaded";

            if (NewPlayer.Ammo <= 3)
            {
               lblPlayShots.Text = Convert.ToString(NewPlayer.Ammo);

                //int shots = int.Parse(lblPlayShots.Text);  ---- bort??
                //shots++;
                //lblPlayShots.Text = shots.ToString();

                //lblPlAction.Text = "Shotgun Loaded"; //nytt

                btnShoot.Visible = true; // nytt!!!!!!!!!!!!!!!!!!!!
            }

            if (NewPlayer.Ammo == 3)
            {
                btnShotgun.Visible = true;
                btnLoad.Visible = false;
            }

            //-------------cpu------------------------------------------

            var cpuActions = new CpuActions();
            cpuActions.CpuRandom(NewCpu);

            if (NewCpu.Load)
            {
               // NewCpu.Load = true;
               // NewCpu.Ammo++;
                lblCpuAction.Text = "I load for Life";
            }

            if (NewCpu.Shoot)
            {
               // NewCpu.Ammo--;
                lblCpuAction.Text = "Shots Fired";
                NewCpu.Win = true;
            }

            if (NewCpu.Block)
            {
                lblCpuAction.Text = "I move too Fast";
            }

            if (NewCpu.Shotgun)
            {
                NewCpu.Win = true;
                lblCpuAction.Text = "Shotgun, Good Night";

            }

            if (NewCpu.Win)
            {
                MessageBox.Show("You lost!");
            }

            if (NewCpu.Ammo < 3)
            {
                lblCpuShots.Text = Convert.ToString(NewCpu.Ammo);

                //int cpuShots = int.Parse(lblCpuShots.Text);
                //cpuShots++;
                //lblCpuShots.Text = cpuShots.ToString();

            }
        }


        public void btnShoot_Click(object sender, EventArgs e)
        {
            NewPlayer.Ammo--;
            lblPlAction.Text = "Shots Fired";

            if (NewPlayer.Ammo <= 3)
            {
                lblPlayShots.Text = Convert.ToString(NewPlayer.Ammo);

                //int shots = int.Parse(lblPlayShots.Text);  ---- bort??
                //shots++;
                //lblPlayShots.Text = shots.ToString();

                //lblPlAction.Text = "Shotgun Loaded"; //nytt

                btnShoot.Visible = true; // nytt!!!!!!!!!!!!!!!!!!!!
            }

            //if (NewPlayer.Ammo < 3)
            //{
            //    int shots = int.Parse(lblPlayShots.Text);
            //    shots--;
            //    lblPlayShots.Text = shots.ToString();

            //    lblPlAction.Text = "Shot Fired";

            //    NewPlayer.Ammo--;
            //}

            if (NewPlayer.Ammo >= 1)
            {
                // btnShotgun.Visible = true;
                //btnLoad.Visible = false;
                btnShoot.Visible = true;
            }
            else btnShoot.Visible = false;


            //--------------------cpu------------------------------

            var cpuActions = new CpuActions();
            cpuActions.CpuRandom(NewCpu);

            if (NewCpu.Ammo < 3)
            {
               // CpuActions cpuActions = new CpuActions();

               // var cpu = cpuActions.CpuRandom(NewCpu);

               // int cpuShots = int.Parse(lblCpuShots.Text);
               //// cpuShots--;
               // lblCpuShots.Text = cpuShots.ToString();

                if (NewCpu.Shoot)
                {
                    //cpu.Ammo--;
                    lblCpuAction.Text = "Shots Fired";
                }


                if (NewCpu.Load)
                {
                    lblCpuAction.Text = "I load for Life";
                    NewPlayer.Win = true;
                    MessageBox.Show("Player Win");
                }

          
                
            }
        }



        // todo gömma blocken när det inte finns skott 
        private void btnBlock_Click(object sender, EventArgs e)
        {
            if (NewPlayer.Ammo < 3)
            {
                lblPlAction.Text = "Blocked"; //nytt
            }

            if (NewPlayer.Ammo < 0)
            {
                //   btnShotgun.Visible = true;
                btnBlock.Visible = false;
            }

            else btnBlock.Visible = true;



            if (NewCpu.Ammo < 3)
            {
                CpuActions cpuActions = new CpuActions();

                var cpu = cpuActions.CpuRandom(NewCpu);

                //int cpuShots = int.Parse(lblCpuShots.Text);
                
                //lblCpuShots.Text = cpuShots.ToString();

                if (NewCpu.Block)
                {
                   
                    lblCpuAction.Text = "I move too Fast";
                }


            }
        }









        private void FormShotgun_Load
            (object sender, EventArgs e) // Laddar Forms Bakgrund
        {


        }


    }

}


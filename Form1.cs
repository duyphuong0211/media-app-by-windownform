using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Media
{
    public partial class Form1 : Form
    {
        Music[] musics;
        Person[] people;

        public Form1()
        {
            InitializeComponent();
            customizeDesing();

            InitMusic();
        }
        

        void InitMusic()
        {
            // Person a = new Person(); vi du ve truu tuong - khong the tao 1 thuc the qua truu tuong
            //Singer singer = new Singer();   - vi du ve phuong thuc nhap 
            //singer.Name = "aa";

            //MessageBox.Show(singer.Name);

            people = new Person[10];
            people[0] = new Singer("Lap Nguyen", new DateTime(123), true, 1000);
            people[1] = new Author();
            people[2] = new Singer("Min", new DateTime(456), true, 1000);
            people[3] = new Author();
            people[4] = new Singer("Lil Nas X_ Billy", new DateTime(789), true, 1000);
            people[5] = new Author();


            musics = new Music[10];
            musics[0] = new Music((Singer)people[0], (Author)people[1], 123, "Em Bang Qua", "./Em Bang Qua - Lap Nguyen.wav");
            musics[1] = new Music((Singer)people[2], (Author)people[3], 123, "Tren Tinh Ban Duoi Tinh Yeu", "./Tren Tinh Ban Duoi Tinh Yeu - Min.wav");
            musics[2] = new Music((Singer)people[0], (Author)people[3], 123, "Old Town Road", "./Old Town Road Remix_ - Lil Nas X_ Billy.wav");

            //media = new Media(musics[0].getLink()); media.play();
        }
        private void customizeDesing()
        {
            panelFindSubmenu.Visible = false;
            panelMediaSubmenu.Visible = false;
            panelToolSubmenu.Visible = false;
            //....
        }
        private void hideSubMenu() // Ẩn Submenu
        {
            if (panelMediaSubmenu.Visible == true)
                panelMediaSubmenu.Visible = false;
            if (panelFindSubmenu.Visible == true)
                panelFindSubmenu.Visible = false;
            if (panelToolSubmenu.Visible == true)
                panelToolSubmenu.Visible = false;
        }

        private void showSubMneu(Panel subMenu) // Hiện subMenu
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void BtnMedia_Click(object sender, EventArgs e)
        {
            showSubMneu(panelMediaSubmenu);
        }
        #region MediaSubmenu
        private void BtnSong1_Click(object sender, EventArgs e)
        {
            openChildForm(new Form2(musics[0]));
           
            hideSubMenu();
        }

        private void BtnSong2_Click(object sender, EventArgs e)
        {
            openChildForm(new Form2(musics[1]));
            ////
            hideSubMenu();
        }

        private void BtnSong3_Click(object sender, EventArgs e)
        {
            openChildForm(new Form2(musics[2]));
            hideSubMenu();
        }///
        #endregion
        private void BtnFind_Click(object sender, EventArgs e)
        {
            showSubMneu(panelFindSubmenu);
        }
        #region FindSubmenu
        private void BtnFindS_Click(object sender, EventArgs e)
        {
            // code
            hideSubMenu();
        }

        private void BtnFindA_Click(object sender, EventArgs e)
        {
            // code
            hideSubMenu();
        }
        #endregion
        private void BtnTool_Click(object sender, EventArgs e)
        {
            showSubMneu(panelToolSubmenu);
        }
        #region ToolSubmenu
        private void BtnSpeaker_Click(object sender, EventArgs e)
        {
            // code
            hideSubMenu();
        }

        private void BtnLight_Click(object sender, EventArgs e)
        {
            // code
            hideSubMenu();
        }
        #endregion
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelPlayer.Controls.Add(childForm);
            panelPlayer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            MessageBox.Show(trackBar1.Value.ToString());
        }
    }
}

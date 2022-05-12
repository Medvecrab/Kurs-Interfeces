using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Kurs_Interfeces
{
    public partial class mainWindow : Form
    {
        User logged_user = new User("a", "a", "a", -1);
        public List<User> users = new List<User>();
        public List<Trafic_Light> trafic_lights = new List<Trafic_Light>();
        public List<PictureBox> trafic_lights_pictures = new List<PictureBox>();
        private int last_width;
        private int last_height;
        private int current_trafic_light = -1;
        public mainWindow()
        {
            InitializeComponent();

            last_width = this.Width;
            last_height = this.Height;

            //костыль
            /*User admin = new User("Администратор", "admin", "qwerty1", 2);
            StreamWriter sw = new StreamWriter("users.txt");
            admin.saveToFile(sw);
            sw.Close();*/


            StreamReader sr = new StreamReader("users.txt");
            while(sr.Peek() >= 0)
            {
                string fio, login, salt;
                int access_level;
                Int32 hash_pass;
                fio = sr.ReadLine();
                login = sr.ReadLine();
                salt = sr.ReadLine();
                hash_pass = Convert.ToInt32(sr.ReadLine());
                access_level = Convert.ToInt32(sr.ReadLine());
                users.Add(new User(fio, login, salt, hash_pass, access_level));
            }
            sr.Close();
            sr = new StreamReader("trafic_lights.txt");
            while (sr.Peek() >= 0)
            {
                int x = Convert.ToInt32(sr.ReadLine());
                int y = Convert.ToInt32(sr.ReadLine());
                int state = Convert.ToInt32(sr.ReadLine()); ;
                int red_timer = Convert.ToInt32(sr.ReadLine()); ;
                int yellow_timer = Convert.ToInt32(sr.ReadLine()); ;
                int green_timer = Convert.ToInt32(sr.ReadLine()); ;
                string comment = sr.ReadLine(); //комментарии про светофор
                trafic_lights.Add(new Trafic_Light(x, y, red_timer, yellow_timer, green_timer, state, comment));
                PictureBox new_trafic_light_picture = new PictureBox();
                new_trafic_light_picture.Height = 40;
                new_trafic_light_picture.Width = 26;
                new_trafic_light_picture.Location = new Point(x - new_trafic_light_picture.Width / 2, y - new_trafic_light_picture.Height / 2);
                new_trafic_light_picture.Parent = MapBox;
                new_trafic_light_picture.SizeMode = PictureBoxSizeMode.Zoom;
                switch (state)
                {
                    case 0:
                        new_trafic_light_picture.Image = Image.FromFile("red.png");
                        break;                    
                    case 1:
                        new_trafic_light_picture.Image = Image.FromFile("yellow.png");
                        break;                    
                    case 2:
                        new_trafic_light_picture.Image = Image.FromFile("green.png");
                        break;                    
                    case 3:
                        new_trafic_light_picture.Image = Image.FromFile("yellow.png");
                        break;
                    case 4:
                        new_trafic_light_picture.Image = Image.FromFile("blank.png");
                        break;
                    case 5:
                        new_trafic_light_picture.Image = Image.FromFile("yellow.png");
                        break;
                    case 6:
                        new_trafic_light_picture.Image = Image.FromFile("blank.png");
                        break;
                }
                new_trafic_light_picture.BackColor = Color.Transparent;
                new_trafic_light_picture.BringToFront();
                new_trafic_light_picture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.traficLight_Click);
                new_trafic_light_picture.ContextMenuStrip = contextMenuStripTraficLight;
                trafic_lights_pictures.Add(new_trafic_light_picture);
            }
            sr.Close();
            timerTraficLights.Start();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            bool user_found = false;
            if (users.Count > 0)
            {
                foreach (User usr in users)
                {
                    if (usr.Validate(textBoxLogin.Text, usr.get_hash(textBoxPassword.Text)))
                    {
                        usr.active = true;
                        user_found = true;
                        logged_user = usr;
                    }
                }
                if (user_found)
                {
                    if (logged_user.access_level == 2)
                    {
                        buttonAddUser.Visible = true;
                        buttonSaveUsers.Visible = true;
                        labelChangeDelete.Visible = true;
                        buttonTimer.Visible = true;
                        contextMenuStripTraficLight.Enabled = true;
                        foreach (ToolStripMenuItem item in contextMenuStripTraficLight.Items)
                        {
                            item.Enabled = true;
                        }
                    }
                    else
                    {
                        buttonAddUser.Visible = false;
                        buttonSaveUsers.Visible = false;
                        labelChangeDelete.Visible = false;
                        buttonTimer.Visible = false;
                        contextMenuStripTraficLight.Enabled = false;
                        foreach (ToolStripMenuItem item in contextMenuStripTraficLight.Items)
                        {
                            item.Enabled = false;
                        }
                    }
                    if (logged_user.access_level >= 1)
                    {
                        labelAddTraficLights.Visible = true;
                        buttonSaveTraficLights.Visible = true;
                        contextMenuStripMap.Enabled = true;
                        foreach (ToolStripMenuItem item in contextMenuStripMap.Items)
                        {
                            item.Enabled = true;
                        }
                    }
                    else
                    {
                        labelAddTraficLights.Visible = false;
                        buttonSaveTraficLights.Visible = false;
                        contextMenuStripMap.Enabled = false;
                        foreach (ToolStripMenuItem item in contextMenuStripMap.Items)
                        {
                            item.Enabled = false;
                        }
                    }
                    //ниже для всех

                    //TODO: в зависимости от уровня привелегий пользователя включать/выключать функционал
                    panelLogin.Visible = false;
                    buttonChangeUser.Visible = true;
                }
                else
                    MessageBox.Show("Ошибка: неправильный логин или пароль", "Ошибка логина", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Ошибка: нет пользователей", "Ошибка пользователей", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }

        private void buttonChangeUser_Click(object sender, EventArgs e)
        {
            panelLogin.Visible = true;
            buttonChangeUser.Visible = false;
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser(this);
            addUser.Show();
        }

        private void toolStripMenuItemAdd_Click (object sender, EventArgs e)
        {
            //-12, -7 - костыли
            AddTraficLight addTraficLights = new AddTraficLight(this, MapBox.PointToClient(Cursor.Position).X - 12, MapBox.PointToClient(Cursor.Position).Y - 7, -1);
            addTraficLights.Show();
        }

        private void toolStripMenuItemChange_Click(object sender, EventArgs e)
        {
            AddTraficLight addTraficLights = new AddTraficLight(this, 0, 0, current_trafic_light);
            addTraficLights.Show();
        }

        private void toolStripMenuItemDelete_Click(object sender, EventArgs e)
        {
            trafic_lights.RemoveAt(current_trafic_light);
            trafic_lights_pictures[current_trafic_light].Dispose();
            trafic_lights_pictures.RemoveAt(current_trafic_light);
            current_trafic_light = -1;
            MapBox.Refresh();
        }

        public void traficLight_Click(object sender, EventArgs e)
        {
            if (current_trafic_light != -1)
                trafic_lights_pictures[current_trafic_light].BorderStyle = BorderStyle.None;
            for (int i = 0; i < trafic_lights_pictures.Count; i++) 
            {
                if (trafic_lights_pictures[i] == (sender as PictureBox))
                {
                    current_trafic_light = i;
                    break;
                }
            }
            if (current_trafic_light != -1)
                trafic_lights_pictures[current_trafic_light].BorderStyle = BorderStyle.FixedSingle;
        }

        private void mainWindow_ResizeBegin(object sender, EventArgs e)
        {
            last_width = this.Width;
            last_height = this.Height;
        }

        private void mainWindow_ResizeEnd(object sender, EventArgs e)
        {
            panelMap.Width = panelMap.Width + (this.Width - last_width);
            panelMap.Height = panelMap.Height + (this.Height - last_height);
        }

        FormWindowState LastWindowState = FormWindowState.Minimized;

        private void mainWindow_Resize(object sender, EventArgs e)
        {
            if (WindowState != LastWindowState)
            {
                LastWindowState = WindowState;
                if (WindowState == FormWindowState.Maximized)
                {
                    panelMap.Width = panelMap.Width + (this.Width - last_width);
                    panelMap.Height = panelMap.Height + (this.Height - last_height);
                    last_width = this.Width;
                    last_height = this.Height;
                }
                if (WindowState == FormWindowState.Normal)
                {
                    panelMap.Width = panelMap.Width + (this.Width - last_width);
                    panelMap.Height = panelMap.Height + (this.Height - last_height);
                    last_width = this.Width;
                    last_height = this.Height;
                }
            }
        }

        private void buttonSaveUsers_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("users.txt");
            foreach (User usr in users)
            {
                usr.saveToFile(sw);
            }
            sw.Close();
        }

        private void buttonSaveTraficLights_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("trafic_lights.txt");
            foreach (Trafic_Light trafic_light in trafic_lights)
            {
                trafic_light.saveToFile(sw);
            }
            sw.Close();
        }

        private void timerTraficLights_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < trafic_lights.Count; i++)
            {
                trafic_lights[i].seconds_left--;
                if (trafic_lights[i].seconds_left == 0) //меняем состояние светофору
                {
                    switch(trafic_lights[i].state)
                    {
                        case 0:
                            trafic_lights[i].state = 1;
                            trafic_lights[i].seconds_left = trafic_lights[i].yellow_timer;
                            trafic_lights_pictures[i].Image = Image.FromFile("yellowred.png");
                            break;       
                        case 1:
                            trafic_lights[i].state = 2;
                            trafic_lights[i].seconds_left = trafic_lights[i].green_timer;
                            trafic_lights_pictures[i].Image = Image.FromFile("green.png");
                            break;
                        case 2:
                            trafic_lights[i].state = 5;
                            trafic_lights[i].seconds_left = trafic_lights[i].yellow_timer;
                            trafic_lights_pictures[i].Image = Image.FromFile("yellow.png");
                            break; 
                        case 3:
                            trafic_lights[i].state = 6;
                            trafic_lights[i].seconds_left = trafic_lights[i].yellow_timer;
                            trafic_lights_pictures[i].Image = Image.FromFile("blank.png");
                            break; 
                        case 4:
                            break;
                        case 5:
                            trafic_lights[i].state = 0;
                            trafic_lights[i].seconds_left = trafic_lights[i].red_timer;
                            trafic_lights_pictures[i].Image = Image.FromFile("red.png");
                            break;
                        case 6:
                            trafic_lights[i].state = 3;
                            trafic_lights[i].seconds_left = trafic_lights[i].yellow_timer;
                            trafic_lights_pictures[i].Image = Image.FromFile("yellow.png");
                            break;
                    }
                }
            }
        }

        private void buttonTimer_Click(object sender, EventArgs e)
        {
            if (timerTraficLights.Enabled)
            {
                buttonTimer.Text = "Включить таймер";
                timerTraficLights.Stop();
            }
            else
            {
                buttonTimer.Text = "Выключить таймер";
                timerTraficLights.Start();
            }
        }
    }
}

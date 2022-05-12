using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kurs_Interfeces
{
    public partial class AddTraficLight : Form
    {
        private mainWindow main_window;
        private int index;
        public AddTraficLight(mainWindow inp_main_window, int inp_x, int inp_y, int inp_index)
        {
            InitializeComponent();
            comboBoxState.SelectedIndex = 0;
            main_window = inp_main_window;
            numericUpDownX.Maximum = main_window.MapBox.Width;
            numericUpDownX.Value = inp_x;
            numericUpDownY.Maximum = main_window.MapBox.Width;
            numericUpDownY.Value = inp_y;
            index = inp_index;
            if (inp_index != -1)
            {
				this.Text = "Изменить светофор";
				buttonConfirm.Text = "Изменить светофор";
                Trafic_Light current = main_window.trafic_lights[index];
                numericUpDownX.Value = current.x;
                numericUpDownY.Value = current.y;
                numericUpDownRed.Value = current.red_timer;
                numericUpDownYellow.Value = current.yellow_timer;
                numericUpDownGreen.Value = current.green_timer;
                textBoxComment.Text = current.comment;
                if (current.state < 4)
                    comboBoxState.SelectedIndex = current.state;
                else
                {
                    if (current.state == 5) //костыли
                    {
                        comboBoxState.SelectedIndex = 1;
                    }
                    else
                    {
                        comboBoxState.SelectedIndex = 3;
                    }
                }
            }
			else
			{
				this.Text = "Добавить светофор";
				buttonConfirm.Text = "Добавить светофор";
			}
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            Trafic_Light trafic_Light = new Trafic_Light(Convert.ToInt32(numericUpDownX.Value), Convert.ToInt32(numericUpDownY.Value),
                Convert.ToInt32(numericUpDownRed.Value), Convert.ToInt32(numericUpDownYellow.Value), Convert.ToInt32(numericUpDownGreen.Value),
                comboBoxState.SelectedIndex, textBoxComment.Text);
            if (index == -1)
                main_window.trafic_lights.Add(trafic_Light);
            else
                main_window.trafic_lights[index] = trafic_Light;
            //Добавить добавление картинки светофора.
            PictureBox new_trafic_light_picture = new PictureBox();
            new_trafic_light_picture.Height = 40;
            new_trafic_light_picture.Width = 26;
            new_trafic_light_picture.Location = new Point(Convert.ToInt32(numericUpDownX.Value) - new_trafic_light_picture.Width/2,
                Convert.ToInt32(numericUpDownY.Value) - new_trafic_light_picture.Height/2);
            new_trafic_light_picture.Parent = main_window.MapBox;
            new_trafic_light_picture.SizeMode = PictureBoxSizeMode.Zoom;
            switch (comboBoxState.SelectedIndex)
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
            new_trafic_light_picture.MouseDown += new System.Windows.Forms.MouseEventHandler(main_window.traficLight_Click);
            new_trafic_light_picture.ContextMenuStrip = main_window.contextMenuStripTraficLight;
            if (index == -1)
                main_window.trafic_lights_pictures.Add(new_trafic_light_picture);
            else
                main_window.trafic_lights_pictures[index] = new_trafic_light_picture;
            this.Close();
            main_window.Show();
        }

        private void AddTraficLight_FormClosed(object sender, FormClosedEventArgs e)
        {
            main_window.Show();
        }
    }
}

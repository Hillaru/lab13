using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_13
{
    public partial class AddVechile : Form
    {
        private int type = 1;
        private List<double> horses_stamina = new List<double> { };
        private int Mass;
        private int Speed;
        private double Fuel;

        public AddVechile(int _type = 1)
        {
            InitializeComponent();            

            type = _type;
            RefreshTB();

            if (type == 1)
            {
                lblStamina.Hide();
                tbStamina.Hide();
                butAddHorse.Hide();
            }
            else
            {
                lblFuel.Hide();
                tbFuel.Hide();
                lblTitle.Text = "Повозка";
                Text = "Добавление повозки";
            }
        }

        public void RefreshTB()
        {
            richTextBox1.Clear();

            if (type == 1)
            {
                richTextBox1.Text = $"масса:{Mass} \nскорость:{Speed} \nпотребление топлива:{Fuel}";
            }
            else
            {
                richTextBox1.Text = $"масса:{Mass} \nскорость:{Speed} \nпотребление выносливости лошадьми:\n";
                foreach (double st in horses_stamina)
                    richTextBox1.Text += $"{st} ";
            }
        }

        private void butAddHorse_Click(object sender, EventArgs e)
        {
            double stamina = 0;
            try
            {
                stamina = Convert.ToDouble(tbStamina.Text);
            }
            catch
            {
                MessageBox.Show("Некорректный ввод");
                return;
            }

            horses_stamina.Add(stamina);
            RefreshTB();
        }

        private void tbMass_TextChanged(object sender, EventArgs e)
        {
            int newMass = 0;
            try
            {
                newMass = Convert.ToInt32(tbMass.Text);
            }
            catch
            {
                tbMass.Text = Convert.ToString(Mass);
                return;
            }

            Mass = newMass;
            RefreshTB();
        }

        private void tbSpeed_TextChanged(object sender, EventArgs e)
        {
            int newSpeed = 0;
            try
            {
                newSpeed = Convert.ToInt32(tbSpeed.Text);
            }
            catch
            {
                tbSpeed.Text = Convert.ToString(Speed);
                return;
            }

            Speed = newSpeed;
            RefreshTB();
        }

        private void tbFuel_TextChanged(object sender, EventArgs e)
        {
            double newFuel = 0;
            try
            {
                newFuel = Convert.ToDouble(tbFuel.Text);
            }
            catch
            {
                return;
            }

            Fuel = newFuel;
            RefreshTB();
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            DataTransfer.Vechile = null;
            Close();
        }

        private void butOK_Click(object sender, EventArgs e)
        {
            if (type == 1)
                DataTransfer.Vechile = new car(Mass, Fuel, Speed);
            else
            {
                if (horses_stamina.Count == 0)
                {
                    MessageBox.Show("В позке должна быть хотя бы одна лошадь","ОШИБКА");
                    return;
                }
                DataTransfer.Vechile = new carriage(horses_stamina, Mass, Speed);
            }

            Close();
        }
    }
}

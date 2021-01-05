using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Serializer;

namespace lab_13
{
    public partial class MainForm : Form
    {
        public race r = new race();

        public MainForm()
        {
            InitializeComponent();
        }

        public void RefreshLB()
        {
            listBox1.Items.Clear();

            if (r.vechile_list.Count == 0)
            {
                listBox1.Items.Add("Список пуст");
                return;
            }

            foreach (vechile vech in r.vechile_list)
            {
                if (vech.GetType() == typeof(car))
                {
                    listBox1.Items.Add($"Машина, скорость:{vech.speed} | масса:{vech.mass} | потребление топлива:{vech.consumption}");
                }
                else
                {
                    string stamina_string = "";
                    carriage cr = (carriage)vech;
                    foreach (double stamina in cr.horses_stamina_list)
                        stamina_string += Convert.ToString(stamina) + " ";
                 
                    listBox1.Items.Add($"Повозка, скорость:{vech.speed} | масса:{vech.mass} | потребление выносливости лошадьми:{stamina_string}");                        
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshLB();
        }

        private void butCar_Click(object sender, EventArgs e)
        {
            Form f = new AddVechile(1);
            f.ShowDialog();

            if (DataTransfer.Vechile != null)
                r.add_vechile(DataTransfer.Vechile);

            RefreshLB();
        }

        private void butCarriage_Click(object sender, EventArgs e)
        {
            Form f = new AddVechile(2);
            f.ShowDialog();

            if (DataTransfer.Vechile != null)
                r.add_vechile(DataTransfer.Vechile);

            RefreshLB();
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            int ind = listBox1.SelectedIndex;

            if (r.vechile_list.Count == 0)
                return;

            if (ind == -1)
            {
                MessageBox.Show("Выберите участника для удаления");
                return;
            }

            r.remove_vechile(ind);
            RefreshLB();
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            if (r.vechile_list == null || r.vechile_list.Count == 0)
            {
                MessageBox.Show("Список пуст","ОШИБКА");
                return;
            }

            GenericXmlSerializer.WriteObject(r, "file.xml");
            MessageBox.Show("Сохранено в файл file.xml", "УСПЕХ");
        }

        private void butLoad_Click(object sender, EventArgs e)
        {
            race _r = GenericXmlSerializer.ReadObject<race>("file.xml");

            if (_r != null)
            {
                r = _r;
                MessageBox.Show("Список загружен из файла file.xml","УСПЕХ");
                RefreshLB();
            }
            else
            {
                MessageBox.Show("Не удалось загрузит список из файла.\nВозможно файл пуст","ОШИБКА");
            }
        }

        private void butStart_Click(object sender, EventArgs e)
        {
            List<vechile> vec = new List<vechile> { };
            List<double> distances = new List<double> { };
            double dist;

            if (r == null || r.vechile_list == null || r.vechile_list.Count == 0)
            {
                MessageBox.Show("Невозможно начать гонку, список участников пуст","ОШИБКА");
                return;
            }

            try
            {
                dist = Convert.ToDouble(tbDist.Text);
            }
            catch
            {
                MessageBox.Show("Некорректный ввод расстояния гонки", "ОШИБКА");
                return;
            }

            r.start(dist, ref vec, ref distances);

            Form f = new RaceResult(vec, distances);
            f.ShowDialog();
        }
    }
}

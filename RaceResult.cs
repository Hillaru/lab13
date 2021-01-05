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
    public partial class RaceResult : Form
    {
        public RaceResult(List<vechile> vechile_list, List<double> dist)
        {
            InitializeComponent();

            for (int i = 0; i < vechile_list.Count; i++)
            {
                vechile vech = vechile_list[i];

                if (vech.GetType() == typeof(car))
                {
                    listBox1.Items.Add($"{i + 1} место, Машина, скорость:{vech.speed} | масса:{vech.mass} | потребление топлива:{vech.consumption}");
                    listBox1.Items.Add($"Пройденное расстояние: {dist[i]}");
                }
                else
                {
                    string stamina_string = "";
                    carriage cr = (carriage)vech;
                    foreach (double stamina in cr.horses_stamina_list)
                        stamina_string += Convert.ToString(stamina) + " ";

                    listBox1.Items.Add($"{i + 1} место, Повозка, скорость:{vech.speed} | масса:{vech.mass} | потребление выносливости лошадьми:{stamina_string}");
                    listBox1.Items.Add($"Пройденное расстояние: {dist[i]}");
                }
            }
        }
    }
}

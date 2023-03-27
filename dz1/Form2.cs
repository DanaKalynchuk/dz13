using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dz1
{
    public partial class Form2 : Form
    {

        public Form2(decimal Width, decimal Height, Point[] pn)
        {
            InitializeComponent();
            numericUpDown1.Maximum= Width;
            numericUpDown2.Maximum = Height;
            if (pn!=null)
            {
                foreach (var item in pn)
                {
                    Point point = (Point)item;
                    listBox1.Items.Add(point);
                }
            }
        }

        private void ok_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(new Point((int)numericUpDown1.Value, (int)numericUpDown2.Value));
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("You must select an item to remove it!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("You must select an item to remove it!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Point point1 = (Point)listBox1.Items[listBox1.SelectedIndex];
            numericUpDown1.Value = point1.X;
            numericUpDown2.Value = point1.Y;
            
        }

        private void EndEdit_Click(object sender, EventArgs e)
        {
            int removedIndex = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(removedIndex);
            listBox1.Items.Insert(removedIndex, new Point((int)numericUpDown1.Value, (int)numericUpDown2.Value));
        }
    }
}

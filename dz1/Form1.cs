using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dz1
{
   
   
public partial class Form1 : Form
    {
            public Point[] pn;
            public Color col = Color.Black;
            public Point point;
            public Point point1;
            public Pen pen;
            public int widthPen;
            public Brush br;
            public Rectangle rectangle;
            public int IndexStartCap = 0;
            public int IndexEndCap = 0;
            public int dashStyle = 0;
            public int IndexLinerGradient = 0;
            public int IndexHachstyle = 0;
            public string path = String.Empty;
            public TextureBrush texture;
            public Figures figures;
            //public int SelIndex =-1;
            public int IndexFigure=0;
            public int IndexBrush = 0;
            public int IndexText = 0;
        public Form1()
            {
                InitializeComponent();
                widthPen = Wigh.Value;
                pen = new Pen(col, widthPen);
                br = new SolidBrush(Color.Transparent);
                Line.Checked = true;
                Ellipse.Checked = false;
                X.Maximum = pictureBox1.Width;
                Y.Maximum = pictureBox1.Height;
                X1.Maximum = pictureBox1.Width;
                Y1.Maximum = pictureBox1.Height;
                Text1.Maximum= pictureBox1.Width;
                Text2.Maximum = pictureBox1.Height;
        }
        // малювання поля

            private void pictureBox1_Paint(object sender, PaintEventArgs e)
            {

                Graphics g = e.Graphics;
                pen.DashStyle = (DashStyle)dashStyle;
            if (Line.Checked)
            {
                pen.StartCap = (LineCap)IndexStartCap;
                pen.EndCap = (LineCap)IndexEndCap;
                g.DrawLine(pen, point, point1);
                IndexFigure = 1;
            }
            else
            {
                rectangle = new Rectangle(point.X, point.Y, point1.X - point.X, point1.Y - point.Y);
                if (Gradient.Checked)
                {
                    IndexBrush = 1;
                    br = new LinearGradientBrush(rectangle, FirstColor.BackColor, SecondColor.BackColor, (LinearGradientMode)IndexLinerGradient);
                }
                if (Hatch.Checked)
                {
                    br = new HatchBrush((HatchStyle)IndexHachstyle, FirstColor.BackColor, SecondColor.BackColor);
                    IndexBrush = 2;
                }
                if (Ellipse.Checked)
                {

                    if (textBox1.Text != String.Empty && Texture.Checked)
                    {
                        IndexBrush = 3;
                        g.FillEllipse(texture, rectangle);
                    }
                    else
                    {
                        g.DrawEllipse(pen, rectangle);
                        g.FillEllipse(br, rectangle);
                    }
                    IndexFigure = 2;

                }
                else if (Rectangle.Checked)
                {
                    if (textBox1.Text != String.Empty && Texture.Checked)
                    {
                        IndexBrush = 3;
                        g.FillRectangle(texture, rectangle);
                    }
                    else
                    {
                        g.DrawRectangle(pen, rectangle);
                        g.FillRectangle(br, rectangle);
                    }
                    IndexFigure = 3;
                }
                else if (Field.Checked)
                {
                    if (textBox1.Text != String.Empty && Texture.Checked)
                    {
                        IndexBrush = 3;
                        g.FillPolygon(texture, pn);
                    }
                    else
                    {
                        g.DrawPolygon(pen, pn);
                        g.FillPolygon(br, pn);
                    }
                    IndexFigure = 4;
                }
            }
                 
            if (Textpic.Checked == true)
            {
                g.DrawString(textfortext.Text, new Font("consolas", widthPen), new SolidBrush(TextButton.BackColor), new Point((int)Text1.Value, (int)Text2.Value));
                IndexText = 1;
            }

            }
        // вибір заднього фону
            private void Color1_Click(object sender, EventArgs e)
            {
                ColorDialog dialog = new ColorDialog();
                dialog.Color = pictureBox1.BackColor;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Color1.BackColor = dialog.Color;
                    pictureBox1.BackColor = dialog.Color;
                    this.Refresh();
                }

            }
        //вибір лінії для малювання
            private void Color2_Click(object sender, EventArgs e)
            {
                ColorDialog dialog = new ColorDialog();

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Color2.BackColor = dialog.Color;
                    col = dialog.Color;
                    pen = new Pen(col, widthPen);
                this.Refresh();
                }

            }
        //для вибору першої точки
            private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
            {
            
                point = new Point(e.X, e.Y);
                X.Value = e.X;
                Y.Value = e.Y;

             }

        //для вибору другої точки
            private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
            {
            
                point1 = new Point(e.X, e.Y);
                X1.Value = e.X;
                Y1.Value = e.Y;
            
            this.Refresh();
            }


        //ширина лінії
            private void Wigh_Scroll(object sender, EventArgs e)
            {
                widthPen = Wigh.Value;
                pen = new Pen(col, widthPen);
                this.Refresh();
        }
        //вибір початку лінії
            private void Start_SelectedIndexChanged(object sender, EventArgs e)
            {
                IndexStartCap = Start.SelectedIndex;
                if (IndexStartCap > 3) IndexStartCap += 12;
                this.Refresh();
            }
        // вибір кінці лінії 
            private void End_SelectedIndexChanged(object sender, EventArgs e)
            {
                IndexEndCap = End.SelectedIndex;
                if (IndexEndCap > 3) IndexEndCap += 12;
            this.Refresh();
        }
        //тип лінії
            private void DiferentLine_SelectedIndexChanged(object sender, EventArgs e)
            {
                dashStyle = DiferentLine.SelectedIndex;
                this.Refresh();
            }
        //суцільна заливка
            private void button1_Click(object sender, EventArgs e)
            {
                ColorDialog dialog = new ColorDialog();

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    FirstColor.BackColor = dialog.Color;
                    br = new SolidBrush(dialog.Color);
                    this.Refresh();
                }
            }
       
           //текстурна заливка
        private void Hatch_Click(object sender, EventArgs e)
        {
            FirstColor.Enabled = true;
            SecondColor.Enabled = true;
            comboBox1.Enabled = false;
            comboBox2.Enabled = true;
        }
        //другий колір для заливки
        private void button2_Click(object sender, EventArgs e)
            {
                ColorDialog dialog = new ColorDialog();

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    SecondColor.BackColor = dialog.Color;

                    this.Refresh();
                }
            }
        //кнопка суцільна заливка
        private void Solid_Click(object sender, EventArgs e)
        {
            FirstColor.Enabled = true;

            IndexBrush = 4;
            SecondColor.Enabled = false;
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
           
        }
        //градієнтна заливка
        private void Gradient_Click(object sender, EventArgs e)
        {
            FirstColor.Enabled = true;
            SecondColor.Enabled = true;
            comboBox1.Enabled = true;
            comboBox2.Enabled = false;

        }
        //для вибору типу градієнта
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
            {
                IndexLinerGradient = comboBox1.SelectedIndex;
           
                this.Refresh();
            }
        //текстурна заливка тип
            private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
            {
                IndexHachstyle = comboBox2.SelectedIndex;
             
                this.Refresh();
            }

            private void button3_Click(object sender, EventArgs e)
            {

                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                pictureBox1.DrawToBitmap(bmp, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));

                SaveFileDialog save = new SaveFileDialog();
                save.AddExtension = true;
                save.DefaultExt = "*.png";
                save.Filter = "PNG files (*.png)| *.png|JPEG(*.jpeg)|*.jpeg";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    bmp.Save(save.FileName);
                }
            }
        private void Texture_Click(object sender, EventArgs e)
        {
            Open.Enabled = true;
            FirstColor.Enabled = false;
            SecondColor.Enabled = false;
        }
        //для відкриття картинки для заливки
        private void Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter= "PNG files (*.png)| *.png|JPEG(*.jpeg)|*.jpeg";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                path = openFile.FileName;
                textBox1.Text= openFile.FileName;
            }
            texture = new TextureBrush(new Bitmap(path));
            this.Refresh();
        }
        //Х для першої точки
        private void X_ValueChanged(object sender, EventArgs e)
        {
            point = new Point((int)X.Value, (int)Y.Value);
            this.Refresh();
        }
        //У для першої точки
        private void Y_ValueChanged(object sender, EventArgs e)
        {
            point = new Point((int)X.Value, (int)Y.Value);
            this.Refresh();
        }
        //Х для другої точки
        private void X1_ValueChanged(object sender, EventArgs e)
        {
            point1 = new Point((int)X1.Value, (int)Y1.Value);
            this.Refresh();
        }
        //У для другої точки
        private void Y1_ValueChanged(object sender, EventArgs e)
        {
            point1 = new Point((int)X1.Value, (int)Y1.Value);
            this.Refresh();
        }
        //додаємо до ліста
        private void Add_Click(object sender, EventArgs e)
        {
            figures = new Figures();
            figures.WidthPenf=Wigh.Value;
            figures.IndexStartCap=IndexStartCap;
            figures.IndexEndCap=IndexEndCap;
            figures.dashStyle=dashStyle;
            figures.IndexLinerGradient=IndexLinerGradient;
            figures.IndexHachstyle=IndexHachstyle;
            figures.Colf= col;
            figures.FirstColor=FirstColor.BackColor;
            figures.SecondColor=SecondColor.BackColor;
            figures.Pathf=textBox1.Text;
            figures.Pointf=point;
            figures.Point1f= point1;
            figures.IndexFigure= IndexFigure;
            figures.Name = Nameimage.Text;
            figures.IndexBrush = IndexBrush;
            figures.IndexOrien = comboBox1.SelectedIndex;
            figures.Indextex = comboBox2.SelectedIndex;
            figures.IndexText = IndexText;
            figures.PointText = new Point((int)Text1.Value, (int)Text2.Value);
            figures.TextImage = textfortext.Text;
            figures.ColorText = TextButton.BackColor;
            figures.pn = pn;
            Images.Items.Add(figures);
        }
        //кнопка редагувати
        private void Edit_Click(object sender, EventArgs e)
        {
            if (Images.SelectedIndex == -1)
            {
                MessageBox.Show("You must select an item to edit it!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            

            figures = new Figures();
            figures = (Figures)Images.SelectedItem;

            Wigh.Value = figures.WidthPenf;
            widthPen = figures.WidthPenf;
            IndexStartCap = figures.IndexStartCap;
            IndexEndCap = figures.IndexEndCap;
            dashStyle = figures.dashStyle;
            col = figures.Colf;
            Color2.BackColor = figures.Colf;
            FirstColor.BackColor = figures.FirstColor;
            SecondColor.BackColor = figures.SecondColor;
            textBox1.Text = figures.Pathf;
            point = figures.Pointf;
            point1 = figures.Point1f;
            IndexFigure = figures.IndexFigure;
            Nameimage.Text=figures.Name;
            IndexBrush = figures.IndexBrush;
            pen = new Pen(col, widthPen);
            Textpic.Checked = false;
            IndexText = figures.IndexText;
           
            if (IndexFigure == 1)
            {
                Line.Checked = true;
            }
            else if (IndexFigure == 2)
            {
                Ellipse.Checked = true;
            }
            else if (IndexFigure == 3)
            {
                Rectangle.Checked = true;
               
            }
            else if(IndexFigure == 4)
            {
                Field.Checked = true;
                pn = figures.pn;
            }
            if (IndexBrush == 1)
            {

                IndexLinerGradient = figures.IndexLinerGradient;
                textBox1.Enabled = false;
                comboBox1.SelectedIndex = figures.IndexOrien;
                Gradient.Checked = true;

            }
            else if (IndexBrush == 2)
            {
               
                textBox1.Enabled = false;
                IndexHachstyle = figures.IndexHachstyle;
                comboBox2.SelectedIndex = figures.Indextex;
                Hatch.Checked = true;
            }
            else if(IndexBrush == 3)
            {
                textBox1.Enabled = true;
                FirstColor.BackColor = Color.Transparent;
                SecondColor.BackColor = Color.Transparent;
                Texture.Checked = true;

            }
            else if (IndexBrush == 4)
            {

                SecondColor.BackColor = Color.Transparent;
                br = new SolidBrush(FirstColor.BackColor);
                Solid.Checked = true;
            }
            else br = new SolidBrush(FirstColor.BackColor);
            if (IndexText == 1)
            {
                Textpic.Checked = true;
                Text1.Value = figures.PointText.X;
                Text2.Value = figures.PointText.Y;
                textfortext.Text = figures.TextImage;
                TextButton.BackColor= figures.ColorText;
            }

            this.Refresh();
        }
        //видалення всього
        private void Clear_Click(object sender, EventArgs e)
        {
            Images.Items.Clear();
        }
        //видалення
        private void Remove_Click(object sender, EventArgs e)
        {
            if (Images.SelectedIndex == -1)
            {
                MessageBox.Show("You must select an item to remove it!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Images.Items.RemoveAt(Images.SelectedIndex);
        }
        //закінчити редагувати і зберегти на попереднє місце
        private void EndEdit_Click(object sender, EventArgs e)
        {
            if (Images.SelectedIndex == -1)
            {
                MessageBox.Show("You must select an item to remove it!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Figures figures1 = new Figures();
            figures1.WidthPenf = Wigh.Value;
            figures1.IndexStartCap = IndexStartCap;
            figures1.IndexEndCap = IndexEndCap;
            figures1.dashStyle = dashStyle;
            figures1.IndexLinerGradient = IndexLinerGradient;
            figures1.IndexHachstyle = IndexHachstyle;
            figures1.Colf = col;
            figures1.FirstColor = FirstColor.BackColor;
            figures1.SecondColor = SecondColor.BackColor;
            figures1.Pathf = textBox1.Text;
            figures1.Pointf = point;
            figures1.Point1f = point1;
            figures1.IndexFigure = IndexFigure;
            figures1.Name = Nameimage.Text;
            figures1.IndexBrush = IndexBrush;
            figures1.IndexOrien = comboBox1.SelectedIndex;
            figures1.Indextex = comboBox2.SelectedIndex;
            figures1.IndexText = IndexText;
            figures1.PointText = new Point((int)Text1.Value, (int)Text2.Value);
            figures1.TextImage= textfortext.Text;
            figures1.pn = pn;
            figures1.ColorText = TextButton.BackColor;
            int removedIndex = Images.SelectedIndex;
            Images.Items.RemoveAt(removedIndex);
            Images.Items.Insert(removedIndex, figures1);
           
        }

        //для додавання тексту
        private void Textpic_CheckedChanged_1(object sender, EventArgs e)
        {
            if (Textpic.Checked == true)
            {
                Text1.Enabled = true;
                Text2.Enabled = true;
                textfortext.Enabled = true;
                TextButton.Enabled = true;
            }
            else
            {
                Text1.Enabled = false;
                Text2.Enabled = false;
                textfortext.Enabled = false;
                TextButton.Enabled = false;
            }
        }

        private void Field_Click(object sender, EventArgs e)
        {
            int i = 0;
            Form2 form2 = new Form2( pictureBox1.Width, pictureBox1.Height, pn);
           
            if (form2.ShowDialog() == DialogResult.OK)
            {
                pn = new Point[form2.listBox1.Items.Count];
                foreach (var item in form2.listBox1.Items)
                {
                    Point point = (Point)item;
                    pn[i]=point;
                    i++;
                }
            }
            this.Refresh();
        }

        private void TextButton_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                TextButton.BackColor = dialog.Color;

                this.Refresh();
            }
        }
    }
}

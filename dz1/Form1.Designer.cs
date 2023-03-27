
namespace dz1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Field = new System.Windows.Forms.RadioButton();
            this.Rectangle = new System.Windows.Forms.RadioButton();
            this.Line = new System.Windows.Forms.RadioButton();
            this.Ellipse = new System.Windows.Forms.RadioButton();
            this.Color1 = new System.Windows.Forms.Button();
            this.Color2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Wigh = new System.Windows.Forms.TrackBar();
            this.DiferentLine = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.ComboBox();
            this.End = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Texture = new System.Windows.Forms.RadioButton();
            this.Hatch = new System.Windows.Forms.RadioButton();
            this.Solid = new System.Windows.Forms.RadioButton();
            this.Gradient = new System.Windows.Forms.RadioButton();
            this.FirstColor = new System.Windows.Forms.Button();
            this.SecondColor = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Open = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.X = new System.Windows.Forms.NumericUpDown();
            this.Y = new System.Windows.Forms.NumericUpDown();
            this.X1 = new System.Windows.Forms.NumericUpDown();
            this.Y1 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Images = new System.Windows.Forms.ListBox();
            this.Add = new System.Windows.Forms.Button();
            this.Nameimage = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.EndEdit = new System.Windows.Forms.Button();
            this.textfortext = new System.Windows.Forms.TextBox();
            this.Text1 = new System.Windows.Forms.NumericUpDown();
            this.Text2 = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.Textpic = new System.Windows.Forms.CheckBox();
            this.TextButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Wigh)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Y1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Text1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Text2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(348, 406);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Field);
            this.groupBox1.Controls.Add(this.Rectangle);
            this.groupBox1.Controls.Add(this.Line);
            this.groupBox1.Controls.Add(this.Ellipse);
            this.groupBox1.Location = new System.Drawing.Point(378, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 68);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Figure";
            // 
            // Field
            // 
            this.Field.AutoSize = true;
            this.Field.Location = new System.Drawing.Point(261, 26);
            this.Field.Name = "Field";
            this.Field.Size = new System.Drawing.Size(62, 24);
            this.Field.TabIndex = 5;
            this.Field.TabStop = true;
            this.Field.Text = "Field";
            this.Field.UseVisualStyleBackColor = true;
            this.Field.Click += new System.EventHandler(this.Field_Click);
            // 
            // Rectangle
            // 
            this.Rectangle.AutoSize = true;
            this.Rectangle.Location = new System.Drawing.Point(148, 26);
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Size = new System.Drawing.Size(96, 24);
            this.Rectangle.TabIndex = 3;
            this.Rectangle.Text = "Rectangle";
            this.Rectangle.UseVisualStyleBackColor = true;
            // 
            // Line
            // 
            this.Line.AutoSize = true;
            this.Line.Checked = true;
            this.Line.Location = new System.Drawing.Point(6, 26);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(57, 24);
            this.Line.TabIndex = 4;
            this.Line.TabStop = true;
            this.Line.Text = "Line";
            this.Line.UseVisualStyleBackColor = true;
            // 
            // Ellipse
            // 
            this.Ellipse.AutoSize = true;
            this.Ellipse.Location = new System.Drawing.Point(69, 26);
            this.Ellipse.Name = "Ellipse";
            this.Ellipse.Size = new System.Drawing.Size(73, 24);
            this.Ellipse.TabIndex = 2;
            this.Ellipse.Text = "Ellipse";
            this.Ellipse.UseVisualStyleBackColor = true;
            // 
            // Color1
            // 
            this.Color1.Location = new System.Drawing.Point(866, 38);
            this.Color1.Name = "Color1";
            this.Color1.Size = new System.Drawing.Size(50, 44);
            this.Color1.TabIndex = 2;
            this.Color1.UseVisualStyleBackColor = true;
            this.Color1.Click += new System.EventHandler(this.Color1_Click);
            // 
            // Color2
            // 
            this.Color2.Location = new System.Drawing.Point(946, 38);
            this.Color2.Name = "Color2";
            this.Color2.Size = new System.Drawing.Size(47, 44);
            this.Color2.TabIndex = 3;
            this.Color2.UseVisualStyleBackColor = true;
            this.Color2.Click += new System.EventHandler(this.Color2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(946, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "ForeColor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(864, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "BeckColor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Width line";
            // 
            // Wigh
            // 
            this.Wigh.Location = new System.Drawing.Point(466, 158);
            this.Wigh.Maximum = 20;
            this.Wigh.Minimum = 1;
            this.Wigh.Name = "Wigh";
            this.Wigh.Size = new System.Drawing.Size(178, 56);
            this.Wigh.TabIndex = 9;
            this.Wigh.Value = 1;
            this.Wigh.Scroll += new System.EventHandler(this.Wigh_Scroll);
            // 
            // DiferentLine
            // 
            this.DiferentLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DiferentLine.FormattingEnabled = true;
            this.DiferentLine.Items.AddRange(new object[] {
            "Solid",
            "Dash",
            "Dot",
            "Dash-Dot",
            "Dash-Dot-Dot"});
            this.DiferentLine.Location = new System.Drawing.Point(381, 114);
            this.DiferentLine.Name = "DiferentLine";
            this.DiferentLine.Size = new System.Drawing.Size(151, 28);
            this.DiferentLine.TabIndex = 10;
            this.DiferentLine.SelectedIndexChanged += new System.EventHandler(this.DiferentLine_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(650, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Start line";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(819, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "End line";
            // 
            // Start
            // 
            this.Start.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Start.FormattingEnabled = true;
            this.Start.Items.AddRange(new object[] {
            "Flat",
            "Square",
            "Round",
            "Triangle",
            "NoAnchor",
            "SquareAnchor",
            "RoundAnchor",
            "DiamondAnchor",
            "Arrow Anchor"});
            this.Start.Location = new System.Drawing.Point(650, 158);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(151, 28);
            this.Start.TabIndex = 13;
            this.Start.SelectedIndexChanged += new System.EventHandler(this.Start_SelectedIndexChanged);
            // 
            // End
            // 
            this.End.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.End.FormattingEnabled = true;
            this.End.Items.AddRange(new object[] {
            "Flat",
            "Square",
            "Round",
            "Triangle",
            "NoAnchor",
            "SquareAnchor",
            "RoundAnchor",
            "DiamondAnchor",
            "Arrow Anchor"});
            this.End.Location = new System.Drawing.Point(819, 155);
            this.End.Name = "End";
            this.End.Size = new System.Drawing.Size(151, 28);
            this.End.TabIndex = 14;
            this.End.SelectedIndexChanged += new System.EventHandler(this.End_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Texture);
            this.groupBox2.Controls.Add(this.Hatch);
            this.groupBox2.Controls.Add(this.Solid);
            this.groupBox2.Controls.Add(this.Gradient);
            this.groupBox2.Location = new System.Drawing.Point(378, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(642, 56);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Brush";
            // 
            // Texture
            // 
            this.Texture.AutoSize = true;
            this.Texture.Location = new System.Drawing.Point(460, 26);
            this.Texture.Name = "Texture";
            this.Texture.Size = new System.Drawing.Size(78, 24);
            this.Texture.TabIndex = 19;
            this.Texture.TabStop = true;
            this.Texture.Text = "Texture";
            this.Texture.UseVisualStyleBackColor = true;
            this.Texture.Click += new System.EventHandler(this.Texture_Click);
            // 
            // Hatch
            // 
            this.Hatch.AutoSize = true;
            this.Hatch.Location = new System.Drawing.Point(290, 26);
            this.Hatch.Name = "Hatch";
            this.Hatch.Size = new System.Drawing.Size(69, 24);
            this.Hatch.TabIndex = 18;
            this.Hatch.TabStop = true;
            this.Hatch.Text = "Hatch";
            this.Hatch.UseVisualStyleBackColor = true;
            this.Hatch.Click += new System.EventHandler(this.Hatch_Click);
            // 
            // Solid
            // 
            this.Solid.AutoSize = true;
            this.Solid.Location = new System.Drawing.Point(6, 26);
            this.Solid.Name = "Solid";
            this.Solid.Size = new System.Drawing.Size(64, 24);
            this.Solid.TabIndex = 16;
            this.Solid.TabStop = true;
            this.Solid.Text = "Solid";
            this.Solid.UseVisualStyleBackColor = true;
            this.Solid.Click += new System.EventHandler(this.Solid_Click);
            // 
            // Gradient
            // 
            this.Gradient.AutoSize = true;
            this.Gradient.Location = new System.Drawing.Point(76, 26);
            this.Gradient.Name = "Gradient";
            this.Gradient.Size = new System.Drawing.Size(87, 24);
            this.Gradient.TabIndex = 17;
            this.Gradient.TabStop = true;
            this.Gradient.Text = "Gradient";
            this.Gradient.UseVisualStyleBackColor = true;
            this.Gradient.Click += new System.EventHandler(this.Gradient_Click);
            // 
            // FirstColor
            // 
            this.FirstColor.Enabled = false;
            this.FirstColor.Location = new System.Drawing.Point(381, 281);
            this.FirstColor.Name = "FirstColor";
            this.FirstColor.Size = new System.Drawing.Size(51, 52);
            this.FirstColor.TabIndex = 16;
            this.FirstColor.UseVisualStyleBackColor = true;
            this.FirstColor.Click += new System.EventHandler(this.button1_Click);
            // 
            // SecondColor
            // 
            this.SecondColor.Enabled = false;
            this.SecondColor.Location = new System.Drawing.Point(609, 282);
            this.SecondColor.Name = "SecondColor";
            this.SecondColor.Size = new System.Drawing.Size(53, 51);
            this.SecondColor.TabIndex = 17;
            this.SecondColor.UseVisualStyleBackColor = true;
            this.SecondColor.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Horizontal",
            "Vertical",
            "ForwardDiagonal",
            "BackwardDiagonal"});
            this.comboBox1.Location = new System.Drawing.Point(447, 282);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Horizontal",
            "Vertical ",
            "ForwardDiagonal",
            "BackwardDiagonal ",
            "Cross",
            "DiagonalCross ",
            "Percent05",
            "Percent10",
            "Percent20 ",
            "Percent25 ",
            "Percent30 ",
            "Percent40 ",
            "Percent50",
            "Percent60 ",
            "Percent70 ",
            "Percent75 ",
            "Percent80 ",
            "Percent90 ",
            "LightDownwardDiagonal ",
            "LightUpwardDiagonal ",
            "DarkDownwardDiagonal ",
            "DarkUpwardDiagonal ",
            "WideDownwardDiagonal ",
            "WideUpwardDiagonal ",
            "LightVertical ",
            "LightHorizontal ",
            "NarrowVertical ",
            "NarrowHorizontal ",
            "DarkVertical ",
            "DarkHorizontal ",
            "DashedDownwardDiagonal ",
            "DashedUpwardDiagonal ",
            "DashedHorizontal ",
            "DashedVertical ",
            "SmallConfetti ",
            "LargeConfetti ",
            "ZigZag ",
            "Wave",
            "DiagonalBrick ",
            "HorizontalBrick ",
            "Weave ",
            "Plaid ",
            "Divot ",
            "DottedGrid",
            "DottedDiamond",
            "Shingle ",
            "Trellis ",
            "Sphere",
            "SmallGrid",
            "SmallCheckerBoard ",
            "LargeCheckerBoard ",
            "OutlinedDiamond",
            "SolidDiamond "});
            this.comboBox2.Location = new System.Drawing.Point(668, 283);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(151, 28);
            this.comboBox2.TabIndex = 19;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 424);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 20;
            this.button3.Text = "Save image";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(381, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Tupe of line";
            // 
            // Open
            // 
            this.Open.Enabled = false;
            this.Open.Location = new System.Drawing.Point(838, 282);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(182, 29);
            this.Open.TabIndex = 22;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(668, 317);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(352, 27);
            this.textBox1.TabIndex = 23;
            // 
            // X
            // 
            this.X.Location = new System.Drawing.Point(366, 374);
            this.X.Maximum = new decimal(new int[] {
            348,
            0,
            0,
            0});
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(86, 27);
            this.X.TabIndex = 24;
            this.X.ValueChanged += new System.EventHandler(this.X_ValueChanged);
            // 
            // Y
            // 
            this.Y.Location = new System.Drawing.Point(472, 374);
            this.Y.Maximum = new decimal(new int[] {
            321,
            0,
            0,
            0});
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(84, 27);
            this.Y.TabIndex = 25;
            this.Y.ValueChanged += new System.EventHandler(this.Y_ValueChanged);
            // 
            // X1
            // 
            this.X1.Location = new System.Drawing.Point(369, 441);
            this.X1.Maximum = new decimal(new int[] {
            348,
            0,
            0,
            0});
            this.X1.Name = "X1";
            this.X1.Size = new System.Drawing.Size(86, 27);
            this.X1.TabIndex = 26;
            this.X1.ValueChanged += new System.EventHandler(this.X1_ValueChanged);
            // 
            // Y1
            // 
            this.Y1.Location = new System.Drawing.Point(472, 441);
            this.Y1.Maximum = new decimal(new int[] {
            321,
            0,
            0,
            0});
            this.Y1.Name = "Y1";
            this.Y1.Size = new System.Drawing.Size(84, 27);
            this.Y1.TabIndex = 27;
            this.Y1.ValueChanged += new System.EventHandler(this.Y1_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(428, 343);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "Point 1 X Y";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(414, 404);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 29;
            this.label8.Text = "Point 2 X Y";
            // 
            // Images
            // 
            this.Images.FormattingEnabled = true;
            this.Images.ItemHeight = 20;
            this.Images.Location = new System.Drawing.Point(1026, 59);
            this.Images.Name = "Images";
            this.Images.Size = new System.Drawing.Size(236, 304);
            this.Images.TabIndex = 30;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(1026, 369);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(94, 29);
            this.Add.TabIndex = 31;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Nameimage
            // 
            this.Nameimage.Location = new System.Drawing.Point(1137, 26);
            this.Nameimage.Name = "Nameimage";
            this.Nameimage.Size = new System.Drawing.Size(125, 27);
            this.Nameimage.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1026, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 20);
            this.label9.TabIndex = 33;
            this.label9.Text = "Name";
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(1148, 369);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(94, 29);
            this.Clear.TabIndex = 34;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(1148, 404);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(94, 29);
            this.Remove.TabIndex = 35;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(1026, 404);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(94, 29);
            this.Edit.TabIndex = 36;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // EndEdit
            // 
            this.EndEdit.Location = new System.Drawing.Point(1026, 439);
            this.EndEdit.Name = "EndEdit";
            this.EndEdit.Size = new System.Drawing.Size(94, 29);
            this.EndEdit.TabIndex = 37;
            this.EndEdit.Text = "End edit";
            this.EndEdit.UseVisualStyleBackColor = true;
            this.EndEdit.Click += new System.EventHandler(this.EndEdit_Click);
            // 
            // textfortext
            // 
            this.textfortext.Enabled = false;
            this.textfortext.Location = new System.Drawing.Point(587, 441);
            this.textfortext.Name = "textfortext";
            this.textfortext.Size = new System.Drawing.Size(190, 27);
            this.textfortext.TabIndex = 38;
            // 
            // Text1
            // 
            this.Text1.Enabled = false;
            this.Text1.Location = new System.Drawing.Point(587, 408);
            this.Text1.Name = "Text1";
            this.Text1.Size = new System.Drawing.Size(83, 27);
            this.Text1.TabIndex = 40;
            // 
            // Text2
            // 
            this.Text2.Enabled = false;
            this.Text2.Location = new System.Drawing.Point(689, 408);
            this.Text2.Name = "Text2";
            this.Text2.Size = new System.Drawing.Size(88, 27);
            this.Text2.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(366, 343);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 20);
            this.label10.TabIndex = 42;
            this.label10.Text = "Location";
            // 
            // Textpic
            // 
            this.Textpic.AutoSize = true;
            this.Textpic.Location = new System.Drawing.Point(587, 372);
            this.Textpic.Name = "Textpic";
            this.Textpic.Size = new System.Drawing.Size(58, 24);
            this.Textpic.TabIndex = 43;
            this.Textpic.Text = "Text";
            this.Textpic.UseVisualStyleBackColor = true;
            this.Textpic.CheckedChanged += new System.EventHandler(this.Textpic_CheckedChanged_1);
            // 
            // TextButton
            // 
            this.TextButton.Enabled = false;
            this.TextButton.Location = new System.Drawing.Point(668, 370);
            this.TextButton.Name = "TextButton";
            this.TextButton.Size = new System.Drawing.Size(69, 27);
            this.TextButton.TabIndex = 44;
            this.TextButton.UseVisualStyleBackColor = true;
            this.TextButton.Click += new System.EventHandler(this.TextButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 477);
            this.Controls.Add(this.TextButton);
            this.Controls.Add(this.Textpic);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Text2);
            this.Controls.Add(this.Text1);
            this.Controls.Add(this.textfortext);
            this.Controls.Add(this.EndEdit);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Nameimage);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Images);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Y1);
            this.Controls.Add(this.X1);
            this.Controls.Add(this.Y);
            this.Controls.Add(this.X);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.SecondColor);
            this.Controls.Add(this.FirstColor);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.End);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DiferentLine);
            this.Controls.Add(this.Wigh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Color2);
            this.Controls.Add(this.Color1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Wigh)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Y1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Text1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Text2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Rectangle;
        private System.Windows.Forms.RadioButton Line;
        private System.Windows.Forms.RadioButton Ellipse;
        private System.Windows.Forms.Button Color1;
        private System.Windows.Forms.Button Color2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar Wigh;
        private System.Windows.Forms.ComboBox DiferentLine;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Start;
        private System.Windows.Forms.ComboBox End;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Hatch;
        private System.Windows.Forms.RadioButton Solid;
        private System.Windows.Forms.RadioButton Gradient;
        private System.Windows.Forms.Button FirstColor;
        private System.Windows.Forms.Button SecondColor;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton Texture;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown X;
        private System.Windows.Forms.NumericUpDown Y;
        private System.Windows.Forms.NumericUpDown X1;
        private System.Windows.Forms.NumericUpDown Y1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox Images;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox Nameimage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button EndEdit;
        private System.Windows.Forms.TextBox textfortext;
        private System.Windows.Forms.NumericUpDown Text1;
        private System.Windows.Forms.NumericUpDown Text2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton Field;
        private System.Windows.Forms.CheckBox Textpic;
        private System.Windows.Forms.Button TextButton;
    }
}


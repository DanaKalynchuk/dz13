
namespace dz1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Add = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.ok = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.Edit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EndEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(12, 21);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(241, 364);
            this.listBox1.TabIndex = 0;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(279, 113);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(94, 29);
            this.Add.TabIndex = 1;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(279, 157);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(94, 29);
            this.Remove.TabIndex = 2;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(12, 409);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(241, 29);
            this.ok.TabIndex = 3;
            this.ok.Text = "Ok";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(279, 62);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(104, 27);
            this.numericUpDown1.TabIndex = 4;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(411, 62);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(103, 27);
            this.numericUpDown2.TabIndex = 5;
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(420, 113);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(94, 29);
            this.Edit.TabIndex = 6;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(411, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Y";
            // 
            // EndEdit
            // 
            this.EndEdit.Location = new System.Drawing.Point(420, 157);
            this.EndEdit.Name = "EndEdit";
            this.EndEdit.Size = new System.Drawing.Size(94, 29);
            this.EndEdit.TabIndex = 9;
            this.EndEdit.Text = "End Edit";
            this.EndEdit.UseVisualStyleBackColor = true;
            this.EndEdit.Click += new System.EventHandler(this.EndEdit_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EndEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.listBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button EndEdit;
    }
}
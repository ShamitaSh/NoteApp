
using System.Windows.Forms;

namespace NoteApp
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.titlebox = new System.Windows.Forms.RichTextBox();
            this.messagebox = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.New = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.Font = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.FontCol = new System.Windows.Forms.Label();
            this.Fontt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(30, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "TITLE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "MESSAGE";
            // 
            // titlebox
            // 
            this.titlebox.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlebox.Location = new System.Drawing.Point(169, 19);
            this.titlebox.Name = "titlebox";
            this.titlebox.Size = new System.Drawing.Size(287, 45);
            this.titlebox.TabIndex = 2;
            this.titlebox.Text = "";
            this.titlebox.TextChanged += new System.EventHandler(this.titlebox_TextChanged);
            // 
            // messagebox
            // 
            this.messagebox.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messagebox.Location = new System.Drawing.Point(27, 152);
            this.messagebox.Name = "messagebox";
            this.messagebox.Size = new System.Drawing.Size(429, 308);
            this.messagebox.TabIndex = 3;
            this.messagebox.Text = "";
            this.messagebox.TextChanged += new System.EventHandler(this.messagebox_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(491, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(287, 290);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // New
            // 
            this.New.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New.Location = new System.Drawing.Point(27, 481);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(84, 33);
            this.New.TabIndex = 5;
            this.New.Text = "New";
            this.New.UseVisualStyleBackColor = true;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Location = new System.Drawing.Point(159, 481);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(84, 33);
            this.save.TabIndex = 6;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(306, 483);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(84, 33);
            this.delete.TabIndex = 8;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // Font
            // 
            this.Font.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Font.FormattingEnabled = true;
            this.Font.Location = new System.Drawing.Point(636, 375);
            this.Font.Name = "Font";
            this.Font.Size = new System.Drawing.Size(121, 24);
            this.Font.TabIndex = 11;
            this.Font.TextChanged += new System.EventHandler(this.Font_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(491, 375);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.ForeColorChanged += new System.EventHandler(this.comboBox1_ForeColorChanged);
            // 
            // FontCol
            // 
            this.FontCol.AutoSize = true;
            this.FontCol.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FontCol.Location = new System.Drawing.Point(501, 354);
            this.FontCol.Name = "FontCol";
            this.FontCol.Size = new System.Drawing.Size(96, 17);
            this.FontCol.TabIndex = 13;
            this.FontCol.Text = "Font Colour";
            // 
            // Fontt
            // 
            this.Fontt.AutoSize = true;
            this.Fontt.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fontt.Location = new System.Drawing.Point(677, 355);
            this.Fontt.Name = "Fontt";
            this.Fontt.Size = new System.Drawing.Size(40, 17);
            this.Fontt.TabIndex = 14;
            this.Fontt.Text = "Font";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 536);
            this.Controls.Add(this.Fontt);
            this.Controls.Add(this.FontCol);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Font);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.save);
            this.Controls.Add(this.New);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.messagebox);
            this.Controls.Add(this.titlebox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Notes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox titlebox;
        private System.Windows.Forms.RichTextBox messagebox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.ComboBox Font;
        private ComboBox comboBox1;
        private Label FontCol;
        private Label Fontt;
    }
}


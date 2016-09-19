namespace WindowsFormsApplication1
{
    partial class Form_Psicologo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Box_Nom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Apellido_Pat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Box_Apelli_Mat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Box_Dir = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Box_Col = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Box_Tel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btt_Alta_Psic = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.PK_psicologo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido_Pat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido_Mat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.work_days = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.limit_pac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sign_Pac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birth_Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Psicologos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre :";
            // 
            // txt_Box_Nom
            // 
            this.txt_Box_Nom.Location = new System.Drawing.Point(185, 61);
            this.txt_Box_Nom.Name = "txt_Box_Nom";
            this.txt_Box_Nom.Size = new System.Drawing.Size(281, 20);
            this.txt_Box_Nom.TabIndex = 1;
            this.txt_Box_Nom.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Apellido Paterno:";
            // 
            // txt_Apellido_Pat
            // 
            this.txt_Apellido_Pat.Location = new System.Drawing.Point(185, 104);
            this.txt_Apellido_Pat.Name = "txt_Apellido_Pat";
            this.txt_Apellido_Pat.Size = new System.Drawing.Size(281, 20);
            this.txt_Apellido_Pat.TabIndex = 1;
            this.txt_Apellido_Pat.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Apellido Materno:";
            // 
            // txt_Box_Apelli_Mat
            // 
            this.txt_Box_Apelli_Mat.Location = new System.Drawing.Point(185, 147);
            this.txt_Box_Apelli_Mat.Name = "txt_Box_Apelli_Mat";
            this.txt_Box_Apelli_Mat.Size = new System.Drawing.Size(281, 20);
            this.txt_Box_Apelli_Mat.TabIndex = 1;
            this.txt_Box_Apelli_Mat.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Direccion:";
            // 
            // txt_Box_Dir
            // 
            this.txt_Box_Dir.Location = new System.Drawing.Point(185, 190);
            this.txt_Box_Dir.Name = "txt_Box_Dir";
            this.txt_Box_Dir.Size = new System.Drawing.Size(281, 20);
            this.txt_Box_Dir.TabIndex = 1;
            this.txt_Box_Dir.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Colonia:";
            // 
            // txt_Box_Col
            // 
            this.txt_Box_Col.Location = new System.Drawing.Point(185, 233);
            this.txt_Box_Col.Name = "txt_Box_Col";
            this.txt_Box_Col.Size = new System.Drawing.Size(281, 20);
            this.txt_Box_Col.TabIndex = 1;
            this.txt_Box_Col.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Telefono:";
            // 
            // txt_Box_Tel
            // 
            this.txt_Box_Tel.Location = new System.Drawing.Point(185, 276);
            this.txt_Box_Tel.Name = "txt_Box_Tel";
            this.txt_Box_Tel.Size = new System.Drawing.Size(281, 20);
            this.txt_Box_Tel.TabIndex = 1;
            this.txt_Box_Tel.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 314);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "Dias Laborales:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(185, 319);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(38, 20);
            this.numericUpDown1.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 357);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 23);
            this.label9.TabIndex = 0;
            this.label9.Text = "Limite de Pacientes:";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(185, 362);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(38, 20);
            this.numericUpDown2.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 400);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(164, 23);
            this.label10.TabIndex = 0;
            this.label10.Text = "Pacientes: Inscritos:";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(185, 405);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(38, 20);
            this.numericUpDown3.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(18, 445);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(164, 23);
            this.label11.TabIndex = 0;
            this.label11.Text = "Pacientes: Inscritos:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(185, 448);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PK_psicologo,
            this.nombre,
            this.apellido_Pat,
            this.Apellido_Mat,
            this.dir,
            this.tel,
            this.work_days,
            this.limit_pac,
            this.sign_Pac,
            this.birth_Day});
            this.dataGridView1.Location = new System.Drawing.Point(494, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(635, 394);
            this.dataGridView1.TabIndex = 4;
            // 
            // btt_Alta_Psic
            // 
            this.btt_Alta_Psic.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_Alta_Psic.Location = new System.Drawing.Point(22, 523);
            this.btt_Alta_Psic.Name = "btt_Alta_Psic";
            this.btt_Alta_Psic.Size = new System.Drawing.Size(138, 35);
            this.btt_Alta_Psic.TabIndex = 5;
            this.btt_Alta_Psic.Text = "Alta";
            this.btt_Alta_Psic.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(339, 523);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "Baja";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(674, 523);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 35);
            this.button2.TabIndex = 5;
            this.button2.Text = "Modificaciones";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1009, 523);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 35);
            this.button3.TabIndex = 5;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // PK_psicologo
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PK_psicologo.DefaultCellStyle = dataGridViewCellStyle2;
            this.PK_psicologo.HeaderText = "Clave Psicologo";
            this.PK_psicologo.Name = "PK_psicologo";
            this.PK_psicologo.ReadOnly = true;
            this.PK_psicologo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // apellido_Pat
            // 
            this.apellido_Pat.HeaderText = "Apeellido Paterno";
            this.apellido_Pat.Name = "apellido_Pat";
            this.apellido_Pat.ReadOnly = true;
            this.apellido_Pat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Apellido_Mat
            // 
            this.Apellido_Mat.HeaderText = "Apellido Materno";
            this.Apellido_Mat.Name = "Apellido_Mat";
            this.Apellido_Mat.ReadOnly = true;
            this.Apellido_Mat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dir
            // 
            this.dir.HeaderText = "Direccion";
            this.dir.Name = "dir";
            this.dir.ReadOnly = true;
            this.dir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tel
            // 
            this.tel.HeaderText = "Telefono";
            this.tel.Name = "tel";
            this.tel.ReadOnly = true;
            this.tel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // work_days
            // 
            this.work_days.HeaderText = "Dias Laborales";
            this.work_days.Name = "work_days";
            this.work_days.ReadOnly = true;
            this.work_days.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // limit_pac
            // 
            this.limit_pac.HeaderText = "Limite de Pacientes";
            this.limit_pac.Name = "limit_pac";
            this.limit_pac.ReadOnly = true;
            this.limit_pac.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // sign_Pac
            // 
            this.sign_Pac.HeaderText = "Pacientes Inscritos";
            this.sign_Pac.Name = "sign_Pac";
            this.sign_Pac.ReadOnly = true;
            this.sign_Pac.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // birth_Day
            // 
            this.birth_Day.HeaderText = "Fecha de Nacimiento";
            this.birth_Day.Name = "birth_Day";
            this.birth_Day.ReadOnly = true;
            this.birth_Day.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Form_Psicologo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 570);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btt_Alta_Psic);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_Box_Tel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Box_Col);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Box_Dir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Box_Apelli_Mat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Apellido_Pat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Box_Nom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Psicologo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apellido Paterno:";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Psicologo_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Box_Nom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Apellido_Pat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Box_Apelli_Mat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Box_Dir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Box_Col;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Box_Tel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btt_Alta_Psic;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn PK_psicologo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido_Pat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido_Mat;
        private System.Windows.Forms.DataGridViewTextBoxColumn dir;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn work_days;
        private System.Windows.Forms.DataGridViewTextBoxColumn limit_pac;
        private System.Windows.Forms.DataGridViewTextBoxColumn sign_Pac;
        private System.Windows.Forms.DataGridViewTextBoxColumn birth_Day;
    }
}
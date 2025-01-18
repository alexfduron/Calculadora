namespace Win_Calculadora
{
    partial class Calc_Regular
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
            panel_pantalla = new Panel();
            panel_signo = new Panel();
            lbl_Operacion02 = new Label();
            lbl_Memo = new Label();
            lbl_Operacion01 = new Label();
            lbl_Pantalla = new Label();
            panel_numero = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btn_01 = new Button();
            btn_02 = new Button();
            btn_03 = new Button();
            btn_04 = new Button();
            btn_05 = new Button();
            btn_06 = new Button();
            btn_07 = new Button();
            btn_08 = new Button();
            btn_09 = new Button();
            btn_00 = new Button();
            btn_pto = new Button();
            btn_signo = new Button();
            panel_especial = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            btn_CA = new Button();
            btn_Back = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            btn_mas = new Button();
            btn_menos = new Button();
            btn_por = new Button();
            btn_entre = new Button();
            btn_igual = new Button();
            panel_pantalla.SuspendLayout();
            panel_signo.SuspendLayout();
            panel_numero.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel_especial.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel_pantalla
            // 
            panel_pantalla.Controls.Add(panel_signo);
            panel_pantalla.Controls.Add(lbl_Pantalla);
            panel_pantalla.Location = new Point(12, 12);
            panel_pantalla.Name = "panel_pantalla";
            panel_pantalla.Size = new Size(468, 95);
            panel_pantalla.TabIndex = 0;
            // 
            // panel_signo
            // 
            panel_signo.BorderStyle = BorderStyle.FixedSingle;
            panel_signo.Controls.Add(lbl_Operacion02);
            panel_signo.Controls.Add(lbl_Memo);
            panel_signo.Controls.Add(lbl_Operacion01);
            panel_signo.Dock = DockStyle.Fill;
            panel_signo.Location = new Point(0, 0);
            panel_signo.Name = "panel_signo";
            panel_signo.Size = new Size(95, 95);
            panel_signo.TabIndex = 1;
            // 
            // lbl_Operacion02
            // 
            lbl_Operacion02.BackColor = SystemColors.Control;
            lbl_Operacion02.Dock = DockStyle.Fill;
            lbl_Operacion02.Font = new Font("Consolas", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Operacion02.Location = new Point(0, 49);
            lbl_Operacion02.Name = "lbl_Operacion02";
            lbl_Operacion02.RightToLeft = RightToLeft.No;
            lbl_Operacion02.Size = new Size(93, 44);
            lbl_Operacion02.TabIndex = 2;
            lbl_Operacion02.Text = "+";
            lbl_Operacion02.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_Memo
            // 
            lbl_Memo.BackColor = SystemColors.Control;
            lbl_Memo.Dock = DockStyle.Top;
            lbl_Memo.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Memo.Location = new Point(0, 27);
            lbl_Memo.Name = "lbl_Memo";
            lbl_Memo.Size = new Size(93, 22);
            lbl_Memo.TabIndex = 1;
            lbl_Memo.Text = "Memo";
            lbl_Memo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_Operacion01
            // 
            lbl_Operacion01.BackColor = SystemColors.Control;
            lbl_Operacion01.Dock = DockStyle.Top;
            lbl_Operacion01.Font = new Font("Segoe UI", 9.6F, FontStyle.Underline);
            lbl_Operacion01.Location = new Point(0, 0);
            lbl_Operacion01.Name = "lbl_Operacion01";
            lbl_Operacion01.Size = new Size(93, 27);
            lbl_Operacion01.TabIndex = 0;
            lbl_Operacion01.Text = "Memory";
            lbl_Operacion01.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_Pantalla
            // 
            lbl_Pantalla.BackColor = SystemColors.Control;
            lbl_Pantalla.Dock = DockStyle.Right;
            lbl_Pantalla.Font = new Font("Consolas", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Pantalla.Location = new Point(95, 0);
            lbl_Pantalla.Name = "lbl_Pantalla";
            lbl_Pantalla.Size = new Size(373, 95);
            lbl_Pantalla.TabIndex = 0;
            lbl_Pantalla.Text = "0";
            lbl_Pantalla.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel_numero
            // 
            panel_numero.Controls.Add(tableLayoutPanel1);
            panel_numero.Location = new Point(13, 113);
            panel_numero.Name = "panel_numero";
            panel_numero.Size = new Size(271, 395);
            panel_numero.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(btn_01, 0, 2);
            tableLayoutPanel1.Controls.Add(btn_02, 1, 2);
            tableLayoutPanel1.Controls.Add(btn_03, 2, 2);
            tableLayoutPanel1.Controls.Add(btn_04, 0, 1);
            tableLayoutPanel1.Controls.Add(btn_05, 1, 1);
            tableLayoutPanel1.Controls.Add(btn_06, 2, 1);
            tableLayoutPanel1.Controls.Add(btn_07, 0, 0);
            tableLayoutPanel1.Controls.Add(btn_08, 1, 0);
            tableLayoutPanel1.Controls.Add(btn_09, 2, 0);
            tableLayoutPanel1.Controls.Add(btn_00, 1, 3);
            tableLayoutPanel1.Controls.Add(btn_pto, 2, 3);
            tableLayoutPanel1.Controls.Add(btn_signo, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(271, 395);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_01
            // 
            btn_01.Dock = DockStyle.Fill;
            btn_01.Font = new Font("Consolas", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_01.Location = new Point(3, 199);
            btn_01.Name = "btn_01";
            btn_01.RightToLeft = RightToLeft.No;
            btn_01.Size = new Size(84, 92);
            btn_01.TabIndex = 0;
            btn_01.Text = "1";
            btn_01.UseVisualStyleBackColor = true;
            btn_01.Click += btn_01_Click;
            // 
            // btn_02
            // 
            btn_02.Dock = DockStyle.Fill;
            btn_02.Font = new Font("Consolas", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_02.Location = new Point(93, 199);
            btn_02.Name = "btn_02";
            btn_02.Size = new Size(84, 92);
            btn_02.TabIndex = 1;
            btn_02.Text = "2";
            btn_02.UseVisualStyleBackColor = true;
            btn_02.Click += btn_02_Click;
            // 
            // btn_03
            // 
            btn_03.Dock = DockStyle.Fill;
            btn_03.Font = new Font("Consolas", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_03.Location = new Point(183, 199);
            btn_03.Name = "btn_03";
            btn_03.Size = new Size(85, 92);
            btn_03.TabIndex = 2;
            btn_03.Text = "3";
            btn_03.UseVisualStyleBackColor = true;
            btn_03.Click += btn_03_Click;
            // 
            // btn_04
            // 
            btn_04.Dock = DockStyle.Fill;
            btn_04.Font = new Font("Consolas", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_04.Location = new Point(3, 101);
            btn_04.Name = "btn_04";
            btn_04.Size = new Size(84, 92);
            btn_04.TabIndex = 3;
            btn_04.Text = "4";
            btn_04.UseVisualStyleBackColor = true;
            btn_04.Click += btn_04_Click;
            // 
            // btn_05
            // 
            btn_05.Dock = DockStyle.Fill;
            btn_05.Font = new Font("Consolas", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_05.Location = new Point(93, 101);
            btn_05.Name = "btn_05";
            btn_05.Size = new Size(84, 92);
            btn_05.TabIndex = 4;
            btn_05.Text = "5";
            btn_05.UseVisualStyleBackColor = true;
            btn_05.Click += btn_05_Click;
            // 
            // btn_06
            // 
            btn_06.Dock = DockStyle.Fill;
            btn_06.Font = new Font("Consolas", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_06.Location = new Point(183, 101);
            btn_06.Name = "btn_06";
            btn_06.Size = new Size(85, 92);
            btn_06.TabIndex = 5;
            btn_06.Text = "6";
            btn_06.UseVisualStyleBackColor = true;
            btn_06.Click += btn_06_Click;
            // 
            // btn_07
            // 
            btn_07.Dock = DockStyle.Fill;
            btn_07.Font = new Font("Consolas", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_07.Location = new Point(3, 3);
            btn_07.Name = "btn_07";
            btn_07.Size = new Size(84, 92);
            btn_07.TabIndex = 6;
            btn_07.Text = "7";
            btn_07.UseVisualStyleBackColor = true;
            btn_07.Click += btn_07_Click;
            // 
            // btn_08
            // 
            btn_08.Dock = DockStyle.Fill;
            btn_08.Font = new Font("Consolas", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_08.Location = new Point(93, 3);
            btn_08.Name = "btn_08";
            btn_08.Size = new Size(84, 92);
            btn_08.TabIndex = 7;
            btn_08.Text = "8";
            btn_08.UseVisualStyleBackColor = true;
            btn_08.Click += btn_08_Click;
            // 
            // btn_09
            // 
            btn_09.Dock = DockStyle.Fill;
            btn_09.Font = new Font("Consolas", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_09.Location = new Point(183, 3);
            btn_09.Name = "btn_09";
            btn_09.Size = new Size(85, 92);
            btn_09.TabIndex = 8;
            btn_09.Text = "9";
            btn_09.UseVisualStyleBackColor = true;
            btn_09.Click += btn_09_Click;
            // 
            // btn_00
            // 
            btn_00.Dock = DockStyle.Fill;
            btn_00.Font = new Font("Consolas", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_00.Location = new Point(93, 297);
            btn_00.Name = "btn_00";
            btn_00.Size = new Size(84, 95);
            btn_00.TabIndex = 9;
            btn_00.Text = "0";
            btn_00.UseVisualStyleBackColor = true;
            btn_00.Click += btn_00_Click;
            // 
            // btn_pto
            // 
            btn_pto.Dock = DockStyle.Fill;
            btn_pto.Font = new Font("Consolas", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_pto.Location = new Point(183, 297);
            btn_pto.Name = "btn_pto";
            btn_pto.Size = new Size(85, 95);
            btn_pto.TabIndex = 10;
            btn_pto.Text = ".";
            btn_pto.UseVisualStyleBackColor = true;
            btn_pto.Click += btn_pto_Click;
            // 
            // btn_signo
            // 
            btn_signo.Dock = DockStyle.Fill;
            btn_signo.Font = new Font("Consolas", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_signo.Location = new Point(3, 297);
            btn_signo.Name = "btn_signo";
            btn_signo.Size = new Size(84, 95);
            btn_signo.TabIndex = 11;
            btn_signo.Text = "+/-";
            btn_signo.UseVisualStyleBackColor = true;
            btn_signo.Click += btn_signo_Click;
            // 
            // panel_especial
            // 
            panel_especial.Controls.Add(tableLayoutPanel2);
            panel_especial.Location = new Point(298, 116);
            panel_especial.Name = "panel_especial";
            panel_especial.Size = new Size(182, 392);
            panel_especial.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel2.Controls.Add(btn_igual, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(182, 392);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(btn_CA, 0, 0);
            tableLayoutPanel3.Controls.Add(btn_Back, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(176, 92);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // btn_CA
            // 
            btn_CA.Dock = DockStyle.Fill;
            btn_CA.Font = new Font("Consolas", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_CA.Location = new Point(3, 3);
            btn_CA.Name = "btn_CA";
            btn_CA.Size = new Size(82, 86);
            btn_CA.TabIndex = 0;
            btn_CA.Text = "CA";
            btn_CA.UseVisualStyleBackColor = true;
            btn_CA.Click += btn_CA_Click;
            // 
            // btn_Back
            // 
            btn_Back.Dock = DockStyle.Fill;
            btn_Back.Font = new Font("Consolas", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Back.Location = new Point(91, 3);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(82, 86);
            btn_Back.TabIndex = 1;
            btn_Back.Text = "◄";
            btn_Back.UseVisualStyleBackColor = true;
            btn_Back.Click += btn_Back_Click;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(btn_mas, 0, 0);
            tableLayoutPanel4.Controls.Add(btn_menos, 1, 0);
            tableLayoutPanel4.Controls.Add(btn_por, 0, 1);
            tableLayoutPanel4.Controls.Add(btn_entre, 1, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 101);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(176, 190);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // btn_mas
            // 
            btn_mas.Dock = DockStyle.Fill;
            btn_mas.Font = new Font("Consolas", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_mas.Location = new Point(3, 3);
            btn_mas.Name = "btn_mas";
            btn_mas.Size = new Size(82, 89);
            btn_mas.TabIndex = 0;
            btn_mas.Text = "+";
            btn_mas.UseVisualStyleBackColor = true;
            btn_mas.Click += btn_mas_Click;
            // 
            // btn_menos
            // 
            btn_menos.Dock = DockStyle.Fill;
            btn_menos.Font = new Font("Consolas", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_menos.Location = new Point(91, 3);
            btn_menos.Name = "btn_menos";
            btn_menos.Size = new Size(82, 89);
            btn_menos.TabIndex = 1;
            btn_menos.Text = "-";
            btn_menos.UseVisualStyleBackColor = true;
            btn_menos.Click += btn_menos_Click;
            // 
            // btn_por
            // 
            btn_por.Dock = DockStyle.Fill;
            btn_por.Font = new Font("Consolas", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_por.Location = new Point(3, 98);
            btn_por.Name = "btn_por";
            btn_por.Size = new Size(82, 89);
            btn_por.TabIndex = 2;
            btn_por.Text = "x";
            btn_por.UseVisualStyleBackColor = true;
            btn_por.Click += btn_por_Click;
            // 
            // btn_entre
            // 
            btn_entre.Dock = DockStyle.Fill;
            btn_entre.Font = new Font("Consolas", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_entre.Location = new Point(91, 98);
            btn_entre.Name = "btn_entre";
            btn_entre.Size = new Size(82, 89);
            btn_entre.TabIndex = 3;
            btn_entre.Text = "/";
            btn_entre.UseVisualStyleBackColor = true;
            btn_entre.Click += btn_entre_Click;
            // 
            // btn_igual
            // 
            btn_igual.Dock = DockStyle.Fill;
            btn_igual.Font = new Font("Consolas", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_igual.Location = new Point(3, 297);
            btn_igual.Name = "btn_igual";
            btn_igual.Size = new Size(176, 92);
            btn_igual.TabIndex = 2;
            btn_igual.Text = "=";
            btn_igual.UseVisualStyleBackColor = true;
            btn_igual.Click += btn_igual_Click;
            // 
            // Calc_Regular
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(492, 520);
            Controls.Add(panel_especial);
            Controls.Add(panel_numero);
            Controls.Add(panel_pantalla);
            Name = "Calc_Regular";
            Text = "Calc_Regular";
            Load += Calc_Regular_Load;
            panel_pantalla.ResumeLayout(false);
            panel_signo.ResumeLayout(false);
            panel_numero.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel_especial.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_pantalla;
        private Label lbl_Pantalla;
        private Panel panel_signo;
        private Label lbl_Operacion01;
        private Label lbl_Operacion02;
        private Panel panel_numero;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btn_01;
        private Button btn_02;
        private Button btn_03;
        private Button btn_04;
        private Button btn_05;
        private Button btn_06;
        private Button btn_07;
        private Button btn_08;
        private Button btn_09;
        private Button btn_00;
        private Button btn_pto;
        private Panel panel_especial;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btn_CA;
        private Button btn_Back;
        private TableLayoutPanel tableLayoutPanel4;
        private Button btn_mas;
        private Button btn_menos;
        private Button btn_por;
        private Button btn_entre;
        private Button btn_igual;
        private Label lbl_Memo;
        private Button btn_signo;
    }
}
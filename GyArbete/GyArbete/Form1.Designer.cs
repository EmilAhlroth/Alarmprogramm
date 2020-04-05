namespace GyArbete
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
            this.bntNyttAlarm = new System.Windows.Forms.Button();
            this.tbxStällAlarm = new System.Windows.Forms.Button();
            this.lbxalarmLista = new System.Windows.Forms.ListBox();
            this.tbxNyÅr = new System.Windows.Forms.TextBox();
            this.tbxNyMånad = new System.Windows.Forms.TextBox();
            this.tbxNyDag = new System.Windows.Forms.TextBox();
            this.tbxNyTimme = new System.Windows.Forms.TextBox();
            this.tbxNyMinut = new System.Windows.Forms.TextBox();
            this.pnlNyttAlarm = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnTaBort = new System.Windows.Forms.Button();
            this.btnTaBortAlla = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlNyttAlarm.SuspendLayout();
            this.SuspendLayout();
            // 
            // bntNyttAlarm
            // 
            this.bntNyttAlarm.Location = new System.Drawing.Point(0, 4);
            this.bntNyttAlarm.Margin = new System.Windows.Forms.Padding(4);
            this.bntNyttAlarm.Name = "bntNyttAlarm";
            this.bntNyttAlarm.Size = new System.Drawing.Size(367, 29);
            this.bntNyttAlarm.TabIndex = 5;
            this.bntNyttAlarm.Text = "Nytt alarm";
            this.bntNyttAlarm.UseVisualStyleBackColor = true;
            this.bntNyttAlarm.Click += new System.EventHandler(this.bntNyttAlarm_Click);
            // 
            // tbxStällAlarm
            // 
            this.tbxStällAlarm.Location = new System.Drawing.Point(110, 149);
            this.tbxStällAlarm.Margin = new System.Windows.Forms.Padding(4);
            this.tbxStällAlarm.Name = "tbxStällAlarm";
            this.tbxStällAlarm.Size = new System.Drawing.Size(169, 29);
            this.tbxStällAlarm.TabIndex = 6;
            this.tbxStällAlarm.Text = "ställ alarm";
            this.tbxStällAlarm.UseVisualStyleBackColor = true;
            this.tbxStällAlarm.Click += new System.EventHandler(this.tbxStällAlarm_Click);
            // 
            // lbxalarmLista
            // 
            this.lbxalarmLista.FormattingEnabled = true;
            this.lbxalarmLista.ItemHeight = 20;
            this.lbxalarmLista.Location = new System.Drawing.Point(13, 214);
            this.lbxalarmLista.Margin = new System.Windows.Forms.Padding(4);
            this.lbxalarmLista.Name = "lbxalarmLista";
            this.lbxalarmLista.Size = new System.Drawing.Size(295, 184);
            this.lbxalarmLista.TabIndex = 17;
            this.lbxalarmLista.SelectedIndexChanged += new System.EventHandler(this.lbxalarmLista_SelectedIndexChanged);
            // 
            // tbxNyÅr
            // 
            this.tbxNyÅr.Location = new System.Drawing.Point(63, 44);
            this.tbxNyÅr.Margin = new System.Windows.Forms.Padding(4);
            this.tbxNyÅr.Name = "tbxNyÅr";
            this.tbxNyÅr.Size = new System.Drawing.Size(112, 26);
            this.tbxNyÅr.TabIndex = 18;
            // 
            // tbxNyMånad
            // 
            this.tbxNyMånad.Location = new System.Drawing.Point(63, 81);
            this.tbxNyMånad.Margin = new System.Windows.Forms.Padding(4);
            this.tbxNyMånad.Name = "tbxNyMånad";
            this.tbxNyMånad.Size = new System.Drawing.Size(112, 26);
            this.tbxNyMånad.TabIndex = 19;
            // 
            // tbxNyDag
            // 
            this.tbxNyDag.Location = new System.Drawing.Point(63, 121);
            this.tbxNyDag.Margin = new System.Windows.Forms.Padding(4);
            this.tbxNyDag.Name = "tbxNyDag";
            this.tbxNyDag.Size = new System.Drawing.Size(112, 26);
            this.tbxNyDag.TabIndex = 20;
            // 
            // tbxNyTimme
            // 
            this.tbxNyTimme.Location = new System.Drawing.Point(255, 38);
            this.tbxNyTimme.Margin = new System.Windows.Forms.Padding(4);
            this.tbxNyTimme.Name = "tbxNyTimme";
            this.tbxNyTimme.Size = new System.Drawing.Size(112, 26);
            this.tbxNyTimme.TabIndex = 21;
            // 
            // tbxNyMinut
            // 
            this.tbxNyMinut.Location = new System.Drawing.Point(255, 81);
            this.tbxNyMinut.Margin = new System.Windows.Forms.Padding(4);
            this.tbxNyMinut.Name = "tbxNyMinut";
            this.tbxNyMinut.Size = new System.Drawing.Size(112, 26);
            this.tbxNyMinut.TabIndex = 22;
            // 
            // pnlNyttAlarm
            // 
            this.pnlNyttAlarm.Controls.Add(this.label5);
            this.pnlNyttAlarm.Controls.Add(this.label4);
            this.pnlNyttAlarm.Controls.Add(this.label3);
            this.pnlNyttAlarm.Controls.Add(this.label2);
            this.pnlNyttAlarm.Controls.Add(this.label1);
            this.pnlNyttAlarm.Controls.Add(this.bntNyttAlarm);
            this.pnlNyttAlarm.Controls.Add(this.tbxNyÅr);
            this.pnlNyttAlarm.Controls.Add(this.tbxNyMånad);
            this.pnlNyttAlarm.Controls.Add(this.tbxNyDag);
            this.pnlNyttAlarm.Controls.Add(this.tbxNyTimme);
            this.pnlNyttAlarm.Controls.Add(this.tbxNyMinut);
            this.pnlNyttAlarm.Controls.Add(this.tbxStällAlarm);
            this.pnlNyttAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.pnlNyttAlarm.Location = new System.Drawing.Point(69, 13);
            this.pnlNyttAlarm.Margin = new System.Windows.Forms.Padding(4);
            this.pnlNyttAlarm.Name = "pnlNyttAlarm";
            this.pnlNyttAlarm.Size = new System.Drawing.Size(381, 38);
            this.pnlNyttAlarm.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "Minut";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Timme";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Dag";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Månad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "År";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(328, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 36);
            this.button1.TabIndex = 30;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnTaBort
            // 
            this.BtnTaBort.Enabled = false;
            this.BtnTaBort.Location = new System.Drawing.Point(328, 245);
            this.BtnTaBort.Name = "BtnTaBort";
            this.BtnTaBort.Size = new System.Drawing.Size(152, 30);
            this.BtnTaBort.TabIndex = 31;
            this.BtnTaBort.Text = "Ta bort alarm";
            this.BtnTaBort.UseVisualStyleBackColor = true;
            this.BtnTaBort.Click += new System.EventHandler(this.BtnTaBort_Click);
            // 
            // btnTaBortAlla
            // 
            this.btnTaBortAlla.Location = new System.Drawing.Point(328, 303);
            this.btnTaBortAlla.Name = "btnTaBortAlla";
            this.btnTaBortAlla.Size = new System.Drawing.Size(152, 30);
            this.btnTaBortAlla.TabIndex = 32;
            this.btnTaBortAlla.Text = "Ta bort alla alarm";
            this.btnTaBortAlla.UseVisualStyleBackColor = true;
            this.btnTaBortAlla.Click += new System.EventHandler(this.btnTaBortAlla_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "Alarmlista";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(536, 428);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnTaBortAlla);
            this.Controls.Add(this.BtnTaBort);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnlNyttAlarm);
            this.Controls.Add(this.lbxalarmLista);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlNyttAlarm.ResumeLayout(false);
            this.pnlNyttAlarm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntNyttAlarm;
        private System.Windows.Forms.Button tbxStällAlarm;
        private System.Windows.Forms.ListBox lbxalarmLista;
        private System.Windows.Forms.TextBox tbxNyÅr;
        private System.Windows.Forms.TextBox tbxNyMånad;
        private System.Windows.Forms.TextBox tbxNyDag;
        private System.Windows.Forms.TextBox tbxNyTimme;
        private System.Windows.Forms.TextBox tbxNyMinut;
        private System.Windows.Forms.Panel pnlNyttAlarm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnTaBort;
        private System.Windows.Forms.Button btnTaBortAlla;
        private System.Windows.Forms.Label label6;
    }
}


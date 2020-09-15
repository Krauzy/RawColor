namespace RawColor
{
    partial class FMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.barShine = new System.Windows.Forms.TrackBar();
            this.barHUE = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btOpenFile = new System.Windows.Forms.Button();
            this.picH = new System.Windows.Forms.PictureBox();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.picS = new System.Windows.Forms.PictureBox();
            this.picI = new System.Windows.Forms.PictureBox();
            this.picR = new System.Windows.Forms.PictureBox();
            this.picG = new System.Windows.Forms.PictureBox();
            this.picB = new System.Windows.Forms.PictureBox();
            this.radioON = new System.Windows.Forms.RadioButton();
            this.radioOFF = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barShine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barHUE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btSave)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox
            // 
            this.picBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox.Location = new System.Drawing.Point(0, 0);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(513, 426);
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            this.picBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picBox_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 460);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Luminância";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(213, 460);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Brilho";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(405, 460);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "HUE";
            // 
            // barShine
            // 
            this.barShine.BackColor = System.Drawing.Color.White;
            this.barShine.LargeChange = 10;
            this.barShine.Location = new System.Drawing.Point(156, 498);
            this.barShine.Maximum = 100;
            this.barShine.Name = "barShine";
            this.barShine.Size = new System.Drawing.Size(151, 45);
            this.barShine.SmallChange = 10;
            this.barShine.TabIndex = 7;
            this.barShine.TickFrequency = 10;
            this.barShine.Scroll += new System.EventHandler(this.barShine_Scroll);
            // 
            // barHUE
            // 
            this.barHUE.BackColor = System.Drawing.Color.White;
            this.barHUE.LargeChange = 10;
            this.barHUE.Location = new System.Drawing.Point(343, 498);
            this.barHUE.Maximum = 100;
            this.barHUE.Name = "barHUE";
            this.barHUE.Size = new System.Drawing.Size(151, 45);
            this.barHUE.SmallChange = 10;
            this.barHUE.TabIndex = 8;
            this.barHUE.TickFrequency = 10;
            this.barHUE.Scroll += new System.EventHandler(this.barHUE_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(281, 528);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "100";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(163, 528);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "0";
            // 
            // btOpenFile
            // 
            this.btOpenFile.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOpenFile.Location = new System.Drawing.Point(201, 187);
            this.btOpenFile.Name = "btOpenFile";
            this.btOpenFile.Size = new System.Drawing.Size(106, 32);
            this.btOpenFile.TabIndex = 15;
            this.btOpenFile.Text = "Abrir Imagem";
            this.btOpenFile.UseVisualStyleBackColor = true;
            this.btOpenFile.Click += new System.EventHandler(this.btOpenFile_Click);
            // 
            // picH
            // 
            this.picH.Location = new System.Drawing.Point(519, 0);
            this.picH.Name = "picH";
            this.picH.Size = new System.Drawing.Size(74, 66);
            this.picH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picH.TabIndex = 16;
            this.picH.TabStop = false;
            // 
            // picS
            // 
            this.picS.Location = new System.Drawing.Point(519, 72);
            this.picS.Name = "picS";
            this.picS.Size = new System.Drawing.Size(74, 66);
            this.picS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picS.TabIndex = 17;
            this.picS.TabStop = false;
            // 
            // picI
            // 
            this.picI.Location = new System.Drawing.Point(519, 144);
            this.picI.Name = "picI";
            this.picI.Size = new System.Drawing.Size(74, 66);
            this.picI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picI.TabIndex = 18;
            this.picI.TabStop = false;
            // 
            // picR
            // 
            this.picR.Location = new System.Drawing.Point(519, 216);
            this.picR.Name = "picR";
            this.picR.Size = new System.Drawing.Size(74, 66);
            this.picR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picR.TabIndex = 19;
            this.picR.TabStop = false;
            // 
            // picG
            // 
            this.picG.Location = new System.Drawing.Point(519, 288);
            this.picG.Name = "picG";
            this.picG.Size = new System.Drawing.Size(74, 66);
            this.picG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picG.TabIndex = 20;
            this.picG.TabStop = false;
            // 
            // picB
            // 
            this.picB.Location = new System.Drawing.Point(519, 360);
            this.picB.Name = "picB";
            this.picB.Size = new System.Drawing.Size(74, 66);
            this.picB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picB.TabIndex = 21;
            this.picB.TabStop = false;
            // 
            // radioON
            // 
            this.radioON.AutoSize = true;
            this.radioON.Location = new System.Drawing.Point(26, 498);
            this.radioON.Name = "radioON";
            this.radioON.Size = new System.Drawing.Size(41, 17);
            this.radioON.TabIndex = 22;
            this.radioON.TabStop = true;
            this.radioON.Text = "ON";
            this.radioON.UseVisualStyleBackColor = true;
            this.radioON.CheckedChanged += new System.EventHandler(this.radioON_CheckedChanged);
            // 
            // radioOFF
            // 
            this.radioOFF.AutoSize = true;
            this.radioOFF.Location = new System.Drawing.Point(73, 498);
            this.radioOFF.Name = "radioOFF";
            this.radioOFF.Size = new System.Drawing.Size(45, 17);
            this.radioOFF.TabIndex = 23;
            this.radioOFF.TabStop = true;
            this.radioOFF.Text = "OFF";
            this.radioOFF.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(350, 528);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(468, 528);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "100";
            // 
            // btSave
            // 
            this.btSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSave.Image = global::RawColor.Properties.Resources.icons8_save_64;
            this.btSave.Location = new System.Drawing.Point(471, 384);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(37, 36);
            this.btSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btSave.TabIndex = 26;
            this.btSave.TabStop = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(593, 576);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.barShine);
            this.Controls.Add(this.radioOFF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picB);
            this.Controls.Add(this.radioON);
            this.Controls.Add(this.picG);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.picI);
            this.Controls.Add(this.barHUE);
            this.Controls.Add(this.picS);
            this.Controls.Add(this.picH);
            this.Controls.Add(this.btOpenFile);
            this.Controls.Add(this.picBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raw Color";
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barShine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barHUE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btSave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar barShine;
        private System.Windows.Forms.TrackBar barHUE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btOpenFile;
        private System.Windows.Forms.PictureBox picH;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.PictureBox picS;
        private System.Windows.Forms.PictureBox picI;
        private System.Windows.Forms.PictureBox picR;
        private System.Windows.Forms.PictureBox picG;
        private System.Windows.Forms.PictureBox picB;
        private System.Windows.Forms.RadioButton radioON;
        private System.Windows.Forms.RadioButton radioOFF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox btSave;
    }
}


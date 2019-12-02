namespace MazeGenerator
{
    partial class Form1
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
            this.GenerateMazeBtn = new System.Windows.Forms.Button();
            this.HeightUpDown = new System.Windows.Forms.NumericUpDown();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LenghtUpDown = new System.Windows.Forms.NumericUpDown();
            this.MazeBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SpeedUpDown = new System.Windows.Forms.NumericUpDown();
            this.Inicio_Btn = new System.Windows.Forms.Button();
            this.fim_Btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.HeightUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LenghtUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MazeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // GenerateMazeBtn
            // 
            this.GenerateMazeBtn.Location = new System.Drawing.Point(12, 424);
            this.GenerateMazeBtn.Name = "GenerateMazeBtn";
            this.GenerateMazeBtn.Size = new System.Drawing.Size(144, 52);
            this.GenerateMazeBtn.TabIndex = 0;
            this.GenerateMazeBtn.Text = "Generate Maze";
            this.GenerateMazeBtn.UseVisualStyleBackColor = true;
            this.GenerateMazeBtn.Click += new System.EventHandler(this.GenerateMazeBtn_Click);
            // 
            // HeightUpDown
            // 
            this.HeightUpDown.Location = new System.Drawing.Point(177, 442);
            this.HeightUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.HeightUpDown.Name = "HeightUpDown";
            this.HeightUpDown.Size = new System.Drawing.Size(48, 20);
            this.HeightUpDown.TabIndex = 1;
            this.HeightUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.HeightUpDown.ValueChanged += new System.EventHandler(this.HeightUpDown_ValueChanged);
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(174, 424);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(38, 13);
            this.HeightLabel.TabIndex = 2;
            this.HeightLabel.Text = "Height";
            this.HeightLabel.Click += new System.EventHandler(this.HeightLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 424);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lenght";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LenghtUpDown
            // 
            this.LenghtUpDown.Location = new System.Drawing.Point(276, 440);
            this.LenghtUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.LenghtUpDown.Name = "LenghtUpDown";
            this.LenghtUpDown.Size = new System.Drawing.Size(48, 20);
            this.LenghtUpDown.TabIndex = 4;
            this.LenghtUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.LenghtUpDown.ValueChanged += new System.EventHandler(this.LenghtUpDown_ValueChanged);
            // 
            // MazeBox
            // 
            this.MazeBox.Location = new System.Drawing.Point(12, 12);
            this.MazeBox.Name = "MazeBox";
            this.MazeBox.Size = new System.Drawing.Size(801, 401);
            this.MazeBox.TabIndex = 5;
            this.MazeBox.TabStop = false;
            this.MazeBox.Click += new System.EventHandler(this.MazeBox_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 423);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Speed";
            // 
            // SpeedUpDown
            // 
            this.SpeedUpDown.Location = new System.Drawing.Point(377, 440);
            this.SpeedUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.SpeedUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SpeedUpDown.Name = "SpeedUpDown";
            this.SpeedUpDown.Size = new System.Drawing.Size(71, 20);
            this.SpeedUpDown.TabIndex = 7;
            this.SpeedUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SpeedUpDown.ValueChanged += new System.EventHandler(this.SpeedUpDown_ValueChanged);
            // 
            // Inicio_Btn
            // 
            this.Inicio_Btn.Location = new System.Drawing.Point(467, 424);
            this.Inicio_Btn.Name = "Inicio_Btn";
            this.Inicio_Btn.Size = new System.Drawing.Size(89, 52);
            this.Inicio_Btn.TabIndex = 8;
            this.Inicio_Btn.Text = "Selecionar Ponto Inicial";
            this.Inicio_Btn.UseVisualStyleBackColor = true;
            this.Inicio_Btn.Click += new System.EventHandler(this.Inicio_Btn_Click);
            // 
            // fim_Btn
            // 
            this.fim_Btn.Location = new System.Drawing.Point(562, 423);
            this.fim_Btn.Name = "fim_Btn";
            this.fim_Btn.Size = new System.Drawing.Size(89, 52);
            this.fim_Btn.TabIndex = 9;
            this.fim_Btn.Text = "Selecionar Ponto Final";
            this.fim_Btn.UseVisualStyleBackColor = true;
            this.fim_Btn.Click += new System.EventHandler(this.fim_Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 488);
            this.Controls.Add(this.fim_Btn);
            this.Controls.Add(this.Inicio_Btn);
            this.Controls.Add(this.SpeedUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MazeBox);
            this.Controls.Add(this.LenghtUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.HeightUpDown);
            this.Controls.Add(this.GenerateMazeBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.HeightUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LenghtUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MazeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenerateMazeBtn;
        private System.Windows.Forms.NumericUpDown HeightUpDown;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown LenghtUpDown;
        private System.Windows.Forms.PictureBox MazeBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown SpeedUpDown;
        private System.Windows.Forms.Button Inicio_Btn;
        private System.Windows.Forms.Button fim_Btn;
    }
}


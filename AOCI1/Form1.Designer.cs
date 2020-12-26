namespace AOCI1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.label = new System.Windows.Forms.Label();
            this.buttonCamera = new System.Windows.Forms.Button();
            this.buttonVideo = new System.Windows.Forms.Button();
            this.radioButtonContour = new System.Windows.Forms.RadioButton();
            this.radioButtonBoxes = new System.Windows.Forms.RadioButton();
            this.trackBarArea = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarArea)).BeginInit();
            this.SuspendLayout();
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(0, 0);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(500, 500);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // imageBox2
            // 
            this.imageBox2.Location = new System.Drawing.Point(627, 0);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(500, 500);
            this.imageBox2.TabIndex = 2;
            this.imageBox2.TabStop = false;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(624, 516);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 13);
            this.label.TabIndex = 7;
            // 
            // buttonCamera
            // 
            this.buttonCamera.Location = new System.Drawing.Point(507, 12);
            this.buttonCamera.Name = "buttonCamera";
            this.buttonCamera.Size = new System.Drawing.Size(114, 23);
            this.buttonCamera.TabIndex = 8;
            this.buttonCamera.Text = "Camera";
            this.buttonCamera.UseVisualStyleBackColor = true;
            this.buttonCamera.Click += new System.EventHandler(this.buttonCamera_Click);
            // 
            // buttonVideo
            // 
            this.buttonVideo.Location = new System.Drawing.Point(506, 41);
            this.buttonVideo.Name = "buttonVideo";
            this.buttonVideo.Size = new System.Drawing.Size(114, 23);
            this.buttonVideo.TabIndex = 14;
            this.buttonVideo.Text = "Video";
            this.buttonVideo.UseVisualStyleBackColor = true;
            this.buttonVideo.Click += new System.EventHandler(this.buttonVideo_Click);
            // 
            // radioButtonContour
            // 
            this.radioButtonContour.AutoSize = true;
            this.radioButtonContour.Location = new System.Drawing.Point(506, 71);
            this.radioButtonContour.Name = "radioButtonContour";
            this.radioButtonContour.Size = new System.Drawing.Size(67, 17);
            this.radioButtonContour.TabIndex = 15;
            this.radioButtonContour.TabStop = true;
            this.radioButtonContour.Text = "Contours";
            this.radioButtonContour.UseVisualStyleBackColor = true;
            // 
            // radioButtonBoxes
            // 
            this.radioButtonBoxes.AutoSize = true;
            this.radioButtonBoxes.Location = new System.Drawing.Point(507, 94);
            this.radioButtonBoxes.Name = "radioButtonBoxes";
            this.radioButtonBoxes.Size = new System.Drawing.Size(54, 17);
            this.radioButtonBoxes.TabIndex = 16;
            this.radioButtonBoxes.TabStop = true;
            this.radioButtonBoxes.Text = "Boxes";
            this.radioButtonBoxes.UseVisualStyleBackColor = true;
            // 
            // trackBarArea
            // 
            this.trackBarArea.Location = new System.Drawing.Point(506, 118);
            this.trackBarArea.Maximum = 2000;
            this.trackBarArea.Name = "trackBarArea";
            this.trackBarArea.Size = new System.Drawing.Size(114, 45);
            this.trackBarArea.TabIndex = 17;
            this.trackBarArea.TickFrequency = 100;
            this.trackBarArea.Value = 10;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 589);
            this.Controls.Add(this.trackBarArea);
            this.Controls.Add(this.radioButtonBoxes);
            this.Controls.Add(this.radioButtonContour);
            this.Controls.Add(this.buttonVideo);
            this.Controls.Add(this.buttonCamera);
            this.Controls.Add(this.label);
            this.Controls.Add(this.imageBox2);
            this.Controls.Add(this.imageBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBox1;
        private Emgu.CV.UI.ImageBox imageBox2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button buttonCamera;
        private System.Windows.Forms.Button buttonVideo;
        private System.Windows.Forms.RadioButton radioButtonContour;
        private System.Windows.Forms.RadioButton radioButtonBoxes;
        private System.Windows.Forms.TrackBar trackBarArea;
        private System.Windows.Forms.Timer timer1;
    }
}


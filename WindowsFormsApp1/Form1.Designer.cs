namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.samgak = new System.Windows.Forms.Button();
            this.square = new System.Windows.Forms.Button();
            this.DEL = new System.Windows.Forms.Button();
            this.AC = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.Number3 = new System.Windows.Forms.Button();
            this.Number2 = new System.Windows.Forms.Button();
            this.Number1 = new System.Windows.Forms.Button();
            this.Number4 = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.Number6 = new System.Windows.Forms.Button();
            this.Number5 = new System.Windows.Forms.Button();
            this.Number7 = new System.Windows.Forms.Button();
            this.Number8 = new System.Windows.Forms.Button();
            this.Number9 = new System.Windows.Forms.Button();
            this.subtraction = new System.Windows.Forms.Button();
            this.point = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.square10 = new System.Windows.Forms.Button();
            this.addition = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // samgak
            // 
            resources.ApplyResources(this.samgak, "samgak");
            this.samgak.Name = "samgak";
            this.samgak.UseVisualStyleBackColor = true;
            this.samgak.Click += new System.EventHandler(this.button2_Click);
            // 
            // square
            // 
            resources.ApplyResources(this.square, "square");
            this.square.Name = "square";
            this.square.UseVisualStyleBackColor = true;
            // 
            // DEL
            // 
            resources.ApplyResources(this.DEL, "DEL");
            this.DEL.Name = "DEL";
            this.DEL.UseVisualStyleBackColor = true;
            // 
            // AC
            // 
            resources.ApplyResources(this.AC, "AC");
            this.AC.Name = "AC";
            this.AC.UseVisualStyleBackColor = true;
            // 
            // multiplication
            // 
            resources.ApplyResources(this.multiplication, "multiplication");
            this.multiplication.Name = "multiplication";
            this.multiplication.UseVisualStyleBackColor = true;
            // 
            // Number3
            // 
            resources.ApplyResources(this.Number3, "Number3");
            this.Number3.Name = "Number3";
            this.Number3.UseVisualStyleBackColor = true;
            // 
            // Number2
            // 
            resources.ApplyResources(this.Number2, "Number2");
            this.Number2.Name = "Number2";
            this.Number2.UseVisualStyleBackColor = true;
            // 
            // Number1
            // 
            resources.ApplyResources(this.Number1, "Number1");
            this.Number1.Name = "Number1";
            this.Number1.UseVisualStyleBackColor = true;
            // 
            // Number4
            // 
            resources.ApplyResources(this.Number4, "Number4");
            this.Number4.Name = "Number4";
            this.Number4.UseVisualStyleBackColor = true;
            // 
            // division
            // 
            resources.ApplyResources(this.division, "division");
            this.division.Name = "division";
            this.division.UseVisualStyleBackColor = true;
            // 
            // Number6
            // 
            resources.ApplyResources(this.Number6, "Number6");
            this.Number6.Name = "Number6";
            this.Number6.UseVisualStyleBackColor = true;
            // 
            // Number5
            // 
            resources.ApplyResources(this.Number5, "Number5");
            this.Number5.Name = "Number5";
            this.Number5.UseVisualStyleBackColor = true;
            // 
            // Number7
            // 
            resources.ApplyResources(this.Number7, "Number7");
            this.Number7.Name = "Number7";
            this.Number7.UseVisualStyleBackColor = true;
            // 
            // Number8
            // 
            resources.ApplyResources(this.Number8, "Number8");
            this.Number8.Name = "Number8";
            this.Number8.UseVisualStyleBackColor = true;
            // 
            // Number9
            // 
            resources.ApplyResources(this.Number9, "Number9");
            this.Number9.Name = "Number9";
            this.Number9.UseVisualStyleBackColor = true;
            // 
            // subtraction
            // 
            resources.ApplyResources(this.subtraction, "subtraction");
            this.subtraction.Name = "subtraction";
            this.subtraction.UseVisualStyleBackColor = true;
            // 
            // point
            // 
            resources.ApplyResources(this.point, "point");
            this.point.Name = "point";
            this.point.UseVisualStyleBackColor = true;
            // 
            // zero
            // 
            resources.ApplyResources(this.zero, "zero");
            this.zero.Name = "zero";
            this.zero.UseVisualStyleBackColor = true;
            // 
            // square10
            // 
            resources.ApplyResources(this.square10, "square10");
            this.square10.Name = "square10";
            this.square10.UseVisualStyleBackColor = true;
            // 
            // addition
            // 
            resources.ApplyResources(this.addition, "addition");
            this.addition.Name = "addition";
            this.addition.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.addition);
            this.Controls.Add(this.square10);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.point);
            this.Controls.Add(this.subtraction);
            this.Controls.Add(this.Number9);
            this.Controls.Add(this.Number8);
            this.Controls.Add(this.Number7);
            this.Controls.Add(this.Number5);
            this.Controls.Add(this.Number6);
            this.Controls.Add(this.division);
            this.Controls.Add(this.Number4);
            this.Controls.Add(this.Number1);
            this.Controls.Add(this.Number2);
            this.Controls.Add(this.Number3);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.AC);
            this.Controls.Add(this.DEL);
            this.Controls.Add(this.square);
            this.Controls.Add(this.samgak);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button samgak;
        private System.Windows.Forms.Button square;
        private System.Windows.Forms.Button DEL;
        private System.Windows.Forms.Button AC;
        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Button Number3;
        private System.Windows.Forms.Button Number2;
        private System.Windows.Forms.Button Number1;
        private System.Windows.Forms.Button Number4;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button Number6;
        private System.Windows.Forms.Button Number5;
        private System.Windows.Forms.Button Number7;
        private System.Windows.Forms.Button Number8;
        private System.Windows.Forms.Button Number9;
        private System.Windows.Forms.Button subtraction;
        private System.Windows.Forms.Button point;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button square10;
        private System.Windows.Forms.Button addition;
    }
}


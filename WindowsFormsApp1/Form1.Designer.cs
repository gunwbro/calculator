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
            this.DEL = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
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
            this.textbox = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.resul = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DEL
            // 
            resources.ApplyResources(this.DEL, "DEL");
            this.DEL.Name = "DEL";
            this.DEL.UseVisualStyleBackColor = true;
            this.DEL.Click += new System.EventHandler(this.DEL_Click);
            // 
            // C
            // 
            resources.ApplyResources(this.C, "C");
            this.C.Name = "C";
            this.C.UseVisualStyleBackColor = true;
            this.C.Click += new System.EventHandler(this.C_Click);
            // 
            // multiplication
            // 
            resources.ApplyResources(this.multiplication, "multiplication");
            this.multiplication.Name = "multiplication";
            this.multiplication.UseVisualStyleBackColor = true;
            this.multiplication.Click += new System.EventHandler(this.Number1_Click);
            // 
            // Number3
            // 
            resources.ApplyResources(this.Number3, "Number3");
            this.Number3.Name = "Number3";
            this.Number3.UseVisualStyleBackColor = true;
            this.Number3.Click += new System.EventHandler(this.Number1_Click);
            // 
            // Number2
            // 
            resources.ApplyResources(this.Number2, "Number2");
            this.Number2.Name = "Number2";
            this.Number2.UseVisualStyleBackColor = true;
            this.Number2.Click += new System.EventHandler(this.Number1_Click);
            // 
            // Number1
            // 
            resources.ApplyResources(this.Number1, "Number1");
            this.Number1.Name = "Number1";
            this.Number1.UseVisualStyleBackColor = true;
            this.Number1.Click += new System.EventHandler(this.Number1_Click);
            // 
            // Number4
            // 
            resources.ApplyResources(this.Number4, "Number4");
            this.Number4.Name = "Number4";
            this.Number4.UseVisualStyleBackColor = true;
            this.Number4.Click += new System.EventHandler(this.Number1_Click);
            // 
            // division
            // 
            resources.ApplyResources(this.division, "division");
            this.division.Name = "division";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.Number1_Click);
            // 
            // Number6
            // 
            resources.ApplyResources(this.Number6, "Number6");
            this.Number6.Name = "Number6";
            this.Number6.UseVisualStyleBackColor = true;
            this.Number6.Click += new System.EventHandler(this.Number1_Click);
            // 
            // Number5
            // 
            resources.ApplyResources(this.Number5, "Number5");
            this.Number5.Name = "Number5";
            this.Number5.UseVisualStyleBackColor = true;
            this.Number5.Click += new System.EventHandler(this.Number1_Click);
            // 
            // Number7
            // 
            resources.ApplyResources(this.Number7, "Number7");
            this.Number7.Name = "Number7";
            this.Number7.UseVisualStyleBackColor = true;
            this.Number7.Click += new System.EventHandler(this.Number1_Click);
            // 
            // Number8
            // 
            resources.ApplyResources(this.Number8, "Number8");
            this.Number8.Name = "Number8";
            this.Number8.UseVisualStyleBackColor = true;
            this.Number8.Click += new System.EventHandler(this.Number1_Click);
            // 
            // Number9
            // 
            resources.ApplyResources(this.Number9, "Number9");
            this.Number9.Name = "Number9";
            this.Number9.UseVisualStyleBackColor = true;
            this.Number9.Click += new System.EventHandler(this.Number1_Click);
            // 
            // subtraction
            // 
            resources.ApplyResources(this.subtraction, "subtraction");
            this.subtraction.Name = "subtraction";
            this.subtraction.UseVisualStyleBackColor = true;
            this.subtraction.Click += new System.EventHandler(this.Number1_Click);
            // 
            // point
            // 
            resources.ApplyResources(this.point, "point");
            this.point.Name = "point";
            this.point.UseVisualStyleBackColor = true;
            this.point.Click += new System.EventHandler(this.Number1_Click);
            // 
            // zero
            // 
            resources.ApplyResources(this.zero, "zero");
            this.zero.Name = "zero";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.Number1_Click);
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
            this.addition.Click += new System.EventHandler(this.Number1_Click);
            // 
            // textbox
            // 
            this.textbox.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.textbox, "textbox");
            this.textbox.Name = "textbox";
            // 
            // Result
            // 
            this.Result.BackColor = System.Drawing.SystemColors.GrayText;
            resources.ApplyResources(this.Result, "Result");
            this.Result.Name = "Result";
            // 
            // resul
            // 
            resources.ApplyResources(this.resul, "resul");
            this.resul.Name = "resul";
            this.resul.UseVisualStyleBackColor = true;
            this.resul.Click += new System.EventHandler(this.resul_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.resul);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.textbox);
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
            this.Controls.Add(this.C);
            this.Controls.Add(this.DEL);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button DEL;
        private System.Windows.Forms.Button C;
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
        private System.Windows.Forms.TextBox textbox;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Button resul;
    }
}



namespace TypeAnim
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LB_Text = new System.Windows.Forms.Label();
            this.TB_Text = new System.Windows.Forms.TextBox();
            this.Btn_SaveAnim = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_FileName = new System.Windows.Forms.TextBox();
            this.Btn_View = new System.Windows.Forms.Button();
            this.Dlg_font = new System.Windows.Forms.FontDialog();
            this.Btn_font = new System.Windows.Forms.Button();
            this.TB_Font = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LB_Text
            // 
            this.LB_Text.AutoSize = true;
            this.LB_Text.BackColor = System.Drawing.Color.Black;
            this.LB_Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LB_Text.Font = new System.Drawing.Font("cjkFonts 全瀨體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LB_Text.ForeColor = System.Drawing.Color.White;
            this.LB_Text.Location = new System.Drawing.Point(12, 9);
            this.LB_Text.Name = "LB_Text";
            this.LB_Text.Size = new System.Drawing.Size(2, 42);
            this.LB_Text.TabIndex = 0;
            // 
            // TB_Text
            // 
            this.TB_Text.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TB_Text.Location = new System.Drawing.Point(25, 458);
            this.TB_Text.Multiline = true;
            this.TB_Text.Name = "TB_Text";
            this.TB_Text.Size = new System.Drawing.Size(852, 165);
            this.TB_Text.TabIndex = 1;
            this.TB_Text.TextChanged += new System.EventHandler(this.TB_Text_TextChanged);
            // 
            // Btn_SaveAnim
            // 
            this.Btn_SaveAnim.BackColor = System.Drawing.Color.Black;
            this.Btn_SaveAnim.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_SaveAnim.ForeColor = System.Drawing.Color.White;
            this.Btn_SaveAnim.Location = new System.Drawing.Point(901, 477);
            this.Btn_SaveAnim.Name = "Btn_SaveAnim";
            this.Btn_SaveAnim.Size = new System.Drawing.Size(151, 48);
            this.Btn_SaveAnim.TabIndex = 3;
            this.Btn_SaveAnim.Text = "保存动画";
            this.Btn_SaveAnim.UseVisualStyleBackColor = false;
            this.Btn_SaveAnim.Click += new System.EventHandler(this.Btn_SaveAnim_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(442, 647);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "文件名";
            // 
            // TB_FileName
            // 
            this.TB_FileName.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TB_FileName.Location = new System.Drawing.Point(534, 644);
            this.TB_FileName.Name = "TB_FileName";
            this.TB_FileName.Size = new System.Drawing.Size(518, 37);
            this.TB_FileName.TabIndex = 7;
            this.TB_FileName.Text = "anim.mp4";
            this.TB_FileName.TextChanged += new System.EventHandler(this.TB_FileName_TextChanged);
            // 
            // Btn_View
            // 
            this.Btn_View.BackColor = System.Drawing.Color.Black;
            this.Btn_View.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_View.ForeColor = System.Drawing.Color.White;
            this.Btn_View.Location = new System.Drawing.Point(901, 549);
            this.Btn_View.Name = "Btn_View";
            this.Btn_View.Size = new System.Drawing.Size(151, 48);
            this.Btn_View.TabIndex = 8;
            this.Btn_View.Text = "打开动画";
            this.Btn_View.UseVisualStyleBackColor = false;
            this.Btn_View.Click += new System.EventHandler(this.Btn_View_Click);
            // 
            // Dlg_font
            // 
            this.Dlg_font.Color = System.Drawing.Color.White;
            this.Dlg_font.Font = new System.Drawing.Font("cjkFonts 全瀨體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Dlg_font.ShowColor = true;
            // 
            // Btn_font
            // 
            this.Btn_font.BackColor = System.Drawing.Color.Black;
            this.Btn_font.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_font.ForeColor = System.Drawing.Color.White;
            this.Btn_font.Location = new System.Drawing.Point(275, 638);
            this.Btn_font.Name = "Btn_font";
            this.Btn_font.Size = new System.Drawing.Size(151, 48);
            this.Btn_font.TabIndex = 9;
            this.Btn_font.Text = "选择字体";
            this.Btn_font.UseVisualStyleBackColor = false;
            this.Btn_font.Click += new System.EventHandler(this.Btn_font_Click);
            // 
            // TB_Font
            // 
            this.TB_Font.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TB_Font.Location = new System.Drawing.Point(25, 644);
            this.TB_Font.Name = "TB_Font";
            this.TB_Font.ReadOnly = true;
            this.TB_Font.Size = new System.Drawing.Size(233, 37);
            this.TB_Font.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1082, 703);
            this.Controls.Add(this.TB_Font);
            this.Controls.Add(this.Btn_font);
            this.Controls.Add(this.Btn_View);
            this.Controls.Add(this.TB_FileName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_SaveAnim);
            this.Controls.Add(this.TB_Text);
            this.Controls.Add(this.LB_Text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "TypeAnim";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_Text;
        private System.Windows.Forms.TextBox TB_Text;
        private System.Windows.Forms.Button Btn_SaveAnim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_FileName;
        private System.Windows.Forms.Button Btn_View;
        private System.Windows.Forms.FontDialog Dlg_font;
        private System.Windows.Forms.Button Btn_font;
        private System.Windows.Forms.TextBox TB_Font;
    }
}


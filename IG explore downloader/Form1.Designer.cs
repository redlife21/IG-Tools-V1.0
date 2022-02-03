
namespace IG_explore_downloader
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginBtn = new System.Windows.Forms.Button();
            this.usernameTxtBox = new System.Windows.Forms.TextBox();
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            this.postCountNum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.console = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hashtagDownloadBtn = new System.Windows.Forms.Button();
            this.profileDownloadBtn = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.postCountNum)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(18, 155);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(235, 41);
            this.loginBtn.TabIndex = 4;
            this.loginBtn.Text = "Explore Download";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // usernameTxtBox
            // 
            this.usernameTxtBox.Location = new System.Drawing.Point(6, 25);
            this.usernameTxtBox.Name = "usernameTxtBox";
            this.usernameTxtBox.Size = new System.Drawing.Size(235, 26);
            this.usernameTxtBox.TabIndex = 1;
            this.usernameTxtBox.Text = "username";
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.Location = new System.Drawing.Point(6, 57);
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.PasswordChar = 'x';
            this.passwordTxtBox.Size = new System.Drawing.Size(235, 26);
            this.passwordTxtBox.TabIndex = 2;
            this.passwordTxtBox.Text = "password";
            // 
            // postCountNum
            // 
            this.postCountNum.Location = new System.Drawing.Point(121, 89);
            this.postCountNum.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.postCountNum.Name = "postCountNum";
            this.postCountNum.Size = new System.Drawing.Size(120, 26);
            this.postCountNum.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Post Count";
            // 
            // console
            // 
            this.console.FormattingEnabled = true;
            this.console.ItemHeight = 20;
            this.console.Location = new System.Drawing.Point(270, 30);
            this.console.Name = "console";
            this.console.Size = new System.Drawing.Size(392, 324);
            this.console.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.usernameTxtBox);
            this.groupBox1.Controls.Add(this.passwordTxtBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.postCountNum);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 137);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Global Property";
            // 
            // hashtagDownloadBtn
            // 
            this.hashtagDownloadBtn.Location = new System.Drawing.Point(18, 234);
            this.hashtagDownloadBtn.Name = "hashtagDownloadBtn";
            this.hashtagDownloadBtn.Size = new System.Drawing.Size(235, 41);
            this.hashtagDownloadBtn.TabIndex = 9;
            this.hashtagDownloadBtn.Text = "Hashtag Download";
            this.hashtagDownloadBtn.UseVisualStyleBackColor = true;
            // 
            // profileDownloadBtn
            // 
            this.profileDownloadBtn.Location = new System.Drawing.Point(18, 313);
            this.profileDownloadBtn.Name = "profileDownloadBtn";
            this.profileDownloadBtn.Size = new System.Drawing.Size(235, 41);
            this.profileDownloadBtn.TabIndex = 10;
            this.profileDownloadBtn.Text = "Profile Download";
            this.profileDownloadBtn.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(18, 360);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(644, 23);
            this.progressBar1.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 202);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(235, 26);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "Hashtag";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(18, 281);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(235, 26);
            this.textBox2.TabIndex = 13;
            this.textBox2.Text = "Profile Username";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 409);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.profileDownloadBtn);
            this.Controls.Add(this.hashtagDownloadBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.console);
            this.Controls.Add(this.loginBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instagram Post Scrapper (Only Png) By redlfie21";
            ((System.ComponentModel.ISupportInitialize)(this.postCountNum)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox usernameTxtBox;
        private System.Windows.Forms.TextBox passwordTxtBox;
        private System.Windows.Forms.NumericUpDown postCountNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox console;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button hashtagDownloadBtn;
        private System.Windows.Forms.Button profileDownloadBtn;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}


namespace Buttonevent
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdd = new System.Windows.Forms.Button();
            this.rayerPanel = new System.Windows.Forms.Panel();
            this.pic = new System.Windows.Forms.PictureBox();
            this.Delbtn = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Palette = new System.Windows.Forms.Panel();
            this.label_color = new System.Windows.Forms.Label();
            this.pen_btn = new System.Windows.Forms.Button();
            this.era_btn = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(548, 650);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 33);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "追加";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // rayerPanel
            // 
            this.rayerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rayerPanel.AutoScroll = true;
            this.rayerPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rayerPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rayerPanel.Location = new System.Drawing.Point(548, 303);
            this.rayerPanel.Name = "rayerPanel";
            this.rayerPanel.Size = new System.Drawing.Size(243, 341);
            this.rayerPanel.TabIndex = 3;
            // 
            // pic
            // 
            this.pic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pic.BackColor = System.Drawing.Color.White;
            this.pic.Location = new System.Drawing.Point(12, 55);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(512, 628);
            this.pic.TabIndex = 4;
            this.pic.TabStop = false;
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // Delbtn
            // 
            this.Delbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Delbtn.AutoSize = true;
            this.Delbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Delbtn.Location = new System.Drawing.Point(676, 650);
            this.Delbtn.Name = "Delbtn";
            this.Delbtn.Size = new System.Drawing.Size(100, 33);
            this.Delbtn.TabIndex = 5;
            this.Delbtn.Text = "削除";
            this.Delbtn.UseVisualStyleBackColor = false;
            this.Delbtn.Click += new System.EventHandler(this.Delbtn_Click);
            // 
            // Palette
            // 
            this.Palette.BackColor = System.Drawing.Color.White;
            this.Palette.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Palette.Location = new System.Drawing.Point(84, 17);
            this.Palette.Name = "Palette";
            this.Palette.Size = new System.Drawing.Size(137, 30);
            this.Palette.TabIndex = 0;
            this.Palette.Click += new System.EventHandler(this.Palette_Click);
            // 
            // label_color
            // 
            this.label_color.AutoSize = true;
            this.label_color.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_color.Location = new System.Drawing.Point(19, 17);
            this.label_color.Name = "label_color";
            this.label_color.Size = new System.Drawing.Size(59, 22);
            this.label_color.TabIndex = 1;
            this.label_color.Text = "カラー";
            // 
            // pen_btn
            // 
            this.pen_btn.Location = new System.Drawing.Point(15, 69);
            this.pen_btn.Name = "pen_btn";
            this.pen_btn.Size = new System.Drawing.Size(100, 50);
            this.pen_btn.TabIndex = 6;
            this.pen_btn.Text = "ペン";
            this.pen_btn.UseVisualStyleBackColor = true;
            this.pen_btn.Click += new System.EventHandler(this.pen_btn_Click);
            // 
            // era_btn
            // 
            this.era_btn.Location = new System.Drawing.Point(121, 69);
            this.era_btn.Name = "era_btn";
            this.era_btn.Size = new System.Drawing.Size(100, 50);
            this.era_btn.TabIndex = 7;
            this.era_btn.Text = "消しゴム";
            this.era_btn.UseVisualStyleBackColor = true;
            this.era_btn.Click += new System.EventHandler(this.era_btn_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(3, 176);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(182, 69);
            this.trackBar1.TabIndex = 8;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(200, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "1";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Palette);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label_color);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Controls.Add(this.pen_btn);
            this.panel1.Controls.Add(this.era_btn);
            this.panel1.Location = new System.Drawing.Point(548, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 236);
            this.panel1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "太さ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(827, 695);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Delbtn);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.rayerPanel);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel rayerPanel;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button Delbtn;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel Palette;
        private System.Windows.Forms.Label label_color;
        private System.Windows.Forms.Button pen_btn;
        private System.Windows.Forms.Button era_btn;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}


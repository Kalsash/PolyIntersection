﻿namespace PolyIntersection
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.intersectBtn = new System.Windows.Forms.Button();
            this.polygon2RB = new System.Windows.Forms.RadioButton();
            this.polygon1RB = new System.Windows.Forms.RadioButton();
            this.clearBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(16, 115);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1034, 423);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseUp);
            // 
            // intersectBtn
            // 
            this.intersectBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.intersectBtn.Location = new System.Drawing.Point(461, 71);
            this.intersectBtn.Margin = new System.Windows.Forms.Padding(4);
            this.intersectBtn.Name = "intersectBtn";
            this.intersectBtn.Size = new System.Drawing.Size(169, 36);
            this.intersectBtn.TabIndex = 1;
            this.intersectBtn.Text = "Найти";
            this.intersectBtn.UseVisualStyleBackColor = true;
            this.intersectBtn.Click += new System.EventHandler(this.IntersectBtn_Click);
            // 
            // polygon2RB
            // 
            this.polygon2RB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.polygon2RB.AutoSize = true;
            this.polygon2RB.Location = new System.Drawing.Point(639, 15);
            this.polygon2RB.Margin = new System.Windows.Forms.Padding(4);
            this.polygon2RB.Name = "polygon2RB";
            this.polygon2RB.Size = new System.Drawing.Size(133, 20);
            this.polygon2RB.TabIndex = 2;
            this.polygon2RB.TabStop = true;
            this.polygon2RB.Text = "Второй полигон";
            this.polygon2RB.UseVisualStyleBackColor = true;
            this.polygon2RB.CheckedChanged += new System.EventHandler(this.Polygon2RB_CheckedChanged);
            // 
            // polygon1RB
            // 
            this.polygon1RB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.polygon1RB.AutoSize = true;
            this.polygon1RB.Checked = true;
            this.polygon1RB.Location = new System.Drawing.Point(461, 15);
            this.polygon1RB.Margin = new System.Windows.Forms.Padding(4);
            this.polygon1RB.Name = "polygon1RB";
            this.polygon1RB.Size = new System.Drawing.Size(136, 20);
            this.polygon1RB.TabIndex = 2;
            this.polygon1RB.TabStop = true;
            this.polygon1RB.Text = "Первый полигон";
            this.polygon1RB.UseVisualStyleBackColor = true;
            this.polygon1RB.CheckedChanged += new System.EventHandler(this.Polygon1RB_CheckedChanged);
            // 
            // clearBtn
            // 
            this.clearBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearBtn.Location = new System.Drawing.Point(672, 71);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(4);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(100, 36);
            this.clearBtn.TabIndex = 5;
            this.clearBtn.Text = "Очистить";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.polygon1RB);
            this.Controls.Add(this.polygon2RB);
            this.Controls.Add(this.intersectBtn);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Polygon intersection";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button intersectBtn;
        private System.Windows.Forms.RadioButton polygon2RB;
        private System.Windows.Forms.RadioButton polygon1RB;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label label1;
    }
}


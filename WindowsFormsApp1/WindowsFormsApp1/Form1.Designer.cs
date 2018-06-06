﻿using System.Windows.Forms;

namespace WindowsFormsApp1
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
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.findust = new System.Windows.Forms.Label();
            this.uv = new System.Windows.Forms.Label();
            this.temperature = new System.Windows.Forms.Label();
            this.humidity = new System.Windows.Forms.Label();
            this.findusts = new System.Windows.Forms.Label();
            this.uvs = new System.Windows.Forms.Label();
            this.temps = new System.Windows.Forms.Label();
            this.hums = new System.Windows.Forms.Label();
            this.Findustb = new System.Windows.Forms.Label();
            this.uvb = new System.Windows.Forms.Label();
            this.tempb = new System.Windows.Forms.Label();
            this.humb = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // findust
            // 
            this.findust.AutoSize = true;
            this.findust.Font = new System.Drawing.Font("맑은 고딕", 18F);
            this.findust.Location = new System.Drawing.Point(23, 66);
            this.findust.Name = "findust";
            this.findust.Size = new System.Drawing.Size(111, 32);
            this.findust.TabIndex = 1;
            this.findust.Text = "미세먼지";
            // 
            // uv
            // 
            this.uv.AutoSize = true;
            this.uv.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uv.Location = new System.Drawing.Point(34, 148);
            this.uv.Name = "uv";
            this.uv.Size = new System.Drawing.Size(87, 32);
            this.uv.TabIndex = 2;
            this.uv.Text = "자외선";
            // 
            // temperature
            // 
            this.temperature.AutoSize = true;
            this.temperature.Font = new System.Drawing.Font("맑은 고딕", 18F);
            this.temperature.Location = new System.Drawing.Point(46, 226);
            this.temperature.Name = "temperature";
            this.temperature.Size = new System.Drawing.Size(63, 32);
            this.temperature.TabIndex = 3;
            this.temperature.Text = "온도";
            // 
            // humidity
            // 
            this.humidity.AutoSize = true;
            this.humidity.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.humidity.Location = new System.Drawing.Point(46, 304);
            this.humidity.Name = "humidity";
            this.humidity.Size = new System.Drawing.Size(63, 32);
            this.humidity.TabIndex = 4;
            this.humidity.Text = "습도";
            // 
            // findusts
            // 
            this.findusts.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.findusts.Location = new System.Drawing.Point(162, 65);
            this.findusts.Name = "findusts";
            this.findusts.Size = new System.Drawing.Size(111, 32);
            this.findusts.TabIndex = 5;
            this.findusts.Text = "0";
            this.findusts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uvs
            // 
            this.uvs.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uvs.Location = new System.Drawing.Point(171, 148);
            this.uvs.Name = "uvs";
            this.uvs.Size = new System.Drawing.Size(92, 32);
            this.uvs.TabIndex = 6;
            this.uvs.Text = "0";
            this.uvs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // temps
            // 
            this.temps.Font = new System.Drawing.Font("맑은 고딕", 18F);
            this.temps.Location = new System.Drawing.Point(183, 226);
            this.temps.Name = "temps";
            this.temps.Size = new System.Drawing.Size(68, 32);
            this.temps.TabIndex = 7;
            this.temps.Text = "0";
            this.temps.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hums
            // 
            this.hums.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.hums.Location = new System.Drawing.Point(181, 295);
            this.hums.Name = "hums";
            this.hums.Size = new System.Drawing.Size(73, 32);
            this.hums.TabIndex = 8;
            this.hums.Text = "0";
            this.hums.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Findustb
            // 
            this.Findustb.AutoSize = true;
            this.Findustb.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Findustb.Location = new System.Drawing.Point(325, 65);
            this.Findustb.Name = "Findustb";
            this.Findustb.Size = new System.Drawing.Size(63, 32);
            this.Findustb.TabIndex = 9;
            this.Findustb.Text = "좋음";
            // 
            // uvb
            // 
            this.uvb.AutoSize = true;
            this.uvb.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uvb.Location = new System.Drawing.Point(325, 148);
            this.uvb.Name = "uvb";
            this.uvb.Size = new System.Drawing.Size(63, 32);
            this.uvb.TabIndex = 10;
            this.uvb.Text = "좋음";
            // 
            // tempb
            // 
            this.tempb.AutoSize = true;
            this.tempb.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tempb.Location = new System.Drawing.Point(325, 226);
            this.tempb.Name = "tempb";
            this.tempb.Size = new System.Drawing.Size(63, 32);
            this.tempb.TabIndex = 11;
            this.tempb.Text = "좋음";
            // 
            // humb
            // 
            this.humb.AutoSize = true;
            this.humb.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.humb.Location = new System.Drawing.Point(326, 304);
            this.humb.Name = "humb";
            this.humb.Size = new System.Drawing.Size(63, 32);
            this.humb.TabIndex = 12;
            this.humb.Text = "좋음";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("굴림", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(133, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 47);
            this.button1.TabIndex = 13;
            this.button1.Text = "값 갱신";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.humb);
            this.Controls.Add(this.tempb);
            this.Controls.Add(this.uvb);
            this.Controls.Add(this.Findustb);
            this.Controls.Add(this.hums);
            this.Controls.Add(this.temps);
            this.Controls.Add(this.uvs);
            this.Controls.Add(this.findusts);
            this.Controls.Add(this.humidity);
            this.Controls.Add(this.temperature);
            this.Controls.Add(this.uv);
            this.Controls.Add(this.findust);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "  ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label findust;
        private System.Windows.Forms.Label uv;
        private System.Windows.Forms.Label temperature;
        private System.Windows.Forms.Label humidity;
        public System.Windows.Forms.Label findusts;
        public System.Windows.Forms.Label uvs;
        public System.Windows.Forms.Label temps;
        public System.Windows.Forms.Label hums;
        private System.Windows.Forms.Label Findustb;
        private System.Windows.Forms.Label uvb;
        private System.Windows.Forms.Label tempb;
        private System.Windows.Forms.Label humb;
        private Button button1;
    }
}


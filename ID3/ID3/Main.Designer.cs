namespace ID3
{
    partial class Main
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
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnlearn = new System.Windows.Forms.Button();
            this.dgvmain = new System.Windows.Forms.DataGridView();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnloaddata = new System.Windows.Forms.Button();
            this.pnpaint = new System.Windows.Forms.Panel();
            this.pbxpaint = new System.Windows.Forms.PictureBox();
            this.rtxresult = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmain)).BeginInit();
            this.pnpaint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxpaint)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(0, -2);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1353, 101);
            this.label1.TabIndex = 6;
            this.label1.Text = "DECISION TREE LEARNING - ID3 Algorithm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnlearn
            // 
            this.btnlearn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnlearn.ForeColor = System.Drawing.Color.Red;
            this.btnlearn.Location = new System.Drawing.Point(21, 107);
            this.btnlearn.Margin = new System.Windows.Forms.Padding(4);
            this.btnlearn.Name = "btnlearn";
            this.btnlearn.Size = new System.Drawing.Size(122, 54);
            this.btnlearn.TabIndex = 4;
            this.btnlearn.Text = "ID3- Alg";
            this.btnlearn.UseVisualStyleBackColor = true;
            this.btnlearn.Click += new System.EventHandler(this.btnlearn_Click);
            // 
            // dgvmain
            // 
            this.dgvmain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvmain.BackgroundColor = System.Drawing.Color.White;
            this.dgvmain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmain.Location = new System.Drawing.Point(23, 171);
            this.dgvmain.Margin = new System.Windows.Forms.Padding(4);
            this.dgvmain.Name = "dgvmain";
            this.dgvmain.Size = new System.Drawing.Size(560, 190);
            this.dgvmain.TabIndex = 6;
            // 
            // btnnew
            // 
            this.btnnew.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnnew.Location = new System.Drawing.Point(21, 174);
            this.btnnew.Margin = new System.Windows.Forms.Padding(4);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(122, 54);
            this.btnnew.TabIndex = 5;
            this.btnnew.Text = "Reset";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnloaddata
            // 
            this.btnloaddata.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnloaddata.Location = new System.Drawing.Point(21, 41);
            this.btnloaddata.Margin = new System.Windows.Forms.Padding(4);
            this.btnloaddata.Name = "btnloaddata";
            this.btnloaddata.Size = new System.Drawing.Size(122, 54);
            this.btnloaddata.TabIndex = 8;
            this.btnloaddata.Text = "Load Data";
            this.btnloaddata.UseVisualStyleBackColor = true;
            this.btnloaddata.Click += new System.EventHandler(this.btnloaddata_Click);
            // 
            // pnpaint
            // 
            this.pnpaint.AutoScroll = true;
            this.pnpaint.BackColor = System.Drawing.Color.White;
            this.pnpaint.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnpaint.Controls.Add(this.pbxpaint);
            this.pnpaint.Location = new System.Drawing.Point(800, 171);
            this.pnpaint.Margin = new System.Windows.Forms.Padding(4);
            this.pnpaint.Name = "pnpaint";
            this.pnpaint.Size = new System.Drawing.Size(581, 469);
            this.pnpaint.TabIndex = 7;
            // 
            // pbxpaint
            // 
            this.pbxpaint.BackColor = System.Drawing.Color.White;
            this.pbxpaint.Location = new System.Drawing.Point(0, 0);
            this.pbxpaint.Margin = new System.Windows.Forms.Padding(4);
            this.pbxpaint.Name = "pbxpaint";
            this.pbxpaint.Size = new System.Drawing.Size(629, 562);
            this.pbxpaint.TabIndex = 0;
            this.pbxpaint.TabStop = false;
            this.pbxpaint.Paint += new System.Windows.Forms.PaintEventHandler(this.pbxpaint_Paint);
            // 
            // rtxresult
            // 
            this.rtxresult.BackColor = System.Drawing.Color.White;
            this.rtxresult.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rtxresult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rtxresult.Location = new System.Drawing.Point(23, 448);
            this.rtxresult.Margin = new System.Windows.Forms.Padding(4);
            this.rtxresult.Name = "rtxresult";
            this.rtxresult.ReadOnly = true;
            this.rtxresult.Size = new System.Drawing.Size(560, 180);
            this.rtxresult.TabIndex = 0;
            this.rtxresult.Text = "";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.Location = new System.Drawing.Point(21, 241);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 54);
            this.button1.TabIndex = 10;
            this.button1.Text = "About";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Cyan;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(182, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 44);
            this.label2.TabIndex = 11;
            this.label2.Text = "Data Training";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnloaddata);
            this.groupBox1.Controls.Add(this.btnlearn);
            this.groupBox1.Controls.Add(this.btnnew);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(611, 263);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(162, 318);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Cyan;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(937, 112);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 44);
            this.label5.TabIndex = 15;
            this.label5.Text = "Decision Tree";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Cyan;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Magenta;
            this.label3.Location = new System.Drawing.Point(182, 389);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 44);
            this.label3.TabIndex = 16;
            this.label3.Text = "Solutions";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1394, 653);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnpaint);
            this.Controls.Add(this.rtxresult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvmain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "ID3";
            this.Load += new System.EventHandler(this.ID3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmain)).EndInit();
            this.pnpaint.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxpaint)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnlearn;
        private System.Windows.Forms.DataGridView dgvmain;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnloaddata;
        private System.Windows.Forms.Panel pnpaint;
        private System.Windows.Forms.PictureBox pbxpaint;
        private System.Windows.Forms.RichTextBox rtxresult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;

    }
}


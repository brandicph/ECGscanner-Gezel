namespace BinToHex
{
    partial class Converter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Converter));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBinHex = new System.Windows.Forms.Button();
            this.btnHexBin = new System.Windows.Forms.Button();
            this.chkHexIndex = new System.Windows.Forms.CheckBox();
            this.txtHexIndex = new System.Windows.Forms.TextBox();
            this.lblHexIndex = new System.Windows.Forms.Label();
            this.txtHexLength = new System.Windows.Forms.TextBox();
            this.lblHexLength = new System.Windows.Forms.Label();
            this.txtBinLength = new System.Windows.Forms.TextBox();
            this.lblBinLength = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 38);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(725, 153);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "bin";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(12, 243);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(725, 139);
            this.richTextBox2.TabIndex = 3;
            this.richTextBox2.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "hex";
            // 
            // btnBinHex
            // 
            this.btnBinHex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBinHex.Location = new System.Drawing.Point(662, 197);
            this.btnBinHex.Name = "btnBinHex";
            this.btnBinHex.Size = new System.Drawing.Size(75, 23);
            this.btnBinHex.TabIndex = 2;
            this.btnBinHex.Text = "bin > hex";
            this.btnBinHex.UseVisualStyleBackColor = true;
            this.btnBinHex.Click += new System.EventHandler(this.btnBinHex_Click);
            // 
            // btnHexBin
            // 
            this.btnHexBin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHexBin.Location = new System.Drawing.Point(662, 388);
            this.btnHexBin.Name = "btnHexBin";
            this.btnHexBin.Size = new System.Drawing.Size(75, 23);
            this.btnHexBin.TabIndex = 4;
            this.btnHexBin.Text = "hex > bin";
            this.btnHexBin.UseVisualStyleBackColor = true;
            this.btnHexBin.Click += new System.EventHandler(this.btnHexBin_Click);
            // 
            // chkHexIndex
            // 
            this.chkHexIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkHexIndex.AutoSize = true;
            this.chkHexIndex.Checked = true;
            this.chkHexIndex.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHexIndex.Location = new System.Drawing.Point(525, 202);
            this.chkHexIndex.Name = "chkHexIndex";
            this.chkHexIndex.Size = new System.Drawing.Size(15, 14);
            this.chkHexIndex.TabIndex = 5;
            this.chkHexIndex.UseVisualStyleBackColor = true;
            this.chkHexIndex.CheckedChanged += new System.EventHandler(this.chkHexIndex_CheckedChanged);
            // 
            // txtHexIndex
            // 
            this.txtHexIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHexIndex.Location = new System.Drawing.Point(486, 199);
            this.txtHexIndex.Name = "txtHexIndex";
            this.txtHexIndex.Size = new System.Drawing.Size(33, 20);
            this.txtHexIndex.TabIndex = 6;
            this.txtHexIndex.Text = "1";
            // 
            // lblHexIndex
            // 
            this.lblHexIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHexIndex.AutoSize = true;
            this.lblHexIndex.Location = new System.Drawing.Point(431, 202);
            this.lblHexIndex.Name = "lblHexIndex";
            this.lblHexIndex.Size = new System.Drawing.Size(52, 13);
            this.lblHexIndex.TabIndex = 7;
            this.lblHexIndex.Text = "hex index";
            // 
            // txtHexLength
            // 
            this.txtHexLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHexLength.Location = new System.Drawing.Point(615, 199);
            this.txtHexLength.Name = "txtHexLength";
            this.txtHexLength.Size = new System.Drawing.Size(33, 20);
            this.txtHexLength.TabIndex = 6;
            this.txtHexLength.Text = "8";
            // 
            // lblHexLength
            // 
            this.lblHexLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHexLength.AutoSize = true;
            this.lblHexLength.Location = new System.Drawing.Point(556, 202);
            this.lblHexLength.Name = "lblHexLength";
            this.lblHexLength.Size = new System.Drawing.Size(56, 13);
            this.lblHexLength.TabIndex = 7;
            this.lblHexLength.Text = "hex length";
            // 
            // txtBinLength
            // 
            this.txtBinLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBinLength.Location = new System.Drawing.Point(615, 390);
            this.txtBinLength.Name = "txtBinLength";
            this.txtBinLength.Size = new System.Drawing.Size(33, 20);
            this.txtBinLength.TabIndex = 6;
            this.txtBinLength.Text = "32";
            // 
            // lblBinLength
            // 
            this.lblBinLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBinLength.AutoSize = true;
            this.lblBinLength.Location = new System.Drawing.Point(556, 393);
            this.lblBinLength.Name = "lblBinLength";
            this.lblBinLength.Size = new System.Drawing.Size(53, 13);
            this.lblBinLength.TabIndex = 7;
            this.lblBinLength.Text = "bin length";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 429);
            this.Controls.Add(this.lblBinLength);
            this.Controls.Add(this.lblHexLength);
            this.Controls.Add(this.lblHexIndex);
            this.Controls.Add(this.txtBinLength);
            this.Controls.Add(this.txtHexLength);
            this.Controls.Add(this.txtHexIndex);
            this.Controls.Add(this.chkHexIndex);
            this.Controls.Add(this.btnHexBin);
            this.Controls.Add(this.btnBinHex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "BIN <> HEX converter © Alexander Brandi & Mark Seidenschnur developers @ examplex" +
    ".net";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBinHex;
        private System.Windows.Forms.Button btnHexBin;
        private System.Windows.Forms.CheckBox chkHexIndex;
        private System.Windows.Forms.TextBox txtHexIndex;
        private System.Windows.Forms.Label lblHexIndex;
        private System.Windows.Forms.TextBox txtHexLength;
        private System.Windows.Forms.Label lblHexLength;
        private System.Windows.Forms.TextBox txtBinLength;
        private System.Windows.Forms.Label lblBinLength;
    }
}


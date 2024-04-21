namespace NumberSystemOperator
{
    partial class InterFace
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterFace));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_shift = new System.Windows.Forms.Button();
            this.btn_complement = new System.Windows.Forms.Button();
            this.btn_Arithmetic = new System.Windows.Forms.Button();
            this.btn_convert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_shift
            // 
            this.btn_shift.BackgroundImage = global::NumberSystemOperator.Properties.Resources.images;
            this.btn_shift.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_shift.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_shift.Location = new System.Drawing.Point(242, 233);
            this.btn_shift.Name = "btn_shift";
            this.btn_shift.Size = new System.Drawing.Size(209, 196);
            this.btn_shift.TabIndex = 3;
            this.btn_shift.UseVisualStyleBackColor = true;
            this.btn_shift.Click += new System.EventHandler(this.btn_shift_Click);
            this.btn_shift.MouseHover += new System.EventHandler(this.btn_shift_MouseHover);
            // 
            // btn_complement
            // 
            this.btn_complement.BackgroundImage = global::NumberSystemOperator.Properties.Resources.complements;
            this.btn_complement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_complement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_complement.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_complement.Location = new System.Drawing.Point(12, 231);
            this.btn_complement.Name = "btn_complement";
            this.btn_complement.Size = new System.Drawing.Size(209, 196);
            this.btn_complement.TabIndex = 2;
            this.btn_complement.UseVisualStyleBackColor = true;
            this.btn_complement.Click += new System.EventHandler(this.btn_complement_Click);
            this.btn_complement.MouseHover += new System.EventHandler(this.btn_complement_MouseHover);
            // 
            // btn_Arithmetic
            // 
            this.btn_Arithmetic.BackgroundImage = global::NumberSystemOperator.Properties.Resources.mats;
            this.btn_Arithmetic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Arithmetic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Arithmetic.Location = new System.Drawing.Point(242, 12);
            this.btn_Arithmetic.Name = "btn_Arithmetic";
            this.btn_Arithmetic.Size = new System.Drawing.Size(209, 196);
            this.btn_Arithmetic.TabIndex = 1;
            this.btn_Arithmetic.UseVisualStyleBackColor = true;
            this.btn_Arithmetic.Click += new System.EventHandler(this.btn_Arithmetic_Click);
            this.btn_Arithmetic.MouseHover += new System.EventHandler(this.btn_Arithmetic_MouseHover);
            // 
            // btn_convert
            // 
            this.btn_convert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.btn_convert.BackgroundImage = global::NumberSystemOperator.Properties.Resources.output;
            this.btn_convert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_convert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_convert.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_convert.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_convert.Location = new System.Drawing.Point(12, 12);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(209, 196);
            this.btn_convert.TabIndex = 0;
            this.btn_convert.UseVisualStyleBackColor = false;
            this.btn_convert.Click += new System.EventHandler(this.btn_convert_Click);
            this.btn_convert.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // InterFace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(463, 441);
            this.Controls.Add(this.btn_shift);
            this.Controls.Add(this.btn_complement);
            this.Controls.Add(this.btn_Arithmetic);
            this.Controls.Add(this.btn_convert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InterFace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multi-Functional Tools with Number Systems";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Arithmetic;
        private System.Windows.Forms.Button btn_convert;
        private System.Windows.Forms.Button btn_complement;
        private System.Windows.Forms.Button btn_shift;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}


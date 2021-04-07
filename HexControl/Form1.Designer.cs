
namespace Hex_Control
{
    partial class RotationLength
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
            this.LinearLength = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ActLength = new System.Windows.Forms.TextBox();
            this.RotPulses = new System.Windows.Forms.TextBox();
            this.PulseperRotations = new System.Windows.Forms.Label();
            this.RotLength = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sendCom = new System.Windows.Forms.Button();
            this.retOrigin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LinearLength
            // 
            this.LinearLength.AutoSize = true;
            this.LinearLength.Location = new System.Drawing.Point(26, 33);
            this.LinearLength.Name = "LinearLength";
            this.LinearLength.Size = new System.Drawing.Size(155, 20);
            this.LinearLength.TabIndex = 0;
            this.LinearLength.Text = "Actuator Length (mm)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(2294, 206);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 27);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(2308, 213);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(244, 27);
            this.textBox2.TabIndex = 2;
            // 
            // ActLength
            // 
            this.ActLength.Location = new System.Drawing.Point(187, 29);
            this.ActLength.Name = "ActLength";
            this.ActLength.Size = new System.Drawing.Size(125, 27);
            this.ActLength.TabIndex = 3;
            this.ActLength.TextChanged += new System.EventHandler(this.ActLength_TextChanged);
            // 
            // RotPulses
            // 
            this.RotPulses.Location = new System.Drawing.Point(187, 95);
            this.RotPulses.Name = "RotPulses";
            this.RotPulses.Size = new System.Drawing.Size(125, 27);
            this.RotPulses.TabIndex = 5;
            // 
            // PulseperRotations
            // 
            this.PulseperRotations.AutoSize = true;
            this.PulseperRotations.Location = new System.Drawing.Point(26, 99);
            this.PulseperRotations.Name = "PulseperRotations";
            this.PulseperRotations.Size = new System.Drawing.Size(112, 20);
            this.PulseperRotations.TabIndex = 4;
            this.PulseperRotations.Text = "Pulses/Rotation";
            this.PulseperRotations.Click += new System.EventHandler(this.label1_Click);
            // 
            // RotLength
            // 
            this.RotLength.Location = new System.Drawing.Point(187, 62);
            this.RotLength.Name = "RotLength";
            this.RotLength.Size = new System.Drawing.Size(125, 27);
            this.RotLength.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Rotation Length (mm)";
            // 
            // sendCom
            // 
            this.sendCom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sendCom.Location = new System.Drawing.Point(482, 409);
            this.sendCom.Name = "sendCom";
            this.sendCom.Size = new System.Drawing.Size(144, 29);
            this.sendCom.TabIndex = 8;
            this.sendCom.Text = "Send Command";
            this.sendCom.UseVisualStyleBackColor = true;
            // 
            // retOrigin
            // 
            this.retOrigin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.retOrigin.Location = new System.Drawing.Point(644, 409);
            this.retOrigin.Name = "retOrigin";
            this.retOrigin.Size = new System.Drawing.Size(144, 29);
            this.retOrigin.TabIndex = 9;
            this.retOrigin.Text = "Return to Origin";
            this.retOrigin.UseVisualStyleBackColor = true;
            // 
            // RotationLength
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.retOrigin);
            this.Controls.Add(this.sendCom);
            this.Controls.Add(this.RotLength);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RotPulses);
            this.Controls.Add(this.PulseperRotations);
            this.Controls.Add(this.ActLength);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LinearLength);
            this.Name = "RotationLength";
            this.Text = "MD BOX C#";
            this.Load += new System.EventHandler(this.RotationLength_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LinearLength;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox ActLength;
        private System.Windows.Forms.TextBox RotPulses;
        private System.Windows.Forms.Label PulseperRotations;
        private System.Windows.Forms.TextBox RotLength;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sendCom;
        private System.Windows.Forms.Button retOrigin;
    }
}


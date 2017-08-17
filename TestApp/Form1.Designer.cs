namespace TestApp
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
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtCom = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnW = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.btnDisarm = new System.Windows.Forms.Button();
            this.btnArm = new System.Windows.Forms.Button();
            this.btnArmA = new System.Windows.Forms.Button();
            this.btnArmB = new System.Windows.Forms.Button();
            this.btnArmABC = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPIN = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "COM port:";
            // 
            // txtCom
            // 
            this.txtCom.Location = new System.Drawing.Point(73, 6);
            this.txtCom.Name = "txtCom";
            this.txtCom.Size = new System.Drawing.Size(100, 20);
            this.txtCom.TabIndex = 1;
            this.txtCom.Text = "COM1";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(15, 32);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(204, 13);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(13, 13);
            this.lblMessage.TabIndex = 3;
            this.lblMessage.Text = "?";
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Location = new System.Drawing.Point(12, 73);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(10, 13);
            this.lblDisplay.TabIndex = 4;
            this.lblDisplay.Text = "-";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(98, 32);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnW
            // 
            this.btnW.Location = new System.Drawing.Point(15, 101);
            this.btnW.Name = "btnW";
            this.btnW.Size = new System.Drawing.Size(28, 23);
            this.btnW.TabIndex = 6;
            this.btnW.Text = "W";
            this.btnW.UseVisualStyleBackColor = true;
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(117, 101);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(28, 23);
            this.btnC.TabIndex = 7;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            // 
            // btnB
            // 
            this.btnB.Location = new System.Drawing.Point(83, 101);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(28, 23);
            this.btnB.TabIndex = 8;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = true;
            // 
            // btnA
            // 
            this.btnA.Location = new System.Drawing.Point(49, 101);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(28, 23);
            this.btnA.TabIndex = 9;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = true;
            // 
            // btnDisarm
            // 
            this.btnDisarm.Location = new System.Drawing.Point(15, 146);
            this.btnDisarm.Name = "btnDisarm";
            this.btnDisarm.Size = new System.Drawing.Size(130, 23);
            this.btnDisarm.TabIndex = 10;
            this.btnDisarm.Text = "Disarm";
            this.btnDisarm.UseVisualStyleBackColor = true;
            this.btnDisarm.Click += new System.EventHandler(this.btnDisarm_Click);
            // 
            // btnArm
            // 
            this.btnArm.Location = new System.Drawing.Point(15, 175);
            this.btnArm.Name = "btnArm";
            this.btnArm.Size = new System.Drawing.Size(130, 23);
            this.btnArm.TabIndex = 11;
            this.btnArm.Text = "Arm";
            this.btnArm.UseVisualStyleBackColor = true;
            this.btnArm.Click += new System.EventHandler(this.btnArm_Click);
            // 
            // btnArmA
            // 
            this.btnArmA.Location = new System.Drawing.Point(15, 204);
            this.btnArmA.Name = "btnArmA";
            this.btnArmA.Size = new System.Drawing.Size(130, 23);
            this.btnArmA.TabIndex = 12;
            this.btnArmA.Text = "Arm A";
            this.btnArmA.UseVisualStyleBackColor = true;
            this.btnArmA.Click += new System.EventHandler(this.btnArmA_Click);
            // 
            // btnArmB
            // 
            this.btnArmB.Location = new System.Drawing.Point(15, 233);
            this.btnArmB.Name = "btnArmB";
            this.btnArmB.Size = new System.Drawing.Size(130, 23);
            this.btnArmB.TabIndex = 13;
            this.btnArmB.Text = "Arm B";
            this.btnArmB.UseVisualStyleBackColor = true;
            this.btnArmB.Click += new System.EventHandler(this.btnArmB_Click);
            // 
            // btnArmABC
            // 
            this.btnArmABC.Location = new System.Drawing.Point(15, 262);
            this.btnArmABC.Name = "btnArmABC";
            this.btnArmABC.Size = new System.Drawing.Size(130, 23);
            this.btnArmABC.TabIndex = 14;
            this.btnArmABC.Text = "Arm ABC";
            this.btnArmABC.UseVisualStyleBackColor = true;
            this.btnArmABC.Click += new System.EventHandler(this.btnArmABC_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "PIN:";
            // 
            // txtPIN
            // 
            this.txtPIN.Location = new System.Drawing.Point(45, 294);
            this.txtPIN.Name = "txtPIN";
            this.txtPIN.Size = new System.Drawing.Size(100, 20);
            this.txtPIN.TabIndex = 16;
            this.txtPIN.Text = "1234";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 328);
            this.Controls.Add(this.txtPIN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnArmABC);
            this.Controls.Add(this.btnArmB);
            this.Controls.Add(this.btnArmA);
            this.Controls.Add(this.btnArm);
            this.Controls.Add(this.btnDisarm);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnW);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.txtCom);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "JaLibrary TEST app";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCom;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnW;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnDisarm;
        private System.Windows.Forms.Button btnArm;
        private System.Windows.Forms.Button btnArmA;
        private System.Windows.Forms.Button btnArmB;
        private System.Windows.Forms.Button btnArmABC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPIN;
    }
}


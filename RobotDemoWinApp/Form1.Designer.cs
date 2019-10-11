using System;

namespace RobotDemoWinApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelCoordinateX = new System.Windows.Forms.Label();
            this.labelCoordinateY = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelDirection = new System.Windows.Forms.Label();
            this.groupBoxEnters = new System.Windows.Forms.GroupBox();
            this.labelDirectionInfo = new System.Windows.Forms.Label();
            this.groupBoxControls = new System.Windows.Forms.GroupBox();
            this.buttonTurnRight = new System.Windows.Forms.Button();
            this.buttonMove = new System.Windows.Forms.Button();
            this.buttonTurnLeft = new System.Windows.Forms.Button();
            this.HelpBtn = new System.Windows.Forms.Button();
            this.groupBoxEnters.SuspendLayout();
            this.groupBoxControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 55);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(96, 95);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(72, 194);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(76, 23);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelCoordinateX
            // 
            this.labelCoordinateX.AutoSize = true;
            this.labelCoordinateX.Location = new System.Drawing.Point(6, 58);
            this.labelCoordinateX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCoordinateX.Name = "labelCoordinateX";
            this.labelCoordinateX.Size = new System.Drawing.Size(68, 13);
            this.labelCoordinateX.TabIndex = 3;
            this.labelCoordinateX.Text = "Coordinate X";
            // 
            // labelCoordinateY
            // 
            this.labelCoordinateY.AutoSize = true;
            this.labelCoordinateY.Location = new System.Drawing.Point(6, 95);
            this.labelCoordinateY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCoordinateY.Name = "labelCoordinateY";
            this.labelCoordinateY.Size = new System.Drawing.Size(68, 13);
            this.labelCoordinateY.TabIndex = 4;
            this.labelCoordinateY.Text = "Coordinate Y";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "East",
            "West",
            "South",
            "North"});
            this.comboBox1.Location = new System.Drawing.Point(96, 131);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // labelDirection
            // 
            this.labelDirection.AutoSize = true;
            this.labelDirection.Location = new System.Drawing.Point(6, 139);
            this.labelDirection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDirection.Name = "labelDirection";
            this.labelDirection.Size = new System.Drawing.Size(88, 13);
            this.labelDirection.TabIndex = 6;
            this.labelDirection.Text = "Choose Direction";
            // 
            // groupBoxEnters
            // 
            this.groupBoxEnters.BackColor = System.Drawing.Color.White;
            this.groupBoxEnters.Controls.Add(this.buttonStart);
            this.groupBoxEnters.Controls.Add(this.labelDirection);
            this.groupBoxEnters.Controls.Add(this.textBox2);
            this.groupBoxEnters.Controls.Add(this.comboBox1);
            this.groupBoxEnters.Controls.Add(this.textBox1);
            this.groupBoxEnters.Controls.Add(this.labelCoordinateY);
            this.groupBoxEnters.Controls.Add(this.labelCoordinateX);
            this.groupBoxEnters.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBoxEnters.Location = new System.Drawing.Point(565, 21);
            this.groupBoxEnters.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxEnters.Name = "groupBoxEnters";
            this.groupBoxEnters.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxEnters.Size = new System.Drawing.Size(211, 265);
            this.groupBoxEnters.TabIndex = 7;
            this.groupBoxEnters.TabStop = false;
            this.groupBoxEnters.Text = "STARTING POSITION";
            // 
            // labelDirectionInfo
            // 
            this.labelDirectionInfo.AutoSize = true;
            this.labelDirectionInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDirectionInfo.ForeColor = System.Drawing.Color.DarkRed;
            this.labelDirectionInfo.Location = new System.Drawing.Point(167, 504);
            this.labelDirectionInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDirectionInfo.Name = "labelDirectionInfo";
            this.labelDirectionInfo.Size = new System.Drawing.Size(0, 25);
            this.labelDirectionInfo.TabIndex = 8;
            // 
            // groupBoxControls
            // 
            this.groupBoxControls.Controls.Add(this.buttonTurnRight);
            this.groupBoxControls.Controls.Add(this.buttonMove);
            this.groupBoxControls.Controls.Add(this.buttonTurnLeft);
            this.groupBoxControls.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBoxControls.Location = new System.Drawing.Point(565, 305);
            this.groupBoxControls.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxControls.Name = "groupBoxControls";
            this.groupBoxControls.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxControls.Size = new System.Drawing.Size(211, 100);
            this.groupBoxControls.TabIndex = 9;
            this.groupBoxControls.TabStop = false;
            this.groupBoxControls.Visible = false;
            // 
            // buttonTurnRight
            // 
            this.buttonTurnRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTurnRight.Location = new System.Drawing.Point(107, 48);
            this.buttonTurnRight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonTurnRight.Name = "buttonTurnRight";
            this.buttonTurnRight.Size = new System.Drawing.Size(104, 52);
            this.buttonTurnRight.TabIndex = 1;
            this.buttonTurnRight.Text = "Turn Right";
            this.buttonTurnRight.UseVisualStyleBackColor = true;
            this.buttonTurnRight.Click += new System.EventHandler(this.buttonTurnRight_Click);
            // 
            // buttonMove
            // 
            this.buttonMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMove.Location = new System.Drawing.Point(0, 0);
            this.buttonMove.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(211, 52);
            this.buttonMove.TabIndex = 2;
            this.buttonMove.Text = "Move";
            this.buttonMove.UseVisualStyleBackColor = true;
            this.buttonMove.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonTurnLeft
            // 
            this.buttonTurnLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTurnLeft.Location = new System.Drawing.Point(0, 48);
            this.buttonTurnLeft.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonTurnLeft.Name = "buttonTurnLeft";
            this.buttonTurnLeft.Size = new System.Drawing.Size(111, 52);
            this.buttonTurnLeft.TabIndex = 0;
            this.buttonTurnLeft.Text = "Turn Left";
            this.buttonTurnLeft.UseVisualStyleBackColor = true;
            this.buttonTurnLeft.Click += new System.EventHandler(this.buttonTurnLeft_Click);
            // 
            // HelpBtn
            // 
            this.HelpBtn.ForeColor = System.Drawing.Color.DarkBlue;
            this.HelpBtn.Location = new System.Drawing.Point(622, 458);
            this.HelpBtn.Name = "HelpBtn";
            this.HelpBtn.Size = new System.Drawing.Size(104, 40);
            this.HelpBtn.TabIndex = 10;
            this.HelpBtn.Text = "HELP";
            this.HelpBtn.UseVisualStyleBackColor = true;
            this.HelpBtn.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 537);
            this.Controls.Add(this.groupBoxEnters);
            this.Controls.Add(this.HelpBtn);
            this.Controls.Add(this.groupBoxControls);
            this.Controls.Add(this.labelDirectionInfo);
            this.ForeColor = System.Drawing.Color.SaddleBrown;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Robot";
            this.groupBoxEnters.ResumeLayout(false);
            this.groupBoxEnters.PerformLayout();
            this.groupBoxControls.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelCoordinateX;
        private System.Windows.Forms.Label labelCoordinateY;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelDirection;
        private System.Windows.Forms.GroupBox groupBoxEnters;
        private System.Windows.Forms.Label labelDirectionInfo;
        private System.Windows.Forms.GroupBox groupBoxControls;
        private System.Windows.Forms.Button buttonMove;
        private System.Windows.Forms.Button buttonTurnRight;
        private System.Windows.Forms.Button buttonTurnLeft;
        private System.Windows.Forms.Button HelpBtn;
    }
}


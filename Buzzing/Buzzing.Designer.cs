namespace Buzzing
{
    partial class Buzzing
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
            this.btnDamageBees = new System.Windows.Forms.Button();
            this.flpQueenBees = new System.Windows.Forms.FlowLayoutPanel();
            this.flpDroneBees = new System.Windows.Forms.FlowLayoutPanel();
            this.flpWorkerBees = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btnDamageBees
            // 
            this.btnDamageBees.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDamageBees.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDamageBees.Location = new System.Drawing.Point(1151, 521);
            this.btnDamageBees.Name = "btnDamageBees";
            this.btnDamageBees.Size = new System.Drawing.Size(213, 65);
            this.btnDamageBees.TabIndex = 0;
            this.btnDamageBees.Text = "Damage Bees";
            this.btnDamageBees.UseVisualStyleBackColor = true;
            this.btnDamageBees.Click += new System.EventHandler(this.btnDamageBee_Click);
            // 
            // flpQueenBees
            // 
            this.flpQueenBees.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpQueenBees.Location = new System.Drawing.Point(12, 12);
            this.flpQueenBees.Name = "flpQueenBees";
            this.flpQueenBees.Size = new System.Drawing.Size(1900, 160);
            this.flpQueenBees.TabIndex = 1;
            // 
            // flpDroneBees
            // 
            this.flpDroneBees.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpDroneBees.Location = new System.Drawing.Point(12, 184);
            this.flpDroneBees.Name = "flpDroneBees";
            this.flpDroneBees.Size = new System.Drawing.Size(1900, 160);
            this.flpDroneBees.TabIndex = 2;
            // 
            // flpWorkerBees
            // 
            this.flpWorkerBees.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpWorkerBees.Location = new System.Drawing.Point(12, 355);
            this.flpWorkerBees.Name = "flpWorkerBees";
            this.flpWorkerBees.Size = new System.Drawing.Size(1900, 160);
            this.flpWorkerBees.TabIndex = 3;
            // 
            // Buzzing
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1924, 593);
            this.Controls.Add(this.flpWorkerBees);
            this.Controls.Add(this.flpDroneBees);
            this.Controls.Add(this.flpQueenBees);
            this.Controls.Add(this.btnDamageBees);
            this.Name = "Buzzing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buzzing";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDamageBees;
        private System.Windows.Forms.FlowLayoutPanel flpQueenBees;
        private System.Windows.Forms.FlowLayoutPanel flpDroneBees;
        private System.Windows.Forms.FlowLayoutPanel flpWorkerBees;
    }
}


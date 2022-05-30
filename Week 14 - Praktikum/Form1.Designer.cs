
namespace Week_14___Praktikum
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
            this.btnLeftEnd = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnRightEnd = new System.Windows.Forms.Button();
            this.lblTeamName = new System.Windows.Forms.Label();
            this.lblManager = new System.Windows.Forms.Label();
            this.lblStadium = new System.Windows.Forms.Label();
            this.lblTopScorer = new System.Windows.Forms.Label();
            this.lblWorseDis = new System.Windows.Forms.Label();
            this.lblTN = new System.Windows.Forms.Label();
            this.lblMgr = new System.Windows.Forms.Label();
            this.lblStd = new System.Windows.Forms.Label();
            this.lblTS = new System.Windows.Forms.Label();
            this.lblWD = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLeftEnd
            // 
            this.btnLeftEnd.Location = new System.Drawing.Point(89, 25);
            this.btnLeftEnd.Name = "btnLeftEnd";
            this.btnLeftEnd.Size = new System.Drawing.Size(75, 40);
            this.btnLeftEnd.TabIndex = 0;
            this.btnLeftEnd.Text = "<<";
            this.btnLeftEnd.UseVisualStyleBackColor = true;
            this.btnLeftEnd.Click += new System.EventHandler(this.btnLeftEnd_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(195, 25);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 40);
            this.btnLeft.TabIndex = 1;
            this.btnLeft.Text = "<";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(306, 25);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 40);
            this.btnRight.TabIndex = 2;
            this.btnRight.Text = ">";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnRightEnd
            // 
            this.btnRightEnd.Location = new System.Drawing.Point(417, 25);
            this.btnRightEnd.Name = "btnRightEnd";
            this.btnRightEnd.Size = new System.Drawing.Size(75, 40);
            this.btnRightEnd.TabIndex = 3;
            this.btnRightEnd.Text = ">>";
            this.btnRightEnd.UseVisualStyleBackColor = true;
            this.btnRightEnd.Click += new System.EventHandler(this.btnRightEnd_Click);
            // 
            // lblTeamName
            // 
            this.lblTeamName.AutoSize = true;
            this.lblTeamName.Location = new System.Drawing.Point(89, 101);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(103, 20);
            this.lblTeamName.TabIndex = 4;
            this.lblTeamName.Text = "Team Name :";
            // 
            // lblManager
            // 
            this.lblManager.AutoSize = true;
            this.lblManager.Location = new System.Drawing.Point(112, 138);
            this.lblManager.Name = "lblManager";
            this.lblManager.Size = new System.Drawing.Size(80, 20);
            this.lblManager.TabIndex = 5;
            this.lblManager.Text = "Manager :";
            // 
            // lblStadium
            // 
            this.lblStadium.AutoSize = true;
            this.lblStadium.Location = new System.Drawing.Point(112, 177);
            this.lblStadium.Name = "lblStadium";
            this.lblStadium.Size = new System.Drawing.Size(76, 20);
            this.lblStadium.TabIndex = 6;
            this.lblStadium.Text = "Stadium :";
            // 
            // lblTopScorer
            // 
            this.lblTopScorer.AutoSize = true;
            this.lblTopScorer.Location = new System.Drawing.Point(93, 215);
            this.lblTopScorer.Name = "lblTopScorer";
            this.lblTopScorer.Size = new System.Drawing.Size(95, 20);
            this.lblTopScorer.TabIndex = 7;
            this.lblTopScorer.Text = "Top Sorcer :";
            // 
            // lblWorseDis
            // 
            this.lblWorseDis.AutoSize = true;
            this.lblWorseDis.Location = new System.Drawing.Point(54, 249);
            this.lblWorseDis.Name = "lblWorseDis";
            this.lblWorseDis.Size = new System.Drawing.Size(134, 20);
            this.lblWorseDis.TabIndex = 8;
            this.lblWorseDis.Text = "Worse Discipline :";
            // 
            // lblTN
            // 
            this.lblTN.AutoSize = true;
            this.lblTN.Location = new System.Drawing.Point(216, 100);
            this.lblTN.Name = "lblTN";
            this.lblTN.Size = new System.Drawing.Size(21, 20);
            this.lblTN.TabIndex = 9;
            this.lblTN.Text = "...";
            // 
            // lblMgr
            // 
            this.lblMgr.AutoSize = true;
            this.lblMgr.Location = new System.Drawing.Point(216, 138);
            this.lblMgr.Name = "lblMgr";
            this.lblMgr.Size = new System.Drawing.Size(21, 20);
            this.lblMgr.TabIndex = 10;
            this.lblMgr.Text = "...";
            // 
            // lblStd
            // 
            this.lblStd.AutoSize = true;
            this.lblStd.Location = new System.Drawing.Point(216, 177);
            this.lblStd.Name = "lblStd";
            this.lblStd.Size = new System.Drawing.Size(21, 20);
            this.lblStd.TabIndex = 11;
            this.lblStd.Text = "...";
            // 
            // lblTS
            // 
            this.lblTS.AutoSize = true;
            this.lblTS.Location = new System.Drawing.Point(216, 215);
            this.lblTS.Name = "lblTS";
            this.lblTS.Size = new System.Drawing.Size(21, 20);
            this.lblTS.TabIndex = 12;
            this.lblTS.Text = "...";
            // 
            // lblWD
            // 
            this.lblWD.AutoSize = true;
            this.lblWD.Location = new System.Drawing.Point(216, 249);
            this.lblWD.Name = "lblWD";
            this.lblWD.Size = new System.Drawing.Size(21, 20);
            this.lblWD.TabIndex = 13;
            this.lblWD.Text = "...";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 296);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(648, 203);
            this.dataGridView1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblWD);
            this.Controls.Add(this.lblTS);
            this.Controls.Add(this.lblStd);
            this.Controls.Add(this.lblMgr);
            this.Controls.Add(this.lblTN);
            this.Controls.Add(this.lblWorseDis);
            this.Controls.Add(this.lblTopScorer);
            this.Controls.Add(this.lblStadium);
            this.Controls.Add(this.lblManager);
            this.Controls.Add(this.lblTeamName);
            this.Controls.Add(this.btnRightEnd);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnLeftEnd);
            this.Name = "Form1";
            this.Text = "Team";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLeftEnd;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnRightEnd;
        private System.Windows.Forms.Label lblTeamName;
        private System.Windows.Forms.Label lblManager;
        private System.Windows.Forms.Label lblStadium;
        private System.Windows.Forms.Label lblTopScorer;
        private System.Windows.Forms.Label lblWorseDis;
        private System.Windows.Forms.Label lblTN;
        private System.Windows.Forms.Label lblMgr;
        private System.Windows.Forms.Label lblStd;
        private System.Windows.Forms.Label lblTS;
        private System.Windows.Forms.Label lblWD;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}


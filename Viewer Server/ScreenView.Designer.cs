namespace Viewer_Server
{
    partial class ScreenView
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
            this.pbDesktop1 = new System.Windows.Forms.PictureBox();
            this.pbDesktop2 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pbDesktop4 = new System.Windows.Forms.PictureBox();
            this.pbDesktop3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbDesktop1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDesktop2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDesktop4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDesktop3)).BeginInit();
            this.SuspendLayout();
            // 
            // pbDesktop1
            // 
            this.pbDesktop1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbDesktop1.Location = new System.Drawing.Point(3, 3);
            this.pbDesktop1.Name = "pbDesktop1";
            this.pbDesktop1.Size = new System.Drawing.Size(612, 312);
            this.pbDesktop1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDesktop1.TabIndex = 0;
            this.pbDesktop1.TabStop = false;
            // 
            // pbDesktop2
            // 
            this.pbDesktop2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbDesktop2.Location = new System.Drawing.Point(621, 3);
            this.pbDesktop2.Name = "pbDesktop2";
            this.pbDesktop2.Size = new System.Drawing.Size(616, 312);
            this.pbDesktop2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDesktop2.TabIndex = 1;
            this.pbDesktop2.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.pbDesktop4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pbDesktop3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pbDesktop1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pbDesktop2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1240, 637);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // pbDesktop4
            // 
            this.pbDesktop4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbDesktop4.Location = new System.Drawing.Point(621, 321);
            this.pbDesktop4.Name = "pbDesktop4";
            this.pbDesktop4.Size = new System.Drawing.Size(616, 313);
            this.pbDesktop4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDesktop4.TabIndex = 3;
            this.pbDesktop4.TabStop = false;
            // 
            // pbDesktop3
            // 
            this.pbDesktop3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbDesktop3.Location = new System.Drawing.Point(3, 321);
            this.pbDesktop3.Name = "pbDesktop3";
            this.pbDesktop3.Size = new System.Drawing.Size(612, 313);
            this.pbDesktop3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDesktop3.TabIndex = 2;
            this.pbDesktop3.TabStop = false;
            // 
            // ScreenView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 680);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "ScreenView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Screen View";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbDesktop1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDesktop2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbDesktop4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDesktop3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbDesktop1;
        private System.Windows.Forms.PictureBox pbDesktop2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pbDesktop4;
        private System.Windows.Forms.PictureBox pbDesktop3;
    }
}
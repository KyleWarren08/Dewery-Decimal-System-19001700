
namespace Dewery_Decimal_System_19001700
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
            this.btnReplacingBooks = new System.Windows.Forms.Button();
            this.btnIdentifyingAreas = new System.Windows.Forms.Button();
            this.btnFindingCallNumbers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReplacingBooks
            // 
            this.btnReplacingBooks.BackgroundImage = global::Dewery_Decimal_System_19001700.Properties.Resources.Light_greean_air_no_water_mark;
            this.btnReplacingBooks.Location = new System.Drawing.Point(48, 158);
            this.btnReplacingBooks.Name = "btnReplacingBooks";
            this.btnReplacingBooks.Size = new System.Drawing.Size(229, 210);
            this.btnReplacingBooks.TabIndex = 0;
            this.btnReplacingBooks.Text = "Replacing books";
            this.btnReplacingBooks.UseVisualStyleBackColor = true;
            this.btnReplacingBooks.Click += new System.EventHandler(this.btnReplacingBooks_Click);
            // 
            // btnIdentifyingAreas
            // 
            this.btnIdentifyingAreas.BackgroundImage = global::Dewery_Decimal_System_19001700.Properties.Resources.Light_greean_air_no_water_mark;
            this.btnIdentifyingAreas.Location = new System.Drawing.Point(327, 158);
            this.btnIdentifyingAreas.Name = "btnIdentifyingAreas";
            this.btnIdentifyingAreas.Size = new System.Drawing.Size(229, 210);
            this.btnIdentifyingAreas.TabIndex = 1;
            this.btnIdentifyingAreas.Text = "Identifying areas";
            this.btnIdentifyingAreas.UseVisualStyleBackColor = true;
            this.btnIdentifyingAreas.Click += new System.EventHandler(this.btnIdentifyingAreas_Click);
            // 
            // btnFindingCallNumbers
            // 
            this.btnFindingCallNumbers.Image = global::Dewery_Decimal_System_19001700.Properties.Resources.Light_greean_air_no_water_mark;
            this.btnFindingCallNumbers.Location = new System.Drawing.Point(601, 158);
            this.btnFindingCallNumbers.Name = "btnFindingCallNumbers";
            this.btnFindingCallNumbers.Size = new System.Drawing.Size(229, 210);
            this.btnFindingCallNumbers.TabIndex = 2;
            this.btnFindingCallNumbers.Text = "Finding call numbers";
            this.btnFindingCallNumbers.UseVisualStyleBackColor = true;
            this.btnFindingCallNumbers.Click += new System.EventHandler(this.btnFindingCallNumbers_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Dewery_Decimal_System_19001700.Properties.Resources.Breath_of_fresh_air;
            this.ClientSize = new System.Drawing.Size(875, 536);
            this.Controls.Add(this.btnFindingCallNumbers);
            this.Controls.Add(this.btnIdentifyingAreas);
            this.Controls.Add(this.btnReplacingBooks);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Dewery\'s Decimal Books";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReplacingBooks;
        private System.Windows.Forms.Button btnIdentifyingAreas;
        private System.Windows.Forms.Button btnFindingCallNumbers;
    }
}


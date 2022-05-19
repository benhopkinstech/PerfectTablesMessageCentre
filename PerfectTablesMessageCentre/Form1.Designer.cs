namespace PerfectTablesMessageCentre
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblSavedResponses = new System.Windows.Forms.Label();
            this.btnAddResponse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSavedResponses
            // 
            this.lblSavedResponses.AutoSize = true;
            this.lblSavedResponses.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSavedResponses.Location = new System.Drawing.Point(12, 48);
            this.lblSavedResponses.Name = "lblSavedResponses";
            this.lblSavedResponses.Size = new System.Drawing.Size(110, 17);
            this.lblSavedResponses.TabIndex = 0;
            this.lblSavedResponses.Text = "Saved Responses";
            // 
            // btnAddResponse
            // 
            this.btnAddResponse.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddResponse.Location = new System.Drawing.Point(12, 14);
            this.btnAddResponse.Name = "btnAddResponse";
            this.btnAddResponse.Size = new System.Drawing.Size(383, 31);
            this.btnAddResponse.TabIndex = 1;
            this.btnAddResponse.Text = "Add a Response";
            this.btnAddResponse.UseVisualStyleBackColor = true;
            this.btnAddResponse.Click += new System.EventHandler(this.btnAddResponse_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(407, 77);
            this.Controls.Add(this.btnAddResponse);
            this.Controls.Add(this.lblSavedResponses);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Perfect Tables Message Centre";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblSavedResponses;
        private Button btnAddResponse;
    }
}
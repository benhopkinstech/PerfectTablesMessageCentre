namespace PerfectTablesMessageCentre
{
    partial class frmEditResponse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditResponse));
            this.btnUpdateResponse = new System.Windows.Forms.Button();
            this.lblResponse = new System.Windows.Forms.Label();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.txtResponseTitle = new System.Windows.Forms.TextBox();
            this.lblResponseTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpdateResponse
            // 
            this.btnUpdateResponse.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateResponse.Location = new System.Drawing.Point(10, 245);
            this.btnUpdateResponse.Name = "btnUpdateResponse";
            this.btnUpdateResponse.Size = new System.Drawing.Size(344, 31);
            this.btnUpdateResponse.TabIndex = 9;
            this.btnUpdateResponse.Text = "Update Response";
            this.btnUpdateResponse.UseVisualStyleBackColor = true;
            this.btnUpdateResponse.Click += new System.EventHandler(this.btnUpdateResponse_Click);
            // 
            // lblResponse
            // 
            this.lblResponse.AutoSize = true;
            this.lblResponse.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResponse.Location = new System.Drawing.Point(38, 41);
            this.lblResponse.Name = "lblResponse";
            this.lblResponse.Size = new System.Drawing.Size(65, 17);
            this.lblResponse.TabIndex = 8;
            this.lblResponse.Text = "Response";
            // 
            // txtResponse
            // 
            this.txtResponse.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtResponse.Location = new System.Drawing.Point(109, 40);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.Size = new System.Drawing.Size(245, 198);
            this.txtResponse.TabIndex = 7;
            // 
            // txtResponseTitle
            // 
            this.txtResponseTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtResponseTitle.Location = new System.Drawing.Point(109, 7);
            this.txtResponseTitle.Name = "txtResponseTitle";
            this.txtResponseTitle.Size = new System.Drawing.Size(245, 25);
            this.txtResponseTitle.TabIndex = 6;
            // 
            // lblResponseTitle
            // 
            this.lblResponseTitle.AutoSize = true;
            this.lblResponseTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResponseTitle.Location = new System.Drawing.Point(10, 8);
            this.lblResponseTitle.Name = "lblResponseTitle";
            this.lblResponseTitle.Size = new System.Drawing.Size(93, 17);
            this.lblResponseTitle.TabIndex = 5;
            this.lblResponseTitle.Text = "Response Title";
            // 
            // frmEditResponse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 283);
            this.Controls.Add(this.btnUpdateResponse);
            this.Controls.Add(this.lblResponse);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.txtResponseTitle);
            this.Controls.Add(this.lblResponseTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEditResponse";
            this.Text = "Edit Response";
            this.Load += new System.EventHandler(this.frmEditResponse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnUpdateResponse;
        private Label lblResponse;
        private TextBox txtResponse;
        private TextBox txtResponseTitle;
        private Label lblResponseTitle;
    }
}
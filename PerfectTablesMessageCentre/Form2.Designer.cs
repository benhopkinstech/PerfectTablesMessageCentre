namespace PerfectTablesMessageCentre
{
    partial class frmAddResponse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddResponse));
            this.lblResponseTitle = new System.Windows.Forms.Label();
            this.txtResponseTitle = new System.Windows.Forms.TextBox();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.lblResponse = new System.Windows.Forms.Label();
            this.btnAddNewResponse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblResponseTitle
            // 
            this.lblResponseTitle.AutoSize = true;
            this.lblResponseTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResponseTitle.Location = new System.Drawing.Point(10, 8);
            this.lblResponseTitle.Name = "lblResponseTitle";
            this.lblResponseTitle.Size = new System.Drawing.Size(93, 17);
            this.lblResponseTitle.TabIndex = 0;
            this.lblResponseTitle.Text = "Response Title";
            // 
            // txtResponseTitle
            // 
            this.txtResponseTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtResponseTitle.Location = new System.Drawing.Point(146, 8);
            this.txtResponseTitle.Name = "txtResponseTitle";
            this.txtResponseTitle.Size = new System.Drawing.Size(245, 25);
            this.txtResponseTitle.TabIndex = 1;
            // 
            // txtResponse
            // 
            this.txtResponse.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtResponse.Location = new System.Drawing.Point(146, 41);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.Size = new System.Drawing.Size(245, 198);
            this.txtResponse.TabIndex = 2;
            // 
            // lblResponse
            // 
            this.lblResponse.AutoSize = true;
            this.lblResponse.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResponse.Location = new System.Drawing.Point(38, 41);
            this.lblResponse.Name = "lblResponse";
            this.lblResponse.Size = new System.Drawing.Size(65, 17);
            this.lblResponse.TabIndex = 3;
            this.lblResponse.Text = "Response";
            // 
            // btnAddNewResponse
            // 
            this.btnAddNewResponse.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddNewResponse.Location = new System.Drawing.Point(10, 245);
            this.btnAddNewResponse.Name = "btnAddNewResponse";
            this.btnAddNewResponse.Size = new System.Drawing.Size(381, 31);
            this.btnAddNewResponse.TabIndex = 4;
            this.btnAddNewResponse.Text = "Add New Response";
            this.btnAddNewResponse.UseVisualStyleBackColor = true;
            this.btnAddNewResponse.Click += new System.EventHandler(this.btnAddNewResponse_Click);
            // 
            // frmAddResponse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 283);
            this.Controls.Add(this.btnAddNewResponse);
            this.Controls.Add(this.lblResponse);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.txtResponseTitle);
            this.Controls.Add(this.lblResponseTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddResponse";
            this.Text = "Add a Response";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblResponseTitle;
        private TextBox txtResponseTitle;
        private TextBox txtResponse;
        private Label lblResponse;
        private Button btnAddNewResponse;
    }
}
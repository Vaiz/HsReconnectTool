namespace HsReconnectTool
{
    partial class FloatReconnectButton
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
            this.close_connection_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // close_connection_label
            // 
            this.close_connection_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.close_connection_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close_connection_label.Location = new System.Drawing.Point(0, 0);
            this.close_connection_label.Name = "close_connection_label";
            this.close_connection_label.Size = new System.Drawing.Size(298, 24);
            this.close_connection_label.TabIndex = 0;
            this.close_connection_label.Text = "Close connection";
            this.close_connection_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FloatReconnectButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(298, 24);
            this.ControlBox = false;
            this.Controls.Add(this.close_connection_label);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FloatReconnectButton";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FloatReconnectButton";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label close_connection_label;
    }
}
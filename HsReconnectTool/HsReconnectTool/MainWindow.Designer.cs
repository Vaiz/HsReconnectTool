namespace HsReconnectTool
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.hs_exe_label = new System.Windows.Forms.Label();
            this.hs_exe_status_label = new System.Windows.Forms.Label();
            this.update_button = new System.Windows.Forms.Button();
            this.connection_count_label = new System.Windows.Forms.Label();
            this.connection_count_value_label = new System.Windows.Forms.Label();
            this.close_connection_button = new System.Windows.Forms.Button();
            this.github_link = new System.Windows.Forms.LinkLabel();
            this.float_button_checkBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // hs_exe_label
            // 
            this.hs_exe_label.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.hs_exe_label.AutoSize = true;
            this.hs_exe_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hs_exe_label.Location = new System.Drawing.Point(40, 40);
            this.hs_exe_label.Name = "hs_exe_label";
            this.hs_exe_label.Size = new System.Drawing.Size(224, 32);
            this.hs_exe_label.TabIndex = 0;
            this.hs_exe_label.Text = "Hearthstone.exe";
            // 
            // hs_exe_status_label
            // 
            this.hs_exe_status_label.AutoSize = true;
            this.hs_exe_status_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hs_exe_status_label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.hs_exe_status_label.Location = new System.Drawing.Point(400, 40);
            this.hs_exe_status_label.Name = "hs_exe_status_label";
            this.hs_exe_status_label.Size = new System.Drawing.Size(61, 32);
            this.hs_exe_status_label.TabIndex = 1;
            this.hs_exe_status_label.Text = "Idle";
            // 
            // update_button
            // 
            this.update_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.update_button.Location = new System.Drawing.Point(40, 200);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(320, 80);
            this.update_button.TabIndex = 2;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // connection_count_label
            // 
            this.connection_count_label.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.connection_count_label.AutoSize = true;
            this.connection_count_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.connection_count_label.Location = new System.Drawing.Point(40, 90);
            this.connection_count_label.Name = "connection_count_label";
            this.connection_count_label.Size = new System.Drawing.Size(237, 32);
            this.connection_count_label.TabIndex = 4;
            this.connection_count_label.Text = "Connection count";
            // 
            // connection_count_value_label
            // 
            this.connection_count_value_label.AutoSize = true;
            this.connection_count_value_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.connection_count_value_label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.connection_count_value_label.Location = new System.Drawing.Point(400, 90);
            this.connection_count_value_label.Name = "connection_count_value_label";
            this.connection_count_value_label.Size = new System.Drawing.Size(24, 32);
            this.connection_count_value_label.TabIndex = 5;
            this.connection_count_value_label.Text = "-";
            // 
            // close_connection_button
            // 
            this.close_connection_button.BackColor = System.Drawing.Color.Salmon;
            this.close_connection_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close_connection_button.Location = new System.Drawing.Point(406, 200);
            this.close_connection_button.Name = "close_connection_button";
            this.close_connection_button.Size = new System.Drawing.Size(320, 80);
            this.close_connection_button.TabIndex = 6;
            this.close_connection_button.Text = "Close connection";
            this.close_connection_button.UseVisualStyleBackColor = false;
            this.close_connection_button.Click += new System.EventHandler(this.close_connsection_button_Click);
            // 
            // github_link
            // 
            this.github_link.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.github_link.AutoSize = true;
            this.github_link.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.github_link.Location = new System.Drawing.Point(684, 300);
            this.github_link.Name = "github_link";
            this.github_link.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.github_link.Size = new System.Drawing.Size(72, 25);
            this.github_link.TabIndex = 7;
            this.github_link.TabStop = true;
            this.github_link.Text = "GitHub";
            this.github_link.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.github_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.github_link_LinkClicked);
            // 
            // float_button_checkBox
            // 
            this.float_button_checkBox.AutoSize = true;
            this.float_button_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.float_button_checkBox.Location = new System.Drawing.Point(40, 140);
            this.float_button_checkBox.Name = "float_button_checkBox";
            this.float_button_checkBox.Size = new System.Drawing.Size(451, 36);
            this.float_button_checkBox.TabIndex = 8;
            this.float_button_checkBox.Text = "Enable floating reconnect button";
            this.float_button_checkBox.UseVisualStyleBackColor = true;
            this.float_button_checkBox.CheckedChanged += new System.EventHandler(this.float_reconnect_button_CheckedChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 334);
            this.Controls.Add(this.float_button_checkBox);
            this.Controls.Add(this.github_link);
            this.Controls.Add(this.close_connection_button);
            this.Controls.Add(this.connection_count_value_label);
            this.Controls.Add(this.connection_count_label);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.hs_exe_status_label);
            this.Controls.Add(this.hs_exe_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(790, 390);
            this.Name = "MainWindow";
            this.Text = "HS Reconnect Tool";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hs_exe_label;
        private System.Windows.Forms.Label hs_exe_status_label;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Label connection_count_label;
        private System.Windows.Forms.Label connection_count_value_label;
        private System.Windows.Forms.Button close_connection_button;
        private System.Windows.Forms.LinkLabel github_link;
        private System.Windows.Forms.CheckBox float_button_checkBox;
    }
}


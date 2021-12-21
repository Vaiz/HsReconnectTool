
namespace UtilLib
{
    partial class SettingsForm
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
            this.disconnectIntervalLabel = new System.Windows.Forms.Label();
            this.disconnectMin = new System.Windows.Forms.NumericUpDown();
            this.disconnectMax = new System.Windows.Forms.NumericUpDown();
            this.disablePrivilegeWarningCheckbox = new System.Windows.Forms.CheckBox();
            this.disablePrivilegeWarningLabel = new System.Windows.Forms.Label();
            this.disconnectButtonPosY = new System.Windows.Forms.NumericUpDown();
            this.disconnectButtonPosX = new System.Windows.Forms.NumericUpDown();
            this.disconnectButtonPositionLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.disconnectButtonLabel = new System.Windows.Forms.Label();
            this.disconnectButtonCheckbox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.disconnectMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disconnectMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disconnectButtonPosY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disconnectButtonPosX)).BeginInit();
            this.SuspendLayout();
            // 
            // disconnectIntervalLabel
            // 
            this.disconnectIntervalLabel.AutoSize = true;
            this.disconnectIntervalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.disconnectIntervalLabel.Location = new System.Drawing.Point(30, 30);
            this.disconnectIntervalLabel.Name = "disconnectIntervalLabel";
            this.disconnectIntervalLabel.Size = new System.Drawing.Size(251, 32);
            this.disconnectIntervalLabel.TabIndex = 0;
            this.disconnectIntervalLabel.Text = "Reconnect interval";
            // 
            // disconnectMin
            // 
            this.disconnectMin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.disconnectMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.disconnectMin.Location = new System.Drawing.Point(480, 34);
            this.disconnectMin.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.disconnectMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.disconnectMin.Name = "disconnectMin";
            this.disconnectMin.Size = new System.Drawing.Size(100, 31);
            this.disconnectMin.TabIndex = 1;
            this.disconnectMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.disconnectMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // disconnectMax
            // 
            this.disconnectMax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.disconnectMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.disconnectMax.Location = new System.Drawing.Point(590, 34);
            this.disconnectMax.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.disconnectMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.disconnectMax.Name = "disconnectMax";
            this.disconnectMax.Size = new System.Drawing.Size(100, 31);
            this.disconnectMax.TabIndex = 2;
            this.disconnectMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.disconnectMax.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // disablePrivilegeWarningCheckbox
            // 
            this.disablePrivilegeWarningCheckbox.AutoSize = true;
            this.disablePrivilegeWarningCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.disablePrivilegeWarningCheckbox.Location = new System.Drawing.Point(480, 247);
            this.disablePrivilegeWarningCheckbox.Name = "disablePrivilegeWarningCheckbox";
            this.disablePrivilegeWarningCheckbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.disablePrivilegeWarningCheckbox.Size = new System.Drawing.Size(22, 21);
            this.disablePrivilegeWarningCheckbox.TabIndex = 3;
            this.disablePrivilegeWarningCheckbox.UseVisualStyleBackColor = true;
            // 
            // disablePrivilegeWarningLabel
            // 
            this.disablePrivilegeWarningLabel.AutoSize = true;
            this.disablePrivilegeWarningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.disablePrivilegeWarningLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.disablePrivilegeWarningLabel.Location = new System.Drawing.Point(30, 240);
            this.disablePrivilegeWarningLabel.Name = "disablePrivilegeWarningLabel";
            this.disablePrivilegeWarningLabel.Size = new System.Drawing.Size(333, 32);
            this.disablePrivilegeWarningLabel.TabIndex = 4;
            this.disablePrivilegeWarningLabel.Text = "Disable privilege warning";
            // 
            // disconnectButtonPosY
            // 
            this.disconnectButtonPosY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.disconnectButtonPosY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.disconnectButtonPosY.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.disconnectButtonPosY.Location = new System.Drawing.Point(590, 104);
            this.disconnectButtonPosY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.disconnectButtonPosY.Name = "disconnectButtonPosY";
            this.disconnectButtonPosY.Size = new System.Drawing.Size(100, 31);
            this.disconnectButtonPosY.TabIndex = 7;
            this.disconnectButtonPosY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.disconnectButtonPosY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // disconnectButtonPosX
            // 
            this.disconnectButtonPosX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.disconnectButtonPosX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.disconnectButtonPosX.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.disconnectButtonPosX.Location = new System.Drawing.Point(480, 104);
            this.disconnectButtonPosX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.disconnectButtonPosX.Name = "disconnectButtonPosX";
            this.disconnectButtonPosX.Size = new System.Drawing.Size(100, 31);
            this.disconnectButtonPosX.TabIndex = 6;
            this.disconnectButtonPosX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.disconnectButtonPosX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // disconnectButtonPositionLabel
            // 
            this.disconnectButtonPositionLabel.AutoSize = true;
            this.disconnectButtonPositionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.disconnectButtonPositionLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.disconnectButtonPositionLabel.Location = new System.Drawing.Point(30, 100);
            this.disconnectButtonPositionLabel.Name = "disconnectButtonPositionLabel";
            this.disconnectButtonPositionLabel.Size = new System.Drawing.Size(350, 32);
            this.disconnectButtonPositionLabel.TabIndex = 5;
            this.disconnectButtonPositionLabel.Text = "Disconnect button position";
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.saveButton.Location = new System.Drawing.Point(30, 310);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(300, 60);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cancelButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cancelButton.Location = new System.Drawing.Point(360, 310);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(300, 60);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // disconnectButtonLabel
            // 
            this.disconnectButtonLabel.AutoSize = true;
            this.disconnectButtonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.disconnectButtonLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.disconnectButtonLabel.Location = new System.Drawing.Point(30, 170);
            this.disconnectButtonLabel.Name = "disconnectButtonLabel";
            this.disconnectButtonLabel.Size = new System.Drawing.Size(437, 32);
            this.disconnectButtonLabel.TabIndex = 11;
            this.disconnectButtonLabel.Text = "Enable floating disconnect button";
            // 
            // disconnectButtonCheckbox
            // 
            this.disconnectButtonCheckbox.AutoSize = true;
            this.disconnectButtonCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.disconnectButtonCheckbox.Location = new System.Drawing.Point(480, 177);
            this.disconnectButtonCheckbox.Name = "disconnectButtonCheckbox";
            this.disconnectButtonCheckbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.disconnectButtonCheckbox.Size = new System.Drawing.Size(22, 21);
            this.disconnectButtonCheckbox.TabIndex = 10;
            this.disconnectButtonCheckbox.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 394);
            this.Controls.Add(this.disconnectButtonLabel);
            this.Controls.Add(this.disconnectButtonCheckbox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.disconnectButtonPosY);
            this.Controls.Add(this.disconnectButtonPosX);
            this.Controls.Add(this.disconnectButtonPositionLabel);
            this.Controls.Add(this.disablePrivilegeWarningLabel);
            this.Controls.Add(this.disablePrivilegeWarningCheckbox);
            this.Controls.Add(this.disconnectMax);
            this.Controls.Add(this.disconnectMin);
            this.Controls.Add(this.disconnectIntervalLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "HsReconnectTool: Settings";
            ((System.ComponentModel.ISupportInitialize)(this.disconnectMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disconnectMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disconnectButtonPosY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disconnectButtonPosX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label disconnectIntervalLabel;
        private System.Windows.Forms.NumericUpDown disconnectMin;
        private System.Windows.Forms.NumericUpDown disconnectMax;
        private System.Windows.Forms.CheckBox disablePrivilegeWarningCheckbox;
        private System.Windows.Forms.Label disablePrivilegeWarningLabel;
        private System.Windows.Forms.NumericUpDown disconnectButtonPosY;
        private System.Windows.Forms.NumericUpDown disconnectButtonPosX;
        private System.Windows.Forms.Label disconnectButtonPositionLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label disconnectButtonLabel;
        private System.Windows.Forms.CheckBox disconnectButtonCheckbox;
    }
}
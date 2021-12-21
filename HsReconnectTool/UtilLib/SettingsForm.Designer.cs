
namespace UtilLib
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.reconnectIntervalLabel = new System.Windows.Forms.Label();
            this.disconnectMin = new System.Windows.Forms.NumericUpDown();
            this.disconnectMax = new System.Windows.Forms.NumericUpDown();
            this.disablePrivilegeWarningCheckbox = new System.Windows.Forms.CheckBox();
            this.disablePrivilegeWarningLabel = new System.Windows.Forms.Label();
            this.closeButtonY = new System.Windows.Forms.NumericUpDown();
            this.closeButtonX = new System.Windows.Forms.NumericUpDown();
            this.closeButtonPositionLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.disconnectMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disconnectMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButtonY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButtonX)).BeginInit();
            this.SuspendLayout();
            // 
            // reconnectIntervalLabel
            // 
            resources.ApplyResources(this.reconnectIntervalLabel, "reconnectIntervalLabel");
            this.reconnectIntervalLabel.Name = "reconnectIntervalLabel";
            // 
            // disconnectMin
            // 
            this.disconnectMin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.disconnectMin, "disconnectMin");
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
            this.disconnectMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // disconnectMax
            // 
            this.disconnectMax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.disconnectMax, "disconnectMax");
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
            this.disconnectMax.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // disablePrivilegeWarningCheckbox
            // 
            resources.ApplyResources(this.disablePrivilegeWarningCheckbox, "disablePrivilegeWarningCheckbox");
            this.disablePrivilegeWarningCheckbox.Name = "disablePrivilegeWarningCheckbox";
            this.disablePrivilegeWarningCheckbox.UseVisualStyleBackColor = true;
            // 
            // disablePrivilegeWarningLabel
            // 
            resources.ApplyResources(this.disablePrivilegeWarningLabel, "disablePrivilegeWarningLabel");
            this.disablePrivilegeWarningLabel.Name = "disablePrivilegeWarningLabel";
            // 
            // closeButtonY
            // 
            this.closeButtonY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.closeButtonY, "closeButtonY");
            this.closeButtonY.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.closeButtonY.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.closeButtonY.Name = "closeButtonY";
            this.closeButtonY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // closeButtonX
            // 
            this.closeButtonX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.closeButtonX, "closeButtonX");
            this.closeButtonX.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.closeButtonX.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.closeButtonX.Name = "closeButtonX";
            this.closeButtonX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // closeButtonPositionLabel
            // 
            resources.ApplyResources(this.closeButtonPositionLabel, "closeButtonPositionLabel");
            this.closeButtonPositionLabel.Name = "closeButtonPositionLabel";
            // 
            // saveButton
            // 
            resources.ApplyResources(this.saveButton, "saveButton");
            this.saveButton.Name = "saveButton";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            resources.ApplyResources(this.cancelButton, "cancelButton");
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.closeButtonY);
            this.Controls.Add(this.closeButtonX);
            this.Controls.Add(this.closeButtonPositionLabel);
            this.Controls.Add(this.disablePrivilegeWarningLabel);
            this.Controls.Add(this.disablePrivilegeWarningCheckbox);
            this.Controls.Add(this.disconnectMax);
            this.Controls.Add(this.disconnectMin);
            this.Controls.Add(this.reconnectIntervalLabel);
            this.MaximizeBox = false;
            this.Name = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.disconnectMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disconnectMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButtonY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButtonX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label reconnectIntervalLabel;
        private System.Windows.Forms.NumericUpDown disconnectMin;
        private System.Windows.Forms.NumericUpDown disconnectMax;
        private System.Windows.Forms.CheckBox disablePrivilegeWarningCheckbox;
        private System.Windows.Forms.Label disablePrivilegeWarningLabel;
        private System.Windows.Forms.NumericUpDown closeButtonY;
        private System.Windows.Forms.NumericUpDown closeButtonX;
        private System.Windows.Forms.Label closeButtonPositionLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
    }
}
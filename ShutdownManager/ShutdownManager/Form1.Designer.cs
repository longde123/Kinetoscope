﻿namespace ShutdownManager
{
    partial class ShutdownManager
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBatteryState = new System.Windows.Forms.Label();
            this.lblShutdownSeconds = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numTimeBeforeShutdown = new System.Windows.Forms.NumericUpDown();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numTimeBeforeShutdown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Battery State";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Shutdown in [s]:";
            // 
            // lblBatteryState
            // 
            this.lblBatteryState.AutoSize = true;
            this.lblBatteryState.Location = new System.Drawing.Point(124, 34);
            this.lblBatteryState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBatteryState.Name = "lblBatteryState";
            this.lblBatteryState.Size = new System.Drawing.Size(71, 17);
            this.lblBatteryState.TabIndex = 2;
            this.lblBatteryState.Text = "undefined";
            this.lblBatteryState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblShutdownSeconds
            // 
            this.lblShutdownSeconds.AutoSize = true;
            this.lblShutdownSeconds.Location = new System.Drawing.Point(148, 74);
            this.lblShutdownSeconds.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShutdownSeconds.Name = "lblShutdownSeconds";
            this.lblShutdownSeconds.Size = new System.Drawing.Size(71, 17);
            this.lblShutdownSeconds.TabIndex = 3;
            this.lblShutdownSeconds.Text = "undefined";
            this.lblShutdownSeconds.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Time before shutdown [s]:";
            // 
            // numTimeBeforeShutdown
            // 
            this.numTimeBeforeShutdown.Location = new System.Drawing.Point(493, 32);
            this.numTimeBeforeShutdown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numTimeBeforeShutdown.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.numTimeBeforeShutdown.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numTimeBeforeShutdown.Name = "numTimeBeforeShutdown";
            this.numTimeBeforeShutdown.Size = new System.Drawing.Size(160, 22);
            this.numTimeBeforeShutdown.TabIndex = 5;
            this.numTimeBeforeShutdown.Value = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            this.numTimeBeforeShutdown.ValueChanged += new System.EventHandler(this.numTimeBeforeShutdown_ValueChanged);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // ShutdownManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 119);
            this.Controls.Add(this.numTimeBeforeShutdown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblShutdownSeconds);
            this.Controls.Add(this.lblBatteryState);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ShutdownManager";
            this.Text = "Shutdown Manager 1.0";
            this.Load += new System.EventHandler(this.ShutdownManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numTimeBeforeShutdown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBatteryState;
        private System.Windows.Forms.Label lblShutdownSeconds;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numTimeBeforeShutdown;
        private System.Windows.Forms.Timer timer;
    }
}


﻿namespace SpriteSheetStudio
{
    partial class AnimationTimeline
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnimationTimeline));
            this.SuspendLayout();
            // 
            // AnimationTimeline
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.CloseButton = false;
            this.CloseButtonVisible = false;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AnimationTimeline";
            this.Text = "Timeline";
            this.ToolTipText = "Timeline";
            this.Load += new System.EventHandler(this.AnimationTimeline_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.AnimationTimeline_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.AnimationTimeline_DragEnter);
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.AnimationTimeline_DragOver);
            this.ResumeLayout(false);

        }

        #endregion


    }
}

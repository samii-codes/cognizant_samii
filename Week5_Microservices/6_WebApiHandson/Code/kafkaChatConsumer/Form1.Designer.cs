namespace kafkaChatConsumer
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtMessages;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtMessages = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtMessages
            // 
            this.txtMessages.Location = new System.Drawing.Point(12, 12);
            this.txtMessages.Multiline = true;
            this.txtMessages.Name = "txtMessages";
            this.txtMessages.ReadOnly = true;
            this.txtMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessages.Size = new System.Drawing.Size(360, 237);
            this.txtMessages.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.txtMessages);
            this.Name = "Form1";
            this.Text = "Kafka Chat Consumer";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

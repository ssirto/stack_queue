namespace esercizio_stackqueue
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnStartStack = new System.Windows.Forms.Button();
            this.btnStopStack = new System.Windows.Forms.Button();
            this.btnStartQueue = new System.Windows.Forms.Button();
            this.btnStopQueue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(73, 206);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(279, 148);
            this.listBox1.TabIndex = 4;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(449, 206);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(279, 148);
            this.listBox2.TabIndex = 5;
            // 
            // btnStartStack
            // 
            this.btnStartStack.Location = new System.Drawing.Point(110, 45);
            this.btnStartStack.Name = "btnStartStack";
            this.btnStartStack.Size = new System.Drawing.Size(108, 46);
            this.btnStartStack.TabIndex = 6;
            this.btnStartStack.Text = "Start Stack";
            this.btnStartStack.UseVisualStyleBackColor = true;
            this.btnStartStack.Click += new System.EventHandler(this.btnStartStack_Click);
            // 
            // btnStopStack
            // 
            this.btnStopStack.Location = new System.Drawing.Point(110, 128);
            this.btnStopStack.Name = "btnStopStack";
            this.btnStopStack.Size = new System.Drawing.Size(108, 46);
            this.btnStopStack.TabIndex = 7;
            this.btnStopStack.Text = "Stop Stack";
            this.btnStopStack.UseVisualStyleBackColor = true;
            this.btnStopStack.Click += new System.EventHandler(this.btnStopStack_Click);
            // 
            // btnStartQueue
            // 
            this.btnStartQueue.Location = new System.Drawing.Point(483, 45);
            this.btnStartQueue.Name = "btnStartQueue";
            this.btnStartQueue.Size = new System.Drawing.Size(108, 46);
            this.btnStartQueue.TabIndex = 8;
            this.btnStartQueue.Text = "Start Queue";
            this.btnStartQueue.UseVisualStyleBackColor = true;
            this.btnStartQueue.Click += new System.EventHandler(this.btnStartQueue_Click);
            // 
            // btnStopQueue
            // 
            this.btnStopQueue.Location = new System.Drawing.Point(483, 128);
            this.btnStopQueue.Name = "btnStopQueue";
            this.btnStopQueue.Size = new System.Drawing.Size(108, 46);
            this.btnStopQueue.TabIndex = 9;
            this.btnStopQueue.Text = "Stop Queue";
            this.btnStopQueue.UseVisualStyleBackColor = true;
            this.btnStopQueue.Click += new System.EventHandler(this.btnStopQueue_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStopQueue);
            this.Controls.Add(this.btnStartQueue);
            this.Controls.Add(this.btnStopStack);
            this.Controls.Add(this.btnStartStack);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnStartStack;
        private System.Windows.Forms.Button btnStopStack;
        private System.Windows.Forms.Button btnStartQueue;
        private System.Windows.Forms.Button btnStopQueue;
    }
}


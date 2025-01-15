namespace NoteTaking
{
    partial class Form2
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
            btnConfirm = new Button();
            txtNoteName = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(187, 131);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(75, 23);
            btnConfirm.TabIndex = 0;
            btnConfirm.Text = "Ok";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // txtNoteName
            // 
            txtNoteName.Location = new Point(173, 89);
            txtNoteName.Name = "txtNoteName";
            txtNoteName.Size = new Size(100, 23);
            txtNoteName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(143, 61);
            label1.Name = "label1";
            label1.Size = new Size(167, 15);
            label1.TabIndex = 2;
            label1.Text = "Enter The Name For Your Note";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 239);
            Controls.Add(label1);
            Controls.Add(txtNoteName);
            Controls.Add(btnConfirm);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfirm;
        private TextBox txtNoteName;
        private Label label1;
    }
}
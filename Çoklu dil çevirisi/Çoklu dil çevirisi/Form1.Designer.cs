namespace Çoklu_dil_çevirisi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtMetin = new TextBox();
            clbDiller = new CheckedListBox();
            btnCevir = new Button();
            txtSonuc = new TextBox();
            SuspendLayout();
            // 
            // txtMetin
            // 
            txtMetin.Location = new Point(76, 42);
            txtMetin.Multiline = true;
            txtMetin.Name = "txtMetin";
            txtMetin.Size = new Size(1000, 393);
            txtMetin.TabIndex = 0;
            // 
            // clbDiller
            // 
            clbDiller.CheckOnClick = true;
            clbDiller.FormattingEnabled = true;
            clbDiller.Items.AddRange(new object[] { "English (en)", "French (fr)", "German (de)", "Spanish (es)", "Russian (ru)", "Arabic (ar)" });
            clbDiller.Location = new Point(1094, 96);
            clbDiller.Name = "clbDiller";
            clbDiller.Size = new Size(525, 256);
            clbDiller.TabIndex = 1;
            clbDiller.SelectedIndexChanged += clbDiller_SelectedIndexChanged;
            // 
            // btnCevir
            // 
            btnCevir.Location = new Point(1445, 280);
            btnCevir.Name = "btnCevir";
            btnCevir.Size = new Size(150, 46);
            btnCevir.TabIndex = 2;
            btnCevir.Text = "ÇEVİR";
            btnCevir.UseVisualStyleBackColor = true;
            btnCevir.Click += btnCevir_Click;
            // 
            // txtSonuc
            // 
            txtSonuc.BackColor = SystemColors.ButtonHighlight;
            txtSonuc.Location = new Point(76, 466);
            txtSonuc.Multiline = true;
            txtSonuc.Name = "txtSonuc";
            txtSonuc.ReadOnly = true;
            txtSonuc.ScrollBars = ScrollBars.Vertical;
            txtSonuc.Size = new Size(1575, 550);
            txtSonuc.TabIndex = 3;
            txtSonuc.TextChanged += txtSonuc_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1722, 1075);
            Controls.Add(txtSonuc);
            Controls.Add(btnCevir);
            Controls.Add(clbDiller);
            Controls.Add(txtMetin);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMetin;
        private CheckedListBox clbDiller;
        private Button btnCevir;
        private TextBox txtSonuc;
    }
}

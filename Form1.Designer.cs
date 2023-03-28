namespace ArduinoMaster
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
            btnConnect = new Button();
            cbPorts = new ComboBox();
            btnSend = new Button();
            txtSend = new TextBox();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(118, 56);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(100, 30);
            btnConnect.TabIndex = 0;
            btnConnect.Text = "Conectar";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // cbPorts
            // 
            cbPorts.FormattingEnabled = true;
            cbPorts.Location = new Point(61, 27);
            cbPorts.Name = "cbPorts";
            cbPorts.Size = new Size(100, 23);
            cbPorts.TabIndex = 1;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(12, 102);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(100, 30);
            btnSend.TabIndex = 2;
            btnSend.Text = "Enviar";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // txtSend
            // 
            txtSend.Location = new Point(118, 107);
            txtSend.Name = "txtSend";
            txtSend.Size = new Size(100, 23);
            txtSend.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(12, 56);
            button1.Name = "button1";
            button1.Size = new Size(100, 30);
            button1.TabIndex = 4;
            button1.Text = "Atualizar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(89, 5);
            label1.Name = "label1";
            label1.Size = new Size(47, 19);
            label1.TabIndex = 5;
            label1.Text = "Portas";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(237, 159);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(txtSend);
            Controls.Add(btnSend);
            Controls.Add(cbPorts);
            Controls.Add(btnConnect);
            Name = "Form1";
            Text = "ArduinoMaster V1.0";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConnect;
        private ComboBox cbPorts;
        private Button btnSend;
        private TextBox txtSend;
        private Button button1;
        private Label label1;
    }
}
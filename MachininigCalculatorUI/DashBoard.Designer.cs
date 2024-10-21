namespace MachininigCalculatorUI
{
    partial class DashBoard
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
            formHeader = new Label();
            vcLabel = new Label();
            vcInputBox = new TextBox();
            radioButtonMilling = new RadioButton();
            radioButtonDrilling = new RadioButton();
            vcUnitLabel = new Label();
            fnLabel = new Label();
            fnInputBox = new TextBox();
            fnUnitLabel = new Label();
            fzLabel = new Label();
            fzInputBox = new TextBox();
            fzUnitLabel = new Label();
            zLabel = new Label();
            zInputBox = new TextBox();
            zUnitLabel = new Label();
            calculateBasicParametersButton = new Button();
            revolutionsOutputBox = new TextBox();
            revolutionsLabel = new Label();
            revolutionsUnitLabel = new Label();
            feedLabel = new Label();
            FeedUnitLabel = new Label();
            feedOutputBox = new TextBox();
            statusStrip = new StatusStrip();
            systemStatus = new ToolStripStatusLabel();
            diameterLabel = new Label();
            DinputBox = new TextBox();
            dUnitLabel = new Label();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // formHeader
            // 
            formHeader.AutoSize = true;
            formHeader.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 238);
            formHeader.Location = new Point(193, -10);
            formHeader.Name = "formHeader";
            formHeader.Size = new Size(669, 60);
            formHeader.TabIndex = 0;
            formHeader.Text = "Kalkulator Parametrów Skrawania";
            // 
            // vcLabel
            // 
            vcLabel.AutoSize = true;
            vcLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            vcLabel.Location = new Point(41, 107);
            vcLabel.Name = "vcLabel";
            vcLabel.Size = new Size(45, 38);
            vcLabel.TabIndex = 1;
            vcLabel.Text = "Vc";
            // 
            // vcInputBox
            // 
            vcInputBox.BorderStyle = BorderStyle.FixedSingle;
            vcInputBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            vcInputBox.Location = new Point(102, 101);
            vcInputBox.Name = "vcInputBox";
            vcInputBox.Size = new Size(125, 43);
            vcInputBox.TabIndex = 2;
            vcInputBox.TextChanged += vcInputBox_TextChanged;
            // 
            // radioButtonMilling
            // 
            radioButtonMilling.AutoSize = true;
            radioButtonMilling.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            radioButtonMilling.Location = new Point(41, 53);
            radioButtonMilling.Name = "radioButtonMilling";
            radioButtonMilling.Size = new Size(178, 42);
            radioButtonMilling.TabIndex = 3;
            radioButtonMilling.TabStop = true;
            radioButtonMilling.Text = "Frezowanie";
            radioButtonMilling.UseVisualStyleBackColor = true;
            // 
            // radioButtonDrilling
            // 
            radioButtonDrilling.AutoSize = true;
            radioButtonDrilling.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            radioButtonDrilling.Location = new Point(230, 53);
            radioButtonDrilling.Name = "radioButtonDrilling";
            radioButtonDrilling.Size = new Size(162, 42);
            radioButtonDrilling.TabIndex = 4;
            radioButtonDrilling.TabStop = true;
            radioButtonDrilling.Text = "Wiercenie";
            radioButtonDrilling.UseVisualStyleBackColor = true;
            // 
            // vcUnitLabel
            // 
            vcUnitLabel.AutoSize = true;
            vcUnitLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            vcUnitLabel.Location = new Point(233, 101);
            vcUnitLabel.Name = "vcUnitLabel";
            vcUnitLabel.Size = new Size(99, 38);
            vcUnitLabel.TabIndex = 5;
            vcUnitLabel.Text = "m/min";
            // 
            // fnLabel
            // 
            fnLabel.AutoSize = true;
            fnLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            fnLabel.Location = new Point(396, 164);
            fnLabel.Name = "fnLabel";
            fnLabel.Size = new Size(47, 38);
            fnLabel.TabIndex = 6;
            fnLabel.Text = "Fn";
            // 
            // fnInputBox
            // 
            fnInputBox.BorderStyle = BorderStyle.FixedSingle;
            fnInputBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            fnInputBox.Location = new Point(452, 162);
            fnInputBox.Name = "fnInputBox";
            fnInputBox.Size = new Size(125, 43);
            fnInputBox.TabIndex = 7;
            // 
            // fnUnitLabel
            // 
            fnUnitLabel.AutoSize = true;
            fnUnitLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            fnUnitLabel.Location = new Point(595, 164);
            fnUnitLabel.Name = "fnUnitLabel";
            fnUnitLabel.Size = new Size(124, 38);
            fnUnitLabel.TabIndex = 8;
            fnUnitLabel.Text = "mm/obr.";
            // 
            // fzLabel
            // 
            fzLabel.AutoSize = true;
            fzLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            fzLabel.Location = new Point(41, 164);
            fzLabel.Name = "fzLabel";
            fzLabel.Size = new Size(44, 38);
            fzLabel.TabIndex = 9;
            fzLabel.Text = "Fz";
            // 
            // fzInputBox
            // 
            fzInputBox.BorderStyle = BorderStyle.FixedSingle;
            fzInputBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            fzInputBox.Location = new Point(105, 168);
            fzInputBox.Name = "fzInputBox";
            fzInputBox.Size = new Size(125, 43);
            fzInputBox.TabIndex = 10;
            // 
            // fzUnitLabel
            // 
            fzUnitLabel.AutoSize = true;
            fzUnitLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            fzUnitLabel.Location = new Point(243, 164);
            fzUnitLabel.Name = "fzUnitLabel";
            fzUnitLabel.Size = new Size(89, 38);
            fzUnitLabel.TabIndex = 11;
            fzUnitLabel.Text = "mm/z";
            // 
            // zLabel
            // 
            zLabel.AutoSize = true;
            zLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            zLabel.Location = new Point(41, 236);
            zLabel.Name = "zLabel";
            zLabel.Size = new Size(33, 38);
            zLabel.TabIndex = 12;
            zLabel.Text = "Z";
            // 
            // zInputBox
            // 
            zInputBox.BorderStyle = BorderStyle.FixedSingle;
            zInputBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            zInputBox.Location = new Point(105, 234);
            zInputBox.Name = "zInputBox";
            zInputBox.Size = new Size(125, 43);
            zInputBox.TabIndex = 13;
            // 
            // zUnitLabel
            // 
            zUnitLabel.AutoSize = true;
            zUnitLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            zUnitLabel.Location = new Point(241, 240);
            zUnitLabel.Name = "zUnitLabel";
            zUnitLabel.Size = new Size(91, 38);
            zUnitLabel.TabIndex = 14;
            zUnitLabel.Text = "ostrzy";
            // 
            // calculateBasicParametersButton
            // 
            calculateBasicParametersButton.Location = new Point(41, 296);
            calculateBasicParametersButton.Name = "calculateBasicParametersButton";
            calculateBasicParametersButton.Size = new Size(384, 49);
            calculateBasicParametersButton.TabIndex = 15;
            calculateBasicParametersButton.Text = "1 Oblicz n i F";
            calculateBasicParametersButton.UseVisualStyleBackColor = true;
            calculateBasicParametersButton.Click += calculateBasicParametersButton_Click;
            // 
            // revolutionsOutputBox
            // 
            revolutionsOutputBox.BorderStyle = BorderStyle.FixedSingle;
            revolutionsOutputBox.Location = new Point(159, 361);
            revolutionsOutputBox.Name = "revolutionsOutputBox";
            revolutionsOutputBox.ReadOnly = true;
            revolutionsOutputBox.Size = new Size(125, 47);
            revolutionsOutputBox.TabIndex = 16;
            revolutionsOutputBox.TextChanged += revolutionsOutputBox_TextChanged;
            // 
            // revolutionsLabel
            // 
            revolutionsLabel.AutoSize = true;
            revolutionsLabel.Location = new Point(41, 367);
            revolutionsLabel.Name = "revolutionsLabel";
            revolutionsLabel.Size = new Size(112, 41);
            revolutionsLabel.TabIndex = 17;
            revolutionsLabel.Text = "Obroty";
            // 
            // revolutionsUnitLabel
            // 
            revolutionsUnitLabel.AutoSize = true;
            revolutionsUnitLabel.Location = new Point(293, 363);
            revolutionsUnitLabel.Name = "revolutionsUnitLabel";
            revolutionsUnitLabel.Size = new Size(126, 41);
            revolutionsUnitLabel.TabIndex = 18;
            revolutionsUnitLabel.Text = "obr/min";
            // 
            // feedLabel
            // 
            feedLabel.AutoSize = true;
            feedLabel.Location = new Point(41, 424);
            feedLabel.Name = "feedLabel";
            feedLabel.Size = new Size(104, 41);
            feedLabel.TabIndex = 19;
            feedLabel.Text = "Posuw";
            // 
            // FeedUnitLabel
            // 
            FeedUnitLabel.AutoSize = true;
            FeedUnitLabel.Location = new Point(293, 424);
            FeedUnitLabel.Name = "FeedUnitLabel";
            FeedUnitLabel.Size = new Size(132, 41);
            FeedUnitLabel.TabIndex = 20;
            FeedUnitLabel.Text = "mm/min";
            // 
            // feedOutputBox
            // 
            feedOutputBox.BorderStyle = BorderStyle.FixedSingle;
            feedOutputBox.Location = new Point(159, 418);
            feedOutputBox.Name = "feedOutputBox";
            feedOutputBox.ReadOnly = true;
            feedOutputBox.Size = new Size(125, 47);
            feedOutputBox.TabIndex = 21;
            // 
            // statusStrip
            // 
            statusStrip.BackColor = Color.Transparent;
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { systemStatus });
            statusStrip.Location = new Point(0, 593);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(1044, 37);
            statusStrip.TabIndex = 23;
            statusStrip.Text = "statusStrip1";
            // 
            // systemStatus
            // 
            systemStatus.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            systemStatus.Name = "systemStatus";
            systemStatus.Size = new Size(76, 31);
            systemStatus.Text = "Ready";
            // 
            // diameterLabel
            // 
            diameterLabel.AutoSize = true;
            diameterLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            diameterLabel.Location = new Point(396, 102);
            diameterLabel.Name = "diameterLabel";
            diameterLabel.Size = new Size(37, 38);
            diameterLabel.TabIndex = 24;
            diameterLabel.Text = "D";
            // 
            // DinputBox
            // 
            DinputBox.BorderStyle = BorderStyle.FixedSingle;
            DinputBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            DinputBox.Location = new Point(452, 97);
            DinputBox.Name = "DinputBox";
            DinputBox.Size = new Size(125, 43);
            DinputBox.TabIndex = 25;
            // 
            // dUnitLabel
            // 
            dUnitLabel.AutoSize = true;
            dUnitLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dUnitLabel.Location = new Point(595, 99);
            dUnitLabel.Name = "dUnitLabel";
            dUnitLabel.Size = new Size(65, 38);
            dUnitLabel.TabIndex = 26;
            dUnitLabel.Text = "mm";
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1044, 630);
            Controls.Add(dUnitLabel);
            Controls.Add(DinputBox);
            Controls.Add(diameterLabel);
            Controls.Add(statusStrip);
            Controls.Add(feedOutputBox);
            Controls.Add(FeedUnitLabel);
            Controls.Add(feedLabel);
            Controls.Add(revolutionsUnitLabel);
            Controls.Add(revolutionsLabel);
            Controls.Add(revolutionsOutputBox);
            Controls.Add(calculateBasicParametersButton);
            Controls.Add(zUnitLabel);
            Controls.Add(zInputBox);
            Controls.Add(zLabel);
            Controls.Add(fzUnitLabel);
            Controls.Add(fzInputBox);
            Controls.Add(fzLabel);
            Controls.Add(fnUnitLabel);
            Controls.Add(fnInputBox);
            Controls.Add(fnLabel);
            Controls.Add(vcUnitLabel);
            Controls.Add(radioButtonDrilling);
            Controls.Add(radioButtonMilling);
            Controls.Add(vcInputBox);
            Controls.Add(vcLabel);
            Controls.Add(formHeader);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Margin = new Padding(6);
            Name = "DashBoard";
            Text = "Technologist Calculator";
            Load += DashBoard_Load;
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label formHeader;
        private Label vcLabel;
        private TextBox vcInputBox;
        private RadioButton radioButtonMilling;
        private RadioButton radioButtonDrilling;
        private Label vcUnitLabel;
        private Label fnLabel;
        private TextBox fnInputBox;
        private Label fnUnitLabel;
        private Label fzLabel;
        private TextBox fzInputBox;
        private Label fzUnitLabel;
        private Label zLabel;
        private TextBox zInputBox;
        private Label zUnitLabel;
        private Button calculateBasicParametersButton;
        private TextBox revolutionsOutputBox;
        private Label revolutionsLabel;
        private Label revolutionsUnitLabel;
        private Label feedLabel;
        private Label FeedUnitLabel;
        private TextBox feedOutputBox;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel systemStatus;
        private Label diameterLabel;
        private TextBox DinputBox;
        private Label dUnitLabel;
    }
}

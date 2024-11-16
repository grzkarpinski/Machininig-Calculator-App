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
            apLabel = new Label();
            aeLabel = new Label();
            calculateVolumetricCuttingEfficiencyButton = new Button();
            apUnitLabel = new Label();
            aeUnitLabel = new Label();
            apInputBox = new TextBox();
            aeInputBox = new TextBox();
            qLabel = new Label();
            qOutputBox = new TextBox();
            qUnitLabel = new Label();
            clearButton = new Button();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // formHeader
            // 
            formHeader.AutoSize = true;
            formHeader.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 238);
            formHeader.Location = new Point(168, 5);
            formHeader.Name = "formHeader";
            formHeader.Size = new Size(669, 60);
            formHeader.TabIndex = 0;
            formHeader.Text = "Kalkulator Parametrów Skrawania";
            // 
            // vcLabel
            // 
            vcLabel.AutoSize = true;
            vcLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            vcLabel.Location = new Point(49, 73);
            vcLabel.Name = "vcLabel";
            vcLabel.Size = new Size(45, 38);
            vcLabel.TabIndex = 1;
            vcLabel.Text = "Vc";
            // 
            // vcInputBox
            // 
            vcInputBox.BorderStyle = BorderStyle.FixedSingle;
            vcInputBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            vcInputBox.Location = new Point(92, 68);
            vcInputBox.Name = "vcInputBox";
            vcInputBox.Size = new Size(125, 43);
            vcInputBox.TabIndex = 2;
            vcInputBox.TextChanged += vcInputBox_TextChanged;
            // 
            // radioButtonMilling
            // 
            radioButtonMilling.AutoSize = true;
            radioButtonMilling.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            radioButtonMilling.Location = new Point(49, 125);
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
            radioButtonDrilling.Location = new Point(238, 125);
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
            vcUnitLabel.Location = new Point(233, 73);
            vcUnitLabel.Name = "vcUnitLabel";
            vcUnitLabel.Size = new Size(99, 38);
            vcUnitLabel.TabIndex = 5;
            vcUnitLabel.Text = "m/min";
            // 
            // fnLabel
            // 
            fnLabel.AutoSize = true;
            fnLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            fnLabel.Location = new Point(327, 192);
            fnLabel.Name = "fnLabel";
            fnLabel.Size = new Size(47, 38);
            fnLabel.TabIndex = 6;
            fnLabel.Text = "Fn";
            // 
            // fnInputBox
            // 
            fnInputBox.BorderStyle = BorderStyle.FixedSingle;
            fnInputBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            fnInputBox.Location = new Point(380, 187);
            fnInputBox.Name = "fnInputBox";
            fnInputBox.Size = new Size(125, 43);
            fnInputBox.TabIndex = 7;
            // 
            // fnUnitLabel
            // 
            fnUnitLabel.AutoSize = true;
            fnUnitLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            fnUnitLabel.Location = new Point(511, 189);
            fnUnitLabel.Name = "fnUnitLabel";
            fnUnitLabel.Size = new Size(124, 38);
            fnUnitLabel.TabIndex = 8;
            fnUnitLabel.Text = "mm/obr.";
            // 
            // fzLabel
            // 
            fzLabel.AutoSize = true;
            fzLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            fzLabel.Location = new Point(41, 195);
            fzLabel.Name = "fzLabel";
            fzLabel.Size = new Size(44, 38);
            fzLabel.TabIndex = 9;
            fzLabel.Text = "Fz";
            // 
            // fzInputBox
            // 
            fzInputBox.BorderStyle = BorderStyle.FixedSingle;
            fzInputBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            fzInputBox.Location = new Point(88, 190);
            fzInputBox.Name = "fzInputBox";
            fzInputBox.Size = new Size(125, 43);
            fzInputBox.TabIndex = 10;
            // 
            // fzUnitLabel
            // 
            fzUnitLabel.AutoSize = true;
            fzUnitLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            fzUnitLabel.Location = new Point(219, 192);
            fzUnitLabel.Name = "fzUnitLabel";
            fzUnitLabel.Size = new Size(89, 38);
            fzUnitLabel.TabIndex = 11;
            fzUnitLabel.Text = "mm/z";
            // 
            // zLabel
            // 
            zLabel.AutoSize = true;
            zLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            zLabel.Location = new Point(673, 192);
            zLabel.Name = "zLabel";
            zLabel.Size = new Size(33, 38);
            zLabel.TabIndex = 12;
            zLabel.Text = "Z";
            // 
            // zInputBox
            // 
            zInputBox.BorderStyle = BorderStyle.FixedSingle;
            zInputBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            zInputBox.Location = new Point(712, 184);
            zInputBox.Name = "zInputBox";
            zInputBox.Size = new Size(125, 43);
            zInputBox.TabIndex = 13;
            // 
            // zUnitLabel
            // 
            zUnitLabel.AutoSize = true;
            zUnitLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            zUnitLabel.Location = new Point(843, 186);
            zUnitLabel.Name = "zUnitLabel";
            zUnitLabel.Size = new Size(91, 38);
            zUnitLabel.TabIndex = 14;
            zUnitLabel.Text = "ostrzy";
            // 
            // calculateBasicParametersButton
            // 
            calculateBasicParametersButton.Location = new Point(41, 263);
            calculateBasicParametersButton.Name = "calculateBasicParametersButton";
            calculateBasicParametersButton.Size = new Size(384, 49);
            calculateBasicParametersButton.TabIndex = 15;
            calculateBasicParametersButton.Text = "1 Oblicz S i F";
            calculateBasicParametersButton.UseVisualStyleBackColor = true;
            calculateBasicParametersButton.Click += calculateBasicParametersButton_Click;
            // 
            // revolutionsOutputBox
            // 
            revolutionsOutputBox.BorderStyle = BorderStyle.FixedSingle;
            revolutionsOutputBox.Location = new Point(187, 338);
            revolutionsOutputBox.Name = "revolutionsOutputBox";
            revolutionsOutputBox.ReadOnly = true;
            revolutionsOutputBox.Size = new Size(125, 47);
            revolutionsOutputBox.TabIndex = 16;
            revolutionsOutputBox.TextChanged += revolutionsOutputBox_TextChanged;
            // 
            // revolutionsLabel
            // 
            revolutionsLabel.AutoSize = true;
            revolutionsLabel.Location = new Point(41, 344);
            revolutionsLabel.Name = "revolutionsLabel";
            revolutionsLabel.Size = new Size(136, 41);
            revolutionsLabel.TabIndex = 17;
            revolutionsLabel.Text = "Obroty S";
            // 
            // revolutionsUnitLabel
            // 
            revolutionsUnitLabel.AutoSize = true;
            revolutionsUnitLabel.Location = new Point(318, 340);
            revolutionsUnitLabel.Name = "revolutionsUnitLabel";
            revolutionsUnitLabel.Size = new Size(126, 41);
            revolutionsUnitLabel.TabIndex = 18;
            revolutionsUnitLabel.Text = "obr/min";
            // 
            // feedLabel
            // 
            feedLabel.AutoSize = true;
            feedLabel.Location = new Point(481, 340);
            feedLabel.Name = "feedLabel";
            feedLabel.Size = new Size(127, 41);
            feedLabel.TabIndex = 19;
            feedLabel.Text = "Posuw F";
            // 
            // FeedUnitLabel
            // 
            FeedUnitLabel.AutoSize = true;
            FeedUnitLabel.Location = new Point(762, 340);
            FeedUnitLabel.Name = "FeedUnitLabel";
            FeedUnitLabel.Size = new Size(132, 41);
            FeedUnitLabel.TabIndex = 20;
            FeedUnitLabel.Text = "mm/min";
            // 
            // feedOutputBox
            // 
            feedOutputBox.BorderStyle = BorderStyle.FixedSingle;
            feedOutputBox.Location = new Point(614, 334);
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
            statusStrip.Location = new Point(0, 636);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(982, 37);
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
            diameterLabel.Location = new Point(380, 73);
            diameterLabel.Name = "diameterLabel";
            diameterLabel.Size = new Size(37, 38);
            diameterLabel.TabIndex = 24;
            diameterLabel.Text = "D";
            // 
            // DinputBox
            // 
            DinputBox.BorderStyle = BorderStyle.FixedSingle;
            DinputBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            DinputBox.Location = new Point(423, 68);
            DinputBox.Name = "DinputBox";
            DinputBox.Size = new Size(125, 43);
            DinputBox.TabIndex = 25;
            // 
            // dUnitLabel
            // 
            dUnitLabel.AutoSize = true;
            dUnitLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            dUnitLabel.Location = new Point(554, 70);
            dUnitLabel.Name = "dUnitLabel";
            dUnitLabel.Size = new Size(65, 38);
            dUnitLabel.TabIndex = 26;
            dUnitLabel.Text = "mm";
            // 
            // apLabel
            // 
            apLabel.AutoSize = true;
            apLabel.Location = new Point(41, 425);
            apLabel.Name = "apLabel";
            apLabel.Size = new Size(55, 41);
            apLabel.TabIndex = 27;
            apLabel.Text = "Ap";
            // 
            // aeLabel
            // 
            aeLabel.AutoSize = true;
            aeLabel.Location = new Point(363, 425);
            aeLabel.Name = "aeLabel";
            aeLabel.Size = new Size(53, 41);
            aeLabel.TabIndex = 28;
            aeLabel.Text = "Ae";
            // 
            // calculateVolumetricCuttingEfficiencyButton
            // 
            calculateVolumetricCuttingEfficiencyButton.Location = new Point(41, 495);
            calculateVolumetricCuttingEfficiencyButton.Name = "calculateVolumetricCuttingEfficiencyButton";
            calculateVolumetricCuttingEfficiencyButton.Size = new Size(384, 49);
            calculateVolumetricCuttingEfficiencyButton.TabIndex = 29;
            calculateVolumetricCuttingEfficiencyButton.Text = "2 Oblicz Q";
            calculateVolumetricCuttingEfficiencyButton.UseVisualStyleBackColor = true;
            calculateVolumetricCuttingEfficiencyButton.Click += calculateVolumetricCuttingEfficiencyButton_Click;
            // 
            // apUnitLabel
            // 
            apUnitLabel.AutoSize = true;
            apUnitLabel.Location = new Point(238, 425);
            apUnitLabel.Name = "apUnitLabel";
            apUnitLabel.Size = new Size(70, 41);
            apUnitLabel.TabIndex = 30;
            apUnitLabel.Text = "mm";
            // 
            // aeUnitLabel
            // 
            aeUnitLabel.AutoSize = true;
            aeUnitLabel.Location = new Point(565, 425);
            aeUnitLabel.Name = "aeUnitLabel";
            aeUnitLabel.Size = new Size(70, 41);
            aeUnitLabel.TabIndex = 31;
            aeUnitLabel.Text = "mm";
            // 
            // apInputBox
            // 
            apInputBox.BorderStyle = BorderStyle.FixedSingle;
            apInputBox.Location = new Point(102, 419);
            apInputBox.Name = "apInputBox";
            apInputBox.Size = new Size(125, 47);
            apInputBox.TabIndex = 32;
            // 
            // aeInputBox
            // 
            aeInputBox.BorderStyle = BorderStyle.FixedSingle;
            aeInputBox.Location = new Point(422, 419);
            aeInputBox.Name = "aeInputBox";
            aeInputBox.Size = new Size(125, 47);
            aeInputBox.TabIndex = 33;
            // 
            // qLabel
            // 
            qLabel.AutoSize = true;
            qLabel.Location = new Point(49, 575);
            qLabel.Name = "qLabel";
            qLabel.Size = new Size(41, 41);
            qLabel.TabIndex = 34;
            qLabel.Text = "Q";
            // 
            // qOutputBox
            // 
            qOutputBox.BorderStyle = BorderStyle.FixedSingle;
            qOutputBox.Location = new Point(102, 569);
            qOutputBox.Name = "qOutputBox";
            qOutputBox.ReadOnly = true;
            qOutputBox.Size = new Size(125, 47);
            qOutputBox.TabIndex = 35;
            // 
            // qUnitLabel
            // 
            qUnitLabel.AutoSize = true;
            qUnitLabel.Location = new Point(233, 575);
            qUnitLabel.Name = "qUnitLabel";
            qUnitLabel.Size = new Size(136, 41);
            qUnitLabel.TabIndex = 36;
            qUnitLabel.Text = "cm3/min";
            // 
            // clearButton
            // 
            clearButton.Location = new Point(755, 569);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(179, 45);
            clearButton.TabIndex = 37;
            clearButton.Text = "CLEAR";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(982, 673);
            Controls.Add(clearButton);
            Controls.Add(qUnitLabel);
            Controls.Add(qOutputBox);
            Controls.Add(qLabel);
            Controls.Add(aeInputBox);
            Controls.Add(apInputBox);
            Controls.Add(aeUnitLabel);
            Controls.Add(apUnitLabel);
            Controls.Add(calculateVolumetricCuttingEfficiencyButton);
            Controls.Add(aeLabel);
            Controls.Add(apLabel);
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
            Text = "Technologist Calculator by Grzegorz Karpinski";
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
        private Label apLabel;
        private Label aeLabel;
        private Button calculateVolumetricCuttingEfficiencyButton;
        private Label apUnitLabel;
        private Label aeUnitLabel;
        private TextBox apInputBox;
        private TextBox aeInputBox;
        private Label qLabel;
        private TextBox qOutputBox;
        private Label qUnitLabel;
        private Button clearButton;
    }
}

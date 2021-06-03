
namespace ORSAPR
{
    partial class MainForm
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
            this.textBoxTopLength = new System.Windows.Forms.TextBox();
            this.textBoxTopWidth = new System.Windows.Forms.TextBox();
            this.textBoxTopThickness = new System.Windows.Forms.TextBox();
            this.textBoxShelfWidth = new System.Windows.Forms.TextBox();
            this.textBoxFootLength = new System.Windows.Forms.TextBox();
            this.textBoxBoxLength = new System.Windows.Forms.TextBox();
            this.textBoxBoxHeight = new System.Windows.Forms.TextBox();
            this.textBoxShelfHeight = new System.Windows.Forms.TextBox();
            this.labelTopLength = new System.Windows.Forms.Label();
            this.labelTopWedth = new System.Windows.Forms.Label();
            this.labelTopThickness = new System.Windows.Forms.Label();
            this.labelFootLength = new System.Windows.Forms.Label();
            this.labelBoxLength = new System.Windows.Forms.Label();
            this.labelBoxHeight = new System.Windows.Forms.Label();
            this.labelShelfHeight = new System.Windows.Forms.Label();
            this.labelShelfWidth = new System.Windows.Forms.Label();
            this.textBoxBoxWidth = new System.Windows.Forms.TextBox();
            this.labelBoxWidth = new System.Windows.Forms.Label();
            this.buttonBuild = new System.Windows.Forms.Button();
            this.buttonConfirmParameters = new System.Windows.Forms.Button();
            this.comboBoxSize = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxTopLength
            // 
            this.textBoxTopLength.Location = new System.Drawing.Point(300, 11);
            this.textBoxTopLength.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTopLength.Name = "textBoxTopLength";
            this.textBoxTopLength.Size = new System.Drawing.Size(100, 22);
            this.textBoxTopLength.TabIndex = 0;
            this.textBoxTopLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxAllowOnlyNumbers);
            this.textBoxTopLength.Leave += new System.EventHandler(this.TextBoxLeave);
            // 
            // textBoxTopWidth
            // 
            this.textBoxTopWidth.Location = new System.Drawing.Point(300, 39);
            this.textBoxTopWidth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTopWidth.Name = "textBoxTopWidth";
            this.textBoxTopWidth.Size = new System.Drawing.Size(100, 22);
            this.textBoxTopWidth.TabIndex = 1;
            this.textBoxTopWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxAllowOnlyNumbers);
            this.textBoxTopWidth.Leave += new System.EventHandler(this.TextBoxLeave);
            // 
            // textBoxTopThickness
            // 
            this.textBoxTopThickness.Location = new System.Drawing.Point(300, 66);
            this.textBoxTopThickness.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTopThickness.Name = "textBoxTopThickness";
            this.textBoxTopThickness.Size = new System.Drawing.Size(100, 22);
            this.textBoxTopThickness.TabIndex = 2;
            this.textBoxTopThickness.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxAllowOnlyNumbers);
            this.textBoxTopThickness.Leave += new System.EventHandler(this.TextBoxLeave);
            // 
            // textBoxShelfWidth
            // 
            this.textBoxShelfWidth.Location = new System.Drawing.Point(300, 207);
            this.textBoxShelfWidth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxShelfWidth.Name = "textBoxShelfWidth";
            this.textBoxShelfWidth.Size = new System.Drawing.Size(100, 22);
            this.textBoxShelfWidth.TabIndex = 3;
            this.textBoxShelfWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxAllowOnlyNumbers);
            this.textBoxShelfWidth.Leave += new System.EventHandler(this.TextBoxLeave);
            // 
            // textBoxFootLength
            // 
            this.textBoxFootLength.Location = new System.Drawing.Point(300, 235);
            this.textBoxFootLength.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxFootLength.Name = "textBoxFootLength";
            this.textBoxFootLength.Size = new System.Drawing.Size(100, 22);
            this.textBoxFootLength.TabIndex = 4;
            this.textBoxFootLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxAllowOnlyNumbers);
            this.textBoxFootLength.Leave += new System.EventHandler(this.TextBoxLeave);
            // 
            // textBoxBoxLength
            // 
            this.textBoxBoxLength.Location = new System.Drawing.Point(300, 123);
            this.textBoxBoxLength.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxBoxLength.Name = "textBoxBoxLength";
            this.textBoxBoxLength.Size = new System.Drawing.Size(100, 22);
            this.textBoxBoxLength.TabIndex = 5;
            this.textBoxBoxLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxAllowOnlyNumbers);
            this.textBoxBoxLength.Leave += new System.EventHandler(this.TextBoxLeave);
            // 
            // textBoxBoxHeight
            // 
            this.textBoxBoxHeight.Location = new System.Drawing.Point(300, 151);
            this.textBoxBoxHeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxBoxHeight.Name = "textBoxBoxHeight";
            this.textBoxBoxHeight.Size = new System.Drawing.Size(100, 22);
            this.textBoxBoxHeight.TabIndex = 6;
            this.textBoxBoxHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxAllowOnlyNumbers);
            this.textBoxBoxHeight.Leave += new System.EventHandler(this.TextBoxLeave);
            // 
            // textBoxShelfHeight
            // 
            this.textBoxShelfHeight.Location = new System.Drawing.Point(300, 178);
            this.textBoxShelfHeight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxShelfHeight.Name = "textBoxShelfHeight";
            this.textBoxShelfHeight.Size = new System.Drawing.Size(100, 22);
            this.textBoxShelfHeight.TabIndex = 7;
            this.textBoxShelfHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxAllowOnlyNumbers);
            this.textBoxShelfHeight.Leave += new System.EventHandler(this.TextBoxLeave);
            // 
            // labelTopLength
            // 
            this.labelTopLength.AutoSize = true;
            this.labelTopLength.Location = new System.Drawing.Point(25, 14);
            this.labelTopLength.Name = "labelTopLength";
            this.labelTopLength.Size = new System.Drawing.Size(132, 16);
            this.labelTopLength.TabIndex = 8;
            this.labelTopLength.Text = "Длина столешницы";
            // 
            // labelTopWedth
            // 
            this.labelTopWedth.AutoSize = true;
            this.labelTopWedth.Location = new System.Drawing.Point(25, 42);
            this.labelTopWedth.Name = "labelTopWedth";
            this.labelTopWedth.Size = new System.Drawing.Size(142, 16);
            this.labelTopWedth.TabIndex = 9;
            this.labelTopWedth.Text = "Ширина столешницы";
            // 
            // labelTopThickness
            // 
            this.labelTopThickness.AutoSize = true;
            this.labelTopThickness.Location = new System.Drawing.Point(25, 70);
            this.labelTopThickness.Name = "labelTopThickness";
            this.labelTopThickness.Size = new System.Drawing.Size(149, 16);
            this.labelTopThickness.TabIndex = 10;
            this.labelTopThickness.Text = "Толщина столешницы";
            // 
            // labelFootLength
            // 
            this.labelFootLength.AutoSize = true;
            this.labelFootLength.Location = new System.Drawing.Point(25, 238);
            this.labelFootLength.Name = "labelFootLength";
            this.labelFootLength.Size = new System.Drawing.Size(92, 16);
            this.labelFootLength.TabIndex = 11;
            this.labelFootLength.Text = "Длина ножек";
            // 
            // labelBoxLength
            // 
            this.labelBoxLength.AutoSize = true;
            this.labelBoxLength.Location = new System.Drawing.Point(25, 126);
            this.labelBoxLength.Name = "labelBoxLength";
            this.labelBoxLength.Size = new System.Drawing.Size(91, 16);
            this.labelBoxLength.TabIndex = 12;
            this.labelBoxLength.Text = "Длина ящика";
            // 
            // labelBoxHeight
            // 
            this.labelBoxHeight.AutoSize = true;
            this.labelBoxHeight.Location = new System.Drawing.Point(25, 154);
            this.labelBoxHeight.Name = "labelBoxHeight";
            this.labelBoxHeight.Size = new System.Drawing.Size(98, 16);
            this.labelBoxHeight.TabIndex = 13;
            this.labelBoxHeight.Text = "Высота ящика";
            // 
            // labelShelfHeight
            // 
            this.labelShelfHeight.AutoSize = true;
            this.labelShelfHeight.Location = new System.Drawing.Point(25, 182);
            this.labelShelfHeight.Name = "labelShelfHeight";
            this.labelShelfHeight.Size = new System.Drawing.Size(98, 16);
            this.labelShelfHeight.TabIndex = 14;
            this.labelShelfHeight.Text = "Высота полки";
            // 
            // labelShelfWidth
            // 
            this.labelShelfWidth.AutoSize = true;
            this.labelShelfWidth.Location = new System.Drawing.Point(25, 210);
            this.labelShelfWidth.Name = "labelShelfWidth";
            this.labelShelfWidth.Size = new System.Drawing.Size(101, 16);
            this.labelShelfWidth.TabIndex = 15;
            this.labelShelfWidth.Text = "Ширина полки";
            // 
            // textBoxBoxWidth
            // 
            this.textBoxBoxWidth.Location = new System.Drawing.Point(300, 95);
            this.textBoxBoxWidth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxBoxWidth.Name = "textBoxBoxWidth";
            this.textBoxBoxWidth.Size = new System.Drawing.Size(100, 22);
            this.textBoxBoxWidth.TabIndex = 16;
            this.textBoxBoxWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxAllowOnlyNumbers);
            this.textBoxBoxWidth.Leave += new System.EventHandler(this.TextBoxLeave);
            // 
            // labelBoxWidth
            // 
            this.labelBoxWidth.AutoSize = true;
            this.labelBoxWidth.Location = new System.Drawing.Point(25, 98);
            this.labelBoxWidth.Name = "labelBoxWidth";
            this.labelBoxWidth.Size = new System.Drawing.Size(101, 16);
            this.labelBoxWidth.TabIndex = 17;
            this.labelBoxWidth.Text = "Ширина ящика";
            // 
            // buttonBuild
            // 
            this.buttonBuild.Location = new System.Drawing.Point(160, 345);
            this.buttonBuild.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBuild.Name = "buttonBuild";
            this.buttonBuild.Size = new System.Drawing.Size(100, 30);
            this.buttonBuild.TabIndex = 18;
            this.buttonBuild.Text = "Построить";
            this.buttonBuild.UseVisualStyleBackColor = true;
            this.buttonBuild.Click += new System.EventHandler(this.buttonBuild_Click);
            // 
            // buttonConfirmParameters
            // 
            this.buttonConfirmParameters.Location = new System.Drawing.Point(268, 277);
            this.buttonConfirmParameters.Margin = new System.Windows.Forms.Padding(4);
            this.buttonConfirmParameters.Name = "buttonConfirmParameters";
            this.buttonConfirmParameters.Size = new System.Drawing.Size(135, 28);
            this.buttonConfirmParameters.TabIndex = 21;
            this.buttonConfirmParameters.Text = "Подтвердить";
            this.buttonConfirmParameters.UseVisualStyleBackColor = true;
            this.buttonConfirmParameters.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // comboBoxSize
            // 
            this.comboBoxSize.FormattingEnabled = true;
            this.comboBoxSize.Location = new System.Drawing.Point(28, 277);
            this.comboBoxSize.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSize.Name = "comboBoxSize";
            this.comboBoxSize.Size = new System.Drawing.Size(191, 24);
            this.comboBoxSize.TabIndex = 22;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(421, 396);
            this.Controls.Add(this.comboBoxSize);
            this.Controls.Add(this.buttonConfirmParameters);
            this.Controls.Add(this.buttonBuild);
            this.Controls.Add(this.labelBoxWidth);
            this.Controls.Add(this.textBoxBoxWidth);
            this.Controls.Add(this.labelShelfWidth);
            this.Controls.Add(this.labelShelfHeight);
            this.Controls.Add(this.labelBoxHeight);
            this.Controls.Add(this.labelBoxLength);
            this.Controls.Add(this.labelFootLength);
            this.Controls.Add(this.labelTopThickness);
            this.Controls.Add(this.labelTopWedth);
            this.Controls.Add(this.labelTopLength);
            this.Controls.Add(this.textBoxShelfHeight);
            this.Controls.Add(this.textBoxBoxHeight);
            this.Controls.Add(this.textBoxBoxLength);
            this.Controls.Add(this.textBoxFootLength);
            this.Controls.Add(this.textBoxShelfWidth);
            this.Controls.Add(this.textBoxTopThickness);
            this.Controls.Add(this.textBoxTopWidth);
            this.Controls.Add(this.textBoxTopLength);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(437, 435);
            this.MinimumSize = new System.Drawing.Size(437, 435);
            this.Name = "MainForm";
            this.Text = "Nightstand builder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTopLength;
        private System.Windows.Forms.TextBox textBoxTopWidth;
        private System.Windows.Forms.TextBox textBoxTopThickness;
        private System.Windows.Forms.TextBox textBoxShelfWidth;
        private System.Windows.Forms.TextBox textBoxFootLength;
        private System.Windows.Forms.TextBox textBoxBoxLength;
        private System.Windows.Forms.TextBox textBoxBoxHeight;
        private System.Windows.Forms.TextBox textBoxShelfHeight;
        private System.Windows.Forms.Label labelTopLength;
        private System.Windows.Forms.Label labelTopWedth;
        private System.Windows.Forms.Label labelTopThickness;
        private System.Windows.Forms.Label labelFootLength;
        private System.Windows.Forms.Label labelBoxLength;
        private System.Windows.Forms.Label labelBoxHeight;
        private System.Windows.Forms.Label labelShelfHeight;
        private System.Windows.Forms.Label labelShelfWidth;
        private System.Windows.Forms.TextBox textBoxBoxWidth;
        private System.Windows.Forms.Label labelBoxWidth;
        private System.Windows.Forms.Button buttonBuild;
        private System.Windows.Forms.Button buttonConfirmParameters;
        private System.Windows.Forms.ComboBox comboBoxSize;
    }
}


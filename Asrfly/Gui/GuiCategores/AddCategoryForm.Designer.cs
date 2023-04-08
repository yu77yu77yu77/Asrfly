namespace Asrfly.Gui.GuiCategores
{
    partial class AddCategoryForm
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
            panel1 = new Panel();
            buttonSave = new Button();
            buttonSaveAndClose = new Button();
            groupBox1 = new GroupBox();
            richTextBoxDetailse = new RichTextBox();
            comboBoxType = new ComboBox();
            textBoxBalaince = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBoxName = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonSave);
            panel1.Controls.Add(buttonSaveAndClose);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 573);
            panel1.Name = "panel1";
            panel1.Size = new Size(495, 57);
            panel1.TabIndex = 0;
            // 
            // buttonSave
            // 
            buttonSave.Font = new Font("Bell MT", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSave.Image = Properties.Resources.icons8_save_as_32px;
            buttonSave.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSave.Location = new Point(5, 5);
            buttonSave.Margin = new Padding(5);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(172, 46);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "حفظ";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonSaveAndClose
            // 
            buttonSaveAndClose.Font = new Font("Bahnschrift Condensed", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSaveAndClose.Image = Properties.Resources.icons8_close_pane_32px;
            buttonSaveAndClose.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSaveAndClose.Location = new Point(321, 5);
            buttonSaveAndClose.Margin = new Padding(5);
            buttonSaveAndClose.Name = "buttonSaveAndClose";
            buttonSaveAndClose.Size = new Size(170, 46);
            buttonSaveAndClose.TabIndex = 2;
            buttonSaveAndClose.Text = "حفظ وغلق";
            buttonSaveAndClose.UseVisualStyleBackColor = true;
            buttonSaveAndClose.Click += buttonSaveAndClose_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(richTextBoxDetailse);
            groupBox1.Controls.Add(comboBoxType);
            groupBox1.Controls.Add(textBoxBalaince);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Simplified Arabic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(513, 555);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "معلومات الصنف";
            // 
            // richTextBoxDetailse
            // 
            richTextBoxDetailse.Location = new Point(43, 282);
            richTextBoxDetailse.Name = "richTextBoxDetailse";
            richTextBoxDetailse.Size = new Size(451, 96);
            richTextBoxDetailse.TabIndex = 9;
            richTextBoxDetailse.Text = "";
            // 
            // comboBoxType
            // 
            comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxType.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "صرف", "قبض" });
            comboBoxType.Location = new Point(42, 191);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(452, 38);
            comboBoxType.TabIndex = 8;
            // 
            // textBoxBalaince
            // 
            textBoxBalaince.Enabled = false;
            textBoxBalaince.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxBalaince.Location = new Point(43, 514);
            textBoxBalaince.Name = "textBoxBalaince";
            textBoxBalaince.Size = new Size(451, 35);
            textBoxBalaince.TabIndex = 7;
            textBoxBalaince.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(236, 477);
            label4.Name = "label4";
            label4.Size = new Size(72, 30);
            label4.TabIndex = 6;
            label4.Text = "الرصيد";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(211, 247);
            label3.Name = "label3";
            label3.Size = new Size(137, 30);
            label3.TabIndex = 4;
            label3.Text = "تفاصيل الصنف";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(211, 154);
            label2.Name = "label2";
            label2.Size = new Size(109, 30);
            label2.TabIndex = 2;
            label2.Text = "نوع الصنف";
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.Location = new Point(43, 90);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(452, 35);
            textBoxName.TabIndex = 1;
            textBoxName.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(211, 48);
            label1.Name = "label1";
            label1.Size = new Size(108, 30);
            label1.TabIndex = 0;
            label1.Text = "أسم الصنف";
            // 
            // AddCategoryForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 630);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddCategoryForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "أضافة / تعديل صنف";
            TopMost = true;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox textBoxName;
        private Label label3;
        private Label label2;
        private TextBox textBoxBalaince;
        private Label label4;
        private ComboBox comboBoxType;
        private RichTextBox richTextBoxDetailse;
        private Button buttonSaveAndClose;
        private Button buttonSave;
    }
}
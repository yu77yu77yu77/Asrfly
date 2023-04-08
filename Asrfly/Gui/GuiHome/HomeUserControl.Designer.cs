namespace Asrfly.Gui.GuiHome
{
    partial class HomeUserControl
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
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            buttonAddCategory = new Button();
            label1 = new Label();
            buttonAddCustoer = new Button();
            buttonAddSupplier = new Button();
            buttonAddProject = new Button();
            buttonAddUsers = new Button();
            buttonAddOutput = new Button();
            buttonAddInput = new Button();
            pictureBoxLogo = new PictureBox();
            panel2 = new Panel();
            labelCompanyName = new Label();
            labelWelcome = new Label();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 422);
            panel1.Name = "panel1";
            panel1.Size = new Size(1280, 298);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(buttonAddInput);
            groupBox1.Controls.Add(buttonAddOutput);
            groupBox1.Controls.Add(buttonAddUsers);
            groupBox1.Controls.Add(buttonAddProject);
            groupBox1.Controls.Add(buttonAddSupplier);
            groupBox1.Controls.Add(buttonAddCustoer);
            groupBox1.Controls.Add(buttonAddCategory);
            groupBox1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(3, 103);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1274, 110);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "أضافة";
            // 
            // buttonAddCategory
            // 
            buttonAddCategory.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddCategory.Image = Properties.Resources.icons8_categorize_32px_1;
            buttonAddCategory.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddCategory.Location = new Point(1094, 44);
            buttonAddCategory.Margin = new Padding(5);
            buttonAddCategory.Name = "buttonAddCategory";
            buttonAddCategory.Size = new Size(175, 55);
            buttonAddCategory.TabIndex = 1;
            buttonAddCategory.Text = " الصنف";
            buttonAddCategory.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(633, 56);
            label1.Name = "label1";
            label1.Size = new Size(165, 32);
            label1.TabIndex = 0;
            label1.Text = "الوصول السريع";
            // 
            // buttonAddCustoer
            // 
            buttonAddCustoer.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddCustoer.Image = Properties.Resources.icons8_customer_32px;
            buttonAddCustoer.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddCustoer.Location = new Point(912, 44);
            buttonAddCustoer.Margin = new Padding(5);
            buttonAddCustoer.Name = "buttonAddCustoer";
            buttonAddCustoer.Size = new Size(182, 55);
            buttonAddCustoer.TabIndex = 2;
            buttonAddCustoer.Text = "العميل";
            buttonAddCustoer.UseVisualStyleBackColor = true;
            // 
            // buttonAddSupplier
            // 
            buttonAddSupplier.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddSupplier.Image = Properties.Resources.icons8_customer_30px;
            buttonAddSupplier.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddSupplier.Location = new Point(730, 44);
            buttonAddSupplier.Margin = new Padding(5);
            buttonAddSupplier.Name = "buttonAddSupplier";
            buttonAddSupplier.Size = new Size(182, 55);
            buttonAddSupplier.TabIndex = 3;
            buttonAddSupplier.Text = "المورد";
            buttonAddSupplier.UseVisualStyleBackColor = true;
            // 
            // buttonAddProject
            // 
            buttonAddProject.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddProject.Image = Properties.Resources.icons8_view_quilt_32px_1;
            buttonAddProject.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddProject.Location = new Point(548, 44);
            buttonAddProject.Margin = new Padding(5);
            buttonAddProject.Name = "buttonAddProject";
            buttonAddProject.Size = new Size(182, 55);
            buttonAddProject.TabIndex = 4;
            buttonAddProject.Text = "المشاريع";
            buttonAddProject.UseVisualStyleBackColor = true;
            // 
            // buttonAddUsers
            // 
            buttonAddUsers.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddUsers.Image = Properties.Resources.icons8_staff_skin_type_7_32px;
            buttonAddUsers.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddUsers.Location = new Point(366, 44);
            buttonAddUsers.Margin = new Padding(5);
            buttonAddUsers.Name = "buttonAddUsers";
            buttonAddUsers.Size = new Size(182, 55);
            buttonAddUsers.TabIndex = 5;
            buttonAddUsers.Text = "المستخدم";
            buttonAddUsers.UseVisualStyleBackColor = true;
            // 
            // buttonAddOutput
            // 
            buttonAddOutput.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddOutput.Image = Properties.Resources.icons8_categorize_32px_1;
            buttonAddOutput.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddOutput.Location = new Point(184, 44);
            buttonAddOutput.Margin = new Padding(5);
            buttonAddOutput.Name = "buttonAddOutput";
            buttonAddOutput.Size = new Size(182, 55);
            buttonAddOutput.TabIndex = 6;
            buttonAddOutput.Text = "الصرف";
            buttonAddOutput.UseVisualStyleBackColor = true;
            // 
            // buttonAddInput
            // 
            buttonAddInput.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddInput.Image = Properties.Resources.icons8_categorize_32px_1;
            buttonAddInput.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddInput.Location = new Point(2, 44);
            buttonAddInput.Margin = new Padding(5);
            buttonAddInput.Name = "buttonAddInput";
            buttonAddInput.Size = new Size(182, 55);
            buttonAddInput.TabIndex = 7;
            buttonAddInput.Text = "القبض";
            buttonAddInput.UseVisualStyleBackColor = true;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Dock = DockStyle.Right;
            pictureBoxLogo.Image = Properties.Resources.icons8_smart_96px;
            pictureBoxLogo.Location = new Point(288, 0);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(110, 100);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 3;
            pictureBoxLogo.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.Controls.Add(labelCompanyName);
            panel2.Controls.Add(pictureBoxLogo);
            panel2.Location = new Point(633, 68);
            panel2.Name = "panel2";
            panel2.Size = new Size(398, 100);
            panel2.TabIndex = 1;
            // 
            // labelCompanyName
            // 
            labelCompanyName.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelCompanyName.Location = new Point(44, 9);
            labelCompanyName.Name = "labelCompanyName";
            labelCompanyName.Size = new Size(233, 78);
            labelCompanyName.TabIndex = 4;
            labelCompanyName.Text = "أفق المستقبل";
            labelCompanyName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelWelcome
            // 
            labelWelcome.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelWelcome.Location = new Point(115, 90);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(233, 78);
            labelWelcome.TabIndex = 5;
            labelWelcome.Text = "اهلا بك";
            labelWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = Properties.Resources.icons8_smart_96px;
            pictureBox2.Location = new Point(566, 50);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(61, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // HomeUserControl
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(labelWelcome);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "HomeUserControl";
            RightToLeft = RightToLeft.Yes;
            Size = new Size(1280, 720);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private Button buttonAddCategory;
        private Button buttonAddProject;
        private Button buttonAddSupplier;
        private Button buttonAddCustoer;
        private Button buttonAddInput;
        private Button buttonAddOutput;
        private Button buttonAddUsers;
        private PictureBox pictureBoxLogo;
        private Panel panel2;
        private Label labelCompanyName;
        private Label labelWelcome;
        private PictureBox pictureBox2;
    }
}

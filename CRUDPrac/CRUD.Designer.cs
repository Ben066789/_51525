namespace CRUDPrac
{
    partial class CRUD
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
            firstNameTxt = new TextBox();
            firstNameLbl = new Label();
            lastNameTxt = new TextBox();
            lastNameLbl = new Label();
            middleNameTxt = new TextBox();
            middleNameLbl = new Label();
            genderLbl = new Label();
            maleRadio = new RadioButton();
            femaleRadio = new RadioButton();
            DoBSelector = new DateTimePicker();
            DoBLbl = new Label();
            courseLbl = new Label();
            courseCmb = new ComboBox();
            insertBtn = new Button();
            clearBtn = new Button();
            dataGridView = new DataGridView();
            searchBarTxt = new TextBox();
            searchBarLbl = new Label();
            deleteBtn = new Button();
            updateButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // firstNameTxt
            // 
            firstNameTxt.Location = new Point(124, 93);
            firstNameTxt.Name = "firstNameTxt";
            firstNameTxt.Size = new Size(178, 23);
            firstNameTxt.TabIndex = 0;
            // 
            // firstNameLbl
            // 
            firstNameLbl.AutoSize = true;
            firstNameLbl.Location = new Point(30, 96);
            firstNameLbl.Name = "firstNameLbl";
            firstNameLbl.Size = new Size(64, 15);
            firstNameLbl.TabIndex = 1;
            firstNameLbl.Text = "First Name";
            // 
            // lastNameTxt
            // 
            lastNameTxt.Location = new Point(124, 151);
            lastNameTxt.Name = "lastNameTxt";
            lastNameTxt.Size = new Size(178, 23);
            lastNameTxt.TabIndex = 0;
            // 
            // lastNameLbl
            // 
            lastNameLbl.AutoSize = true;
            lastNameLbl.Location = new Point(30, 154);
            lastNameLbl.Name = "lastNameLbl";
            lastNameLbl.Size = new Size(63, 15);
            lastNameLbl.TabIndex = 1;
            lastNameLbl.Text = "Last Name";
            // 
            // middleNameTxt
            // 
            middleNameTxt.Location = new Point(124, 210);
            middleNameTxt.Name = "middleNameTxt";
            middleNameTxt.Size = new Size(178, 23);
            middleNameTxt.TabIndex = 0;
            // 
            // middleNameLbl
            // 
            middleNameLbl.AutoSize = true;
            middleNameLbl.Location = new Point(30, 213);
            middleNameLbl.Name = "middleNameLbl";
            middleNameLbl.Size = new Size(79, 15);
            middleNameLbl.TabIndex = 1;
            middleNameLbl.Text = "Middle Name";
            // 
            // genderLbl
            // 
            genderLbl.AutoSize = true;
            genderLbl.Location = new Point(30, 269);
            genderLbl.Name = "genderLbl";
            genderLbl.Size = new Size(45, 15);
            genderLbl.TabIndex = 1;
            genderLbl.Text = "Gender";
            // 
            // maleRadio
            // 
            maleRadio.AutoSize = true;
            maleRadio.Location = new Point(124, 265);
            maleRadio.Name = "maleRadio";
            maleRadio.Size = new Size(51, 19);
            maleRadio.TabIndex = 2;
            maleRadio.TabStop = true;
            maleRadio.Text = "Male";
            maleRadio.UseVisualStyleBackColor = true;
            // 
            // femaleRadio
            // 
            femaleRadio.AutoSize = true;
            femaleRadio.Location = new Point(208, 265);
            femaleRadio.Name = "femaleRadio";
            femaleRadio.Size = new Size(63, 19);
            femaleRadio.TabIndex = 3;
            femaleRadio.TabStop = true;
            femaleRadio.Text = "Female";
            femaleRadio.UseVisualStyleBackColor = true;
            // 
            // DoBSelector
            // 
            DoBSelector.Location = new Point(124, 311);
            DoBSelector.Name = "DoBSelector";
            DoBSelector.Size = new Size(178, 23);
            DoBSelector.TabIndex = 4;
            // 
            // DoBLbl
            // 
            DoBLbl.AutoSize = true;
            DoBLbl.Location = new Point(30, 317);
            DoBLbl.Name = "DoBLbl";
            DoBLbl.Size = new Size(73, 15);
            DoBLbl.TabIndex = 1;
            DoBLbl.Text = "Date of Birth";
            // 
            // courseLbl
            // 
            courseLbl.AutoSize = true;
            courseLbl.Location = new Point(31, 368);
            courseLbl.Name = "courseLbl";
            courseLbl.Size = new Size(44, 15);
            courseLbl.TabIndex = 1;
            courseLbl.Text = "Course";
            // 
            // courseCmb
            // 
            courseCmb.FormattingEnabled = true;
            courseCmb.Items.AddRange(new object[] { "Test1", "Test2", "Test3", "Test4" });
            courseCmb.Location = new Point(124, 364);
            courseCmb.Name = "courseCmb";
            courseCmb.Size = new Size(178, 23);
            courseCmb.TabIndex = 5;
            // 
            // insertBtn
            // 
            insertBtn.Location = new Point(124, 422);
            insertBtn.Name = "insertBtn";
            insertBtn.Size = new Size(83, 26);
            insertBtn.TabIndex = 6;
            insertBtn.Text = "Insert";
            insertBtn.UseVisualStyleBackColor = true;
            insertBtn.Click += insertBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(219, 422);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(83, 26);
            clearBtn.TabIndex = 6;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(344, 77);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(624, 339);
            dataGridView.TabIndex = 7;
            // 
            // searchBarTxt
            // 
            searchBarTxt.Location = new Point(790, 48);
            searchBarTxt.Name = "searchBarTxt";
            searchBarTxt.Size = new Size(178, 23);
            searchBarTxt.TabIndex = 0;
            // 
            // searchBarLbl
            // 
            searchBarLbl.AutoSize = true;
            searchBarLbl.Location = new Point(742, 51);
            searchBarLbl.Name = "searchBarLbl";
            searchBarLbl.Size = new Size(42, 15);
            searchBarLbl.TabIndex = 1;
            searchBarLbl.Text = "Search";
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(885, 422);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(83, 26);
            deleteBtn.TabIndex = 6;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(790, 422);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(83, 26);
            updateButton.TabIndex = 6;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // CRUD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(994, 507);
            Controls.Add(dataGridView);
            Controls.Add(updateButton);
            Controls.Add(deleteBtn);
            Controls.Add(clearBtn);
            Controls.Add(insertBtn);
            Controls.Add(courseCmb);
            Controls.Add(DoBSelector);
            Controls.Add(femaleRadio);
            Controls.Add(maleRadio);
            Controls.Add(courseLbl);
            Controls.Add(DoBLbl);
            Controls.Add(genderLbl);
            Controls.Add(middleNameLbl);
            Controls.Add(lastNameLbl);
            Controls.Add(searchBarLbl);
            Controls.Add(firstNameLbl);
            Controls.Add(middleNameTxt);
            Controls.Add(lastNameTxt);
            Controls.Add(searchBarTxt);
            Controls.Add(firstNameTxt);
            Name = "CRUD";
            Text = "Form1";
            //Load += CRUD_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox firstNameTxt;
        private Label firstNameLbl;
        private TextBox lastNameTxt;
        private Label lastNameLbl;
        private TextBox middleNameTxt;
        private Label middleNameLbl;
        private Label genderLbl;
        private RadioButton maleRadio;
        private RadioButton femaleRadio;
        private DateTimePicker DoBSelector;
        private Label DoBLbl;
        private Label courseLbl;
        private ComboBox courseCmb;
        private Button insertBtn;
        private Button clearBtn;
        private DataGridView dataGridView;
        private TextBox searchBarTxt;
        private Label searchBarLbl;
        private Button deleteBtn;
        private Button updateButton;
    }
}

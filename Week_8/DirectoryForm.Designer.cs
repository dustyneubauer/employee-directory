
namespace Week_8
{
    partial class DirectoryForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DirectoryForm));
            this.employeeListBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.employeeListBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.employeeListDataGridView = new System.Windows.Forms.DataGridView();
            this.employeeSearchGroupBox = new System.Windows.Forms.GroupBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.showEmployeesButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeDirectoryDataSet = new Week_8.EmployeeDirectoryDataSet();
            this.employeeListTableAdapter = new Week_8.EmployeeDirectoryDataSetTableAdapters.EmployeeListTableAdapter();
            this.tableAdapterManager = new Week_8.EmployeeDirectoryDataSetTableAdapters.TableAdapterManager();
            this.minSalaryButton = new System.Windows.Forms.Button();
            this.maxSalaryButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employeeListBindingNavigator)).BeginInit();
            this.employeeListBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeListDataGridView)).BeginInit();
            this.employeeSearchGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDirectoryDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeListBindingNavigator
            // 
            this.employeeListBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.employeeListBindingNavigator.BindingSource = this.employeeListBindingSource;
            this.employeeListBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.employeeListBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.employeeListBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.employeeListBindingNavigatorSaveItem});
            this.employeeListBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.employeeListBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.employeeListBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.employeeListBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.employeeListBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.employeeListBindingNavigator.Name = "employeeListBindingNavigator";
            this.employeeListBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.employeeListBindingNavigator.Size = new System.Drawing.Size(738, 25);
            this.employeeListBindingNavigator.TabIndex = 0;
            this.employeeListBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // employeeListBindingNavigatorSaveItem
            // 
            this.employeeListBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.employeeListBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("employeeListBindingNavigatorSaveItem.Image")));
            this.employeeListBindingNavigatorSaveItem.Name = "employeeListBindingNavigatorSaveItem";
            this.employeeListBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.employeeListBindingNavigatorSaveItem.Text = "Save Data";
            this.employeeListBindingNavigatorSaveItem.Click += new System.EventHandler(this.employeeListBindingNavigatorSaveItem_Click);
            // 
            // employeeListDataGridView
            // 
            this.employeeListDataGridView.AutoGenerateColumns = false;
            this.employeeListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.employeeListDataGridView.DataSource = this.employeeListBindingSource;
            this.employeeListDataGridView.Location = new System.Drawing.Point(37, 62);
            this.employeeListDataGridView.Name = "employeeListDataGridView";
            this.employeeListDataGridView.Size = new System.Drawing.Size(300, 220);
            this.employeeListDataGridView.TabIndex = 1;
            // 
            // employeeSearchGroupBox
            // 
            this.employeeSearchGroupBox.Controls.Add(this.searchButton);
            this.employeeSearchGroupBox.Controls.Add(this.searchTextBox);
            this.employeeSearchGroupBox.Location = new System.Drawing.Point(389, 62);
            this.employeeSearchGroupBox.Name = "employeeSearchGroupBox";
            this.employeeSearchGroupBox.Size = new System.Drawing.Size(200, 100);
            this.employeeSearchGroupBox.TabIndex = 2;
            this.employeeSearchGroupBox.TabStop = false;
            this.employeeSearchGroupBox.Text = "Employee Search";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(19, 19);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(175, 20);
            this.searchTextBox.TabIndex = 3;
            // 
            // showEmployeesButton
            // 
            this.showEmployeesButton.Location = new System.Drawing.Point(426, 178);
            this.showEmployeesButton.Name = "showEmployeesButton";
            this.showEmployeesButton.Size = new System.Drawing.Size(142, 40);
            this.showEmployeesButton.TabIndex = 4;
            this.showEmployeesButton.Text = "Show All Employees";
            this.showEmployeesButton.UseVisualStyleBackColor = true;
            this.showEmployeesButton.Click += new System.EventHandler(this.showEmployeesButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(67, 61);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "EmployeeID";
            this.dataGridViewTextBoxColumn1.HeaderText = "EmployeeID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Position";
            this.dataGridViewTextBoxColumn3.HeaderText = "Position";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "HourlyPayRate";
            this.dataGridViewTextBoxColumn4.HeaderText = "HourlyPayRate";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // employeeListBindingSource
            // 
            this.employeeListBindingSource.DataMember = "EmployeeList";
            this.employeeListBindingSource.DataSource = this.employeeDirectoryDataSet;
            // 
            // employeeDirectoryDataSet
            // 
            this.employeeDirectoryDataSet.DataSetName = "EmployeeDirectoryDataSet";
            this.employeeDirectoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeListTableAdapter
            // 
            this.employeeListTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmployeeListTableAdapter = this.employeeListTableAdapter;
            this.tableAdapterManager.UpdateOrder = Week_8.EmployeeDirectoryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // minSalaryButton
            // 
            this.minSalaryButton.Location = new System.Drawing.Point(504, 234);
            this.minSalaryButton.Name = "minSalaryButton";
            this.minSalaryButton.Size = new System.Drawing.Size(79, 48);
            this.minSalaryButton.TabIndex = 5;
            this.minSalaryButton.Text = "Min Salary Button";
            this.minSalaryButton.UseVisualStyleBackColor = true;
            this.minSalaryButton.Click += new System.EventHandler(this.minSalaryButton_Click);
            // 
            // maxSalaryButton
            // 
            this.maxSalaryButton.Location = new System.Drawing.Point(408, 234);
            this.maxSalaryButton.Name = "maxSalaryButton";
            this.maxSalaryButton.Size = new System.Drawing.Size(79, 48);
            this.maxSalaryButton.TabIndex = 6;
            this.maxSalaryButton.Text = "Max Salary Button";
            this.maxSalaryButton.UseVisualStyleBackColor = true;
            this.maxSalaryButton.Click += new System.EventHandler(this.maxSalaryButton_Click);
            // 
            // DirectoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 327);
            this.Controls.Add(this.maxSalaryButton);
            this.Controls.Add(this.minSalaryButton);
            this.Controls.Add(this.showEmployeesButton);
            this.Controls.Add(this.employeeSearchGroupBox);
            this.Controls.Add(this.employeeListDataGridView);
            this.Controls.Add(this.employeeListBindingNavigator);
            this.Name = "DirectoryForm";
            this.Text = "Employee Directory";
            this.Load += new System.EventHandler(this.DirectoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeListBindingNavigator)).EndInit();
            this.employeeListBindingNavigator.ResumeLayout(false);
            this.employeeListBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeListDataGridView)).EndInit();
            this.employeeSearchGroupBox.ResumeLayout(false);
            this.employeeSearchGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDirectoryDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EmployeeDirectoryDataSet employeeDirectoryDataSet;
        private System.Windows.Forms.BindingSource employeeListBindingSource;
        private EmployeeDirectoryDataSetTableAdapters.EmployeeListTableAdapter employeeListTableAdapter;
        private EmployeeDirectoryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator employeeListBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton employeeListBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView employeeListDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.GroupBox employeeSearchGroupBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button showEmployeesButton;
        private System.Windows.Forms.Button minSalaryButton;
        private System.Windows.Forms.Button maxSalaryButton;
    }
}


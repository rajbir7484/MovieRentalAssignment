namespace MovieRentalAssignment
{
    partial class Movie_Rental
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
            this.TabControlSystem = new System.Windows.Forms.TabControl();
            this.Movies = new System.Windows.Forms.TabPage();
            this.MovieDataGridView = new System.Windows.Forms.DataGridView();
            this.Customers = new System.Windows.Forms.TabPage();
            this.CustomersDataGridView = new System.Windows.Forms.DataGridView();
            this.RentedMovies = new System.Windows.Forms.TabPage();
            this.RentalDataGridView = new System.Windows.Forms.DataGridView();
            this.CustomerBox = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1FatherName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.TextBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.AddCustomer = new System.Windows.Forms.Button();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1Show = new System.Windows.Forms.Button();
            this.tbxCustomerID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.DeleteCustomer = new System.Windows.Forms.Button();
            this.UpdateCustomer = new System.Windows.Forms.Button();
            this.GroupBoxReturnMovie = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.DropDownAllCust = new System.Windows.Forms.ComboBox();
            this.btnReturnMovie = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.ddlRentedMovies = new System.Windows.Forms.ComboBox();
            this.gbRentMovie = new System.Windows.Forms.GroupBox();
            this.DropDownMovie = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.DropDownSelectCustomer = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtReturn = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtIsuue = new System.Windows.Forms.DateTimePicker();
            this.btnIssueMovie = new System.Windows.Forms.Button();
            this.buttonAllRented = new System.Windows.Forms.Button();
            this.buttonMostPopular = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBoxMovie = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1ShowData = new System.Windows.Forms.Button();
            this.btnDelMOvie = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.TextBoxMovieID = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxStoryLine = new System.Windows.Forms.TextBox();
            this.btnAddMOvie = new System.Windows.Forms.Button();
            this.TextBoxStarRating = new System.Windows.Forms.TextBox();
            this.TextBoxRent = new System.Windows.Forms.TextBox();
            this.TextBoxGenre = new System.Windows.Forms.TextBox();
            this.TextBoxMOvieTitle = new System.Windows.Forms.TextBox();
            this.TextBoxYear = new System.Windows.Forms.TextBox();
            this.TabControlSystem.SuspendLayout();
            this.Movies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MovieDataGridView)).BeginInit();
            this.Customers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersDataGridView)).BeginInit();
            this.RentedMovies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RentalDataGridView)).BeginInit();
            this.CustomerBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.GroupBoxReturnMovie.SuspendLayout();
            this.gbRentMovie.SuspendLayout();
            this.groupBoxMovie.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControlSystem
            // 
            this.TabControlSystem.Controls.Add(this.Movies);
            this.TabControlSystem.Controls.Add(this.Customers);
            this.TabControlSystem.Controls.Add(this.RentedMovies);
            this.TabControlSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControlSystem.Location = new System.Drawing.Point(3, 2);
            this.TabControlSystem.Margin = new System.Windows.Forms.Padding(4);
            this.TabControlSystem.Name = "TabControlSystem";
            this.TabControlSystem.SelectedIndex = 0;
            this.TabControlSystem.Size = new System.Drawing.Size(1387, 363);
            this.TabControlSystem.TabIndex = 22;
            this.TabControlSystem.SelectedIndexChanged += new System.EventHandler(this.TabControlSystem_SelectedIndexChanged);
            // 
            // Movies
            // 
            this.Movies.Controls.Add(this.MovieDataGridView);
            this.Movies.Location = new System.Drawing.Point(4, 35);
            this.Movies.Margin = new System.Windows.Forms.Padding(4);
            this.Movies.Name = "Movies";
            this.Movies.Padding = new System.Windows.Forms.Padding(4);
            this.Movies.Size = new System.Drawing.Size(1379, 324);
            this.Movies.TabIndex = 1;
            this.Movies.Text = "Movies";
            this.Movies.UseVisualStyleBackColor = true;
            // 
            // MovieDataGridView
            // 
            this.MovieDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MovieDataGridView.Location = new System.Drawing.Point(5, 7);
            this.MovieDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.MovieDataGridView.Name = "MovieDataGridView";
            this.MovieDataGridView.RowHeadersWidth = 51;
            this.MovieDataGridView.Size = new System.Drawing.Size(1389, 309);
            this.MovieDataGridView.TabIndex = 0;
            // 
            // Customers
            // 
            this.Customers.Controls.Add(this.CustomersDataGridView);
            this.Customers.Location = new System.Drawing.Point(4, 35);
            this.Customers.Margin = new System.Windows.Forms.Padding(4);
            this.Customers.Name = "Customers";
            this.Customers.Padding = new System.Windows.Forms.Padding(4);
            this.Customers.Size = new System.Drawing.Size(1379, 324);
            this.Customers.TabIndex = 0;
            this.Customers.Text = "Customers";
            this.Customers.UseVisualStyleBackColor = true;
            // 
            // CustomersDataGridView
            // 
            this.CustomersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomersDataGridView.Location = new System.Drawing.Point(8, 7);
            this.CustomersDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.CustomersDataGridView.Name = "CustomersDataGridView";
            this.CustomersDataGridView.RowHeadersWidth = 51;
            this.CustomersDataGridView.Size = new System.Drawing.Size(1386, 308);
            this.CustomersDataGridView.TabIndex = 0;
            // 
            // RentedMovies
            // 
            this.RentedMovies.BackColor = System.Drawing.Color.Transparent;
            this.RentedMovies.Controls.Add(this.RentalDataGridView);
            this.RentedMovies.Location = new System.Drawing.Point(4, 35);
            this.RentedMovies.Margin = new System.Windows.Forms.Padding(4);
            this.RentedMovies.Name = "RentedMovies";
            this.RentedMovies.Size = new System.Drawing.Size(1379, 324);
            this.RentedMovies.TabIndex = 2;
            this.RentedMovies.Text = "Rented Movies";
            // 
            // RentalDataGridView
            // 
            this.RentalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RentalDataGridView.Location = new System.Drawing.Point(4, 4);
            this.RentalDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.RentalDataGridView.Name = "RentalDataGridView";
            this.RentalDataGridView.RowHeadersWidth = 51;
            this.RentalDataGridView.Size = new System.Drawing.Size(1393, 315);
            this.RentalDataGridView.TabIndex = 0;
            // 
            // CustomerBox
            // 
            this.CustomerBox.BackColor = System.Drawing.Color.White;
            this.CustomerBox.Controls.Add(this.panel1);
            this.CustomerBox.Controls.Add(this.panel2);
            this.CustomerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerBox.Location = new System.Drawing.Point(13, 378);
            this.CustomerBox.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerBox.Name = "CustomerBox";
            this.CustomerBox.Padding = new System.Windows.Forms.Padding(4);
            this.CustomerBox.Size = new System.Drawing.Size(1009, 324);
            this.CustomerBox.TabIndex = 45;
            this.CustomerBox.TabStop = false;
            this.CustomerBox.Text = "Customer";
            this.CustomerBox.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox1FatherName);
            this.panel1.Controls.Add(this.textBoxLastName);
            this.panel1.Controls.Add(this.TextBoxFirstName);
            this.panel1.Controls.Add(this.textBoxAddress);
            this.panel1.Controls.Add(this.AddCustomer);
            this.panel1.Controls.Add(this.textBoxPhone);
            this.panel1.Location = new System.Drawing.Point(9, 33);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 271);
            this.panel1.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(412, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 26);
            this.label6.TabIndex = 62;
            this.label6.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 26);
            this.label5.TabIndex = 61;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(419, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 26);
            this.label4.TabIndex = 60;
            this.label4.Text = "Father\'s Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 26);
            this.label3.TabIndex = 59;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 26);
            this.label2.TabIndex = 58;
            this.label2.Text = "First Name";
            // 
            // textBox1FatherName
            // 
            this.textBox1FatherName.Location = new System.Drawing.Point(421, 44);
            this.textBox1FatherName.Name = "textBox1FatherName";
            this.textBox1FatherName.Size = new System.Drawing.Size(204, 32);
            this.textBox1FatherName.TabIndex = 57;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(217, 44);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(178, 32);
            this.textBoxLastName.TabIndex = 45;
            // 
            // TextBoxFirstName
            // 
            this.TextBoxFirstName.Location = new System.Drawing.Point(19, 44);
            this.TextBoxFirstName.Margin = new System.Windows.Forms.Padding(5);
            this.TextBoxFirstName.Name = "TextBoxFirstName";
            this.TextBoxFirstName.Size = new System.Drawing.Size(168, 32);
            this.TextBoxFirstName.TabIndex = 44;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(19, 123);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(361, 126);
            this.textBoxAddress.TabIndex = 31;
            // 
            // AddCustomer
            // 
            this.AddCustomer.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.AddCustomer.ForeColor = System.Drawing.Color.White;
            this.AddCustomer.Location = new System.Drawing.Point(412, 159);
            this.AddCustomer.Margin = new System.Windows.Forms.Padding(5);
            this.AddCustomer.Name = "AddCustomer";
            this.AddCustomer.Size = new System.Drawing.Size(213, 90);
            this.AddCustomer.TabIndex = 43;
            this.AddCustomer.Text = "Add Customer";
            this.AddCustomer.UseVisualStyleBackColor = false;
            this.AddCustomer.Click += new System.EventHandler(this.AddCustomer_Click);
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(412, 123);
            this.textBoxPhone.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(212, 32);
            this.textBoxPhone.TabIndex = 32;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Khaki;
            this.panel2.Controls.Add(this.button1Show);
            this.panel2.Controls.Add(this.tbxCustomerID);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.DeleteCustomer);
            this.panel2.Controls.Add(this.UpdateCustomer);
            this.panel2.Location = new System.Drawing.Point(663, 30);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(333, 284);
            this.panel2.TabIndex = 55;
            // 
            // button1Show
            // 
            this.button1Show.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.button1Show.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1Show.Location = new System.Drawing.Point(18, 84);
            this.button1Show.Margin = new System.Windows.Forms.Padding(5);
            this.button1Show.Name = "button1Show";
            this.button1Show.Size = new System.Drawing.Size(162, 49);
            this.button1Show.TabIndex = 58;
            this.button1Show.Text = "Show Data";
            this.button1Show.UseVisualStyleBackColor = false;
            this.button1Show.Click += new System.EventHandler(this.button1Show_Click);
            // 
            // tbxCustomerID
            // 
            this.tbxCustomerID.Location = new System.Drawing.Point(157, 28);
            this.tbxCustomerID.Margin = new System.Windows.Forms.Padding(4);
            this.tbxCustomerID.Name = "tbxCustomerID";
            this.tbxCustomerID.Size = new System.Drawing.Size(132, 32);
            this.tbxCustomerID.TabIndex = 57;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(14, 34);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 24);
            this.label13.TabIndex = 56;
            this.label13.Text = "Customer Id:";
            // 
            // DeleteCustomer
            // 
            this.DeleteCustomer.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.DeleteCustomer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DeleteCustomer.Location = new System.Drawing.Point(20, 147);
            this.DeleteCustomer.Margin = new System.Windows.Forms.Padding(5);
            this.DeleteCustomer.Name = "DeleteCustomer";
            this.DeleteCustomer.Size = new System.Drawing.Size(237, 49);
            this.DeleteCustomer.TabIndex = 55;
            this.DeleteCustomer.Text = "Delete Customer";
            this.DeleteCustomer.UseVisualStyleBackColor = false;
            this.DeleteCustomer.Click += new System.EventHandler(this.DeleteCustomer_Click);
            // 
            // UpdateCustomer
            // 
            this.UpdateCustomer.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.UpdateCustomer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.UpdateCustomer.Location = new System.Drawing.Point(20, 210);
            this.UpdateCustomer.Margin = new System.Windows.Forms.Padding(5);
            this.UpdateCustomer.Name = "UpdateCustomer";
            this.UpdateCustomer.Size = new System.Drawing.Size(253, 49);
            this.UpdateCustomer.TabIndex = 54;
            this.UpdateCustomer.Text = "Update Customer";
            this.UpdateCustomer.UseVisualStyleBackColor = false;
            this.UpdateCustomer.Click += new System.EventHandler(this.UpdateCustomer_Click);
            // 
            // GroupBoxReturnMovie
            // 
            this.GroupBoxReturnMovie.BackColor = System.Drawing.Color.White;
            this.GroupBoxReturnMovie.Controls.Add(this.label12);
            this.GroupBoxReturnMovie.Controls.Add(this.DropDownAllCust);
            this.GroupBoxReturnMovie.Controls.Add(this.btnReturnMovie);
            this.GroupBoxReturnMovie.Controls.Add(this.label11);
            this.GroupBoxReturnMovie.Controls.Add(this.ddlRentedMovies);
            this.GroupBoxReturnMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxReturnMovie.Location = new System.Drawing.Point(1409, 37);
            this.GroupBoxReturnMovie.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBoxReturnMovie.Name = "GroupBoxReturnMovie";
            this.GroupBoxReturnMovie.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBoxReturnMovie.Size = new System.Drawing.Size(500, 280);
            this.GroupBoxReturnMovie.TabIndex = 61;
            this.GroupBoxReturnMovie.TabStop = false;
            this.GroupBoxReturnMovie.Text = "Movie Return";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 60);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 26);
            this.label12.TabIndex = 56;
            this.label12.Text = "Customer:";
            // 
            // DropDownAllCust
            // 
            this.DropDownAllCust.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropDownAllCust.FormattingEnabled = true;
            this.DropDownAllCust.Location = new System.Drawing.Point(147, 60);
            this.DropDownAllCust.Margin = new System.Windows.Forms.Padding(4);
            this.DropDownAllCust.Name = "DropDownAllCust";
            this.DropDownAllCust.Size = new System.Drawing.Size(328, 34);
            this.DropDownAllCust.TabIndex = 55;
            this.DropDownAllCust.SelectedIndexChanged += new System.EventHandler(this.DropDownAllCust_SelectedIndexChanged);
            // 
            // btnReturnMovie
            // 
            this.btnReturnMovie.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnReturnMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnMovie.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReturnMovie.Location = new System.Drawing.Point(20, 192);
            this.btnReturnMovie.Margin = new System.Windows.Forms.Padding(5);
            this.btnReturnMovie.Name = "btnReturnMovie";
            this.btnReturnMovie.Size = new System.Drawing.Size(471, 50);
            this.btnReturnMovie.TabIndex = 28;
            this.btnReturnMovie.Text = "Return Movie";
            this.btnReturnMovie.UseVisualStyleBackColor = false;
            this.btnReturnMovie.Click += new System.EventHandler(this.btnReturnMovie_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 124);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(152, 26);
            this.label11.TabIndex = 54;
            this.label11.Text = "Rented Movie:";
            // 
            // ddlRentedMovies
            // 
            this.ddlRentedMovies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlRentedMovies.FormattingEnabled = true;
            this.ddlRentedMovies.Location = new System.Drawing.Point(184, 121);
            this.ddlRentedMovies.Margin = new System.Windows.Forms.Padding(4);
            this.ddlRentedMovies.Name = "ddlRentedMovies";
            this.ddlRentedMovies.Size = new System.Drawing.Size(291, 34);
            this.ddlRentedMovies.TabIndex = 53;
            // 
            // gbRentMovie
            // 
            this.gbRentMovie.BackColor = System.Drawing.Color.White;
            this.gbRentMovie.Controls.Add(this.DropDownMovie);
            this.gbRentMovie.Controls.Add(this.label16);
            this.gbRentMovie.Controls.Add(this.DropDownSelectCustomer);
            this.gbRentMovie.Controls.Add(this.label15);
            this.gbRentMovie.Controls.Add(this.label9);
            this.gbRentMovie.Controls.Add(this.dtReturn);
            this.gbRentMovie.Controls.Add(this.label10);
            this.gbRentMovie.Controls.Add(this.label1);
            this.gbRentMovie.Controls.Add(this.dtIsuue);
            this.gbRentMovie.Controls.Add(this.btnIssueMovie);
            this.gbRentMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRentMovie.Location = new System.Drawing.Point(1407, 333);
            this.gbRentMovie.Margin = new System.Windows.Forms.Padding(4);
            this.gbRentMovie.Name = "gbRentMovie";
            this.gbRentMovie.Padding = new System.Windows.Forms.Padding(4);
            this.gbRentMovie.Size = new System.Drawing.Size(477, 377);
            this.gbRentMovie.TabIndex = 62;
            this.gbRentMovie.TabStop = false;
            this.gbRentMovie.Text = "Movie Rent Panel";
            // 
            // DropDownMovie
            // 
            this.DropDownMovie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropDownMovie.FormattingEnabled = true;
            this.DropDownMovie.Location = new System.Drawing.Point(150, 114);
            this.DropDownMovie.Margin = new System.Windows.Forms.Padding(4);
            this.DropDownMovie.Name = "DropDownMovie";
            this.DropDownMovie.Size = new System.Drawing.Size(283, 34);
            this.DropDownMovie.TabIndex = 70;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(23, 57);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(113, 26);
            this.label16.TabIndex = 69;
            this.label16.Text = "Customer:";
            // 
            // DropDownSelectCustomer
            // 
            this.DropDownSelectCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropDownSelectCustomer.FormattingEnabled = true;
            this.DropDownSelectCustomer.Location = new System.Drawing.Point(150, 57);
            this.DropDownSelectCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.DropDownSelectCustomer.Name = "DropDownSelectCustomer";
            this.DropDownSelectCustomer.Size = new System.Drawing.Size(283, 34);
            this.DropDownSelectCustomer.TabIndex = 68;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(25, 120);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 26);
            this.label15.TabIndex = 56;
            this.label15.Text = "Movie:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 177);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 26);
            this.label9.TabIndex = 49;
            this.label9.Text = "Issue Date:";
            // 
            // dtReturn
            // 
            this.dtReturn.Location = new System.Drawing.Point(168, 234);
            this.dtReturn.Margin = new System.Windows.Forms.Padding(4);
            this.dtReturn.Name = "dtReturn";
            this.dtReturn.Size = new System.Drawing.Size(265, 32);
            this.dtReturn.TabIndex = 51;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 240);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 26);
            this.label10.TabIndex = 52;
            this.label10.Text = "Return Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, -82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 52;
            this.label1.Text = "Select Movie:";
            // 
            // dtIsuue
            // 
            this.dtIsuue.Location = new System.Drawing.Point(155, 175);
            this.dtIsuue.Margin = new System.Windows.Forms.Padding(4);
            this.dtIsuue.Name = "dtIsuue";
            this.dtIsuue.Size = new System.Drawing.Size(278, 32);
            this.dtIsuue.TabIndex = 50;
            // 
            // btnIssueMovie
            // 
            this.btnIssueMovie.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnIssueMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssueMovie.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIssueMovie.Location = new System.Drawing.Point(29, 297);
            this.btnIssueMovie.Margin = new System.Windows.Forms.Padding(5);
            this.btnIssueMovie.Name = "btnIssueMovie";
            this.btnIssueMovie.Size = new System.Drawing.Size(404, 50);
            this.btnIssueMovie.TabIndex = 27;
            this.btnIssueMovie.Text = "Issue Movie";
            this.btnIssueMovie.UseVisualStyleBackColor = false;
            this.btnIssueMovie.Click += new System.EventHandler(this.btnIssueMovie_Click);
            // 
            // buttonAllRented
            // 
            this.buttonAllRented.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonAllRented.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAllRented.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAllRented.Location = new System.Drawing.Point(1060, 386);
            this.buttonAllRented.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAllRented.Name = "buttonAllRented";
            this.buttonAllRented.Size = new System.Drawing.Size(326, 80);
            this.buttonAllRented.TabIndex = 63;
            this.buttonAllRented.Text = "All Rented Movies";
            this.buttonAllRented.UseVisualStyleBackColor = false;
            this.buttonAllRented.Click += new System.EventHandler(this.buttonAllRented_Click);
            // 
            // buttonMostPopular
            // 
            this.buttonMostPopular.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.buttonMostPopular.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMostPopular.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonMostPopular.Location = new System.Drawing.Point(1060, 604);
            this.buttonMostPopular.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMostPopular.Name = "buttonMostPopular";
            this.buttonMostPopular.Size = new System.Drawing.Size(330, 82);
            this.buttonMostPopular.TabIndex = 64;
            this.buttonMostPopular.Text = "Most Popular Movies";
            this.buttonMostPopular.UseVisualStyleBackColor = false;
            this.buttonMostPopular.Click += new System.EventHandler(this.buttonMostPopular_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(1060, 497);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(326, 87);
            this.button3.TabIndex = 65;
            this.button3.Text = "Customer Borrows Most Movies";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBoxMovie
            // 
            this.groupBoxMovie.BackColor = System.Drawing.Color.White;
            this.groupBoxMovie.Controls.Add(this.panel4);
            this.groupBoxMovie.Controls.Add(this.panel3);
            this.groupBoxMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMovie.Location = new System.Drawing.Point(12, 376);
            this.groupBoxMovie.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxMovie.Name = "groupBoxMovie";
            this.groupBoxMovie.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxMovie.Size = new System.Drawing.Size(894, 338);
            this.groupBoxMovie.TabIndex = 66;
            this.groupBoxMovie.TabStop = false;
            this.groupBoxMovie.Text = "Movies";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Khaki;
            this.panel4.Controls.Add(this.button1ShowData);
            this.panel4.Controls.Add(this.btnDelMOvie);
            this.panel4.Controls.Add(this.btnUpdate);
            this.panel4.Controls.Add(this.TextBoxMovieID);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Location = new System.Drawing.Point(629, 37);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(244, 286);
            this.panel4.TabIndex = 63;
            // 
            // button1ShowData
            // 
            this.button1ShowData.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.button1ShowData.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1ShowData.Location = new System.Drawing.Point(25, 78);
            this.button1ShowData.Margin = new System.Windows.Forms.Padding(5);
            this.button1ShowData.Name = "button1ShowData";
            this.button1ShowData.Size = new System.Drawing.Size(143, 49);
            this.button1ShowData.TabIndex = 60;
            this.button1ShowData.Text = "Show Data";
            this.button1ShowData.UseVisualStyleBackColor = false;
            this.button1ShowData.Click += new System.EventHandler(this.button1ShowData_Click);
            // 
            // btnDelMOvie
            // 
            this.btnDelMOvie.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnDelMOvie.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelMOvie.Location = new System.Drawing.Point(25, 138);
            this.btnDelMOvie.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelMOvie.Name = "btnDelMOvie";
            this.btnDelMOvie.Size = new System.Drawing.Size(163, 49);
            this.btnDelMOvie.TabIndex = 60;
            this.btnDelMOvie.Text = "Delete Movie";
            this.btnDelMOvie.UseVisualStyleBackColor = false;
            this.btnDelMOvie.Click += new System.EventHandler(this.btnDelMOvie_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdate.Location = new System.Drawing.Point(25, 199);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(191, 49);
            this.btnUpdate.TabIndex = 62;
            this.btnUpdate.Text = "Update Movie";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // TextBoxMovieID
            // 
            this.TextBoxMovieID.Location = new System.Drawing.Point(116, 26);
            this.TextBoxMovieID.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxMovieID.Name = "TextBoxMovieID";
            this.TextBoxMovieID.Size = new System.Drawing.Size(88, 32);
            this.TextBoxMovieID.TabIndex = 59;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(21, 31);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 24);
            this.label14.TabIndex = 56;
            this.label14.Text = "Movie Id:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Khaki;
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.textBoxStoryLine);
            this.panel3.Controls.Add(this.btnAddMOvie);
            this.panel3.Controls.Add(this.TextBoxStarRating);
            this.panel3.Controls.Add(this.TextBoxRent);
            this.panel3.Controls.Add(this.TextBoxGenre);
            this.panel3.Controls.Add(this.TextBoxMOvieTitle);
            this.panel3.Controls.Add(this.TextBoxYear);
            this.panel3.Location = new System.Drawing.Point(12, 37);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(602, 286);
            this.panel3.TabIndex = 61;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(17, 179);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(63, 26);
            this.label20.TabIndex = 71;
            this.label20.Text = "Story";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(266, 97);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(84, 26);
            this.label19.TabIndex = 70;
            this.label19.Text = "Rent($)";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(18, 96);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 26);
            this.label18.TabIndex = 69;
            this.label18.Text = "Genre";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(446, 13);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(121, 26);
            this.label17.TabIndex = 68;
            this.label17.Text = "Star Rating";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(268, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 26);
            this.label8.TabIndex = 67;
            this.label8.Text = "Release Year";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 26);
            this.label7.TabIndex = 66;
            this.label7.Text = "Movie Title";
            // 
            // textBoxStoryLine
            // 
            this.textBoxStoryLine.Location = new System.Drawing.Point(17, 209);
            this.textBoxStoryLine.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxStoryLine.Multiline = true;
            this.textBoxStoryLine.Name = "textBoxStoryLine";
            this.textBoxStoryLine.Size = new System.Drawing.Size(410, 59);
            this.textBoxStoryLine.TabIndex = 64;
            // 
            // btnAddMOvie
            // 
            this.btnAddMOvie.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnAddMOvie.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddMOvie.Location = new System.Drawing.Point(446, 119);
            this.btnAddMOvie.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddMOvie.Name = "btnAddMOvie";
            this.btnAddMOvie.Size = new System.Drawing.Size(145, 148);
            this.btnAddMOvie.TabIndex = 63;
            this.btnAddMOvie.Text = "Add Movie";
            this.btnAddMOvie.UseVisualStyleBackColor = false;
            this.btnAddMOvie.Click += new System.EventHandler(this.btnAddMOvie_Click);
            // 
            // TextBoxStarRating
            // 
            this.TextBoxStarRating.Location = new System.Drawing.Point(446, 42);
            this.TextBoxStarRating.Margin = new System.Windows.Forms.Padding(5);
            this.TextBoxStarRating.Name = "TextBoxStarRating";
            this.TextBoxStarRating.Size = new System.Drawing.Size(144, 32);
            this.TextBoxStarRating.TabIndex = 61;
            // 
            // TextBoxRent
            // 
            this.TextBoxRent.Location = new System.Drawing.Point(268, 126);
            this.TextBoxRent.Margin = new System.Windows.Forms.Padding(5);
            this.TextBoxRent.Name = "TextBoxRent";
            this.TextBoxRent.ReadOnly = true;
            this.TextBoxRent.Size = new System.Drawing.Size(159, 32);
            this.TextBoxRent.TabIndex = 58;
            // 
            // TextBoxGenre
            // 
            this.TextBoxGenre.Location = new System.Drawing.Point(17, 126);
            this.TextBoxGenre.Margin = new System.Windows.Forms.Padding(5);
            this.TextBoxGenre.Name = "TextBoxGenre";
            this.TextBoxGenre.Size = new System.Drawing.Size(225, 32);
            this.TextBoxGenre.TabIndex = 59;
            // 
            // TextBoxMOvieTitle
            // 
            this.TextBoxMOvieTitle.Location = new System.Drawing.Point(17, 42);
            this.TextBoxMOvieTitle.Margin = new System.Windows.Forms.Padding(5);
            this.TextBoxMOvieTitle.Name = "TextBoxMOvieTitle";
            this.TextBoxMOvieTitle.Size = new System.Drawing.Size(225, 32);
            this.TextBoxMOvieTitle.TabIndex = 54;
            // 
            // TextBoxYear
            // 
            this.TextBoxYear.Location = new System.Drawing.Point(268, 42);
            this.TextBoxYear.Margin = new System.Windows.Forms.Padding(5);
            this.TextBoxYear.Name = "TextBoxYear";
            this.TextBoxYear.Size = new System.Drawing.Size(159, 32);
            this.TextBoxYear.TabIndex = 56;
            this.TextBoxYear.TextChanged += new System.EventHandler(this.TextBoxYear_TextChanged);
            // 
            // Movie_Rental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 727);
            this.Controls.Add(this.groupBoxMovie);
            this.Controls.Add(this.buttonAllRented);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonMostPopular);
            this.Controls.Add(this.gbRentMovie);
            this.Controls.Add(this.GroupBoxReturnMovie);
            this.Controls.Add(this.CustomerBox);
            this.Controls.Add(this.TabControlSystem);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Movie_Rental";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movie_Rental";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Movie_Rental_Load);
            this.TabControlSystem.ResumeLayout(false);
            this.Movies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MovieDataGridView)).EndInit();
            this.Customers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CustomersDataGridView)).EndInit();
            this.RentedMovies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RentalDataGridView)).EndInit();
            this.CustomerBox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.GroupBoxReturnMovie.ResumeLayout(false);
            this.GroupBoxReturnMovie.PerformLayout();
            this.gbRentMovie.ResumeLayout(false);
            this.gbRentMovie.PerformLayout();
            this.groupBoxMovie.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControlSystem;
        private System.Windows.Forms.TabPage Customers;
        private System.Windows.Forms.DataGridView CustomersDataGridView;
        private System.Windows.Forms.TabPage Movies;
        private System.Windows.Forms.DataGridView MovieDataGridView;
        private System.Windows.Forms.TabPage RentedMovies;
        private System.Windows.Forms.DataGridView RentalDataGridView;
        private System.Windows.Forms.GroupBox CustomerBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TextBoxFirstName;
        private System.Windows.Forms.Button AddCustomer;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbxCustomerID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button DeleteCustomer;
        private System.Windows.Forms.Button UpdateCustomer;
        private System.Windows.Forms.GroupBox GroupBoxReturnMovie;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox DropDownAllCust;
        private System.Windows.Forms.Button btnReturnMovie;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox ddlRentedMovies;
        private System.Windows.Forms.GroupBox gbRentMovie;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox DropDownSelectCustomer;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtReturn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtIsuue;
        private System.Windows.Forms.Button btnIssueMovie;
        private System.Windows.Forms.Button buttonAllRented;
        private System.Windows.Forms.Button buttonMostPopular;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBoxMovie;
        private System.Windows.Forms.ComboBox DropDownMovie;
        private System.Windows.Forms.Button button1Show;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1ShowData;
        private System.Windows.Forms.TextBox TextBoxMovieID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxStoryLine;
        private System.Windows.Forms.Button btnAddMOvie;
        private System.Windows.Forms.TextBox TextBoxStarRating;
        private System.Windows.Forms.TextBox TextBoxRent;
        private System.Windows.Forms.TextBox TextBoxGenre;
        private System.Windows.Forms.TextBox TextBoxMOvieTitle;
        private System.Windows.Forms.TextBox TextBoxYear;
        private System.Windows.Forms.Button btnDelMOvie;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1FatherName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}
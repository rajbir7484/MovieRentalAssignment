using MovieRentalAssignment.DataAccessLayer;
using MovieRentalAssignment.PresentationLayer;
using MovieRentalAssignment.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieRentalAssignment
{
    public partial class Movie_Rental : Form
    {
        public Movie_Rental()
        {
            InitializeComponent();
            
        }

        //bind movies table to gridview
        private void MoviesTableGridDataBind()
        {
            DataTable ds = new Movies().ShowAllMovies();
            MovieDataGridView.DataSource = ds;
            MovieDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void Movie_Rental_Load(object sender, EventArgs e)
        {
           //bind dropdown with movies table
            BindDropDownMovie();

            //bind table customer with dropdown
            BindDdlWithCustomer();

            //bind gridview with movies table
            MoviesTableGridDataBind();

            //bind customer table with grid
            BindGridCustomersTbl();

            groupBoxMovie.Visible = true;
            

        }

        //RentedMovie Gridview Bind Data here
        private void RentedMovieGridData()
        {
            DataTable ds = new RentedMOvies().ShowAllRentedMovies();
            RentalDataGridView.DataSource = ds;
            RentalDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        //menu tab control
        private void TabControlSystem_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
               
                if (TabControlSystem.SelectedTab == TabControlSystem.TabPages["Movies"])
                {
                    MoviesTableGridDataBind();
                   
                    groupBoxMovie.Visible = true;
                    CustomerBox.Visible = false;
                   



                }
                else if (TabControlSystem.SelectedTab == TabControlSystem.TabPages["Customers"])
                {
                    groupBoxMovie.Visible = false;
                    CustomerBox.Visible = true;


                    BindGridCustomersTbl();

                }
                else if (TabControlSystem.SelectedTab == TabControlSystem.TabPages["RentedMovies"])
                {
                    RentedMovieGridData(); //show all rented movies
                    groupBoxMovie.Visible = false;
                    CustomerBox.Visible = false;
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DataBaseConnection.CloseConnection(); // close connection with database when error occured
            }
        }

        //Display All Rented Movies
        private void buttonAllRented_Click(object sender, EventArgs e)
        {
            try
            {
                TabControlSystem.SelectedTab = TabControlSystem.TabPages["RentedMovies"];
                RentedMovieGridData();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        //Display Most Popular movies
        private void buttonMostPopular_Click(object sender, EventArgs e)
        {
            try
            {
                TabControlSystem.SelectedTab = TabControlSystem.TabPages["RentedMovies"];
                DataTable dt = new RentedMOvies().MostPopularMovies();
                RentalDataGridView.DataSource = dt;
                RentalDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Get Customers who borrow most movies
        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                TabControlSystem.SelectedTab = TabControlSystem.TabPages["RentedMovies"];
                DataTable dt = new RentedMOvies().CustBorrowMostMovies();
                RentalDataGridView.DataSource = dt;
                RentalDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //add movies to table
        private void btnAddMOvie_Click(object sender, EventArgs e)
        {
            string Title, RentCost, Year, Rating, Genre,StoryLine;
            Title = TextBoxMOvieTitle.Text;
            RentCost = TextBoxRent.Text;
            Rating = TextBoxStarRating.Text;
            Year = TextBoxYear.Text;
            Genre = TextBoxGenre.Text;
            StoryLine = textBoxStoryLine.Text;

            if (Title == "")
            {
                MessageBox.Show("Movie title required!");
                TextBoxMOvieTitle.Focus();
            }
            else if (Year == "")
            {
                MessageBox.Show("Movie released year required!");
                TextBoxYear.Focus();
            }
            else if (Genre == "")
            {
                MessageBox.Show("Movie genre required!");
                TextBoxGenre.Focus();
            }
            else if (Rating == "")
            {
                MessageBox.Show("Movie rating required!");
                TextBoxStarRating.Focus();
            }
            else if (StoryLine == "")
            {
                MessageBox.Show("Story required!");
                textBoxStoryLine.Focus();
            }
            else
            {
                MoviesDataTbl data = new MoviesDataTbl();
                data.Title = Title;
                data.Year = Year;
                data.Rating = Rating;
                data.Genre = Genre;
                data.RentCost = int.Parse(RentCost);
                data.StoryLine = StoryLine;
                if (new Movies().InsertMovie(data))
                {

                    MoviesTableGridDataBind(); // method calling to Bind Grid Movies
                    BindDropDownMovie(); // method calling to Bind dropdown Movies
                    MessageBox.Show("Movie Saved to Database!!");

                    TextBoxMOvieTitle.Text = "";
                    TextBoxYear.Text = "";
                    TextBoxStarRating.Text = "";
                    TextBoxGenre.Text = "";
                    TextBoxRent.Text = "";
                    textBoxStoryLine.Text = "";

                }
            }
        }

        //Complute Movie Rent on the basis of movie release year
        private void TextBoxYear_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string movieReleaseYear = TextBoxYear.Text;
                string currentYear = DateTime.Now.Year.ToString();
                if (movieReleaseYear == "")
                {
                    TextBoxRent.Text = "";
                }

                else
                {
                    int MovieAge = int.Parse(currentYear) - int.Parse(movieReleaseYear);
                    //if movie is older than 5 years (Release Date) then rent cost is $2 otherwise rent cost is $5
                    if (MovieAge > 5)
                    {
                        TextBoxRent.Text = "2";
                    }
                    else
                    {
                        TextBoxRent.Text = "5";
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        //Delete movie
        private void btnDelMOvie_Click(object sender, EventArgs e)
        {
            try
            {
                string movieid = TextBoxMovieID.Text;

                if (new Movies().DeleteMovie(movieid))
                {
                    BindDropDownMovie(); // method calling to Bind comboBox movie
                    MoviesTableGridDataBind(); // method calling to Bind GridView movie
                    MessageBox.Show("Movie Deleted from Database!!");
                    btnAddMOvie.Enabled = true;
                    TextBoxMovieID.Text = "";
                    TextBoxMOvieTitle.Text = "";
                    TextBoxYear.Text = "";
                    TextBoxStarRating.Text = "";
                    TextBoxGenre.Text = "";
                    TextBoxRent.Text = "";
                    textBoxStoryLine.Text = "";
                }
                else
                {
                    MessageBox.Show("Failed! Not able to delete this movie");
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        // Bind DropDownSelectMovie
        private void BindDropDownMovie()
        {
            DataTable ds = new Movies().ShowMovies();

            DataRow row = ds.NewRow();
            row[0] = 0;
            row[1] = "Select...";
            ds.Rows.InsertAt(row, 0); // add item at INDEX = 0;

            // Bind Movie in Dropdown in Movie Rent
            DropDownMovie.DisplayMember = "Title";
            DropDownMovie.ValueMember = "MovieID";
            DropDownMovie.DataSource = ds;
        }

        //Update movie
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string MovieId = TextBoxMovieID.Text;

                string Title, RentCost, Year, Rating, Genre,StoryLine;
                Title = TextBoxMOvieTitle.Text;
                RentCost = TextBoxRent.Text;
                Rating = TextBoxStarRating.Text;
                Year = TextBoxYear.Text;
                Genre = TextBoxGenre.Text;
                StoryLine = textBoxStoryLine.Text;

                if (Title=="")
                {
                    MessageBox.Show("Movie title required!");
                    TextBoxMOvieTitle.Focus();
                }
                else if (Year=="")
                {
                    MessageBox.Show("Movie released year required!");
                    TextBoxYear.Focus();
                }
                
                else if (Genre=="")
                {
                    MessageBox.Show("Movie genre required!");
                    TextBoxGenre.Focus();
                }
                else if (RentCost=="")
                {
                    MessageBox.Show("Movie rent cost required!");
                }
                else if (StoryLine == "")
                {
                    MessageBox.Show("Story required!");
                    textBoxStoryLine.Focus();
                }
                else if (Rating=="")
                {
                    MessageBox.Show("Movie rating required!");
                    TextBoxStarRating.Focus();
                }
               
                else
                {
                    MoviesDataTbl data = new MoviesDataTbl();
                    data.Title = Title;
                    data.Year = Year;
                    data.Rating = Rating;
                    data.Genre = Genre;
                    data.RentCost = int.Parse(RentCost);
                    data.MovieId = int.Parse(MovieId);
                    data.StoryLine = StoryLine;
                    if (new Movies().UpdateMovie(data))
                    {

                        MoviesTableGridDataBind();
                        BindDropDownMovie();
                      
                        btnAddMOvie.Enabled = true; // enable Add movie button
                        MessageBox.Show("Movie Updated!!");
                        TextBoxMovieID.Text = "";
                        TextBoxMOvieTitle.Text = "";
                        TextBoxYear.Text = "";
                        TextBoxStarRating.Text = "";
                        TextBoxGenre.Text = "";
                        TextBoxRent.Text = "";
                        textBoxStoryLine.Text = "";

                    }
                    else
                    {
                        MessageBox.Show("Unable to update this movie!");

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DataBaseConnection.CloseConnection(); // close connection with database when error occured
            }
        }


        //dropdown Customer bind data 
        private void BindDdlWithCustomer()
        {
            DataTable ds = new Customer().DisplayAllCustomers();

            DataRow row = ds.NewRow();
            row[0] = 0;
            row[1] = "Select...";
            ds.Rows.InsertAt(row, 0); // add item at INDEX = 0;

            DropDownSelectCustomer.DisplayMember = "name";
            DropDownSelectCustomer.ValueMember = "CustId";
            DropDownSelectCustomer.DataSource = ds; // Bind customer in Movie Rent Panel

            // Bind customer in Movie Return section **********************************
            DropDownAllCust.DisplayMember = "name";
            DropDownAllCust.ValueMember = "CustId";
            DropDownAllCust.DataSource = ds;

        }

        //Issue movie to selected customer
        private void btnIssueMovie_Click(object sender, EventArgs e)
        {
            try
            {
                string CustId, MovieId, IssueDate, ReturnDate;
                int totalDays = 0;
                int temp = 0;
                int TotalRent = 0;
                CustId = DropDownSelectCustomer.SelectedValue.ToString();
                MovieId = DropDownMovie.SelectedValue.ToString();
                IssueDate = dtIsuue.Value.ToShortDateString();
                ReturnDate = dtReturn.Value.ToShortDateString();

                if (CustId=="" || CustId == "0" || CustId==null)
                {
                    MessageBox.Show("Please select customer");
                }
                else if (MovieId.Equals("") || MovieId == "0" || MovieId==null)
                {
                    MessageBox.Show("Please select movie");
                }

                else if (DateTime.Parse(IssueDate) > DateTime.Parse(ReturnDate))
                {
                    MessageBox.Show("Issue date can not be greater than retun date", "Alert");
                }
                else if (IssueDate == ReturnDate)
                {
                    totalDays = 1;  
                    temp = new Movies().CalculateMovieCost(int.Parse(MovieId)); // Getting rent amount for that movie

                    TotalRent = totalDays * temp; // Calculate the Total Rent of issue movie
                }
                else
                {
                   
                    totalDays = new CalculateDays().GetTotalDays(IssueDate, ReturnDate);
                   
                    temp = new Movies().CalculateMovieCost(int.Parse(MovieId)); // Getting rent amount for that movie

                    TotalRent = totalDays * temp; // Calculate the Total Rent of issue movie
                }

                RentedMoviesDataTbl rmdata = new RentedMoviesDataTbl();
                rmdata.MovieId = int.Parse(MovieId);
                rmdata.CustId = int.Parse(CustId);
                rmdata.RentDate = IssueDate;
                rmdata.ReturnDate = ReturnDate;
                rmdata.TotalRentAmount = TotalRent;
            
                if (new RentedMOvies().InsertRentedMovie(rmdata))
                {
                    TabControlSystem.SelectedTab = TabControlSystem.TabPages["RentedMovies"];
                    RentedMovieGridData();
                    MessageBox.Show("Movie rented successfully!");

                }
                else
                {
                    MessageBox.Show("Failed to rent this movie!");
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Display all rented movies from customer
        private void DropDownAllCust_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int customerId = int.Parse(DropDownAllCust.SelectedValue.ToString());
                if (customerId > 0)
                {
                    ddlRentedMovies.Enabled = true;
                    DataTable dsRented = new RentedMOvies().ShowRentedMoviesDDL(customerId);

                    if (dsRented.Rows.Count > 0)
                    {
                        DataRow row = dsRented.NewRow();
                        row[0] = 0;
                        row[1] = "Select...";
                        dsRented.Rows.InsertAt(row, 0); // add item at INDEX = 0;

                        ddlRentedMovies.DisplayMember = "Title";
                        ddlRentedMovies.ValueMember = "MovieId";
                        ddlRentedMovies.DataSource = dsRented;
                    }
                    else
                    {
                        ddlRentedMovies.Enabled = false;
                    }
                }
                else
                {
                    ddlRentedMovies.Enabled = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //Customer table GridView DataBind
        private void BindGridCustomersTbl()
        {
            DataTable ds = new Customer().ShowCustomersTbl();
            CustomersDataGridView.DataSource = ds;
            CustomersDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        //Delete Customer from db
        private void DeleteCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                string custId = tbxCustomerID.Text;

                    if (new Customer().DeleteCustomerTblData(custId))
                    {
                        BindDdlWithCustomer(); // method calling to Bind comboBox Customer
                        BindGridCustomersTbl(); // method calling to Bind GridView Customer

                        AddCustomer.Enabled = true;
                        MessageBox.Show("Customer Deleted Successfully!");
                        TextBoxFirstName.Text = "";
                        textBoxLastName.Text = "";
                        textBox1FatherName.Text = "";
                        textBoxAddress.Text = "";
                        textBoxPhone.Text = "";
                        tbxCustomerID.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Unable to delete this customer");
                    }
                
            }
            catch (Exception ex)
            {

                if (ex.Message.Contains("REFERENCE"))
                {
                    MessageBox.Show("Can not delete this customer as the customer rented a movie!");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                    DataBaseConnection.CloseConnection(); // close connection with database when error occured
                }
            }
        }

        //Add Customers to database
        private void AddCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                
                    string Firstname,Lastname, address, phone, fatherName;
                    Firstname = TextBoxFirstName.Text;
                    Lastname = textBoxLastName.Text;
                    address = textBoxAddress.Text;
                    phone = textBoxPhone.Text;
                    fatherName = textBox1FatherName.Text;

                    if (Firstname=="")
                    {
                        MessageBox.Show("First name required!");
                        TextBoxFirstName.Focus();
                    }
                    else if (Lastname == "")
                    {
                        MessageBox.Show("Last name required!");
                        textBoxLastName.Focus();
                    }
                    else if (fatherName == "")
                    {
                        MessageBox.Show("Father's name required!");
                        textBox1FatherName.Focus();
                    }
                    else if (address=="")
                    {
                        MessageBox.Show("Address required!");
                        textBoxAddress.Focus();
                    }
                    else if (phone=="")
                    {
                        MessageBox.Show("Phone number required!");
                        textBoxPhone.Focus();
                    }
                    
                    else
                    {
                        CustomerDataTbl data = new CustomerDataTbl();
                        data.FirstName = Firstname;
                        data.LastName = Lastname;
                        data.fatherName = fatherName;
                        data.Address = address;
                        data.Phone = phone;
                        if (new Customer().AddCustomerData(data))
                        {

                        BindDdlWithCustomer(); // bind customer table to combobox
                        BindGridCustomersTbl(); // Bind GridView with Customer table

                        MessageBox.Show("Customer Saved to Database!!");

                        TextBoxFirstName.Text = "";
                        textBoxLastName.Text = "";
                        textBoxAddress.Text = "";
                        textBox1FatherName.Text = "";
                        textBoxPhone.Text = "";
                    }
                        else
                        {
                            MessageBox.Show("Unable to add this customer!");
                        }
                    }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DataBaseConnection.CloseConnection(); // close DB connection when error occured
            }
        }

        //Update Customer table data
        private void UpdateCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                string custId = tbxCustomerID.Text;
                string FirstName,LastName, fatherName,address, phone;
                LastName = textBoxLastName.Text;
                FirstName = TextBoxFirstName.Text;
                address = textBoxAddress.Text;
                phone = textBoxPhone.Text;
                fatherName = textBox1FatherName.Text;

                if (FirstName == "")
                {
                    MessageBox.Show("First name required!");
                    TextBoxFirstName.Focus();
                }
                else if (LastName == "")
                {
                    MessageBox.Show("Last name required!");
                    textBoxLastName.Focus();
                }
                else if (fatherName == "")
                {
                    MessageBox.Show("Father's name required!");
                    textBox1FatherName.Focus();
                }
                else if (address == "")
                {
                    MessageBox.Show("Address required!");
                    textBoxAddress.Focus();
                }
                else if (phone == "")
                {
                    MessageBox.Show("Phone number required!");
                    textBoxPhone.Focus();
                }
                else
                {
                    CustomerDataTbl data = new CustomerDataTbl();
                    data.FirstName = FirstName;
                    data.LastName = LastName;
                    data.Address = address;
                    data.Phone = phone;
                    data.fatherName = fatherName;
                    data.CustId = int.Parse(custId);
                    if (new Customer().UpdateCustomerInformation(data))
                    {
                        AddCustomer.Enabled = true;
                        BindDdlWithCustomer();      // Bind comboBox with Customer table
                        BindGridCustomersTbl(); // BindGridView with Customer table
                        MessageBox.Show("Customer Data Updated!");
                        TextBoxFirstName.Text = "";
                        textBoxLastName.Text = "";
                        textBoxAddress.Text = "";
                        textBox1FatherName.Text = "";
                        textBoxPhone.Text = "";
                        tbxCustomerID.Text = "";

                    }
                    else
                    {
                        MessageBox.Show("Unable to update this customer!!");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DataBaseConnection.CloseConnection(); // close connection with database when error occured
            }
        }

        //Display Movie information in TextBoxes
        private void button1ShowData_Click(object sender, EventArgs e)
        {
            try
            {
                string movieid = TextBoxMovieID.Text;
                if (movieid != "")
                {
                    MoviesDataTbl data = new Movies().ShowMovieInfoById(int.Parse(movieid));
                    if (data != null)
                    {
                        btnAddMOvie.Enabled = false;
                        TextBoxMOvieTitle.Text = data.Title;
                        TextBoxYear.Text = data.Year;
                        TextBoxStarRating.Text = data.Rating;
                        TextBoxGenre.Text = data.Genre;
                        TextBoxRent.Text = data.RentCost.ToString();
                        textBoxStoryLine.Text = data.StoryLine;
                    }
                    else
                    {
                        MessageBox.Show("No Movies Found!!");
                        TextBoxMovieID.Focus();
                        TextBoxMOvieTitle.Text = "";
                        TextBoxYear.Text = "";
                        TextBoxStarRating.Text = "";
                        TextBoxGenre.Text = "";
                        TextBoxRent.Text = "";
                        textBoxStoryLine.Text = "";
                        
                    }
                }
                else
                {
                    MessageBox.Show("MovieId required!!");
                    TextBoxMovieID.Focus();

                }

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        //show customer info in textboxes
        private void button1Show_Click(object sender, EventArgs e)
        {
            try
            {
                string customerID = tbxCustomerID.Text;

                if (customerID != "")
                {
                    CustomerDataTbl data = new Customer().ShowCustomerFromID(int.Parse(customerID));
                    if (data != null)
                    {
                        AddCustomer.Enabled = false;
                        TextBoxFirstName.Text = data.FirstName;
                        textBoxLastName.Text = data.LastName;
                        textBoxAddress.Text = data.Address;
                        textBoxPhone.Text = data.Phone;
                        textBox1FatherName.Text = data.fatherName;
                    }
                    else
                    {
                        MessageBox.Show("No Record Found!");
                        tbxCustomerID.Focus();
                        TextBoxFirstName.Text = "";
                        textBoxLastName.Text = "";
                        textBoxAddress.Text = "";
                        textBoxPhone.Text = "";
                        textBox1FatherName.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("CustomerID required!!");
                    tbxCustomerID.Focus();
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        //Return Movie
        private void btnReturnMovie_Click(object sender, EventArgs e)
        {
            try
            {
                int MoviID = int.Parse(ddlRentedMovies.SelectedValue.ToString());
                int CustId = int.Parse(DropDownAllCust.SelectedValue.ToString());
                if (new RentedMOvies().ReturnThisMovie(MoviID, CustId))
                {

                    RentedMovieGridData(); //method calling to Bind Grid for all rental movies

                    MessageBox.Show("Movie Returned Successfully!");
                    DropDownAllCust.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Unable to return this movie!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}

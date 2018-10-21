using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        /*try
        {
            System.Data.SqlClient.SqlConnection sc = new System.Data.SqlClient.SqlConnection();
            sc.ConnectionString = @"Server =Localhost;Database=Lab1;Trusted_Connection=Yes;";
            //Open the sql connection
            sc.Open();

            //Creates a new sql insert command to insert the data from the arrays into the Person Tabl
            System.Data.SqlClient.SqlCommand insert = new System.Data.SqlClient.SqlCommand();
            insert.Connection = sc;
            for (int i = 0; i < index; i++)
            {
                insert.Comm
            }

        }
        catch (Exception)
        {
            //resultmessage.Text = "Error Clearing Database.";
        }

        //Open the sql connection
        sc.Open();

        */
    }

    public class Person
    {
        //make this private later after getters and setters are made
        public static int index = 0;
        private string fName;
        private string lName;
        private string mName;

        private string houseNum;
        private string street;
        private string cityCo;
        private string stateAbb;
        private string CountryAbb;
        private string zip;

        private DateTime dofBirth;
        private DateTime hireDate;
        private DateTime termDate;

        private Boolean validPermit;
        private string rabiesVaccinated;
        public  int age;
        private double yrHour;
        


        //also make this private after getters and setters are made
        public static Person[] pArr = new Person[3];

        public Person(string nameF, string nameL, string nameM, string houseN,
                      string st, string city, string state, string country, string z,
                      DateTime dOB, DateTime hDate, DateTime tDate, Boolean vac,Boolean perm,
                      int age, double yrHour)
        {
            SetFName(nameF);
            SetLName(nameL);
            SetMName(nameM);

            SetHouseNum(houseN);
            SetStreet(st);
            SetCityCo(city);
            SetStateAbb(state);
            SetCountryAbb(country);
            SetZip(z);

            SetdofBirth(dOB);
            SetHireDate(hDate);
            SetTermDate(tDate);

            //make a method that validates vac for now, just use an if statement
            if (vac == true)
            {
                SetRabiesVaccinated("Y");
            } else
            {
                SetRabiesVaccinated("N");
            }

            SetValidPermit(perm);
            SetAge(age);
            SetYrHour(yrHour);
        }

        public void SetFName(string a)
        {
            this.fName = a;
        }

        public string GetFName()
        {
            return this.fName;
        }

        public void SetLName(string a)
        {
            this.lName = a;
        }

        public string GetLName()
        {
            return this.lName;
        }

        public void SetMName(string a)
        {
            this.mName = a;
        }

        public string GetMName()
        {
            return this.mName;
        }

        public void SetHouseNum(string a)
        {
            this.houseNum = a;
        }

        public string GetHouseNum()
        {
            return this.houseNum;
        }

        public void SetStreet(string a)
        {
            this.street = a;
        }

        public string GetStreet()
        {
            return this.street;
        }

        public void SetCityCo(string a)
        {
            this.cityCo = a;
        }

        public string GetCityCo()
        {
            return this.cityCo;
        }

        public void SetStateAbb(string a)
        {
            this.stateAbb = a;
        }

        public string GetStateABB()
        {
            return this.stateAbb;
        }

        public void SetCountryAbb(string a)
        {
            this.CountryAbb = a;
        }

        public string GetCountryAbb()
        {
            return this.CountryAbb;
        }

        public void SetZip(string a)
        {
            this.zip = a;
        }

        public string GetZip()
        {
            return this.zip;
        }

        public void SetdofBirth(DateTime a)
        {
            this.dofBirth = a;
        }

        public DateTime GetdofBirth()
        {
            return this.dofBirth;
        }

        public void SetHireDate(DateTime a)
        {
            this.hireDate = a;
        }

        public DateTime GetHireDate()
        {
            return this.hireDate;
        }

        public void SetTermDate(DateTime a)
        {
            this.termDate = a;
        }

        public DateTime GetTermDate()
        {
            return this.termDate;
        }

        public void SetRabiesVaccinated(string a)
        {
            this.rabiesVaccinated = a;
        }

        public string GetRabiesVaccinated()
        {
            return this.rabiesVaccinated;
        }

        public void SetAge(int a)
        {
            this.age = a;
        }

        public int GetAge()
        {
            return this.age;
        }

        public void SetYrHour(double a)
        {
            this.yrHour = a;
        }

        public double GetYrHour()
        {
            return this.yrHour;
        }

        public void SetValidPermit(Boolean a)
        {
            this.validPermit = a;
        }

        public Boolean GetValidPermit()
        {
            return this.validPermit;
        }
    }

    protected void InsertB_Click(object sender, EventArgs e)
    {
        indexSize.Text = "" + Person.index;
        
        if (!IsFormValid())
        {
            errorText.Text = "Form is incomplete";
        }
        else
        {

            if (Person.index > 2)
            {
                errorText.Text = "Array Size Exceeded";
            }
            else
            {

                if (IfNameExists())
                {
                    errorText.Text = "Name Already Exists";
                }
                else
                {
                    //if (validateDates())
                    //{
                        Person current = new Person(fNameText.Text, lNameText.Text, mNameText.Text,
                                            houseNumText.Text, streetText.Text, cityCoText.Text,
                                            "null", countryAbbText.Text, zipText.Text,
                                            DateTime.Parse(dobText.Text), DateTime.Parse(hireDateText.Text),
                                            DateTime.Parse(termDateText.Text), vacY.Checked, ValidPermitY.Checked, int.Parse(ageText.Text), double.Parse(yrHourText.Text));
                        Person.pArr[Person.index] = current;
                        Person.index++;
                        uneditableText.Text = "" + current.age;
                        //testing

                        pTest1.Text = "" + Person.pArr[0].GetFName() + " " + Person.pArr[0].GetLName() + " " + Person.pArr[0].GetMName() + "\n" + Person.pArr[0].GetHouseNum() + "\n" + Person.pArr[0].GetStreet() + "\n" + Person.pArr[0].GetCityCo() + "\n"
                        + Person.pArr[0].GetCountryAbb() + "\n";
                        if (Person.pArr[1] == null) { }
                        else
                        {
                            pTest2.Text = "" + Person.pArr[1].GetFName() + " " + Person.pArr[1].GetLName() + " " + Person.pArr[1].GetMName() + "\n" + Person.pArr[1].GetHouseNum() + "\n" + Person.pArr[1].GetStreet() + "\n" + Person.pArr[1].GetCityCo() + "\n"
                        + Person.pArr[1].GetCountryAbb() + "\n";
                        }
                        if (Person.pArr[2] == null) { }
                        else
                        {
                            pTest3.Text = "" + Person.pArr[2].GetFName() + " " + Person.pArr[2].GetLName() + " " + Person.pArr[2].GetMName() + "\n" + Person.pArr[2].GetHouseNum() + "\n" + Person.pArr[2].GetStreet() + "\n" + Person.pArr[2].GetCityCo() + "\n"
                            + Person.pArr[2].GetCountryAbb() + "\n";
                        }
                    //}
                    
                }
            }
        }
    }

    protected void CommitB_Click(object sender, EventArgs e)
    {
        ClearFields();
    }

    protected void ClearB_Click(object sender, EventArgs e)
    {
        ClearFields();
    }

    protected void PopB_Click(object sender, EventArgs e)
    {
        fNameText.Text = "Matt";
        lNameText.Text = "Bosek";
        mNameText.Text = "None";
        houseNumText.Text = "333";
        streetText.Text = "Univeristy Boulevard";
        cityCoText.Text = "Leesburg";
        countryAbbText.Text = "US";
        zipText.Text = "22801";
        dobText.Text = "05/02/1995";
        hireDateText.Text = "08/17/2018";
        termDateText.Text = "08/18/2018";
        yrHourText.Text = "2500";
        vacN.Checked = true;
        ValidPermitY.Checked = true;
    }

    protected void ExitB_Click(object sender, EventArgs e)
    {

    }

    public Boolean IsFormValid()
    {   
        return IsFNameValid() && IsLNameValid();
    }

    public Boolean IsFNameValid()
    {
        Boolean result = true;
        if (fNameText.Text.Equals("") || fNameText.Text.Equals(" "))
        {
            TextBox1.Text = "*";
            result = false;
        } else
        {
            TextBox1.Text = "";
        }
        return result;
    }

    public Boolean IsLNameValid()
    {
        Boolean result = true;
        if (lNameText.Text.Equals("") || lNameText.Text.Equals(" "))
        {
            TextBox2.Text = "*";
            result = false;
        } else
        {
            TextBox2.Text = "";
        }
        return result;
    }

    public Boolean IsStreetValid()
    {
        Boolean result = true;
        if (streetText.Text.Equals("") || streetText.Text.Equals(" "))
        {
            TextBox4.Text = "*";
            result = false;
        } else
        {
            TextBox4.Text = "";
        }
        return result;
    }
    //not completed
    public Boolean IsDOBValid()
    {
        Boolean result = true;
        return result;
        
    }

    public Boolean IfNameExists()
    {
        Boolean result = false;
        //loop through insert array
        for (int i = 0; i < Person.pArr.Length; i++)
        {
            //check if reference exists
            if (Person.pArr[i] != null)
            {

                //matches what is in text box with indexed Person
                //If First name, last name, and middle name match, return
                //true
                if ((Person.pArr[i].GetFName() == fNameText.Text)
                     && (Person.pArr[i].GetLName() == lNameText.Text)
                     && (Person.pArr[i].GetMName() == mNameText.Text))
                {
                    result = true;
                }
            }
        }
        return result;
    }

    public Boolean ValidateDates()
    {
        return ValidateDob() && ValidateHireDate() && ValidateTermDate();

    }

    public Boolean ValidateDob()
    {
        Boolean result = true;
        DateTime tester;
        if (!DateTime.TryParse(dobText.Text, out tester))
        {
            errorText.Text = "invalid date";
            TextBox9.Text = "*";
            result = false;
        }
        return result;
    }

    public Boolean ValidateHireDate()
    {
        Boolean result = true;
        DateTime tester;
        if (!DateTime.TryParse(hireDateText.Text, out tester))
        {
            errorText.Text = "invalid date";
            TextBox10.Text = "*";
            result = false;
        }
        return result;
    }

    public Boolean ValidateTermDate()
    {
        Boolean result = true;
        DateTime tester;
        if (!String.IsNullOrEmpty(termDateText.Text))
        {
            if (!DateTime.TryParse(termDateText.Text, out tester))
            {
                errorText.Text = "invalid date";
                TextBox11.Text = "*";
                result = false;
            }
        }
        
        return result;
    }

    public void ClearFields()
    {
        fNameText.Text = "";
        lNameText.Text = "";
        mNameText.Text = "";
        houseNumText.Text = "";
        streetText.Text = "";
        cityCoText.Text = "";
        countryAbbText.Text = "";
        //state abb
        zipText.Text = "";
        dobText.Text = "";
        hireDateText.Text = "";
        termDateText.Text = "";
        ValidPermitY.Checked = false;
        ValidPermitN.Checked = false;
        vacY.Checked = false;
        vacN.Checked = false;
        ageText.Text = ""; 
    }
}
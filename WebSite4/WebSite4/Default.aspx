<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        
    </style>
</head>
<body style="height: 734px; width: 803px;">
    <form id="form1" runat="server">
        <asp:Button ID="insertB" runat="server" Text="Insert" OnClick="InsertB_Click" />
        <asp:Button ID="commitB" runat="server" Text="Commit" OnClick="CommitB_Click" />
        <asp:Button ID="clearB" runat="server" Text="Clear" OnClick="ClearB_Click" />
        <asp:Button ID="popB" runat="server" Text="Populate" OnClick="PopB_Click" />
        <asp:Button ID="exitB" runat="server" Text="Exit" OnClick="ExitB_Click" />
        <fieldset id="personName">
            <legend>Employee Name</legend>
            <asp:Label ID="FirstName" runat="server" Text="First Name"></asp:Label>       
            <br />     
            <asp:TextBox ID="fNameText" runat="server" MaxLength="25"></asp:TextBox> 
            <asp:TextBox ID="TextBox1" runat="server" BorderStyle="None" ForeColor="Red"></asp:TextBox>
            <br />
            
            <asp:Label ID="LastName" runat="server" Text="Last Name"></asp:Label><br />
            <asp:TextBox ID="lNameText" runat="server" MaxLength="30"></asp:TextBox>
            <asp:TextBox ID="TextBox2" runat="server" BorderStyle="None" ForeColor="Red"></asp:TextBox>
            <br />
            <asp:Label ID="MiddleL" runat="server" Text="Middle Name"></asp:Label><br />
            <asp:TextBox ID="mNameText" runat="server" MaxLength="30"></asp:TextBox>
        </fieldset>
        <fieldset id="address">
            <legend>Address</legend>
            <asp:Label ID="houseL" runat="server" Text="House Number"></asp:Label><br />
            <asp:TextBox ID="houseNumText" runat="server" MaxLength="10"></asp:TextBox>
            <br />
            <asp:Label ID="streetL" runat="server" Text="Street"></asp:Label><br />
            <asp:TextBox ID="streetText" runat="server" MaxLength="20"></asp:TextBox>
            <asp:TextBox ID="TextBox4" runat="server" BorderStyle="None" ForeColor="Red"></asp:TextBox>
            <br />
            <asp:Label ID="cityL" runat="server" Text="City/County"></asp:Label><br />
            <asp:TextBox ID="cityCoText" runat="server" MaxLength="30"></asp:TextBox>
            <asp:TextBox ID="TextBox5" runat="server" BorderStyle="None" ForeColor="Red"></asp:TextBox>
            <br />
            <asp:Label ID="countryL" runat="server" Text="Country Abbr."></asp:Label><br />
            <asp:TextBox ID="countryAbbText" runat="server" MaxLength="35"></asp:TextBox>
            <asp:TextBox ID="TextBox7" runat="server" BorderStyle="None" ForeColor="Red"></asp:TextBox>  
            <br />
            <asp:Label ID="stateL" runat="server" Text="State Abbr."></asp:Label><br />
            <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>
            <asp:TextBox ID="TextBox6" runat="server" BorderStyle="None" ForeColor="Red"></asp:TextBox>
            <br />
            <asp:Label ID="Label7" runat="server" Text="Zip Code"></asp:Label><br />
            <asp:TextBox ID="zipText" runat="server" MaxLength="9"></asp:TextBox>
            <asp:TextBox ID="TextBox8" runat="server" BorderStyle="None" ForeColor="Red"></asp:TextBox>
        </fieldset>
        <fieldset id="employee">
            <legend>Employment Information</legend>

            <asp:Label ID="dobL" runat="server" Text="Date of Birth (MM/DD/YYYY)"></asp:Label><br />

            <asp:TextBox ID="dobText" runat="server" MaxLength="10"></asp:TextBox>
            <asp:TextBox ID="TextBox9" runat="server" BorderStyle="None" ForeColor="Red"></asp:TextBox>
            <br />

            <asp:Label ID="Label8" runat="server" Text="Hire Date (MM/DD/YYYY)"></asp:Label>
            <br />
            <asp:TextBox ID="hireDateText" runat="server" MaxLength="10"></asp:TextBox>
            <asp:TextBox ID="TextBox10" runat="server" BorderStyle="None" ForeColor="Red"></asp:TextBox>
            <br />
            <asp:Label ID="Label10" runat="server" Text="Termination Date (MM/DD/YYYY)"></asp:Label><br />
            <asp:TextBox ID="termDateText" runat="server" MaxLength="10"></asp:TextBox>
            <asp:TextBox ID="TextBox11" runat="server" BorderStyle="None" ForeColor="Red"></asp:TextBox>
            <br />
            
            <asp:Label ID="hoursL" runat="server" Text="Yearly Hours"></asp:Label><br />
            <asp:TextBox ID="yrHourText" runat="server" MaxLength="4"></asp:TextBox>
            <asp:TextBox ID="TextBox12" runat="server" BorderStyle="None" ForeColor="Red"></asp:TextBox>
            <br />
            <asp:Label ID="Label12" runat="server" Text="Valid Permit?"></asp:Label> <br />
            <asp:RadioButton ID="ValidPermitY" runat="server" Text="Yes" ValidationGroup="ValidPermit" />
            <asp:RadioButton ID="ValidPermitN" runat="server" Text="No" ValidationGroup="ValidPermit" />
            <br />

            <asp:Label ID="vaccL" runat="server" Text="Are you Rabies Vaccinated?"></asp:Label><br />
            <asp:RadioButton ID="vacY" runat="server" GroupName="isVaccinated" Text="Yes" />
            <asp:RadioButton ID="vacN" runat="server" GroupName="isVaccinated" Text="No" />
            <asp:TextBox ID="TextBox13" runat="server" BorderStyle="None" ForeColor="Red"></asp:TextBox>
            <br />

            <asp:Label ID="ageL" runat="server" Text="Age"></asp:Label>
            <asp:TextBox ID="ageText" runat="server" Height="16px" Width="22px"></asp:TextBox>
            <br />

            <asp:Label ID="Label11" runat="server" Text="Skill"></asp:Label><br />
            <asp:DropDownList ID="DropDownList2" runat="server"></asp:DropDownList>
            <asp:TextBox ID="TextBox14" runat="server" BorderStyle="None" ForeColor="Red"></asp:TextBox>
            <br />
        </fieldset>
        <br />

        <asp:TextBox ID="uneditableText" runat="server"></asp:TextBox><br />

        <asp:TextBox ID="pTest1" runat="server"></asp:TextBox> <br />
        <asp:TextBox ID="pTest2" runat="server"></asp:TextBox> <br />
        <asp:TextBox ID="pTest3" runat="server"></asp:TextBox> <br />
        <asp:TextBox ID="errorText" runat="server"></asp:TextBox>
        <asp:TextBox ID="indexSize" runat="server"></asp:TextBox>


    </form>
    
</body>
</html>

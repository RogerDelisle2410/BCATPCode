using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default : System.Web.UI.Page
{
    public decimal FromServerlatitude; // = 49.026512526906m;  
    public decimal FromServerlongitude; // = -122.3688582561165m;
    public string lblnm;
    public string FromServercomment;
    public string FromServerwiki;
    public bool firstTime = true;
    public int DropDownListIndex;
    public int DropDownListIndexB;
    public DataView rdrSqlNext;
    public DataView rdrSqlPrevious;
    public string currentDropList;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            MyGlobals.selection = 0;
            DropDownList1.ForeColor = System.Drawing.Color.Red;
            DropDownList1.SelectedIndex = 1;
            const int theIndex = 1;
            DataView rdrSql = (DataView)SqlDataSource1.Select(DataSourceSelectArguments.Empty);
            DisplayData(rdrSql, theIndex);
        }
    }
    public static class MyGlobals
    {
        public static int selection;
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        currentDropList = ((DropDownList)sender).ID;
        MyGlobals.selection = 0;
        SetDropColor(currentDropList);
        DropDownList1.ForeColor = System.Drawing.Color.Red;
        DropDownList1.SelectedIndex = DropDownList1.Items.IndexOf(DropDownList1.Items.FindByText(DropDownList1.SelectedValue));

        if (DropDownList1.SelectedIndex != 0)
        {
            var theIndex = DropDownList1.SelectedIndex;
            DataView rdrSql = (DataView)SqlDataSource1.Select(DataSourceSelectArguments.Empty);
            DisplayData(rdrSql, theIndex);
        }
    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        currentDropList = ((DropDownList)sender).ID;
        MyGlobals.selection = 1;
        SetDropColor(currentDropList);
        DropDownList2.ForeColor = System.Drawing.Color.Red;
        DropDownList2.SelectedIndex = DropDownList2.Items.IndexOf(DropDownList2.Items.FindByText(DropDownList2.SelectedValue));
        if (DropDownList2.SelectedIndex != 0)
        {
            var theIndex = DropDownList2.SelectedIndex;
            DataView rdrSql = (DataView)SqlDataSource2.Select(DataSourceSelectArguments.Empty);
            DisplayData(rdrSql, theIndex);
        }
    }

    protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
    {
        currentDropList = ((DropDownList)sender).ID;
        MyGlobals.selection = 2;
        SetDropColor(currentDropList);
        DropDownList3.ForeColor = System.Drawing.Color.Red;
        DropDownList3.SelectedIndex = DropDownList3.Items.IndexOf(DropDownList3.Items.FindByText(DropDownList3.SelectedValue));
        if (DropDownList3.SelectedIndex != 0)
        {
            var theIndex = DropDownList3.SelectedIndex;
            DataView rdrSql = (DataView)SqlDataSource3.Select(DataSourceSelectArguments.Empty);
            DisplayData(rdrSql, theIndex);
        }
    }

    protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e)
    {
        currentDropList = ((DropDownList)sender).ID;
        MyGlobals.selection = 3;
        SetDropColor(currentDropList);
        DropDownList4.ForeColor = System.Drawing.Color.Red;
        DropDownList4.SelectedIndex = DropDownList4.Items.IndexOf(DropDownList4.Items.FindByText(DropDownList4.SelectedValue));
        if (DropDownList4.SelectedIndex != 0)
        {
            var theIndex = DropDownList4.SelectedIndex;
            DataView rdrSql = (DataView)SqlDataSource4.Select(DataSourceSelectArguments.Empty);
            DisplayData(rdrSql, theIndex);
        }
    }
    protected void DropDownList5_SelectedIndexChanged(object sender, EventArgs e)
    {
        currentDropList = ((DropDownList)sender).ID;
        MyGlobals.selection = 4;
        SetDropColor(currentDropList);
        DropDownList5.ForeColor = System.Drawing.Color.Red;
        DropDownList5.SelectedIndex = DropDownList5.Items.IndexOf(DropDownList5.Items.FindByText(DropDownList5.SelectedValue));
        if (DropDownList5.SelectedIndex != 0)
        {
            var theIndex = DropDownList5.SelectedIndex;
            DataView rdrSql = (DataView)SqlDataSource5.Select(DataSourceSelectArguments.Empty);
            DisplayData(rdrSql, theIndex);
        }
    }
    protected void DropDownList6_SelectedIndexChanged(object sender, EventArgs e)
    {
        currentDropList = ((DropDownList)sender).ID;
        MyGlobals.selection = 5;
        SetDropColor(currentDropList);
        DropDownList6.ForeColor = System.Drawing.Color.Red;
        DropDownList6.SelectedIndex = DropDownList6.Items.IndexOf(DropDownList6.Items.FindByText(DropDownList6.SelectedValue));
        if (DropDownList6.SelectedIndex != 0)
        {
            var theIndex = DropDownList6.SelectedIndex;
            DataView rdrSql = (DataView)SqlDataSource6.Select(DataSourceSelectArguments.Empty);
            DisplayData(rdrSql, theIndex);
        }
    }
    protected void DropDownList7_SelectedIndexChanged(object sender, EventArgs e)
    {
        currentDropList = ((DropDownList)sender).ID;
        MyGlobals.selection = 6;
        SetDropColor(currentDropList);
        DropDownList7.ForeColor = System.Drawing.Color.Red;
        DropDownList7.SelectedIndex = DropDownList7.Items.IndexOf(DropDownList7.Items.FindByText(DropDownList7.SelectedValue));
        if (DropDownList7.SelectedIndex != 0)
        {
            var theIndex = DropDownList7.SelectedIndex;
            DataView rdrSql = (DataView)SqlDataSource7.Select(DataSourceSelectArguments.Empty);
            DisplayData(rdrSql, theIndex);
        }
    }
    protected void DropDownList8_SelectedIndexChanged(object sender, EventArgs e)
    {
        var currentDropList = ((DropDownList)sender).ID;
        MyGlobals.selection = 7;
        SetDropColor(currentDropList);
        DropDownList8.ForeColor = System.Drawing.Color.Red;
        DropDownList8.SelectedIndex = DropDownList8.Items.IndexOf(DropDownList8.Items.FindByText(DropDownList8.SelectedValue));
        if (DropDownList8.SelectedIndex != 0)
        {
            var theIndex = DropDownList8.SelectedIndex;
            DataView rdrSql = (DataView)SqlDataSource8.Select(DataSourceSelectArguments.Empty);
            DisplayData(rdrSql, theIndex);
        }
    }
    protected void DisplayData(DataView rdrSql, int theIndex)
    {
        FromServerlongitude = Convert.ToDecimal(rdrSql[theIndex].Row.ItemArray[1]);
        FromServerlatitude = Convert.ToDecimal(rdrSql[theIndex].Row.ItemArray[2]);
        FromServercomment = rdrSql[theIndex].Row.ItemArray[3].ToString();
        FromServerwiki = rdrSql[theIndex].Row.ItemArray[4].ToString();

        TextBox1.Text = FromServerlongitude.ToString();
        TextBox2.Text = FromServerlatitude.ToString();
        TextBox3.Text = FromServercomment;

        linkInfo.NavigateUrl = "";
        linkInfo.Text = "";

        //lblName.Text = " ";
        //lblName2.Text = " ";
        //lblnm = "";
        if (FromServerwiki != "")
        {
            linkInfo.NavigateUrl = string.Format(FromServerwiki);
            linkInfo.Text = "Click here for more info on";

            //lblName2.NavigateUrl = string.Format(FromServerwiki);
            //lblName2.Text = rdrSql[theIndex].Row.ItemArray[0].ToString();

        }
        //else { 
        lblName.Text = rdrSql[theIndex].Row.ItemArray[0].ToString();
        lblnm = lblName.Text;
    //}
    }
    protected void SetDropColor(string currentDropList)
    {
        foreach (Control control in Page.Controls)
        {
            foreach (Control childc in control.Controls)
            {
                if (childc is DropDownList)
                {
                    ((DropDownList)childc).ForeColor = System.Drawing.Color.Black;
                }
                if (childc is DropDownList && childc.ID != currentDropList)
                {
                    ((DropDownList)childc).SelectedIndex = 0;
                }
            }
        }
    }

    protected void BtnPrevious_Click(object sender, EventArgs e)
    {
        switch (MyGlobals.selection)
        {
            case 0:
                DropDownListIndex = DropDownList1.Items.IndexOf(DropDownList1.Items.FindByText(DropDownList1.SelectedValue));
                DropDownListIndex--;
                DropDownListIndexB = DropDownList1.Items.Count - 1;
                rdrSqlPrevious = (DataView)SqlDataSource1.Select(DataSourceSelectArguments.Empty);
                break;
            case 1:
                DropDownListIndex = DropDownList2.Items.IndexOf(DropDownList2.Items.FindByText(DropDownList2.SelectedValue));
                DropDownListIndex--;
                DropDownListIndexB = DropDownList2.Items.Count - 1;
                rdrSqlPrevious = (DataView)SqlDataSource2.Select(DataSourceSelectArguments.Empty);
                break;
            case 2:
                DropDownListIndex = DropDownList3.Items.IndexOf(DropDownList3.Items.FindByText(DropDownList3.SelectedValue));
                DropDownListIndex--;
                DropDownListIndexB = DropDownList3.Items.Count - 1;
                rdrSqlPrevious = (DataView)SqlDataSource3.Select(DataSourceSelectArguments.Empty);
                break;
            case 3:
                DropDownListIndex = DropDownList4.Items.IndexOf(DropDownList4.Items.FindByText(DropDownList4.SelectedValue));
                DropDownListIndex--;
                DropDownListIndexB = DropDownList4.Items.Count - 1;
                rdrSqlPrevious = (DataView)SqlDataSource4.Select(DataSourceSelectArguments.Empty);
                break;
            case 4:
                DropDownListIndex = DropDownList5.Items.IndexOf(DropDownList5.Items.FindByText(DropDownList5.SelectedValue));
                DropDownListIndex--;
                DropDownListIndexB = DropDownList5.Items.Count - 1;
                rdrSqlPrevious = (DataView)SqlDataSource5.Select(DataSourceSelectArguments.Empty);
                break;
            case 5:
                DropDownListIndex = DropDownList6.Items.IndexOf(DropDownList6.Items.FindByText(DropDownList6.SelectedValue));
                DropDownListIndex--;
                DropDownListIndexB = DropDownList6.Items.Count - 1;
                rdrSqlPrevious = (DataView)SqlDataSource6.Select(DataSourceSelectArguments.Empty);
                break;
            case 6:
                DropDownListIndex = DropDownList7.Items.IndexOf(DropDownList7.Items.FindByText(DropDownList7.SelectedValue));
                DropDownListIndex--;
                DropDownListIndexB = DropDownList7.Items.Count - 1;
                rdrSqlPrevious = (DataView)SqlDataSource7.Select(DataSourceSelectArguments.Empty);
                break;
            case 7:
                DropDownListIndex = DropDownList8.Items.IndexOf(DropDownList8.Items.FindByText(DropDownList8.SelectedValue));
                DropDownListIndex--;
                DropDownListIndexB = DropDownList8.Items.Count - 1;
                rdrSqlPrevious = (DataView)SqlDataSource8.Select(DataSourceSelectArguments.Empty);
                break;
        }
        //if(DropDownListIndex == 0)
        //{
        //    DropDownListIndex = 1;
        //}

        if (DropDownListIndex > 0)
        {
            lblName.Text = rdrSqlPrevious[DropDownListIndex].Row.ItemArray[0].ToString();
            lblnm = lblName.Text;
            FromServerlongitude = Convert.ToDecimal(rdrSqlPrevious[DropDownListIndex].Row.ItemArray[1]);
            FromServerlatitude = Convert.ToDecimal(rdrSqlPrevious[DropDownListIndex].Row.ItemArray[2]);
            FromServercomment = rdrSqlPrevious[DropDownListIndex].Row.ItemArray[3].ToString();
            FromServerwiki = rdrSqlPrevious[DropDownListIndex].Row.ItemArray[4].ToString();

            switch (MyGlobals.selection)
            {
                case 0:
                    DropDownList1.Text = rdrSqlPrevious[DropDownListIndex].Row.ItemArray[0].ToString();
                    break;
                case 1:
                    DropDownList2.Text = rdrSqlPrevious[DropDownListIndex].Row.ItemArray[0].ToString();
                    break;
                case 2:
                    DropDownList3.Text = rdrSqlPrevious[DropDownListIndex].Row.ItemArray[0].ToString();
                    break;
                case 3:
                    DropDownList4.Text = rdrSqlPrevious[DropDownListIndex].Row.ItemArray[0].ToString();
                    break;
                case 4:
                    DropDownList5.Text = rdrSqlPrevious[DropDownListIndex].Row.ItemArray[0].ToString();
                    break;
                case 5:
                    DropDownList6.Text = rdrSqlPrevious[DropDownListIndex].Row.ItemArray[0].ToString();
                    break;
                case 6:
                    DropDownList7.Text = rdrSqlPrevious[DropDownListIndex].Row.ItemArray[0].ToString();
                    break;
                case 7:
                    DropDownList8.Text = rdrSqlPrevious[DropDownListIndex].Row.ItemArray[0].ToString();
                    break;
            }

            TextBox1.Text = FromServerlongitude.ToString();
            TextBox2.Text = FromServerlatitude.ToString();
            TextBox3.Text = FromServercomment;
            linkInfo.NavigateUrl = "";
            linkInfo.Text = "";
            if (FromServerwiki != "")
            {
                linkInfo.NavigateUrl = string.Format(FromServerwiki);
                linkInfo.Text = "Click here for more info on";
            }
        }
        if (DropDownListIndex == 0)
        {
            DropDownListIndex = DropDownListIndexB-1;
            lblName.Text = rdrSqlPrevious[DropDownListIndex + 1].Row.ItemArray[0].ToString();
            lblnm = lblName.Text;
            FromServerlongitude = Convert.ToDecimal(rdrSqlPrevious[DropDownListIndex + 1].Row.ItemArray[1]);
            FromServerlatitude = Convert.ToDecimal(rdrSqlPrevious[DropDownListIndex + 1].Row.ItemArray[2]);
            FromServercomment = rdrSqlPrevious[DropDownListIndex + 1].Row.ItemArray[3].ToString();
            FromServerwiki = rdrSqlPrevious[DropDownListIndex + 1].Row.ItemArray[4].ToString();

            switch (MyGlobals.selection)
            {
                case 0:
                    DropDownList1.Text = rdrSqlPrevious[DropDownListIndex + 1].Row.ItemArray[0].ToString();
                    break;
                case 1:
                    DropDownList2.Text = rdrSqlPrevious[DropDownListIndex + 1].Row.ItemArray[0].ToString();
                    break;
                case 2:
                    DropDownList3.Text = rdrSqlPrevious[DropDownListIndex + 1].Row.ItemArray[0].ToString();
                    break;
                case 3:
                    DropDownList4.Text = rdrSqlPrevious[DropDownListIndex + 1].Row.ItemArray[0].ToString();
                    break;
                case 4:
                    DropDownList5.Text = rdrSqlPrevious[DropDownListIndex + 1].Row.ItemArray[0].ToString();
                    break;
                case 5:
                    DropDownList6.Text = rdrSqlPrevious[DropDownListIndex + 1].Row.ItemArray[0].ToString();
                    break;
                case 6:
                    DropDownList7.Text = rdrSqlPrevious[DropDownListIndex + 1].Row.ItemArray[0].ToString();
                    break;
                case 7:
                    DropDownList8.Text = rdrSqlPrevious[DropDownListIndex + 1].Row.ItemArray[0].ToString();
                    break;
            }
            TextBox1.Text = FromServerlongitude.ToString();
            TextBox2.Text = FromServerlatitude.ToString();
            TextBox3.Text = FromServercomment; linkInfo.NavigateUrl = "";
            linkInfo.Text = "";
            if (FromServerwiki != "")
            {
                linkInfo.NavigateUrl = string.Format(FromServerwiki);
                linkInfo.Text = "Click here for more info on";
            }
        }
    }

    protected void BtnNext_Click(object sender, EventArgs e)
    {
        switch (MyGlobals.selection)
        {
            case 0:
                DropDownListIndex = DropDownList1.Items.IndexOf(DropDownList1.Items.FindByText(DropDownList1.SelectedValue));
                DropDownListIndex++;
                DropDownListIndexB = DropDownList1.Items.Count -1;
                rdrSqlNext = (DataView)SqlDataSource1.Select(DataSourceSelectArguments.Empty);
                break;
            case 1:
                DropDownListIndex = DropDownList2.Items.IndexOf(DropDownList2.Items.FindByText(DropDownList2.SelectedValue));
                DropDownListIndex++;
                DropDownListIndexB = DropDownList2.Items.Count - 1;
                rdrSqlNext = (DataView)SqlDataSource2.Select(DataSourceSelectArguments.Empty);
                break;
            case 2:
                DropDownListIndex = DropDownList3.Items.IndexOf(DropDownList3.Items.FindByText(DropDownList3.SelectedValue));
                DropDownListIndex++;
                DropDownListIndexB = DropDownList3.Items.Count - 1;
                rdrSqlNext = (DataView)SqlDataSource3.Select(DataSourceSelectArguments.Empty);
                break;
            case 3:
                DropDownListIndex = DropDownList4.Items.IndexOf(DropDownList4.Items.FindByText(DropDownList4.SelectedValue));
                DropDownListIndex++;
                DropDownListIndexB = DropDownList4.Items.Count - 1;
                rdrSqlNext = (DataView)SqlDataSource4.Select(DataSourceSelectArguments.Empty);
                break;
            case 4:
                DropDownListIndex = DropDownList5.Items.IndexOf(DropDownList5.Items.FindByText(DropDownList5.SelectedValue));
                DropDownListIndex++;
                DropDownListIndexB = DropDownList5.Items.Count - 1;
                rdrSqlNext = (DataView)SqlDataSource5.Select(DataSourceSelectArguments.Empty);
                break;
            case 5:
                DropDownListIndex = DropDownList6.Items.IndexOf(DropDownList6.Items.FindByText(DropDownList6.SelectedValue));
                DropDownListIndex++;
                DropDownListIndexB = DropDownList6.Items.Count - 1;
                rdrSqlNext = (DataView)SqlDataSource6.Select(DataSourceSelectArguments.Empty);
                break;
            case 6:
                DropDownListIndex = DropDownList7.Items.IndexOf(DropDownList7.Items.FindByText(DropDownList7.SelectedValue));
                DropDownListIndex++;
                DropDownListIndexB = DropDownList7.Items.Count - 1;
                rdrSqlNext = (DataView)SqlDataSource7.Select(DataSourceSelectArguments.Empty);
                break;
            case 7:
                DropDownListIndex = DropDownList8.Items.IndexOf(DropDownList8.Items.FindByText(DropDownList8.SelectedValue));
                DropDownListIndex++;
                DropDownListIndexB = DropDownList8.Items.Count - 1;
                rdrSqlNext = (DataView)SqlDataSource8.Select(DataSourceSelectArguments.Empty);
                break;
        }
        if (DropDownListIndex <= DropDownListIndexB)
        {
            lblName.Text = rdrSqlNext[DropDownListIndex].Row.ItemArray[0].ToString();
            lblnm = lblName.Text;
            FromServerlongitude = Convert.ToDecimal(rdrSqlNext[DropDownListIndex].Row.ItemArray[1]);
            FromServerlatitude = Convert.ToDecimal(rdrSqlNext[DropDownListIndex].Row.ItemArray[2]);
            FromServercomment = rdrSqlNext[DropDownListIndex].Row.ItemArray[3].ToString();
            FromServerwiki = rdrSqlNext[DropDownListIndex].Row.ItemArray[4].ToString();

            switch (MyGlobals.selection)
            {
                case 0:
                    DropDownList1.Text = rdrSqlNext[DropDownListIndex].Row.ItemArray[0].ToString();
                    break;
                case 1:
                    DropDownList2.Text = rdrSqlNext[DropDownListIndex].Row.ItemArray[0].ToString();
                    break;
                case 2:
                    DropDownList3.Text = rdrSqlNext[DropDownListIndex].Row.ItemArray[0].ToString();
                    break;
                case 3:
                    DropDownList4.Text = rdrSqlNext[DropDownListIndex].Row.ItemArray[0].ToString();
                    break;
                case 4:
                    DropDownList5.Text = rdrSqlNext[DropDownListIndex].Row.ItemArray[0].ToString();
                    break;
                case 5:
                    DropDownList6.Text = rdrSqlNext[DropDownListIndex].Row.ItemArray[0].ToString();
                    break;
                case 6:
                    DropDownList7.Text = rdrSqlNext[DropDownListIndex].Row.ItemArray[0].ToString();
                    break;
                case 7:
                    DropDownList8.Text = rdrSqlNext[DropDownListIndex].Row.ItemArray[0].ToString();
                    break;
            }
            TextBox1.Text = FromServerlongitude.ToString();
            TextBox2.Text = FromServerlatitude.ToString();
            TextBox3.Text = FromServercomment;
            linkInfo.NavigateUrl = "";
            linkInfo.Text = "";
            if (FromServerwiki != "")
            {
                linkInfo.NavigateUrl = string.Format(FromServerwiki);
                linkInfo.Text = "Click here for more info on";
            }
        }
        if (DropDownListIndex > DropDownListIndexB)
        {
            DropDownListIndex = 2;
            // TextBox3.Value = "Last record";
            lblName.Text = rdrSqlNext[DropDownListIndex - 1].Row.ItemArray[0].ToString();
            lblnm = lblName.Text;
            FromServerlongitude = Convert.ToDecimal(rdrSqlNext[DropDownListIndex - 1].Row.ItemArray[1]);
            FromServerlatitude = Convert.ToDecimal(rdrSqlNext[DropDownListIndex - 1].Row.ItemArray[2]);
            FromServercomment = rdrSqlNext[DropDownListIndex - 1].Row.ItemArray[3].ToString();
            FromServerwiki = rdrSqlNext[DropDownListIndex - 1].Row.ItemArray[4].ToString();

            switch (MyGlobals.selection)
            {
                case 0:
                    DropDownList1.Text = rdrSqlNext[DropDownListIndex - 1].Row.ItemArray[0].ToString();
                    break;
                case 1:
                    DropDownList2.Text = rdrSqlNext[DropDownListIndex - 1].Row.ItemArray[0].ToString();
                    break;
                case 2:
                    DropDownList3.Text = rdrSqlNext[DropDownListIndex - 1].Row.ItemArray[0].ToString();
                    break;
                case 3:
                    DropDownList4.Text = rdrSqlNext[DropDownListIndex - 1].Row.ItemArray[0].ToString();
                    break;
                case 4:
                    DropDownList5.Text = rdrSqlNext[DropDownListIndex - 1].Row.ItemArray[0].ToString();
                    break;
                case 5:
                    DropDownList6.Text = rdrSqlNext[DropDownListIndex - 1].Row.ItemArray[0].ToString();
                    break;
                case 6:
                    DropDownList7.Text = rdrSqlNext[DropDownListIndex - 1].Row.ItemArray[0].ToString();
                    break;
                case 7:
                    DropDownList8.Text = rdrSqlNext[DropDownListIndex - 1].Row.ItemArray[0].ToString();
                    break;
            }
            TextBox1.Text = FromServerlongitude.ToString();
            TextBox2.Text = FromServerlatitude.ToString();
            TextBox3.Text = FromServercomment;
            linkInfo.NavigateUrl = "";
            linkInfo.Text = "";
            if (FromServerwiki != "")
            {
                linkInfo.NavigateUrl = string.Format(FromServerwiki);
                linkInfo.Text = "Click here for more info on";
            }
        }
    }
}
namespace _005_example
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private string[,] listName;
        private string[,] listResult;
        private int count;
        private int countFemale;
        private int countFail;

        private void MainForm_Load(object sender, EventArgs e)
        {
            txtName.Focus();
            cbGender.Items.Add("male");
            cbGender.Items.Add("female");
            cbGender.Items.Add("other");

            cbGender.SelectedIndex = 0;

            this.listName = new string[100, 2];
            listName[count, 0] = "Name";
            listName[count, 1] = "Gender";

            this.listResult = new string[100, 6];
            listResult[count, 0] = "Name";
            listResult[count, 1] = "Gender";
            listResult[count, 2] = "Total";
            listResult[count, 3] = "Credit";
            listResult[count, 4] = "Result";
            listResult[count, 5] = "Mention";

            count++;

            ShowListName();
            ShowListResult();
            ShowFooter();
        }

        private void ShowListName()
        {
            string text = "";
            for (int i = 0; i < count; i++)
            {
                text += listName[i, 0] + "\t" + listName[i, 1] + "\r\n";
            }
            txtShowList.Text = text;
        }

        private void ShowListResult()
        {
            string text = "";
            for (int i = 0; i < count; i++)
            {
                text += listResult[i, 0] + "\t" + listResult[i, 1] + "\t" +
                        listResult[i, 2] + "\t" + listResult[i, 3] + "\t" +
                        listResult[i, 4] + "\t" + listResult[i, 5] + "\r\n";
            }
            txtShowResult.Text = text;
        }

        private void btnShowListName_Click(object sender, EventArgs e)
        {
            ShowListName();
        }

        private void btnHideListName_Click(object sender, EventArgs e)
        {
            txtShowList.Text = "";
        }

        private void btnShowResult_Click(object sender, EventArgs e)
        {
            ShowListResult();
            ShowFooter();
        }

        private void btnHideResult_Click(object sender, EventArgs e)
        {
            txtShowResult.Text = "";
            HideFooter();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter name");
                return; 
            }
            if (string.IsNullOrWhiteSpace(txtHomework.Text))
            {
                MessageBox.Show("Please enter homework score");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtMidterm.Text))
            {
                MessageBox.Show("Please enter midterm score");
                return; 
            }
            if (string.IsNullOrWhiteSpace(txtFinal.Text))
            {
                MessageBox.Show("Please enter final score");
                return; 
            }
            string name = txtName.Text;
            string gender = cbGender.Text;
            double homework = 0;
            double midterm = 0;
            double final = 0;
            try
            {
                homework = Convert.ToDouble(txtHomework.Text);
                if (homework < 0 || homework > 20)
                {
                    MessageBox.Show("Homework score must be between 0 and 20!");
                    return;
                }
                midterm = Convert.ToDouble(txtMidterm.Text);
                if (midterm < 0 || midterm > 30)
                {
                    MessageBox.Show("Midterm score must be between 0 and 30!");
                    return;
                }
                final = Convert.ToDouble(txtFinal.Text);
                if (final < 0 || final > 50)
                {
                    MessageBox.Show("Final score must be between 0 and 50!");
                    return; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return;
            }

            listName[count, 0] = name;
            listName[count, 1] = gender;
            if (gender.Equals(cbGender.Items[1].ToString()))
            {
                countFemale++;
            }

            //total 
            double total = homework + midterm + final;

            //credit
            double credit = total / 25;

            //result 
            string result = "";
            if (credit < 2)
            {
                result = "failed";
                countFail++;
            }
            else
            {
                result = "passed";
            }

            //mention 
            string mention = "";
            if (credit < 2) mention = "weak";
            else if (credit < 2.5) mention = "average";
            else if (credit < 3.8) mention = "good";
            else mention = "excellent";

            listResult[count, 0] = name;
            listResult[count, 1] = gender;
            listResult[count, 2] = total.ToString();
            listResult[count, 3] = credit.ToString();
            listResult[count, 4] = result;
            listResult[count, 5] = mention;

            count++;

            ClearText();
            ShowListName();
            ShowListResult();
            ShowFooter();
        }

        private void ShowFooter()
        {
            lblCountAll.Text = (count - 1).ToString();
            lblCountFemale.Text = countFemale.ToString();
            lblCountFail.Text = countFail.ToString();
        }

        private void HideFooter()
        {
            lblCountAll.Text = "--";
            lblCountFemale.Text = "--";
            lblCountFail.Text = "--";
        }

        private void ClearText()
        {
            txtName.Clear();
            txtHomework.Clear();
            txtMidterm.Clear();
            txtFinal.Clear();
        }
    }
}
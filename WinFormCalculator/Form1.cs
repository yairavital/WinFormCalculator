namespace WinFormCalculator
{
    public partial class Form1 : Form
    {
        string targil = "";
        char Action { get; set; }
        double FirstNumber { get; set; }
        double SecondNumber { get; set; }


        public Form1()
        {
            InitializeComponent();
            Calculator c = new Calculator();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

  

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtEquation.Text = txtEquation.Text.Remove(txtEquation.Text.Length - 1);

        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            if (Action == '/' || Action == '*' || Action == '+' || Action == '-')
                SecondNumber = 1;
            txtEquation.Text += "1";
        }

        private void btnTwo_Click(object sender, EventArgs e)
        { 
            if (Action == '/' || Action == '*' || Action == '+' || Action == '-')
                SecondNumber = 2;
            txtEquation.Text+= "2";
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
        if (Action == '/' || Action == '*' || Action == '+' || Action == '-')
            SecondNumber = 3;
            txtEquation.Text+= "3";
        }

        private void btnFour_Click(object sender, EventArgs e)
        { 
        
                if (Action == '/' || Action == '*' || Action == '+' || Action == '-')
                    SecondNumber = 4;
            txtEquation.Text+= "4";
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (Action == '/' || Action == '*' || Action == '+' || Action == '-')
                SecondNumber = 5;
            txtEquation.Text += "5";
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (Action == '/' || Action == '*' || Action == '+' || Action == '-')
                SecondNumber = 6;
            txtEquation.Text += "6";
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (Action == '/' || Action == '*' || Action == '+' || Action == '-')
                SecondNumber = 7;
            txtEquation.Text += "7";
           
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (Action == '/' || Action == '*' || Action == '+' || Action == '-')
                SecondNumber = 8;
            txtEquation.Text += "8";
           
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (Action == '/' || Action == '*' || Action == '+' || Action == '-')
                SecondNumber = 9;
            txtEquation.Text += "9";
            
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            FirstNumber = double.Parse(txtEquation.Text);

            txtEquation.Text += "/";
            Action = '/';
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            FirstNumber = double.Parse(txtEquation.Text);
            txtEquation.Text += "X";
            Action = 'X';
        }

        private void btnDeu_Click(object sender, EventArgs e)
        {
            FirstNumber = double.Parse(txtEquation.Text);

            txtEquation.Text += "-";
            Action = '-';

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FirstNumber = double.Parse(txtEquation.Text);
            txtEquation.Text +="+";
            Action = '+';
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            
            switch(Action)
            {
                case '+':

                   txtEquation.Text = (FirstNumber + SecondNumber).ToString();
                    break;
                case '-':
                    txtEquation.Text = (FirstNumber - SecondNumber).ToString();
                    break;
                case '/':
                    txtEquation.Text = (FirstNumber / SecondNumber).ToString();
                    break ;
                case 'X':
                    txtEquation.Text = (FirstNumber * SecondNumber).ToString();
                    break;





            }

        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (Action == '/' || Action == '*' || Action == '+' || Action == '-')
                SecondNumber = 3; txtEquation.Text +="0";
            FirstNumber = 0;
        }

        private void btnCe_Click(object sender, EventArgs e)
        {
            

           
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtEquation.Clear();
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            txtEquation.Text += ".";     
        }
    }
}
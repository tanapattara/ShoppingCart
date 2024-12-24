namespace ShoppingCart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //get amount
            string strCoffeePrice = tbCoffeePrice.Text;
            //get price
            string strCoffeeQuantity = tbCoffeeQuantity.Text;

            int iCoffeePrice = 0;
            int iCoffeeQuantity = 0;
            try
            {
                // convert string to int
                if (chbCoffee.Checked)
                { 
                    iCoffeePrice = int.Parse(strCoffeePrice);
                    iCoffeeQuantity = int.Parse(strCoffeeQuantity);
                }
            }
            catch (Exception ex)
            {
                iCoffeePrice = 0;
                iCoffeeQuantity = 0;
            }
            //calculate total
            int iTotal = iCoffeePrice * iCoffeeQuantity;
            //display total
            tbTotal.Text = iTotal.ToString();
        }
    }
}

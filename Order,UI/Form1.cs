
using Order.Domian;
using System.Windows.Forms;
namespace Order_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void butCalculate_Click(object sender, EventArgs e)
        {
            //ʵ����Customer����
            Customer cs = new Customer() {
                Name = txtCustomerName.Text,
                Phone = txtCustomeTel.Text,
                Adress = txtCostomerAdress.Text
            };
            //ʵ��������
            Orders ord = new Orders(cs);
            //ʵ����������
            Product p1 = new Product()
            {
                Name = txtProduct1Name.Text,
                Price = double.Parse(txtProduct1Price.Text)
            };
            Product p2 = new Product()
            {
                Name = txtProduct2Name.Text,
                Price = double.Parse(txtProduct2Price.Text)
            };

            OrderItem item1 = new OrderItem(ord, p1)
            {
                count=Convert.ToInt32(txtProduct1Count)
            };

            OrderItem item2=new OrderItem(ord, p2)
            {
                count = Convert.ToInt32(txtProduct2Count)
            };


            //���㲢��ʾ
            txtOrderID.Text = ord.Number;
            txtOrderDate.Text = ord.Date.ToString();
            butSubTotal1.Text = item1.SubTotal().ToString();
            butSubTotal2.Text = item2.SubTotal().ToString();
            butTotal.Text=ord.Total().ToString();
        }
    }
}
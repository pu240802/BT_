using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5_bt1
{
    public partial class Form1 : Form
    {

        
        public Form1()
        {
            InitializeComponent();

        }
       private void addFoodIntoListFood(string foodname)
        {
            try
            {
                for  (int i = 0; i < dataOrder.Rows.Count-1; i++)
                {
                    if(dataOrder["clMonan", i].Value.ToString().Equals(foodname))
                    {
                        dataOrder["clSoluong",i].Value = int.Parse(dataOrder["clSoluong", i].Value.ToString()) + 1;
                        return;
                    }
                }
                dataOrder.Rows.Add(foodname, 1);
            }
            catch ( Exception e)
            {
                MessageBox.Show(e.ToString(),"Thông Báo", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addFoodIntoListFood("Burger Phô Mai Gà");
        }
        
        private void btnBurgerPMB_Click(object sender, EventArgs e)
        {
            addFoodIntoListFood("Burger Phô Mai Bò");
        }

        private void dataOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
           



        }
        private void btnBurgerPMT_Click(object sender, EventArgs e)
        {
            addFoodIntoListFood("Burger Phô Mai Tôm");


        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if(comboTenban.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn bàn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (dataOrder.Rows.Count < 2)
                {
                    MessageBox.Show("Vui lòng chọn thức ăn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                MessageBox.Show("Đã gửi danh sách cho thức ăn cho nhà bếp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dataOrder.Rows.Clear();
                comboTenban.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnBurgerPMC_Click(object sender, EventArgs e)
        {
            addFoodIntoListFood("Burger Phô Mai Cá");
        }

        private void btnTVC_Click(object sender, EventArgs e)
        {
            addFoodIntoListFood("Tôm Viên Cá");
        }

        private void btnGVC_Click(object sender, EventArgs e)
        {
            addFoodIntoListFood("Gà Viên Cá");
        }

        private void btnGR_Click(object sender, EventArgs e)
        {
            addFoodIntoListFood("Gà Rán Phần ");
        }

        private void btnCGTender_Click(object sender, EventArgs e)
        {
            addFoodIntoListFood("Cơm Gà Tender");
        }

        private void btnpepsi_Click(object sender, EventArgs e)
        {
            addFoodIntoListFood("pepsi");
        }

        private void btn7up_Click(object sender, EventArgs e)
        {
            addFoodIntoListFood("7 up");
        }

        private void btncafe_Click(object sender, EventArgs e)
        {
            addFoodIntoListFood("cafe");
        }

        private void btncoca_Click(object sender, EventArgs e)
        {
            addFoodIntoListFood("Coca");
        }

        private void btnlipton_Click(object sender, EventArgs e)
        {
            addFoodIntoListFood("Lipton");
        }

        private void btnCam_Click(object sender, EventArgs e)
        {
            addFoodIntoListFood("Can");
        }

        private void btnKTChien_Click(object sender, EventArgs e)
        {
            addFoodIntoListFood("Khoai Tây Chiên");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dataOrder.CurrentCell.RowIndex;
                if( index != dataOrder.Rows.Count - 1)
                {
                    dataOrder.Rows.RemoveAt(index);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(e.ToString(), "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
 }
    
   

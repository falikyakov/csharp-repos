using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kugels
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

        private void Button1_Click(object sender, EventArgs e)
        {
            string storeName = textBox_StoreName.Text;
            string address = textBox_Address.Text;
            string area = comboBox_Area.Text;
            string storeOwner = textBox_StoreOwner.Text;
            string storeManager = textBox_StoreManager.Text;
            string telephone = textBox_Tel.Text;
            string ownerCell = textBox_OwnerCell.Text;
            string managerCell = textBox_ManagerCell.Text;

            StoreCustomer Store1 = new StoreCustomer(storeName, address, area, storeOwner, storeManager,
                telephone, ownerCell, managerCell);

            MessageBox.Show(String.Format("Store Name: {0}\nAddress: {1}\nArea: {2}\nStore Owner: {3}" +
                "\nStore Manager: {4}\nTel: {5}\nOwner Cell: {6}\nManager Cell: {7}",Store1.Name, Store1.Address,
                Store1.Area, Store1.StoreOwner,storeManager, Store1.Telephone, Store1.OwnerCell, Store1.ManagerCell));



            //StoreCustomer BestMarket = new StoreCustomer("Best Market", "Cor. Dolev & Ayalon", "Dolev RBS-A", "Effi", "Tzach", 025386800,
            //    123456, 9876544);
            //MessageBox.Show(String.Format("Store Name: {0}\nAddress: {1}\nArea: {2}\nOwner: {3}\nManager: {4}\nStore Tel: {5}\nOwner Cell: {6}" +
            //    "\nManager Cell: {7}",BestMarket.Name,BestMarket.Address,BestMarket.Area,BestMarket.StoreOwner,BestMarket.StoreManager,
            //    BestMarket.Telephone,BestMarket.OwnerCell,BestMarket.ManagerCell));
        }
    }

    
}

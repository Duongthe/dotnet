using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_04_SuDungCCTreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            treeView1.ImageList = imgLAnh;

            TreeNode goc = treeView1.Nodes.Add("Ký tự đặt biệt");
            goc.ImageIndex = 1; //lấy dựa trên indeximg bắt đầu từ số 0
            goc.SelectedImageIndex = 1;

            TreeNode nodecong = goc.Nodes.Add("+");
            TreeNode nodetru = goc.Nodes.Add("-");
            TreeNode nodenhan = goc.Nodes.Add("*");
            TreeNode nodechia = goc.Nodes.Add("/");

            nodecong.ImageIndex = 2;
            nodetru.ImageIndex = 2;
            nodenhan.ImageIndex = 2;
            nodechia.ImageIndex = 2;

            nodecong.SelectedImageIndex = 7;
            nodetru.SelectedImageIndex= 7;
            nodenhan.StateImageIndex = 7;
            nodechia.StateImageIndex= 7;

            TreeNode gockytu = treeView1.Nodes.Add("Ký tự");
            gockytu.ImageIndex = 1;
            gockytu.StateImageIndex = 1;

            for (char i = 'A'; i <= 'Z'; i++)
            {
                TreeNode kt = gockytu.Nodes.Add(i + "");
                kt.ImageIndex = 2;
                kt.SelectedImageIndex = 7;
            }



            TreeNode gocchuso = treeView1.Nodes.Add("Chữ số");
            gocchuso.ImageIndex = 1;
            gocchuso.StateImageIndex = 1;
            for (int i = 0; i <= 9; i++)
            {
                TreeNode kt = gocchuso.Nodes.Add(i + "");
                kt.ImageIndex = 2;
                kt.SelectedImageIndex = 7;
            }



        }



    }
}

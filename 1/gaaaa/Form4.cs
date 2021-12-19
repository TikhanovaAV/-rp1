using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gaaaa
{
    public partial class Form4 : Form
    {
        public int ID;
        //private Color colFColor;
        private Color colBColor;
        private Image pictureImg;
        private string typeNameProductStr;
        private int prioriStr;
        public delegate void PUCHandler(string message, int id);
        public event PUCHandler Notify;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
        public Image Picture
        {
            get { return pictureImg; }
            set
            {
                pictureImg = value;
                PictureBox.Image = pictureImg;
            }
        }

        private void Form4_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (Form3.lstSelectedProduct.IndexOf(ID) != -1)
                { // если данный ПЭУ ВЫБРАН
                    BackColor = colBColor;
                    // удаляем из выборанных
                    Form3.lstSelectedProduct.Remove(ID);
                }
                else
                { // если данный ПЭУ НЕ ВЫБРАН
                    BackColor = Color.LightGray;
                    // добавляем к выбранным
                    Form3.lstSelectedProduct.Add(ID);
                }
                // Notify.Invoke("xxxxxx");
                if (Notify != null) Notify("Правая кнопка", ID);
            }
            if (e.Button == MouseButtons.Left)
            {
                if (Notify != null) Notify("Левая кнопка", ID);
            }
        }

        private void TypeNameProductLbl_Click(object sender, EventArgs e)
        {

        }
        public string TypeNameProduct
        {
            get { return typeNameProductStr; }
            set
            {
                typeNameProductStr = value;
                TypeNameProductLbl.Text = typeNameProductStr;
            }
        }
       

    }
}

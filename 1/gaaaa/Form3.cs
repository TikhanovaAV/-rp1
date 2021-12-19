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
    public partial class Form3 : Form
    {
        
        static int nAgList = 10;
        // коллекция ID выбранных товаров
        static public List<int> lstSelectedProduct = new List<int>();
        Model1 db = new Model1();
        public Form3()
        {
            InitializeComponent();
        }
        List<Agent> lstProduct = new List<Agent>();
        List<Form4> lstControls = new List<Form4>();
        Button[] btnsList = new Button[5];
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            agentBindingSource.DataSource = db.Agent.ToList();
            List<string> lstTypes = db.Agent.Select(a => a.Title).ToList();


            // заполняем коллекцию ПЭУ и размещаем ее в flowLayoutPanel1
            for (int i = 0; i < nAgList; i++)
            {
                // добавляем новый ПЭУ к коллекции lstControls
                lstControls.Add(new Form4());
                // добавляем новый ПЭУ к flowLayoutPanel 
                
            }

            {
                btnsList[0] = button1;
                btnsList[1] = button2;
                btnsList[2] = button3;
                btnsList[3] = button4;
                btnsList[4] = button5;
                SetPageBtn(1);
            }

            // подготавливаем данные для показа
            DataWork();
        }
        int nProdNumber = 0;  // начальный номер товара на странице
        int nPageFirst = 1;   // номер первой кнопки на странице
        int nPageCurrent = 1; // номер текущей страницы
        int nPageAll = 0;     // всего страниц с товарами
        // номер нажатой (текущей, активной) кнопки
        int nActiveBtn = 1;      // Convert.ToInt32(button1.Text);    

        public void DataWork()
        {
            // вначале выбираем все товары
            lstProduct = db.Agent.ToList();

            ////////////////////////////////////////////
            // вызов метода загрузки данных в ПЭУ  
            ShowCurrentPage();

            // что показываем на кнопках 
            nPageCurrent = 1;       // текущая страница
            nPageFirst = 1;  // первая кнопка = "1"
            // расчитываем общее кол-во страниц
            nPageAll = lstProduct.Count() / nAgList;
            if (nPageAll * nAgList < lstProduct.Count())
                nPageAll++;
            // если страниц меньше, чем кнопок
            if (nPageAll <= 5)
            {
                if (nPageAll < 5)
                {
                    for (int i = nPageAll; i <= 5; i++)
                        btnsList[i - 1].Enabled = false;
                }
                RightBtn.Enabled = false;
            }

        }

        private void ShowCurrentPage()
        {
            int nProdMax = lstProduct.Count(); // максимальное коли-во товара

            
            // расчитываем номер первого товара на странице
            nProdNumber = (nPageCurrent - 1) * nAgList;

            // счетчик номера товара на странице
            int i = nProdNumber;

           
            // задаем свойства показываемых ПЭУ
            foreach (Form4 puc in lstControls)
            {
                if (i < nProdMax)
                {
                    // сохраняем ID продукта
                    puc.ID = lstProduct[i].ID;

                    // проверяем - выбран этот ЭУ или нет?
                    if (lstSelectedProduct.IndexOf(puc.ID) != -1)
                    {// если данный ПЭУ ВЫБРАН, то фон меняем
                        puc.BackColor = Color.LightGray;
                    }
                    else
                    {// если не выбран, то начальный цвет
                        puc.BackColor = Color.White; // puc.BackColor1;
                    }
                    // задаем фото товара
                    if ((lstProduct[i].Logo != "") && (lstProduct[i].Logo != null))
                        // если фото у товара есть, добавляем его
                        puc.Picture = Image.FromFile(lstProduct[i].Logo);
                    else  // если фото нет, то добавляем картинку по умолчанию
                        puc.Picture = Image.FromFile(@"agent\picture.png");

                    // задаем строку "тип товара | название товара"
                    puc.TypeNameProduct = lstProduct[i].AgentType.Title + " | "
                        + lstProduct[i].Title;


                    
                }
                else
                {   // если данных для ПЭУ нет
                    // делаем этот ПЭУ невидимым
                    puc.Visible = false;
                    // если данных уже нет, то кнопка враво не активная
                    RightBtn.Enabled = false;
                }
                i++; // счетчик номера товара увеличиваем
            }
            // если на последней странице показаны все товары
            // то кнопку тоже отключаем 
            if (i == nProdMax)
            {
                RightBtn.Enabled = false;
            }
            ////////////////////////////////////////////
            //  выводим надпись внизу формы 
            // 
            int max = nPageCurrent * nAgList;
            if (max > nProdMax) max = nProdMax;
            //  вывод сообщения о номерах показываемых товаров
            RangeLbl.Text = $"Товары с {nProdNumber + 1} по {max} (из всего {lstProduct.Count()})";
        }
        void SetPageBtn(int nPage)
        {
            for (int i = 0; i < 5; i++)
            {
                int ii = Convert.ToInt32(btnsList[i].Text);
                if (ii == nPage)
                    btnsList[i].BackColor = Color.LightBlue;
                else
                    btnsList[i].BackColor = Color.White;
            }
        }

        private void red_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.Show();
        }

        private void LeftBtn_Click(object sender, EventArgs e)
        {
            // вычисляем номер предыдущей страницы
            if (nActiveBtn > 1)
            {
                nPageCurrent--;
                nActiveBtn--;
                SetPageBtn(nPageCurrent);
            }
            else if (nActiveBtn == 1 && nPageFirst != 1)
            {
                ChangePageBtn(-1); // смещаем страницы влево на -1                
                nPageCurrent = Convert.ToInt32(button1.Text); // или nActiveBtn
                SetPageBtn(1);
            }
            // передаем данные для UserControl новой страницу с товарами
            ShowCurrentPage();

            if (nPageCurrent == 1 && nPageFirst == 1)
                LeftBtn.Enabled = false;
            RightBtn.Enabled = false;
            if (nPageFirst + 4 < nPageAll)
                RightBtn.Enabled = true;
        }

        private void RightBtn_Click(object sender, EventArgs e)
        {
            // вычисляем начальный номер товара на следующей странице
            if (nPageCurrent < nPageAll)
            {
                nPageCurrent++;
                if (nActiveBtn < 5)
                {
                    SetPageBtn(nPageCurrent);
                    nActiveBtn++;
                }
                else if (nActiveBtn == 5)
                {
                    ChangePageBtn(1);
                }
            }
            else
                RightBtn.Enabled = false;

            // передаем данные для UserControl новой страницу с товарами
            ShowCurrentPage();

            // делаем кнопку "налево" активной
            LeftBtn.Enabled = true;
        }
        void ChangePageBtn(int d)
        {
            if (nPageAll < 5)
            {
                for (int i = nPageAll; i < 5; i++)
                {
                    btnsList[i].Enabled = false;
                }
            }

            for (int i = 0; i < 5; i++)
            {
                int n = Convert.ToInt32(btnsList[i].Text) + d;
                if (n < 1) return;
                btnsList[i].Text = n.ToString();
            }
            nPageFirst = Convert.ToInt32(btnsList[0].Text);
        }
    }
}
    
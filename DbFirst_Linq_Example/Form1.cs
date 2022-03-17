using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbFirst_Linq_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NorthwindEntities db = new NorthwindEntities();
        //Db'yı daha rahat kullanabilmek için nesnemin içine atım
        private void btnExample_1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Categories.ToList();
        }

        private void btnExample_2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Products.Select(x => new
            {
                x.ProductID,
                x.ProductName,
                x.UnitPrice,
                x.UnitsInStock,
                x.CategoryID
            }).ToList();
        }

        private void btnExample_3_Click(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = db.Employees.Where(x => x.EmployeeID >= 5 && x.EmployeeID <= 8)
            //                                       .Select(x => new
            //                                       {
            //                                           x.EmployeeID,
            //                                           x.FirstName,
            //                                           x.LastName
            //                                       }).ToList();

            //Unit price 20 ile 50 arasında olan ürünlerin Id, Name, stock, Price bilgilerini getirin
            //dataGridView1.DataSource = db.Products.Where(x => x.UnitPrice > 20 && x.UnitPrice < 50)
            //                                      .Select(x => new
            //                                      {
            //                                          x.ProductID,
            //                                          x.ProductName,
            //                                          x.UnitPrice,
            //                                          x.UnitsInStock,
            //                                          x.CategoryID
            //                                      }).ToList();

            //Stok miktarı 16 yada 23 olan ürünlerin listeleyin
            dataGridView1.DataSource = db.Products.Where(x => x.UnitsInStock == 16 ||
                                                              x.UnitsInStock == 23)
                                                  .ToList();
        }

        private void btnExample_4_Click(object sender, EventArgs e)
        {
            //CategoryId'si 10'dan büyük olan ilk kaydı getirir. Şayet kaydı bulamazsa exception fırlatır bu sebepten ötürü First kullanırken bir emniyet yapısınu muhakka düşünmeliyiz.
            //dataGridView1.DataSource = db.Categories.First(x => x.CategoryID > 15); //Veri tabanında ID'si 15'den büyük olamayan kategori bulunmadığından dolayı exception yedik.

            //Yukarıdaki sebepten ötürü First kullnırken try catch bloğunda kullanmalıyız.

            try
            {
                Category category = db.Categories.First(x => x.CategoryID > 20); //Burada CategoyID'si 21'dan büyük olan ilk kaydı bana getirecek

                MessageBox.Show($"Id: {category.CategoryID}\nName: {category.CategoryName}");
            }
            catch (Exception)
            {
                MessageBox.Show("Aradığınız kategori bulunmamaktadır..!");
            }
        }

        private void btnExample_5_Click(object sender, EventArgs e)
        {
            //FirstorDefault, First mantığında çalışır lakin kayıt bulamadığında exception fırlatmaz. Default değer getirir.

            Category category = db.Categories.FirstOrDefault(x => x.CategoryID > 27);

            if (category == null)
                MessageBox.Show("Aradığınız kategori bulunmamaktadır..!");
            else
                MessageBox.Show($"Id: {category.CategoryID}\nName: {category.CategoryName}");
        }

        private void btnExample_6_Click(object sender, EventArgs e)
        {
            //Find() => Unieq alanlar için kullanılaması tercih edilir. SQL Server'da en yaygın biricik alan Id'dir. Veri tabanın id bilgisinden faydalanarak böyle bir kayıt var mı yok mu diye bakmak istediğimizde tercih edebiliriz.

            Category category = db.Categories.Find(50);//bulamazsa null dönecektir. 

            if (category == null)
                MessageBox.Show("Aradığınız kategori bulunmamaktadır..!");
            else
                MessageBox.Show($"Id: {category.CategoryID}\nName: {category.CategoryName}");
        }

        private void btnExample_7_Click(object sender, EventArgs e)
        {
            //Take() fonksiyon çalışma mantığını TOP benzetebiliiriz. Take fonksiyonu verilen parametre değeri kadar sorgu sonucunda dönen veri kümesinden veri döner.

            dataGridView1.DataSource = db.Employees.Take(5).ToList();

            //Birim fiyatı en yüksek olan ürünlerin ilk 5 tansini getirin
            dataGridView1.DataSource = db.Products.OrderByDescending(x => x.UnitPrice).Take(5).ToList();
        }

        private void btnExample_8_Click(object sender, EventArgs e)
        {
            //Skip() fonksiyonu içerisine verilen değer kadar satırı görmezden gelir.
            dataGridView1.DataSource = db.Products.OrderByDescending(x => x.UnitPrice)
                                                  .Skip(5)
                                                  .Take(5)
                                                  .ToList();
        }

        private void btnExample_9_Click(object sender, EventArgs e)
        {
            //Contains(), bir ifade içerisinde bir harften geçiyor mu diye bakmamıza yaraa.

            //İçerisinde a harf geçen çalışanlarımı a'dan z'ye listeleyinz.
            dataGridView1.DataSource = db.Employees.Where(x => x.FirstName.Contains("a"))
                                                   .OrderBy(x => x.FirstName)
                                                   .Select(x => new
                                                   {
                                                       x.EmployeeID,
                                                       x.FirstName,
                                                       x.LastName,
                                                       x.Title
                                                   }).ToList();
        }

        private void btnExample_10_Click(object sender, EventArgs e)
        {
            //StartWith() => İçerisine verilne harf ile başlayıp başlamadığını kontrol eder.

            dataGridView1.DataSource = db.Employees.Where(x => x.FirstName.StartsWith("R"))
                                                   .Select(x => new
                                                   {
                                                       x.EmployeeID,
                                                       x.FirstName,
                                                       x.LastName,
                                                       x.Title
                                                   }).ToList();
        }

        private void btnExample_11_Click(object sender, EventArgs e)
        {
            //EndWith() => Verilen parametre ile bitip bitmeidğine bakar
            dataGridView1.DataSource = db.Products.Where(x => x.ProductName.EndsWith("c"))
                                                  .OrderBy(x => x.ProductName)
                                                  .Select(x => new
                                                  {
                                                      x.ProductID,
                                                      x.ProductName,
                                                      x.UnitPrice,
                                                      x.UnitsInStock
                                                  }).ToList();
        }

        private void btnExample_12_Click(object sender, EventArgs e)
        {
            //Any() => Verilen değere göre tabloda kayıt var mı yok mu diye bakar. 

            bool result = db.Categories.Any(x => x.CategoryName == "SeaFood");

            if (result)
                MessageBox.Show("Aradığınız kategori bulunmaktadır..!");
            else
                MessageBox.Show("Aradığınız kategori bulunmamaktadır..!");
        }

        private void btnExample_13_Click(object sender, EventArgs e)
        {
            //Count() => SQL'deki mantığında çalışır
            int productCount = db.Products.Count();
            MessageBox.Show($"Count of Product: {productCount}");
        }

        private void btnExample_14_Click(object sender, EventArgs e)
        {
            //SUM() => SQL'deki mantığı ile aynı şekilde çalışır

            int? stock = db.Products.Sum(x => x.UnitsInStock);

            MessageBox.Show($"Stock Condition: {stock}");
        }

        private void btnExample_15_Click(object sender, EventArgs e)
        {

            try
            {
                var max = db.Products.Max(x => x.ProductID).ToString(); //Burada CategoyID'si 21'dan büyük olan ilk kaydı bana getirecek

                MessageBox.Show($"Id'sı en yüksek olan ürün : {max}");
            }
            catch (Exception)
            {
                MessageBox.Show("Yokki....!!");
            }
            
        }


    }
}

using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kutuphane_Otomasyon
{
    public class Connection
    {
     //   public SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Projeler\C#\Kutuphane_Otomasyon\Kutuphane_Otomasyon\Kutuphane_Otomasyon\bin\Debug\net5.0-windows7.0\DataBase\SQLKutuphane.mdf;Integrated Security=True;Connect Timeout=30");

       public SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Kütüphane Takip Programı\DataBase\SQLKutuphane.mdf;Integrated Security=True;Connect Timeout=30");




    }
}


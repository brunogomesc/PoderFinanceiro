using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoderFinanceiro.Service
{
    public class Icons
    {

        public static ImageList ListIconsImageList()
        {
            ImageList imageList = new ImageList();
            imageList.Images.Add("add", Properties.Resources.add);
            imageList.Images.Add("categories", Properties.Resources.categories);
            imageList.Images.Add("wallet_add", Properties.Resources.wallet_add);
            imageList.Images.Add("wallet_minus", Properties.Resources.wallet_minus);
            imageList.Images.Add("sub", Properties.Resources.sub);

            return imageList;

        }

        public static ListViewItem[] ListIconsViewItem()
        {
            ListViewItem add = new ListViewItem("Adicionar", "add");
            ListViewItem categories = new ListViewItem("Categoria", "categories");
            ListViewItem wallet_add = new ListViewItem("Adicionar Ganhos", "wallet_add");
            ListViewItem wallet_minus = new ListViewItem("Adicionar Despesas", "wallet_minus");
            ListViewItem sub = new ListViewItem("Subcategoria", "sub");


            ListViewItem[] listViewIcons = { 
                add, 
                categories, 
                wallet_add,
                wallet_minus,
                sub
            };

            return listViewIcons;
        }

    }
}

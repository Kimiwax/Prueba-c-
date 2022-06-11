using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Guia7_KevinArias
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        int precioDelProductoSeleccionado;
        int total = 0;
        int totalAPagar = 0;
  
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = listBox1.SelectedIndex;
            label1.Text = listBox1.Items[indice].ToString();
            label3.Text = Convert.ToString(totalAPagar);

       
            switch (indice)
            {
                case 0:
                    lbl_ProductoSeleccionado.Text = "Precio por kg: $" + 80 + " ";
                    break;

                case 1:
                    lbl_ProductoSeleccionado.Text = "Precio por kg: $" + 60 + " ";
                    
                    break;
                case 2:
                   
                    lbl_ProductoSeleccionado.Text = "Precio por kg: $" + 100 + " ";
                    break;
                case 3:
                   
                    lbl_ProductoSeleccionado.Text = "Precio por kg: $" + 110 + " ";
                    break;
                case 4:
                   
                    lbl_ProductoSeleccionado.Text = "Precio por kg: $" + 55 + " ";
                    break;
                case 5:
               
                    lbl_ProductoSeleccionado.Text = "Precio por kg: $" + 75 + " ";
                    break;
                case 6:
                   
                    lbl_ProductoSeleccionado.Text = "Precio por kg: $" + 40 + " ";
                    break;
                case 7:
              
                    lbl_ProductoSeleccionado.Text = "Precio por kg: $" + 150 + " ";
                    break;

            }

        }

        public void btn_agregarProductos_Click(object sender, EventArgs e)
        {
            int indice = listBox1.SelectedIndex;
            string cantidad = Convert.ToString(nud_cantidad);
            listBox2.Items.Add(listBox1.Items[indice].ToString() + " " + nud_cantidad.Text + " Kg");

            PrecioProductos(indice); //se asignan precio dependiendo posicion de indice
            
         
        }

        public void PrecioProductos(int val)
        {
            switch (val)
            {
                case 0:
                    precioDelProductoSeleccionado = 80;
                    sumaDeTotal(ref precioDelProductoSeleccionado);

                    break;
                case 1:
                    precioDelProductoSeleccionado = 60;
                    sumaDeTotal(ref precioDelProductoSeleccionado);
                    break;
                case 2:
                    precioDelProductoSeleccionado = 100;
                    sumaDeTotal(ref precioDelProductoSeleccionado);
                    break;
                case 3:
                    precioDelProductoSeleccionado = 110;
                    sumaDeTotal(ref precioDelProductoSeleccionado);
                    break;
                case 4:
                    precioDelProductoSeleccionado = 55;
                    sumaDeTotal(ref precioDelProductoSeleccionado);
                    break;
                case 5:
                    precioDelProductoSeleccionado = 75;
                    sumaDeTotal(ref precioDelProductoSeleccionado);
                    break;

                case 6:
                    precioDelProductoSeleccionado = 40;
                    sumaDeTotal(ref precioDelProductoSeleccionado);
                    break;

                case 7:
                    precioDelProductoSeleccionado = 150;
                    sumaDeTotal(ref precioDelProductoSeleccionado);
                    break;
            }


        }







        public void sumaDeTotal(ref int val1)
        {   
            total = total + (val1 * Convert.ToInt32( nud_cantidad.Text));
            //totalAPagar = total;
            lbl_total.Text = "$ " + Convert.ToString(total);
            totalAPagar = total;
        }

        private void btn_Pagar_Click(object sender, EventArgs e)
        {
            List<string> lista = new List<string>();
            foreach (object item in listBox2.Items)
            {
                lista.Add(Convert.ToString(item));
                

            }
            frm_Pago MetodoPagocs = new frm_Pago(lista,totalAPagar);
            MetodoPagocs.ShowDialog();
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargarInfo_Click(object sender, EventArgs e)
        {
            int[] numeros = new int[100];

            for (int i = 0; i<100; i++)
            {
                numeros[i] = (i+1);
            }

            cbTodos.Items.Clear();
            cbMultiplos4.Items.Clear();
            cbMultiplos10.Items.Clear();
            cbMultiplos3.Items.Clear();
            cbImpares.Items.Clear();


            var todos = from valor in numeros
                        orderby valor descending
                        select valor;
            foreach (var valor in todos)
            {
                cbTodos.Items.Add(valor);
            }

            var multiplos4 = from valor in numeros
                             where valor % 4 == 0
                             orderby valor descending
                            select valor;
            foreach (var valor in multiplos4)
            {
                cbMultiplos4.Items.Add(valor);
            }

            var multiplos10 = from valor in numeros
                             where valor % 10 == 0
                             orderby valor descending
                             select valor;
            foreach (var valor in multiplos10)
            {
                cbMultiplos10.Items.Add(valor);
            }

            var multiplos3 = from valor in numeros
                             where valor % 3 == 0
                             orderby valor descending
                             select valor;
            foreach (var valor in multiplos3)
            {
                cbMultiplos3.Items.Add(valor);
            }

            var impares = from valor in numeros
                             where valor % 2 != 0
                             orderby valor descending
                             select valor;
            foreach (var valor in impares)
            {
                cbImpares.Items.Add(valor);
            }
        }
    }
}

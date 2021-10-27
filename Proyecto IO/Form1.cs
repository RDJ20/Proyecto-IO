using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_IO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        int V = 0;
        int ren = 1, col = 0;
        int var, rest, Dmenor = 0, g;
        int Colpivote = 0;
        bool M;
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NumRestricciones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //====================================================
            // Creamos 1 varible 
            
            double ele;
            // elpib es la variable que almacena el valor pivote 
            double elpib = Convert.ToDouble(dgv1[col, ren].Value);
            // como ren es el renglon donde sta el valor pivote va a evaluar todo ese renglon 
            for (int i = 0; i < rest + var + 2; i++)
            {
                // ele se va a convertir en cada valor del renglon donde esta el valor pivote
                ele = Convert.ToInt32(dgv1[i, ren].Value);
                // aqui se divide cada valor del renglon por el valor de elpib para sustituirlo 
                dgv1[i, ren].Value = (ele / elpib).ToString("0.##");
            }
            //=====================================================


           
           //======================================================
            Dmenor *= -1;
            // nColumn va a ser igual al numero de columnas 
            int nColumnas = dgv1.ColumnCount;
            // nRenglon va a ser igual al numero de renglones 
            int nRenglo = dgv1.RowCount;


            double[] rPiv = new double[nColumnas];
            for (int i = 0; i < nColumnas; i++)
                // Multiplica todo el renglon pivote por -1
                rPiv[i] = Convert.ToDouble(dgv1[i, ren].Value) * Dmenor;
            // Cambiar todos los valores de la tabla por los valores que resultaron de la multiplicacion anterior (Por menos 1)
            for (int i = 0; i < nColumnas; i++)
                dgv1[i, 0].Value = Convert.ToDouble(dgv1[i, 0].Value) + rPiv[i];

            //  Checar va a ser igual al numero de columnas 
            double[] Checar = new double[nColumnas];
            //  colPivo va a ser igual al numero de renglones 
            double[] colPivo = new double[nRenglo];
            //  nrenPivo va a ser igual al numero de columnas 
            double[] nrenPivo = new double[nColumnas];

            // guarda todos los valores de la columna pivote en un array
            for (int i = 0; i < nRenglo; i++)
            {
                colPivo[i] = Convert.ToDouble(dgv1.Rows[i].Cells[col].Value);
            }

            // guarda todos los valores del renglon pivote en un array
            for (int i = 0; i < nColumnas; i++)
            {
                nrenPivo[i] = Convert.ToDouble(dgv1.Rows[ren].Cells[i].Value);
            }

            double nrpiv = 0;
            int conta = 1;
            int y = 0, z = 0;
            // elePiv va a ser igual al valor pivote
            double elePiv = Convert.ToDouble(dgv1[col, ren].Value);

            for (int i = 1; i < nRenglo; i++)
            {
                y = 0;
                for (int j = 0; j < nColumnas; j++)
                {
                    // Va a afcetra a todas las celdas que no pertenezcan al renglon pivote
                    if (i != ren)
                    {
                        //nrpiv va a  ser igual al valor del array de la columna pivote por menos uno 
                        nrpiv = colPivo[i] * -1;
                        // Multiplica el valor de la columna por el valor del renglon 
                        Checar[y] = nrpiv * nrenPivo[y];
                        // Esta sumando os valores que le dio chcar con e resto de filas
                        dgv1[j, i].Value = Checar[y] + Convert.ToDouble(dgv1[j, i].Value);
                        // "Y" aumneta para revisar toda la tabla
                        y++;
                    }
                }
                conta++;
            }

            double numero = 0.0;
            for (int i = 0; i < nColumnas; i++)
            {
                // recorre toda la primera fila para encontrar un numero negativo
                numero = Convert.ToDouble(dgv1.Rows[0].Cells[i].Value);
                // si el numero es menor a cero esntones es negativo
                if (numero < 0)
                {
                    // si hay algun valor negativo va a convertir M a verdadero
                    M = true;
                    break;
                }
                V++;
            }
            //===============================================================


            //===============================================================
            // limpia todo los items que hay en la caja de soluciones
            listBox1.Items.Clear();


            double[] nuevaCpivote = new double[dgv1.RowCount];
            double[] sol = new double[dgv1.RowCount];
            double[] resultado = new double[dgv1.RowCount];
            // Si hay algun numero negatov en la primera fila entonces que entre al if 
            if (M == true)
            {
                // Cambia todos los colores a blanco 
                for (int i = 0; i < dgv1.RowCount; i++)
                {
                    for (int j = 0; j < dgv1.ColumnCount; j++)
                    {
                        dgv1.Rows[i].Cells[j].Style.BackColor = Color.White;
                    }
                }


                for (int i = 0; i < dgv1.RowCount; i++)
                {
                    nuevaCpivote[i] = Convert.ToDouble(dgv1.Rows[i].Cells[V].Value);
                }
                for (int i = 0; i < dgv1.RowCount; i++)
                {
                    dgv1.Rows[i].Cells[V].Style.BackColor = Color.Green;
                }
                for (int i = 0; i < sol.Length; i++)
                {
                    sol[i] = Convert.ToDouble(dgv1.Rows[i].Cells[dgv1.ColumnCount - 1].Value);
                }
                for (int i = 0; i < resultado.Length; i++)
                {
                    resultado[i] = sol[i] / nuevaCpivote[i];
                }
                double peque = 999999.99;
                for (int i = 1; i < resultado.Length; i++)
                {
                    if (resultado[i] < peque)
                    {
                        peque = resultado[i];
                    }
                }
                int t;
                for (t = 0; t < dgv1.RowCount; t++)
                {
                    if (peque == resultado[t])
                        break;
                }
                for (int i = 0; i < dgv1.ColumnCount; i++)
                {
                    dgv1.Rows[t].Cells[i].Style.BackColor = Color.Yellow;
                }
                dgv1.Rows[t].Cells[V].Style.BackColor = Color.Red;
                double nElementoPivote = Convert.ToDouble(dgv1.Rows[t].Cells[V].Value);
                int s = 0;
                int ncdt = dgv1.ColumnCount;
                int nrdt = dgv1.RowCount;
                double vari;
                for (int i = 0; i < ncdt; i++)
                {
                    vari = Convert.ToDouble(dgv1.Rows[t].Cells[i].Value);
                    dgv1.Rows[t].Cells[i].Value = (vari / nElementoPivote).ToString("0.##");
                }
                double ch;
                double[] Pri = new double[dgv1.ColumnCount];
                double[] Jir = new double[dgv1.ColumnCount];
                for (int i = 0; i < Jir.Length; i++)
                {
                    Jir[i] = Convert.ToDouble(dgv1.Rows[t].Cells[i].Value);
                }
                for (int i = 0; i < dgv1.RowCount; i++)
                {
                    s = 0;
                    for (int j = 0; j < dgv1.ColumnCount; j++)
                    {
                        if (i != t)
                        {
                            ch = nuevaCpivote[i] * -1;
                            Pri[s] = ch * Jir[s];
                            dgv1[j, i].Value = (Pri[s] + Convert.ToDouble(dgv1[j, i].Value)).ToString("0.##");
                            s++;
                        }
                    }
                }


                listBox1.Items.Add("Z= " + dgv1.Rows[0].Cells[dgv1.ColumnCount - 1].Value);
                for (int i = 1; i < (var + 1); i++)
                {
                    listBox1.Items.Add("X" + i + "= " + dgv1.Rows[i].Cells[dgv1.ColumnCount - 1].Value);
                }
            }
            else
            {
                listBox1.Items.Add("Z= " + dgv1.Rows[0].Cells[dgv1.ColumnCount - 1].Value);
                for (int i = 1; i < (var + 1); i++)
                {
                    listBox1.Items.Add("X" + i + "= " + dgv1.Rows[i].Cells[dgv1.ColumnCount - 1].Value);
                }
            }
            //==========================================================================================
        }

        private void CrearTabla_MouseHover(object sender, EventArgs e)
        {
            CrearTabla.BackColor = Color.FromArgb(5, 242, 175);
            CrearTabla.ForeColor = Color.Black;
        }

        private void CrearTabla_MouseLeave(object sender, EventArgs e)
        {
            CrearTabla.BackColor = Color.OrangeRed;
            CrearTabla.ForeColor = Color.White;
        }

        private void CrearTabla_MouseEnter(object sender, EventArgs e)
        {
            CrearTabla.BackColor = Color.FromArgb(5, 242, 175);
            CrearTabla.ForeColor = Color.Black;
        }

       

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CrearTabla_Click(object sender, EventArgs e)
        {
            try
            {
                //===========PARA HACER TABLAS===============
                // Limpia la tabla de haber datos anteriores
                dgv2.Rows.Clear();
                dgv2.Rows.Clear();
                dgv2.Columns.Clear();
                dgv1.Rows.Clear();
                dgv1.Columns.Clear();
                ;
                // Convirte el texto de los ComboBox en numeros
                int v = Convert.ToInt32(NumVariables.Text);
                int r = Convert.ToInt32(NumRestricciones.Text);

                //Le dice a la Tabla el numero de variables y restricciones que hay 
                dgv2.ColumnCount = v;
                dgv2.RowCount = r + 1;

                //Crea las columnas y por ultimo 
                for (int i = 0; i < v; i++)
                    dgv2.Columns[i].Name = ("X" + (i + 1));
                dgv2.Rows[0].HeaderCell.Value = "Max Z =";

                //Creamos un item para las ondas de maximizacion y minimizacion
                DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
                cmb.Items.Add("<=");
                cmb.Items.Add(">=");
                cmb.Items.Add("=");
                cmb.HeaderText = "";
                cmb.Width = 70;

                //Añadimos ese item a cada renglon de restricciones excepto e primero 
                dgv2.Columns.Add(cmb);

                // Agregamos los nombres de las restricciones aqui en cada fila
                for (int i = 1; i <= r; i++)
                    dgv2.Rows[i].HeaderCell.Value = "Rest. " + i;

                //Ajustamos el tama;o a 50 aqui de cada columna
                for (int i = 0; i < v; i++)
                    dgv2.Columns[i].Width = 50;
                //Cambia el tama;o de las descripcion de las restricciones a 90 pa que se pueda ver
                dgv2.RowHeadersWidth = 90;

                //Añade la columna de Resultados al final 
                dgv2.Columns.Add("Result", "Result");


                // Pone el valor de la celda de resultado en 0 y lo bloquea para que no se pueda cambiar
                dgv2.Rows[0].Cells[v + 1].Value = "0";
                dgv2.Rows[0].Cells[v].ReadOnly = true;

                //Creo que aqui es donde le pone a todas las filas el "<=" como predeterminado
                for (int i = 1; i <= r; i++)
                    dgv2.Rows[i].Cells[v].Value = "<=";
            }
            catch
            {
                MessageBox.Show("INGRESA VALORES");
            }
        }

        private void Solucion_Click(object sender, EventArgs e)
        {
            //===========PARA HACER TABLAS===============
            try
            { 
            //Limpia la tabla de haber datos anteriores
            dgv1.Rows.Clear();

            //Pone las varibales "var" y "rest"con los valores de los combobox
            var = Convert.ToInt32(NumVariables.Text);
            rest = Convert.ToInt32(NumRestricciones.Text);

            //En la tabla dgv1 pone el numero de columnas que va a haber, que serian el numero de variables mas restricciones mas 2 columnas que son a de Z y solucion
            dgv1.ColumnCount = (1 + var + rest + 1);
            dgv1.Columns[0].Name = "Z";

            // Le pone nombre a todas las columnas de X, X1 X2 X3...
            for (int i = 1; i <= var; i++)
                dgv1.Columns[i].Name = ("X" + i);

            //Le poner nombre a todas las columnas de S, S1 S2 S3...
            for (int i = 1; i <= rest; i++)
                dgv1.Columns[i + var].Name = ("S" + i);

            //Le pone nombre a la columna de solucion
            dgv1.Columns[var + rest + 1].Name = "Solucion";

            //Pone el numero de filas de la tabla igual al numero de restricciones pero mas 1 
            dgv1.RowCount = rest + 1;

            //A la primera casilla le llama Z
            dgv1.Rows[0].HeaderCell.Value = "Z";

            //Nombra el resto de las filas de S, S1 S2 S3...
            for (int i = 1; i <= rest; i++)
                dgv1.Rows[i].HeaderCell.Value = "S" + i;

            //Cambia el tama;o de las colmunas de las variables y variables de holgura a 40
            for (int i = 0; i <= rest + var; i++)
                dgv1.Columns[i].Width = 40;

            //Cambia el tama;o de la colmna de solucion 
            dgv1.Columns[var + rest + 1].Width = 60;

            // Cambia el tamaño de las filas a 50
            dgv1.RowHeadersWidth = 50;



             // ========= OPERACIONES DE PROGRAMACION LINEAL QUE NO ENTIENDO ===========

             //[*]Crea un Array para almacenar varias Valores
             //[*]En el For toma las primeras 3 celdas de la primera fila 
             //y las vuelve negativas para ponerlas en la en la tabla de soluciones
            int[] z = new int[var];
            for (int i = 0; i < var; i++)
                z[i] = (Convert.ToInt32(dgv2.Rows[0].Cells[i].Value) * -1);

            //Vuele la primera celda a valor 1 
            dgv1.Rows[0].Cells[0].Value = 1;

            // Aqui coloca los valores que saco antes en la tabla
            for (int i = 0; i < var; i++)
            {
                dgv1[i + 1, 0].Value = z[i];
            }

            //Ayuda a poner los valores que no queremos en 0 
            for (int i = (var + 1); i < (rest + var + 2); i++)
            {
                dgv1[i, 0].Value = 0;
            }

            //Setea los valores de las columnas de las variables 
           for (int i = 0; i < rest; i++)
            {
                for (int j = 0; j < var; j++)
                {
                    dgv1[j + 1, i + 1].Value = dgv2[j, i + 1].Value;
                }
            }

           // Pone los valores de la primera columna Z
            for (int i = 0; i < rest; i++)
            {
                dgv1[0, i + 1].Value = 0;
            }

            // Pone los valores de las columnas de las variables de holgura o sea los 1
            for (int i = 0; i < rest; i++)
            {
                for (int j = 0; j < rest; j++)
                {
                    if (i == j)
                        dgv1[j + (var + 1), i + 1].Value = 1;
                    else
                        dgv1[j + (var + 1), i + 1].Value = 0;
                }
            }

            // Toma los valores de los totales de las restricciones y los pone en la tabla
            for (int i = 0; i < rest; i++)
            {
                dgv1[var + rest + 1, i + 1].Value = dgv2[var + 1, i + 1].Value;
            }


            
            // Declara un numero ejemplo que sera el menor 
                Dmenor = 999;
                // la variable num servira para obtener los datos de la tabla
                int num;
                // Aqui recorremos la segunda tabla para encontrar el numero menor con el for 
                for (int i = 0; i < (rest + var + 2); i++)
                {
                    // Tomamos cada celda de la segunda tabla y sera ahora num
                    num = Convert.ToInt32(dgv1[i, 0].Value);
                    // si num (Que es un valor de la tabla es menor a Dmenor entonces ahora es el nuevo menor)
                    if (num < Dmenor)
                        Dmenor = num;
                }

                // Pinta la columna de rojo y selecciona los numeros de los valores mas negativos 
                for (int i = 0; i < (rest + var + 2); i++)
                {
                    if (Convert.ToInt32(dgv1[i, 0].Value) == Dmenor)
                    {
                        dgv1.Columns[i].DefaultCellStyle.BackColor = Color.Red;
                        break;
                    }
                    Colpivote++;
                    // Col aumenta para indicarnos en que columna esta el valor pivote
                    col++;
                }




                //Pinta las filas de amarillo indicando la fila pivote  y tambie indica donde esta el valor pivote
                int R = rest + var + 1;
                int n1, n2, S = 0;
                for (int i = 0; i < rest + 1; i++)
                {
                    n1 = Convert.ToInt32(dgv1[R, i].Value);
                    n2 = Convert.ToInt32(dgv1[col, i].Value);
                    if (n1 > 0 & n2 > 0)
                        S++;
                }
                double[] comp = new double[S];
                int M = 0;
                double ra = 0.0, r2 = 0.0;
                for (int i = 0; i < rest + 1; i++)
                {
                    ra = Convert.ToDouble(dgv1[R, i].Value);
                    r2 = Convert.ToDouble(dgv1[col, i].Value);
                    if (ra > 0 & r2 > 0)
                    {
                        //
                        comp[M] = ra / r2;
                        M++;
                    }
                }
                double and = 999999;
                for (int i = 0; i < comp.Length; i++)
                {
                    if (comp[i] < and)
                    {
                        and = comp[i];
                    }
                }
                g = 1;
                for (int i = 0; i < (rest + 1); i++)
                {
                    if (comp[i] == and)
                    {
                        dgv1.Rows[g].DefaultCellStyle.BackColor = Color.BlueViolet;
                        break;
                    }
                    g++;
                    // ren aumenta para indicarnos en que renglon esta el valor pivote
                    ren++;
                }
                dgv1.Rows[ren].Cells[col].Style.BackColor = Color.Yellow;






            }
            // Por si existe un error 
        catch (Exception)
            {
                MessageBox.Show("INGRESA VALORES");
            }

        }


    }
}





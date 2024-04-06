﻿using SistemaGestion.BSS;
using SistemaGestion.Modelos;
using SistemaGestion.VISTA.ClienteVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestion.VISTA.PedidoVistas
{
    public partial class PedidoEditarVista : Form
    {
        int idx = 0;
        Pedido p = new Pedido();
        PedidoBss bss = new PedidoBss();
        public PedidoEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void PedidoEditarVista_Load(object sender, EventArgs e)
        {
            p = bss.ObtenerPedidoIdBss(idx);
            textBox1.Text = p.IdCliente.ToString();
            dateTimePicker1.Value = p.Fecha;
            textBox2.Text = p.Total.ToString();
            textBox3.Text = p.Estado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p.IdCliente = IdClienteSeleccionado;
            p.Fecha = dateTimePicker1.Value;
            p.Total = Convert.ToDecimal(textBox2.Text);
            p.Estado = textBox3.Text;

            bss.EditarPedidoBss(p);
            MessageBox.Show("Datos Actualizados");
        }
        public static int IdClienteSeleccionado = 0;
        ClienteBss bsscliente = new ClienteBss();
        private void button3_Click(object sender, EventArgs e)
        {
            ClienteListarVista fr = new ClienteListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Cliente cliente = bsscliente.ObtenerClienteIdBss(IdClienteSeleccionado);
                textBox1.Text = cliente.Nombre;
            }
        }
    }
}

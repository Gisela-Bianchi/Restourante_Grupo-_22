﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Pedido
    {
        public Mesa NumeroMesa { get; set; }
        public int NumeroPedido { get; set; }
        
        public DateTime HoraPedido {  get; set; }

        public bool EstadoDelPedido { get; set; }
        public string Comentarios { get; set; }

        public DateTime HoraCierre { get; set; }

        public bool Facturado { get; set; }



        public List<Insumo> Insumos;

    }
}

using AppBlazor.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

public class ListaPedidos
{
    // Lista interna de pedidos
    private List<Pedido> pedidos = new List<Pedido>
    {
        new Pedido { idPedido = 1, cliente = "Juan Perez", fecha = DateTime.Now.AddDays(-2), estado = "Pendiente", total = 150 },
        new Pedido { idPedido = 2, cliente = "Maria Lopez", fecha = DateTime.Now.AddDays(-1), estado = "Enviado", total = 250 }
    };

    // Obtener todos los pedidos
    public List<Pedido> GetPedidos()
    {
        return pedidos;
    }

    // Obtener un pedido por ID
    public Pedido? GetPedido(int id)
    {
        return pedidos.FirstOrDefault(p => p.idPedido == id);
    }


    // Agregar un pedido
    public void AgregarPedido(Pedido pedido)
    {
        pedidos.Add(pedido);
    }

    // Actualizar un pedido
    public void ActualizarPedido(Pedido pedido)
    {
        var p = pedidos.FirstOrDefault(x => x.idPedido == pedido.idPedido);
        if (p != null)
        {
            p.cliente = pedido.cliente;
            p.fecha = pedido.fecha;
            p.estado = pedido.estado;
            p.total = pedido.total;
        }
    }

    // Eliminar un pedido
    public void EliminarPedido(int id)
    {
        var p = pedidos.FirstOrDefault(x => x.idPedido == id);
        if (p != null)
        {
            pedidos.Remove(p);
        }
    }
}

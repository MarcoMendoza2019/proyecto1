﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

public partial class AjedrezDBEntities : DbContext
{
    public AjedrezDBEntities()
        : base("name=AjedrezDBEntities")
    {
    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }

    public virtual DbSet<Carrito> Carritoes { get; set; }
    public virtual DbSet<Producto> Productoes { get; set; }
    public virtual DbSet<TipoProducto> TipoProductoes { get; set; }
    public virtual DbSet<InformacionUsuario> InformacionUsuarios { get; set; }
    public virtual DbSet<Noticia> Noticias { get; set; }
    public virtual DbSet<Noticia1> Noticia1 { get; set; }
}

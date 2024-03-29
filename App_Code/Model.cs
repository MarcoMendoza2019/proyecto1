﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

public partial class Carrito
{
    public int Id { get; set; }
    public string ClienteId { get; set; }
    public int ProductoId { get; set; }
    public int Cantidad { get; set; }
    public Nullable<System.DateTime> FechaCompra { get; set; }
    public bool IsInCart { get; set; }

    public virtual Producto Producto { get; set; }
}

public partial class InformacionUsuario
{
    public int Id { get; set; }
    public string GUId { get; set; }
    public string Nombre { get; set; }
    public string ApePaterno { get; set; }
    public string ApeMaterno { get; set; }
    public string Direccion { get; set; }
    public int CodigoPostal { get; set; }
}

public partial class Noticia
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public string Descripcion { get; set; }
    public System.DateTime FechaPublicacion { get; set; }
    public string Imagen { get; set; }
}

public partial class Noticia1
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public string Descripcion { get; set; }
    public string FechaPublicacion { get; set; }
    public string Imagen { get; set; }
}

public partial class Producto
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Producto()
    {
        this.Carritoes = new HashSet<Carrito>();
    }

    public int Id { get; set; }
    public int TipoId { get; set; }
    public string Nombre { get; set; }
    public Nullable<int> Precio { get; set; }
    public string Descripcion { get; set; }
    public string Image { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Carrito> Carritoes { get; set; }
    public virtual TipoProducto TipoProducto { get; set; }
}

public partial class TipoProducto
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public TipoProducto()
    {
        this.Productoes = new HashSet<Producto>();
    }

    public int Id { get; set; }
    public string Nombre { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Producto> Productoes { get; set; }
}

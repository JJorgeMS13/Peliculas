using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using PatronMvc.Models.Dao;

namespace PatronMvc.Models
{
    class MoviItems 
    {

        //Atributos
        long _Id;
        string _Titulo;
        DateTime _FechaEmision;
        string _Genero;
        decimal _Precio;

        public long Id { get { return _Id; } set { _Id = value; } }
        [Required]
        public string Titulo { get { return _Titulo; } set { _Titulo = value; } }
        public DateTime FechaEmision { get { return _FechaEmision; } set { _FechaEmision = value; } }
        [Required]
        public string Genero { get { return _Genero; } set { _Genero = value; } }
        [Range(1, 10000, ErrorMessage = "Debe ingresar un valor numerico")]
        public decimal Precio { get { return _Precio; } set { _Precio = value; } }
        [Required]
        public byte[] Imagen { get; set; }
    }
}

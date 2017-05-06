using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvetarioDoblementeEnlazado
{
    class Inventario
    {
        private Producto inicio, ultimo;


        /// <summary>
        /// Agregar un nuevo producto.
        /// </summary>
        /// <param name="nuevo">Objeto de tipo producto</param>
        public void agregar(Producto nuevo)
        {
            if (inicio == null)
                inicio = nuevo;
            else
                agregar(inicio, nuevo);
        }

        private void agregar(Producto last, Producto nuevo)
        {
            if (last.siguiente == null)
            {
                last.siguiente = nuevo;
                nuevo.anterior = last;
                ultimo = nuevo;
            }
            else
                agregar(last.siguiente, nuevo);
        }

        /// <summary>
        /// Buscar un producto.
        /// </summary>
        /// <param name="codigo">Código del producto que se va a buscar.</param>
        /// <returns></returns>
        public Producto buscar(int codigo)
        {
            Producto item = null, temp = inicio;
            while (temp.siguiente != null)
            {
                if (temp.codigo == codigo)
                {
                    return temp;
                }
                if (temp.siguiente.codigo == codigo)
                    item = temp.siguiente;
                temp = temp.siguiente;
            }
            return item;
        }

        /// <summary>
        /// Borra un producto por medio del código.
        /// </summary>
        /// <param name="codigo">Código del producto que se va a borrar.</param>
        public void borrar(int codigo)
        {
            Producto temp = inicio;

            if(temp.codigo == codigo)
            {
                if(temp.siguiente == null)
                {
                    inicio = temp.siguiente;
                }
                inicio = temp.siguiente;
            }
            else
            {
                while (temp.siguiente != null)
                {
                    if (temp.codigo == codigo)
                    {
                        inicio = temp.siguiente;
                        //temp = inicio;
                    }
                    else
                    {
                        if (temp.siguiente.codigo == codigo)
                        {
                            temp.siguiente = temp.siguiente.siguiente;
                            break;
                        }
                        temp = temp.siguiente;
                    }
                }
            }
            //while (temp.siguiente != null)
            //{
            //    if (temp.codigo == codigo)
            //    {
            //        inicio = temp.siguiente;
            //        //temp = inicio;
            //    }
            //    else
            //    {
            //        if (temp.siguiente.codigo == codigo)
            //        {
            //            temp.siguiente = temp.siguiente.siguiente;
            //            break;
            //        }
            //        temp = temp.siguiente;
            //    }
            //}
        }

        /// <summary>
        /// Agrega el producto al inicio de la lista.
        /// </summary>
        /// <param name="nuevo">Objeto producto que se va agregar a la lista.</param>
        public void agregarInicio(Producto nuevo)
        {
            nuevo.siguiente = inicio;
            inicio = nuevo;
        }

        /// <summary>
        /// Borra el primero objeto de lista.
        /// </summary>
        public void borrarInicio()
        {
            inicio = inicio.siguiente;
        }

        /// <summary>
        /// Elimina el ultimo objeto de la lista.
        /// </summary>
        public void borrarUltimo()
        {
            ultimo.anterior.siguiente = null;
            ultimo = ultimo.anterior; 
        }

        /// <summary>
        /// Inserta un objeto en la lista en la posicion que se desee.
        /// </summary>
        /// <param name="nuevo">Objeto de tipo producto.</param>
        /// <param name="posicion">Lugar en la lista que se va a insertar.</param>
        public void insertarProducto(Producto nuevo, int posicion)
        {
            Producto temp = inicio, antItem;
            int cont = 1;
            if (posicion == 1)
            {
                nuevo.siguiente = inicio;
                inicio = nuevo;
            }
            else
            {
                do
                {
                    antItem = temp;
                    temp = temp.siguiente;
                    cont++;
                } while (temp.siguiente != null || cont < posicion - 1);
                antItem.siguiente = nuevo;  //Error en antItem es igual a null y por eso no se puede igualar.
                nuevo.siguiente = temp;
            }
        }

        /// <summary>
        /// Regresa una cadena con todos los datos de los objetos guardados.
        /// </summary>
        /// <returns></returns>
        public string reporte()
        {
            string datos = "";
            Producto t = inicio;
            while (t != null)
            {
                datos += t.ToString() + Environment.NewLine;
                t = t.siguiente;
            }
            return datos;
        }

        /// <summary>
        /// Regresa una cadena con todos los datos de los objetos pero de forma invertida, 
        /// empezando por el ultimo objeto.
        /// </summary>
        /// <returns></returns>
        /// 
        public string reporteInvertido() 
        {
            string reporte = "";
            Producto temp = ultimo;
            if (temp == null)
                return reporte;
            else
                return reporteInv(temp);
        }

        private string reporteInv(Producto item)
        {
            if (item.anterior == null)
                return item.ToString() + Environment.NewLine;
            else
            {
                //return reporteInv(item.anterior) + item.ToString() + Environment.NewLine; //Esto regresa el reporte normal.
                return item.ToString() + Environment.NewLine + reporteInv(item.anterior); //Esto regresa el reporte invertido.
            }
        }

        //public int datos()
        //{
        //    Producto temp = inicio;
        //    return 0;
        //}
    }
}
